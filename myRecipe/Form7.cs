using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myRecipe
{
    public partial class Form7 : Form
    {
        private bool drag = false;
        private Point startP = new Point(0, 0);
        string conStr = @"Data Source=DESKTOP-4VJ698M\GJF;Initial Catalog=DBUsers;Integrated Security=True";
        public Form7()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conStr);
            SqlCommand comm = new SqlCommand($"INSERT INTO TBUser VALUES('{tbuser.Text}', '{tbpass.Text}', '{txtEmail.Text}')",con);
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

        private void btnhome_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form7_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void Form7_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startP.X, p.Y - this.startP.Y);
            }
        }

        private void Form7_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            startP = new Point(e.X, e.Y);
        }
    }
}
