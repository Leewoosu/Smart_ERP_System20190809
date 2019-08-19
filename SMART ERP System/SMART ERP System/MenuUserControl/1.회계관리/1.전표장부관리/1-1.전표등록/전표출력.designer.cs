namespace SMART_ERP_System.MenuUserControl
{
    partial class 전표출력
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbxSearchMenu = new System.Windows.Forms.GroupBox();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbb전표유형 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbb전표구분 = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbb전표상태 = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txb사원명 = new System.Windows.Forms.TextBox();
            this.cbb사원코드 = new System.Windows.Forms.ComboBox();
            this.사원등록BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label16 = new System.Windows.Forms.Label();
            this.cbb부서코드 = new System.Windows.Forms.ComboBox();
            this.부서등록BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txb부서명 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txb회사명 = new System.Windows.Forms.TextBox();
            this.cbb회사코드 = new System.Windows.Forms.ComboBox();
            this.회사등록BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label18 = new System.Windows.Forms.Label();
            this.dgv전표리스트 = new System.Windows.Forms.DataGridView();
            this.순번DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.전표번호 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.입력날짜DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.구분DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.계정과목코드번호DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.계정과목명 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.거래처코드번호DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.거래처명 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.적요명DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.차변 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.대변 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.전표리스트BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.btn전표양식 = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gbxSearchMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.사원등록BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.부서등록BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.회사등록BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv전표리스트)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.전표리스트BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gbxSearchMenu);
            this.groupBox1.Controls.Add(this.dgv전표리스트);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btn전표양식);
            this.groupBox1.Controls.Add(this.btnSum);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1039, 645);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // gbxSearchMenu
            // 
            this.gbxSearchMenu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gbxSearchMenu.Controls.Add(this.cbb회사코드);
            this.gbxSearchMenu.Controls.Add(this.cbb부서코드);
            this.gbxSearchMenu.Controls.Add(this.cbb사원코드);
            this.gbxSearchMenu.Controls.Add(this.cbb전표상태);
            this.gbxSearchMenu.Controls.Add(this.cbb전표구분);
            this.gbxSearchMenu.Controls.Add(this.cbb전표유형);
            this.gbxSearchMenu.Controls.Add(this.dtpFrom);
            this.gbxSearchMenu.Controls.Add(this.dtpTo);
            this.gbxSearchMenu.Controls.Add(this.label3);
            this.gbxSearchMenu.Controls.Add(this.label1);
            this.gbxSearchMenu.Controls.Add(this.label13);
            this.gbxSearchMenu.Controls.Add(this.label14);
            this.gbxSearchMenu.Controls.Add(this.label15);
            this.gbxSearchMenu.Controls.Add(this.txb사원명);
            this.gbxSearchMenu.Controls.Add(this.label16);
            this.gbxSearchMenu.Controls.Add(this.txb회사명);
            this.gbxSearchMenu.Controls.Add(this.txb부서명);
            this.gbxSearchMenu.Controls.Add(this.label17);
            this.gbxSearchMenu.Controls.Add(this.label18);
            this.gbxSearchMenu.Location = new System.Drawing.Point(7, 30);
            this.gbxSearchMenu.Name = "gbxSearchMenu";
            this.gbxSearchMenu.Size = new System.Drawing.Size(1025, 80);
            this.gbxSearchMenu.TabIndex = 137;
            this.gbxSearchMenu.TabStop = false;
            // 
            // dtpTo
            // 
            this.dtpTo.CustomFormat = "yyyy-MM-dd";
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(617, 45);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(97, 21);
            this.dtpTo.TabIndex = 155;
            this.dtpTo.Value = new System.DateTime(2019, 12, 31, 16, 26, 0, 0);
            this.dtpTo.ValueChanged += new System.EventHandler(this.DtpTo_ValueChanged);
            this.dtpTo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DtpTo_KeyDown);
            // 
            // dtpFrom
            // 
            this.dtpFrom.CustomFormat = "yyyy-MM-dd";
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(489, 43);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(101, 21);
            this.dtpFrom.TabIndex = 154;
            this.dtpFrom.Value = new System.DateTime(2019, 1, 1, 16, 4, 0, 0);
            this.dtpFrom.ValueChanged += new System.EventHandler(this.DtpFrom_ValueChanged);
            this.dtpFrom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DtpFrom_KeyDown);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(596, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 26);
            this.label1.TabIndex = 153;
            this.label1.Text = "~";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(420, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 22);
            this.label3.TabIndex = 152;
            this.label3.Text = "결의기간";
            // 
            // cbb전표유형
            // 
            this.cbb전표유형.DisplayMember = "전표번호";
            this.cbb전표유형.Enabled = false;
            this.cbb전표유형.Font = new System.Drawing.Font("굴림", 10F);
            this.cbb전표유형.FormattingEnabled = true;
            this.cbb전표유형.Location = new System.Drawing.Point(353, 45);
            this.cbb전표유형.Name = "cbb전표유형";
            this.cbb전표유형.Size = new System.Drawing.Size(59, 21);
            this.cbb전표유형.TabIndex = 151;
            this.cbb전표유형.ValueMember = "전표번호";
            this.cbb전표유형.SelectedValueChanged += new System.EventHandler(this.Cbb전표유형_SelectedValueChanged);
            this.cbb전표유형.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cbb부서코드_KeyDown);
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label13.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(286, 48);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 22);
            this.label13.TabIndex = 150;
            this.label13.Text = "전표유형";
            // 
            // cbb전표구분
            // 
            this.cbb전표구분.Enabled = false;
            this.cbb전표구분.Font = new System.Drawing.Font("굴림", 10F);
            this.cbb전표구분.FormattingEnabled = true;
            this.cbb전표구분.Location = new System.Drawing.Point(215, 46);
            this.cbb전표구분.Name = "cbb전표구분";
            this.cbb전표구분.Size = new System.Drawing.Size(59, 21);
            this.cbb전표구분.TabIndex = 149;
            this.cbb전표구분.SelectedValueChanged += new System.EventHandler(this.Cbb전표구분_SelectedValueChanged);
            this.cbb전표구분.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cbb부서코드_KeyDown);
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label14.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(148, 49);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 22);
            this.label14.TabIndex = 148;
            this.label14.Text = "전표구분";
            // 
            // cbb전표상태
            // 
            this.cbb전표상태.DisplayMember = "전표번호";
            this.cbb전표상태.Enabled = false;
            this.cbb전표상태.Font = new System.Drawing.Font("굴림", 10F);
            this.cbb전표상태.FormattingEnabled = true;
            this.cbb전표상태.Location = new System.Drawing.Point(84, 45);
            this.cbb전표상태.Name = "cbb전표상태";
            this.cbb전표상태.Size = new System.Drawing.Size(59, 21);
            this.cbb전표상태.TabIndex = 147;
            this.cbb전표상태.ValueMember = "전표번호";
            this.cbb전표상태.SelectedValueChanged += new System.EventHandler(this.Cbb전표상태_SelectedValueChanged);
            this.cbb전표상태.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cbb부서코드_KeyDown);
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label15.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(17, 48);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 22);
            this.label15.TabIndex = 146;
            this.label15.Text = "전표상태";
            // 
            // txb사원명
            // 
            this.txb사원명.Enabled = false;
            this.txb사원명.Location = new System.Drawing.Point(632, 9);
            this.txb사원명.Name = "txb사원명";
            this.txb사원명.Size = new System.Drawing.Size(82, 21);
            this.txb사원명.TabIndex = 145;
            this.txb사원명.Text = "사원명";
            // 
            // cbb사원코드
            // 
            this.cbb사원코드.DataSource = this.사원등록BindingSource;
            this.cbb사원코드.DisplayMember = "사원코드";
            this.cbb사원코드.Font = new System.Drawing.Font("굴림", 10F);
            this.cbb사원코드.FormattingEnabled = true;
            this.cbb사원코드.Location = new System.Drawing.Point(547, 9);
            this.cbb사원코드.Name = "cbb사원코드";
            this.cbb사원코드.Size = new System.Drawing.Size(78, 21);
            this.cbb사원코드.TabIndex = 144;
            this.cbb사원코드.ValueMember = "사원코드";
            this.cbb사원코드.SelectedValueChanged += new System.EventHandler(this.Cbb사원코드_SelectedValueChanged);
            this.cbb사원코드.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cbb부서코드_KeyDown);
            // 
            // 사원등록BindingSource
            // 
            this.사원등록BindingSource.DataSource = typeof(ClassLibrary.사원등록);
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label16.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(488, 12);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 22);
            this.label16.TabIndex = 143;
            this.label16.Text = "작성자";
            // 
            // cbb부서코드
            // 
            this.cbb부서코드.DataSource = this.부서등록BindingSource;
            this.cbb부서코드.DisplayMember = "부서코드";
            this.cbb부서코드.Font = new System.Drawing.Font("굴림", 10F);
            this.cbb부서코드.FormattingEnabled = true;
            this.cbb부서코드.Location = new System.Drawing.Point(314, 9);
            this.cbb부서코드.Name = "cbb부서코드";
            this.cbb부서코드.Size = new System.Drawing.Size(88, 21);
            this.cbb부서코드.TabIndex = 142;
            this.cbb부서코드.ValueMember = "부서코드";
            this.cbb부서코드.SelectedValueChanged += new System.EventHandler(this.Cbb부서코드_SelectedValueChanged);
            this.cbb부서코드.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cbb부서코드_KeyDown);
            // 
            // 부서등록BindingSource
            // 
            this.부서등록BindingSource.DataSource = typeof(ClassLibrary.부서등록);
            // 
            // txb부서명
            // 
            this.txb부서명.Enabled = false;
            this.txb부서명.Location = new System.Drawing.Point(408, 9);
            this.txb부서명.Name = "txb부서명";
            this.txb부서명.Size = new System.Drawing.Size(69, 21);
            this.txb부서명.TabIndex = 141;
            this.txb부서명.Text = "부서명";
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label17.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label17.Location = new System.Drawing.Point(247, 13);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(79, 22);
            this.label17.TabIndex = 140;
            this.label17.Text = "결의부서";
            // 
            // txb회사명
            // 
            this.txb회사명.Enabled = false;
            this.txb회사명.Location = new System.Drawing.Point(172, 9);
            this.txb회사명.Name = "txb회사명";
            this.txb회사명.Size = new System.Drawing.Size(69, 21);
            this.txb회사명.TabIndex = 139;
            this.txb회사명.TabStop = false;
            this.txb회사명.Text = "회사명";
            // 
            // cbb회사코드
            // 
            this.cbb회사코드.DataSource = this.회사등록BindingSource;
            this.cbb회사코드.DisplayMember = "회사코드";
            this.cbb회사코드.Enabled = false;
            this.cbb회사코드.Font = new System.Drawing.Font("굴림", 10F);
            this.cbb회사코드.FormattingEnabled = true;
            this.cbb회사코드.Location = new System.Drawing.Point(85, 9);
            this.cbb회사코드.Name = "cbb회사코드";
            this.cbb회사코드.Size = new System.Drawing.Size(81, 21);
            this.cbb회사코드.TabIndex = 138;
            this.cbb회사코드.TabStop = false;
            this.cbb회사코드.ValueMember = "회사코드";
            // 
            // 회사등록BindingSource
            // 
            this.회사등록BindingSource.DataSource = typeof(ClassLibrary.회사등록);
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label18.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label18.Location = new System.Drawing.Point(17, 12);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(79, 22);
            this.label18.TabIndex = 137;
            this.label18.Text = "회계단위";
            // 
            // dgv전표리스트
            // 
            this.dgv전표리스트.AllowUserToAddRows = false;
            this.dgv전표리스트.AllowUserToDeleteRows = false;
            this.dgv전표리스트.AllowUserToResizeColumns = false;
            this.dgv전표리스트.AllowUserToResizeRows = false;
            this.dgv전표리스트.AutoGenerateColumns = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv전표리스트.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv전표리스트.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv전표리스트.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.순번DataGridViewTextBoxColumn,
            this.전표번호,
            this.입력날짜DataGridViewTextBoxColumn,
            this.구분DataGridViewTextBoxColumn,
            this.계정과목코드번호DataGridViewTextBoxColumn,
            this.계정과목명,
            this.거래처코드번호DataGridViewTextBoxColumn,
            this.거래처명,
            this.적요명DataGridViewTextBoxColumn,
            this.차변,
            this.대변});
            this.dgv전표리스트.DataSource = this.전표리스트BindingSource;
            this.dgv전표리스트.Location = new System.Drawing.Point(7, 115);
            this.dgv전표리스트.Name = "dgv전표리스트";
            this.dgv전표리스트.ReadOnly = true;
            this.dgv전표리스트.RowTemplate.Height = 23;
            this.dgv전표리스트.Size = new System.Drawing.Size(1025, 494);
            this.dgv전표리스트.TabIndex = 132;
            this.dgv전표리스트.TabStop = false;
            this.dgv전표리스트.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.Dgv전표리스트_RowPostPaint);
            // 
            // 순번DataGridViewTextBoxColumn
            // 
            this.순번DataGridViewTextBoxColumn.DataPropertyName = "순번";
            this.순번DataGridViewTextBoxColumn.HeaderText = "순번";
            this.순번DataGridViewTextBoxColumn.Name = "순번DataGridViewTextBoxColumn";
            this.순번DataGridViewTextBoxColumn.ReadOnly = true;
            this.순번DataGridViewTextBoxColumn.Width = 80;
            // 
            // 전표번호
            // 
            this.전표번호.DataPropertyName = "전표번호";
            this.전표번호.HeaderText = "전표번호";
            this.전표번호.Name = "전표번호";
            this.전표번호.ReadOnly = true;
            this.전표번호.Width = 80;
            // 
            // 입력날짜DataGridViewTextBoxColumn
            // 
            this.입력날짜DataGridViewTextBoxColumn.DataPropertyName = "입력날짜";
            this.입력날짜DataGridViewTextBoxColumn.HeaderText = "입력날짜";
            this.입력날짜DataGridViewTextBoxColumn.Name = "입력날짜DataGridViewTextBoxColumn";
            this.입력날짜DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 구분DataGridViewTextBoxColumn
            // 
            this.구분DataGridViewTextBoxColumn.DataPropertyName = "구분";
            this.구분DataGridViewTextBoxColumn.HeaderText = "구분";
            this.구분DataGridViewTextBoxColumn.Name = "구분DataGridViewTextBoxColumn";
            this.구분DataGridViewTextBoxColumn.ReadOnly = true;
            this.구분DataGridViewTextBoxColumn.Width = 70;
            // 
            // 계정과목코드번호DataGridViewTextBoxColumn
            // 
            this.계정과목코드번호DataGridViewTextBoxColumn.DataPropertyName = "계정과목코드번호";
            this.계정과목코드번호DataGridViewTextBoxColumn.HeaderText = "코드";
            this.계정과목코드번호DataGridViewTextBoxColumn.Name = "계정과목코드번호DataGridViewTextBoxColumn";
            this.계정과목코드번호DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 계정과목명
            // 
            this.계정과목명.DataPropertyName = "계정과목명";
            this.계정과목명.HeaderText = "계정과목명";
            this.계정과목명.Name = "계정과목명";
            this.계정과목명.ReadOnly = true;
            // 
            // 거래처코드번호DataGridViewTextBoxColumn
            // 
            this.거래처코드번호DataGridViewTextBoxColumn.DataPropertyName = "거래처코드번호";
            this.거래처코드번호DataGridViewTextBoxColumn.HeaderText = "코드";
            this.거래처코드번호DataGridViewTextBoxColumn.Name = "거래처코드번호DataGridViewTextBoxColumn";
            this.거래처코드번호DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 거래처명
            // 
            this.거래처명.DataPropertyName = "거래처명";
            this.거래처명.HeaderText = "거래처명";
            this.거래처명.Name = "거래처명";
            this.거래처명.ReadOnly = true;
            // 
            // 적요명DataGridViewTextBoxColumn
            // 
            this.적요명DataGridViewTextBoxColumn.DataPropertyName = "적요명";
            this.적요명DataGridViewTextBoxColumn.HeaderText = "적요";
            this.적요명DataGridViewTextBoxColumn.Name = "적요명DataGridViewTextBoxColumn";
            this.적요명DataGridViewTextBoxColumn.ReadOnly = true;
            this.적요명DataGridViewTextBoxColumn.Width = 150;
            // 
            // 차변
            // 
            this.차변.DataPropertyName = "차변";
            this.차변.HeaderText = "차변";
            this.차변.Name = "차변";
            this.차변.ReadOnly = true;
            // 
            // 대변
            // 
            this.대변.DataPropertyName = "대변";
            this.대변.HeaderText = "대변";
            this.대변.Name = "대변";
            this.대변.ReadOnly = true;
            // 
            // 전표리스트BindingSource
            // 
            this.전표리스트BindingSource.DataSource = typeof(ClassLibrary.전표리스트);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("굴림체", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(55, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 25);
            this.label8.TabIndex = 116;
            this.label8.Text = "전표출력";
            // 
            // btn전표양식
            // 
            this.btn전표양식.Location = new System.Drawing.Point(624, 1);
            this.btn전표양식.Name = "btn전표양식";
            this.btn전표양식.Size = new System.Drawing.Size(75, 23);
            this.btn전표양식.TabIndex = 115;
            this.btn전표양식.TabStop = false;
            this.btn전표양식.Text = "전표양식";
            this.btn전표양식.UseVisualStyleBackColor = true;
            this.btn전표양식.Visible = false;
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(542, 1);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(75, 23);
            this.btnSum.TabIndex = 114;
            this.btnSum.TabStop = false;
            this.btnSum.Text = "계정합계";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.BtnSum_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(703, 1);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 113;
            this.button8.TabStop = false;
            this.button8.Text = "정렬순서";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Visible = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(460, 1);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 112;
            this.btnSearch.TabStop = false;
            this.btnSearch.Text = "전표검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Visible = false;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Location = new System.Drawing.Point(7, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(1025, 1);
            this.label9.TabIndex = 111;
            // 
            // 전표출력
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "전표출력";
            this.Size = new System.Drawing.Size(1044, 645);
            this.Load += new System.EventHandler(this.전표출력_Load);
            this.groupBox1.ResumeLayout(false);
            this.gbxSearchMenu.ResumeLayout(false);
            this.gbxSearchMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.사원등록BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.부서등록BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.회사등록BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv전표리스트)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.전표리스트BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv전표리스트;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn전표양식;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gbxSearchMenu;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbb전표유형;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbb전표구분;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbb전표상태;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txb사원명;
        private System.Windows.Forms.ComboBox cbb사원코드;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbb부서코드;
        private System.Windows.Forms.TextBox txb부서명;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txb회사명;
        private System.Windows.Forms.ComboBox cbb회사코드;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.BindingSource 회사등록BindingSource;
        private System.Windows.Forms.BindingSource 부서등록BindingSource;
        private System.Windows.Forms.BindingSource 사원등록BindingSource;
        public System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.BindingSource 전표리스트BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn 순번DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 전표번호;
        private System.Windows.Forms.DataGridViewTextBoxColumn 입력날짜DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 구분DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 계정과목코드번호DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 계정과목명;
        private System.Windows.Forms.DataGridViewTextBoxColumn 거래처코드번호DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 거래처명;
        private System.Windows.Forms.DataGridViewTextBoxColumn 적요명DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 차변;
        private System.Windows.Forms.DataGridViewTextBoxColumn 대변;
    }
}
