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

namespace Mosquitto_1
{
    public partial class Form1 : Form
    {   
        //where is the broker?
        MqttClient broker = new MqttClient("127.0.0.1"); // em casa usar o test.mosquitto.org
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

        private void Form1_Load(object sender, EventArgs e)
        {
            broker.Connect(Guid.NewGuid().ToString());
            if (!broker.IsConnected) {
                MessageBox.Show("Error connecting to broker");
                return;
            }
            
            broker.MqttMsgPublishReceived += Broker_MqttMsgPublishReceived;
            broker.MqttMsgSubscribed += Broker_MqttMsgSubscribed;
            broker.MqttMsgUnsubscribed += Broker_MqttMsgUnsubscribed;
            //number of topics = number of qosLevels
            byte[] qosLevels = { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE};
            broker.Subscribe(topics, qosLevels);
        }

        private void Broker_MqttMsgUnsubscribed(object sender, MqttMsgUnsubscribedEventArgs e)
        {
            MessageBox.Show("Topics unsubcribe!");
        }

        private void Broker_MqttMsgSubscribed(object sender, MqttMsgSubscribedEventArgs e)
        {
            MessageBox.Show("Sucessful subscription!");
        }

        private void Broker_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate { 
                string message = Encoding.UTF8.GetString(e.Message);
                //MessageBox.Show($"topic {e.Topic} --> Message: {message}");
                textBox1.AppendText($"topic {e.Topic} --> Message: {message}" + Environment.NewLine);
            });

           
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (broker.IsConnected)
            {
                broker.Unsubscribe(topics);
                broker.Disconnect();
            }
         
        }

        private void btnUnsubscribeAllTopics_Click(object sender, EventArgs e)
        {
            if (broker.IsConnected)
            {
                broker.Unsubscribe(topics);
            }
        }
    }
}
