namespace SMART_ERP_System.MenuUserControl
{
    partial class 입고현황
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txb공급업체 = new System.Windows.Forms.TextBox();
            this.OrderLast = new System.Windows.Forms.DateTimePicker();
            this.OrderStart = new System.Windows.Forms.DateTimePicker();
            this.txb입고번호 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn조회 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tab입고 = new System.Windows.Forms.TabControl();
            this.발주입고 = new System.Windows.Forms.TabPage();
            this.dgv발주입고 = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.예외입고 = new System.Windows.Forms.TabPage();
            this.dgv예외입고 = new System.Windows.Forms.DataGridView();
            this.반품처리서번호DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.공급업체번호DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.반품처리날짜 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bds반품처리서 = new System.Windows.Forms.BindingSource(this.components);
            this.dgv입고등록리스트 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.tab입고.SuspendLayout();
            this.발주입고.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv발주입고)).BeginInit();
            this.예외입고.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv예외입고)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds반품처리서)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv입고등록리스트)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txb공급업체);
            this.groupBox1.Controls.Add(this.OrderLast);
            this.groupBox1.Controls.Add(this.OrderStart);
            this.groupBox1.Controls.Add(this.txb입고번호);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(7, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1018, 54);
            this.groupBox1.TabIndex = 109;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(317, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 12);
            this.label2.TabIndex = 104;
            this.label2.Text = "입고/반품번호";
            // 
            // txb공급업체
            // 
            this.txb공급업체.Location = new System.Drawing.Point(97, 16);
            this.txb공급업체.Name = "txb공급업체";
            this.txb공급업체.Size = new System.Drawing.Size(180, 20);
            this.txb공급업체.TabIndex = 103;
            // 
            // OrderLast
            // 
            this.OrderLast.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.OrderLast.Location = new System.Drawing.Point(835, 19);
            this.OrderLast.Name = "OrderLast";
            this.OrderLast.Size = new System.Drawing.Size(96, 20);
            this.OrderLast.TabIndex = 102;
            // 
            // OrderStart
            // 
            this.OrderStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.OrderStart.Location = new System.Drawing.Point(716, 19);
            this.OrderStart.Name = "OrderStart";
            this.OrderStart.Size = new System.Drawing.Size(96, 20);
            this.OrderStart.TabIndex = 101;
            // 
            // txb입고번호
            // 
            this.txb입고번호.Location = new System.Drawing.Point(413, 19);
            this.txb입고번호.Name = "txb입고번호";
            this.txb입고번호.Size = new System.Drawing.Size(180, 20);
            this.txb입고번호.TabIndex = 100;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(653, 24);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 12);
            this.label15.TabIndex = 51;
            this.label15.Text = "발주기간";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(818, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 11);
            this.label3.TabIndex = 27;
            this.label3.Text = "~";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(53, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 12);
            this.label6.TabIndex = 33;
            this.label6.Text = "거래처";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림체", 15.75F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(51, 2);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 21);
            this.label8.TabIndex = 108;
            this.label8.Text = "입고현황";
            // 
            // btn조회
            // 
            this.btn조회.Location = new System.Drawing.Point(941, -1);
            this.btn조회.Name = "btn조회";
            this.btn조회.Size = new System.Drawing.Size(84, 23);
            this.btn조회.TabIndex = 107;
            this.btn조회.Text = "조회";
            this.btn조회.UseVisualStyleBackColor = true;
            this.btn조회.Click += new System.EventHandler(this.Btn조회_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1018, 1);
            this.label1.TabIndex = 106;
            this.label1.Text = "label1";
            // 
            // tab입고
            // 
            this.tab입고.Controls.Add(this.발주입고);
            this.tab입고.Controls.Add(this.예외입고);
            this.tab입고.Location = new System.Drawing.Point(7, 89);
            this.tab입고.Name = "tab입고";
            this.tab입고.SelectedIndex = 0;
            this.tab입고.Size = new System.Drawing.Size(1018, 266);
            this.tab입고.TabIndex = 110;
            this.tab입고.SelectedIndexChanged += new System.EventHandler(this.Tab입고_SelectedIndexChanged);
            // 
            // 발주입고
            // 
            this.발주입고.Controls.Add(this.dgv발주입고);
            this.발주입고.Location = new System.Drawing.Point(4, 22);
            this.발주입고.Name = "발주입고";
            this.발주입고.Padding = new System.Windows.Forms.Padding(3);
            this.발주입고.Size = new System.Drawing.Size(1010, 240);
            this.발주입고.TabIndex = 0;
            this.발주입고.Text = "발주입고";
            this.발주입고.UseVisualStyleBackColor = true;
            // 
            // dgv발주입고
            // 
            this.dgv발주입고.AllowUserToAddRows = false;
            this.dgv발주입고.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv발주입고.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv발주입고.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgv발주입고.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv발주입고.Location = new System.Drawing.Point(3, 3);
            this.dgv발주입고.Name = "dgv발주입고";
            this.dgv발주입고.RowTemplate.Height = 23;
            this.dgv발주입고.Size = new System.Drawing.Size(1004, 234);
            this.dgv발주입고.TabIndex = 0;
            this.dgv발주입고.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv발주입고_CellClick);
            // 
            // Column3
            // 
            this.Column3.HeaderText = "입고등록번호";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "발주번호";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "공급업체";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "입고날짜";
            this.Column6.Name = "Column6";
            // 
            // 예외입고
            // 
            this.예외입고.Controls.Add(this.dgv예외입고);
            this.예외입고.Location = new System.Drawing.Point(4, 22);
            this.예외입고.Name = "예외입고";
            this.예외입고.Padding = new System.Windows.Forms.Padding(3);
            this.예외입고.Size = new System.Drawing.Size(1010, 240);
            this.예외입고.TabIndex = 1;
            this.예외입고.Text = "예외입고";
            this.예외입고.UseVisualStyleBackColor = true;
            // 
            // dgv예외입고
            // 
            this.dgv예외입고.AllowUserToAddRows = false;
            this.dgv예외입고.AutoGenerateColumns = false;
            this.dgv예외입고.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv예외입고.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv예외입고.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.반품처리서번호DataGridViewTextBoxColumn,
            this.공급업체번호DataGridViewTextBoxColumn,
            this.반품처리날짜});
            this.dgv예외입고.DataSource = this.bds반품처리서;
            this.dgv예외입고.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv예외입고.Location = new System.Drawing.Point(3, 3);
            this.dgv예외입고.Name = "dgv예외입고";
            this.dgv예외입고.Size = new System.Drawing.Size(1004, 234);
            this.dgv예외입고.TabIndex = 1;
            this.dgv예외입고.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv예외입고_CellClick);
            // 
            // 반품처리서번호DataGridViewTextBoxColumn
            // 
            this.반품처리서번호DataGridViewTextBoxColumn.DataPropertyName = "반품처리서번호";
            this.반품처리서번호DataGridViewTextBoxColumn.HeaderText = "반품처리서번호";
            this.반품처리서번호DataGridViewTextBoxColumn.Name = "반품처리서번호DataGridViewTextBoxColumn";
            // 
            // 공급업체번호DataGridViewTextBoxColumn
            // 
            this.공급업체번호DataGridViewTextBoxColumn.DataPropertyName = "공급업체번호";
            this.공급업체번호DataGridViewTextBoxColumn.HeaderText = "공급업체";
            this.공급업체번호DataGridViewTextBoxColumn.Name = "공급업체번호DataGridViewTextBoxColumn";
            // 
            // 반품처리날짜
            // 
            this.반품처리날짜.DataPropertyName = "반품처리날짜";
            this.반품처리날짜.HeaderText = "반품처리날짜";
            this.반품처리날짜.Name = "반품처리날짜";
            // 
            // bds반품처리서
            // 
            this.bds반품처리서.DataSource = typeof(ClassLibrary.반품처리서);
            // 
            // dgv입고등록리스트
            // 
            this.dgv입고등록리스트.AllowUserToAddRows = false;
            this.dgv입고등록리스트.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv입고등록리스트.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv입고등록리스트.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgv입고등록리스트.Location = new System.Drawing.Point(9, 380);
            this.dgv입고등록리스트.Name = "dgv입고등록리스트";
            this.dgv입고등록리스트.RowTemplate.Height = 23;
            this.dgv입고등록리스트.Size = new System.Drawing.Size(1016, 232);
            this.dgv입고등록리스트.TabIndex = 111;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "자재";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "수량";
            this.Column2.Name = "Column2";
            // 
            // 입고현황
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv입고등록리스트);
            this.Controls.Add(this.tab입고);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn조회);
            this.Controls.Add(this.label1);
            this.Name = "입고현황";
            this.Size = new System.Drawing.Size(1044, 645);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tab입고.ResumeLayout(false);
            this.발주입고.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv발주입고)).EndInit();
            this.예외입고.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv예외입고)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds반품처리서)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv입고등록리스트)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txb입고번호;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn조회;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tab입고;
        private System.Windows.Forms.TabPage 발주입고;
        private System.Windows.Forms.DataGridView dgv발주입고;
        private System.Windows.Forms.TabPage 예외입고;
        private System.Windows.Forms.DataGridView dgv예외입고;
        private System.Windows.Forms.DataGridView dgv입고등록리스트;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb공급업체;
        private System.Windows.Forms.DateTimePicker OrderLast;
        private System.Windows.Forms.DateTimePicker OrderStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.BindingSource bds반품처리서;
        private System.Windows.Forms.DataGridViewTextBoxColumn 반품처리서번호DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 공급업체번호DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 반품처리날짜;
    }
}
