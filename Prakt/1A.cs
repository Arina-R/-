using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prakt
{
    public partial class _1A : Form
    {
        public _1A()
        {
            InitializeComponent();
            
        }
        public int N;
        private void but_back_Click(object sender, EventArgs e)
        {

             
            Hide();
            Form1 F1 = new Form1();
            F1.ShowDialog();
            Close();
        }

        

        private void but_in_Click(object sender, EventArgs e)
        {
            if (TB_log.Text == "admin" && TB_pass.Text=="123")
            {
                panel1.Visible = true;

                RTB.ReadOnly = false;
            }
            else
            {
                MessageBox.Show("Введите верный логин и пароль");
            }
        }

    }
}
