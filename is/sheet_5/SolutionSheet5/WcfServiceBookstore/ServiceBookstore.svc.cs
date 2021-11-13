using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml;
namespace WcfServiceBookstore
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class ServiceBookstore : IServiceBookstore
    {
        string FILEPATH = AppDomain.CurrentDomain.BaseDirectory + @"App_Data\bookstore.xml";
        public void AddBook(Book newBook)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(FILEPATH);

            XmlNode parent = doc.SelectSingleNode("/bookstore");

            XmlElement book = doc.CreateElement("book");
            book.SetAttribute("category", newBook.Category.ToString());
            XmlElement title = doc.CreateElement("title");
            title.InnerText = newBook.Title;
            XmlElement author = doc.CreateElement("author");
            author.InnerText = newBook.Author;
            XmlElement year = doc.CreateElement("year");
            year.InnerText = newBook.Year.ToString();
            XmlElement price = doc.CreateElement("price");
            price.InnerText =Convert.ToString(newBook.Price, System.Globalization.NumberFormatInfo.InvariantInfo);
            book.AppendChild(title);
            book.AppendChild(author);
            book.AppendChild(year);
            book.AppendChild(price);
            parent.AppendChild(book);
            doc.Save(FILEPATH);
        }

        public bool DeleteBook(string title)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(FILEPATH);

            XmlNode parent = doc.SelectSingleNode("/bookstore");
            XmlNode book = doc.SelectSingleNode($"/bookstore/book[title='{title}']");
            if (book == null)
            {
                return false;
            }
            parent.RemoveChild(book);
            doc.Save(FILEPATH);
            return true;
        }

        public List<Book> GetBooks()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(FILEPATH);
         
            XmlNodeList books = doc.SelectNodes("/bookstore/book");
            List<Book> booksReceived = new List<Book>();

            foreach (XmlNode book in books)
            {
                Book bookNew = new Book();
                bookNew.Author = book["author"].InnerText;
                bookNew.Title = book["title"].InnerText;
                bookNew.Price = Convert.ToDouble(book["price"].InnerText, System.Globalization.NumberFormatInfo.InvariantInfo);
                bookNew.Year = int.Parse(book["year"].InnerText);
                bookNew.Category = (BookCategory) Enum.Parse(typeof(BookCategory),book.Attributes["category"].Value);
                booksReceived.Add(bookNew);
            }
            return booksReceived;
        }

        public List<Book> GetBooksByCategory(BookCategory category)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(FILEPATH);

            XmlNodeList books = doc.SelectNodes($"/bookstore/book[@category='{category}']");
            List<Book> booksReceived = new List<Book>();
            foreach (XmlNode book in books)
            {
                Book bookNew = new Book();
                bookNew.Author = book["author"].InnerText;
                bookNew.Title = book["title"].InnerText;
                bookNew.Price = Convert.ToDouble(book["price"].InnerText, System.Globalization.NumberFormatInfo.InvariantInfo);
                bookNew.Year = int.Parse(book["year"].InnerText);
                bookNew.Category = (BookCategory)Enum.Parse(typeof(BookCategory), book.Attributes["category"].Value);
                booksReceived.Add(bookNew);
            }
            return booksReceived;
        }

        public Book GetBookByTitle(string title)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(FILEPATH);

            XmlNode book = doc.SelectSingleNode($"/bookstore/book[title='{title}']");
            if (book == null)
            {
                return null;
            }
            Book bookNew = new Book();
            bookNew.Author = book["author"].InnerText;
            bookNew.Title = book["title"].InnerText;
            bookNew.Price = Convert.ToDouble(book["price"].InnerText, System.Globalization.NumberFormatInfo.InvariantInfo);
            bookNew.Year = int.Parse(book["year"].InnerText);
            bookNew.Category = (BookCategory)Enum.Parse(typeof(BookCategory), book.Attributes["category"].Value);

            
            return bookNew;
        }

        public string GetData(int value)
        {
            //return string.Format("You entered: {0}", value);
            return AppDomain.CurrentDomain.BaseDirectory;
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public Book[] GetBooksByTitle(string title)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(FILEPATH);

            XmlNodeList books = doc.SelectNodes($"/bookstore/book/title[contains(text(), '{title}')]/parent::book");
            Book[] booksReceived = new Book[books.Count]; 
            int i = 0;
            foreach (XmlNode book in books)
            {
                Book bookNew = new Book();
                bookNew.Author = book["author"].InnerText;
                bookNew.Title = book["title"].InnerText;
                bookNew.Price = Convert.ToDouble(book["price"].InnerText, System.Globalization.NumberFormatInfo.InvariantInfo);
                bookNew.Year = int.Parse(book["year"].InnerText);
                bookNew.Category = (BookCategory)Enum.Parse(typeof(BookCategory), book.Attributes["category"].Value);
                booksReceived[i] = bookNew;
                i++;
            }
            return booksReceived;
        }
    }
}
