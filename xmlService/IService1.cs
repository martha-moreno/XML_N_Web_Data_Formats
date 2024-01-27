using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace xmlService
{
    
    [ServiceContract]
    public interface IService1
    {
        
        //Web operation “verification” takes the URL of an XML (.xml) file and the URL of the
        //corresponding XMLS (.xsd) file as input and validates the XML file against the
        //corresponding XMLS (XSD) file.
        [OperationContract]
         string verification(string xmlUrl, string xsdUrl);
        //Web operation “search” takes the URL of an XML (.xml) file and a key
        //(e.g., the element name Headquarter) as input. It returns the node’s content
        //information related to the search key, for example: cruise name, number, departure port, etc.

        [OperationContract]
        string search(string xmlUrl, string key);
    }

}
