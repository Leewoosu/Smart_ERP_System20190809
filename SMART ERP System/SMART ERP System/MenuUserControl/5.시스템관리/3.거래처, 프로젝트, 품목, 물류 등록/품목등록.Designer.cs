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
            this.cbbSearch검사여부 = new System.Windows.Forms.ComboBox();
            this.txbSearch품목군 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv제품 = new System.Windows.Forms.DataGridView();
            this.제품번호DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.제품명DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bds제품 = new System.Windows.Forms.BindingSource(this.components);
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
            this.txb후공정 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txb전공정 = new System.Windows.Forms.TextBox();
            this.txb실제원가 = new System.Windows.Forms.TextBox();
            this.txb일별생산량 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txb리드타임 = new System.Windows.Forms.TextBox();
            this.txbLOT수량 = new System.Windows.Forms.TextBox();
            this.txb제품명 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txb최종공정 = new System.Windows.Forms.TextBox();
            this.txb표준원가 = new System.Windows.Forms.TextBox();
            this.txb안전재고량 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txb제품번호 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv제품)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds제품)).BeginInit();
            this.panel2.SuspendLayout();
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
            this.label2.Location = new System.Drawing.Point(4, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "품목등록";
            // 
            // btn등록
            // 
            this.btn등록.Location = new System.Drawing.Point(666, 1);
            this.btn등록.Name = "btn등록";
            this.btn등록.Size = new System.Drawing.Size(75, 23);
            this.btn등록.TabIndex = 2;
            this.btn등록.Text = "등록";
            this.btn등록.UseVisualStyleBackColor = true;
            this.btn등록.Click += new System.EventHandler(this.btn등록_Click);
            // 
            // btn조회
            // 
            this.btn조회.Location = new System.Drawing.Point(585, 1);
            this.btn조회.Name = "btn조회";
            this.btn조회.Size = new System.Drawing.Size(75, 23);
            this.btn조회.TabIndex = 3;
            this.btn조회.Text = "조회";
            this.btn조회.UseVisualStyleBackColor = true;
            this.btn조회.Click += new System.EventHandler(this.btn조회_Click);
            // 
            // btn변경
            // 
            this.btn변경.Location = new System.Drawing.Point(747, 1);
            this.btn변경.Name = "btn변경";
            this.btn변경.Size = new System.Drawing.Size(75, 23);
            this.btn변경.TabIndex = 4;
            this.btn변경.Text = "변경";
            this.btn변경.UseVisualStyleBackColor = true;
            this.btn변경.Click += new System.EventHandler(this.btn변경_Click);
            // 
            // btn삭제
            // 
            this.btn삭제.Location = new System.Drawing.Point(828, 1);
            this.btn삭제.Name = "btn삭제";
            this.btn삭제.Size = new System.Drawing.Size(75, 23);
            this.btn삭제.TabIndex = 5;
            this.btn삭제.Text = "삭제";
            this.btn삭제.UseVisualStyleBackColor = true;
            this.btn삭제.Click += new System.EventHandler(this.btn삭제_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbSearch검사여부);
            this.groupBox1.Controls.Add(this.txbSearch품목군);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(6, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1012, 68);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // cbbSearch검사여부
            // 
            this.cbbSearch검사여부.FormattingEnabled = true;
            this.cbbSearch검사여부.Location = new System.Drawing.Point(552, 20);
            this.cbbSearch검사여부.Name = "cbbSearch검사여부";
            this.cbbSearch검사여부.Size = new System.Drawing.Size(150, 20);
            this.cbbSearch검사여부.TabIndex = 6;
            // 
            // txbSearch품목군
            // 
            this.txbSearch품목군.Location = new System.Drawing.Point(267, 20);
            this.txbSearch품목군.Name = "txbSearch품목군";
            this.txbSearch품목군.Size = new System.Drawing.Size(150, 21);
            this.txbSearch품목군.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(492, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "검사여부";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "품목군";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv제품);
            this.panel1.Location = new System.Drawing.Point(6, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(397, 544);
            this.panel1.TabIndex = 7;
            // 
            // dgv제품
            // 
            this.dgv제품.AutoGenerateColumns = false;
            this.dgv제품.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv제품.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv제품.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.제품번호DataGridViewTextBoxColumn,
            this.제품명DataGridViewTextBoxColumn});
            this.dgv제품.DataSource = this.bds제품;
            this.dgv제품.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv제품.Location = new System.Drawing.Point(0, 0);
            this.dgv제품.Name = "dgv제품";
            this.dgv제품.RowTemplate.Height = 23;
            this.dgv제품.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv제품.Size = new System.Drawing.Size(397, 544);
            this.dgv제품.TabIndex = 0;
            this.dgv제품.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv제품_CellDoubleClick);
            this.dgv제품.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv제품_CellEndEdit);
            // 
            // 제품번호DataGridViewTextBoxColumn
            // 
            this.제품번호DataGridViewTextBoxColumn.DataPropertyName = "제품번호";
            this.제품번호DataGridViewTextBoxColumn.HeaderText = "제품번호";
            this.제품번호DataGridViewTextBoxColumn.Name = "제품번호DataGridViewTextBoxColumn";
            // 
            // 제품명DataGridViewTextBoxColumn
            // 
            this.제품명DataGridViewTextBoxColumn.DataPropertyName = "제품명";
            this.제품명DataGridViewTextBoxColumn.HeaderText = "제품명";
            this.제품명DataGridViewTextBoxColumn.Name = "제품명DataGridViewTextBoxColumn";
            // 
            // bds제품
            // 
            this.bds제품.DataSource = typeof(ClassLibrary.제품);
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
            this.panel2.Controls.Add(this.txb후공정);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.txb전공정);
            this.panel2.Controls.Add(this.txb실제원가);
            this.panel2.Controls.Add(this.txb일별생산량);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.txb리드타임);
            this.panel2.Controls.Add(this.txbLOT수량);
            this.panel2.Controls.Add(this.txb제품명);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.txb최종공정);
            this.panel2.Controls.Add(this.txb표준원가);
            this.panel2.Controls.Add(this.txb안전재고량);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txb제품번호);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(420, 104);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(598, 543);
            this.panel2.TabIndex = 8;
            // 
            // txb외경
            // 
            this.txb외경.Location = new System.Drawing.Point(373, 435);
            this.txb외경.Name = "txb외경";
            this.txb외경.Size = new System.Drawing.Size(150, 21);
            this.txb외경.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(304, 438);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 38;
            this.label7.Text = "외경";
            // 
            // txb층
            // 
            this.txb층.Location = new System.Drawing.Point(140, 432);
            this.txb층.Name = "txb층";
            this.txb층.Size = new System.Drawing.Size(150, 21);
            this.txb층.TabIndex = 37;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(68, 435);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(17, 12);
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
            this.txb재고량.Location = new System.Drawing.Point(373, 380);
            this.txb재고량.Name = "txb재고량";
            this.txb재고량.Size = new System.Drawing.Size(150, 21);
            this.txb재고량.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(304, 383);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
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
            this.label18.Location = new System.Drawing.Point(68, 80);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 12);
            this.label18.TabIndex = 32;
            this.label18.Text = "품목군";
            // 
            // txb후공정
            // 
            this.txb후공정.Location = new System.Drawing.Point(140, 377);
            this.txb후공정.Name = "txb후공정";
            this.txb후공정.Size = new System.Drawing.Size(150, 21);
            this.txb후공정.TabIndex = 31;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(68, 260);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 12);
            this.label19.TabIndex = 30;
            this.label19.Text = "표준원가";
            // 
            // txb전공정
            // 
            this.txb전공정.Location = new System.Drawing.Point(373, 317);
            this.txb전공정.Name = "txb전공정";
            this.txb전공정.Size = new System.Drawing.Size(150, 21);
            this.txb전공정.TabIndex = 29;
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
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(304, 320);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 12);
            this.label15.TabIndex = 26;
            this.label15.Text = "전공정";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(304, 260);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 12);
            this.label16.TabIndex = 25;
            this.label16.Text = "실제원가";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(304, 200);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 12);
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
            this.label12.Location = new System.Drawing.Point(304, 140);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 20;
            this.label12.Text = "리드타임";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(304, 80);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 19;
            this.label13.Text = "LOT수량";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(304, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 12);
            this.label14.TabIndex = 18;
            this.label14.Text = "제품명";
            // 
            // txb최종공정
            // 
            this.txb최종공정.Location = new System.Drawing.Point(140, 317);
            this.txb최종공정.Name = "txb최종공정";
            this.txb최종공정.Size = new System.Drawing.Size(150, 21);
            this.txb최종공정.TabIndex = 17;
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(68, 380);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 14;
            this.label9.Text = "후공정";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(68, 320);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 13;
            this.label10.Text = "최종공정";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(68, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
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
            this.label6.Location = new System.Drawing.Point(68, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "안전재고량";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(68, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 6;
            this.label8.Text = "제품번호";
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv제품)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds제품)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.TextBox txbSearch품목군;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv제품;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn 제품번호DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 제품명DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bds제품;
        private System.Windows.Forms.TextBox txb품목군;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txb후공정;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txb전공정;
        private System.Windows.Forms.TextBox txb실제원가;
        private System.Windows.Forms.TextBox txb일별생산량;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txb리드타임;
        private System.Windows.Forms.TextBox txbLOT수량;
        private System.Windows.Forms.TextBox txb제품명;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txb최종공정;
        private System.Windows.Forms.TextBox txb안전재고량;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
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
    }
}
