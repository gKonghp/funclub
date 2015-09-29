namespace FunHomeClub
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAdministration_Link = new System.Windows.Forms.Button();
            this.btnViewCourseInfo_Link = new System.Windows.Forms.Button();
            this.btnInvoiceHistory_Link = new System.Windows.Forms.Button();
            this.btnCourseReg_Link = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_welcome.Location = new System.Drawing.Point(12, 83);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(104, 24);
            this.lbl_welcome.TabIndex = 0;
            this.lbl_welcome.Text = "Welcome, ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(422, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Position:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(422, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Employee ID:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(596, 71);
            this.panel1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(95, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Main Menu";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FunHomeClub.Properties.Resources.GUI_Assignment_smallIcon;
            this.pictureBox1.Location = new System.Drawing.Point(11, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnAdministration_Link
            // 
            this.btnAdministration_Link.BackColor = System.Drawing.Color.Coral;
            this.btnAdministration_Link.FlatAppearance.BorderSize = 0;
            this.btnAdministration_Link.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdministration_Link.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAdministration_Link.ForeColor = System.Drawing.Color.White;
            this.btnAdministration_Link.Image = ((System.Drawing.Image)(resources.GetObject("btnAdministration_Link.Image")));
            this.btnAdministration_Link.Location = new System.Drawing.Point(290, 136);
            this.btnAdministration_Link.Name = "btnAdministration_Link";
            this.btnAdministration_Link.Size = new System.Drawing.Size(221, 85);
            this.btnAdministration_Link.TabIndex = 11;
            this.btnAdministration_Link.Text = "Administraion";
            this.btnAdministration_Link.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdministration_Link.UseVisualStyleBackColor = false;
            this.btnAdministration_Link.Click += new System.EventHandler(this.btnAdministration_Link_Click);
            // 
            // btnViewCourseInfo_Link
            // 
            this.btnViewCourseInfo_Link.BackColor = System.Drawing.Color.Coral;
            this.btnViewCourseInfo_Link.FlatAppearance.BorderSize = 0;
            this.btnViewCourseInfo_Link.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewCourseInfo_Link.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnViewCourseInfo_Link.ForeColor = System.Drawing.Color.White;
            this.btnViewCourseInfo_Link.Image = ((System.Drawing.Image)(resources.GetObject("btnViewCourseInfo_Link.Image")));
            this.btnViewCourseInfo_Link.Location = new System.Drawing.Point(63, 136);
            this.btnViewCourseInfo_Link.Name = "btnViewCourseInfo_Link";
            this.btnViewCourseInfo_Link.Size = new System.Drawing.Size(219, 85);
            this.btnViewCourseInfo_Link.TabIndex = 9;
            this.btnViewCourseInfo_Link.TabStop = false;
            this.btnViewCourseInfo_Link.Text = "View Course Information";
            this.btnViewCourseInfo_Link.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnViewCourseInfo_Link.UseVisualStyleBackColor = false;
            this.btnViewCourseInfo_Link.Click += new System.EventHandler(this.btnViewCourseInfo_Link_Click);
            // 
            // btnInvoiceHistory_Link
            // 
            this.btnInvoiceHistory_Link.BackColor = System.Drawing.Color.Coral;
            this.btnInvoiceHistory_Link.FlatAppearance.BorderSize = 0;
            this.btnInvoiceHistory_Link.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvoiceHistory_Link.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnInvoiceHistory_Link.ForeColor = System.Drawing.Color.White;
            this.btnInvoiceHistory_Link.Image = ((System.Drawing.Image)(resources.GetObject("btnInvoiceHistory_Link.Image")));
            this.btnInvoiceHistory_Link.Location = new System.Drawing.Point(290, 228);
            this.btnInvoiceHistory_Link.Name = "btnInvoiceHistory_Link";
            this.btnInvoiceHistory_Link.Size = new System.Drawing.Size(219, 85);
            this.btnInvoiceHistory_Link.TabIndex = 5;
            this.btnInvoiceHistory_Link.Text = "Invoice History";
            this.btnInvoiceHistory_Link.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInvoiceHistory_Link.UseVisualStyleBackColor = false;
            this.btnInvoiceHistory_Link.Click += new System.EventHandler(this.btnInvoiceHistory_Click);
            // 
            // btnCourseReg_Link
            // 
            this.btnCourseReg_Link.BackColor = System.Drawing.Color.Coral;
            this.btnCourseReg_Link.FlatAppearance.BorderSize = 0;
            this.btnCourseReg_Link.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCourseReg_Link.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCourseReg_Link.ForeColor = System.Drawing.Color.White;
            this.btnCourseReg_Link.Image = global::FunHomeClub.Properties.Resources.CourseReg;
            this.btnCourseReg_Link.Location = new System.Drawing.Point(63, 228);
            this.btnCourseReg_Link.Name = "btnCourseReg_Link";
            this.btnCourseReg_Link.Size = new System.Drawing.Size(219, 85);
            this.btnCourseReg_Link.TabIndex = 4;
            this.btnCourseReg_Link.Text = "Course Registration";
            this.btnCourseReg_Link.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCourseReg_Link.UseVisualStyleBackColor = false;
            this.btnCourseReg_Link.Click += new System.EventHandler(this.btnCourseReg_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(594, 337);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAdministration_Link);
            this.Controls.Add(this.btnViewCourseInfo_Link);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnInvoiceHistory_Link);
            this.Controls.Add(this.btnCourseReg_Link);
            this.Controls.Add(this.lbl_welcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuForm";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.Button btnCourseReg_Link;
        private System.Windows.Forms.Button btnInvoiceHistory_Link;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnViewCourseInfo_Link;
        private System.Windows.Forms.Button btnAdministration_Link;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}