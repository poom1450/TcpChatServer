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
using SimpleTCP;

namespace Client
{
    public partial class TcpServer : Form
    {


        public TcpServer()
        {
            InitializeComponent();
        }

        SimpleTcpClient Client;
        string name;
        string nsv;
        string cn = "n";
        string oldname;
        System.Media.SoundPlayer player = new System.Media.SoundPlayer("sound_signal.wav");

        public void bconnect_Click(object sender, EventArgs e)
        {
      
            if (txtname.Text == "")
            {
                MessageBox.Show("Insert Name!");
            }
            else if (nsv != "y")
            {
                MessageBox.Show("Click Save Name!");
            }
            else if(nsv == "y")
            {

                try{
                    Client.Connect(txthost.Text, Convert.ToInt32(txtport.Text));
                    Client.Write("User:"+name +";" +" is connected to server");
                    cn = "y";
                    bconnect.Enabled = false;
                }
                catch
                {
                    MessageBox.Show("Can't connect to server");
                }
               
            }

        }

        public void Form1_Load(object sender, EventArgs e)
        {
            Client = new SimpleTcpClient();
            Client.StringEncoder = Encoding.UTF8;
            Client.DataReceived += Client_DataReceived;
            
           





        }
        private void lstatus_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;
            //if the item state is selected them change the back color 
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                e = new DrawItemEventArgs(e.Graphics,
                                          e.Font,
                                          e.Bounds,
                                          e.Index,
                                          e.State ^ DrawItemState.Selected,
                                          e.ForeColor,
                                          Color.White);//Choose the color


            e.DrawBackground();
            e.Graphics.DrawString(lstatus.Items[e.Index].ToString(), e.Font, Brushes.DimGray, e.Bounds, StringFormat.GenericDefault);
            e.DrawFocusRectangle();
        }

        private void Client_DataReceived(object sender, SimpleTCP.Message e)
        {
            
            lstatus.Invoke((MethodInvoker)delegate ()
            {
                Console.WriteLine(e.MessageString);
                if (e.MessageString.Remove(e.MessageString.Length - 1) == "Server closed")
                {
                    bconnect.Enabled = true;
                    lstatus.Items.Add(string.Format("{0:HH:mm tt}", DateTime.Now) + "||" + "Server is closed");
                    lstatus.Items.Add(string.Format("{0:HH:mm tt}", DateTime.Now) + "||" + "Try Connect to server again");
                    cn = "n";
                    lstatus.SelectedIndex = lstatus.Items.Count - 1;
                    Client.Disconnect();
                    
                }
                else if (Comparestr(e.MessageString.Remove(e.MessageString.Length - 1),"Cmsrv3x"))
                {
                    string rms = e.MessageString.Remove(e.MessageString.Length - 1);
                    ltest.Text = rms.Replace("Cmsrv3x", "User online: ");
                    lstatus.SelectedIndex = lstatus.Items.Count - 1;
                }
                else if(secretms(e.MessageString.Remove(e.MessageString.Length - 1), "@") != true)
                {
                    lstatus.Items.Add(string.Format("{0:HH:mm tt}", DateTime.Now) + "||" + e.MessageString.Remove(e.MessageString.Length - 1));
                    lstatus.SelectedIndex = lstatus.Items.Count - 1;
                }
                else if(secretms(e.MessageString.Remove(e.MessageString.Length - 1), "@" + name+ ":") | secretms(e.MessageString.Remove(e.MessageString.Length - 1), name+ " : " ))
                {
                    lstatus.Items.Add(string.Format("{0:HH:mm tt}", DateTime.Now)+ "||" + e.MessageString.Remove(e.MessageString.Length - 1));
                    if(secretms(e.MessageString.Remove(e.MessageString.Length - 1), "@" + name + ":"))
                    {
                        player.Play();
                    }
                    else
                    {

                    }
                    
                    lstatus.SelectedIndex = lstatus.Items.Count - 1;
                }
                else
                {

                }
               
                
            });
        }

        private bool Comparestr(string v1, string v2)
        {
            v1.Contains(v2);
            if (v1.Contains(v2))
            {
                Console.WriteLine("return true");
                return true;
            }
            else {
                Console.WriteLine("return false");
                return false;
               
            }
        }

        private bool secretms(string v1, string v2)
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

        public void bsend_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "")
            {
                MessageBox.Show("Insert Name!");
            }
            else if(nsv!="y")
            {
                MessageBox.Show("Click Save Name!");
            }
            else if(cn != "y")
            {
                MessageBox.Show("Server is not connect!");
                
            }
            else
            {
                Client.Write(name + " : " + txtms.Text);
                txtms.Clear();
            }
            
        }

        public void bSave_Click(object sender, EventArgs e)
        {

            if (txtname.Text == "")
            {
                MessageBox.Show("Insert Name!");
            }
            else if(nsv != "y")
            {
                name = txtname.Text;
                nsv = "y";
                

            }
            else if(cn=="y")
            {
                oldname = name;
                Client.Write( oldname + " changed name to " + name);
            }
            name = txtname.Text;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtms_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Client.Write(name +" " + "disconnect from server ");
            cn = "n";
            bconnect.Enabled = true;
            ltest.Text = "User online:0 ";
            lstatus.Items.Clear();
            Client.Disconnect();
            

        }
    }
}
