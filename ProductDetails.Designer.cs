namespace WindowsFormsApplication1
{
    partial class frmProductDetails
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
            this.grpProductDetails = new System.Windows.Forms.GroupBox();
            this.txtProductDetails = new System.Windows.Forms.TextBox();
            this.btnChangeImage = new System.Windows.Forms.Button();
            this.btnChangeDetails = new System.Windows.Forms.Button();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.lblBranchNickname = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblProductStockLevel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.imgProductImageSource = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblProductID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BackBtn = new System.Windows.Forms.Button();
            this.grpProductDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgProductImageSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grpProductDetails
            // 
            this.grpProductDetails.Controls.Add(this.txtProductDetails);
            this.grpProductDetails.Controls.Add(this.btnChangeImage);
            this.grpProductDetails.Controls.Add(this.btnChangeDetails);
            this.grpProductDetails.Controls.Add(this.lblCategoryName);
            this.grpProductDetails.Controls.Add(this.lblBranchNickname);
            this.grpProductDetails.Controls.Add(this.btnSave);
            this.grpProductDetails.Controls.Add(this.btnEdit);
            this.grpProductDetails.Controls.Add(this.lblProductStockLevel);
            this.grpProductDetails.Controls.Add(this.label6);
            this.grpProductDetails.Controls.Add(this.label5);
            this.grpProductDetails.Controls.Add(this.txtPrice);
            this.grpProductDetails.Controls.Add(this.imgProductImageSource);
            this.grpProductDetails.Controls.Add(this.label4);
            this.grpProductDetails.Controls.Add(this.label2);
            this.grpProductDetails.Controls.Add(this.txtProductName);
            this.grpProductDetails.Controls.Add(this.lblProductID);
            this.grpProductDetails.Controls.Add(this.label3);
            this.grpProductDetails.Controls.Add(this.label1);
            this.grpProductDetails.Location = new System.Drawing.Point(13, 13);
            this.grpProductDetails.Name = "grpProductDetails";
            this.grpProductDetails.Size = new System.Drawing.Size(376, 368);
            this.grpProductDetails.TabIndex = 0;
            this.grpProductDetails.TabStop = false;
            this.grpProductDetails.Text = "Product Details";
            // 
            // txtProductDetails
            // 
            this.txtProductDetails.Location = new System.Drawing.Point(15, 122);
            this.txtProductDetails.Multiline = true;
            this.txtProductDetails.Name = "txtProductDetails";
            this.txtProductDetails.Size = new System.Drawing.Size(136, 95);
            this.txtProductDetails.TabIndex = 57;
            // 
            // btnChangeImage
            // 
            this.btnChangeImage.Location = new System.Drawing.Point(146, 223);
            this.btnChangeImage.Name = "btnChangeImage";
            this.btnChangeImage.Size = new System.Drawing.Size(99, 23);
            this.btnChangeImage.TabIndex = 56;
            this.btnChangeImage.Text = "Change Image";
            this.btnChangeImage.UseVisualStyleBackColor = true;
            // 
            // btnChangeDetails
            // 
            this.btnChangeDetails.Location = new System.Drawing.Point(15, 223);
            this.btnChangeDetails.Name = "btnChangeDetails";
            this.btnChangeDetails.Size = new System.Drawing.Size(99, 23);
            this.btnChangeDetails.TabIndex = 55;
            this.btnChangeDetails.Text = "Change Details";
            this.btnChangeDetails.UseVisualStyleBackColor = true;
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Location = new System.Drawing.Point(143, 25);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(116, 13);
            this.lblCategoryName.TabIndex = 54;
            this.lblCategoryName.Text = "Catergory Bread Crumb";
            // 
            // lblBranchNickname
            // 
            this.lblBranchNickname.AutoSize = true;
            this.lblBranchNickname.Location = new System.Drawing.Point(18, 25);
            this.lblBranchNickname.Name = "lblBranchNickname";
            this.lblBranchNickname.Size = new System.Drawing.Size(119, 13);
            this.lblBranchNickname.TabIndex = 53;
            this.lblBranchNickname.Text = "Branch Bread Crumb   /";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(118, 325);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 37);
            this.btnSave.TabIndex = 52;
            this.btnSave.Text = "Save Changes";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(278, 25);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(90, 39);
            this.btnEdit.TabIndex = 51;
            this.btnEdit.Text = "Enable/Disable Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // lblProductStockLevel
            // 
            this.lblProductStockLevel.AutoSize = true;
            this.lblProductStockLevel.Location = new System.Drawing.Point(131, 293);
            this.lblProductStockLevel.Name = "lblProductStockLevel";
            this.lblProductStockLevel.Size = new System.Drawing.Size(58, 13);
            this.lblProductStockLevel.TabIndex = 50;
            this.lblProductStockLevel.Text = "Stub Label";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 49;
            this.label6.Text = "Product Stock Levels";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "Price:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(51, 258);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 47;
            // 
            // imgProductImageSource
            // 
            this.imgProductImageSource.Location = new System.Drawing.Point(165, 122);
            this.imgProductImageSource.Name = "imgProductImageSource";
            this.imgProductImageSource.Size = new System.Drawing.Size(136, 95);
            this.imgProductImageSource.TabIndex = 46;
            this.imgProductImageSource.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(162, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Product Image";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Product Details";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(51, 76);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(100, 20);
            this.txtProductName.TabIndex = 42;
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Location = new System.Drawing.Point(85, 53);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(58, 13);
            this.lblProductID.TabIndex = 41;
            this.lblProductID.Text = "Stub Label";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Title:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "I.D Number:";
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(299, 387);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(90, 37);
            this.BackBtn.TabIndex = 39;
            this.BackBtn.Text = "Go Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // frmProductDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 428);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.grpProductDetails);
            this.Name = "frmProductDetails";
            this.Text = "ProductDetails";
            this.grpProductDetails.ResumeLayout(false);
            this.grpProductDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgProductImageSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpProductDetails;
        private System.Windows.Forms.Button btnChangeImage;
        private System.Windows.Forms.Button btnChangeDetails;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.Label lblBranchNickname;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblProductStockLevel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.PictureBox imgProductImageSource;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.TextBox txtProductDetails;
    }
}