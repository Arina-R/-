using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prakt
{
    public partial class Form1 : Form
    {

       

        public Form1()
        {
            InitializeComponent();
            client = new TcpClient();
            client.Connect(host, port); //подключение клиента
            richTextBoxChat.Text += "Введите свое имя: " + '\n';

        }

        private void but_1A_Click(object sender, EventArgs e)
        {
            Hide();
            _1A A1 = new _1A();
            
            
            
            A1.ShowDialog();
            Close();

            
        }

        private void but_1B_Click(object sender, EventArgs e)
        {

        }

        private void but_3A_Click(object sender, EventArgs e)
        {

        }

        private void but_3B_Click(object sender, EventArgs e)
        {

        }

        private void but_2A_Click(object sender, EventArgs e)
        {

        }

        private void but_2B_Click(object sender, EventArgs e)
        {

        }

        private void but_4A_Click(object sender, EventArgs e)
        {

        }

        private void but_4B_Click(object sender, EventArgs e)
        {

        }

        
    }
}
