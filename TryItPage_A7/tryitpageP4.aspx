<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="tryitpageP4.aspx.cs" Inherits="TryItPage_A7.tryitpageP4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblServiceText" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="#0000CC" Text="VERIFICATION SERVICE"></asp:Label>
            <br />
            <asp:Label ID="Label2" runat="server" Font-Bold="True" Text="Service Description:"></asp:Label>
            <asp:Label ID="Label3" runat="server" Text="Web operation &quot;verification&quot; takes the URL of an XML file and the URL of the corresponding XMLS(.xsd) file as input and validates the XML file against the corresponding XMLS (XSD) file."></asp:Label>
            <br />
            <br />
            <asp:Label ID="lbltextxml" runat="server" Text="Enter XML file URL:"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtXML" runat="server" Width="353px"></asp:TextBox>
&nbsp;
            <asp:Label ID="lblWarningXml" runat="server" ForeColor="Red" Text="lblWarningXml" Visible="False"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lbltextxsd" runat="server" Text="Enter Schema file URL:"></asp:Label>
            <asp:TextBox ID="txtUrl" runat="server" Width="355px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblWarningUrl" runat="server" ForeColor="Red" Text="lblWarningUrl" Visible="False"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnValidate" runat="server" Height="50px" OnClick="btnValidate_Click" Text="Validate" Width="230px" />
            <br />
            <br />
            <asp:Label ID="lbltext" runat="server" Font-Bold="True" Font-Size="Medium" Text="Validation Response:" Visible="False"></asp:Label>
            <asp:Label ID="lblWCF1Response" runat="server" Font-Bold="True" Font-Size="Medium" ForeColor="Red" Text="WCF1Response" Visible="False"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <br />
            <br />
            <asp:Label ID="lblServiceText0" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="#0000CC" Text="SEARCH SERVICE"></asp:Label>
            <br />
            <asp:Label ID="Label4" runat="server" Font-Bold="True" Text="Service Description:"></asp:Label>
            <asp:Label ID="Label5" runat="server" Text="Web operation &quot;search&quot; takes the URL of an XML (.xml) file and a key (e.g., the element name Headquarter) as input. It returns the node’s content information related to the search key."></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label6" runat="server" Text="Enter XML file URL:"></asp:Label>
            <asp:TextBox ID="txtxmlUrlPath" runat="server" Width="370px"></asp:TextBox>
&nbsp;<asp:Label ID="lblWarningXmlSearch" runat="server" ForeColor="Red" Text="lblWarningXmlSearch" Visible="False"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label7" runat="server" Text="Enter Key:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="ddKey" runat="server">
                <asp:ListItem>Cruises</asp:ListItem>
                <asp:ListItem>Cruise</asp:ListItem>
                <asp:ListItem>ParentCompany</asp:ListItem>
                <asp:ListItem>FoundedIn</asp:ListItem>
                <asp:ListItem>Name</asp:ListItem>
                <asp:ListItem>Reservation</asp:ListItem>
                <asp:ListItem>Phone</asp:ListItem>
                <asp:ListItem>Url</asp:ListItem>
                <asp:ListItem>Headquarters</asp:ListItem>
                <asp:ListItem>City</asp:ListItem>
                <asp:ListItem>State</asp:ListItem>
                <asp:ListItem>DeparturePorts</asp:ListItem>
                <asp:ListItem>Port</asp:ListItem>
                <asp:ListItem>Zip</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
&nbsp;<asp:Button ID="btnSearchXPath0" runat="server" Height="50px" OnClick="Button1_Click" Text="Search" Width="215px" />
            <br />
            <br />
            <asp:Label ID="Label8" runat="server" Font-Bold="True" Text="Node or Attribute Content:"></asp:Label>
            <asp:Label ID="lblContentResponse" runat="server" Font-Bold="True" ForeColor="#006600" Text="ContentResponse" Visible="False"></asp:Label>
            <br />
        </div>
    </form>
</body>
</html>
