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
            this.btnMargin = new XButton();
            this.txtMargin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMargin
            // 
            this.btnMargin.BackColor = System.Drawing.Color.Coral;
            this.btnMargin.FlatAppearance.BorderSize = 0;
            this.btnMargin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMargin.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMargin.ForeColor = System.Drawing.Color.White;
            this.btnMargin.Location = new System.Drawing.Point(364, 8);
            this.btnMargin.Name = "btnMargin";
            this.btnMargin.Size = new System.Drawing.Size(75, 29);
            this.btnMargin.TabIndex = 8;
            this.btnMargin.Text = "Modify";
            this.btnMargin.UseVisualStyleBackColor = false;
            this.btnMargin.Click += new System.EventHandler(this.btnMargin_Click);
            // 
            // txtMargin
            // 
            this.txtMargin.BackColor = System.Drawing.SystemColors.Control;
            this.txtMargin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMargin.Enabled = false;
            this.txtMargin.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMargin.Location = new System.Drawing.Point(183, 14);
            this.txtMargin.Name = "txtMargin";
            this.txtMargin.Size = new System.Drawing.Size(124, 20);
            this.txtMargin.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(15, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Current profit margin:";
            // 
            // ProfitMarginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnMargin);
            this.Controls.Add(this.txtMargin);
            this.Controls.Add(this.label1);
            this.Name = "ProfitMarginControl";
            this.Size = new System.Drawing.Size(453, 45);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XButton btnMargin;
        private System.Windows.Forms.TextBox txtMargin;
        private System.Windows.Forms.Label label1;
    }
}
