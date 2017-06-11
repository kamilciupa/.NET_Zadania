using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {

        TcpClient client;
        bool isConnected;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // client.Connect(tbIP.Text, Int32.Parse(tbPort.Text));
           // lStatus.Text = "Connected!";
        }

        private void bSet_Click(object sender, EventArgs e)
        {
            try
            {
                client = new TcpClient();
                client.Connect(tbIP.Text, Int32.Parse(tbPort.Text));
                lStatus.Text = "Connected!";
                isConnected = true;
            } catch (SocketException ex)
            {
                MessageBox.Show("Cannot connect to server!");
            }
        }

        private void bBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.ShowDialog();
            tbFile.Text = dialog.FileName;
        }

        private void bSend_Click(object sender, EventArgs e)
        { 
            if (isConnected)
            {
                new Thread(() =>
                {
                    try
                    {
                        bool isGood = false;

                        Stream fileStream = File.OpenRead(tbFile.Text);
                        Byte[] dataBytes = new byte[fileStream.Length];
                        Byte[] fileType = new byte[3];
                        Byte[] fileSize = new byte[3];

                        var type = tbFile.Text.Split('.');
                        fileType = Encoding.UTF8.GetBytes(type[type.Length - 1]);
                        fileSize = Encoding.UTF8.GetBytes(fileStream.Length.ToString());

                        fileStream.Read(dataBytes, 0, (int)fileStream.Length);
                        NetworkStream networkStream = client.GetStream();
                        isGood = true;
                        if (isGood)
                        {
                            networkStream.Write(fileType, 0, fileType.GetLength(0));

                            networkStream.Write(fileSize, 0, fileSize.GetLength(0));

                            networkStream.Write(dataBytes, 0, dataBytes.GetLength(0));
                            networkStream.Close();
                            MessageBox.Show("File was send");
                        }
                    
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Cannot open file!");
                    } 



                    client.Close();
                    isConnected = false;
                }
                ).Start();

                
                
                   lStatus.Text = "Disconnected!";
                
            }
        }
    }
}
