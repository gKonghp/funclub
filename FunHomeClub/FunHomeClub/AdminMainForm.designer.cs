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
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Administrative", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Membership");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Promotions");
            this.tvControlForm = new System.Windows.Forms.TreeView();
            this.adminPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // tvControlForm
            // 
            this.tvControlForm.BackColor = System.Drawing.SystemColors.Control;
            this.tvControlForm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvControlForm.Location = new System.Drawing.Point(12, 11);
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
            treeNode6.Name = "Administrative";
            treeNode6.Text = "Administrative";
            treeNode7.Name = "Membership";
            treeNode7.Text = "Membership";
            treeNode8.Name = "Promotions";
            treeNode8.Text = "Promotions";
            this.tvControlForm.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8});
            this.tvControlForm.Size = new System.Drawing.Size(113, 291);
            this.tvControlForm.TabIndex = 0;
            this.tvControlForm.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvControlForm_AfterSelect);
            // 
            // adminPanel
            // 
            this.adminPanel.Location = new System.Drawing.Point(121, 12);
            this.adminPanel.Name = "adminPanel";
            this.adminPanel.Size = new System.Drawing.Size(894, 290);
            this.adminPanel.TabIndex = 1;
            // 
            // AdminMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 313);
            this.Controls.Add(this.adminPanel);
            this.Controls.Add(this.tvControlForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminMainForm";
            this.Text = "AdminMainForm";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel adminPanel;
        public System.Windows.Forms.TreeView tvControlForm;
    }
}