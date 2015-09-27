namespace FunHomeClub
{
    partial class UserControlStaff
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_adminFuc = new System.Windows.Forms.Button();
            this.btn_viewCourseDetails = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            // btn_viewCourseDetails
            // 
            this.btn_viewCourseDetails.Location = new System.Drawing.Point(19, 38);
            this.btn_viewCourseDetails.Name = "btn_viewCourseDetails";
            this.btn_viewCourseDetails.Size = new System.Drawing.Size(160, 23);
            this.btn_viewCourseDetails.TabIndex = 1;
            this.btn_viewCourseDetails.Text = "Maintain Master Data";
            this.btn_viewCourseDetails.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btn_viewCourseDetails);
            this.groupBox1.Controls.Add(this.btn_adminFuc);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 153);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adminstration Function";
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
            // UserControlStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "UserControlStaff";
            this.Size = new System.Drawing.Size(395, 245);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_adminFuc;
        private System.Windows.Forms.Button btn_viewCourseDetails;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
    }
}
