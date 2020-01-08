using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapstoneIndividual
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        

        private void rb1Player_CheckedChanged(object sender, EventArgs e)
        {
            lblPlayer2Prompt.Visible = false;
            textBox2.Visible = false;
        }

        private void rb2Players_CheckedChanged(object sender, EventArgs e)
        {
            lblPlayer2Prompt.Visible = true;
            textBox2.Visible = true;
        }

        private void btnBegin_Click(object sender, EventArgs e)
        {
            Player playerX = new Player(textBox1.Text);
            Player playerO = new Player(textBox2.Text);
            textBox1.Text = playerX.Name;
            textBox2.Text = playerO.Name;

            if (rbNormal.Checked == true)
            {
                Normal gNormal = new Normal();
                gNormal.Show();
                this.Hide();
            }

            if (rbUltimate.Checked == true)
            {
                Ultimate gUltimate = new Ultimate();
                gUltimate.Show();
                this.Hide();
            }

            if (rb6x6.Checked == true)
            {
                _6x6 g6x6 = new _6x6();
                g6x6.Show();
                this.Hide();
            }
        }
    }
}
