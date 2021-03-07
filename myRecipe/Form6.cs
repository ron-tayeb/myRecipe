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
    public partial class Form6 : Form
    {
        private bool drag = false;
        private Point startP = new Point(0, 0);
        string path = @"../../resipes.txt";
        public Form6()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void Form6_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void Form6_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startP.X, p.Y - this.startP.Y);
            }
        }

        private void Form6_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            startP = new Point(e.X, e.Y);
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            string old;
            string n = "";
            StreamReader sr = File.OpenText(path);
            while ((old = sr.ReadLine()) != null)
            {
                if (!old.Contains(txtNametodelete.Text))
                {
                    n += old + Environment.NewLine;
                }
                else
                {
                    while (!(old[0] == 'D'))
                    {
                        old = sr.ReadLine();
                    }
                }

            }
            sr.Close();
            File.WriteAllText(path, n);
            MessageBox.Show("delete", "succses", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtNametodelete_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            this.Close();
            Form4 f4 = new Form4();
            f4.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form3 f3 = new Form3();
            f3.Show();
        }
    }
}
