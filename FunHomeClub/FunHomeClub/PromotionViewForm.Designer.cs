namespace FunHomeClub
{
    partial class PromotionViewForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.btnClose = new XButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblName_d = new System.Windows.Forms.Label();
            this.lblTime_d = new System.Windows.Forms.Label();
            this.lblTo_d = new System.Windows.Forms.Label();
            this.lblDiscount_d = new System.Windows.Forms.Label();
            this.lblDescription_d = new System.Windows.Forms.Label();
            this.masterDBDataSet1 = new FunHomeClub.res.db.masterDBDataSet();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPromotionID_d = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.masterDBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(12, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 19);
            this.label5.TabIndex = 22;
            this.label5.Text = "Description:";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Coral;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(153, 216);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 23);
            this.btnClose.TabIndex = 21;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(198, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 19);
            this.label4.TabIndex = 19;
            this.label4.Text = "To";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(12, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 19);
            this.label3.TabIndex = 17;
            this.label3.Text = "Time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "Discount:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Name:";
            // 
            // lblName_d
            // 
            this.lblName_d.AutoSize = true;
            this.lblName_d.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblName_d.Location = new System.Drawing.Point(122, 39);
            this.lblName_d.Name = "lblName_d";
            this.lblName_d.Size = new System.Drawing.Size(21, 19);
            this.lblName_d.TabIndex = 23;
            this.lblName_d.Text = "--";
            // 
            // lblTime_d
            // 
            this.lblTime_d.AutoSize = true;
            this.lblTime_d.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTime_d.Location = new System.Drawing.Point(122, 103);
            this.lblTime_d.Name = "lblTime_d";
            this.lblTime_d.Size = new System.Drawing.Size(21, 19);
            this.lblTime_d.TabIndex = 24;
            this.lblTime_d.Text = "--";
            // 
            // lblTo_d
            // 
            this.lblTo_d.AutoSize = true;
            this.lblTo_d.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTo_d.Location = new System.Drawing.Point(259, 103);
            this.lblTo_d.Name = "lblTo_d";
            this.lblTo_d.Size = new System.Drawing.Size(21, 19);
            this.lblTo_d.TabIndex = 25;
            this.lblTo_d.Text = "--";
            // 
            // lblDiscount_d
            // 
            this.lblDiscount_d.AutoSize = true;
            this.lblDiscount_d.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDiscount_d.Location = new System.Drawing.Point(122, 72);
            this.lblDiscount_d.Name = "lblDiscount_d";
            this.lblDiscount_d.Size = new System.Drawing.Size(21, 19);
            this.lblDiscount_d.TabIndex = 26;
            this.lblDiscount_d.Text = "--";
            // 
            // lblDescription_d
            // 
            this.lblDescription_d.AutoSize = true;
            this.lblDescription_d.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDescription_d.Location = new System.Drawing.Point(12, 167);
            this.lblDescription_d.MaximumSize = new System.Drawing.Size(325, 40);
            this.lblDescription_d.Name = "lblDescription_d";
            this.lblDescription_d.Size = new System.Drawing.Size(21, 19);
            this.lblDescription_d.TabIndex = 27;
            this.lblDescription_d.Text = "--";
            // 
            // masterDBDataSet1
            // 
            this.masterDBDataSet1.DataSetName = "masterDBDataSet";
            this.masterDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(12, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 19);
            this.label6.TabIndex = 28;
            this.label6.Text = "Promotion ID:";
            // 
            // lblPromotionID_d
            // 
            this.lblPromotionID_d.AutoSize = true;
            this.lblPromotionID_d.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPromotionID_d.Location = new System.Drawing.Point(122, 13);
            this.lblPromotionID_d.Name = "lblPromotionID_d";
            this.lblPromotionID_d.Size = new System.Drawing.Size(21, 19);
            this.lblPromotionID_d.TabIndex = 29;
            this.lblPromotionID_d.Text = "--";
            // 
            // PromotionViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(361, 245);
            this.Controls.Add(this.lblPromotionID_d);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblDescription_d);
            this.Controls.Add(this.lblDiscount_d);
            this.Controls.Add(this.lblTo_d);
            this.Controls.Add(this.lblTime_d);
            this.Controls.Add(this.lblName_d);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PromotionViewForm";
            this.Text = "PromotionViewForm";
            this.Load += new System.EventHandler(this.PromotionViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.masterDBDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private XButton btnClose;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblName_d;
        private System.Windows.Forms.Label lblTime_d;
        private System.Windows.Forms.Label lblTo_d;
        private System.Windows.Forms.Label lblDiscount_d;
        private System.Windows.Forms.Label lblDescription_d;
        private res.db.masterDBDataSet masterDBDataSet1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPromotionID_d;
    }
}