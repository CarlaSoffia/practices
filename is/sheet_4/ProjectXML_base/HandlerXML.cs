using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;

namespace ProjectXML
{
    class HandlerXML
    {
        public HandlerXML(string xmlFile)
        {
            XmlFilePath = xmlFile;
        }

        public HandlerXML(string xmlFile, string xsdFile)
        {
            XmlFilePath = xmlFile;
            XsdFilePath = xsdFile;
        }

        public string XmlFilePath { get; set; }
        public string XsdFilePath { get; set; }

        private bool isValid = true;
        private string validationMessage = "Document valid against xsd";
        public string ValidationMessage
        {
            get { return validationMessage; }
        }

        //**********************************************
        // Ex. 7
        //**********************************************
        public List<string> GetTitles()
        {
            List<string> titles = new List<string>();
            XmlDocument doc = new XmlDocument();
            doc.Load(XmlFilePath);
            XmlNodeList nodes = doc.SelectNodes("/bookstore/book/title"); //xpath
            foreach (XmlNode node in nodes)
            {
                titles.Add(node.InnerText);
            }
            return titles;
        }
        //**********************************************
        // Ex. 8
        //**********************************************       
        public bool UpdateAuthorByTitle(string title, string author)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(XmlFilePath);
            XmlNode authorNode = doc.SelectSingleNode($"bookstore/book[title='{title}']/author"); //
            if (authorNode == null)
            {
                return false;
            }
            authorNode.InnerText = author;
            doc.Save(XmlFilePath);
            return true;
        } 

        //**********************************************
        // Ex. 9
        //**********************************************  
        public void AddRateToBook(string title, string rate)
        {
           
        }
        //**********************************************
        // Ex. 10 Add Attribute
        //**********************************************  
        public void AddAttributeISBNToBook(string title, string isbn)
        {
            
        }

        #region Ex. 6 - Validate XML with XML Schema (xsd)
        public bool ValidateXML()
        {
            isValid = true;
            XmlDocument doc = new XmlDocument();
            try
            {
                doc.Load(XmlFilePath);
                ValidationEventHandler eventHandler = new ValidationEventHandler(MyValidateMethod);
                doc.Schemas.Add(null, XsdFilePath);
                doc.Validate(eventHandler);
            }
            catch (XmlException ex)
            {
                isValid = false;
                validationMessage = string.Format("ERROR: {0}", ex.ToString());
            }
            return isValid;
        }

        private void MyValidateMethod(object sender, ValidationEventArgs args)
        {
            isValid = false;
            switch (args.Severity)
            {
                case XmlSeverityType.Error:
                    validationMessage = string.Format("ERROR: {0}", args.Message);
                    break;
                case XmlSeverityType.Warning:
                    validationMessage = string.Format("WARNING: {0}", args.Message);
                    break;
                default:
                    break;
            }
        }
        #endregion

        public int NumberBooksByCategory(string category)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(XmlFilePath);
            XmlNodeList booksNode = doc.SelectNodes($"bookstore/book[@category='{category}']");
            return booksNode.Count;
        }

        public String executeXPath(string xpath)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(XmlFilePath);
            XmlNodeList nodes = doc.SelectNodes($"{xpath}");
            string result = "";
            foreach (XmlNode node in nodes)
            {
                result += node.InnerText + Environment.NewLine;
            }
            return result;
        }
    }
}
