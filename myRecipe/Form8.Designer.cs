
namespace myRecipe
{
    partial class Form8
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            this.txtEmailtochange = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbuser = new System.Windows.Forms.TextBox();
            this.tbpass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtmailupdate = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtemaildel = new System.Windows.Forms.TextBox();
            this.btnupdate = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnhome = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmailtochange
            // 
            this.txtEmailtochange.Location = new System.Drawing.Point(39, 244);
            this.txtEmailtochange.Name = "txtEmailtochange";
            this.txtEmailtochange.Size = new System.Drawing.Size(225, 22);
            this.txtEmailtochange.TabIndex = 19;
            this.txtEmailtochange.TextChanged += new System.EventHandler(this.txtEmailtochange_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(28)))));
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(117, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 28);
            this.label3.TabIndex = 18;
            this.label3.Text = "email";
            // 
            // tbuser
            // 
            this.tbuser.Location = new System.Drawing.Point(40, 75);
            this.tbuser.Name = "tbuser";
            this.tbuser.Size = new System.Drawing.Size(225, 22);
            this.tbuser.TabIndex = 17;
            this.tbuser.TextChanged += new System.EventHandler(this.tbuser_TextChanged);
            // 
            // tbpass
            // 
            this.tbpass.Location = new System.Drawing.Point(39, 162);
            this.tbpass.Name = "tbpass";
            this.tbpass.Size = new System.Drawing.Size(225, 22);
            this.tbpass.TabIndex = 16;
            this.tbpass.TextChanged += new System.EventHandler(this.tbpass_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(28)))));
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(93, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 28);
            this.label2.TabIndex = 15;
            this.label2.Text = "password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(28)))));
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(93, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 28);
            this.label1.TabIndex = 14;
            this.label1.Text = "user name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(28)))));
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(360, 44);
            this.label4.TabIndex = 20;
            this.label4.Text = "edit or delete user";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(28)))));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtEmailtochange);
            this.groupBox1.Controls.Add(this.tbpass);
            this.groupBox1.Controls.Add(this.tbuser);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(332, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 311);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "new details";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(28)))));
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtmailupdate);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(12, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(306, 131);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "user to change";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(28)))));
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(116, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 28);
            this.label7.TabIndex = 18;
            this.label7.Text = "email";
            // 
            // txtmailupdate
            // 
            this.txtmailupdate.Location = new System.Drawing.Point(38, 59);
            this.txtmailupdate.Name = "txtmailupdate";
            this.txtmailupdate.Size = new System.Drawing.Size(225, 22);
            this.txtmailupdate.TabIndex = 19;
            this.txtmailupdate.TextChanged += new System.EventHandler(this.txtmailupdate_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(20, 421);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(482, 10);
            this.panel1.TabIndex = 23;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(28)))));
            this.groupBox3.Controls.Add(this.btndelete);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtemaildel);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Location = new System.Drawing.Point(20, 434);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(458, 131);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "delete user by email";
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Red;
            this.btndelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btndelete.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btndelete.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F);
            this.btndelete.ForeColor = System.Drawing.SystemColors.Window;
            this.btndelete.Location = new System.Drawing.Point(294, 48);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(122, 37);
            this.btndelete.TabIndex = 20;
            this.btndelete.Text = "delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(28)))));
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(116, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 28);
            this.label5.TabIndex = 18;
            this.label5.Text = "email";
            // 
            // txtemaildel
            // 
            this.txtemaildel.Location = new System.Drawing.Point(38, 59);
            this.txtemaildel.Name = "txtemaildel";
            this.txtemaildel.Size = new System.Drawing.Size(225, 22);
            this.txtemaildel.TabIndex = 19;
            this.txtemaildel.TextChanged += new System.EventHandler(this.txtemaildel_TextChanged);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.Red;
            this.btnupdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnupdate.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btnupdate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F);
            this.btnupdate.ForeColor = System.Drawing.SystemColors.Window;
            this.btnupdate.Location = new System.Drawing.Point(102, 266);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(122, 37);
            this.btnupdate.TabIndex = 25;
            this.btnupdate.Text = "update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(28)))));
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(917, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 29);
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnhome
            // 
            this.btnhome.BackColor = System.Drawing.Color.Gray;
            this.btnhome.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F);
            this.btnhome.ForeColor = System.Drawing.SystemColors.Window;
            this.btnhome.Location = new System.Drawing.Point(499, 528);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(98, 37);
            this.btnhome.TabIndex = 27;
            this.btnhome.Text = "home";
            this.btnhome.UseVisualStyleBackColor = false;
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F);
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(619, 528);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 37);
            this.button1.TabIndex = 28;
            this.button1.Text = "show all users";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnhome);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form8";
            this.Text = "Form8";
            this.Load += new System.EventHandler(this.Form8_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form8_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form8_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form8_MouseUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmailtochange;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbuser;
        private System.Windows.Forms.TextBox tbpass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtmailupdate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtemaildel;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnhome;
        private System.Windows.Forms.Button button1;
    }
}