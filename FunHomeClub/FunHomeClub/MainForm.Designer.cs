namespace FunHomeClub
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.systemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.courseRegistrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.admintrationFunctionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintainCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintainStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintainTeacherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintainStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintainCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setProfitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCourseDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invoiceHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.membershipSystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.promotionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.systemToolStripMenuItem,
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(768, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // systemToolStripMenuItem
            // 
            this.systemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            this.systemToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.systemToolStripMenuItem.Text = "System";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.L)));
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.E)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuToolStripMenuItem,
            this.courseRegistrationToolStripMenuItem,
            this.admintrationFunctionToolStripMenuItem,
            this.viewCourseDetailsToolStripMenuItem,
            this.invoiceHistoryToolStripMenuItem,
            this.searchCourseToolStripMenuItem,
            this.membershipSystemToolStripMenuItem,
            this.promotionToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            this.mainMenuToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.M)));
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.mainMenuToolStripMenuItem.Text = "Main Menu";
            this.mainMenuToolStripMenuItem.Click += new System.EventHandler(this.mainMenuToolStripMenuItem_Click);
            // 
            // courseRegistrationToolStripMenuItem
            // 
            this.courseRegistrationToolStripMenuItem.Name = "courseRegistrationToolStripMenuItem";
            this.courseRegistrationToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.R)));
            this.courseRegistrationToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.courseRegistrationToolStripMenuItem.Text = "Course Registration";
            this.courseRegistrationToolStripMenuItem.Click += new System.EventHandler(this.courseRegistrationToolStripMenuItem_Click);
            // 
            // admintrationFunctionToolStripMenuItem
            // 
            this.admintrationFunctionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maintainCourseToolStripMenuItem,
            this.maintainStaffToolStripMenuItem,
            this.maintainTeacherToolStripMenuItem,
            this.maintainStudentToolStripMenuItem,
            this.setProfitToolStripMenuItem,
            this.maintainCategoryToolStripMenuItem});
            this.admintrationFunctionToolStripMenuItem.Name = "admintrationFunctionToolStripMenuItem";
            this.admintrationFunctionToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.admintrationFunctionToolStripMenuItem.Text = "Admintration";
            // 
            // maintainCourseToolStripMenuItem
            // 
            this.maintainCourseToolStripMenuItem.Name = "maintainCourseToolStripMenuItem";
            this.maintainCourseToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.F1)));
            this.maintainCourseToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.maintainCourseToolStripMenuItem.Text = "Maintain Course";
            this.maintainCourseToolStripMenuItem.Click += new System.EventHandler(this.maintainCourseToolStripMenuItem_Click);
            // 
            // maintainStaffToolStripMenuItem
            // 
            this.maintainStaffToolStripMenuItem.Name = "maintainStaffToolStripMenuItem";
            this.maintainStaffToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.F2)));
            this.maintainStaffToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.maintainStaffToolStripMenuItem.Text = "Maintain Staff";
            this.maintainStaffToolStripMenuItem.Click += new System.EventHandler(this.maintainStaffToolStripMenuItem_Click);
            // 
            // maintainTeacherToolStripMenuItem
            // 
            this.maintainTeacherToolStripMenuItem.Name = "maintainTeacherToolStripMenuItem";
            this.maintainTeacherToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.F3)));
            this.maintainTeacherToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.maintainTeacherToolStripMenuItem.Text = "Maintain Teacher";
            this.maintainTeacherToolStripMenuItem.Click += new System.EventHandler(this.maintainTeacherToolStripMenuItem_Click);
            // 
            // maintainStudentToolStripMenuItem
            // 
            this.maintainStudentToolStripMenuItem.Name = "maintainStudentToolStripMenuItem";
            this.maintainStudentToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.F4)));
            this.maintainStudentToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.maintainStudentToolStripMenuItem.Text = "Maintain Student";
            this.maintainStudentToolStripMenuItem.Click += new System.EventHandler(this.maintainStudentToolStripMenuItem_Click);
            // 
            // maintainCategoryToolStripMenuItem
            // 
            this.maintainCategoryToolStripMenuItem.Name = "maintainCategoryToolStripMenuItem";
            this.maintainCategoryToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.F6)));
            this.maintainCategoryToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.maintainCategoryToolStripMenuItem.Text = "Maintain Category";
            this.maintainCategoryToolStripMenuItem.Click += new System.EventHandler(this.maintainCategoryToolStripMenuItem_Click);
            // 
            // setProfitToolStripMenuItem
            // 
            this.setProfitToolStripMenuItem.Name = "setProfitToolStripMenuItem";
            this.setProfitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.F5)));
            this.setProfitToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.setProfitToolStripMenuItem.Text = "Set Profit";
            this.setProfitToolStripMenuItem.Click += new System.EventHandler(this.setProfitToolStripMenuItem_Click);
            // 
            // viewCourseDetailsToolStripMenuItem
            // 
            this.viewCourseDetailsToolStripMenuItem.Name = "viewCourseDetailsToolStripMenuItem";
            this.viewCourseDetailsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.V)));
            this.viewCourseDetailsToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.viewCourseDetailsToolStripMenuItem.Text = "View Course Details";
            this.viewCourseDetailsToolStripMenuItem.Click += new System.EventHandler(this.viewCourseDetailsToolStripMenuItem_Click);
            // 
            // invoiceHistoryToolStripMenuItem
            // 
            this.invoiceHistoryToolStripMenuItem.Name = "invoiceHistoryToolStripMenuItem";
            this.invoiceHistoryToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.I)));
            this.invoiceHistoryToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.invoiceHistoryToolStripMenuItem.Text = "Invoice History";
            this.invoiceHistoryToolStripMenuItem.Click += new System.EventHandler(this.invoiceHistoryToolStripMenuItem_Click);
            // 
            // searchCourseToolStripMenuItem
            // 
            this.searchCourseToolStripMenuItem.Name = "searchCourseToolStripMenuItem";
            this.searchCourseToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.C)));
            this.searchCourseToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.searchCourseToolStripMenuItem.Text = "Search Course";
            this.searchCourseToolStripMenuItem.Click += new System.EventHandler(this.searchCourseToolStripMenuItem_Click);
            // 
            // membershipSystemToolStripMenuItem
            // 
            this.membershipSystemToolStripMenuItem.Name = "membershipSystemToolStripMenuItem";
            this.membershipSystemToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
            this.membershipSystemToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.membershipSystemToolStripMenuItem.Text = "Membership System";
            this.membershipSystemToolStripMenuItem.Click += new System.EventHandler(this.membershipSystemToolStripMenuItem_Click);
            // 
            // promotionToolStripMenuItem
            // 
            this.promotionToolStripMenuItem.Name = "promotionToolStripMenuItem";
            this.promotionToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.P)));
            this.promotionToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.promotionToolStripMenuItem.Text = "Promotion";
            this.promotionToolStripMenuItem.Click += new System.EventHandler(this.promotionToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(768, 483);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Fun-Home Club - Course Registration System";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed_1);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem systemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem courseRegistrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem admintrationFunctionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewCourseDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invoiceHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maintainCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setProfitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maintainStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maintainTeacherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maintainStaffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maintainCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem membershipSystemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem promotionToolStripMenuItem;
    }
}