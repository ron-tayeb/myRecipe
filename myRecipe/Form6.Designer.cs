
namespace myRecipe
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtNametodelete = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnhome = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(28)))));
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(917, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 29);
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // txtNametodelete
            // 
            this.txtNametodelete.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.txtNametodelete.Location = new System.Drawing.Point(257, 300);
            this.txtNametodelete.Name = "txtNametodelete";
            this.txtNametodelete.Size = new System.Drawing.Size(149, 27);
            this.txtNametodelete.TabIndex = 24;
            this.txtNametodelete.TextChanged += new System.EventHandler(this.txtNametodelete_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(28)))));
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F);
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(18, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(398, 39);
            this.label2.TabIndex = 23;
            this.label2.Text = "Recipe name for delete";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(28)))));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(41, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 217);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Gray;
            this.btndelete.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F);
            this.btndelete.ForeColor = System.Drawing.SystemColors.Window;
            this.btndelete.Location = new System.Drawing.Point(257, 345);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(149, 37);
            this.btndelete.TabIndex = 26;
            this.btndelete.Text = "delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnhome
            // 
            this.btnhome.BackColor = System.Drawing.Color.Gray;
            this.btnhome.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F);
            this.btnhome.ForeColor = System.Drawing.SystemColors.Window;
            this.btnhome.Location = new System.Drawing.Point(244, 528);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(100, 37);
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
            this.button1.Location = new System.Drawing.Point(8, 528);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 37);
            this.button1.TabIndex = 28;
            this.button1.Text = "view all resipes";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnhome);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.txtNametodelete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form6_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form6_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form6_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtNametodelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnhome;
        private System.Windows.Forms.Button button1;
    }
}