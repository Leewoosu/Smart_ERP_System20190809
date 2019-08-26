namespace SMART_ERP_System.MenuUserControl
{
    partial class 출고처리
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.납품업체번호 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.수주번호1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SuperKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.제품번호 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.주문수량 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.주문일 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.납기일 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.출고량 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.잔량 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.단가 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.금액 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.출고 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.고객이름 = new System.Windows.Forms.TextBox();
            this.고객번호 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txbTotalPrice = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txbMaterialCnt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txbTotalCnt = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbMaterialQty = new System.Windows.Forms.TextBox();
            this.txbMaterialName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txbMaterial = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.조회 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpe = new System.Windows.Forms.DateTimePicker();
            this.dtps = new System.Windows.Forms.DateTimePicker();
            this.품번1 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rbtn처리 = new System.Windows.Forms.RadioButton();
            this.rbtn조회 = new System.Windows.Forms.RadioButton();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.납품업체번호,
            this.수주번호1,
            this.SuperKey,
            this.제품번호,
            this.주문수량,
            this.주문일,
            this.납기일,
            this.출고량,
            this.잔량,
            this.단가,
            this.금액,
            this.출고});
            this.dataGridView1.Location = new System.Drawing.Point(7, 159);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1018, 438);
            this.dataGridView1.TabIndex = 128;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellEnter);
            // 
            // 납품업체번호
            // 
            this.납품업체번호.HeaderText = "납품업체번호";
            this.납품업체번호.Name = "납품업체번호";
            this.납품업체번호.Visible = false;
            // 
            // 수주번호1
            // 
            this.수주번호1.HeaderText = "수주번호1";
            this.수주번호1.Name = "수주번호1";
            this.수주번호1.ReadOnly = true;
            // 
            // SuperKey
            // 
            this.SuperKey.HeaderText = "items";
            this.SuperKey.Name = "SuperKey";
            this.SuperKey.ReadOnly = true;
            this.SuperKey.Width = 65;
            // 
            // 제품번호
            // 
            this.제품번호.HeaderText = "제품번호";
            this.제품번호.Name = "제품번호";
            this.제품번호.ReadOnly = true;
            this.제품번호.Width = 120;
            // 
            // 주문수량
            // 
            this.주문수량.HeaderText = "주문수량";
            this.주문수량.Name = "주문수량";
            this.주문수량.ReadOnly = true;
            this.주문수량.Width = 80;
            // 
            // 주문일
            // 
            this.주문일.HeaderText = "주문일";
            this.주문일.Name = "주문일";
            this.주문일.ReadOnly = true;
            this.주문일.Width = 80;
            // 
            // 납기일
            // 
            this.납기일.HeaderText = "납기일";
            this.납기일.Name = "납기일";
            this.납기일.ReadOnly = true;
            this.납기일.Width = 80;
            // 
            // 출고량
            // 
            this.출고량.HeaderText = "출고가능수량";
            this.출고량.Name = "출고량";
            // 
            // 잔량
            // 
            this.잔량.HeaderText = "잔량";
            this.잔량.Name = "잔량";
            this.잔량.ReadOnly = true;
            this.잔량.Width = 80;
            // 
            // 단가
            // 
            this.단가.HeaderText = "단가";
            this.단가.Name = "단가";
            // 
            // 금액
            // 
            this.금액.HeaderText = "금액";
            this.금액.Name = "금액";
            this.금액.ReadOnly = true;
            // 
            // 출고
            // 
            this.출고.HeaderText = "출고";
            this.출고.Name = "출고";
            this.출고.Width = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림체", 15.75F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(51, 2);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 21);
            this.label8.TabIndex = 126;
            this.label8.Text = "출고처리";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1018, 1);
            this.label1.TabIndex = 125;
            this.label1.Text = "label1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(790, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 14);
            this.label11.TabIndex = 38;
            this.label11.Text = "사원";
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(902, 38);
            this.textBox15.Name = "textBox15";
            this.textBox15.ReadOnly = true;
            this.textBox15.Size = new System.Drawing.Size(111, 20);
            this.textBox15.TabIndex = 128;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(829, 38);
            this.textBox14.Name = "textBox14";
            this.textBox14.ReadOnly = true;
            this.textBox14.Size = new System.Drawing.Size(67, 20);
            this.textBox14.TabIndex = 127;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(789, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 14);
            this.label2.TabIndex = 135;
            this.label2.Text = "고객";
            // 
            // 고객이름
            // 
            this.고객이름.Location = new System.Drawing.Point(902, 13);
            this.고객이름.Name = "고객이름";
            this.고객이름.ReadOnly = true;
            this.고객이름.Size = new System.Drawing.Size(111, 20);
            this.고객이름.TabIndex = 137;
            // 
            // 고객번호
            // 
            this.고객번호.Location = new System.Drawing.Point(829, 13);
            this.고객번호.Name = "고객번호";
            this.고객번호.ReadOnly = true;
            this.고객번호.Size = new System.Drawing.Size(67, 20);
            this.고객번호.TabIndex = 136;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.고객이름);
            this.groupBox1.Controls.Add(this.textBox14);
            this.groupBox1.Controls.Add(this.고객번호);
            this.groupBox1.Controls.Add(this.textBox15);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(7, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1018, 124);
            this.groupBox1.TabIndex = 127;
            this.groupBox1.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txbTotalPrice);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.txbMaterialCnt);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.txbTotalCnt);
            this.groupBox4.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox4.Location = new System.Drawing.Point(525, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(176, 114);
            this.groupBox4.TabIndex = 157;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "현황정보";
            // 
            // txbTotalPrice
            // 
            this.txbTotalPrice.Location = new System.Drawing.Point(76, 83);
            this.txbTotalPrice.Name = "txbTotalPrice";
            this.txbTotalPrice.Size = new System.Drawing.Size(91, 23);
            this.txbTotalPrice.TabIndex = 158;
            this.txbTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(6, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 14);
            this.label10.TabIndex = 157;
            this.label10.Text = "전체금액";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(6, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 14);
            this.label9.TabIndex = 156;
            this.label9.Text = "품목개수";
            // 
            // txbMaterialCnt
            // 
            this.txbMaterialCnt.Location = new System.Drawing.Point(76, 29);
            this.txbMaterialCnt.Name = "txbMaterialCnt";
            this.txbMaterialCnt.Size = new System.Drawing.Size(91, 23);
            this.txbMaterialCnt.TabIndex = 155;
            this.txbMaterialCnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(6, 61);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 14);
            this.label12.TabIndex = 154;
            this.label12.Text = "전체수량";
            // 
            // txbTotalCnt
            // 
            this.txbTotalCnt.Location = new System.Drawing.Point(76, 56);
            this.txbTotalCnt.Name = "txbTotalCnt";
            this.txbTotalCnt.Size = new System.Drawing.Size(91, 23);
            this.txbTotalCnt.TabIndex = 153;
            this.txbTotalCnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txbMaterialQty);
            this.groupBox2.Controls.Add(this.txbMaterialName);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txbMaterial);
            this.groupBox2.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(338, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(185, 114);
            this.groupBox2.TabIndex = 150;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "품목정보";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(6, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 14);
            this.label6.TabIndex = 156;
            this.label6.Text = "품   명";
            // 
            // txbMaterialQty
            // 
            this.txbMaterialQty.Location = new System.Drawing.Point(70, 82);
            this.txbMaterialQty.Name = "txbMaterialQty";
            this.txbMaterialQty.Size = new System.Drawing.Size(42, 23);
            this.txbMaterialQty.TabIndex = 150;
            this.txbMaterialQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txbMaterialName
            // 
            this.txbMaterialName.Location = new System.Drawing.Point(68, 29);
            this.txbMaterialName.Name = "txbMaterialName";
            this.txbMaterialName.Size = new System.Drawing.Size(102, 23);
            this.txbMaterialName.TabIndex = 155;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(6, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 14);
            this.label5.TabIndex = 151;
            this.label5.Text = "현재고";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(6, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 14);
            this.label7.TabIndex = 154;
            this.label7.Text = "품목군";
            // 
            // txbMaterial
            // 
            this.txbMaterial.Location = new System.Drawing.Point(69, 55);
            this.txbMaterial.Name = "txbMaterial";
            this.txbMaterial.Size = new System.Drawing.Size(102, 23);
            this.txbMaterial.TabIndex = 153;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.조회);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.dtpe);
            this.groupBox3.Controls.Add(this.dtps);
            this.groupBox3.Controls.Add(this.품번1);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.rbtn처리);
            this.groupBox3.Controls.Add(this.rbtn조회);
            this.groupBox3.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(0, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(338, 114);
            this.groupBox3.TabIndex = 149;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "출고";
            // 
            // 조회
            // 
            this.조회.Location = new System.Drawing.Point(216, 79);
            this.조회.Name = "조회";
            this.조회.Size = new System.Drawing.Size(110, 23);
            this.조회.TabIndex = 161;
            this.조회.Text = "조회";
            this.조회.UseVisualStyleBackColor = true;
            this.조회.Click += new System.EventHandler(this.Button5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(5, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 14);
            this.label4.TabIndex = 164;
            this.label4.Text = "품목번호";
            // 
            // dtpe
            // 
            this.dtpe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpe.Location = new System.Drawing.Point(216, 51);
            this.dtpe.Name = "dtpe";
            this.dtpe.Size = new System.Drawing.Size(110, 23);
            this.dtpe.TabIndex = 163;
            // 
            // dtps
            // 
            this.dtps.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtps.Location = new System.Drawing.Point(84, 51);
            this.dtps.Name = "dtps";
            this.dtps.Size = new System.Drawing.Size(107, 23);
            this.dtps.TabIndex = 162;
            // 
            // 품번1
            // 
            this.품번1.Location = new System.Drawing.Point(84, 79);
            this.품번1.Name = "품번1";
            this.품번1.Size = new System.Drawing.Size(105, 23);
            this.품번1.TabIndex = 160;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(5, 56);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 14);
            this.label15.TabIndex = 159;
            this.label15.Text = "기      간";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 14);
            this.label3.TabIndex = 158;
            this.label3.Text = "~";
            // 
            // rbtn처리
            // 
            this.rbtn처리.AutoSize = true;
            this.rbtn처리.Location = new System.Drawing.Point(102, 19);
            this.rbtn처리.Name = "rbtn처리";
            this.rbtn처리.Size = new System.Drawing.Size(85, 18);
            this.rbtn처리.TabIndex = 147;
            this.rbtn처리.Text = "출고현황";
            this.rbtn처리.UseVisualStyleBackColor = true;
            this.rbtn처리.CheckedChanged += new System.EventHandler(this.Rbtn조회_CheckedChanged);
            // 
            // rbtn조회
            // 
            this.rbtn조회.AutoSize = true;
            this.rbtn조회.Checked = true;
            this.rbtn조회.Location = new System.Drawing.Point(11, 19);
            this.rbtn조회.Name = "rbtn조회";
            this.rbtn조회.Size = new System.Drawing.Size(85, 18);
            this.rbtn조회.TabIndex = 148;
            this.rbtn조회.TabStop = true;
            this.rbtn조회.Text = "출고등록";
            this.rbtn조회.UseVisualStyleBackColor = true;
            this.rbtn조회.CheckedChanged += new System.EventHandler(this.Rbtn조회_CheckedChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(829, 93);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(84, 23);
            this.button4.TabIndex = 146;
            this.button4.Text = "전체해제";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(739, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 23);
            this.button1.TabIndex = 145;
            this.button1.Text = "전체선택";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(917, 93);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 23);
            this.button3.TabIndex = 144;
            this.button3.Text = "출고처리";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // 출고처리
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Name = "출고처리";
            this.Size = new System.Drawing.Size(1044, 645);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox 고객이름;
        private System.Windows.Forms.TextBox 고객번호;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbtn처리;
        private System.Windows.Forms.RadioButton rbtn조회;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbMaterialCnt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txbTotalCnt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbMaterialQty;
        private System.Windows.Forms.TextBox txbMaterialName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbMaterial;
        private System.Windows.Forms.Button 조회;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpe;
        private System.Windows.Forms.DateTimePicker dtps;
        private System.Windows.Forms.TextBox 품번1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbTotalPrice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn 납품업체번호;
        private System.Windows.Forms.DataGridViewTextBoxColumn 수주번호1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SuperKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn 제품번호;
        private System.Windows.Forms.DataGridViewTextBoxColumn 주문수량;
        private System.Windows.Forms.DataGridViewTextBoxColumn 주문일;
        private System.Windows.Forms.DataGridViewTextBoxColumn 납기일;
        private System.Windows.Forms.DataGridViewTextBoxColumn 출고량;
        private System.Windows.Forms.DataGridViewTextBoxColumn 잔량;
        private System.Windows.Forms.DataGridViewTextBoxColumn 단가;
        private System.Windows.Forms.DataGridViewTextBoxColumn 금액;
        private System.Windows.Forms.DataGridViewCheckBoxColumn 출고;
    }
}
