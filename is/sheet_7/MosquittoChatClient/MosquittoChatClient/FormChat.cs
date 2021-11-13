using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;
using System.Xml;

namespace MosquittoChatClient
{
    public partial class FormChat : Form
    {
        const String STR_CHANNEL_NAME = "users";

        //MqttClient m_cClient = new MqttClient(IPAddress.Parse("192.168.237.155"));
        MqttClient m_cClient = new MqttClient("127.0.0.1");
        string[] m_strTopicsInfo = { STR_CHANNEL_NAME };

        public FormChat()
        {
            InitializeComponent();
        }

        //Remember that this method/callback is called by thread from (mosquitto client middleware). It is not the GUI thread!
        void client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            //Console.WriteLine("Received = " + Encoding.UTF8.GetString(e.Message) + " on topic " + e.Topic);            
            //EXTRACT FIELDS
            String strTemp = Encoding.UTF8.GetString(e.Message);
            // string[] arrParts = strTemp.Split(new string[] {"|"}, StringSplitOptions.RemoveEmptyEntries);

            //ler xml que foi enviado
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(strTemp);

            //xpath 
            //RECOVER AVATAR IMG
            Bitmap btmAvatar = ImageHandler.Base64StringToImage(arrParts[2]);
            
            //PACK INFO
            string[] arr = new string[4];
            ListViewItem itm;
            arr[0] = arrParts[2]; //avatar
            arr[1] = arrParts[0]; //nickname
            arr[2] = arrParts[1]; //Classroom
            arr[3] = arrParts[3]; //Message
            itm = new ListViewItem(arr);

            //INSERT INTO DATALISTVIEW
            dataGridView.BeginInvoke((MethodInvoker)delegate { dataGridView.Rows.Add(btmAvatar, arrParts[0], arrParts[1], arrParts[3]); }); 
        }

        private string CreateXMLMessageToSend(string nickname, string room, string avatar, string sms)
        {
            XmlDocument doc = new XmlDocument();
            XmlElement root = doc.CreateElement("chat");
            
            XmlElement avatarNode = doc.CreateElement("avatar");
            avatarNode.InnerText = avatar;
            root.AppendChild(avatarNode);
            XmlElement roomNode = doc.CreateElement("room");
            roomNode.InnerText = room;
            root.AppendChild(roomNode);
            XmlElement nicknameNode = doc.CreateElement("nickname");
            nicknameNode.InnerText = nickname;
            root.AppendChild(nicknameNode);
            XmlElement smsNode = doc.CreateElement("msg");
            smsNode.InnerText = sms;
            root.AppendChild(smsNode);
            doc.AppendChild(root);
            return doc.OuterXml;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView.Columns.Clear();
            
            //First column is bitmap type!            
            DataGridViewImageColumn imgCol = new DataGridViewImageColumn(); imgCol.Name = "nic"; imgCol.HeaderText = "Avatar";
            dataGridView.Columns.Add(imgCol);
            //Next columns are text type
            dataGridView.Columns.Add("nic", "Nickname");
            dataGridView.Columns.Add("cl", "Classroom");
            dataGridView.Columns.Add("msg", "Message");

            //Just to...
            textBoxNickName.Text = "user1";
            textBoxClassRoom.Text = "ESTG-LSI";
            textBoxAvatarLoc.Text = Application.StartupPath +  @"\icon_blue.png";
            
            m_cClient.Connect(Guid.NewGuid().ToString());
            if (!m_cClient.IsConnected)
            {
                MessageBox.Show("Error connecting to message broker...");
                return;
            }

            //Subscribe chat channel
            m_cClient.MqttMsgPublishReceived += client_MqttMsgPublishReceived;

            byte[] qosLevels = { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE};//QoS
            m_cClient.Subscribe(m_strTopicsInfo, qosLevels);

            if (m_cClient.IsConnected)
                lblStatus.Text = "Connected";
            else
                lblStatus.Text = "Disconnected";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (m_cClient.IsConnected)
            {
                m_cClient.Unsubscribe(m_strTopicsInfo); //Put this in a button to see notif!
                m_cClient.Disconnect(); //Free process and process's resources
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (!m_cClient.IsConnected)
            {
                MessageBox.Show("Application is disconnected");
                return;
            }

            if (!ValidateUserInfo())
            {
                MessageBox.Show("Invalid User Info");
                return;
            }

            String strNickName = textBoxNickName.Text;
            String strClassRoom = textBoxClassRoom.Text;
            String strAvatar = ImageHandler.ImageToBase64String(textBoxAvatarLoc.Text);

            String strMsg = textBoxMsgToSend.Text;
            if (strMsg.Trim().Length <= 0)
            {
                MessageBox.Show("Invalid message");
                return;
            }

            String strMsgToSend = CreateXMLMessageToSend(strNickName, strClassRoom, strAvatar, strMsg);
            m_cClient.Publish(STR_CHANNEL_NAME, Encoding.UTF8.GetBytes(strMsgToSend));

            textBoxMsgToSend.Text="";
            textBoxMsgToSend.Focus();
        }

        private Boolean ValidateUserInfo()
        {
            String strTemp = textBoxNickName.Text;
            if (strTemp.Trim().Length <= 0)
            {
                return false;
            }
            strTemp = textBoxClassRoom.Text;
            if (strTemp.Trim().Length <= 0)
            {
                return false;
            }
            strTemp = textBoxAvatarLoc.Text;
            if (strTemp.Trim().Length <= 0)
            {
                return false;
            }
            if (!File.Exists(strTemp))
            {
                return false;
            }
            
            return true;
        }

     
    }
}
