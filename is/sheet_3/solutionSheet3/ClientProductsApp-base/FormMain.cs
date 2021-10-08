using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO; //Stream
using System.Linq;
using System.Net; //HttpWebRequest
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

//JavaScriptSerializer --> necessário criar referencia para System.Web.Extensions caso pretendam usar para serializar objetos em JSON

namespace ClientProductsApp
{
    public partial class FormMain : Form
    {

        string baseURI = @"http://localhost:59011/"; //TODO: needs to be updated!

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonGetAll_Click(object sender, EventArgs e)
        {
            var client = new RestSharp.RestClient(baseURI);
            var request = new RestSharp.RestRequest("api/products", method: RestSharp.Method.GET);
            List<Product> response = client.Execute<List<Product>>(request).Data;
            richTextBoxShowProducts.Clear();
            foreach (Product product in response)
            {
                richTextBoxShowProducts.AppendText($"{product.Id}\tName:{product.Name}\tCategory:{product.Category}\tPrice:{product.Price}\n");
            }
        }

        private void buttonGetProductById_Click(object sender, EventArgs e)
        {
            var client = new RestSharp.RestClient(baseURI);
            var request = new RestSharp.RestRequest("api/products/{id}", RestSharp.Method.GET);
            request.AddUrlSegment("id", textBoxFilterById.Text);
            Product product = client.Execute<Product>(request).Data;
            if (product == null)
            {
                MessageBox.Show($"No Product with id:{textBoxFilterById.Text}");
                textBoxOutput.Clear();
                textBoxID.Clear();
                textBoxCategory.Clear();
                textBoxPrice.Clear();
                textBoxName.Clear();
                return;
            }
            textBoxOutput.Clear();
            textBoxOutput.Text = $"{product.Id}\tName:{product.Name}\tCategory:{product.Category}\tPrice:{product.Price}";
            textBoxID.Text = product.Id.ToString();
            textBoxCategory.Text = product.Category;
            textBoxPrice.Text = product.Price.ToString();
            textBoxName.Text = product.Name;
        }

        private void buttonPost_Click(object sender, EventArgs e)
        {
           Product product = new Product
            {
                Id = int.Parse(textBoxID.Text),
                Name = textBoxName.Text,
                Category = textBoxCategory.Text,
                Price = decimal.Parse(textBoxPrice.Text)
            };

            var client = new RestSharp.RestClient(baseURI);
            var request = new RestSharp.RestRequest("api/products", method: RestSharp.Method.POST);
            request.AddJsonBody(product);          
            RestSharp.IRestResponse response = client.Execute(request);
            MessageBox.Show(response.StatusCode + " " + response.ResponseStatus);

        }

        private void buttonPut_Click(object sender, EventArgs e)
        {
            Product product = new Product
            {
                Id = int.Parse(textBoxID.Text),
                Name = textBoxName.Text,
                Category = textBoxCategory.Text,
                Price = decimal.Parse(textBoxPrice.Text)
            };

            var client = new RestSharp.RestClient(baseURI);
            var request = new RestSharp.RestRequest("api/products/{id}", method: RestSharp.Method.PUT);
            request.AddUrlSegment("id", textBoxID.Text);
            request.AddJsonBody(product);
            RestSharp.IRestResponse response = client.Execute(request);
            MessageBox.Show(response.StatusCode + " " + response.ResponseStatus);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var client = new RestSharp.RestClient(baseURI);
            var request = new RestSharp.RestRequest("api/products/{id}", method: RestSharp.Method.DELETE);
            request.AddUrlSegment("id", textBoxID.Text);
            RestSharp.IRestResponse response = client.Execute(request);
            MessageBox.Show(response.StatusCode + " " + response.ResponseStatus);
        }
    }
}
