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
            this.dgv발주리스트 = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv발주서 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv발주리스트)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv발주서)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
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
            this.groupBox1.Location = new System.Drawing.Point(15, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1018, 78);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            // 
            // DeliveryLastDate
            // 
            this.DeliveryLastDate.CustomFormat = "yyyy-MM-dd";
            this.DeliveryLastDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DeliveryLastDate.Location = new System.Drawing.Point(855, 47);
            this.DeliveryLastDate.Name = "DeliveryLastDate";
            this.DeliveryLastDate.Size = new System.Drawing.Size(99, 20);
            this.DeliveryLastDate.TabIndex = 69;
            // 
            // DeliveryFirstDate
            // 
            this.DeliveryFirstDate.CustomFormat = "yyyy-MM-dd";
            this.DeliveryFirstDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DeliveryFirstDate.Location = new System.Drawing.Point(719, 47);
            this.DeliveryFirstDate.Name = "DeliveryFirstDate";
            this.DeliveryFirstDate.Size = new System.Drawing.Size(103, 20);
            this.DeliveryFirstDate.TabIndex = 68;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(645, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 14);
            this.label4.TabIndex = 67;
            this.label4.Text = "납기기간";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(834, 53);
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
            this.label15.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(292, 48);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 14);
            this.label15.TabIndex = 51;
            this.label15.Text = "주문기간";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(324, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 14);
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
            this.label5.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(49, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 14);
            this.label5.TabIndex = 31;
            this.label5.Text = "부서";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(33, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 14);
            this.label6.TabIndex = 33;
            this.label6.Text = "거래처";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림체", 15.75F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(51, 2);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 21);
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
            this.btn조회.Text = "조회";
            this.btn조회.UseVisualStyleBackColor = true;
            this.btn조회.Click += new System.EventHandler(this.Btn조회_Click);
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
            this.dgv발주리스트.Size = new System.Drawing.Size(1018, 241);
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
            this.dgv발주서.Location = new System.Drawing.Point(15, 115);
            this.dgv발주서.Name = "dgv발주서";
            this.dgv발주서.RowTemplate.Height = 23;
            this.dgv발주서.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv발주서.Size = new System.Drawing.Size(1018, 234);
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
