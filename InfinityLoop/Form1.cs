using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfinityLoop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            button1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loopgame game = new loopgame();
            game.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
                button1.Enabled = true;
            
        }
    }
}
