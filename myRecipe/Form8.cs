using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace myRecipe
{
    public partial class Form8 : Form
    {
        private bool drag = false;
        private Point startP = new Point(0, 0);
        string conStr = @"Data Source=DESKTOP-4VJ698M\GJF;Initial Catalog=DBUsers;Integrated Security=True";
        public Form8()
        {
            InitializeComponent();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (tbuser.Text=="" || tbpass.Text=="" || txtEmailtochange.Text=="")
            {
                MessageBox.Show("error", "succses", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else
            {
                SqlConnection con = new SqlConnection(conStr);
                SqlCommand comm = new SqlCommand($"UPDATE TBUser" +
                                                 $" SET user_name='{tbuser.Text}' " +
                                                 $"    ,password='{tbpass.Text}'" +
                                                 $"    ,email='{txtEmailtochange.Text}'" +
                                                 $" WHERE email='{txtmailupdate.Text}'", con);
                con.Open();
                int res = comm.ExecuteNonQuery();
                con.Close();
                if (res == 1)
                {
                    MessageBox.Show("succses", "succses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("All fields must be filled out", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conStr);
            SqlCommand comm = new SqlCommand($"DELETE FROM TBUser WHERE email='{txtemaildel.Text}'", con);
            con.Open();
            int res = comm.ExecuteNonQuery();
            con.Close();
            if (res == 1)
            {
                MessageBox.Show("succses", "succses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("error", "succses", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtemaildel_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmailupdate_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmailtochange_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbpass_TextChanged(object sender, EventArgs e)
        {
            tbpass.PasswordChar = '*';
            tbpass.MaxLength = 14;
        }

        private void tbuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form8_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void Form8_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startP.X, p.Y - this.startP.Y);
            }
        }

        private void Form8_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            startP = new Point(e.X, e.Y);
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form9 f9 = new Form9();
            f9.Show();
        }
    }
}
