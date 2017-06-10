﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
              

            //}
        }

        private void bFolder_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog();
            dialog.ShowDialog();
            tbFolder.Text = dialog.SelectedPath;
        }

        private void bSet_Click(object sender, EventArgs e)
        {
            TcpListener server = null;
            try
            {
                // options
                Int32 port = Int32.Parse(tbPort.Text);
                IPAddress ipAddress = IPAddress.Parse(tbIP.Text);
                // new tcp
                server = new TcpListener(ipAddress, port);
                //listen
                server.Start();

                //buffer for reading data temporary xD 
                Byte[] buffer = new Byte[2048];
                Byte[] fileTyp = new Byte[3];
                String data = null;

                //listening loop

                lStats.Text = "Waiting ... ";
                while (true)
                {


                    TcpClient client = server.AcceptTcpClient();
                    lStats.Text = "Connected!";
                    NetworkStream stream = client.GetStream();
                    int i;
                    stream.Read(fileTyp, 0, 3);
                    string typeFile = Encoding.UTF8.GetString(fileTyp);

                    try
                    {
                        Stream fileStream = File.OpenWrite(tbFolder.Text + "\\cos." + typeFile);
                        while (true)
                        {
                            i = stream.Read(buffer, 0, 2048);
                            fileStream.Write(buffer, 0, i);
                            if (i == 0) break;
                        }
                        fileStream.Close();
                        lStats.Text = "File is saved!";
                    } catch (Exception)
                    {
                        MessageBox.Show("Something is wrong");
                    }
                }
            }
            catch (SocketException)
            {
                lStats.Text = "Socket Exception";
            }
            finally
            {
                server.Stop();
                lStats.Text = "Server is offline"; 
            }
        }
    }
}