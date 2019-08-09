namespace SMART_ERP_System
{
    partial class LoginControl
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.txbPassWord = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbEmployeeName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbEmployeeCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnOk);
            this.groupBox1.Controls.Add(this.txbPassWord);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txbEmployeeName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txbEmployeeCode);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(3, 230);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 148);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "로그인";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(142, 114);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(76, 23);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(85, 114);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(53, 23);
            this.btnOk.TabIndex = 14;
            this.btnOk.Text = "&OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // txbPassWord
            // 
            this.txbPassWord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbPassWord.Location = new System.Drawing.Point(108, 82);
            this.txbPassWord.Name = "txbPassWord";
            this.txbPassWord.PasswordChar = '●';
            this.txbPassWord.Size = new System.Drawing.Size(110, 19);
            this.txbPassWord.TabIndex = 13;
            this.txbPassWord.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxbPassWord_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(15, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "암     호";
            // 
            // txbEmployeeName
            // 
            this.txbEmployeeName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbEmployeeName.Enabled = false;
            this.txbEmployeeName.Location = new System.Drawing.Point(108, 51);
            this.txbEmployeeName.Name = "txbEmployeeName";
            this.txbEmployeeName.ReadOnly = true;
            this.txbEmployeeName.Size = new System.Drawing.Size(110, 19);
            this.txbEmployeeName.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(15, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "이     름";
            // 
            // txbEmployeeCode
            // 
            this.txbEmployeeCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbEmployeeCode.Location = new System.Drawing.Point(108, 19);
            this.txbEmployeeCode.Name = "txbEmployeeCode";
            this.txbEmployeeCode.Size = new System.Drawing.Size(110, 19);
            this.txbEmployeeCode.TabIndex = 7;
            this.txbEmployeeCode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxbEmployeeCode_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "사원코드";
            // 
            // LoginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SMART_ERP_System.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.groupBox1);
            this.Name = "LoginControl";
            this.Size = new System.Drawing.Size(618, 381);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txbPassWord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txbEmployeeCode;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.TextBox txbEmployeeName;
        public System.Windows.Forms.Button btnOk;
    }
}
