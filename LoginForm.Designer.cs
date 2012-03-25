namespace WindowsFormsApplication1
{
    partial class frmLogin
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
            this.lblBranchLogin = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtBranchID = new System.Windows.Forms.MaskedTextBox();
            this.lblBranchID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBranchLogin
            // 
            this.lblBranchLogin.AutoSize = true;
            this.lblBranchLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBranchLogin.Location = new System.Drawing.Point(39, 9);
            this.lblBranchLogin.Name = "lblBranchLogin";
            this.lblBranchLogin.Size = new System.Drawing.Size(205, 36);
            this.lblBranchLogin.TabIndex = 0;
            this.lblBranchLogin.Text = "Branch Login";
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(85, 93);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(94, 37);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtBranchID
            // 
            this.txtBranchID.Location = new System.Drawing.Point(148, 57);
            this.txtBranchID.Mask = "00000";
            this.txtBranchID.Name = "txtBranchID";
            this.txtBranchID.PromptChar = ' ';
            this.txtBranchID.Size = new System.Drawing.Size(47, 20);
            this.txtBranchID.TabIndex = 2;
            this.txtBranchID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBranchID.ValidatingType = typeof(int);
            this.txtBranchID.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtBranchID_MaskInputRejected);
            // 
            // lblBranchID
            // 
            this.lblBranchID.AutoSize = true;
            this.lblBranchID.Location = new System.Drawing.Point(82, 63);
            this.lblBranchID.Name = "lblBranchID";
            this.lblBranchID.Size = new System.Drawing.Size(58, 13);
            this.lblBranchID.TabIndex = 3;
            this.lblBranchID.Text = "Branch ID:";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 146);
            this.Controls.Add(this.lblBranchID);
            this.Controls.Add(this.txtBranchID);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblBranchLogin);
            this.HelpButton = true;
            this.Name = "frmLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBranchLogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.MaskedTextBox txtBranchID;
        private System.Windows.Forms.Label lblBranchID;
    }
}

