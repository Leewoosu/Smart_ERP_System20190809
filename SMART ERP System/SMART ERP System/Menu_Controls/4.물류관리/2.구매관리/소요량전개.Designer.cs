﻿namespace SMART_ERP_System.MenuUserControl
{
    partial class 소요량전개
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn소요량전개 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LastDate = new System.Windows.Forms.DateTimePicker();
            this.FirstDate = new System.Windows.Forms.DateTimePicker();
            this.txb제품이름 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dgv소요량전개 = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv소요량전개)).BeginInit();
            this.SuspendLayout();
            // 
            // btn소요량전개
            // 
            this.btn소요량전개.Location = new System.Drawing.Point(950, 1);
            this.btn소요량전개.Name = "btn소요량전개";
            this.btn소요량전개.Size = new System.Drawing.Size(75, 23);
            this.btn소요량전개.TabIndex = 20;
            this.btn소요량전개.Text = "소요량전개";
            this.btn소요량전개.UseVisualStyleBackColor = true;
            this.btn소요량전개.Click += new System.EventHandler(this.btn소요량전개_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1018, 1);
            this.label1.TabIndex = 18;
            this.label1.Text = "label1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림체", 15.75F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(51, 2);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(185, 21);
            this.label8.TabIndex = 36;
            this.label8.Text = "소요량전개(MRP)";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.LastDate);
            this.groupBox1.Controls.Add(this.FirstDate);
            this.groupBox1.Controls.Add(this.txb제품이름);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(7, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1018, 54);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(340, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 11);
            this.label2.TabIndex = 54;
            this.label2.Text = "~";
            // 
            // LastDate
            // 
            this.LastDate.CustomFormat = "yyyy-MM-dd";
            this.LastDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.LastDate.Location = new System.Drawing.Point(357, 13);
            this.LastDate.Name = "LastDate";
            this.LastDate.Size = new System.Drawing.Size(97, 20);
            this.LastDate.TabIndex = 53;
            // 
            // FirstDate
            // 
            this.FirstDate.CustomFormat = "yyyy-MM-dd";
            this.FirstDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FirstDate.Location = new System.Drawing.Point(237, 13);
            this.FirstDate.Name = "FirstDate";
            this.FirstDate.Size = new System.Drawing.Size(97, 20);
            this.FirstDate.TabIndex = 52;
            // 
            // txb제품이름
            // 
            this.txb제품이름.Location = new System.Drawing.Point(83, 13);
            this.txb제품이름.Name = "txb제품이름";
            this.txb제품이름.Size = new System.Drawing.Size(77, 20);
            this.txb제품이름.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 14);
            this.label4.TabIndex = 50;
            this.label4.Text = "제품이름";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(190, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 14);
            this.label13.TabIndex = 48;
            this.label13.Text = "기간";
            // 
            // dgv소요량전개
            // 
            this.dgv소요량전개.AllowUserToAddRows = false;
            this.dgv소요량전개.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv소요량전개.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv소요량전개.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column1,
            this.Column2});
            this.dgv소요량전개.Location = new System.Drawing.Point(7, 89);
            this.dgv소요량전개.Name = "dgv소요량전개";
            this.dgv소요량전개.RowTemplate.Height = 23;
            this.dgv소요량전개.Size = new System.Drawing.Size(1018, 511);
            this.dgv소요량전개.TabIndex = 44;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "품번";
            this.Column3.Name = "Column3";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "자재";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "전개수량";
            this.Column2.Name = "Column2";
            // 
            // 소요량전개
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv소요량전개);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn소요량전개);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(7, 35);
            this.Name = "소요량전개";
            this.Size = new System.Drawing.Size(1044, 645);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv소요량전개)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn소요량전개;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgv소요량전개;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb제품이름;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker LastDate;
        private System.Windows.Forms.DateTimePicker FirstDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}
