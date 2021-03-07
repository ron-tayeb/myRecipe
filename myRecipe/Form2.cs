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
    public partial class Form2 : Form
    {
        private bool drag = false;
        private Point startP = new Point(0, 0);
        string path = @"../../resipes.txt";
        public Form2()
        {
            InitializeComponent();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIngredients_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrep_TextChanged(object sender, EventArgs e)
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
            int numLines = richTextBox1.Text.Split('\n').Length;
            
            Resipe r1 = new Resipe(txtName.Text,txtCal.Text,txtPrep.Text,richTextBox1.Text,difficulty);
            r1.Insert(r1.ToString());
            Console.WriteLine(r1.ToString());
            File.AppendAllText(path, r1.ToString());
            MessageBox.Show("Added", "succses", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
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

        private void Form2_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startP.X, p.Y - this.startP.Y);
            }
        }
        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            startP = new Point(e.X, e.Y);
        }
    }

}
