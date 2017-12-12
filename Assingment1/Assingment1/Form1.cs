using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assingment1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            var mouseX = e.X;
            var mouseY = e.Y;
            mouseX = mouseX - 15;
            mouseY = mouseY - 37;
            Form f = new Form2(mouseY, mouseX);
            f.Show();
        }
    }
}
