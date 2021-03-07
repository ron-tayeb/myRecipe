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
    public partial class Form5 : Form
    {
        private bool drag = false;
        private Point startP = new Point(0, 0);
        string path = @"../../resipes.txt";
        public Form5()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string difficulty = null;
            if (rbEASY.Checked)
            {
                difficulty = rbEASY.Text;
            }
            if (rbMED.Checked)
            {
                difficulty = rbMED.Text;
            }
            if (rbHARD.Checked)
            {
                difficulty = rbHARD.Text;
            }
            int count = 0;
            string old;
            string n = "";
            StreamReader sr = File.OpenText(path);
            while ((old = sr.ReadLine()) != null)
            {
                if (!old.Contains(txtNametoupdate.Text))
                {
                    n += old + Environment.NewLine;
                }
                else
                {
                    if (txtname.Text == "")
                    {
                        n += old + Environment.NewLine;
                        old = sr.ReadLine();
                    }
                    else
                    {
                        n += old = "Name:" + txtname.Text + Environment.NewLine;
                        old = sr.ReadLine();
                    }

                    if (txtCal.Text == "")
                    {
                        n += old + Environment.NewLine;
                        old = sr.ReadLine();
                    }
                    else
                    {
                        n += old = "calories:" + txtCal.Text + Environment.NewLine;
                        old = sr.ReadLine();
                    }

                    if (txtPrep.Text == "")
                    {
                        n += old + Environment.NewLine;
                        old = sr.ReadLine();
                    }
                    else
                    {
                        n += old = "preparation time:" + txtPrep.Text + Environment.NewLine;
                        old = sr.ReadLine();
                    }

                    if (richTextinger.Text == "")
                    {
                        
                        while (!(old[0] == 'D'))
                        {
                            n += old + Environment.NewLine;
                            old = sr.ReadLine();
                        }
                    }
                    else
                    {
                        n += old = "Ingredients:\n" + richTextinger.Text + Environment.NewLine;

                        while (!(old[0]=='D'))
                        {
                            old = sr.ReadLine();
                        }

                    }

                    if (difficulty == null)
                    {
                        n += old + "\n" + Environment.NewLine ;
                        old = sr.ReadLine();
                    }
                    else
                    {
                        n += old = "Difficulty:" + difficulty + Environment.NewLine;
                        old = "\n\n";
                        old = sr.ReadLine();
                    }

                }

            }
            sr.Close();
            File.WriteAllText(path, n);
            MessageBox.Show("update", "succses", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void richTextinger_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrep_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNametoupdate_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbEASY_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbMED_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbHARD_CheckedChanged(object sender, EventArgs e)
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

        private void Form5_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startP.X, p.Y - this.startP.Y);
            }
        }

        private void Form5_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void Form5_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            startP = new Point(e.X, e.Y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
