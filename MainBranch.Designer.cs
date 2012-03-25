namespace WindowsFormsApplication1
{
    partial class frmMainBranch
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnEditBranch = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtSearchCriteria = new System.Windows.Forms.TextBox();
            this.lblCatInBranch = new System.Windows.Forms.Label();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnRemoveCatFromBranch = new System.Windows.Forms.Button();
            this.btnAddCatToBranch = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSearchProducts = new System.Windows.Forms.Label();
            this.ProductImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.StockLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Details = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpProductInfo = new System.Windows.Forms.DataGridView();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.grpProductDetails = new System.Windows.Forms.GroupBox();
            this.lblAddressPostcode = new System.Windows.Forms.Label();
            this.lblAddressCounty = new System.Windows.Forms.Label();
            this.lslCatInBranch = new System.Windows.Forms.ListView();
            this.lblAddressCity = new System.Windows.Forms.Label();
            this.lblAddressNo = new System.Windows.Forms.Label();
            this.grpBranchDetails = new System.Windows.Forms.GroupBox();
            this.lblAddressStreet = new System.Windows.Forms.Label();
            this.lblBranchNickname = new System.Windows.Forms.Label();
            this.lbBranchID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCatNotInBranch = new System.Windows.Forms.Label();
            this.lstCatNotInBranch = new System.Windows.Forms.ListView();
            this.grpCategoryDetails = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.grpProductInfo)).BeginInit();
            this.grpProductDetails.SuspendLayout();
            this.grpBranchDetails.SuspendLayout();
            this.grpCategoryDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(427, 32);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 28;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnEditBranch
            // 
            this.btnEditBranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditBranch.Location = new System.Drawing.Point(502, 122);
            this.btnEditBranch.Name = "btnEditBranch";
            this.btnEditBranch.Size = new System.Drawing.Size(111, 36);
            this.btnEditBranch.TabIndex = 2;
            this.btnEditBranch.Text = "Edit Branch Details";
            this.btnEditBranch.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(492, 109);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 51);
            this.button4.TabIndex = 7;
            this.button4.Text = "View Catergory Details";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // txtSearchCriteria
            // 
            this.txtSearchCriteria.Location = new System.Drawing.Point(123, 29);
            this.txtSearchCriteria.Name = "txtSearchCriteria";
            this.txtSearchCriteria.Size = new System.Drawing.Size(270, 26);
            this.txtSearchCriteria.TabIndex = 27;
            // 
            // lblCatInBranch
            // 
            this.lblCatInBranch.AutoSize = true;
            this.lblCatInBranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatInBranch.Location = new System.Drawing.Point(255, 36);
            this.lblCatInBranch.Name = "lblCatInBranch";
            this.lblCatInBranch.Size = new System.Drawing.Size(108, 13);
            this.lblCatInBranch.TabIndex = 6;
            this.lblCatInBranch.Text = "Catergories in Branch";
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteProduct.Location = new System.Drawing.Point(1092, 545);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(100, 43);
            this.btnDeleteProduct.TabIndex = 30;
            this.btnDeleteProduct.Text = "Delete Product";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            // 
            // btnRemoveCatFromBranch
            // 
            this.btnRemoveCatFromBranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveCatFromBranch.Location = new System.Drawing.Point(223, 106);
            this.btnRemoveCatFromBranch.Name = "btnRemoveCatFromBranch";
            this.btnRemoveCatFromBranch.Size = new System.Drawing.Size(29, 23);
            this.btnRemoveCatFromBranch.TabIndex = 5;
            this.btnRemoveCatFromBranch.Text = "-";
            this.btnRemoveCatFromBranch.UseVisualStyleBackColor = true;
            // 
            // btnAddCatToBranch
            // 
            this.btnAddCatToBranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCatToBranch.Location = new System.Drawing.Point(223, 77);
            this.btnAddCatToBranch.Name = "btnAddCatToBranch";
            this.btnAddCatToBranch.Size = new System.Drawing.Size(29, 23);
            this.btnAddCatToBranch.TabIndex = 4;
            this.btnAddCatToBranch.Text = "+";
            this.btnAddCatToBranch.UseVisualStyleBackColor = true;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.Location = new System.Drawing.Point(524, 25);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(95, 30);
            this.btnAddProduct.TabIndex = 29;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 3;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 80;
            // 
            // lblSearchProducts
            // 
            this.lblSearchProducts.AutoSize = true;
            this.lblSearchProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchProducts.Location = new System.Drawing.Point(28, 36);
            this.lblSearchProducts.Name = "lblSearchProducts";
            this.lblSearchProducts.Size = new System.Drawing.Size(89, 13);
            this.lblSearchProducts.TabIndex = 26;
            this.lblSearchProducts.Text = "Search Products:";
            // 
            // ProductImage
            // 
            this.ProductImage.HeaderText = "Product Image";
            this.ProductImage.Name = "ProductImage";
            this.ProductImage.Width = 192;
            // 
            // StockLevel
            // 
            this.StockLevel.HeaderText = "Stock Level";
            this.StockLevel.MinimumWidth = 3;
            this.StockLevel.Name = "StockLevel";
            this.StockLevel.ReadOnly = true;
            this.StockLevel.Width = 80;
            // 
            // Details
            // 
            this.Details.HeaderText = "Details";
            this.Details.Name = "Details";
            this.Details.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Details.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Details.Width = 410;
            // 
            // grpProductInfo
            // 
            this.grpProductInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grpProductInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.Product_Name,
            this.Details,
            this.ProductImage,
            this.Price,
            this.StockLevel,
            this.Edit});
            this.grpProductInfo.Location = new System.Drawing.Point(7, 61);
            this.grpProductInfo.Name = "grpProductInfo";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Format = "N1";
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grpProductInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grpProductInfo.Size = new System.Drawing.Size(1079, 504);
            this.grpProductInfo.TabIndex = 0;
            // 
            // ProductID
            // 
            this.ProductID.HeaderText = "ID Number";
            this.ProductID.Name = "ProductID";
            // 
            // Product_Name
            // 
            this.Product_Name.HeaderText = "Title";
            this.Product_Name.MinimumWidth = 3;
            this.Product_Name.Name = "Product_Name";
            this.Product_Name.ReadOnly = true;
            this.Product_Name.Width = 94;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.Width = 80;
            // 
            // grpProductDetails
            // 
            this.grpProductDetails.Controls.Add(this.btnDeleteProduct);
            this.grpProductDetails.Controls.Add(this.btnSearch);
            this.grpProductDetails.Controls.Add(this.txtSearchCriteria);
            this.grpProductDetails.Controls.Add(this.btnAddProduct);
            this.grpProductDetails.Controls.Add(this.lblSearchProducts);
            this.grpProductDetails.Controls.Add(this.grpProductInfo);
            this.grpProductDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpProductDetails.Location = new System.Drawing.Point(13, 163);
            this.grpProductDetails.Name = "grpProductDetails";
            this.grpProductDetails.Size = new System.Drawing.Size(1198, 594);
            this.grpProductDetails.TabIndex = 7;
            this.grpProductDetails.TabStop = false;
            this.grpProductDetails.Text = "Product Details";
            // 
            // lblAddressPostcode
            // 
            this.lblAddressPostcode.AutoSize = true;
            this.lblAddressPostcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressPostcode.Location = new System.Drawing.Point(207, 128);
            this.lblAddressPostcode.Name = "lblAddressPostcode";
            this.lblAddressPostcode.Size = new System.Drawing.Size(52, 13);
            this.lblAddressPostcode.TabIndex = 21;
            this.lblAddressPostcode.Text = "Postcode";
            // 
            // lblAddressCounty
            // 
            this.lblAddressCounty.AutoSize = true;
            this.lblAddressCounty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressCounty.Location = new System.Drawing.Point(207, 106);
            this.lblAddressCounty.Name = "lblAddressCounty";
            this.lblAddressCounty.Size = new System.Drawing.Size(39, 13);
            this.lblAddressCounty.TabIndex = 20;
            this.lblAddressCounty.Text = "county";
            // 
            // lslCatInBranch
            // 
            this.lslCatInBranch.Location = new System.Drawing.Point(258, 56);
            this.lslCatInBranch.Name = "lslCatInBranch";
            this.lslCatInBranch.Size = new System.Drawing.Size(201, 95);
            this.lslCatInBranch.TabIndex = 0;
            this.lslCatInBranch.UseCompatibleStateImageBehavior = false;
            // 
            // lblAddressCity
            // 
            this.lblAddressCity.AutoSize = true;
            this.lblAddressCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressCity.Location = new System.Drawing.Point(207, 82);
            this.lblAddressCity.Name = "lblAddressCity";
            this.lblAddressCity.Size = new System.Drawing.Size(24, 13);
            this.lblAddressCity.TabIndex = 19;
            this.lblAddressCity.Text = "City";
            // 
            // lblAddressNo
            // 
            this.lblAddressNo.AutoSize = true;
            this.lblAddressNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressNo.Location = new System.Drawing.Point(207, 30);
            this.lblAddressNo.Name = "lblAddressNo";
            this.lblAddressNo.Size = new System.Drawing.Size(32, 13);
            this.lblAddressNo.TabIndex = 18;
            this.lblAddressNo.Text = "Adr 1";
            // 
            // grpBranchDetails
            // 
            this.grpBranchDetails.Controls.Add(this.lblAddressPostcode);
            this.grpBranchDetails.Controls.Add(this.btnEditBranch);
            this.grpBranchDetails.Controls.Add(this.lblAddressCounty);
            this.grpBranchDetails.Controls.Add(this.lblAddressCity);
            this.grpBranchDetails.Controls.Add(this.lblAddressNo);
            this.grpBranchDetails.Controls.Add(this.lblAddressStreet);
            this.grpBranchDetails.Controls.Add(this.lblBranchNickname);
            this.grpBranchDetails.Controls.Add(this.lbBranchID);
            this.grpBranchDetails.Controls.Add(this.label3);
            this.grpBranchDetails.Controls.Add(this.label1);
            this.grpBranchDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBranchDetails.Location = new System.Drawing.Point(13, -7);
            this.grpBranchDetails.Name = "grpBranchDetails";
            this.grpBranchDetails.Size = new System.Drawing.Size(619, 164);
            this.grpBranchDetails.TabIndex = 5;
            this.grpBranchDetails.TabStop = false;
            this.grpBranchDetails.Text = "Branch Details";
            // 
            // lblAddressStreet
            // 
            this.lblAddressStreet.AutoSize = true;
            this.lblAddressStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressStreet.Location = new System.Drawing.Point(207, 56);
            this.lblAddressStreet.Name = "lblAddressStreet";
            this.lblAddressStreet.Size = new System.Drawing.Size(31, 13);
            this.lblAddressStreet.TabIndex = 17;
            this.lblAddressStreet.Text = "adr 2";
            // 
            // lblBranchNickname
            // 
            this.lblBranchNickname.AutoSize = true;
            this.lblBranchNickname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBranchNickname.Location = new System.Drawing.Point(76, 56);
            this.lblBranchNickname.Name = "lblBranchNickname";
            this.lblBranchNickname.Size = new System.Drawing.Size(58, 13);
            this.lblBranchNickname.TabIndex = 16;
            this.lblBranchNickname.Text = "Stub Label";
            // 
            // lbBranchID
            // 
            this.lbBranchID.AutoSize = true;
            this.lbBranchID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBranchID.Location = new System.Drawing.Point(76, 30);
            this.lbBranchID.Name = "lbBranchID";
            this.lbBranchID.Size = new System.Drawing.Size(58, 13);
            this.lbBranchID.TabIndex = 15;
            this.lbBranchID.Text = "Stub Label";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "NickName:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "I.D Number:";
            // 
            // lblCatNotInBranch
            // 
            this.lblCatNotInBranch.AutoSize = true;
            this.lblCatNotInBranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatNotInBranch.Location = new System.Drawing.Point(13, 36);
            this.lblCatNotInBranch.Name = "lblCatNotInBranch";
            this.lblCatNotInBranch.Size = new System.Drawing.Size(126, 13);
            this.lblCatNotInBranch.TabIndex = 2;
            this.lblCatNotInBranch.Text = "Catergories not in Branch";
            // 
            // lstCatNotInBranch
            // 
            this.lstCatNotInBranch.Location = new System.Drawing.Point(16, 56);
            this.lstCatNotInBranch.Name = "lstCatNotInBranch";
            this.lstCatNotInBranch.Size = new System.Drawing.Size(201, 95);
            this.lstCatNotInBranch.TabIndex = 1;
            this.lstCatNotInBranch.UseCompatibleStateImageBehavior = false;
            // 
            // grpCategoryDetails
            // 
            this.grpCategoryDetails.Controls.Add(this.button4);
            this.grpCategoryDetails.Controls.Add(this.lblCatInBranch);
            this.grpCategoryDetails.Controls.Add(this.btnRemoveCatFromBranch);
            this.grpCategoryDetails.Controls.Add(this.btnAddCatToBranch);
            this.grpCategoryDetails.Controls.Add(this.lblCatNotInBranch);
            this.grpCategoryDetails.Controls.Add(this.lstCatNotInBranch);
            this.grpCategoryDetails.Controls.Add(this.lslCatInBranch);
            this.grpCategoryDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCategoryDetails.Location = new System.Drawing.Point(638, -7);
            this.grpCategoryDetails.Name = "grpCategoryDetails";
            this.grpCategoryDetails.Size = new System.Drawing.Size(573, 164);
            this.grpCategoryDetails.TabIndex = 6;
            this.grpCategoryDetails.TabStop = false;
            this.grpCategoryDetails.Text = "Catergory Details";
            // 
            // frmMainBranch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 750);
            this.Controls.Add(this.grpProductDetails);
            this.Controls.Add(this.grpBranchDetails);
            this.Controls.Add(this.grpCategoryDetails);
            this.Name = "frmMainBranch";
            this.Text = "MainBranch";
            ((System.ComponentModel.ISupportInitialize)(this.grpProductInfo)).EndInit();
            this.grpProductDetails.ResumeLayout(false);
            this.grpProductDetails.PerformLayout();
            this.grpBranchDetails.ResumeLayout(false);
            this.grpBranchDetails.PerformLayout();
            this.grpCategoryDetails.ResumeLayout(false);
            this.grpCategoryDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnEditBranch;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtSearchCriteria;
        private System.Windows.Forms.Label lblCatInBranch;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnRemoveCatFromBranch;
        private System.Windows.Forms.Button btnAddCatToBranch;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.Label lblSearchProducts;
        private System.Windows.Forms.DataGridViewImageColumn ProductImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Details;
        private System.Windows.Forms.DataGridView grpProductInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Name;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.GroupBox grpProductDetails;
        private System.Windows.Forms.Label lblAddressPostcode;
        private System.Windows.Forms.Label lblAddressCounty;
        private System.Windows.Forms.ListView lslCatInBranch;
        private System.Windows.Forms.Label lblAddressCity;
        private System.Windows.Forms.Label lblAddressNo;
        private System.Windows.Forms.GroupBox grpBranchDetails;
        private System.Windows.Forms.Label lblAddressStreet;
        private System.Windows.Forms.Label lblBranchNickname;
        private System.Windows.Forms.Label lbBranchID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCatNotInBranch;
        private System.Windows.Forms.ListView lstCatNotInBranch;
        private System.Windows.Forms.GroupBox grpCategoryDetails;


    }
}