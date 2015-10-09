namespace FunHomeClub
{
    partial class PromotionControl
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
            this.lstPromotion = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDeleteStudent = new XButton();
            this.btnMaintainStudent = new XButton();
            this.button3 = new XButton();
            this.SuspendLayout();
            // 
            // lstPromotion
            // 
            this.lstPromotion.BackColor = System.Drawing.SystemColors.Control;
            this.lstPromotion.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17});
            this.lstPromotion.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lstPromotion.Location = new System.Drawing.Point(10, 8);
            this.lstPromotion.Name = "lstPromotion";
            this.lstPromotion.Size = new System.Drawing.Size(573, 241);
            this.lstPromotion.TabIndex = 3;
            this.lstPromotion.UseCompatibleStateImageBehavior = false;
            this.lstPromotion.View = System.Windows.Forms.View.Details;
            this.lstPromotion.SelectedIndexChanged += new System.EventHandler(this.lstPromotion_SelectedIndexChanged);
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "PromotionID";
            this.columnHeader10.Width = 89;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Name";
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Description";
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "AdditionalDiscount";
            this.columnHeader15.Width = 227;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "StartTime";
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "EndTime";
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.BackColor = System.Drawing.Color.Coral;
            this.btnDeleteStudent.Enabled = false;
            this.btnDeleteStudent.FlatAppearance.BorderSize = 0;
            this.btnDeleteStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteStudent.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDeleteStudent.ForeColor = System.Drawing.Color.White;
            this.btnDeleteStudent.Location = new System.Drawing.Point(602, 90);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(97, 26);
            this.btnDeleteStudent.TabIndex = 12;
            this.btnDeleteStudent.Text = "Delete";
            this.btnDeleteStudent.UseVisualStyleBackColor = false;
            this.btnDeleteStudent.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMaintainStudent
            // 
            this.btnMaintainStudent.BackColor = System.Drawing.Color.Coral;
            this.btnMaintainStudent.Enabled = false;
            this.btnMaintainStudent.FlatAppearance.BorderSize = 0;
            this.btnMaintainStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaintainStudent.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMaintainStudent.ForeColor = System.Drawing.Color.White;
            this.btnMaintainStudent.Location = new System.Drawing.Point(602, 50);
            this.btnMaintainStudent.Name = "btnMaintainStudent";
            this.btnMaintainStudent.Size = new System.Drawing.Size(97, 26);
            this.btnMaintainStudent.TabIndex = 11;
            this.btnMaintainStudent.Text = "Change";
            this.btnMaintainStudent.UseVisualStyleBackColor = false;
            this.btnMaintainStudent.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Coral;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(602, 8);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 26);
            this.button3.TabIndex = 10;
            this.button3.Text = "Add";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // PromotionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnDeleteStudent);
            this.Controls.Add(this.btnMaintainStudent);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lstPromotion);
            this.Name = "PromotionControl";
            this.Size = new System.Drawing.Size(713, 260);
            this.Load += new System.EventHandler(this.PromotionControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstPromotion;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private XButton btnDeleteStudent;
        private XButton btnMaintainStudent;
        private XButton button3;
    }
}
