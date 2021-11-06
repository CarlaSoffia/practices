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

namespace Mosquitto_A
{
    public partial class Form1 : Form
    {
        MqttClient broker;
        string[] topics = { "news", "complains" };
        public Form1()
        {
            InitializeComponent();

        }

        private void btnConnectSubscribe_Click(object sender, EventArgs e)
        {
            if (broker == null)
            {
                broker = new MqttClient(textBoxBrokerDomain.Text);
                broker.Connect(Guid.NewGuid().ToString());
            }
            
            byte[] qosLevels = { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE };
            broker.Subscribe(topics, qosLevels);
            
            if (!broker.IsConnected)
            {
                MessageBox.Show("Error connecting to broker");
                return;
            }
            broker.MqttMsgPublishReceived += Broker_MqttMsgPublishReceived;
            broker.MqttMsgUnsubscribed += Broker_MqttMsgUnsubscribed;
            broker.MqttMsgSubscribed += Broker_MqttMsgSubscribed;
        }

        private void Broker_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate {
                string message = Encoding.UTF8.GetString(e.Message);
                textBoxReceived.AppendText($"topic {e.Topic} --> Message: {message}" + Environment.NewLine);
            });
        }

        private void Broker_MqttMsgSubscribed(object sender, MqttMsgSubscribedEventArgs e)
        {
            MessageBox.Show("Sucessful subscription!");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (broker.IsConnected)
            {
                broker.Unsubscribe(topics);  
            }
        }
        private void Broker_MqttMsgUnsubscribed(object sender, MqttMsgUnsubscribedEventArgs e)
        {
            MessageBox.Show("Topics unsubcribe!");
        }

    }
}
