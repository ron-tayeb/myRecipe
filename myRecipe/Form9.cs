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
    public partial class Form9 : Form
    {
        private bool drag = false;
        private Point startP = new Point(0, 0);
        string conStr = @"Data Source=DESKTOP-4VJ698M\GJF;Initial Catalog=DBUsers;Integrated Security=True";
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            string output = "";
            SqlConnection con = new SqlConnection(conStr);
            SqlCommand comm = new SqlCommand($"SELECT * FROM TBUser", con);
            con.Open();
            SqlDataReader reader = comm.ExecuteReader();
            while(reader.Read())
            {
                output +="name: "+reader["user_name"] + ". password: " + reader["password"] + ". email: " + reader["email"] +"\n";
            }
            con.Close();
            label2.Text = output;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void Form9_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void Form9_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startP.X, p.Y - this.startP.Y);
            }
        }

        private void Form9_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            startP = new Point(e.X, e.Y);
        }
    }
}
