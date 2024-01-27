using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TryItPage_A7
{
    public partial class tryitpageP4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //Btn Validate xml vs xsd
        protected void btnValidate_Click(object sender, EventArgs e)
        { 
            xmlService1Reference1.Service1Client service1Client = new xmlService1Reference1.Service1Client();//object instance to the service
            lblWCF1Response.Visible = false;
            string xmlUrl = txtXML.Text;//assign textbox xmlURL value to variable 
            string xsdUrl = txtUrl.Text;//assign textbox xsdURL value to variable 
            //condition to check entered URLs are valid
            if (Regex.IsMatch(txtXML.Text, "(https?:\\/\\/)?(www\\.)[-a-zA-Z0-9@:%._\\+~#=]{2,256}\\.[a-z]{2,4}\\b([-a-zA-Z0-9@:%_\\+.~#?&//=]*)|(https?:\\/\\/)?(www\\.)?(?!ww)[-a-zA-Z0-9@:%._\\+~#=]{2,256}\\.[a-z]{2,4}\\b([-a-zA-Z0-9@:%_\\+.~#?&//=]*)"))
            {
                if (Regex.IsMatch(txtUrl.Text, "(https?:\\/\\/)?(www\\.)[-a-zA-Z0-9@:%._\\+~#=]{2,256}\\.[a-z]{2,4}\\b([-a-zA-Z0-9@:%_\\+.~#?&//=]*)|(https?:\\/\\/)?(www\\.)?(?!ww)[-a-zA-Z0-9@:%._\\+~#=]{2,256}\\.[a-z]{2,4}\\b([-a-zA-Z0-9@:%_\\+.~#?&//=]*)"))
                {
                    //initial states for labels
                    lblWCF1Response.ForeColor = System.Drawing.Color.Red;
                    string validationResponse = service1Client.verification(xmlUrl, xsdUrl);//calling the verification service operation
                    lblWarningUrl.Visible = false;
                    lblWarningXml.Visible = false;
                    lblWCF1Response.Text = validationResponse;
                    lblWCF1Response.Visible = true;
                    if (validationResponse == "No Error")
                    {
                        lblWCF1Response.ForeColor = System.Drawing.Color.Green;
                        lblWCF1Response.Visible = true;
                        lbltext.Visible = true;
                    }
                }
                else
                {
                    lblWarningUrl.Text = "Please enter a valid Url";
                    lblWarningUrl.Visible = true;
                }
            }
            else
            {
                lblWarningXml.Text = "Please enter a valid Url";
                lblWarningXml.Visible = true;
            }
            
        }
        //Button for Search Service
        protected void Button1_Click(object sender, EventArgs e)
        {
            //initial state for variables
            lblWarningXmlSearch.Visible = false;
            lblContentResponse.Visible = false;
            xmlService1Reference1.Service1Client service1Client = new xmlService1Reference1.Service1Client();//object instance to service
            string xmlUrl=txtxmlUrlPath.Text;
            if(xmlUrl!="")//condition to check that xmlURl textbox is not empty
            { 
                string key = ddKey.Text;//assign value of key dropdown list to variable
                string result=service1Client.search(xmlUrl,key);//calling the search service operation
                lblContentResponse.Text = result;//Display result in label
                lblContentResponse.Visible = true;
            }
            else
            {
                lblWarningXmlSearch.Text = "Please enter an URL";
                lblWarningXmlSearch.Visible = true;
            }
        }
    }
}