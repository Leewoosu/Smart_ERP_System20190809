namespace SMART_ERP_System.MenuUserControl
{
    partial class 입고등록
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
            this.dgv입고등록리스트 = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv입고등록 = new System.Windows.Forms.DataGridView();
            this.Column0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn조회 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.LastDate = new System.Windows.Forms.DateTimePicker();
            this.FirstDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txb발주번호 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txb거래처이름 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dgv불량상세정보 = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv입고등록리스트)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv입고등록)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv불량상세정보)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv입고등록리스트
            // 
            this.dgv입고등록리스트.AllowUserToAddRows = false;
            this.dgv입고등록리스트.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv입고등록리스트.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv입고등록리스트.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgv입고등록리스트.Location = new System.Drawing.Point(3, 319);
            this.dgv입고등록리스트.Name = "dgv입고등록리스트";
            this.dgv입고등록리스트.RowTemplate.Height = 23;
            this.dgv입고등록리스트.Size = new System.Drawing.Size(525, 222);
            this.dgv입고등록리스트.TabIndex = 97;
            this.dgv입고등록리스트.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv입고등록리스트_CellClick);
            this.dgv입고등록리스트.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv입고등록리스트_CellEndEdit);
            this.dgv입고등록리스트.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Dgv입고등록리스트_KeyDown);
            // 
            // Column4
            // 
            this.Column4.HeaderText = "자재번호";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "양품수량";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "불량수량";
            this.Column6.Name = "Column6";
            // 
            // dgv입고등록
            // 
            this.dgv입고등록.AllowUserToAddRows = false;
            this.dgv입고등록.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv입고등록.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv입고등록.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column0,
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgv입고등록.Location = new System.Drawing.Point(7, 120);
            this.dgv입고등록.Name = "dgv입고등록";
            this.dgv입고등록.RowTemplate.Height = 23;
            this.dgv입고등록.Size = new System.Drawing.Size(1018, 164);
            this.dgv입고등록.TabIndex = 96;
            this.dgv입고등록.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv입고등록_CellClick);
            this.dgv입고등록.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv입고등록_CellEndEdit);
            this.dgv입고등록.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv입고등록_CellEnter);
            this.dgv입고등록.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Dgv입고등록_KeyDown);
            // 
            // Column0
            // 
            this.Column0.HeaderText = "입고등록번호";
            this.Column0.Name = "Column0";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "발주번호";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "공급업체번호";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "주문일";
            this.Column3.Name = "Column3";
            // 
            // btn조회
            // 
            this.btn조회.Location = new System.Drawing.Point(933, -1);
            this.btn조회.Name = "btn조회";
            this.btn조회.Size = new System.Drawing.Size(92, 23);
            this.btn조회.TabIndex = 94;
            this.btn조회.Text = "조회";
            this.btn조회.UseVisualStyleBackColor = true;
            this.btn조회.Click += new System.EventHandler(this.Btn조회_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.LastDate);
            this.groupBox1.Controls.Add(this.FirstDate);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txb발주번호);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.txb거래처이름);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.textBox8);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(7, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1018, 85);
            this.groupBox1.TabIndex = 93;
            this.groupBox1.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(778, 53);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(11, 11);
            this.label13.TabIndex = 74;
            this.label13.Text = "~";
            // 
            // LastDate
            // 
            this.LastDate.Checked = false;
            this.LastDate.CustomFormat = "yyyy-MM-dd";
            this.LastDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.LastDate.Location = new System.Drawing.Point(795, 47);
            this.LastDate.Name = "LastDate";
            this.LastDate.Size = new System.Drawing.Size(96, 20);
            this.LastDate.TabIndex = 73;
            // 
            // FirstDate
            // 
            this.FirstDate.Checked = false;
            this.FirstDate.CustomFormat = "yyyy-MM-dd";
            this.FirstDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FirstDate.Location = new System.Drawing.Point(676, 47);
            this.FirstDate.Name = "FirstDate";
            this.FirstDate.Size = new System.Drawing.Size(96, 20);
            this.FirstDate.TabIndex = 72;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(301, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 14);
            this.label7.TabIndex = 71;
            this.label7.Text = "발주번호";
            // 
            // txb발주번호
            // 
            this.txb발주번호.Location = new System.Drawing.Point(373, 47);
            this.txb발주번호.Name = "txb발주번호";
            this.txb발주번호.Size = new System.Drawing.Size(77, 20);
            this.txb발주번호.TabIndex = 68;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(373, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(66, 20);
            this.textBox1.TabIndex = 62;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(445, 20);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(108, 20);
            this.textBox4.TabIndex = 63;
            // 
            // txb거래처이름
            // 
            this.txb거래처이름.AcceptsReturn = true;
            this.txb거래처이름.Location = new System.Drawing.Point(98, 47);
            this.txb거래처이름.Name = "txb거래처이름";
            this.txb거래처이름.Size = new System.Drawing.Size(180, 20);
            this.txb거래처이름.TabIndex = 56;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(98, 21);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(66, 20);
            this.textBox7.TabIndex = 54;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(170, 21);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(108, 20);
            this.textBox8.TabIndex = 55;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(602, 50);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 14);
            this.label15.TabIndex = 51;
            this.label15.Text = "검사기간";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(329, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 14);
            this.label11.TabIndex = 38;
            this.label11.Text = "사원";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(52, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 14);
            this.label5.TabIndex = 31;
            this.label5.Text = "부서";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(6, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 14);
            this.label6.TabIndex = 33;
            this.label6.Text = "공급처이름";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림체", 15.75F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(51, 2);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 21);
            this.label8.TabIndex = 92;
            this.label8.Text = "입고등록";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1018, 1);
            this.label1.TabIndex = 89;
            this.label1.Text = "label1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.dgv불량상세정보);
            this.groupBox2.Location = new System.Drawing.Point(544, 290);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(481, 251);
            this.groupBox2.TabIndex = 68;
            this.groupBox2.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 99;
            this.label12.Text = "검사내역";
            // 
            // dgv불량상세정보
            // 
            this.dgv불량상세정보.AllowUserToAddRows = false;
            this.dgv불량상세정보.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv불량상세정보.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv불량상세정보.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column8});
            this.dgv불량상세정보.Location = new System.Drawing.Point(6, 29);
            this.dgv불량상세정보.Name = "dgv불량상세정보";
            this.dgv불량상세정보.RowTemplate.Height = 23;
            this.dgv불량상세정보.Size = new System.Drawing.Size(475, 216);
            this.dgv불량상세정보.TabIndex = 98;
            this.dgv불량상세정보.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv불량상세정보_CellEndEdit);
            this.dgv불량상세정보.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Dgv불량상세정보_KeyDown);
            // 
            // Column7
            // 
            this.Column7.HeaderText = "불량코드정보";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "불량갯수";
            this.Column8.Name = "Column8";
            // 
            // 입고등록
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgv입고등록리스트);
            this.Controls.Add(this.dgv입고등록);
            this.Controls.Add(this.btn조회);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Name = "입고등록";
            this.Size = new System.Drawing.Size(1044, 645);
            this.Load += new System.EventHandler(this.입고등록_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv입고등록리스트)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv입고등록)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv불량상세정보)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv입고등록리스트;
        private System.Windows.Forms.DataGridView dgv입고등록;
        private System.Windows.Forms.Button btn조회;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox txb거래처이름;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv불량상세정보;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker LastDate;
        private System.Windows.Forms.DateTimePicker FirstDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txb발주번호;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column0;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}
