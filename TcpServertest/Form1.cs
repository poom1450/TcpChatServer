using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleTCP;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace TcpServertest
{
    public partial class Form1 : Form
    {
     
    

        public Form1()
        {
            InitializeComponent();
        }
        SimpleTcpServer server;
        List<string> usersList = new List<string>();
        public void Form1_Load(object sender, EventArgs e)
        {
            server = new SimpleTcpServer();
            server.Delimiter = 0x13; //Enter
            server.StringEncoder = Encoding.UTF8;
            server.DataReceived += Server_DataReceived;
            server.ClientConnected += Server_ClientConnected;
            server.ClientDisconnected += Server_ClientDisconnect;
         


        }

        private void Server_ClientDisconnect(object sender, TcpClient e)
        {
            int clientsConnected = server.ConnectedClientsCount;
            server.BroadcastLine("Cmsrv3x" + clientsConnected.ToString());
            Thread.Sleep(100);
        }

        public void Server_ClientConnected(object sender, TcpClient e)
        {
            
            txtstatus.Invoke((MethodInvoker)delegate ()
            {
                
                txtstatus.Text += string.Format("{0:HH:mm:ss tt}", DateTime.Now) + "||" + ((IPEndPoint)e.Client.RemoteEndPoint).Address.ToString();
                txtstatus.Text +=  "Connect to server" + Environment.NewLine;
          

            });
            
        }

        private void bstart_Click(object sender, EventArgs e)
        {
            txtstatus.Text += string.Format("{0:HH:mm:ss tt}", DateTime.Now) + "||" + "Server started " +  Environment.NewLine;
            System.Net.IPAddress ip = System.Net.IPAddress.Parse(txthost.Text);
            server.Start(ip, Convert.ToInt32(txtport.Text));
            bstart.Enabled = false;
        }
        private void Server_DataReceived(object sender, SimpleTCP.Message e)
        {
            int clientsConnected = server.ConnectedClientsCount;
            txtstatus.Invoke((MethodInvoker)delegate ()
            {

            txtstatus.Text += string.Format("{0:HH:mm:ss tt}", DateTime.Now) + "||"+ e.MessageString + Environment.NewLine;
                if (nameofuser(e.MessageString, "User:"))
                {

                
                    int startIndex = e.MessageString.IndexOf(':');
                    int endIndex = e.MessageString.LastIndexOf(';');
                    int length = endIndex - startIndex + 1;
                    string namefromms = e.MessageString.Substring(startIndex+1, length-1);
                    usersList.Add(namefromms);
                    Console.WriteLine(usersList);
                    string rpms = e.MessageString.Replace("User:", "");
                    server.BroadcastLine(rpms.Replace(";", ""));
                    Thread.Sleep(100);
                    server.BroadcastLine("Cmsrv3x" + clientsConnected.ToString());



                }
                else if (commandms(e.MessageString, "cmd:online") == false)
                {
                    string rpms = e.MessageString.Replace("User:", "");
                    server.BroadcastLine(rpms.Replace(";", ""));
                    Console.WriteLine("condition2");
                    Thread.Sleep(500);
                    

                }
                else if(commandms(e.MessageString, "cmd:online"))
                {
                    string[] arrayname = usersList.ToArray();
                    e.Reply("Name of users in this server ");
                    Thread.Sleep(100);
                    foreach (string name in arrayname)
                    {
                        e.Reply($"Name:{name}");
                        Thread.Sleep(200);
                    }
                    e.Reply("---------------------");
                }
                else
                {

                }
                



            });
        }

        private bool commandms(string v1, string v2)
        {
            v1.Contains(v2);
            if (v1.Contains(v2))
            {
                Console.WriteLine("is command");
                return true;
            }
            else
            {
                Console.WriteLine("return false");
                return false;

            }
        }

        private bool nameofuser(string v1, string v2)
        {
            v1.Contains(v2);
            if (v1.Contains(v2))
            {
                Console.WriteLine("return true");
                return true;
            }
            else
            {
                Console.WriteLine("return false");
                return false;

            }
        }

        private void bstop_Click(object sender, EventArgs e)
        {
             if (server.IsStarted)
            {
                server.BroadcastLine("Server closed");
                txtstatus.Text += string.Format("{0:HH:mm:ss tt}", DateTime.Now) + "||" + "Server closed " + Environment.NewLine;
                server.Stop();
                bstart.Enabled = true;
                usersList.Clear();
            }
            else
            {
                MessageBox.Show("Server is not open");
            }
            
        }
       
      
       
    }
}
