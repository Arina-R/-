using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        }

        private void but_1A_Click(object sender, EventArgs e)
        {

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

        private void but_Teacher_Click(object sender, EventArgs e)
        {
            Hide();
            Teacher Teach = new Teacher();
            Teach.ShowDialog();
            Close();

        }
    }
}
