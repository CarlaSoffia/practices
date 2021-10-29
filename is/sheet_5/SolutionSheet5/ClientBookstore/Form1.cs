using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ClientBookstore.ServiceReferenceBookstore;

namespace ClientBookstore
{
    public partial class Form1 : Form
    {
        List<Book> books = new List<Book>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetBooks_Click(object sender, EventArgs e)
        {
            using (ServiceBookstoreClient service = new ServiceBookstoreClient())
            {
                books = service.GetBooks().ToList();
                listBoxBooks.DataSource = books;
                listBoxBooks.DisplayMember = "Title";
                listBoxBooks.ValueMember = "Title";

               }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxCategory.DataSource = Enum.GetValues(typeof(BookCategory));
            comboBoxCategoriesNew.DataSource = Enum.GetValues(typeof(BookCategory));
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            using (ServiceBookstoreClient service = new ServiceBookstoreClient())
            {
                Book book = new Book()
                {
                    Title = textBoxTitleNew.Text,
                    Author = textBoxAuthorNew.Text,
                    Price = Double.Parse(textBoxPriceNew.Text),
                    Year = int.Parse(textBoxYearNew.Text),
                    Category = (BookCategory)comboBoxCategoriesNew.SelectedItem
                };
               service.AddBook(book);
                MessageBox.Show("Book Added!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (ServiceBookstoreClient service = new ServiceBookstoreClient())
            {
                bool deleted = service.DeleteBook(textBoxTitleNew.Text);
                if (deleted) MessageBox.Show("Book was deleted!");
                else MessageBox.Show("Book was not deleted!");
            
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBoxTitleNew.Text = "";
            textBoxAuthorNew.Text = "";
            textBoxPriceNew.Text = "";
            textBoxYearNew.Text = "";
            comboBoxCategoriesNew.SelectedItem = BookCategory.WEB;
        }

        private void btnFilterCat_Click(object sender, EventArgs e)
        {
            using (ServiceBookstoreClient service = new ServiceBookstoreClient())
            {
                
                listBoxBooks.DataSource = service.GetBooksByCategory((BookCategory) comboBoxCategory.SelectedItem).ToList();
                listBoxBooks.DisplayMember = "Title";
                listBoxBooks.ValueMember = "Title";
            }
        }

        private void listBoxBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            Book book = (Book)listBoxBooks.SelectedItem;
            textBoxTitleNew.Text = book.Title;
            textBoxAuthorNew.Text = book.Author;
            textBoxPriceNew.Text = Convert.ToString(book.Price);
            textBoxYearNew.Text = Convert.ToString(book.Year);
            comboBoxCategoriesNew.SelectedItem = book.Category;

        }

        private void btnFilterTitle_Click(object sender, EventArgs e)
        {
            using (ServiceBookstoreClient service = new ServiceBookstoreClient())
            {
                Book[] books = service.GetBooksByTitle(textBoxTitle.Text);
                listBoxBooks.DataSource = books;
                listBoxBooks.DisplayMember = "Title";
                listBoxBooks.ValueMember = "Title";

            }
        }
    }
}
