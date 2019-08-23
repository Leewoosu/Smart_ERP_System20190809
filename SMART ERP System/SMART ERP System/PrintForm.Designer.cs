namespace SMART_ERP_System
{
    partial class PrintForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintForm));
            this.printPreviewControl = new System.Windows.Forms.PrintPreviewControl();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnPrtSet = new System.Windows.Forms.Button();
            this.btnPreView = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // printPreviewControl
            // 
            this.printPreviewControl.Location = new System.Drawing.Point(23, 63);
            this.printPreviewControl.Name = "printPreviewControl";
            this.printPreviewControl.Size = new System.Drawing.Size(624, 394);
            this.printPreviewControl.TabIndex = 0;
            // 
            // btnPrint
            // 
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.Location = new System.Drawing.Point(113, 19);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(56, 37);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // btnPrtSet
            // 
            this.btnPrtSet.Location = new System.Drawing.Point(239, 19);
            this.btnPrtSet.Name = "btnPrtSet";
            this.btnPrtSet.Size = new System.Drawing.Size(56, 37);
            this.btnPrtSet.TabIndex = 2;
            this.btnPrtSet.Text = "설정";
            this.btnPrtSet.UseVisualStyleBackColor = true;
            this.btnPrtSet.Click += new System.EventHandler(this.BtnPrtSet_Click);
            // 
            // btnPreView
            // 
            this.btnPreView.Location = new System.Drawing.Point(332, 20);
            this.btnPreView.Name = "btnPreView";
            this.btnPreView.Size = new System.Drawing.Size(68, 37);
            this.btnPreView.TabIndex = 3;
            this.btnPreView.Text = "미리보기";
            this.btnPreView.UseVisualStyleBackColor = true;
            this.btnPreView.Click += new System.EventHandler(this.BtnPreView_Click);
            // 
            // PrintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 476);
            this.Controls.Add(this.btnPreView);
            this.Controls.Add(this.btnPrtSet);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.printPreviewControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PrintForm";
            this.Text = "프린트";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PrintPreviewControl printPreviewControl;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnPrtSet;
        private System.Windows.Forms.Button btnPreView;
    }
}