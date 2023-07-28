namespace MyAccountDemo
{
    partial class frmMyAccountDemo
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
            this.lblId = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnSet = new System.Windows.Forms.Button();
            this.btnGet = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDestroy = new System.Windows.Forms.Button();
            this.btnGC = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnSetMB = new System.Windows.Forms.Button();
            this.btnGetMB = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtMB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblId.Location = new System.Drawing.Point(29, 18);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(100, 23);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Id";
            // 
            // lblName
            // 
            this.lblName.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblName.Location = new System.Drawing.Point(144, 18);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(100, 23);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblBalance
            // 
            this.lblBalance.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblBalance.Location = new System.Drawing.Point(262, 18);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(100, 23);
            this.lblBalance.TabIndex = 2;
            this.lblBalance.Text = "Balance";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(29, 44);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(147, 44);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 4;
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(265, 44);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(100, 20);
            this.txtBalance.TabIndex = 5;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(29, 80);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 6;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(147, 80);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(75, 23);
            this.btnSet.TabIndex = 7;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(265, 80);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(75, 23);
            this.btnGet.TabIndex = 8;
            this.btnGet.Text = "Get";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(29, 112);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDestroy
            // 
            this.btnDestroy.Location = new System.Drawing.Point(147, 112);
            this.btnDestroy.Name = "btnDestroy";
            this.btnDestroy.Size = new System.Drawing.Size(75, 23);
            this.btnDestroy.TabIndex = 10;
            this.btnDestroy.Text = "Destroy";
            this.btnDestroy.UseVisualStyleBackColor = true;
            // 
            // btnGC
            // 
            this.btnGC.Location = new System.Drawing.Point(265, 112);
            this.btnGC.Name = "btnGC";
            this.btnGC.Size = new System.Drawing.Size(75, 23);
            this.btnGC.TabIndex = 11;
            this.btnGC.Text = "GC";
            this.btnGC.UseVisualStyleBackColor = true;
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(29, 141);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(75, 23);
            this.btnDeposit.TabIndex = 12;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(265, 141);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(75, 23);
            this.btnWithdraw.TabIndex = 13;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            // 
            // btnSetMB
            // 
            this.btnSetMB.Location = new System.Drawing.Point(29, 170);
            this.btnSetMB.Name = "btnSetMB";
            this.btnSetMB.Size = new System.Drawing.Size(75, 23);
            this.btnSetMB.TabIndex = 14;
            this.btnSetMB.Text = "Set MB";
            this.btnSetMB.UseVisualStyleBackColor = true;
            // 
            // btnGetMB
            // 
            this.btnGetMB.Location = new System.Drawing.Point(265, 170);
            this.btnGetMB.Name = "btnGetMB";
            this.btnGetMB.Size = new System.Drawing.Size(75, 23);
            this.btnGetMB.TabIndex = 15;
            this.btnGetMB.Text = "Get MB";
            this.btnGetMB.UseVisualStyleBackColor = true;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(147, 144);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 20);
            this.txtAmount.TabIndex = 16;
            // 
            // txtMB
            // 
            this.txtMB.Location = new System.Drawing.Point(147, 173);
            this.txtMB.Name = "txtMB";
            this.txtMB.Size = new System.Drawing.Size(100, 20);
            this.txtMB.TabIndex = 17;
            // 
            // frmMyAccountDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 219);
            this.Controls.Add(this.txtMB);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.btnGetMB);
            this.Controls.Add(this.btnSetMB);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.btnGC);
            this.Controls.Add(this.btnDestroy);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblId);
            this.Name = "frmMyAccountDemo";
            this.Text = "MyAccountDemo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDestroy;
        private System.Windows.Forms.Button btnGC;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnSetMB;
        private System.Windows.Forms.Button btnGetMB;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtMB;
    }
}

