namespace FunHomeClub
{
    partial class AdminMainForm
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Course");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Staff");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Teacher");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Student");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Profit Margin");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Category");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Administration", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6});
            this.tvControlForm = new System.Windows.Forms.TreeView();
            this.adminPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvControlForm
            // 
            this.tvControlForm.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tvControlForm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvControlForm.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tvControlForm.Location = new System.Drawing.Point(11, 82);
            this.tvControlForm.Name = "tvControlForm";
            treeNode1.Name = "Course";
            treeNode1.Text = "Course";
            treeNode2.Name = "Staff";
            treeNode2.Text = "Staff";
            treeNode3.Name = "Teacher";
            treeNode3.Text = "Teacher";
            treeNode4.Name = "Student";
            treeNode4.Text = "Student";
            treeNode5.Name = "ProfitMargin";
            treeNode5.Text = "Profit Margin";
            treeNode6.Name = "Category";
            treeNode6.Text = "Category";
            treeNode7.Name = "Administration";
            treeNode7.Text = "Administration";
            this.tvControlForm.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode7});
            this.tvControlForm.Size = new System.Drawing.Size(144, 291);
            this.tvControlForm.TabIndex = 0;
            this.tvControlForm.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvControlForm_AfterSelect);
            // 
            // adminPanel
            // 
            this.adminPanel.AutoSize = true;
            this.adminPanel.Location = new System.Drawing.Point(162, 82);
            this.adminPanel.Name = "adminPanel";
            this.adminPanel.Size = new System.Drawing.Size(853, 290);
            this.adminPanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1027, 71);
            this.panel1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(95, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Administrative Function";
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
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.tvControlForm);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(155, 386);
            this.panel2.TabIndex = 18;
            // 
            // AdminMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1027, 382);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.adminPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminMainForm";
            this.Text = "AdminMainForm";
            this.Load += new System.EventHandler(this.AdminMainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel adminPanel;
        public System.Windows.Forms.TreeView tvControlForm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
    }
}