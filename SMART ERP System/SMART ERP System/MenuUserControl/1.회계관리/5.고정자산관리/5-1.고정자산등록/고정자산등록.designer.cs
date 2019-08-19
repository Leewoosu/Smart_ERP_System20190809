namespace SMART_ERP_System.MenuUserControl
{
    partial class 고정자산등록
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
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txb내용연수 = new System.Windows.Forms.TextBox();
            this.txb경비구분 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.dtp수정일자 = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.dtp입력일자 = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.txb일반상각비 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txb취득수 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txb당기말상각누계액 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbb상각방법 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txb전기말상각누계액 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txb취득원가 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txb비고 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txb모델명 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txb제작사명 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txb규격 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txb구입처명 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txb고정자산계정명 = new System.Windows.Forms.TextBox();
            this.cbb고정자산계정코드 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.고정자산dgv = new System.Windows.Forms.DataGridView();
            this.txb회사명 = new System.Windows.Forms.TextBox();
            this.cbb회사코드 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnStatementForm = new System.Windows.Forms.Button();
            this.btnAccountTotal = new System.Windows.Forms.Button();
            this.btnSortOrder = new System.Windows.Forms.Button();
            this.btnStatementSearch = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.고정자산코드DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.고정자산명DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.계정과목코드번호DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.취득일DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.처리여부DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.고정자산bds = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.고정자산dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.고정자산bds)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.tabControl2);
            this.groupBox1.Controls.Add(this.txb고정자산계정명);
            this.groupBox1.Controls.Add(this.cbb고정자산계정코드);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.고정자산dgv);
            this.groupBox1.Controls.Add(this.txb회사명);
            this.groupBox1.Controls.Add(this.cbb회사코드);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnStatementForm);
            this.groupBox1.Controls.Add(this.btnAccountTotal);
            this.groupBox1.Controls.Add(this.btnSortOrder);
            this.groupBox1.Controls.Add(this.btnStatementSearch);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.richTextBox2);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1041, 651);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Location = new System.Drawing.Point(555, 105);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(478, 512);
            this.tabControl2.TabIndex = 95;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txb내용연수);
            this.tabPage2.Controls.Add(this.txb경비구분);
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Controls.Add(this.dtp수정일자);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.dtp입력일자);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.txb일반상각비);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txb취득수);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.txb당기말상각누계액);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.cbb상각방법);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txb전기말상각누계액);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.txb취득원가);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(470, 486);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "주요등록사항";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txb내용연수
            // 
            this.txb내용연수.Location = new System.Drawing.Point(313, 170);
            this.txb내용연수.Name = "txb내용연수";
            this.txb내용연수.Size = new System.Drawing.Size(70, 21);
            this.txb내용연수.TabIndex = 115;
            // 
            // txb경비구분
            // 
            this.txb경비구분.Location = new System.Drawing.Point(158, 208);
            this.txb경비구분.Name = "txb경비구분";
            this.txb경비구분.Size = new System.Drawing.Size(70, 21);
            this.txb경비구분.TabIndex = 110;
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.label20.Location = new System.Drawing.Point(98, 211);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(130, 22);
            this.label20.TabIndex = 109;
            this.label20.Text = "경비구분";
            // 
            // dtp수정일자
            // 
            this.dtp수정일자.CustomFormat = "yyyy-MM-dd";
            this.dtp수정일자.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp수정일자.Location = new System.Drawing.Point(158, 399);
            this.dtp수정일자.Name = "dtp수정일자";
            this.dtp수정일자.Size = new System.Drawing.Size(173, 21);
            this.dtp수정일자.TabIndex = 108;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(98, 402);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(130, 18);
            this.label13.TabIndex = 107;
            this.label13.Text = "수정일자";
            // 
            // dtp입력일자
            // 
            this.dtp입력일자.CustomFormat = "yyyy-MM-dd";
            this.dtp입력일자.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp입력일자.Location = new System.Drawing.Point(158, 360);
            this.dtp입력일자.Name = "dtp입력일자";
            this.dtp입력일자.Size = new System.Drawing.Size(173, 21);
            this.dtp입력일자.TabIndex = 106;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(98, 363);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 18);
            this.label11.TabIndex = 105;
            this.label11.Text = "입력일자";
            // 
            // txb일반상각비
            // 
            this.txb일반상각비.Location = new System.Drawing.Point(158, 251);
            this.txb일반상각비.Name = "txb일반상각비";
            this.txb일반상각비.Size = new System.Drawing.Size(225, 21);
            this.txb일반상각비.TabIndex = 104;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(87, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 22);
            this.label7.TabIndex = 103;
            this.label7.Text = "일반상각비";
            // 
            // txb취득수
            // 
            this.txb취득수.Location = new System.Drawing.Point(313, 208);
            this.txb취득수.Name = "txb취득수";
            this.txb취득수.Size = new System.Drawing.Size(70, 21);
            this.txb취득수.TabIndex = 102;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(248, 211);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 22);
            this.label10.TabIndex = 98;
            this.label10.Text = "취득수량";
            // 
            // txb당기말상각누계액
            // 
            this.txb당기말상각누계액.Location = new System.Drawing.Point(158, 293);
            this.txb당기말상각누계액.Name = "txb당기말상각누계액";
            this.txb당기말상각누계액.Size = new System.Drawing.Size(225, 21);
            this.txb당기말상각누계액.TabIndex = 97;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(47, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 22);
            this.label6.TabIndex = 96;
            this.label6.Text = "당기말상각누계액";
            // 
            // cbb상각방법
            // 
            this.cbb상각방법.DisplayMember = "상각방법코드번호";
            this.cbb상각방법.Font = new System.Drawing.Font("굴림", 10F);
            this.cbb상각방법.FormattingEnabled = true;
            this.cbb상각방법.Items.AddRange(new object[] {
            "정액법",
            "정률법"});
            this.cbb상각방법.Location = new System.Drawing.Point(158, 168);
            this.cbb상각방법.Name = "cbb상각방법";
            this.cbb상각방법.Size = new System.Drawing.Size(70, 21);
            this.cbb상각방법.TabIndex = 94;
            this.cbb상각방법.ValueMember = "상각방법코드번호";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(248, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 22);
            this.label5.TabIndex = 68;
            this.label5.Text = "내용연수";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(98, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 22);
            this.label4.TabIndex = 66;
            this.label4.Text = "상각방법";
            // 
            // txb전기말상각누계액
            // 
            this.txb전기말상각누계액.Location = new System.Drawing.Point(158, 123);
            this.txb전기말상각누계액.Name = "txb전기말상각누계액";
            this.txb전기말상각누계액.Size = new System.Drawing.Size(225, 21);
            this.txb전기말상각누계액.TabIndex = 65;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(47, 127);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(130, 22);
            this.label12.TabIndex = 64;
            this.label12.Text = "전기말상각누계액";
            // 
            // txb취득원가
            // 
            this.txb취득원가.Location = new System.Drawing.Point(158, 78);
            this.txb취득원가.Name = "txb취득원가";
            this.txb취득원가.Size = new System.Drawing.Size(225, 21);
            this.txb취득원가.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(98, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 22);
            this.label3.TabIndex = 49;
            this.label3.Text = "취득원가";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txb비고);
            this.tabPage3.Controls.Add(this.label19);
            this.tabPage3.Controls.Add(this.txb모델명);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.txb제작사명);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.txb규격);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.txb구입처명);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(470, 486);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "추가등록사항";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txb비고
            // 
            this.txb비고.Location = new System.Drawing.Point(146, 301);
            this.txb비고.Name = "txb비고";
            this.txb비고.Size = new System.Drawing.Size(225, 21);
            this.txb비고.TabIndex = 64;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.label19.Location = new System.Drawing.Point(108, 305);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(79, 22);
            this.label19.TabIndex = 63;
            this.label19.Text = "비고";
            // 
            // txb모델명
            // 
            this.txb모델명.Location = new System.Drawing.Point(148, 250);
            this.txb모델명.Name = "txb모델명";
            this.txb모델명.Size = new System.Drawing.Size(225, 21);
            this.txb모델명.TabIndex = 59;
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.label17.Location = new System.Drawing.Point(110, 254);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(79, 22);
            this.label17.TabIndex = 58;
            this.label17.Text = "모델";
            // 
            // txb제작사명
            // 
            this.txb제작사명.Location = new System.Drawing.Point(148, 145);
            this.txb제작사명.Name = "txb제작사명";
            this.txb제작사명.Size = new System.Drawing.Size(225, 21);
            this.txb제작사명.TabIndex = 57;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(97, 149);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 22);
            this.label16.TabIndex = 56;
            this.label16.Text = "제작사";
            // 
            // txb규격
            // 
            this.txb규격.Location = new System.Drawing.Point(148, 196);
            this.txb규격.Name = "txb규격";
            this.txb규격.Size = new System.Drawing.Size(225, 21);
            this.txb규격.TabIndex = 55;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(110, 200);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 22);
            this.label15.TabIndex = 54;
            this.label15.Text = "규격";
            // 
            // txb구입처명
            // 
            this.txb구입처명.Location = new System.Drawing.Point(148, 96);
            this.txb구입처명.Name = "txb구입처명";
            this.txb구입처명.Size = new System.Drawing.Size(225, 21);
            this.txb구입처명.TabIndex = 53;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(97, 100);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 22);
            this.label14.TabIndex = 52;
            this.label14.Text = "구입처";
            // 
            // txb고정자산계정명
            // 
            this.txb고정자산계정명.Location = new System.Drawing.Point(434, 76);
            this.txb고정자산계정명.Name = "txb고정자산계정명";
            this.txb고정자산계정명.Size = new System.Drawing.Size(82, 21);
            this.txb고정자산계정명.TabIndex = 94;
            this.txb고정자산계정명.Text = "계정명";
            // 
            // cbb고정자산계정코드
            // 
            this.cbb고정자산계정코드.Font = new System.Drawing.Font("굴림", 10F);
            this.cbb고정자산계정코드.FormattingEnabled = true;
            this.cbb고정자산계정코드.Location = new System.Drawing.Point(346, 76);
            this.cbb고정자산계정코드.Name = "cbb고정자산계정코드";
            this.cbb고정자산계정코드.Size = new System.Drawing.Size(80, 21);
            this.cbb고정자산계정코드.TabIndex = 93;
            this.cbb고정자산계정코드.Text = "계정코드";
            this.cbb고정자산계정코드.SelectedValueChanged += new System.EventHandler(this.Cbb고정자산계정코드_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(272, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 22);
            this.label1.TabIndex = 92;
            this.label1.Text = "자산유형";
            // 
            // 고정자산dgv
            // 
            this.고정자산dgv.AutoGenerateColumns = false;
            this.고정자산dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.고정자산dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.고정자산코드DataGridViewTextBoxColumn,
            this.고정자산명DataGridViewTextBoxColumn,
            this.계정과목코드번호DataGridViewTextBoxColumn,
            this.취득일DataGridViewTextBoxColumn,
            this.처리여부DataGridViewTextBoxColumn});
            this.고정자산dgv.DataSource = this.고정자산bds;
            this.고정자산dgv.Location = new System.Drawing.Point(13, 105);
            this.고정자산dgv.Name = "고정자산dgv";
            this.고정자산dgv.RowTemplate.Height = 23;
            this.고정자산dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.고정자산dgv.Size = new System.Drawing.Size(540, 512);
            this.고정자산dgv.TabIndex = 91;
            this.고정자산dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.고정자산dgv_CellContentClick);
            // 
            // txb회사명
            // 
            this.txb회사명.Location = new System.Drawing.Point(172, 77);
            this.txb회사명.Name = "txb회사명";
            this.txb회사명.Size = new System.Drawing.Size(82, 21);
            this.txb회사명.TabIndex = 90;
            this.txb회사명.Text = "회사명";
            // 
            // cbb회사코드
            // 
            this.cbb회사코드.Font = new System.Drawing.Font("굴림", 10F);
            this.cbb회사코드.FormattingEnabled = true;
            this.cbb회사코드.Location = new System.Drawing.Point(86, 77);
            this.cbb회사코드.Name = "cbb회사코드";
            this.cbb회사코드.Size = new System.Drawing.Size(80, 21);
            this.cbb회사코드.TabIndex = 89;
            this.cbb회사코드.Text = "회사코드";
            this.cbb회사코드.SelectedValueChanged += new System.EventHandler(this.Cbb회사코드_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(18, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 22);
            this.label2.TabIndex = 88;
            this.label2.Text = "회계단위";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("굴림체", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(57, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 27);
            this.label8.TabIndex = 87;
            this.label8.Text = "고정자산등록";
            // 
            // btnStatementForm
            // 
            this.btnStatementForm.Location = new System.Drawing.Point(649, 38);
            this.btnStatementForm.Name = "btnStatementForm";
            this.btnStatementForm.Size = new System.Drawing.Size(75, 23);
            this.btnStatementForm.TabIndex = 86;
            this.btnStatementForm.Text = "전표양식";
            this.btnStatementForm.UseVisualStyleBackColor = true;
            // 
            // btnAccountTotal
            // 
            this.btnAccountTotal.Location = new System.Drawing.Point(730, 38);
            this.btnAccountTotal.Name = "btnAccountTotal";
            this.btnAccountTotal.Size = new System.Drawing.Size(75, 23);
            this.btnAccountTotal.TabIndex = 85;
            this.btnAccountTotal.Text = "계정합계";
            this.btnAccountTotal.UseVisualStyleBackColor = true;
            // 
            // btnSortOrder
            // 
            this.btnSortOrder.Location = new System.Drawing.Point(811, 38);
            this.btnSortOrder.Name = "btnSortOrder";
            this.btnSortOrder.Size = new System.Drawing.Size(75, 23);
            this.btnSortOrder.TabIndex = 84;
            this.btnSortOrder.Text = "정렬순서";
            this.btnSortOrder.UseVisualStyleBackColor = true;
            // 
            // btnStatementSearch
            // 
            this.btnStatementSearch.Location = new System.Drawing.Point(568, 38);
            this.btnStatementSearch.Name = "btnStatementSearch";
            this.btnStatementSearch.Size = new System.Drawing.Size(75, 23);
            this.btnStatementSearch.TabIndex = 83;
            this.btnStatementSearch.Text = "전표검색";
            this.btnStatementSearch.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Location = new System.Drawing.Point(9, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(1025, 1);
            this.label9.TabIndex = 82;
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox2.Location = new System.Drawing.Point(13, 70);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(1021, 32);
            this.richTextBox2.TabIndex = 81;
            this.richTextBox2.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(730, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 96;
            this.button1.Text = "등록";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.등록btn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(811, 76);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 97;
            this.button2.Text = "삭제";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.삭제btn_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(892, 77);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 98;
            this.button3.Text = "수정";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.수정btn_Click);
            // 
            // 고정자산코드DataGridViewTextBoxColumn
            // 
            this.고정자산코드DataGridViewTextBoxColumn.DataPropertyName = "고정자산코드";
            this.고정자산코드DataGridViewTextBoxColumn.HeaderText = "고정자산코드";
            this.고정자산코드DataGridViewTextBoxColumn.Name = "고정자산코드DataGridViewTextBoxColumn";
            // 
            // 고정자산명DataGridViewTextBoxColumn
            // 
            this.고정자산명DataGridViewTextBoxColumn.DataPropertyName = "고정자산명";
            this.고정자산명DataGridViewTextBoxColumn.HeaderText = "고정자산명";
            this.고정자산명DataGridViewTextBoxColumn.Name = "고정자산명DataGridViewTextBoxColumn";
            // 
            // 계정과목코드번호DataGridViewTextBoxColumn
            // 
            this.계정과목코드번호DataGridViewTextBoxColumn.DataPropertyName = "계정과목코드번호";
            this.계정과목코드번호DataGridViewTextBoxColumn.HeaderText = "계정과목코드번호";
            this.계정과목코드번호DataGridViewTextBoxColumn.Name = "계정과목코드번호DataGridViewTextBoxColumn";
            // 
            // 취득일DataGridViewTextBoxColumn
            // 
            this.취득일DataGridViewTextBoxColumn.DataPropertyName = "취득일";
            this.취득일DataGridViewTextBoxColumn.HeaderText = "취득일";
            this.취득일DataGridViewTextBoxColumn.Name = "취득일DataGridViewTextBoxColumn";
            // 
            // 처리여부DataGridViewTextBoxColumn
            // 
            this.처리여부DataGridViewTextBoxColumn.DataPropertyName = "처리여부";
            this.처리여부DataGridViewTextBoxColumn.HeaderText = "처리여부";
            this.처리여부DataGridViewTextBoxColumn.Name = "처리여부DataGridViewTextBoxColumn";
            // 
            // 고정자산bds
            // 
            this.고정자산bds.DataSource = typeof(ClassLibrary.고정자산);
            // 
            // 고정자산등록
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "고정자산등록";
            this.Size = new System.Drawing.Size(1044, 645);
            this.Load += new System.EventHandler(this.고정자산등록_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.고정자산dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.고정자산bds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DateTimePicker dtp수정일자;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtp입력일자;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txb일반상각비;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txb취득수;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txb당기말상각누계액;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbb상각방법;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb전기말상각누계액;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txb취득원가;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txb비고;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txb모델명;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txb제작사명;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txb규격;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txb구입처명;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txb고정자산계정명;
        private System.Windows.Forms.ComboBox cbb고정자산계정코드;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView 고정자산dgv;
        private System.Windows.Forms.TextBox txb회사명;
        private System.Windows.Forms.ComboBox cbb회사코드;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnStatementForm;
        private System.Windows.Forms.Button btnAccountTotal;
        private System.Windows.Forms.Button btnSortOrder;
        private System.Windows.Forms.Button btnStatementSearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.TextBox txb경비구분;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.BindingSource 고정자산bds;
        private System.Windows.Forms.TextBox txb내용연수;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn 고정자산코드DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 고정자산명DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 계정과목코드번호DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 취득일DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 처리여부DataGridViewTextBoxColumn;
    }
}
