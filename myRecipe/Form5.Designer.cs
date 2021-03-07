
namespace myRecipe
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNametoupdate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextinger = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbMED = new System.Windows.Forms.RadioButton();
            this.rbHARD = new System.Windows.Forms.RadioButton();
            this.rbEASY = new System.Windows.Forms.RadioButton();
            this.txtPrep = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCal = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnhome = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(28)))));
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(589, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "update resipe";
            // 
            // txtNametoupdate
            // 
            this.txtNametoupdate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.txtNametoupdate.Location = new System.Drawing.Point(820, 91);
            this.txtNametoupdate.Name = "txtNametoupdate";
            this.txtNametoupdate.Size = new System.Drawing.Size(100, 27);
            this.txtNametoupdate.TabIndex = 15;
            this.txtNametoupdate.TextChanged += new System.EventHandler(this.txtNametoupdate_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(28)))));
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13F);
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(533, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 26);
            this.label2.TabIndex = 14;
            this.label2.Text = "Recipe name for update";
            // 
            // richTextinger
            // 
            this.richTextinger.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextinger.Location = new System.Drawing.Point(678, 289);
            this.richTextinger.Name = "richTextinger";
            this.richTextinger.Size = new System.Drawing.Size(264, 170);
            this.richTextinger.TabIndex = 24;
            this.richTextinger.Text = "";
            this.richTextinger.TextChanged += new System.EventHandler(this.richTextinger_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(28)))));
            this.groupBox1.Controls.Add(this.rbMED);
            this.groupBox1.Controls.Add(this.rbHARD);
            this.groupBox1.Controls.Add(this.rbEASY);
            this.groupBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13F);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Location = new System.Drawing.Point(523, 332);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(149, 155);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Difficulty";
            // 
            // rbMED
            // 
            this.rbMED.AutoSize = true;
            this.rbMED.Location = new System.Drawing.Point(6, 80);
            this.rbMED.Name = "rbMED";
            this.rbMED.Size = new System.Drawing.Size(117, 30);
            this.rbMED.TabIndex = 2;
            this.rbMED.TabStop = true;
            this.rbMED.Text = "medium";
            this.rbMED.UseVisualStyleBackColor = true;
            this.rbMED.CheckedChanged += new System.EventHandler(this.rbMED_CheckedChanged);
            // 
            // rbHARD
            // 
            this.rbHARD.AutoSize = true;
            this.rbHARD.Location = new System.Drawing.Point(6, 119);
            this.rbHARD.Name = "rbHARD";
            this.rbHARD.Size = new System.Drawing.Size(83, 30);
            this.rbHARD.TabIndex = 1;
            this.rbHARD.TabStop = true;
            this.rbHARD.Text = "hard";
            this.rbHARD.UseVisualStyleBackColor = true;
            this.rbHARD.CheckedChanged += new System.EventHandler(this.rbHARD_CheckedChanged);
            // 
            // rbEASY
            // 
            this.rbEASY.AutoSize = true;
            this.rbEASY.Location = new System.Drawing.Point(6, 44);
            this.rbEASY.Name = "rbEASY";
            this.rbEASY.Size = new System.Drawing.Size(83, 30);
            this.rbEASY.TabIndex = 0;
            this.rbEASY.TabStop = true;
            this.rbEASY.Text = "easy";
            this.rbEASY.UseVisualStyleBackColor = true;
            this.rbEASY.CheckedChanged += new System.EventHandler(this.rbEASY_CheckedChanged);
            // 
            // txtPrep
            // 
            this.txtPrep.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.txtPrep.Location = new System.Drawing.Point(751, 244);
            this.txtPrep.Name = "txtPrep";
            this.txtPrep.Size = new System.Drawing.Size(75, 27);
            this.txtPrep.TabIndex = 22;
            this.txtPrep.TextChanged += new System.EventHandler(this.txtPrep_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(28)))));
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13F);
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(536, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 26);
            this.label5.TabIndex = 21;
            this.label5.Text = "preparation time";
            // 
            // txtCal
            // 
            this.txtCal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.txtCal.Location = new System.Drawing.Point(655, 191);
            this.txtCal.Name = "txtCal";
            this.txtCal.Size = new System.Drawing.Size(122, 27);
            this.txtCal.TabIndex = 20;
            this.txtCal.TextChanged += new System.EventHandler(this.txtCal_TextChanged);
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.txtname.Location = new System.Drawing.Point(609, 137);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 27);
            this.txtname.TabIndex = 19;
            this.txtname.TextChanged += new System.EventHandler(this.txtname_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(28)))));
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13F);
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(533, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 26);
            this.label4.TabIndex = 17;
            this.label4.Text = "calories";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(28)))));
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13F);
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(537, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 26);
            this.label3.TabIndex = 18;
            this.label3.Text = "Ingredients";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(28)))));
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13F);
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(533, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 26);
            this.label6.TabIndex = 16;
            this.label6.Text = "name";
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.Gray;
            this.btnInsert.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F);
            this.btnInsert.ForeColor = System.Drawing.SystemColors.Window;
            this.btnInsert.Location = new System.Drawing.Point(464, 528);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(111, 37);
            this.btnInsert.TabIndex = 25;
            this.btnInsert.Text = "update";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnhome
            // 
            this.btnhome.BackColor = System.Drawing.Color.Gray;
            this.btnhome.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F);
            this.btnhome.ForeColor = System.Drawing.SystemColors.Window;
            this.btnhome.Location = new System.Drawing.Point(581, 528);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(112, 37);
            this.btnhome.TabIndex = 26;
            this.btnhome.Text = "home";
            this.btnhome.UseVisualStyleBackColor = false;
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(28)))));
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(921, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 29);
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F);
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(699, 528);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 37);
            this.button1.TabIndex = 28;
            this.button1.Text = "view all resipes";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnhome);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.richTextinger);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtPrep);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCal);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNametoupdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form5_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form5_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form5_MouseUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNametoupdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextinger;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbMED;
        private System.Windows.Forms.RadioButton rbHARD;
        private System.Windows.Forms.RadioButton rbEASY;
        private System.Windows.Forms.TextBox txtPrep;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCal;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnhome;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
    }
}