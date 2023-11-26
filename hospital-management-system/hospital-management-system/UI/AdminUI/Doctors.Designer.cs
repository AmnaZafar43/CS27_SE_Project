namespace hospital_management_system.UI.AdminUI
{
    partial class Doctors
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Update_btn = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.Contact_textBox = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Name_tbx = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Specialization_tbx = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Email_textBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.Dcotors_dgv = new System.Windows.Forms.DataGridView();
            this.DELETE = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dcotors_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // Update_btn
            // 
            this.Update_btn.BackColor = System.Drawing.Color.RoyalBlue;
            this.Update_btn.FlatAppearance.BorderSize = 0;
            this.Update_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update_btn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_btn.ForeColor = System.Drawing.Color.White;
            this.Update_btn.Location = new System.Drawing.Point(129, 3);
            this.Update_btn.Name = "Update_btn";
            this.Update_btn.Size = new System.Drawing.Size(120, 23);
            this.Update_btn.TabIndex = 1;
            this.Update_btn.Text = "UPDATE";
            this.Update_btn.UseVisualStyleBackColor = false;
            this.Update_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.Contact_textBox);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(360, 84);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(351, 53);
            this.flowLayoutPanel2.TabIndex = 8;
            // 
            // Contact_textBox
            // 
            this.Contact_textBox.AcceptsReturn = true;
            this.Contact_textBox.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contact_textBox.ForeColor = System.Drawing.Color.Silver;
            this.Contact_textBox.Location = new System.Drawing.Point(13, 13);
            this.Contact_textBox.MaxLength = 11;
            this.Contact_textBox.Name = "Contact_textBox";
            this.Contact_textBox.Size = new System.Drawing.Size(332, 27);
            this.Contact_textBox.TabIndex = 1;
            this.Contact_textBox.Text = "Contact";
            this.Contact_textBox.Enter += new System.EventHandler(this.Contact_textBox_Enter);
            this.Contact_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Contact_textBox_KeyPress);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(3, 3);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(120, 23);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(360, 143);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.panel4.Size = new System.Drawing.Size(351, 28);
            this.panel4.TabIndex = 5;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.btn_add);
            this.flowLayoutPanel3.Controls.Add(this.Update_btn);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 241);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(714, 32);
            this.flowLayoutPanel3.TabIndex = 3;
            this.flowLayoutPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel3_Paint);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 143);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.panel2.Size = new System.Drawing.Size(351, 28);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(261, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Doctors";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Name_tbx);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.panel1.Size = new System.Drawing.Size(351, 75);
            this.panel1.TabIndex = 0;
            // 
            // Name_tbx
            // 
            this.Name_tbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Name_tbx.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_tbx.ForeColor = System.Drawing.Color.Silver;
            this.Name_tbx.Location = new System.Drawing.Point(10, 10);
            this.Name_tbx.Name = "Name_tbx";
            this.Name_tbx.Size = new System.Drawing.Size(331, 27);
            this.Name_tbx.TabIndex = 0;
            this.Name_tbx.Text = "Name";
            this.Name_tbx.Enter += new System.EventHandler(this.textBox1_Enter);
            this.Name_tbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(714, 52);
            this.panel5.TabIndex = 2;
            // 
            // Specialization_tbx
            // 
            this.Specialization_tbx.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Specialization_tbx.ForeColor = System.Drawing.Color.Silver;
            this.Specialization_tbx.Location = new System.Drawing.Point(13, 13);
            this.Specialization_tbx.Name = "Specialization_tbx";
            this.Specialization_tbx.Size = new System.Drawing.Size(332, 27);
            this.Specialization_tbx.TabIndex = 1;
            this.Specialization_tbx.Text = "Specialization";
            this.Specialization_tbx.Enter += new System.EventHandler(this.Specialization_tbx_Enter);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Email_textBox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 84);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10);
            this.panel3.Size = new System.Drawing.Size(351, 53);
            this.panel3.TabIndex = 6;
            // 
            // Email_textBox
            // 
            this.Email_textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Email_textBox.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_textBox.ForeColor = System.Drawing.Color.Silver;
            this.Email_textBox.Location = new System.Drawing.Point(10, 10);
            this.Email_textBox.Name = "Email_textBox";
            this.Email_textBox.Size = new System.Drawing.Size(331, 27);
            this.Email_textBox.TabIndex = 1;
            this.Email_textBox.Text = "Email";
            this.Email_textBox.Enter += new System.EventHandler(this.Email_textBox_Enter);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.Specialization_tbx);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(360, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(351, 75);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 61);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.55172F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.90805F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.96552F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(714, 174);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.panel5, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.flowLayoutPanel3, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.Dcotors_dgv, 0, 3);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 4;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.46352F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.53648F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 213F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(720, 490);
            this.tableLayoutPanel5.TabIndex = 6;
            // 
            // Dcotors_dgv
            // 
            this.Dcotors_dgv.AllowUserToAddRows = false;
            this.Dcotors_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dcotors_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dcotors_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DELETE,
            this.Update});
            this.Dcotors_dgv.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dcotors_dgv.DefaultCellStyle = dataGridViewCellStyle1;
            this.Dcotors_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dcotors_dgv.Location = new System.Drawing.Point(3, 279);
            this.Dcotors_dgv.Name = "Dcotors_dgv";
            this.Dcotors_dgv.Size = new System.Drawing.Size(714, 208);
            this.Dcotors_dgv.TabIndex = 4;
            this.Dcotors_dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dcotors_dgv_CellContentClick);
            // 
            // DELETE
            // 
            this.DELETE.HeaderText = "Delete";
            this.DELETE.Name = "DELETE";
            this.DELETE.Text = "Delete";
            this.DELETE.UseColumnTextForButtonValue = true;
            // 
            // Update
            // 
            this.Update.HeaderText = "Update";
            this.Update.Name = "Update";
            this.Update.Text = "Update";
            // 
            // Doctors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel5);
            this.Name = "Doctors";
            this.Size = new System.Drawing.Size(720, 490);
            this.Load += new System.EventHandler(this.Doctors_Load);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dcotors_dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Update_btn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TextBox Contact_textBox;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Name_tbx;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox Specialization_tbx;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox Email_textBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.DataGridView Dcotors_dgv;
        private System.Windows.Forms.DataGridViewButtonColumn DELETE;
        private System.Windows.Forms.DataGridViewButtonColumn Update;
    }
}
