namespace SMART_ERP_System.MenuUserControl
{
    partial class 자재등록
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbSearch공급업체 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbSearch품목군 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txb공급업체 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn조회 = new System.Windows.Forms.Button();
            this.btn변경 = new System.Windows.Forms.Button();
            this.btn삭제 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv자재 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbb검사여부 = new System.Windows.Forms.ComboBox();
            this.txb리드타임 = new System.Windows.Forms.TextBox();
            this.txb안전재고량 = new System.Windows.Forms.TextBox();
            this.txb자재이름 = new System.Windows.Forms.TextBox();
            this.txb재고량 = new System.Windows.Forms.TextBox();
            this.txb품목군 = new System.Windows.Forms.TextBox();
            this.txb자재번호 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn등록 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv자재)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "자재등록";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbSearch공급업체);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txbSearch품목군);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(7, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1017, 66);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // txbSearch공급업체
            // 
            this.txbSearch공급업체.Location = new System.Drawing.Point(359, 21);
            this.txbSearch공급업체.Name = "txbSearch공급업체";
            this.txbSearch공급업체.Size = new System.Drawing.Size(150, 21);
            this.txbSearch공급업체.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(264, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 29;
            this.label3.Text = "공급업체이름 : ";
            // 
            // txbSearch품목군
            // 
            this.txbSearch품목군.Location = new System.Drawing.Point(610, 24);
            this.txbSearch품목군.Name = "txbSearch품목군";
            this.txbSearch품목군.Size = new System.Drawing.Size(150, 21);
            this.txbSearch품목군.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(539, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "품목군 : ";
            // 
            // txb공급업체
            // 
            this.txb공급업체.Location = new System.Drawing.Point(353, 177);
            this.txb공급업체.Name = "txb공급업체";
            this.txb공급업체.Size = new System.Drawing.Size(150, 21);
            this.txb공급업체.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(270, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "주거래처 : ";
            // 
            // btn조회
            // 
            this.btn조회.Location = new System.Drawing.Point(705, 3);
            this.btn조회.Name = "btn조회";
            this.btn조회.Size = new System.Drawing.Size(75, 23);
            this.btn조회.TabIndex = 3;
            this.btn조회.Text = "조회";
            this.btn조회.UseVisualStyleBackColor = true;
            this.btn조회.Click += new System.EventHandler(this.Btn조회_Click);
            // 
            // btn변경
            // 
            this.btn변경.Location = new System.Drawing.Point(867, 2);
            this.btn변경.Name = "btn변경";
            this.btn변경.Size = new System.Drawing.Size(75, 23);
            this.btn변경.TabIndex = 4;
            this.btn변경.Text = "변경";
            this.btn변경.UseVisualStyleBackColor = true;
            this.btn변경.Click += new System.EventHandler(this.Btn변경_Click);
            // 
            // btn삭제
            // 
            this.btn삭제.Location = new System.Drawing.Point(948, 2);
            this.btn삭제.Name = "btn삭제";
            this.btn삭제.Size = new System.Drawing.Size(75, 23);
            this.btn삭제.TabIndex = 5;
            this.btn삭제.Text = "삭제";
            this.btn삭제.UseVisualStyleBackColor = true;
            this.btn삭제.Click += new System.EventHandler(this.Btn삭제_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv자재);
            this.panel1.Location = new System.Drawing.Point(7, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 499);
            this.panel1.TabIndex = 6;
            // 
            // dgv자재
            // 
            this.dgv자재.AllowUserToAddRows = false;
            this.dgv자재.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv자재.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv자재.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgv자재.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv자재.Location = new System.Drawing.Point(0, 0);
            this.dgv자재.Name = "dgv자재";
            this.dgv자재.RowTemplate.Height = 23;
            this.dgv자재.Size = new System.Drawing.Size(466, 499);
            this.dgv자재.TabIndex = 0;
            this.dgv자재.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv자재_CellDoubleClick);
            this.dgv자재.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv자재_CellEndEdit);
            this.dgv자재.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Dgv자재_KeyDown);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "자재번호";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "자재이름";
            this.Column2.Name = "Column2";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbb검사여부);
            this.panel2.Controls.Add(this.txb공급업체);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txb리드타임);
            this.panel2.Controls.Add(this.txb안전재고량);
            this.panel2.Controls.Add(this.txb자재이름);
            this.panel2.Controls.Add(this.txb재고량);
            this.panel2.Controls.Add(this.txb품목군);
            this.panel2.Controls.Add(this.txb자재번호);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(492, 137);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(532, 460);
            this.panel2.TabIndex = 7;
            // 
            // cbb검사여부
            // 
            this.cbb검사여부.FormattingEnabled = true;
            this.cbb검사여부.Location = new System.Drawing.Point(88, 177);
            this.cbb검사여부.Name = "cbb검사여부";
            this.cbb검사여부.Size = new System.Drawing.Size(150, 20);
            this.cbb검사여부.TabIndex = 28;
            // 
            // txb리드타임
            // 
            this.txb리드타임.Location = new System.Drawing.Point(353, 128);
            this.txb리드타임.Name = "txb리드타임";
            this.txb리드타임.Size = new System.Drawing.Size(150, 21);
            this.txb리드타임.TabIndex = 21;
            // 
            // txb안전재고량
            // 
            this.txb안전재고량.Location = new System.Drawing.Point(353, 75);
            this.txb안전재고량.Name = "txb안전재고량";
            this.txb안전재고량.Size = new System.Drawing.Size(150, 21);
            this.txb안전재고량.TabIndex = 20;
            // 
            // txb자재이름
            // 
            this.txb자재이름.Location = new System.Drawing.Point(353, 26);
            this.txb자재이름.Name = "txb자재이름";
            this.txb자재이름.ReadOnly = true;
            this.txb자재이름.Size = new System.Drawing.Size(150, 21);
            this.txb자재이름.TabIndex = 19;
            // 
            // txb재고량
            // 
            this.txb재고량.Location = new System.Drawing.Point(88, 128);
            this.txb재고량.Name = "txb재고량";
            this.txb재고량.Size = new System.Drawing.Size(150, 21);
            this.txb재고량.TabIndex = 17;
            // 
            // txb품목군
            // 
            this.txb품목군.Location = new System.Drawing.Point(88, 75);
            this.txb품목군.Name = "txb품목군";
            this.txb품목군.Size = new System.Drawing.Size(150, 21);
            this.txb품목군.TabIndex = 16;
            // 
            // txb자재번호
            // 
            this.txb자재번호.Location = new System.Drawing.Point(88, 26);
            this.txb자재번호.Name = "txb자재번호";
            this.txb자재번호.ReadOnly = true;
            this.txb자재번호.Size = new System.Drawing.Size(150, 21);
            this.txb자재번호.TabIndex = 6;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(270, 131);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 12);
            this.label15.TabIndex = 14;
            this.label15.Text = "리드타임 : ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(258, 78);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 12);
            this.label16.TabIndex = 13;
            this.label16.Text = "안전재고량 : ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(270, 29);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 12);
            this.label17.TabIndex = 12;
            this.label17.Text = "자재이름 : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 8;
            this.label9.Text = "검사여부 : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 131);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 6;
            this.label11.Text = "재고량 : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "품목군 : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 3;
            this.label8.Text = "자재번호 : ";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1018, 1);
            this.label2.TabIndex = 8;
            // 
            // btn등록
            // 
            this.btn등록.Location = new System.Drawing.Point(786, 3);
            this.btn등록.Name = "btn등록";
            this.btn등록.Size = new System.Drawing.Size(75, 23);
            this.btn등록.TabIndex = 9;
            this.btn등록.Text = "등록";
            this.btn등록.UseVisualStyleBackColor = true;
            this.btn등록.Click += new System.EventHandler(this.Btn등록_Click);
            // 
            // 자재등록
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn등록);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn삭제);
            this.Controls.Add(this.btn변경);
            this.Controls.Add(this.btn조회);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "자재등록";
            this.Size = new System.Drawing.Size(1044, 645);
            this.Load += new System.EventHandler(this.자재등록_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv자재)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn조회;
        private System.Windows.Forms.Button btn삭제;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv자재;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbSearch품목군;
        private System.Windows.Forms.TextBox txb공급업체;
        private System.Windows.Forms.TextBox txb안전재고량;
        private System.Windows.Forms.TextBox txb자재이름;
        private System.Windows.Forms.TextBox txb재고량;
        private System.Windows.Forms.TextBox txb품목군;
        private System.Windows.Forms.TextBox txb자재번호;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbb검사여부;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.TextBox txb리드타임;
        private System.Windows.Forms.Button btn변경;
        private System.Windows.Forms.TextBox txbSearch공급업체;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn등록;
    }
}
