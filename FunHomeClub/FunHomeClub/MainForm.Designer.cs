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
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.btn_viewCourseDetails = new System.Windows.Forms.Button();
            this.btn_adminFuc = new System.Windows.Forms.Button();
            this.gpb_adminFuc = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gpb_adminFuc.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.Location = new System.Drawing.Point(13, 40);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(55, 12);
            this.lbl_welcome.TabIndex = 0;
            this.lbl_welcome.Text = "Welcome, ";
            // 
            // btn_viewCourseDetails
            // 
            this.btn_viewCourseDetails.Location = new System.Drawing.Point(19, 38);
            this.btn_viewCourseDetails.Name = "btn_viewCourseDetails";
            this.btn_viewCourseDetails.Size = new System.Drawing.Size(160, 23);
            this.btn_viewCourseDetails.TabIndex = 1;
            this.btn_viewCourseDetails.Text = "Maintain Master Data";
            this.btn_viewCourseDetails.UseVisualStyleBackColor = true;
            // 
            // btn_adminFuc
            // 
            this.btn_adminFuc.Location = new System.Drawing.Point(19, 76);
            this.btn_adminFuc.Name = "btn_adminFuc";
            this.btn_adminFuc.Size = new System.Drawing.Size(160, 23);
            this.btn_adminFuc.TabIndex = 0;
            this.btn_adminFuc.Text = "Set Profit";
            this.btn_adminFuc.UseVisualStyleBackColor = true;
            // 
            // gpb_adminFuc
            // 
            this.gpb_adminFuc.Controls.Add(this.button1);
            this.gpb_adminFuc.Controls.Add(this.btn_viewCourseDetails);
            this.gpb_adminFuc.Controls.Add(this.btn_adminFuc);
            this.gpb_adminFuc.Location = new System.Drawing.Point(365, 80);
            this.gpb_adminFuc.Name = "gpb_adminFuc";
            this.gpb_adminFuc.Size = new System.Drawing.Size(200, 153);
            this.gpb_adminFuc.TabIndex = 3;
            this.gpb_adminFuc.TabStop = false;
            this.gpb_adminFuc.Text = "Adminstration Function";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Set Discount";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 261);
            this.Controls.Add(this.gpb_adminFuc);
            this.Controls.Add(this.lbl_welcome);
            this.Name = "FormMain";
            this.Text = "Main Menu";
            this.gpb_adminFuc.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.Button btn_viewCourseDetails;
        private System.Windows.Forms.Button btn_adminFuc;
        private System.Windows.Forms.GroupBox gpb_adminFuc;
        private System.Windows.Forms.Button button1;
    }
}