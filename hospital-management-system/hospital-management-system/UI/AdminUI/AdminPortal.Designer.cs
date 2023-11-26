namespace hospital_management_system.UI.AdminUI
{
    partial class AdminPortal
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.doctors1 = new hospital_management_system.UI.AdminUI.Doctors();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_rubriclevel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Rubric = new System.Windows.Forms.Button();
            this.btn_assesments = new System.Windows.Forms.Button();
            this.btn_attendance = new System.Windows.Forms.Button();
            this.btn_CLO = new System.Windows.Forms.Button();
            this.btn_Student = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.panel14);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(220, 76);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(814, 605);
            this.panel4.TabIndex = 5;
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.doctors1);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel14.Location = new System.Drawing.Point(0, 0);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(814, 605);
            this.panel14.TabIndex = 0;
            // 
            // doctors1
            // 
            this.doctors1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.doctors1.Location = new System.Drawing.Point(0, 0);
            this.doctors1.Name = "doctors1";
            this.doctors1.Size = new System.Drawing.Size(814, 605);
            this.doctors1.TabIndex = 0;
            this.doctors1.Load += new System.EventHandler(this.doctors1_Load);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.Controls.Add(this.tableLayoutPanel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(220, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(5);
            this.panel3.Size = new System.Drawing.Size(814, 76);
            this.panel3.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(230, 0, 0, 0);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(804, 66);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(233, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10);
            this.label1.Size = new System.Drawing.Size(486, 66);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hospital Management System (Admin Portal)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_rubriclevel
            // 
            this.btn_rubriclevel.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_rubriclevel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_rubriclevel.FlatAppearance.BorderSize = 0;
            this.btn_rubriclevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rubriclevel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rubriclevel.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_rubriclevel.Location = new System.Drawing.Point(0, 404);
            this.btn_rubriclevel.Name = "btn_rubriclevel";
            this.btn_rubriclevel.Size = new System.Drawing.Size(220, 51);
            this.btn_rubriclevel.TabIndex = 10;
            this.btn_rubriclevel.Text = "WARDs";
            this.btn_rubriclevel.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_rubriclevel);
            this.panel1.Controls.Add(this.btn_Rubric);
            this.panel1.Controls.Add(this.btn_assesments);
            this.panel1.Controls.Add(this.btn_attendance);
            this.panel1.Controls.Add(this.btn_CLO);
            this.panel1.Controls.Add(this.btn_Student);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 681);
            this.panel1.TabIndex = 3;
            // 
            // btn_Rubric
            // 
            this.btn_Rubric.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Rubric.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Rubric.FlatAppearance.BorderSize = 0;
            this.btn_Rubric.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Rubric.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Rubric.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Rubric.Location = new System.Drawing.Point(0, 353);
            this.btn_Rubric.Name = "btn_Rubric";
            this.btn_Rubric.Size = new System.Drawing.Size(220, 51);
            this.btn_Rubric.TabIndex = 5;
            this.btn_Rubric.Text = "     PHARMACy";
            this.btn_Rubric.UseVisualStyleBackColor = false;
            // 
            // btn_assesments
            // 
            this.btn_assesments.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_assesments.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_assesments.FlatAppearance.BorderSize = 0;
            this.btn_assesments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_assesments.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_assesments.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_assesments.Location = new System.Drawing.Point(0, 302);
            this.btn_assesments.Name = "btn_assesments";
            this.btn_assesments.Size = new System.Drawing.Size(220, 51);
            this.btn_assesments.TabIndex = 4;
            this.btn_assesments.Text = "    SURGEONs";
            this.btn_assesments.UseVisualStyleBackColor = false;
            // 
            // btn_attendance
            // 
            this.btn_attendance.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_attendance.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_attendance.FlatAppearance.BorderSize = 0;
            this.btn_attendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_attendance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_attendance.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_attendance.Location = new System.Drawing.Point(0, 251);
            this.btn_attendance.Name = "btn_attendance";
            this.btn_attendance.Size = new System.Drawing.Size(220, 51);
            this.btn_attendance.TabIndex = 3;
            this.btn_attendance.Text = "NURSEs";
            this.btn_attendance.UseVisualStyleBackColor = false;
            // 
            // btn_CLO
            // 
            this.btn_CLO.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_CLO.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_CLO.FlatAppearance.BorderSize = 0;
            this.btn_CLO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CLO.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CLO.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_CLO.Location = new System.Drawing.Point(0, 200);
            this.btn_CLO.Name = "btn_CLO";
            this.btn_CLO.Size = new System.Drawing.Size(220, 51);
            this.btn_CLO.TabIndex = 2;
            this.btn_CLO.Text = "PATIENTs";
            this.btn_CLO.UseVisualStyleBackColor = false;
            // 
            // btn_Student
            // 
            this.btn_Student.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Student.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Student.FlatAppearance.BorderSize = 0;
            this.btn_Student.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Student.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Student.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Student.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_Student.Location = new System.Drawing.Point(0, 149);
            this.btn_Student.Name = "btn_Student";
            this.btn_Student.Size = new System.Drawing.Size(220, 51);
            this.btn_Student.TabIndex = 1;
            this.btn_Student.Text = " DOCTORs";
            this.btn_Student.UseVisualStyleBackColor = false;
            this.btn_Student.Click += new System.EventHandler(this.btn_Student_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 149);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::hospital_management_system.Properties.Resources.hospital;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(51, 558);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 51);
            this.button1.TabIndex = 11;
            this.button1.Text = "EXIT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminPortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 681);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminPortal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPortal";
            this.Load += new System.EventHandler(this.AdminPortal_Load);
            this.panel4.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_rubriclevel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Rubric;
        private System.Windows.Forms.Button btn_assesments;
        private System.Windows.Forms.Button btn_attendance;
        private System.Windows.Forms.Button btn_CLO;
        private System.Windows.Forms.Button btn_Student;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel14;
        private Doctors doctors1;
        private System.Windows.Forms.Button button1;
    }
}