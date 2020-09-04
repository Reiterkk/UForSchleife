using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UForSchleife
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdSchleife1_Click(object sender, EventArgs e)
        {
            LblSchleife1.Text = "";
            for (double i = 35; i > 19 ; i -=2.5)
            {
                LblSchleife1.Text += i + "\n";
            }

        }
    }
}
