using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace Mosquitto_B
{
    public partial class Form1 : Form
    {
        MqttClient broker;
        string[] topics = { "news", "complains" };
        public Form1()
        {
            InitializeComponent();
            comboBox1.DataSource = topics;
        }

        private void buttonPublish_Click(object sender, EventArgs e)
        {
            broker.Publish(comboBox1.SelectedItem.ToString(), Encoding.UTF8.GetBytes(textBox.Text));
        }

        private void btnConnectBroker_Click(object sender, EventArgs e)
        {
            broker = new MqttClient(textBoxBrokerDomain.Text);
            broker.Connect(Guid.NewGuid().ToString());
            if (!broker.IsConnected)
            {
                MessageBox.Show("Error connecting to broker");
                return;
            }
        }
    }
}
