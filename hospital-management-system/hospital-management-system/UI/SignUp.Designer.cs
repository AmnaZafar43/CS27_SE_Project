namespace hospital_management_system.UI
{
    partial class SignUp
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.role_cbx = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Signupbtn = new System.Windows.Forms.Button();
            this.Loginbtn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.password_tbx = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Username_tbx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Exitbtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::hospital_management_system.Properties.Resources.icons8_username_32;
            this.pictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox2.Location = new System.Drawing.Point(4, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label7.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(109, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 21);
            this.label7.TabIndex = 11;
            this.label7.Text = "Select Role";
            // 
            // role_cbx
            // 
            this.role_cbx.FormattingEnabled = true;
            this.role_cbx.Items.AddRange(new object[] {
            "Doctor",
            "Surgeon",
            "Nurse",
            "Patient"});
            this.role_cbx.Location = new System.Drawing.Point(210, 255);
            this.role_cbx.Name = "role_cbx";
            this.role_cbx.Size = new System.Drawing.Size(112, 32);
            this.role_cbx.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(135, 394);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Go To Log In Page";
            // 
            // Signupbtn
            // 
            this.Signupbtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Signupbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Signupbtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Signupbtn.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Signupbtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Signupbtn.Location = new System.Drawing.Point(294, 388);
            this.Signupbtn.Name = "Signupbtn";
            this.Signupbtn.Size = new System.Drawing.Size(81, 32);
            this.Signupbtn.TabIndex = 7;
            this.Signupbtn.Text = "LogIn";
            this.Signupbtn.UseVisualStyleBackColor = false;
            this.Signupbtn.Click += new System.EventHandler(this.Signupbtn_Click);
            // 
            // Loginbtn
            // 
            this.Loginbtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.Loginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Loginbtn.ForeColor = System.Drawing.Color.White;
            this.Loginbtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Loginbtn.Location = new System.Drawing.Point(181, 307);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.Size = new System.Drawing.Size(106, 43);
            this.Loginbtn.TabIndex = 6;
            this.Loginbtn.Text = "SignUp";
            this.Loginbtn.UseVisualStyleBackColor = false;
            this.Loginbtn.Click += new System.EventHandler(this.Loginbtn_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.password_tbx);
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Location = new System.Drawing.Point(-1, 210);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(435, 33);
            this.panel4.TabIndex = 5;
            // 
            // password_tbx
            // 
            this.password_tbx.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.password_tbx.ForeColor = System.Drawing.Color.RoyalBlue;
            this.password_tbx.Location = new System.Drawing.Point(43, 3);
            this.password_tbx.Name = "password_tbx";
            this.password_tbx.Size = new System.Drawing.Size(386, 27);
            this.password_tbx.TabIndex = 2;
            this.password_tbx.UseSystemPasswordChar = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::hospital_management_system.Properties.Resources.icons8_password_32;
            this.pictureBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox3.Location = new System.Drawing.Point(4, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.role_cbx);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Signupbtn);
            this.panel1.Controls.Add(this.Loginbtn);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.panel1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 500);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.Username_tbx);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Location = new System.Drawing.Point(-1, 167);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(435, 33);
            this.panel3.TabIndex = 4;
            // 
            // Username_tbx
            // 
            this.Username_tbx.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Username_tbx.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Username_tbx.Location = new System.Drawing.Point(43, 3);
            this.Username_tbx.Name = "Username_tbx";
            this.Username_tbx.Size = new System.Drawing.Size(386, 27);
            this.Username_tbx.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(347, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "System";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(190, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hospital Management";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(290, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Welcome to";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(176, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sign Up";
            // 
            // Exitbtn
            // 
            this.Exitbtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.Exitbtn.FlatAppearance.BorderSize = 0;
            this.Exitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exitbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Exitbtn.ForeColor = System.Drawing.Color.White;
            this.Exitbtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Exitbtn.Location = new System.Drawing.Point(907, 2);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Size = new System.Drawing.Size(42, 38);
            this.Exitbtn.TabIndex = 4;
            this.Exitbtn.Text = "X";
            this.Exitbtn.UseVisualStyleBackColor = false;
            this.Exitbtn.Click += new System.EventHandler(this.Exitbtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Exitbtn);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(950, 500);
            this.panel2.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::hospital_management_system.Properties.Resources.Hospital_Management_System;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(950, 500);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 500);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUp";
            this.Text = "SignUp";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox role_cbx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Signupbtn;
        private System.Windows.Forms.Button Loginbtn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox password_tbx;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox Username_tbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Exitbtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}