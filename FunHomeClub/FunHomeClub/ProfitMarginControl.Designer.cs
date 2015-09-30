namespace FunHomeClub
{
    partial class ProfitMarginControl
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
            this.btnMargin = new System.Windows.Forms.Button();
            this.txtMargin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMargin
            // 
            this.btnMargin.Location = new System.Drawing.Point(247, 9);
            this.btnMargin.Name = "btnMargin";
            this.btnMargin.Size = new System.Drawing.Size(75, 25);
            this.btnMargin.TabIndex = 8;
            this.btnMargin.Text = "Modify";
            this.btnMargin.UseVisualStyleBackColor = true;
            this.btnMargin.Click += new System.EventHandler(this.btnMargin_Click);
            // 
            // txtMargin
            // 
            this.txtMargin.Enabled = false;
            this.txtMargin.Location = new System.Drawing.Point(130, 12);
            this.txtMargin.Name = "txtMargin";
            this.txtMargin.Size = new System.Drawing.Size(100, 20);
            this.txtMargin.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Current profit margin:";
            // 
            // ProfitMarginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnMargin);
            this.Controls.Add(this.txtMargin);
            this.Controls.Add(this.label1);
            this.Name = "ProfitMarginControl";
            this.Size = new System.Drawing.Size(339, 43);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMargin;
        private System.Windows.Forms.TextBox txtMargin;
        private System.Windows.Forms.Label label1;
    }
}
