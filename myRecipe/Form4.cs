using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myRecipe
{
    public partial class Form4 : Form
    {
        private bool drag = false;
        private Point startP = new Point(0, 0);
        public Form4()
        {
            InitializeComponent();
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f5 = new Form5();
            f5.Show();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            this.Close();
            Form6 f6 = new Form6();
            f6.Show();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void Form4_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startP.X, p.Y - this.startP.Y);
            }
        }

        private void Form4_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void Form4_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            startP = new Point(e.X, e.Y);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form3 f3 = new Form3();
            f3.Show();
        }
    }
}
