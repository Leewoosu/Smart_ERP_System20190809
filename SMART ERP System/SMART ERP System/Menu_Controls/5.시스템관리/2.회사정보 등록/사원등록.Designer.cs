namespace SMART_ERP_System.MenuUserControl
{
    partial class 사원등록
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn등록 = new System.Windows.Forms.Button();
            this.btn삭제 = new System.Windows.Forms.Button();
            this.btn변경 = new System.Windows.Forms.Button();
            this.btn조회 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.dtp퇴사일 = new System.Windows.Forms.DateTimePicker();
            this.dtp입사일 = new System.Windows.Forms.DateTimePicker();
            this.txb사원명 = new System.Windows.Forms.TextBox();
            this.txb사원코드 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txb암호 = new System.Windows.Forms.TextBox();
            this.txb비상연락망 = new System.Windows.Forms.TextBox();
            this.txb조회권한 = new System.Windows.Forms.TextBox();
            this.txb사용자여부 = new System.Windows.Forms.TextBox();
            this.txb부서코드 = new System.Windows.Forms.TextBox();
            this.txb영문이름 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv사원 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txb사원 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txb부서 = new System.Windows.Forms.TextBox();
            this.cbb부서코드 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv사원)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn등록);
            this.groupBox1.Controls.Add(this.btn삭제);
            this.groupBox1.Controls.Add(this.btn변경);
            this.groupBox1.Controls.Add(this.btn조회);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.dgv사원);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1033, 651);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btn등록
            // 
            this.btn등록.Location = new System.Drawing.Point(792, -1);
            this.btn등록.Name = "btn등록";
            this.btn등록.Size = new System.Drawing.Size(75, 23);
            this.btn등록.TabIndex = 103;
            this.btn등록.Text = "등록";
            this.btn등록.UseVisualStyleBackColor = true;
            this.btn등록.Click += new System.EventHandler(this.Btn등록_Click);
            // 
            // btn삭제
            // 
            this.btn삭제.Location = new System.Drawing.Point(951, -1);
            this.btn삭제.Name = "btn삭제";
            this.btn삭제.Size = new System.Drawing.Size(75, 23);
            this.btn삭제.TabIndex = 102;
            this.btn삭제.Text = "삭제";
            this.btn삭제.UseVisualStyleBackColor = true;
            this.btn삭제.Click += new System.EventHandler(this.Btn삭제_Click);
            // 
            // btn변경
            // 
            this.btn변경.Location = new System.Drawing.Point(871, -1);
            this.btn변경.Name = "btn변경";
            this.btn변경.Size = new System.Drawing.Size(75, 23);
            this.btn변경.TabIndex = 101;
            this.btn변경.Text = "변경";
            this.btn변경.UseVisualStyleBackColor = true;
            this.btn변경.Click += new System.EventHandler(this.Btn변경_Click);
            // 
            // btn조회
            // 
            this.btn조회.Location = new System.Drawing.Point(711, 0);
            this.btn조회.Name = "btn조회";
            this.btn조회.Size = new System.Drawing.Size(75, 23);
            this.btn조회.TabIndex = 100;
            this.btn조회.Text = "조회";
            this.btn조회.UseVisualStyleBackColor = true;
            this.btn조회.Click += new System.EventHandler(this.Btn조회_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.dtp퇴사일);
            this.panel1.Controls.Add(this.dtp입사일);
            this.panel1.Controls.Add(this.txb사원명);
            this.panel1.Controls.Add(this.txb사원코드);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.txb암호);
            this.panel1.Controls.Add(this.txb비상연락망);
            this.panel1.Controls.Add(this.txb조회권한);
            this.panel1.Controls.Add(this.txb사용자여부);
            this.panel1.Controls.Add(this.txb부서코드);
            this.panel1.Controls.Add(this.txb영문이름);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(424, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 548);
            this.panel1.TabIndex = 99;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(106, 289);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 22;
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.CheckBox2_CheckedChanged);
            // 
            // dtp퇴사일
            // 
            this.dtp퇴사일.Enabled = false;
            this.dtp퇴사일.Location = new System.Drawing.Point(127, 283);
            this.dtp퇴사일.Name = "dtp퇴사일";
            this.dtp퇴사일.Size = new System.Drawing.Size(165, 21);
            this.dtp퇴사일.TabIndex = 21;
            this.dtp퇴사일.Value = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            // 
            // dtp입사일
            // 
            this.dtp입사일.Location = new System.Drawing.Point(127, 236);
            this.dtp입사일.Name = "dtp입사일";
            this.dtp입사일.Size = new System.Drawing.Size(165, 21);
            this.dtp입사일.TabIndex = 20;
            // 
            // txb사원명
            // 
            this.txb사원명.Location = new System.Drawing.Point(127, 86);
            this.txb사원명.Name = "txb사원명";
            this.txb사원명.ReadOnly = true;
            this.txb사원명.Size = new System.Drawing.Size(165, 21);
            this.txb사원명.TabIndex = 19;
            // 
            // txb사원코드
            // 
            this.txb사원코드.Location = new System.Drawing.Point(127, 39);
            this.txb사원코드.Name = "txb사원코드";
            this.txb사원코드.ReadOnly = true;
            this.txb사원코드.Size = new System.Drawing.Size(165, 21);
            this.txb사원코드.TabIndex = 18;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(52, 89);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 12);
            this.label13.TabIndex = 17;
            this.label13.Text = "사원명";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(52, 42);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 12);
            this.label14.TabIndex = 16;
            this.label14.Text = "사원코드";
            // 
            // txb암호
            // 
            this.txb암호.Location = new System.Drawing.Point(126, 487);
            this.txb암호.Name = "txb암호";
            this.txb암호.Size = new System.Drawing.Size(165, 21);
            this.txb암호.TabIndex = 15;
            // 
            // txb비상연락망
            // 
            this.txb비상연락망.Location = new System.Drawing.Point(127, 439);
            this.txb비상연락망.Name = "txb비상연락망";
            this.txb비상연락망.Size = new System.Drawing.Size(165, 21);
            this.txb비상연락망.TabIndex = 14;
            // 
            // txb조회권한
            // 
            this.txb조회권한.Location = new System.Drawing.Point(127, 391);
            this.txb조회권한.Name = "txb조회권한";
            this.txb조회권한.Size = new System.Drawing.Size(165, 21);
            this.txb조회권한.TabIndex = 13;
            // 
            // txb사용자여부
            // 
            this.txb사용자여부.Location = new System.Drawing.Point(127, 338);
            this.txb사용자여부.Name = "txb사용자여부";
            this.txb사용자여부.Size = new System.Drawing.Size(165, 21);
            this.txb사용자여부.TabIndex = 12;
            // 
            // txb부서코드
            // 
            this.txb부서코드.Location = new System.Drawing.Point(127, 188);
            this.txb부서코드.Name = "txb부서코드";
            this.txb부서코드.Size = new System.Drawing.Size(165, 21);
            this.txb부서코드.TabIndex = 9;
            // 
            // txb영문이름
            // 
            this.txb영문이름.Location = new System.Drawing.Point(127, 141);
            this.txb영문이름.Name = "txb영문이름";
            this.txb영문이름.Size = new System.Drawing.Size(165, 21);
            this.txb영문이름.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(52, 490);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 12);
            this.label11.TabIndex = 7;
            this.label11.Text = "암호";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(52, 191);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 12);
            this.label10.TabIndex = 6;
            this.label10.Text = "부서코드";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(52, 341);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 12);
            this.label7.TabIndex = 5;
            this.label7.Text = "사용자여부";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(52, 391);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "조회권한";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(52, 442);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "비상연락망";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(52, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "입사일";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(52, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "퇴사일";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(52, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "영문이름";
            // 
            // dgv사원
            // 
            this.dgv사원.AllowUserToAddRows = false;
            this.dgv사원.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv사원.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv사원.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgv사원.Location = new System.Drawing.Point(7, 66);
            this.dgv사원.Name = "dgv사원";
            this.dgv사원.RowTemplate.Height = 23;
            this.dgv사원.Size = new System.Drawing.Size(410, 547);
            this.dgv사원.TabIndex = 98;
            this.dgv사원.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv사원_CellDoubleClick);
            this.dgv사원.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv사원_CellEndEdit);
            this.dgv사원.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Dgv사원_KeyDown);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "사원코드";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "사원명";
            this.Column2.Name = "Column2";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.txb사원);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txb부서);
            this.groupBox2.Controls.Add(this.cbb부서코드);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(7, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1020, 32);
            this.groupBox2.TabIndex = 88;
            this.groupBox2.TabStop = false;
            // 
            // txb사원
            // 
            this.txb사원.Location = new System.Drawing.Point(493, 5);
            this.txb사원.Name = "txb사원";
            this.txb사원.Size = new System.Drawing.Size(137, 21);
            this.txb사원.TabIndex = 114;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.checkBox1.Location = new System.Drawing.Point(636, 9);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(76, 16);
            this.checkBox1.TabIndex = 113;
            this.checkBox1.Text = "사용자만";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label12.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(405, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(123, 22);
            this.label12.TabIndex = 111;
            this.label12.Text = "사원명검색";
            // 
            // txb부서
            // 
            this.txb부서.Location = new System.Drawing.Point(215, 7);
            this.txb부서.Name = "txb부서";
            this.txb부서.Size = new System.Drawing.Size(137, 21);
            this.txb부서.TabIndex = 110;
            // 
            // cbb부서코드
            // 
            this.cbb부서코드.Font = new System.Drawing.Font("굴림", 10F);
            this.cbb부서코드.FormattingEnabled = true;
            this.cbb부서코드.Location = new System.Drawing.Point(102, 7);
            this.cbb부서코드.Name = "cbb부서코드";
            this.cbb부서코드.Size = new System.Drawing.Size(107, 21);
            this.cbb부서코드.TabIndex = 109;
            this.cbb부서코드.SelectedValueChanged += new System.EventHandler(this.Cbb부서코드_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(63, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 22);
            this.label2.TabIndex = 108;
            this.label2.Text = "부서";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("굴림체", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(51, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 25);
            this.label8.TabIndex = 97;
            this.label8.Text = "사원등록";
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Location = new System.Drawing.Point(7, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(1018, 1);
            this.label9.TabIndex = 94;
            // 
            // 사원등록
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "사원등록";
            this.Size = new System.Drawing.Size(1044, 645);
            this.Load += new System.EventHandler(this.사원등록_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv사원)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv사원;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txb사원;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txb부서;
        private System.Windows.Forms.ComboBox cbb부서코드;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txb사원명;
        private System.Windows.Forms.TextBox txb사원코드;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txb암호;
        private System.Windows.Forms.TextBox txb비상연락망;
        private System.Windows.Forms.TextBox txb조회권한;
        private System.Windows.Forms.TextBox txb사용자여부;
        private System.Windows.Forms.TextBox txb부서코드;
        private System.Windows.Forms.TextBox txb영문이름;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DateTimePicker dtp퇴사일;
        private System.Windows.Forms.DateTimePicker dtp입사일;
        private System.Windows.Forms.Button btn삭제;
        private System.Windows.Forms.Button btn변경;
        private System.Windows.Forms.Button btn조회;
        private System.Windows.Forms.Button btn등록;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}
