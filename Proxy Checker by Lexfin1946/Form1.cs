using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Leaf.xNet;
using System.IO;


namespace Proxy_Checker_by_Lexfin1946
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // CREATED BY LEXFİN

        List<string> list = new List<string>();
        
        private void Form1_Load(object sender, EventArgs e)
        {
            Thread.Sleep(1000);
            MessageBox.Show("Lets goooooo", "This program created by Lexfin. ");
        }     

        private void richTextBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;

            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Select proxy4 or proxy5 !");
                return;
            }



            var selectedProxyType = comboBox1.SelectedItem.ToString();
            ProxyType proxyType;

            if (selectedProxyType == "Proxy4")
            {
                proxyType = ProxyType.Socks4;
            }

            else if (selectedProxyType == "Proxy5")
            {
                proxyType = ProxyType.Socks5;
            }

            else
            {
               MessageBox.Show("Select correct proxy type !");
               return;
            }
            

            var lines = richTextBox1.Lines;
            var opt = comboBox1.SelectedItem;
            using(var req = new HttpRequest())
            {
                req.ConnectTimeout = 2000;
                foreach (var line in lines)
                {
                    
                    var proxyadres = line.Trim();
                    try
                    {
                        richTextBox1.Enabled = false;
                        req.Proxy = ProxyClient.Parse(proxyType, line.Trim());
                        string adres = req.Get("http://api.ipify.org/").ToString();
                        proxyCheck.Items.Add("SUCCESS ✓" + "   " + "→" + " " + proxyadres);
                        req.ConnectTimeout = 1000;
                        if (adres == proxyadres.Split(':')[0])
                        {
                            list.Add(proxyadres);
                           
                        }


                    }
                    catch (Exception)
                    {
                        proxyCheck.Items.Add("ERROR    X"+ "   " + "→" + " " + proxyadres);
                        req.ConnectTimeout = 1000;

                    }
                }
                richTextBox1.Enabled = true;
                button2.Enabled = true;
                MessageBox.Show("Please select some txt for log...");
                Thread.Sleep(1000);
                OpenFileDialog openFileDialog1 = new OpenFileDialog();


                openFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string selectedFileName = openFileDialog1.FileName;
                    using (FileStream fs = new FileStream(selectedFileName, FileMode.Open, FileAccess.Write))
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        foreach (var item in list)
                        {
                            sw.WriteLine(item);
                        }
                    }
                    MessageBox.Show("Logs saved !");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/lexfin13";
            System.Diagnostics.Process.Start(url);
        }
    }
}
