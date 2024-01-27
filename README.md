# Project 4
#CSE 598 Distributed Systems and Design
#Fall 2022
<img width="807" alt="Screenshot 2024-01-26 at 5 45 45 PM" src="https://github.com/martha-moreno/XML_N_Web_Data_Formats/assets/88118070/8935d386-4acc-4642-bf3f-4c8aeeaebcf9">




In this question, you will create a directory of cruise lines, which can be found through Google search.
For example, Carnival Cruise Line information can be found at: https://www.carnival.com/about-
carnival/about-us.aspx. The information will be represented as an XML tree. The diagram below
shows the required structure of the directory of Cruise Lines in XML tree notation that you will create
in this assignment. All the “Cruise” elements have the same structure. Notice that different shapes and
colors of boxes in the tree have different meanings. They represent elements, attributes, and text
contents/values, respectively. The structure of elements and attributes given in the diagram in Figure 1
must be implemented as described, while the given text contents/values in the diagram are example’s
instance values and can be different in your files. The solid arrows show parent-child element
relations, and the dotted arrows show the element-content relations. The optional attribute means that
the XML instance can have the attribute or not have the attribute, without causing a verification error
against its schema. However, it is still required to define the optional attribute in the XML Scheme
file. In the instances, you must provide the attribute for some cruises, but not for all cruises. For the
required attribute, you must provide this attribute for all the Headquarter element. For the Headquarter
element, you must allow one or multiple Headquarter elements. For each cruise, you must enter at
least two departure ports.

Write the Cruises.xsd file that defines the XML schema allowing the structure shown in Figure 1.
You can use any tool to create/edit the file. [10 points]
1.2 Create an XML file Cruises.xml as an instance of your schema file. Enter the information of at
least ten (10) real cruises into the Cruises.xml file. You can use any tool to edit the file. You must
include all the elements given in the XML tree. If an element has a Required attribute, you must
provide the attribute for each of the elements. If an element has an Implied (Optional) attribute, you
will provide this attribute for some elements, but not for all elements. The departure ports must have
at least two appearances. [10 points]
2. Develop a Web service (.svc) containing two of the Web operations listed below. The node
mentioned in the sub questions below includes every component (element, content, and attribute)
shown in the XML tree in question 1. You choose two (and only two) following operations to
implement. If you implement more than two operations, we will grade the first two operations only.
If you have implemented and submitted a service listed below in your project 3 as an elective
service, you cannot choose that service here. [20 points]
2.1 Web operation “verification” takes the URL of an XML (.xml) file and the URL of the
corresponding XMLS (.xsd) file as input and validates the XML file against the corresponding
XMLS (XSD) file. The Web method returns “No Error” or an error message showing the available
information at the error point. You must use the files that you created in this assignment, with and
without fault injection, as the test cases. However, your service operation should work for other test
cases (other XML file and its corresponding XSD file) too.
2.2 Web operation “search” takes the URL of an XML (.xml) file and a key (e.g., the element name
Headquarter) as input. It returns the node’s content information related to the search key, for
example: cruise name, number, departure port, etc. Your program must also read any attributes.
Attributes should be searched too. If there are multiple occurrences, you must return all of them. In
this question, you can use DOM or SAX model. In the GUI (Question 3), you can display them all
or once at a time through a “Display Next” button.
2.3 Web operation “XPathSearch” takes the URL of an XML (.xml) file and a path expression as input.
It returns the path expression value of the given path. It could be a list of nodes, the content value,
etc., depending on the path given.
2.4 Web operation “addCruise” modifies the XML file by adding a new cruise element into the XML
file. You can use multiple parameters or one parameter that contains all the information required for
adding a new cruise into the tree. The method must work for any tree that conforms with your XML
schema file. After the modification, the tree must be saved back to the file in App_Data in your
working directory. In the TryIt page (Question 3), the added contents must be demonstra
