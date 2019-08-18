namespace SMART_ERP_System.MenuUserControl
{
    partial class 계정과목등록
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
            this.button4 = new System.Windows.Forms.Button();
            this.btn세목추가 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.계정과목그룹BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.계정과목BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gbx세부항목 = new System.Windows.Forms.GroupBox();
            this.cbb필수입력여부 = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txb출력계정명 = new System.Windows.Forms.TextBox();
            this.txb관련계정명 = new System.Windows.Forms.TextBox();
            this.txb계정명 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txb그룹코드 = new System.Windows.Forms.TextBox();
            this.txb관련계정코드 = new System.Windows.Forms.TextBox();
            this.txb계정코드 = new System.Windows.Forms.TextBox();
            this.cbb계정구분 = new System.Windows.Forms.ComboBox();
            this.cbb입력구분 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbb차대구분 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txb그룹명 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txb양식 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.treeView = new System.Windows.Forms.TreeView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txb계정과목설명 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dgv계정과목세부 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.계정과목그룹BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.계정과목BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gbx세부항목.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv계정과목세부)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.btn세목추가);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(-1, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1042, 651);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(462, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(137, 23);
            this.button4.TabIndex = 100;
            this.button4.Text = "양식선택";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            // 
            // btn세목추가
            // 
            this.btn세목추가.Location = new System.Drawing.Point(605, 2);
            this.btn세목추가.Name = "btn세목추가";
            this.btn세목추가.Size = new System.Drawing.Size(137, 23);
            this.btn세목추가.TabIndex = 99;
            this.btn세목추가.Text = "세목추가";
            this.btn세목추가.UseVisualStyleBackColor = true;
            this.btn세목추가.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(748, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 23);
            this.button2.TabIndex = 98;
            this.button2.Text = "일괄설정";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("굴림체", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(57, 1);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 24);
            this.label8.TabIndex = 86;
            this.label8.Text = "계정과목등록";
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Location = new System.Drawing.Point(7, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(1018, 1);
            this.label9.TabIndex = 84;
            // 
            // 계정과목그룹BindingSource
            // 
            this.계정과목그룹BindingSource.DataSource = typeof(ClassLibrary.계정과목그룹);
            // 
            // 계정과목BindingSource
            // 
            this.계정과목BindingSource.DataSource = typeof(ClassLibrary.계정과목);
            // 
            // splitContainer1
            // 
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(6, 43);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgv계정과목세부);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox4);
            this.splitContainer1.Panel2.Controls.Add(this.gbx세부항목);
            this.splitContainer1.Panel2.Leave += new System.EventHandler(this.SplitContainer1_Panel2_Leave);
            this.splitContainer1.Size = new System.Drawing.Size(1018, 551);
            this.splitContainer1.SplitterDistance = 339;
            this.splitContainer1.TabIndex = 106;
            // 
            // gbx세부항목
            // 
            this.gbx세부항목.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbx세부항목.Controls.Add(this.cbb필수입력여부);
            this.gbx세부항목.Controls.Add(this.label14);
            this.gbx세부항목.Controls.Add(this.txb출력계정명);
            this.gbx세부항목.Controls.Add(this.txb관련계정명);
            this.gbx세부항목.Controls.Add(this.txb계정명);
            this.gbx세부항목.Controls.Add(this.label12);
            this.gbx세부항목.Controls.Add(this.label7);
            this.gbx세부항목.Controls.Add(this.txb그룹코드);
            this.gbx세부항목.Controls.Add(this.txb관련계정코드);
            this.gbx세부항목.Controls.Add(this.txb계정코드);
            this.gbx세부항목.Controls.Add(this.cbb계정구분);
            this.gbx세부항목.Controls.Add(this.cbb입력구분);
            this.gbx세부항목.Controls.Add(this.label10);
            this.gbx세부항목.Controls.Add(this.label6);
            this.gbx세부항목.Controls.Add(this.cbb차대구분);
            this.gbx세부항목.Controls.Add(this.label5);
            this.gbx세부항목.Controls.Add(this.label4);
            this.gbx세부항목.Controls.Add(this.label1);
            this.gbx세부항목.Controls.Add(this.txb그룹명);
            this.gbx세부항목.Controls.Add(this.label3);
            this.gbx세부항목.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbx세부항목.Location = new System.Drawing.Point(0, 0);
            this.gbx세부항목.Name = "gbx세부항목";
            this.gbx세부항목.Size = new System.Drawing.Size(675, 254);
            this.gbx세부항목.TabIndex = 103;
            this.gbx세부항목.TabStop = false;
            // 
            // cbb필수입력여부
            // 
            this.cbb필수입력여부.Font = new System.Drawing.Font("굴림", 10F);
            this.cbb필수입력여부.FormattingEnabled = true;
            this.cbb필수입력여부.Items.AddRange(new object[] {
            "차/대변 필수",
            "차/대변 선택",
            "차변 필수"});
            this.cbb필수입력여부.Location = new System.Drawing.Point(103, 219);
            this.cbb필수입력여부.Name = "cbb필수입력여부";
            this.cbb필수입력여부.Size = new System.Drawing.Size(114, 21);
            this.cbb필수입력여부.TabIndex = 140;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(12, 222);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 22);
            this.label14.TabIndex = 139;
            this.label14.Text = "필수입력여부";
            // 
            // txb출력계정명
            // 
            this.txb출력계정명.Location = new System.Drawing.Point(103, 109);
            this.txb출력계정명.Name = "txb출력계정명";
            this.txb출력계정명.Size = new System.Drawing.Size(287, 21);
            this.txb출력계정명.TabIndex = 135;
            // 
            // txb관련계정명
            // 
            this.txb관련계정명.Location = new System.Drawing.Point(230, 166);
            this.txb관련계정명.Name = "txb관련계정명";
            this.txb관련계정명.Size = new System.Drawing.Size(160, 21);
            this.txb관련계정명.TabIndex = 123;
            // 
            // txb계정명
            // 
            this.txb계정명.Location = new System.Drawing.Point(103, 82);
            this.txb계정명.Name = "txb계정명";
            this.txb계정명.Size = new System.Drawing.Size(287, 21);
            this.txb계정명.TabIndex = 116;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(25, 115);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 22);
            this.label12.TabIndex = 137;
            this.label12.Text = "출력계정명";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(25, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 22);
            this.label7.TabIndex = 136;
            this.label7.Text = "계정과목명";
            // 
            // txb그룹코드
            // 
            this.txb그룹코드.Enabled = false;
            this.txb그룹코드.Location = new System.Drawing.Point(103, 22);
            this.txb그룹코드.Name = "txb그룹코드";
            this.txb그룹코드.Size = new System.Drawing.Size(114, 21);
            this.txb그룹코드.TabIndex = 134;
            this.txb그룹코드.TextChanged += new System.EventHandler(this.Txb그룹코드_TextChanged);
            // 
            // txb관련계정코드
            // 
            this.txb관련계정코드.Location = new System.Drawing.Point(103, 164);
            this.txb관련계정코드.Name = "txb관련계정코드";
            this.txb관련계정코드.Size = new System.Drawing.Size(114, 21);
            this.txb관련계정코드.TabIndex = 133;
            this.txb관련계정코드.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txb관련계정코드_KeyDown);
            // 
            // txb계정코드
            // 
            this.txb계정코드.Enabled = false;
            this.txb계정코드.Location = new System.Drawing.Point(103, 53);
            this.txb계정코드.Name = "txb계정코드";
            this.txb계정코드.Size = new System.Drawing.Size(287, 21);
            this.txb계정코드.TabIndex = 132;
            // 
            // cbb계정구분
            // 
            this.cbb계정구분.Font = new System.Drawing.Font("굴림", 10F);
            this.cbb계정구분.FormattingEnabled = true;
            this.cbb계정구분.Location = new System.Drawing.Point(103, 137);
            this.cbb계정구분.Name = "cbb계정구분";
            this.cbb계정구분.Size = new System.Drawing.Size(114, 21);
            this.cbb계정구분.TabIndex = 131;
            // 
            // cbb입력구분
            // 
            this.cbb입력구분.Font = new System.Drawing.Font("굴림", 10F);
            this.cbb입력구분.FormattingEnabled = true;
            this.cbb입력구분.Items.AddRange(new object[] {
            "입력가능",
            "입력불가"});
            this.cbb입력구분.Location = new System.Drawing.Point(103, 192);
            this.cbb입력구분.Name = "cbb입력구분";
            this.cbb입력구분.Size = new System.Drawing.Size(114, 21);
            this.cbb입력구분.TabIndex = 130;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(38, 195);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 22);
            this.label10.TabIndex = 129;
            this.label10.Text = "입력구분";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(39, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 22);
            this.label6.TabIndex = 121;
            this.label6.Text = "관련계정";
            // 
            // cbb차대구분
            // 
            this.cbb차대구분.Font = new System.Drawing.Font("굴림", 10F);
            this.cbb차대구분.FormattingEnabled = true;
            this.cbb차대구분.Items.AddRange(new object[] {
            "차변",
            "대변"});
            this.cbb차대구분.Location = new System.Drawing.Point(315, 137);
            this.cbb차대구분.Name = "cbb차대구분";
            this.cbb차대구분.Size = new System.Drawing.Size(75, 21);
            this.cbb차대구분.TabIndex = 120;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(251, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 22);
            this.label5.TabIndex = 119;
            this.label5.Text = "차대구분";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(38, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 22);
            this.label4.TabIndex = 117;
            this.label4.Text = "계정구분";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(39, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 22);
            this.label1.TabIndex = 113;
            this.label1.Text = "계정코드";
            // 
            // txb그룹명
            // 
            this.txb그룹명.Enabled = false;
            this.txb그룹명.Location = new System.Drawing.Point(230, 22);
            this.txb그룹명.Name = "txb그룹명";
            this.txb그룹명.Size = new System.Drawing.Size(160, 21);
            this.txb그룹명.TabIndex = 111;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(39, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 22);
            this.label3.TabIndex = 110;
            this.label3.Text = "그룹코드";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.txb양식);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(339, 32);
            this.groupBox2.TabIndex = 97;
            this.groupBox2.TabStop = false;
            // 
            // txb양식
            // 
            this.txb양식.Location = new System.Drawing.Point(78, 4);
            this.txb양식.Name = "txb양식";
            this.txb양식.Size = new System.Drawing.Size(148, 21);
            this.txb양식.TabIndex = 98;
            this.txb양식.Text = "2007 NEW 회계기준적용";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 22);
            this.label2.TabIndex = 96;
            this.label2.Text = "선택양식";
            // 
            // treeView
            // 
            this.treeView.Dock = System.Windows.Forms.DockStyle.Top;
            this.treeView.Location = new System.Drawing.Point(0, 32);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(339, 516);
            this.treeView.TabIndex = 102;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeView_AfterSelect);
            this.treeView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TreeView_KeyDown);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox4.Controls.Add(this.txb계정과목설명);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(0, 254);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(675, 132);
            this.groupBox4.TabIndex = 104;
            this.groupBox4.TabStop = false;
            // 
            // txb계정과목설명
            // 
            this.txb계정과목설명.Location = new System.Drawing.Point(24, 34);
            this.txb계정과목설명.Multiline = true;
            this.txb계정과목설명.Name = "txb계정과목설명";
            this.txb계정과목설명.Size = new System.Drawing.Size(628, 82);
            this.txb계정과목설명.TabIndex = 119;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(22, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 22);
            this.label11.TabIndex = 118;
            this.label11.Text = "계정과목설명";
            // 
            // dgv계정과목세부
            // 
            this.dgv계정과목세부.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv계정과목세부.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv계정과목세부.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgv계정과목세부.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgv계정과목세부.Location = new System.Drawing.Point(0, 386);
            this.dgv계정과목세부.Name = "dgv계정과목세부";
            this.dgv계정과목세부.RowTemplate.Height = 23;
            this.dgv계정과목세부.Size = new System.Drawing.Size(675, 162);
            this.dgv계정과목세부.TabIndex = 105;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "NO";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "코드";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "관리항목명";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "입력필수";
            this.Column4.Name = "Column4";
            // 
            // 계정과목등록
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.groupBox1);
            this.Name = "계정과목등록";
            this.Size = new System.Drawing.Size(1044, 645);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.계정과목그룹BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.계정과목BindingSource)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gbx세부항목.ResumeLayout(false);
            this.gbx세부항목.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv계정과목세부)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn세목추가;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource 계정과목그룹BindingSource;
        private System.Windows.Forms.BindingSource 계정과목BindingSource;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txb양식;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv계정과목세부;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txb계정과목설명;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox gbx세부항목;
        private System.Windows.Forms.ComboBox cbb필수입력여부;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txb출력계정명;
        private System.Windows.Forms.TextBox txb관련계정명;
        private System.Windows.Forms.TextBox txb계정명;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txb그룹코드;
        private System.Windows.Forms.TextBox txb관련계정코드;
        private System.Windows.Forms.TextBox txb계정코드;
        private System.Windows.Forms.ComboBox cbb계정구분;
        private System.Windows.Forms.ComboBox cbb입력구분;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbb차대구분;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb그룹명;
        private System.Windows.Forms.Label label3;
    }
}
