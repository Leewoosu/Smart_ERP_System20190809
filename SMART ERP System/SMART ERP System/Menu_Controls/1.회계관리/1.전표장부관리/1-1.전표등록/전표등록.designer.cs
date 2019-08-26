namespace SMART_ERP_System.MenuUserControl
{
    partial class 전표등록
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbb사업장코드 = new System.Windows.Forms.ComboBox();
            this.사업장등록BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbb부서코드 = new System.Windows.Forms.ComboBox();
            this.부서등록BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbb사원코드 = new System.Windows.Forms.ComboBox();
            this.사원등록BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbb월 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txb일 = new System.Windows.Forms.TextBox();
            this.lbl회계년도 = new System.Windows.Forms.Label();
            this.txb사원명 = new System.Windows.Forms.TextBox();
            this.txb부서명 = new System.Windows.Forms.TextBox();
            this.txb사업장명 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn합계 = new System.Windows.Forms.Button();
            this.txb대변합계 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txb차변합계 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgv전표리스트 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.구분 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv전표 = new System.Windows.Forms.DataGridView();
            this.CheckColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.사업장등록BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.부서등록BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.사원등록BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv전표리스트)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv전표)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btn합계);
            this.groupBox1.Controls.Add(this.txb대변합계);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txb차변합계);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dgv전표리스트);
            this.groupBox1.Controls.Add(this.dgv전표);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1041, 651);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.cbb사업장코드);
            this.groupBox2.Controls.Add(this.cbb부서코드);
            this.groupBox2.Controls.Add(this.cbb사원코드);
            this.groupBox2.Controls.Add(this.cbb월);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txb일);
            this.groupBox2.Controls.Add(this.lbl회계년도);
            this.groupBox2.Controls.Add(this.txb사원명);
            this.groupBox2.Controls.Add(this.txb부서명);
            this.groupBox2.Controls.Add(this.txb사업장명);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(7, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1028, 33);
            this.groupBox2.TabIndex = 108;
            this.groupBox2.TabStop = false;
            // 
            // cbb사업장코드
            // 
            this.cbb사업장코드.DataSource = this.사업장등록BindingSource;
            this.cbb사업장코드.DisplayMember = "사업장코드";
            this.cbb사업장코드.Font = new System.Drawing.Font("굴림", 10F);
            this.cbb사업장코드.FormattingEnabled = true;
            this.cbb사업장코드.Location = new System.Drawing.Point(95, 5);
            this.cbb사업장코드.Name = "cbb사업장코드";
            this.cbb사업장코드.Size = new System.Drawing.Size(64, 21);
            this.cbb사업장코드.TabIndex = 120;
            this.cbb사업장코드.TabStop = false;
            this.cbb사업장코드.ValueMember = "사업장코드";
            // 
            // 사업장등록BindingSource
            // 
            this.사업장등록BindingSource.DataSource = typeof(ClassLibrary.사업장등록);
            // 
            // cbb부서코드
            // 
            this.cbb부서코드.DataSource = this.부서등록BindingSource;
            this.cbb부서코드.DisplayMember = "부서코드";
            this.cbb부서코드.Font = new System.Drawing.Font("굴림", 10F);
            this.cbb부서코드.FormattingEnabled = true;
            this.cbb부서코드.Location = new System.Drawing.Point(348, 5);
            this.cbb부서코드.Name = "cbb부서코드";
            this.cbb부서코드.Size = new System.Drawing.Size(83, 21);
            this.cbb부서코드.TabIndex = 125;
            this.cbb부서코드.ValueMember = "부서코드";
            this.cbb부서코드.SelectedValueChanged += new System.EventHandler(this.Cbb부서코드_SelectedValueChanged);
            // 
            // 부서등록BindingSource
            // 
            this.부서등록BindingSource.DataSource = typeof(ClassLibrary.부서등록);
            // 
            // cbb사원코드
            // 
            this.cbb사원코드.DataSource = this.사원등록BindingSource;
            this.cbb사원코드.DisplayMember = "사원코드";
            this.cbb사원코드.Font = new System.Drawing.Font("굴림", 10F);
            this.cbb사원코드.FormattingEnabled = true;
            this.cbb사원코드.Location = new System.Drawing.Point(583, 5);
            this.cbb사원코드.Name = "cbb사원코드";
            this.cbb사원코드.Size = new System.Drawing.Size(83, 21);
            this.cbb사원코드.TabIndex = 126;
            this.cbb사원코드.ValueMember = "사원코드";
            this.cbb사원코드.SelectedValueChanged += new System.EventHandler(this.Cbb사원코드_SelectedValueChanged);
            // 
            // 사원등록BindingSource
            // 
            this.사원등록BindingSource.DataSource = typeof(ClassLibrary.사원등록);
            // 
            // cbb월
            // 
            this.cbb월.Font = new System.Drawing.Font("굴림", 10F);
            this.cbb월.FormattingEnabled = true;
            this.cbb월.Location = new System.Drawing.Point(831, 6);
            this.cbb월.Name = "cbb월";
            this.cbb월.Size = new System.Drawing.Size(36, 21);
            this.cbb월.TabIndex = 130;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label8.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(903, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 22);
            this.label8.TabIndex = 104;
            this.label8.Text = "일";
            // 
            // txb일
            // 
            this.txb일.Location = new System.Drawing.Point(869, 6);
            this.txb일.Name = "txb일";
            this.txb일.Size = new System.Drawing.Size(36, 21);
            this.txb일.TabIndex = 102;
            this.txb일.TextChanged += new System.EventHandler(this.Txb일_TextChanged);
            this.txb일.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txb일_KeyDown);
            // 
            // lbl회계년도
            // 
            this.lbl회계년도.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl회계년도.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.lbl회계년도.Location = new System.Drawing.Point(786, 8);
            this.lbl회계년도.Name = "lbl회계년도";
            this.lbl회계년도.Size = new System.Drawing.Size(79, 22);
            this.lbl회계년도.TabIndex = 129;
            this.lbl회계년도.Text = "2018";
            // 
            // txb사원명
            // 
            this.txb사원명.Location = new System.Drawing.Point(673, 5);
            this.txb사원명.Name = "txb사원명";
            this.txb사원명.Size = new System.Drawing.Size(82, 21);
            this.txb사원명.TabIndex = 127;
            // 
            // txb부서명
            // 
            this.txb부서명.Location = new System.Drawing.Point(441, 5);
            this.txb부서명.Name = "txb부서명";
            this.txb부서명.Size = new System.Drawing.Size(82, 21);
            this.txb부서명.TabIndex = 124;
            // 
            // txb사업장명
            // 
            this.txb사업장명.Enabled = false;
            this.txb사업장명.Location = new System.Drawing.Point(165, 5);
            this.txb사업장명.Name = "txb사업장명";
            this.txb사업장명.Size = new System.Drawing.Size(107, 21);
            this.txb사업장명.TabIndex = 123;
            this.txb사업장명.TabStop = false;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(529, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 22);
            this.label5.TabIndex = 122;
            this.label5.Text = "작성자";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(282, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 22);
            this.label4.TabIndex = 121;
            this.label4.Text = "결의부서";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(27, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 22);
            this.label2.TabIndex = 119;
            this.label2.Text = "회계단위";
            // 
            // btn합계
            // 
            this.btn합계.Location = new System.Drawing.Point(330, 561);
            this.btn합계.Name = "btn합계";
            this.btn합계.Size = new System.Drawing.Size(75, 23);
            this.btn합계.TabIndex = 105;
            this.btn합계.TabStop = false;
            this.btn합계.Text = "합계";
            this.btn합계.UseVisualStyleBackColor = true;
            this.btn합계.Click += new System.EventHandler(this.Btn합계_Click);
            // 
            // txb대변합계
            // 
            this.txb대변합계.Location = new System.Drawing.Point(857, 563);
            this.txb대변합계.Name = "txb대변합계";
            this.txb대변합계.Size = new System.Drawing.Size(172, 21);
            this.txb대변합계.TabIndex = 132;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(767, 566);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 22);
            this.label7.TabIndex = 103;
            this.label7.Text = "대변의 합계";
            // 
            // txb차변합계
            // 
            this.txb차변합계.Location = new System.Drawing.Point(517, 563);
            this.txb차변합계.Name = "txb차변합계";
            this.txb차변합계.Size = new System.Drawing.Size(172, 21);
            this.txb차변합계.TabIndex = 131;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(427, 566);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 22);
            this.label6.TabIndex = 101;
            this.label6.Text = "차변의 합계";
            // 
            // dgv전표리스트
            // 
            this.dgv전표리스트.AllowUserToAddRows = false;
            this.dgv전표리스트.AllowUserToResizeColumns = false;
            this.dgv전표리스트.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv전표리스트.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv전표리스트.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv전표리스트.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.구분,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.Column9});
            this.dgv전표리스트.Location = new System.Drawing.Point(7, 308);
            this.dgv전표리스트.Name = "dgv전표리스트";
            this.dgv전표리스트.RowHeadersVisible = false;
            this.dgv전표리스트.RowTemplate.Height = 23;
            this.dgv전표리스트.Size = new System.Drawing.Size(1025, 247);
            this.dgv전표리스트.TabIndex = 100;
            this.dgv전표리스트.TabStop = false;
            this.dgv전표리스트.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv전표리스트_CellEndEdit);
            this.dgv전표리스트.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv전표리스트_CellEnter);
            this.dgv전표리스트.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.Dgv전표리스트_DataError);
            this.dgv전표리스트.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.Dgv전표리스트_RowPostPaint);
            this.dgv전표리스트.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Dgv전표리스트_KeyDown);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn1.HeaderText = "순번";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 60;
            // 
            // 구분
            // 
            this.구분.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.구분.HeaderText = "구분";
            this.구분.Name = "구분";
            this.구분.Width = 60;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn3.HeaderText = "코드";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 85;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn4.HeaderText = "계정과목";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn5.HeaderText = "코드";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 85;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn6.HeaderText = "거래처명";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 140;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn7.HeaderText = "사업자(주민)번호";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn8.HeaderText = "금액";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 130;
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column9.HeaderText = "적요명";
            this.Column9.Name = "Column9";
            this.Column9.Width = 160;
            // 
            // dgv전표
            // 
            this.dgv전표.AllowUserToAddRows = false;
            this.dgv전표.AllowUserToResizeColumns = false;
            this.dgv전표.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv전표.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv전표.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv전표.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckColumn,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column10,
            this.Column4,
            this.Column5,
            this.Column7,
            this.Column6,
            this.Column8});
            this.dgv전표.Location = new System.Drawing.Point(7, 69);
            this.dgv전표.Name = "dgv전표";
            this.dgv전표.RowHeadersVisible = false;
            this.dgv전표.RowTemplate.Height = 23;
            this.dgv전표.Size = new System.Drawing.Size(905, 233);
            this.dgv전표.TabIndex = 99;
            this.dgv전표.TabStop = false;
            this.dgv전표.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv전표_CellClick);
            this.dgv전표.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv전표_CellEnter);
            this.dgv전표.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.Dgv전표_CellPainting);
            this.dgv전표.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.Dgv전표_DataError);
            this.dgv전표.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.Dgv전표_RowPostPaint);
            this.dgv전표.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Dgv전표_Scroll);
            this.dgv전표.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Dgv전표_KeyDown);
            // 
            // CheckColumn
            // 
            this.CheckColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CheckColumn.HeaderText = "";
            this.CheckColumn.Name = "CheckColumn";
            this.CheckColumn.Width = 50;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.HeaderText = "일";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column2.HeaderText = "번호";
            this.Column2.Name = "Column2";
            this.Column2.Width = 60;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "품의내역";
            this.Column3.Name = "Column3";
            // 
            // Column10
            // 
            this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column10.HeaderText = "유형";
            this.Column10.Name = "Column10";
            this.Column10.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column10.Width = 70;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column4.HeaderText = "기표번호";
            this.Column4.Name = "Column4";
            this.Column4.Width = 120;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column5.HeaderText = "상태";
            this.Column5.Name = "Column5";
            this.Column5.Width = 70;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column7.HeaderText = "승인자";
            this.Column7.Name = "Column7";
            this.Column7.Width = 80;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column6.HeaderText = "대차차액";
            this.Column6.Name = "Column6";
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column8.HeaderText = "작업자";
            this.Column8.Name = "Column8";
            this.Column8.Width = 80;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(536, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 88;
            this.button4.TabStop = false;
            this.button4.Text = "전표양식";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(617, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 87;
            this.button3.TabStop = false;
            this.button3.Text = "재무부서";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(698, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 86;
            this.button2.TabStop = false;
            this.button2.Text = "환경설정";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(455, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 85;
            this.button1.TabStop = false;
            this.button1.Text = "전표검색";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("굴림체", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(51, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 23);
            this.label3.TabIndex = 84;
            this.label3.Text = "전표등록";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1025, 1);
            this.label1.TabIndex = 83;
            // 
            // 전표등록
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "전표등록";
            this.Size = new System.Drawing.Size(1044, 645);
            this.Load += new System.EventHandler(this.전표등록_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.사업장등록BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.부서등록BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.사원등록BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv전표리스트)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv전표)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn합계;
        private System.Windows.Forms.TextBox txb대변합계;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txb차변합계;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgv전표리스트;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txb사원명;
        private System.Windows.Forms.ComboBox cbb사원코드;
        private System.Windows.Forms.ComboBox cbb부서코드;
        private System.Windows.Forms.TextBox txb부서명;
        private System.Windows.Forms.TextBox txb사업장명;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txb일;
        private System.Windows.Forms.ComboBox cbb월;
        private System.Windows.Forms.Label lbl회계년도;
        public System.Windows.Forms.DataGridView dgv전표;
        private System.Windows.Forms.BindingSource 사원등록BindingSource;
        private System.Windows.Forms.BindingSource 부서등록BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 구분;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.BindingSource 사업장등록BindingSource;
        private System.Windows.Forms.ComboBox cbb사업장코드;
    }
}
