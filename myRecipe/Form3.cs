using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myRecipe
{
    public partial class Form3 : Form
    {
        private bool drag = false;
        private Point startP = new Point(0, 0);
        string path = @"../../resipes.txt";
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            string resipes = File.ReadAllText(path);
            label2.Text = resipes;
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            this.Close();
            Form4 f4 = new Form4();
            f4.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form3_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            startP = new Point(e.X, e.Y);
        }

        private void Form3_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startP.X, p.Y - this.startP.Y);
            }
        }

        private void Form3_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }
    }
}
