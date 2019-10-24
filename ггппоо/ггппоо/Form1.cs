using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ггппоо
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form2 reg = new Form2();
            reg.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form3 bdk = new Form3();
            bdk.Show();
        }
    }
}
