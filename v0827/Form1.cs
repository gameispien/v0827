using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v0827
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int vx = -10;
        int vy = -10;
        private void label1_Click(object sender, EventArgs e)
        {
            label1.Left=-10;
            label1.Top=-10;
        }

        private void label2_Click(object sender, EventArgs e)
        {
          //xとy座標を表示


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left=+vx;
            label1.Top= + vy;
        }
    }
}
