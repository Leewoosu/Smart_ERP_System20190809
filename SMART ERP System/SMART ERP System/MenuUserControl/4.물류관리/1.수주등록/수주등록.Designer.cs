namespace SMART_ERP_System.MenuUserControl
{
    partial class 수주등록
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv엑셀 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txb납품업체이름 = new System.Windows.Forms.TextBox();
            this.txb품목명 = new System.Windows.Forms.TextBox();
            this.LastDate = new System.Windows.Forms.DateTimePicker();
            this.FirstDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn조회 = new System.Windows.Forms.Button();
            this.btn변경 = new System.Windows.Forms.Button();
            this.btn삭제 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv수주 = new System.Windows.Forms.DataGridView();
            this.수주번호DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.수주번호2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.제품번호DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.주문수량DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.납품업체번호DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.주문일DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.납기일DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bds수주 = new System.Windows.Forms.BindingSource(this.components);
            this.btn엑셀 = new System.Windows.Forms.Button();
            this.btn등록 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv엑셀)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv수주)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds수주)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv엑셀
            // 
            this.dgv엑셀.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgv엑셀.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv엑셀.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv엑셀.Location = new System.Drawing.Point(11, 145);
            this.dgv엑셀.Name = "dgv엑셀";
            this.dgv엑셀.RowTemplate.Height = 23;
            this.dgv엑셀.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv엑셀.Size = new System.Drawing.Size(502, 489);
            this.dgv엑셀.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(7, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1018, 1);
            this.label1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "수주등록";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txb납품업체이름);
            this.groupBox1.Controls.Add(this.txb품목명);
            this.groupBox1.Controls.Add(this.LastDate);
            this.groupBox1.Controls.Add(this.FirstDate);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(7, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1018, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // txb납품업체이름
            // 
            this.txb납품업체이름.Location = new System.Drawing.Point(143, 56);
            this.txb납품업체이름.Name = "txb납품업체이름";
            this.txb납품업체이름.Size = new System.Drawing.Size(150, 21);
            this.txb납품업체이름.TabIndex = 17;
            // 
            // txb품목명
            // 
            this.txb품목명.Location = new System.Drawing.Point(143, 14);
            this.txb품목명.Name = "txb품목명";
            this.txb품목명.Size = new System.Drawing.Size(150, 21);
            this.txb품목명.TabIndex = 16;
            // 
            // LastDate
            // 
            this.LastDate.CustomFormat = "yyyy-MM-dd";
            this.LastDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.LastDate.Location = new System.Drawing.Point(535, 11);
            this.LastDate.Name = "LastDate";
            this.LastDate.Size = new System.Drawing.Size(100, 21);
            this.LastDate.TabIndex = 15;
            this.LastDate.ValueChanged += new System.EventHandler(this.LastDate_ValueChanged);
            // 
            // FirstDate
            // 
            this.FirstDate.CustomFormat = "yyyy-MM-dd";
            this.FirstDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FirstDate.Location = new System.Drawing.Point(410, 11);
            this.FirstDate.Name = "FirstDate";
            this.FirstDate.Size = new System.Drawing.Size(96, 21);
            this.FirstDate.TabIndex = 14;
            this.FirstDate.ValueChanged += new System.EventHandler(this.FirstDate_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(515, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "~";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(351, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "주문일 : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "품목명 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "납품업체이름 : ";
            // 
            // btn조회
            // 
            this.btn조회.Location = new System.Drawing.Point(788, 3);
            this.btn조회.Name = "btn조회";
            this.btn조회.Size = new System.Drawing.Size(75, 23);
            this.btn조회.TabIndex = 7;
            this.btn조회.Text = "조회";
            this.btn조회.UseVisualStyleBackColor = true;
            this.btn조회.Click += new System.EventHandler(this.btn조회_Click);
            // 
            // btn변경
            // 
            this.btn변경.Location = new System.Drawing.Point(869, 2);
            this.btn변경.Name = "btn변경";
            this.btn변경.Size = new System.Drawing.Size(75, 23);
            this.btn변경.TabIndex = 8;
            this.btn변경.Text = "변경";
            this.btn변경.UseVisualStyleBackColor = true;
            this.btn변경.Click += new System.EventHandler(this.btn변경_Click);
            // 
            // btn삭제
            // 
            this.btn삭제.Location = new System.Drawing.Point(950, 2);
            this.btn삭제.Name = "btn삭제";
            this.btn삭제.Size = new System.Drawing.Size(75, 23);
            this.btn삭제.TabIndex = 9;
            this.btn삭제.Text = "삭제";
            this.btn삭제.UseVisualStyleBackColor = true;
            this.btn삭제.Click += new System.EventHandler(this.btn삭제_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv수주);
            this.panel1.Location = new System.Drawing.Point(530, 145);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(495, 492);
            this.panel1.TabIndex = 10;
            // 
            // dgv수주
            // 
            this.dgv수주.AutoGenerateColumns = false;
            this.dgv수주.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv수주.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv수주.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.수주번호DataGridViewTextBoxColumn,
            this.수주번호2DataGridViewTextBoxColumn,
            this.제품번호DataGridViewTextBoxColumn,
            this.주문수량DataGridViewTextBoxColumn,
            this.납품업체번호DataGridViewTextBoxColumn,
            this.주문일DataGridViewTextBoxColumn,
            this.납기일DataGridViewTextBoxColumn});
            this.dgv수주.DataSource = this.bds수주;
            this.dgv수주.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv수주.Location = new System.Drawing.Point(0, 0);
            this.dgv수주.Name = "dgv수주";
            this.dgv수주.RowTemplate.Height = 23;
            this.dgv수주.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv수주.Size = new System.Drawing.Size(495, 492);
            this.dgv수주.TabIndex = 0;
            // 
            // 수주번호DataGridViewTextBoxColumn
            // 
            this.수주번호DataGridViewTextBoxColumn.DataPropertyName = "수주번호";
            this.수주번호DataGridViewTextBoxColumn.HeaderText = "수주번호";
            this.수주번호DataGridViewTextBoxColumn.Name = "수주번호DataGridViewTextBoxColumn";
            // 
            // 수주번호2DataGridViewTextBoxColumn
            // 
            this.수주번호2DataGridViewTextBoxColumn.DataPropertyName = "수주번호2";
            this.수주번호2DataGridViewTextBoxColumn.HeaderText = "수주번호2";
            this.수주번호2DataGridViewTextBoxColumn.Name = "수주번호2DataGridViewTextBoxColumn";
            // 
            // 제품번호DataGridViewTextBoxColumn
            // 
            this.제품번호DataGridViewTextBoxColumn.DataPropertyName = "제품번호";
            this.제품번호DataGridViewTextBoxColumn.HeaderText = "제품번호";
            this.제품번호DataGridViewTextBoxColumn.Name = "제품번호DataGridViewTextBoxColumn";
            // 
            // 주문수량DataGridViewTextBoxColumn
            // 
            this.주문수량DataGridViewTextBoxColumn.DataPropertyName = "주문수량";
            this.주문수량DataGridViewTextBoxColumn.HeaderText = "주문수량";
            this.주문수량DataGridViewTextBoxColumn.Name = "주문수량DataGridViewTextBoxColumn";
            // 
            // 납품업체번호DataGridViewTextBoxColumn
            // 
            this.납품업체번호DataGridViewTextBoxColumn.DataPropertyName = "납품업체번호";
            this.납품업체번호DataGridViewTextBoxColumn.HeaderText = "납품업체번호";
            this.납품업체번호DataGridViewTextBoxColumn.Name = "납품업체번호DataGridViewTextBoxColumn";
            // 
            // 주문일DataGridViewTextBoxColumn
            // 
            this.주문일DataGridViewTextBoxColumn.DataPropertyName = "주문일";
            this.주문일DataGridViewTextBoxColumn.HeaderText = "주문일";
            this.주문일DataGridViewTextBoxColumn.Name = "주문일DataGridViewTextBoxColumn";
            // 
            // 납기일DataGridViewTextBoxColumn
            // 
            this.납기일DataGridViewTextBoxColumn.DataPropertyName = "납기일";
            this.납기일DataGridViewTextBoxColumn.HeaderText = "납기일";
            this.납기일DataGridViewTextBoxColumn.Name = "납기일DataGridViewTextBoxColumn";
            // 
            // bds수주
            // 
            this.bds수주.DataSource = typeof(ClassLibrary.수주);
            // 
            // btn엑셀
            // 
            this.btn엑셀.Location = new System.Drawing.Point(615, 3);
            this.btn엑셀.Name = "btn엑셀";
            this.btn엑셀.Size = new System.Drawing.Size(86, 23);
            this.btn엑셀.TabIndex = 11;
            this.btn엑셀.Text = "파일불러오기";
            this.btn엑셀.UseVisualStyleBackColor = true;
            this.btn엑셀.Click += new System.EventHandler(this.Btn엑셀_Click);
            // 
            // btn등록
            // 
            this.btn등록.Location = new System.Drawing.Point(707, 3);
            this.btn등록.Name = "btn등록";
            this.btn등록.Size = new System.Drawing.Size(75, 23);
            this.btn등록.TabIndex = 12;
            this.btn등록.Text = "등록";
            this.btn등록.UseVisualStyleBackColor = true;
            this.btn등록.Click += new System.EventHandler(this.btn등록_Click);
            // 
            // 수주등록
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn등록);
            this.Controls.Add(this.btn엑셀);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn삭제);
            this.Controls.Add(this.btn변경);
            this.Controls.Add(this.btn조회);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv엑셀);
            this.Name = "수주등록";
            this.Size = new System.Drawing.Size(1044, 645);
            this.Load += new System.EventHandler(this.RegisterSujuExcelControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv엑셀)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv수주)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds수주)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv엑셀;
        private System.Windows.Forms.BindingSource bds수주;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txb납품업체이름;
        private System.Windows.Forms.DateTimePicker LastDate;
        private System.Windows.Forms.DateTimePicker FirstDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn조회;
        private System.Windows.Forms.Button btn변경;
        private System.Windows.Forms.Button btn삭제;
        private System.Windows.Forms.TextBox txb품목명;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv수주;
        private System.Windows.Forms.DataGridViewTextBoxColumn 수주번호DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 수주번호2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 제품번호DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 주문수량DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 납품업체번호DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 주문일DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 납기일DataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn엑셀;
        private System.Windows.Forms.Button btn등록;
    }
}
