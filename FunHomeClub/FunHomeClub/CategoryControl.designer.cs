namespace FunHomeClub
{
    partial class CategoryControl
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
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lstCategory = new System.Windows.Forms.ListView();
            this.categoryHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.categoryNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metrialHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDeleteCategory = new FunHomeClub.XButton();
            this.btnMaintainCategory = new FunHomeClub.XButton();
            this.btnAddCategory = new FunHomeClub.XButton();
            this.SuspendLayout();
            // 
            // lstCategory
            // 
            this.lstCategory.AutoArrange = false;
            this.lstCategory.BackColor = System.Drawing.SystemColors.Control;
            this.lstCategory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.categoryHeader,
            this.categoryNameHeader,
            this.metrialHeader});
            this.lstCategory.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lstCategory.Location = new System.Drawing.Point(3, 3);
            this.lstCategory.Name = "lstCategory";
            this.lstCategory.Size = new System.Drawing.Size(290, 240);
            this.lstCategory.TabIndex = 3;
            this.lstCategory.UseCompatibleStateImageBehavior = false;
            this.lstCategory.View = System.Windows.Forms.View.Details;
            this.lstCategory.SelectedIndexChanged += new System.EventHandler(this.lstCategory_SelectedIndexChanged);
            // 
            // categoryHeader
            // 
            this.categoryHeader.Text = "CategoryID";
            this.categoryHeader.Width = 96;
            // 
            // categoryNameHeader
            // 
            this.categoryNameHeader.Text = "Name";
            this.categoryNameHeader.Width = 95;
            // 
            // metrialHeader
            // 
            this.metrialHeader.Text = "MaterialCost";
            this.metrialHeader.Width = 92;
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.BackColor = System.Drawing.Color.Coral;
            this.btnDeleteCategory.Enabled = false;
            this.btnDeleteCategory.FlatAppearance.BorderSize = 0;
            this.btnDeleteCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCategory.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDeleteCategory.ForeColor = System.Drawing.Color.White;
            this.btnDeleteCategory.Location = new System.Drawing.Point(308, 67);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(97, 26);
            this.btnDeleteCategory.TabIndex = 9;
            this.btnDeleteCategory.Text = "Delete";
            this.btnDeleteCategory.UseVisualStyleBackColor = false;
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // btnMaintainCategory
            // 
            this.btnMaintainCategory.BackColor = System.Drawing.Color.Coral;
            this.btnMaintainCategory.Enabled = false;
            this.btnMaintainCategory.FlatAppearance.BorderSize = 0;
            this.btnMaintainCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaintainCategory.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMaintainCategory.ForeColor = System.Drawing.Color.White;
            this.btnMaintainCategory.Location = new System.Drawing.Point(308, 35);
            this.btnMaintainCategory.Name = "btnMaintainCategory";
            this.btnMaintainCategory.Size = new System.Drawing.Size(97, 26);
            this.btnMaintainCategory.TabIndex = 8;
            this.btnMaintainCategory.Text = "Maintain";
            this.btnMaintainCategory.UseVisualStyleBackColor = false;
            this.btnMaintainCategory.Click += new System.EventHandler(this.btnMaintainCategory_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.BackColor = System.Drawing.Color.Coral;
            this.btnAddCategory.FlatAppearance.BorderSize = 0;
            this.btnAddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCategory.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAddCategory.ForeColor = System.Drawing.Color.White;
            this.btnAddCategory.Location = new System.Drawing.Point(308, 3);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(97, 26);
            this.btnAddCategory.TabIndex = 7;
            this.btnAddCategory.Text = "Add";
            this.btnAddCategory.UseVisualStyleBackColor = false;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // CategoryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnDeleteCategory);
            this.Controls.Add(this.btnMaintainCategory);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.lstCategory);
            this.Name = "CategoryControl";
            this.Size = new System.Drawing.Size(420, 250);
            this.Load += new System.EventHandler(this.CategoryControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstCategory;
        private System.Windows.Forms.ColumnHeader categoryHeader;
        private System.Windows.Forms.ColumnHeader categoryNameHeader;
        private System.Windows.Forms.ColumnHeader metrialHeader;
        private XButton btnDeleteCategory;
        private XButton btnMaintainCategory;
        private XButton btnAddCategory;
    }
}
