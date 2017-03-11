using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mouse
{
    public partial class Lose : Form
    {
        int Score = 0;
        public Lose(int score)
        {
            InitializeComponent();
            label1.Focus();
            Score = score;
            label3.Text = Score.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Focus();
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Focus();
            this.Close();
        }
    }
}
