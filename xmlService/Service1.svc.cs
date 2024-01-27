using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;
using System.IO;
using System.Xml.XPath;
using System.Web.UI.WebControls;
using System.Collections;
using System.CodeDom.Compiler;
using System.IO.Compression;
using System.Xml.Serialization;
using System.Runtime.Remoting.Messaging;
using System.Text.RegularExpressions;

namespace xmlService
{
    
    //This service has operations of verification and 
    public class Service1 : IService1
    {
        public static string result;
        public static List<string> results = new List<string>();
        public static  string response= "No Error";
       

        public string verification(string xmlUrl, string xsdUrl)
        {
            response = "No Error";
            
           
            XmlSchemaSet schema = new XmlSchemaSet();  //Create the XmlSchemaSet object
            schema.Add(null, xsdUrl); //Add the schema to the Schema set

            try
            {
                XmlReaderSettings settings = new XmlReaderSettings();//create an object of the XmlReaderSettings class
                settings.Schemas.Add(null, XmlReader.Create(xsdUrl));
                settings.ValidationType = ValidationType.Schema;//define the type of validation
                //settings.Schemas = schema;//associate the schema given to the settings
                settings.ValidationFlags |= XmlSchemaValidationFlags.ProcessInlineSchema;
                settings.ValidationFlags |= XmlSchemaValidationFlags.ReportValidationWarnings;
                settings.ValidationEventHandler += new ValidationEventHandler(ValidationCallBack);//call event handler in case of errors

                using (XmlReader reader = XmlReader.Create(xmlUrl, settings)) //Read the xml file
                {
                    while (reader.Read()) ;//while each line is being read with no errors
                   reader.Close();
                    
                }
                
            }
            catch (Exception error)
            {
                response=error.ToString();
            }
            return response; //return response
        }

       private static void ValidationCallBack(object sender, ValidationEventArgs e)
       {
            response = "Validation Failed.Message:" + e.Message; //if error occur, return error messsage

       }

        //Search Service
       public string search(string xmlUrl, string key)
       {

            XmlDocument xml = new XmlDocument();//create an instance to the XML document
            xml.Load(xmlUrl);//Load the xml document 
            
             if(key== "Zip")//Check if entered key is Zip(attribute)
            {
                results.Clear();//Clear string list for new search
                XmlNodeList list = xml.GetElementsByTagName("Headquarters");//Get Headquarters element nodes and put it on a list of type XmlNodeList
                for (int i=0; i<list.Count; i++)
                {
                   results.Add(list[i].Attributes["Zip"].InnerText);//add attribute "Zip" value from each element to a string list
                }
                result = String.Join(",", results); //list to string separated by commas
            }
             else if (key == "FoundedIn") //Check if entered key is FoundedIn(attribute)
            {
                results.Clear();
                XmlNodeList list = xml.GetElementsByTagName("Cruise");//get Cruise element nodes and put it in a list of type XmlNodelist
                foreach (XmlNode attr in list)
                {
                   if( attr.Attributes["FoundedIn"]!=null)//Only if there is an attribute "FoundedIn" in the element
                      results.Add(attr.Attributes["FoundedIn"].InnerText);//Add "FoundedIn" value from each element to a string list
                }
                    result = String.Join(",", results);     //list to string separated by commas        
            }
            else //any of the existent elements in the xml file
            {
                results.Clear();
                XmlNodeList list = xml.GetElementsByTagName(key);//Get the element nodes of the element entered in key dropdownlist
                for (int i = 0; i < list.Count; i++)
                {
                    results.Add(list[i].InnerText);    //add values to a string list               
                }
                result = String.Join(",", results); //list to string separated by commas
            }

            return result;//return string response separated by commas
       }

    }

    
    
}
