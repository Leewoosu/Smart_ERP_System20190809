namespace SMART_ERP_System.MenuUserControl
{
    partial class 발주등록
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
            this.DeliveryLastDate = new System.Windows.Forms.DateTimePicker();
            this.DeliveryFirstDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.OrderLastDate = new System.Windows.Forms.DateTimePicker();
            this.OrderFirstDate = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txb거래처이름 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn조회 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox32 = new System.Windows.Forms.TextBox();
            this.textBox36 = new System.Windows.Forms.TextBox();
            this.dgv발주리스트 = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv발주서 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv발주리스트)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv발주서)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DeliveryLastDate);
            this.groupBox1.Controls.Add(this.DeliveryFirstDate);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.OrderLastDate);
            this.groupBox1.Controls.Add(this.OrderFirstDate);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.txb거래처이름);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.textBox8);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(7, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1018, 108);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            // 
            // DeliveryLastDate
            // 
            this.DeliveryLastDate.CustomFormat = "yyyy-MM-dd";
            this.DeliveryLastDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DeliveryLastDate.Location = new System.Drawing.Point(515, 72);
            this.DeliveryLastDate.Name = "DeliveryLastDate";
            this.DeliveryLastDate.Size = new System.Drawing.Size(99, 20);
            this.DeliveryLastDate.TabIndex = 69;
            // 
            // DeliveryFirstDate
            // 
            this.DeliveryFirstDate.CustomFormat = "yyyy-MM-dd";
            this.DeliveryFirstDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DeliveryFirstDate.Location = new System.Drawing.Point(366, 72);
            this.DeliveryFirstDate.Name = "DeliveryFirstDate";
            this.DeliveryFirstDate.Size = new System.Drawing.Size(103, 20);
            this.DeliveryFirstDate.TabIndex = 68;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(307, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 11);
            this.label4.TabIndex = 67;
            this.label4.Text = "납기기간";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(487, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 11);
            this.label7.TabIndex = 66;
            this.label7.Text = "~";
            // 
            // OrderLastDate
            // 
            this.OrderLastDate.CustomFormat = "yyyy-MM-dd";
            this.OrderLastDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.OrderLastDate.Location = new System.Drawing.Point(515, 46);
            this.OrderLastDate.Name = "OrderLastDate";
            this.OrderLastDate.Size = new System.Drawing.Size(99, 20);
            this.OrderLastDate.TabIndex = 65;
            // 
            // OrderFirstDate
            // 
            this.OrderFirstDate.CustomFormat = "yyyy-MM-dd";
            this.OrderFirstDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.OrderFirstDate.Location = new System.Drawing.Point(366, 46);
            this.OrderFirstDate.Name = "OrderFirstDate";
            this.OrderFirstDate.Size = new System.Drawing.Size(103, 20);
            this.OrderFirstDate.TabIndex = 64;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(366, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(66, 20);
            this.textBox1.TabIndex = 62;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(438, 17);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(108, 20);
            this.textBox4.TabIndex = 63;
            // 
            // txb거래처이름
            // 
            this.txb거래처이름.Location = new System.Drawing.Point(92, 46);
            this.txb거래처이름.Name = "txb거래처이름";
            this.txb거래처이름.Size = new System.Drawing.Size(179, 20);
            this.txb거래처이름.TabIndex = 57;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(92, 17);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(66, 20);
            this.textBox7.TabIndex = 54;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(164, 17);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(108, 20);
            this.textBox8.TabIndex = 55;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label15.Location = new System.Drawing.Point(307, 52);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 11);
            this.label15.TabIndex = 51;
            this.label15.Text = "주문기간";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(329, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 11);
            this.label11.TabIndex = 38;
            this.label11.Text = "사원";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(487, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 11);
            this.label3.TabIndex = 27;
            this.label3.Text = "~";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(59, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 11);
            this.label5.TabIndex = 31;
            this.label5.Text = "부서";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(48, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 11);
            this.label6.TabIndex = 33;
            this.label6.Text = "거래처";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 48;
            this.label8.Text = "발주등록";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1018, 1);
            this.label1.TabIndex = 44;
            this.label1.Text = "label1";
            // 
            // btn조회
            // 
            this.btn조회.Location = new System.Drawing.Point(933, 0);
            this.btn조회.Name = "btn조회";
            this.btn조회.Size = new System.Drawing.Size(92, 23);
            this.btn조회.TabIndex = 51;
            this.btn조회.Text = "청구적용조회";
            this.btn조회.UseVisualStyleBackColor = true;
            this.btn조회.Click += new System.EventHandler(this.Btn조회_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.textBox16);
            this.groupBox2.Controls.Add(this.textBox17);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.textBox18);
            this.groupBox2.Controls.Add(this.textBox19);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.textBox32);
            this.groupBox2.Controls.Add(this.textBox36);
            this.groupBox2.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(7, 561);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1018, 79);
            this.groupBox2.TabIndex = 89;
            this.groupBox2.TabStop = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(734, 47);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(109, 15);
            this.checkBox2.TabIndex = 77;
            this.checkBox2.Text = "가용재고(부)제외";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(734, 25);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(101, 15);
            this.checkBox1.TabIndex = 76;
            this.checkBox1.Text = "부적합재고제외";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(513, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 11);
            this.label2.TabIndex = 75;
            this.label2.Text = "입고예정량";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(296, 50);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 11);
            this.label12.TabIndex = 74;
            this.label12.Text = "가용재고";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label16.Location = new System.Drawing.Point(513, 26);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 11);
            this.label16.TabIndex = 72;
            this.label16.Text = "입고예정량";
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(572, 45);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(156, 20);
            this.textBox16.TabIndex = 71;
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(572, 19);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(156, 20);
            this.textBox17.TabIndex = 70;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label14.Location = new System.Drawing.Point(296, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 11);
            this.label14.TabIndex = 68;
            this.label14.Text = "가용재고";
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(351, 47);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(156, 20);
            this.textBox18.TabIndex = 67;
            // 
            // textBox19
            // 
            this.textBox19.Location = new System.Drawing.Point(351, 20);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(156, 20);
            this.textBox19.TabIndex = 66;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(72, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 11);
            this.label9.TabIndex = 65;
            this.label9.Text = "현재고";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(72, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 11);
            this.label10.TabIndex = 64;
            this.label10.Text = "현재고";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label20.Location = new System.Drawing.Point(6, 50);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(49, 11);
            this.label20.TabIndex = 53;
            this.label20.Text = "재고단위";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label21.Location = new System.Drawing.Point(6, 26);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(49, 11);
            this.label21.TabIndex = 52;
            this.label21.Text = "관리단위";
            // 
            // textBox32
            // 
            this.textBox32.Location = new System.Drawing.Point(116, 45);
            this.textBox32.Name = "textBox32";
            this.textBox32.Size = new System.Drawing.Size(156, 20);
            this.textBox32.TabIndex = 51;
            // 
            // textBox36
            // 
            this.textBox36.Location = new System.Drawing.Point(116, 20);
            this.textBox36.Name = "textBox36";
            this.textBox36.Size = new System.Drawing.Size(156, 20);
            this.textBox36.TabIndex = 28;
            // 
            // dgv발주리스트
            // 
            this.dgv발주리스트.AllowUserToAddRows = false;
            this.dgv발주리스트.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv발주리스트.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv발주리스트.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6});
            this.dgv발주리스트.Location = new System.Drawing.Point(15, 355);
            this.dgv발주리스트.Name = "dgv발주리스트";
            this.dgv발주리스트.RowTemplate.Height = 23;
            this.dgv발주리스트.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv발주리스트.Size = new System.Drawing.Size(1018, 200);
            this.dgv발주리스트.TabIndex = 88;
            this.dgv발주리스트.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv발주리스트_CellEndEdit);
            this.dgv발주리스트.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Dgv발주리스트_KeyDown);
            // 
            // Column5
            // 
            this.Column5.HeaderText = "자재";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "수량";
            this.Column6.Name = "Column6";
            // 
            // dgv발주서
            // 
            this.dgv발주서.AllowUserToAddRows = false;
            this.dgv발주서.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv발주서.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv발주서.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgv발주서.Location = new System.Drawing.Point(15, 145);
            this.dgv발주서.Name = "dgv발주서";
            this.dgv발주서.RowTemplate.Height = 23;
            this.dgv발주서.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv발주서.Size = new System.Drawing.Size(1018, 204);
            this.dgv발주서.TabIndex = 87;
            this.dgv발주서.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv발주서_CellClick);
            this.dgv발주서.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv발주서_CellEndEdit);
            this.dgv발주서.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Dgv발주서_KeyDown);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "발주번호";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "공급처";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "주문일";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "납기일";
            this.Column4.Name = "Column4";
            // 
            // 발주등록
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgv발주리스트);
            this.Controls.Add(this.dgv발주서);
            this.Controls.Add(this.btn조회);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Name = "발주등록";
            this.Size = new System.Drawing.Size(1044, 645);
            this.Load += new System.EventHandler(this.발주등록_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv발주리스트)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv발주서)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn조회;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox txb거래처이름;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBox32;
        private System.Windows.Forms.TextBox textBox36;
        private System.Windows.Forms.DataGridView dgv발주리스트;
        private System.Windows.Forms.DataGridView dgv발주서;
        private System.Windows.Forms.DateTimePicker DeliveryLastDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker OrderLastDate;
        private System.Windows.Forms.DateTimePicker OrderFirstDate;
        private System.Windows.Forms.DateTimePicker DeliveryFirstDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}
