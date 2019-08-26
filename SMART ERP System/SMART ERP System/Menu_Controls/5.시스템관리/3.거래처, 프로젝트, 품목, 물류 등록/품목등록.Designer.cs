namespace SMART_ERP_System.MenuUserControl
{
    partial class 품목등록
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn등록 = new System.Windows.Forms.Button();
            this.btn조회 = new System.Windows.Forms.Button();
            this.btn변경 = new System.Windows.Forms.Button();
            this.btn삭제 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbb사원코드 = new System.Windows.Forms.ComboBox();
            this.사원등록BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbb부서코드 = new System.Windows.Forms.ComboBox();
            this.부서등록BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txb사원명 = new System.Windows.Forms.TextBox();
            this.txb부서명 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbbSearch검사여부 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv제품 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txb외경 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txb층 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.cbb검사여부 = new System.Windows.Forms.ComboBox();
            this.txb재고량 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txb품목군 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txb실제원가 = new System.Windows.Forms.TextBox();
            this.txb일별생산량 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txb리드타임 = new System.Windows.Forms.TextBox();
            this.txbLOT수량 = new System.Windows.Forms.TextBox();
            this.txb제품명 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txb표준원가 = new System.Windows.Forms.TextBox();
            this.txb안전재고량 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txb제품번호 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbb품목군 = new System.Windows.Forms.ComboBox();
            this.제품BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.사원등록BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.부서등록BindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv제품)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.제품BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(0, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1018, 1);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림체", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(51, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "품목등록";
            // 
            // btn등록
            // 
            this.btn등록.Location = new System.Drawing.Point(781, 1);
            this.btn등록.Name = "btn등록";
            this.btn등록.Size = new System.Drawing.Size(75, 23);
            this.btn등록.TabIndex = 2;
            this.btn등록.Text = "등록";
            this.btn등록.UseVisualStyleBackColor = true;
            this.btn등록.Click += new System.EventHandler(this.btn등록_Click);
            // 
            // btn조회
            // 
            this.btn조회.Location = new System.Drawing.Point(700, 1);
            this.btn조회.Name = "btn조회";
            this.btn조회.Size = new System.Drawing.Size(75, 23);
            this.btn조회.TabIndex = 3;
            this.btn조회.Text = "조회";
            this.btn조회.UseVisualStyleBackColor = true;
            this.btn조회.Click += new System.EventHandler(this.btn조회_Click);
            // 
            // btn변경
            // 
            this.btn변경.Location = new System.Drawing.Point(862, 1);
            this.btn변경.Name = "btn변경";
            this.btn변경.Size = new System.Drawing.Size(75, 23);
            this.btn변경.TabIndex = 4;
            this.btn변경.Text = "변경";
            this.btn변경.UseVisualStyleBackColor = true;
            this.btn변경.Click += new System.EventHandler(this.btn변경_Click);
            // 
            // btn삭제
            // 
            this.btn삭제.Location = new System.Drawing.Point(943, 1);
            this.btn삭제.Name = "btn삭제";
            this.btn삭제.Size = new System.Drawing.Size(75, 23);
            this.btn삭제.TabIndex = 5;
            this.btn삭제.Text = "삭제";
            this.btn삭제.UseVisualStyleBackColor = true;
            this.btn삭제.Click += new System.EventHandler(this.btn삭제_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.cbb품목군);
            this.groupBox1.Controls.Add(this.cbb사원코드);
            this.groupBox1.Controls.Add(this.cbb부서코드);
            this.groupBox1.Controls.Add(this.txb사원명);
            this.groupBox1.Controls.Add(this.txb부서명);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cbbSearch검사여부);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(6, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1012, 96);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // cbb사원코드
            // 
            this.cbb사원코드.DataSource = this.사원등록BindingSource;
            this.cbb사원코드.FormattingEnabled = true;
            this.cbb사원코드.Location = new System.Drawing.Point(371, 24);
            this.cbb사원코드.Name = "cbb사원코드";
            this.cbb사원코드.Size = new System.Drawing.Size(65, 20);
            this.cbb사원코드.TabIndex = 83;
            this.cbb사원코드.SelectionChangeCommitted += new System.EventHandler(this.Cbb사원코드_SelectionChangeCommitted);
            // 
            // 사원등록BindingSource
            // 
            this.사원등록BindingSource.DataSource = typeof(ClassLibrary.사원등록);
            // 
            // cbb부서코드
            // 
            this.cbb부서코드.DataSource = this.부서등록BindingSource;
            this.cbb부서코드.FormattingEnabled = true;
            this.cbb부서코드.Location = new System.Drawing.Point(79, 21);
            this.cbb부서코드.Name = "cbb부서코드";
            this.cbb부서코드.Size = new System.Drawing.Size(65, 20);
            this.cbb부서코드.TabIndex = 82;
            this.cbb부서코드.SelectedValueChanged += new System.EventHandler(this.Cbb부서코드_SelectedValueChanged);
            // 
            // 부서등록BindingSource
            // 
            this.부서등록BindingSource.DataSource = typeof(ClassLibrary.부서등록);
            // 
            // txb사원명
            // 
            this.txb사원명.Location = new System.Drawing.Point(442, 24);
            this.txb사원명.Name = "txb사원명";
            this.txb사원명.Size = new System.Drawing.Size(108, 21);
            this.txb사원명.TabIndex = 81;
            // 
            // txb부서명
            // 
            this.txb부서명.Location = new System.Drawing.Point(150, 21);
            this.txb부서명.Name = "txb부서명";
            this.txb부서명.Size = new System.Drawing.Size(108, 21);
            this.txb부서명.TabIndex = 80;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(328, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 14);
            this.label9.TabIndex = 79;
            this.label9.Text = "사원";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(38, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 14);
            this.label10.TabIndex = 78;
            this.label10.Text = "부서";
            // 
            // cbbSearch검사여부
            // 
            this.cbbSearch검사여부.FormattingEnabled = true;
            this.cbbSearch검사여부.Location = new System.Drawing.Point(372, 63);
            this.cbbSearch검사여부.Name = "cbbSearch검사여부";
            this.cbbSearch검사여부.Size = new System.Drawing.Size(150, 20);
            this.cbbSearch검사여부.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(299, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 14);
            this.label4.TabIndex = 1;
            this.label4.Text = "검사여부";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(19, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 14);
            this.label3.TabIndex = 0;
            this.label3.Text = "품목군";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv제품);
            this.panel1.Location = new System.Drawing.Point(6, 138);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(397, 495);
            this.panel1.TabIndex = 7;
            // 
            // dgv제품
            // 
            this.dgv제품.AllowUserToAddRows = false;
            this.dgv제품.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv제품.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv제품.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgv제품.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv제품.Location = new System.Drawing.Point(0, 0);
            this.dgv제품.Name = "dgv제품";
            this.dgv제품.RowTemplate.Height = 23;
            this.dgv제품.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv제품.Size = new System.Drawing.Size(397, 495);
            this.dgv제품.TabIndex = 0;
            this.dgv제품.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv제품_CellDoubleClick);
            this.dgv제품.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv제품_CellEndEdit);
            this.dgv제품.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Dgv제품_KeyDown);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "제품번호";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "제품이름";
            this.Column2.Name = "Column2";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txb외경);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txb층);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.cbb검사여부);
            this.panel2.Controls.Add(this.txb재고량);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txb품목군);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.txb실제원가);
            this.panel2.Controls.Add(this.txb일별생산량);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.txb리드타임);
            this.panel2.Controls.Add(this.txbLOT수량);
            this.panel2.Controls.Add(this.txb제품명);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.txb표준원가);
            this.panel2.Controls.Add(this.txb안전재고량);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txb제품번호);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(430, 138);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(598, 495);
            this.panel2.TabIndex = 8;
            // 
            // txb외경
            // 
            this.txb외경.Location = new System.Drawing.Point(373, 310);
            this.txb외경.Name = "txb외경";
            this.txb외경.Size = new System.Drawing.Size(150, 21);
            this.txb외경.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(304, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 12);
            this.label7.TabIndex = 38;
            this.label7.Text = "외경";
            // 
            // txb층
            // 
            this.txb층.Location = new System.Drawing.Point(140, 307);
            this.txb층.Name = "txb층";
            this.txb층.Size = new System.Drawing.Size(150, 21);
            this.txb층.TabIndex = 37;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.label20.Location = new System.Drawing.Point(68, 310);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(18, 12);
            this.label20.TabIndex = 36;
            this.label20.Text = "층";
            // 
            // cbb검사여부
            // 
            this.cbb검사여부.FormattingEnabled = true;
            this.cbb검사여부.Location = new System.Drawing.Point(140, 137);
            this.cbb검사여부.Name = "cbb검사여부";
            this.cbb검사여부.Size = new System.Drawing.Size(150, 20);
            this.cbb검사여부.TabIndex = 7;
            // 
            // txb재고량
            // 
            this.txb재고량.Location = new System.Drawing.Point(138, 356);
            this.txb재고량.Name = "txb재고량";
            this.txb재고량.Size = new System.Drawing.Size(150, 21);
            this.txb재고량.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(69, 359);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 12);
            this.label5.TabIndex = 34;
            this.label5.Text = "재고량";
            // 
            // txb품목군
            // 
            this.txb품목군.Location = new System.Drawing.Point(140, 77);
            this.txb품목군.Name = "txb품목군";
            this.txb품목군.Size = new System.Drawing.Size(150, 21);
            this.txb품목군.TabIndex = 33;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.label18.Location = new System.Drawing.Point(68, 80);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(44, 12);
            this.label18.TabIndex = 32;
            this.label18.Text = "품목군";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.label19.Location = new System.Drawing.Point(68, 260);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(57, 12);
            this.label19.TabIndex = 30;
            this.label19.Text = "표준원가";
            // 
            // txb실제원가
            // 
            this.txb실제원가.Location = new System.Drawing.Point(373, 257);
            this.txb실제원가.Name = "txb실제원가";
            this.txb실제원가.Size = new System.Drawing.Size(150, 21);
            this.txb실제원가.TabIndex = 28;
            // 
            // txb일별생산량
            // 
            this.txb일별생산량.Location = new System.Drawing.Point(373, 197);
            this.txb일별생산량.Name = "txb일별생산량";
            this.txb일별생산량.Size = new System.Drawing.Size(150, 21);
            this.txb일별생산량.TabIndex = 27;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(304, 260);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 12);
            this.label16.TabIndex = 25;
            this.label16.Text = "실제원가";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.label17.Location = new System.Drawing.Point(304, 200);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(70, 12);
            this.label17.TabIndex = 24;
            this.label17.Text = "일별생산량";
            // 
            // txb리드타임
            // 
            this.txb리드타임.Location = new System.Drawing.Point(373, 137);
            this.txb리드타임.Name = "txb리드타임";
            this.txb리드타임.Size = new System.Drawing.Size(150, 21);
            this.txb리드타임.TabIndex = 23;
            // 
            // txbLOT수량
            // 
            this.txbLOT수량.Location = new System.Drawing.Point(373, 77);
            this.txbLOT수량.Name = "txbLOT수량";
            this.txbLOT수량.Size = new System.Drawing.Size(150, 21);
            this.txbLOT수량.TabIndex = 22;
            // 
            // txb제품명
            // 
            this.txb제품명.Location = new System.Drawing.Point(373, 19);
            this.txb제품명.Name = "txb제품명";
            this.txb제품명.ReadOnly = true;
            this.txb제품명.Size = new System.Drawing.Size(150, 21);
            this.txb제품명.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(304, 140);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 12);
            this.label12.TabIndex = 20;
            this.label12.Text = "리드타임";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(304, 80);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 12);
            this.label13.TabIndex = 19;
            this.label13.Text = "LOT수량";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(304, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 12);
            this.label14.TabIndex = 18;
            this.label14.Text = "제품명";
            // 
            // txb표준원가
            // 
            this.txb표준원가.Location = new System.Drawing.Point(140, 257);
            this.txb표준원가.Name = "txb표준원가";
            this.txb표준원가.Size = new System.Drawing.Size(150, 21);
            this.txb표준원가.TabIndex = 16;
            // 
            // txb안전재고량
            // 
            this.txb안전재고량.Location = new System.Drawing.Point(140, 197);
            this.txb안전재고량.Name = "txb안전재고량";
            this.txb안전재고량.Size = new System.Drawing.Size(150, 21);
            this.txb안전재고량.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(68, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 12);
            this.label11.TabIndex = 12;
            this.label11.Text = "검사여부";
            // 
            // txb제품번호
            // 
            this.txb제품번호.Location = new System.Drawing.Point(140, 17);
            this.txb제품번호.Name = "txb제품번호";
            this.txb제품번호.ReadOnly = true;
            this.txb제품번호.Size = new System.Drawing.Size(150, 21);
            this.txb제품번호.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(68, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "안전재고량";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(68, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 12);
            this.label8.TabIndex = 6;
            this.label8.Text = "제품번호";
            // 
            // cbb품목군
            // 
            this.cbb품목군.DataSource = this.제품BindingSource;
            this.cbb품목군.DisplayMember = "품목군";
            this.cbb품목군.FormattingEnabled = true;
            this.cbb품목군.Location = new System.Drawing.Point(79, 60);
            this.cbb품목군.Name = "cbb품목군";
            this.cbb품목군.Size = new System.Drawing.Size(179, 20);
            this.cbb품목군.TabIndex = 84;
            this.cbb품목군.ValueMember = "제품번호";
            // 
            // 제품BindingSource
            // 
            this.제품BindingSource.DataSource = typeof(ClassLibrary.제품);
            // 
            // 품목등록
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn삭제);
            this.Controls.Add(this.btn변경);
            this.Controls.Add(this.btn조회);
            this.Controls.Add(this.btn등록);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "품목등록";
            this.Size = new System.Drawing.Size(1044, 645);
            this.Load += new System.EventHandler(this.품목등록_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.사원등록BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.부서등록BindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv제품)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.제품BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn등록;
        private System.Windows.Forms.Button btn조회;
        private System.Windows.Forms.Button btn변경;
        private System.Windows.Forms.Button btn삭제;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv제품;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txb품목군;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txb실제원가;
        private System.Windows.Forms.TextBox txb일별생산량;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txb리드타임;
        private System.Windows.Forms.TextBox txbLOT수량;
        private System.Windows.Forms.TextBox txb제품명;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txb안전재고량;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txb제품번호;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbbSearch검사여부;
        private System.Windows.Forms.ComboBox cbb검사여부;
        private System.Windows.Forms.TextBox txb재고량;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txb표준원가;
        private System.Windows.Forms.TextBox txb외경;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txb층;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.ComboBox cbb사원코드;
        private System.Windows.Forms.ComboBox cbb부서코드;
        private System.Windows.Forms.TextBox txb사원명;
        private System.Windows.Forms.TextBox txb부서명;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.BindingSource 사원등록BindingSource;
        private System.Windows.Forms.BindingSource 부서등록BindingSource;
        private System.Windows.Forms.ComboBox cbb품목군;
        private System.Windows.Forms.BindingSource 제품BindingSource;
    }
}
