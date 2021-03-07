
namespace myRecipe
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrep = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbMED = new System.Windows.Forms.RadioButton();
            this.rbHARD = new System.Windows.Forms.RadioButton();
            this.rbEASY = new System.Windows.Forms.RadioButton();
            this.btnInsert = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnhome = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
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
            this.label1.Location = new System.Drawing.Point(4, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "insert resipe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(28)))));
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13F);
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(15, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(28)))));
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13F);
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(18, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ingredients";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(28)))));
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13F);
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(15, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 26);
            this.label4.TabIndex = 2;
            this.label4.Text = "calories";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.txtName.Location = new System.Drawing.Point(120, 153);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 27);
            this.txtName.TabIndex = 3;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtCal
            // 
            this.txtCal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.txtCal.Location = new System.Drawing.Point(137, 207);
            this.txtCal.Name = "txtCal";
            this.txtCal.Size = new System.Drawing.Size(122, 27);
            this.txtCal.TabIndex = 4;
            this.txtCal.TextChanged += new System.EventHandler(this.txtCal_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(28)))));
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13F);
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(18, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 26);
            this.label5.TabIndex = 6;
            this.label5.Text = "preparation time";
            // 
            // txtPrep
            // 
            this.txtPrep.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.txtPrep.Location = new System.Drawing.Point(233, 260);
            this.txtPrep.Name = "txtPrep";
            this.txtPrep.Size = new System.Drawing.Size(75, 27);
            this.txtPrep.TabIndex = 7;
            this.txtPrep.TextChanged += new System.EventHandler(this.txtPrep_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(28)))));
            this.groupBox1.Controls.Add(this.rbMED);
            this.groupBox1.Controls.Add(this.rbHARD);
            this.groupBox1.Controls.Add(this.rbEASY);
            this.groupBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13F);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Location = new System.Drawing.Point(6, 355);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(149, 155);
            this.groupBox1.TabIndex = 8;
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
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.Gray;
            this.btnInsert.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F);
            this.btnInsert.ForeColor = System.Drawing.SystemColors.Window;
            this.btnInsert.Location = new System.Drawing.Point(10, 528);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(115, 37);
            this.btnInsert.TabIndex = 10;
            this.btnInsert.Text = "insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F);
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(259, 528);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 37);
            this.button1.TabIndex = 11;
            this.button1.Text = "view all resipes";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(161, 312);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(206, 118);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // btnhome
            // 
            this.btnhome.BackColor = System.Drawing.Color.Gray;
            this.btnhome.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F);
            this.btnhome.ForeColor = System.Drawing.SystemColors.Window;
            this.btnhome.Location = new System.Drawing.Point(141, 528);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(112, 37);
            this.btnhome.TabIndex = 14;
            this.btnhome.Text = "home";
            this.btnhome.UseVisualStyleBackColor = false;
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(28)))));
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(929, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 29);
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(962, 577);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnhome);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtPrep);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCal);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrep;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbMED;
        private System.Windows.Forms.RadioButton rbHARD;
        private System.Windows.Forms.RadioButton rbEASY;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnhome;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}