namespace SMART_ERP_System.MenuUserControl
{
    partial class 일반거래처등록
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txb사업장전화번호 = new System.Windows.Forms.TextBox();
            this.txb사업장번지 = new System.Windows.Forms.TextBox();
            this.txb사업장주소 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp거래종료일 = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.dtp거래시작일 = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.txb종목 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txb업태 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txb대표자성명 = new System.Windows.Forms.TextBox();
            this.txb주민등록번호 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txb사업자등록번호 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.일반거래처등록bds = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txb거래처명 = new System.Windows.Forms.TextBox();
            this.cbb거래처코드 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.일반거래처코드DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.거래처코드번호 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.거래처명DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.구분DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.일반거래처등록bds)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1033, 651);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(408, 63);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(617, 575);
            this.tabControl1.TabIndex = 99;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.txb사업장전화번호);
            this.tabPage1.Controls.Add(this.txb사업장번지);
            this.tabPage1.Controls.Add(this.txb사업장주소);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dtp거래종료일);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.dtp거래시작일);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.txb종목);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.txb업태);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.txb대표자성명);
            this.tabPage1.Controls.Add(this.txb주민등록번호);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txb사업자등록번호);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(609, 549);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "기본등록사항";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(40, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 22);
            this.label7.TabIndex = 179;
            this.label7.Text = "사업장번지";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(11, 247);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 22);
            this.label10.TabIndex = 177;
            this.label10.Text = "사업장전화번호";
            // 
            // txb사업장전화번호
            // 
            this.txb사업장전화번호.Location = new System.Drawing.Point(126, 245);
            this.txb사업장전화번호.Name = "txb사업장전화번호";
            this.txb사업장전화번호.Size = new System.Drawing.Size(226, 21);
            this.txb사업장전화번호.TabIndex = 176;
            // 
            // txb사업장번지
            // 
            this.txb사업장번지.Location = new System.Drawing.Point(127, 219);
            this.txb사업장번지.Name = "txb사업장번지";
            this.txb사업장번지.Size = new System.Drawing.Size(364, 21);
            this.txb사업장번지.TabIndex = 175;
            // 
            // txb사업장주소
            // 
            this.txb사업장주소.Location = new System.Drawing.Point(127, 192);
            this.txb사업장주소.Name = "txb사업장주소";
            this.txb사업장주소.Size = new System.Drawing.Size(364, 21);
            this.txb사업장주소.TabIndex = 174;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(40, 194);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 22);
            this.label13.TabIndex = 173;
            this.label13.Text = "사업장주소";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(40, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 22);
            this.label1.TabIndex = 169;
            this.label1.Text = "대표자성명";
            // 
            // dtp거래종료일
            // 
            this.dtp거래종료일.CustomFormat = "yyyy-MM-dd";
            this.dtp거래종료일.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp거래종료일.Location = new System.Drawing.Point(124, 304);
            this.dtp거래종료일.Name = "dtp거래종료일";
            this.dtp거래종료일.Size = new System.Drawing.Size(226, 21);
            this.dtp거래종료일.TabIndex = 168;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label15.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(40, 306);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 22);
            this.label15.TabIndex = 167;
            this.label15.Text = "거래종료일";
            // 
            // dtp거래시작일
            // 
            this.dtp거래시작일.CustomFormat = "yyyy-MM-dd";
            this.dtp거래시작일.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp거래시작일.Location = new System.Drawing.Point(124, 277);
            this.dtp거래시작일.Name = "dtp거래시작일";
            this.dtp거래시작일.Size = new System.Drawing.Size(226, 21);
            this.dtp거래시작일.TabIndex = 166;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label14.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(40, 279);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 22);
            this.label14.TabIndex = 165;
            this.label14.Text = "거래시작일";
            // 
            // txb종목
            // 
            this.txb종목.Location = new System.Drawing.Point(128, 167);
            this.txb종목.Name = "txb종목";
            this.txb종목.Size = new System.Drawing.Size(224, 21);
            this.txb종목.TabIndex = 164;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(85, 169);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 22);
            this.label12.TabIndex = 163;
            this.label12.Text = "종목";
            // 
            // txb업태
            // 
            this.txb업태.Location = new System.Drawing.Point(128, 137);
            this.txb업태.Name = "txb업태";
            this.txb업태.Size = new System.Drawing.Size(224, 21);
            this.txb업태.TabIndex = 162;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(85, 139);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 22);
            this.label11.TabIndex = 161;
            this.label11.Text = "업태";
            // 
            // txb대표자성명
            // 
            this.txb대표자성명.Location = new System.Drawing.Point(127, 109);
            this.txb대표자성명.Name = "txb대표자성명";
            this.txb대표자성명.Size = new System.Drawing.Size(225, 21);
            this.txb대표자성명.TabIndex = 157;
            // 
            // txb주민등록번호
            // 
            this.txb주민등록번호.Location = new System.Drawing.Point(127, 79);
            this.txb주민등록번호.Name = "txb주민등록번호";
            this.txb주민등록번호.Size = new System.Drawing.Size(225, 21);
            this.txb주민등록번호.TabIndex = 156;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(27, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 22);
            this.label6.TabIndex = 155;
            this.label6.Text = "주민등록번호";
            // 
            // txb사업자등록번호
            // 
            this.txb사업자등록번호.Location = new System.Drawing.Point(127, 53);
            this.txb사업자등록번호.Name = "txb사업자등록번호";
            this.txb사업자등록번호.Size = new System.Drawing.Size(225, 21);
            this.txb사업자등록번호.TabIndex = 154;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(14, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 22);
            this.label4.TabIndex = 153;
            this.label4.Text = "사업자등록번호";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.일반거래처코드DataGridViewTextBoxColumn,
            this.거래처코드번호,
            this.거래처명DataGridViewTextBoxColumn,
            this.구분DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.일반거래처등록bds;
            this.dataGridView1.Location = new System.Drawing.Point(6, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(396, 577);
            this.dataGridView1.TabIndex = 98;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // 일반거래처등록bds
            // 
            this.일반거래처등록bds.DataSource = typeof(ClassLibrary.일반거래처등록);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.txb거래처명);
            this.groupBox2.Controls.Add(this.cbb거래처코드);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(7, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1018, 29);
            this.groupBox2.TabIndex = 88;
            this.groupBox2.TabStop = false;
            // 
            // txb거래처명
            // 
            this.txb거래처명.Location = new System.Drawing.Point(293, 4);
            this.txb거래처명.Name = "txb거래처명";
            this.txb거래처명.Size = new System.Drawing.Size(216, 21);
            this.txb거래처명.TabIndex = 112;
            // 
            // cbb거래처코드
            // 
            this.cbb거래처코드.Font = new System.Drawing.Font("굴림", 10F);
            this.cbb거래처코드.FormattingEnabled = true;
            this.cbb거래처코드.Location = new System.Drawing.Point(133, 4);
            this.cbb거래처코드.Name = "cbb거래처코드";
            this.cbb거래처코드.Size = new System.Drawing.Size(154, 21);
            this.cbb거래처코드.TabIndex = 109;
            this.cbb거래처코드.SelectedValueChanged += new System.EventHandler(this.Cbb거래처코드_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(75, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 22);
            this.label2.TabIndex = 108;
            this.label2.Text = "거래처";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("굴림체", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(55, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 25);
            this.label8.TabIndex = 97;
            this.label8.Text = "일반거래처등록";
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Location = new System.Drawing.Point(7, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(1018, 1);
            this.label9.TabIndex = 94;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(649, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 180;
            this.button1.Text = "등록";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn일반등록_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(730, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 181;
            this.button2.Text = "삭제";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btn일반삭체_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(811, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 182;
            this.button3.Text = "수정";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btn일반수정_Click);
            // 
            // 일반거래처코드DataGridViewTextBoxColumn
            // 
            this.일반거래처코드DataGridViewTextBoxColumn.DataPropertyName = "일반거래처코드";
            this.일반거래처코드DataGridViewTextBoxColumn.HeaderText = "코드";
            this.일반거래처코드DataGridViewTextBoxColumn.Name = "일반거래처코드DataGridViewTextBoxColumn";
            // 
            // 거래처코드번호
            // 
            this.거래처코드번호.DataPropertyName = "거래처코드번호";
            this.거래처코드번호.HeaderText = "거래처코드번호";
            this.거래처코드번호.Name = "거래처코드번호";
            // 
            // 거래처명DataGridViewTextBoxColumn
            // 
            this.거래처명DataGridViewTextBoxColumn.DataPropertyName = "거래처명";
            this.거래처명DataGridViewTextBoxColumn.HeaderText = "거래처명";
            this.거래처명DataGridViewTextBoxColumn.Name = "거래처명DataGridViewTextBoxColumn";
            // 
            // 구분DataGridViewTextBoxColumn
            // 
            this.구분DataGridViewTextBoxColumn.DataPropertyName = "구분";
            this.구분DataGridViewTextBoxColumn.HeaderText = "구분";
            this.구분DataGridViewTextBoxColumn.Name = "구분DataGridViewTextBoxColumn";
            // 
            // 일반거래처등록
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "일반거래처등록";
            this.Size = new System.Drawing.Size(1044, 645);
            this.Load += new System.EventHandler(this.일반거래처등록_Load);
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.일반거래처등록bds)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txb거래처명;
        private System.Windows.Forms.ComboBox cbb거래처코드;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp거래종료일;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtp거래시작일;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txb종목;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txb업태;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txb대표자성명;
        private System.Windows.Forms.TextBox txb주민등록번호;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txb사업자등록번호;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txb사업장전화번호;
        private System.Windows.Forms.TextBox txb사업장번지;
        private System.Windows.Forms.TextBox txb사업장주소;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.BindingSource 일반거래처등록bds;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 일반거래처코드DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 거래처코드번호;
        private System.Windows.Forms.DataGridViewTextBoxColumn 거래처명DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 구분DataGridViewTextBoxColumn;
    }
}
