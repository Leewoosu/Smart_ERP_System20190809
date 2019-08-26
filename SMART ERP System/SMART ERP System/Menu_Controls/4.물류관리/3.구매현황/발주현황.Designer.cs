namespace SMART_ERP_System.MenuUserControl
{
    partial class 발주현황
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
            this.components = new System.ComponentModel.Container();
            this.dgv발주 = new System.Windows.Forms.DataGridView();
            this.발주번호DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.공급업체번호DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.주문날짜DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.납기일DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bds발주 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbb사원코드 = new System.Windows.Forms.ComboBox();
            this.사원등록BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DeliveryLastDate = new System.Windows.Forms.DateTimePicker();
            this.DeliveryFirstDate = new System.Windows.Forms.DateTimePicker();
            this.cbb부서코드 = new System.Windows.Forms.ComboBox();
            this.부서등록BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.txb사원명 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.OrderLastDate = new System.Windows.Forms.DateTimePicker();
            this.txb부서명 = new System.Windows.Forms.TextBox();
            this.OrderFirstDate = new System.Windows.Forms.DateTimePicker();
            this.txb거래처이름 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn조회 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv발주리스트 = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.공급업체번호DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.주문날짜DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.납기일DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv발주)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds발주)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.사원등록BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.부서등록BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv발주리스트)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv발주
            // 
            this.dgv발주.AutoGenerateColumns = false;
            this.dgv발주.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv발주.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv발주.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.발주번호DataGridViewTextBoxColumn1,
            this.공급업체번호DataGridViewTextBoxColumn1,
            this.주문날짜DataGridViewTextBoxColumn1,
            this.납기일DataGridViewTextBoxColumn1});
            this.dgv발주.DataSource = this.bds발주;
            this.dgv발주.Location = new System.Drawing.Point(9, 180);
            this.dgv발주.Name = "dgv발주";
            this.dgv발주.RowTemplate.Height = 23;
            this.dgv발주.Size = new System.Drawing.Size(1018, 212);
            this.dgv발주.TabIndex = 105;
            this.dgv발주.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv발주_CellClick);
            // 
            // 발주번호DataGridViewTextBoxColumn1
            // 
            this.발주번호DataGridViewTextBoxColumn1.DataPropertyName = "발주번호";
            this.발주번호DataGridViewTextBoxColumn1.HeaderText = "발주번호";
            this.발주번호DataGridViewTextBoxColumn1.Name = "발주번호DataGridViewTextBoxColumn1";
            // 
            // 공급업체번호DataGridViewTextBoxColumn1
            // 
            this.공급업체번호DataGridViewTextBoxColumn1.DataPropertyName = "공급업체번호";
            this.공급업체번호DataGridViewTextBoxColumn1.HeaderText = "공급업체번호";
            this.공급업체번호DataGridViewTextBoxColumn1.Name = "공급업체번호DataGridViewTextBoxColumn1";
            // 
            // 주문날짜DataGridViewTextBoxColumn1
            // 
            this.주문날짜DataGridViewTextBoxColumn1.DataPropertyName = "주문날짜";
            this.주문날짜DataGridViewTextBoxColumn1.HeaderText = "주문날짜";
            this.주문날짜DataGridViewTextBoxColumn1.Name = "주문날짜DataGridViewTextBoxColumn1";
            // 
            // 납기일DataGridViewTextBoxColumn1
            // 
            this.납기일DataGridViewTextBoxColumn1.DataPropertyName = "납기일";
            this.납기일DataGridViewTextBoxColumn1.HeaderText = "납기일";
            this.납기일DataGridViewTextBoxColumn1.Name = "납기일DataGridViewTextBoxColumn1";
            // 
            // bds발주
            // 
            this.bds발주.DataSource = typeof(ClassLibrary.발주서);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.cbb사원코드);
            this.groupBox1.Controls.Add(this.DeliveryLastDate);
            this.groupBox1.Controls.Add(this.DeliveryFirstDate);
            this.groupBox1.Controls.Add(this.cbb부서코드);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txb사원명);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.OrderLastDate);
            this.groupBox1.Controls.Add(this.txb부서명);
            this.groupBox1.Controls.Add(this.OrderFirstDate);
            this.groupBox1.Controls.Add(this.txb거래처이름);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(7, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1018, 105);
            this.groupBox1.TabIndex = 104;
            this.groupBox1.TabStop = false;
            // 
            // cbb사원코드
            // 
            this.cbb사원코드.DataSource = this.사원등록BindingSource;
            this.cbb사원코드.FormattingEnabled = true;
            this.cbb사원코드.Location = new System.Drawing.Point(374, 21);
            this.cbb사원코드.Name = "cbb사원코드";
            this.cbb사원코드.Size = new System.Drawing.Size(65, 19);
            this.cbb사원코드.TabIndex = 85;
            this.cbb사원코드.SelectedValueChanged += new System.EventHandler(this.Cbb사원코드_SelectedValueChanged);
            // 
            // 사원등록BindingSource
            // 
            this.사원등록BindingSource.DataSource = typeof(ClassLibrary.사원등록);
            // 
            // DeliveryLastDate
            // 
            this.DeliveryLastDate.CustomFormat = "yyyy-MM-dd";
            this.DeliveryLastDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DeliveryLastDate.Location = new System.Drawing.Point(842, 70);
            this.DeliveryLastDate.Name = "DeliveryLastDate";
            this.DeliveryLastDate.Size = new System.Drawing.Size(99, 20);
            this.DeliveryLastDate.TabIndex = 79;
            // 
            // DeliveryFirstDate
            // 
            this.DeliveryFirstDate.CustomFormat = "yyyy-MM-dd";
            this.DeliveryFirstDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DeliveryFirstDate.Location = new System.Drawing.Point(711, 70);
            this.DeliveryFirstDate.Name = "DeliveryFirstDate";
            this.DeliveryFirstDate.Size = new System.Drawing.Size(103, 20);
            this.DeliveryFirstDate.TabIndex = 78;
            // 
            // cbb부서코드
            // 
            this.cbb부서코드.DataSource = this.부서등록BindingSource;
            this.cbb부서코드.FormattingEnabled = true;
            this.cbb부서코드.Location = new System.Drawing.Point(85, 21);
            this.cbb부서코드.Name = "cbb부서코드";
            this.cbb부서코드.Size = new System.Drawing.Size(65, 19);
            this.cbb부서코드.TabIndex = 84;
            this.cbb부서코드.SelectedValueChanged += new System.EventHandler(this.Cbb부서코드_SelectedValueChanged);
            // 
            // 부서등록BindingSource
            // 
            this.부서등록BindingSource.DataSource = typeof(ClassLibrary.부서등록);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(638, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 14);
            this.label4.TabIndex = 77;
            this.label4.Text = "납기기간";
            // 
            // txb사원명
            // 
            this.txb사원명.Location = new System.Drawing.Point(445, 21);
            this.txb사원명.Name = "txb사원명";
            this.txb사원명.Size = new System.Drawing.Size(108, 20);
            this.txb사원명.TabIndex = 83;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(824, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 11);
            this.label7.TabIndex = 76;
            this.label7.Text = "~";
            // 
            // OrderLastDate
            // 
            this.OrderLastDate.CustomFormat = "yyyy-MM-dd";
            this.OrderLastDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.OrderLastDate.Location = new System.Drawing.Point(498, 69);
            this.OrderLastDate.Name = "OrderLastDate";
            this.OrderLastDate.Size = new System.Drawing.Size(99, 20);
            this.OrderLastDate.TabIndex = 75;
            // 
            // txb부서명
            // 
            this.txb부서명.Location = new System.Drawing.Point(156, 21);
            this.txb부서명.Name = "txb부서명";
            this.txb부서명.Size = new System.Drawing.Size(108, 20);
            this.txb부서명.TabIndex = 82;
            // 
            // OrderFirstDate
            // 
            this.OrderFirstDate.CustomFormat = "yyyy-MM-dd";
            this.OrderFirstDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.OrderFirstDate.Location = new System.Drawing.Point(374, 70);
            this.OrderFirstDate.Name = "OrderFirstDate";
            this.OrderFirstDate.Size = new System.Drawing.Size(103, 20);
            this.OrderFirstDate.TabIndex = 74;
            // 
            // txb거래처이름
            // 
            this.txb거래처이름.Location = new System.Drawing.Point(85, 69);
            this.txb거래처이름.Name = "txb거래처이름";
            this.txb거래처이름.Size = new System.Drawing.Size(179, 20);
            this.txb거래처이름.TabIndex = 73;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(331, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 14);
            this.label11.TabIndex = 81;
            this.label11.Text = "사원";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(301, 73);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 14);
            this.label15.TabIndex = 72;
            this.label15.Text = "주문기간";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(481, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 11);
            this.label3.TabIndex = 70;
            this.label3.Text = "~";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(41, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 14);
            this.label2.TabIndex = 80;
            this.label2.Text = "부서";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(26, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 14);
            this.label6.TabIndex = 71;
            this.label6.Text = "거래처";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림체", 15.75F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(51, 2);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 21);
            this.label8.TabIndex = 103;
            this.label8.Text = "발주현황";
            // 
            // btn조회
            // 
            this.btn조회.Location = new System.Drawing.Point(943, -1);
            this.btn조회.Name = "btn조회";
            this.btn조회.Size = new System.Drawing.Size(84, 23);
            this.btn조회.TabIndex = 102;
            this.btn조회.Text = "조회";
            this.btn조회.UseVisualStyleBackColor = true;
            this.btn조회.Click += new System.EventHandler(this.Btn조회_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(7, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1018, 1);
            this.label1.TabIndex = 101;
            this.label1.Text = "label1";
            // 
            // dgv발주리스트
            // 
            this.dgv발주리스트.AllowUserToAddRows = false;
            this.dgv발주리스트.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv발주리스트.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv발주리스트.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column1});
            this.dgv발주리스트.Location = new System.Drawing.Point(7, 417);
            this.dgv발주리스트.Name = "dgv발주리스트";
            this.dgv발주리스트.RowTemplate.Height = 23;
            this.dgv발주리스트.Size = new System.Drawing.Size(1018, 210);
            this.dgv발주리스트.TabIndex = 106;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "자재";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "수량";
            this.Column3.Name = "Column3";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "자재번호";
            this.Column1.HeaderText = "미입고수량";
            this.Column1.Name = "Column1";
            // 
            // 공급업체번호DataGridViewTextBoxColumn
            // 
            this.공급업체번호DataGridViewTextBoxColumn.DataPropertyName = "공급업체번호";
            this.공급업체번호DataGridViewTextBoxColumn.HeaderText = "공급업체번호";
            this.공급업체번호DataGridViewTextBoxColumn.Name = "공급업체번호DataGridViewTextBoxColumn";
            // 
            // 주문날짜DataGridViewTextBoxColumn
            // 
            this.주문날짜DataGridViewTextBoxColumn.DataPropertyName = "주문날짜";
            this.주문날짜DataGridViewTextBoxColumn.HeaderText = "주문날짜";
            this.주문날짜DataGridViewTextBoxColumn.Name = "주문날짜DataGridViewTextBoxColumn";
            // 
            // 납기일DataGridViewTextBoxColumn
            // 
            this.납기일DataGridViewTextBoxColumn.DataPropertyName = "납기일";
            this.납기일DataGridViewTextBoxColumn.HeaderText = "납기일";
            this.납기일DataGridViewTextBoxColumn.Name = "납기일DataGridViewTextBoxColumn";
            // 
            // 발주현황
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv발주리스트);
            this.Controls.Add(this.dgv발주);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn조회);
            this.Controls.Add(this.label1);
            this.Name = "발주현황";
            this.Size = new System.Drawing.Size(1044, 645);
            this.Load += new System.EventHandler(this.발주현황_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv발주)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds발주)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.사원등록BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.부서등록BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv발주리스트)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn조회;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 공급업체번호DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 주문날짜DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 납기일DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bds발주;
        private System.Windows.Forms.DataGridView dgv발주리스트;
        private System.Windows.Forms.DateTimePicker DeliveryLastDate;
        private System.Windows.Forms.DateTimePicker DeliveryFirstDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker OrderLastDate;
        private System.Windows.Forms.DateTimePicker OrderFirstDate;
        private System.Windows.Forms.TextBox txb거래처이름;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgv발주;
        private System.Windows.Forms.DataGridViewTextBoxColumn 발주번호DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 공급업체번호DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 주문날짜DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 납기일DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.ComboBox cbb사원코드;
        private System.Windows.Forms.ComboBox cbb부서코드;
        private System.Windows.Forms.TextBox txb사원명;
        private System.Windows.Forms.TextBox txb부서명;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource 사원등록BindingSource;
        private System.Windows.Forms.BindingSource 부서등록BindingSource;
    }
}
