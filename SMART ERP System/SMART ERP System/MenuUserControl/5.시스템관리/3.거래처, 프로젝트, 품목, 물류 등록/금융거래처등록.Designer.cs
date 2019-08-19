namespace SMART_ERP_System.MenuUserControl
{
    partial class 금융거래처등록
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
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txb금융예금주명 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txb금융예금명 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb금융기관코드 = new System.Windows.Forms.ComboBox();
            this.금융기관Bds = new System.Windows.Forms.BindingSource(this.components);
            this.label19 = new System.Windows.Forms.Label();
            this.cbb금융예금종류 = new System.Windows.Forms.ComboBox();
            this.예금종류Bds = new System.Windows.Forms.BindingSource(this.components);
            this.label18 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txb금융사업장전화번호1 = new System.Windows.Forms.TextBox();
            this.txb금융사업장번지 = new System.Windows.Forms.TextBox();
            this.txb금융사업장주소 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dtp금융거래종료일 = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.dtp금융계좌개설일 = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.txb금융사업자등록번호 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txb금융계좌개설점 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txb금융계좌번호 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.금융거래처등록bds = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.금융거래처코드DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.거래처코드번호 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.금융거래처명DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.구분DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.금융기관Bds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.예금종류Bds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.금융거래처등록bds)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1033, 651);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(543, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 192;
            this.button1.Text = "등록";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Btn등록_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(442, 29);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(583, 611);
            this.tabControl1.TabIndex = 99;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tabPage1.Controls.Add(this.txb금융예금주명);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txb금융예금명);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cbb금융기관코드);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.cbb금융예금종류);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.txb금융사업장전화번호1);
            this.tabPage1.Controls.Add(this.txb금융사업장번지);
            this.tabPage1.Controls.Add(this.txb금융사업장주소);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.dtp금융거래종료일);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.dtp금융계좌개설일);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.txb금융사업자등록번호);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txb금융계좌개설점);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txb금융계좌번호);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(575, 585);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "기본등록사항";
            // 
            // txb금융예금주명
            // 
            this.txb금융예금주명.Location = new System.Drawing.Point(156, 327);
            this.txb금융예금주명.Name = "txb금융예금주명";
            this.txb금융예금주명.Size = new System.Drawing.Size(225, 21);
            this.txb금융예금주명.TabIndex = 191;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(99, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 22);
            this.label2.TabIndex = 190;
            this.label2.Text = "예금주";
            // 
            // txb금융예금명
            // 
            this.txb금융예금명.Location = new System.Drawing.Point(156, 295);
            this.txb금융예금명.Name = "txb금융예금명";
            this.txb금융예금명.Size = new System.Drawing.Size(225, 21);
            this.txb금융예금명.TabIndex = 189;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(99, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 22);
            this.label1.TabIndex = 188;
            this.label1.Text = "예금명";
            // 
            // cbb금융기관코드
            // 
            this.cbb금융기관코드.DataSource = this.금융기관Bds;
            this.cbb금융기관코드.DisplayMember = "금융기관명";
            this.cbb금융기관코드.Font = new System.Drawing.Font("굴림", 10F);
            this.cbb금융기관코드.FormattingEnabled = true;
            this.cbb금융기관코드.Location = new System.Drawing.Point(156, 231);
            this.cbb금융기관코드.Name = "cbb금융기관코드";
            this.cbb금융기관코드.Size = new System.Drawing.Size(226, 21);
            this.cbb금융기관코드.TabIndex = 187;
            this.cbb금융기관코드.ValueMember = "금융기관코드";
            // 
            // 금융기관Bds
            // 
            this.금융기관Bds.DataSource = typeof(ClassLibrary.금융기관);
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label19.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label19.Location = new System.Drawing.Point(73, 235);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(99, 22);
            this.label19.TabIndex = 186;
            this.label19.Text = "금융기관명";
            // 
            // cbb금융예금종류
            // 
            this.cbb금융예금종류.DataSource = this.예금종류Bds;
            this.cbb금융예금종류.DisplayMember = "예금내역명";
            this.cbb금융예금종류.Font = new System.Drawing.Font("굴림", 10F);
            this.cbb금융예금종류.FormattingEnabled = true;
            this.cbb금융예금종류.Location = new System.Drawing.Point(156, 263);
            this.cbb금융예금종류.Name = "cbb금융예금종류";
            this.cbb금융예금종류.Size = new System.Drawing.Size(226, 21);
            this.cbb금융예금종류.TabIndex = 185;
            this.cbb금융예금종류.ValueMember = "예금종류코드";
            // 
            // 예금종류Bds
            // 
            this.예금종류Bds.DataSource = typeof(ClassLibrary.예금종류);
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label18.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label18.Location = new System.Drawing.Point(86, 266);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(78, 22);
            this.label18.TabIndex = 184;
            this.label18.Text = "예금종류";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(70, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 22);
            this.label7.TabIndex = 179;
            this.label7.Text = "사업장번지";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(41, 202);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 22);
            this.label10.TabIndex = 177;
            this.label10.Text = "사업장전화번호";
            // 
            // txb금융사업장전화번호1
            // 
            this.txb금융사업장전화번호1.Location = new System.Drawing.Point(156, 200);
            this.txb금융사업장전화번호1.Name = "txb금융사업장전화번호1";
            this.txb금융사업장전화번호1.Size = new System.Drawing.Size(225, 21);
            this.txb금융사업장전화번호1.TabIndex = 176;
            // 
            // txb금융사업장번지
            // 
            this.txb금융사업장번지.Location = new System.Drawing.Point(157, 170);
            this.txb금융사업장번지.Name = "txb금융사업장번지";
            this.txb금융사업장번지.Size = new System.Drawing.Size(364, 21);
            this.txb금융사업장번지.TabIndex = 175;
            // 
            // txb금융사업장주소
            // 
            this.txb금융사업장주소.Location = new System.Drawing.Point(157, 140);
            this.txb금융사업장주소.Name = "txb금융사업장주소";
            this.txb금융사업장주소.Size = new System.Drawing.Size(364, 21);
            this.txb금융사업장주소.TabIndex = 174;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(70, 142);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 22);
            this.label13.TabIndex = 173;
            this.label13.Text = "사업장주소";
            // 
            // dtp금융거래종료일
            // 
            this.dtp금융거래종료일.CustomFormat = "yyyy-MM-dd";
            this.dtp금융거래종료일.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp금융거래종료일.Location = new System.Drawing.Point(156, 465);
            this.dtp금융거래종료일.Name = "dtp금융거래종료일";
            this.dtp금융거래종료일.Size = new System.Drawing.Size(226, 21);
            this.dtp금융거래종료일.TabIndex = 168;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label15.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(72, 467);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 22);
            this.label15.TabIndex = 167;
            this.label15.Text = "거래종료일";
            // 
            // dtp금융계좌개설일
            // 
            this.dtp금융계좌개설일.CustomFormat = "yyyy-MM-dd";
            this.dtp금융계좌개설일.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp금융계좌개설일.Location = new System.Drawing.Point(156, 427);
            this.dtp금융계좌개설일.Name = "dtp금융계좌개설일";
            this.dtp금융계좌개설일.Size = new System.Drawing.Size(226, 21);
            this.dtp금융계좌개설일.TabIndex = 166;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label14.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(72, 429);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 22);
            this.label14.TabIndex = 165;
            this.label14.Text = "계좌개설일";
            // 
            // txb금융사업자등록번호
            // 
            this.txb금융사업자등록번호.Location = new System.Drawing.Point(157, 110);
            this.txb금융사업자등록번호.Name = "txb금융사업자등록번호";
            this.txb금융사업자등록번호.Size = new System.Drawing.Size(225, 21);
            this.txb금융사업자등록번호.TabIndex = 156;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(41, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 22);
            this.label6.TabIndex = 155;
            this.label6.Text = "사업자등록번호";
            // 
            // txb금융계좌개설점
            // 
            this.txb금융계좌개설점.Location = new System.Drawing.Point(157, 82);
            this.txb금융계좌개설점.Name = "txb금융계좌개설점";
            this.txb금융계좌개설점.Size = new System.Drawing.Size(225, 21);
            this.txb금융계좌개설점.TabIndex = 154;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(70, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 22);
            this.label4.TabIndex = 153;
            this.label4.Text = "계좌개설점";
            // 
            // txb금융계좌번호
            // 
            this.txb금융계좌번호.Location = new System.Drawing.Point(157, 53);
            this.txb금융계좌번호.Name = "txb금융계좌번호";
            this.txb금융계좌번호.Size = new System.Drawing.Size(225, 21);
            this.txb금융계좌번호.TabIndex = 152;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(84, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 22);
            this.label5.TabIndex = 151;
            this.label5.Text = "계좌번호";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.금융거래처코드DataGridViewTextBoxColumn,
            this.거래처코드번호,
            this.금융거래처명DataGridViewTextBoxColumn,
            this.구분DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.금융거래처등록bds;
            this.dataGridView1.Location = new System.Drawing.Point(6, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(430, 611);
            this.dataGridView1.TabIndex = 98;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // 금융거래처등록bds
            // 
            this.금융거래처등록bds.DataSource = typeof(ClassLibrary.금융거래처등록);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("굴림체", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(55, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 25);
            this.label8.TabIndex = 97;
            this.label8.Text = "금융거래처등록";
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Location = new System.Drawing.Point(7, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(1018, 1);
            this.label9.TabIndex = 94;
            // 
            // 금융거래처코드DataGridViewTextBoxColumn
            // 
            this.금융거래처코드DataGridViewTextBoxColumn.DataPropertyName = "금융거래처코드";
            this.금융거래처코드DataGridViewTextBoxColumn.HeaderText = "코드";
            this.금융거래처코드DataGridViewTextBoxColumn.Name = "금융거래처코드DataGridViewTextBoxColumn";
            // 
            // 거래처코드번호
            // 
            this.거래처코드번호.DataPropertyName = "거래처코드번호";
            this.거래처코드번호.HeaderText = "거래처코드번호";
            this.거래처코드번호.Name = "거래처코드번호";
            // 
            // 금융거래처명DataGridViewTextBoxColumn
            // 
            this.금융거래처명DataGridViewTextBoxColumn.DataPropertyName = "금융거래처명";
            this.금융거래처명DataGridViewTextBoxColumn.HeaderText = "금융거래처명";
            this.금융거래처명DataGridViewTextBoxColumn.Name = "금융거래처명DataGridViewTextBoxColumn";
            // 
            // 구분DataGridViewTextBoxColumn
            // 
            this.구분DataGridViewTextBoxColumn.DataPropertyName = "구분";
            this.구분DataGridViewTextBoxColumn.HeaderText = "구분";
            this.구분DataGridViewTextBoxColumn.Name = "구분DataGridViewTextBoxColumn";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(624, -1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 193;
            this.button2.Text = "삭제";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btn삭제_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(705, -1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 194;
            this.button3.Text = "수정";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btn수정_Click);
            // 
            // 금융거래처등록
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "금융거래처등록";
            this.Size = new System.Drawing.Size(1044, 645);
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.금융기관Bds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.예금종류Bds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.금융거래처등록bds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox cbb금융기관코드;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cbb금융예금종류;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txb금융사업장전화번호1;
        private System.Windows.Forms.TextBox txb금융사업장번지;
        private System.Windows.Forms.TextBox txb금융사업장주소;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtp금융계좌개설일;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txb금융사업자등록번호;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txb금융계좌개설점;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb금융계좌번호;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txb금융예금주명;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb금융예금명;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource 금융거래처등록bds;
        private System.Windows.Forms.BindingSource 금융기관Bds;
        private System.Windows.Forms.BindingSource 예금종류Bds;
        private System.Windows.Forms.DateTimePicker dtp금융거래종료일;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 금융거래처코드DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 거래처코드번호;
        private System.Windows.Forms.DataGridViewTextBoxColumn 금융거래처명DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 구분DataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}
