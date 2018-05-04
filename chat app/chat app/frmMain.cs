using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks; 

namespace chat_app
{
    public partial class frmMain : Form
    {
        Socket sck;
        EndPoint epLocal, epRemote;
        string ReceivedMessage;

        public frmMain()
        {
            Thread t = new Thread(new ThreadStart(startForm));
            t.Start();
            Thread.Sleep(5000);

            InitializeComponent();

            t.Abort();

            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            textLocalIp.Text = GetLocalIP();
            textFriendsIp.Text = GetLocalIP();
        }

        public void startForm()
        {

            Application.Run(new frmSplashScreen());

        }

        private string GetLocalIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());

            foreach (IPAddress ip in host.AddressList)
            { 
                if(ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }

            return "127.0.0.1";
        }

        private void MessageCallBack(IAsyncResult aResult) 
        {
            try
            {
                int size = sck.EndReceiveFrom(aResult, ref epRemote);
                if (size > 0)
                {
                    byte[] receivedData = new byte[1464];
                    receivedData = (byte[])aResult.AsyncState;

                    ASCIIEncoding eEncoding = new ASCIIEncoding();
                    string receivedMessage = eEncoding.GetString(receivedData);

                    receivedMessage = Encryption(receivedMessage);

                    ReceivedMessage = receivedMessage;

                    listMessage.Items.Add("Frined: "+receivedMessage); 
                }

                byte[] buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                epLocal = new IPEndPoint(IPAddress.Parse(textLocalIp.Text), Convert.ToInt32(textLocalPort.Text));
                sck.Bind(epLocal);

                epRemote = new IPEndPoint(IPAddress.Parse(textFriendsIp.Text), Convert.ToInt32(textFriendsPort.Text));
                sck.Connect(epRemote);

                byte[] buffer = new byte[15000];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);

                button1.Text = "Connected";
                button1.Enabled = false;
                button2.Enabled = true;
                textMessage.Focus();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();
                byte[] mes = new byte[1500];
                mes = enc.GetBytes(textMessage.Text);

                sck.Send(mes);
                listMessage.Items.Add("Me: " + textMessage.Text);
                textMessage.Clear();
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }

        private string Encryption(string s)
        {
            char[] c = s.ToCharArray();

            for (int i = 0; i < c.Length; i++)
            {
                if (char.IsLetter(c[i])) c[i] += (char)3;
            }

            s = new string(c);
            c = s.ToCharArray();

            for (int i = c.Length / 2; i < c.Length; i++) c[i] -= (char)1;
            return s = new string(c);
        }

        private string Decryption(string s)
        {
            char[] c = s.ToCharArray();
            for (int i = c.Length / 2; i < c.Length; i++) c[i] += (char)1;
            s = new string(c);
            c = s.ToCharArray();

            for (int i = 0; i < c.Length; i++)
            {
                if (char.IsLetter(c[i]) || c[i] == '{' || c[i] == '|' || c[i] == '}' || c[i] == '{' || c[i] == '\\' || c[i] == '[' || c[i] == ']') 				c[i] -= (char)3;
            }

            return s = new string(c); ;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(Decryption(ReceivedMessage), "Original Message");
            }

            catch(Exception exp)
            { 
                MessageBox.Show(exp.ToString());
            }
        }
    }
}
