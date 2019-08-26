namespace SMART_ERP_System.MenuUserControl
{
    partial class 손익계산서
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv손익계산서 = new System.Windows.Forms.DataGridView();
            this.계정과목DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.당기금액차변DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.당기금액대변DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.전기금액차변DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.전기금액대변DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.손익계산서BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbb금액구분 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp입력날짜 = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.txb사업장명 = new System.Windows.Forms.TextBox();
            this.cbb사업장코드 = new System.Windows.Forms.ComboBox();
            this.사업장등록BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv손익계산서)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.손익계산서BindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.사업장등록BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1041, 651);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv손익계산서);
            this.panel1.Location = new System.Drawing.Point(8, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1025, 513);
            this.panel1.TabIndex = 100;
            // 
            // dgv손익계산서
            // 
            this.dgv손익계산서.AllowUserToAddRows = false;
            this.dgv손익계산서.AllowUserToDeleteRows = false;
            this.dgv손익계산서.AutoGenerateColumns = false;
            this.dgv손익계산서.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv손익계산서.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv손익계산서.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.계정과목DataGridViewTextBoxColumn,
            this.당기금액차변DataGridViewTextBoxColumn,
            this.당기금액대변DataGridViewTextBoxColumn,
            this.전기금액차변DataGridViewTextBoxColumn,
            this.전기금액대변DataGridViewTextBoxColumn});
            this.dgv손익계산서.DataSource = this.손익계산서BindingSource;
            this.dgv손익계산서.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv손익계산서.Location = new System.Drawing.Point(0, 0);
            this.dgv손익계산서.Name = "dgv손익계산서";
            this.dgv손익계산서.ReadOnly = true;
            this.dgv손익계산서.RowHeadersVisible = false;
            this.dgv손익계산서.RowTemplate.Height = 23;
            this.dgv손익계산서.Size = new System.Drawing.Size(1025, 513);
            this.dgv손익계산서.TabIndex = 88;
            this.dgv손익계산서.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.Dgv손익계산서_CellFormatting);
            this.dgv손익계산서.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.Dgv손익계산서_CellPainting);
            this.dgv손익계산서.ColumnWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.Dgv손익계산서_ColumnWidthChanged);
            this.dgv손익계산서.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.Dgv손익계산서_DataError);
            this.dgv손익계산서.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.Dgv손익계산서_RowPostPaint);
            this.dgv손익계산서.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Dgv손익계산서_Scroll);
            this.dgv손익계산서.Paint += new System.Windows.Forms.PaintEventHandler(this.Dgv손익계산서_Paint);
            // 
            // 계정과목DataGridViewTextBoxColumn
            // 
            this.계정과목DataGridViewTextBoxColumn.DataPropertyName = "계정과목";
            this.계정과목DataGridViewTextBoxColumn.HeaderText = "계정과목";
            this.계정과목DataGridViewTextBoxColumn.Name = "계정과목DataGridViewTextBoxColumn";
            this.계정과목DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 당기금액차변DataGridViewTextBoxColumn
            // 
            this.당기금액차변DataGridViewTextBoxColumn.DataPropertyName = "당기금액차변";
            this.당기금액차변DataGridViewTextBoxColumn.HeaderText = "당기금액차변";
            this.당기금액차변DataGridViewTextBoxColumn.Name = "당기금액차변DataGridViewTextBoxColumn";
            this.당기금액차변DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 당기금액대변DataGridViewTextBoxColumn
            // 
            this.당기금액대변DataGridViewTextBoxColumn.DataPropertyName = "당기금액대변";
            this.당기금액대변DataGridViewTextBoxColumn.HeaderText = "당기금액대변";
            this.당기금액대변DataGridViewTextBoxColumn.Name = "당기금액대변DataGridViewTextBoxColumn";
            this.당기금액대변DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 전기금액차변DataGridViewTextBoxColumn
            // 
            this.전기금액차변DataGridViewTextBoxColumn.DataPropertyName = "전기금액차변";
            this.전기금액차변DataGridViewTextBoxColumn.HeaderText = "전기금액차변";
            this.전기금액차변DataGridViewTextBoxColumn.Name = "전기금액차변DataGridViewTextBoxColumn";
            this.전기금액차변DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 전기금액대변DataGridViewTextBoxColumn
            // 
            this.전기금액대변DataGridViewTextBoxColumn.DataPropertyName = "전기금액대변";
            this.전기금액대변DataGridViewTextBoxColumn.HeaderText = "전기금액대변";
            this.전기금액대변DataGridViewTextBoxColumn.Name = "전기금액대변DataGridViewTextBoxColumn";
            this.전기금액대변DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 손익계산서BindingSource
            // 
            this.손익계산서BindingSource.DataSource = typeof(ClassLibrary.손익계산서);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.cbb금액구분);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dtp입력날짜);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txb사업장명);
            this.groupBox2.Controls.Add(this.cbb사업장코드);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(7, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1025, 44);
            this.groupBox2.TabIndex = 88;
            this.groupBox2.TabStop = false;
            // 
            // cbb금액구분
            // 
            this.cbb금액구분.Enabled = false;
            this.cbb금액구분.Font = new System.Drawing.Font("굴림", 10F);
            this.cbb금액구분.FormattingEnabled = true;
            this.cbb금액구분.Items.AddRange(new object[] {
            "0.       원",
            "1.  천  원",
            "2. 백만원"});
            this.cbb금액구분.Location = new System.Drawing.Point(717, 10);
            this.cbb금액구분.Name = "cbb금액구분";
            this.cbb금액구분.Size = new System.Drawing.Size(76, 21);
            this.cbb금액구분.TabIndex = 114;
            this.cbb금액구분.SelectedValueChanged += new System.EventHandler(this.Cbb금액구분_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(671, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 22);
            this.label4.TabIndex = 113;
            this.label4.Text = "단위";
            // 
            // dtp입력날짜
            // 
            this.dtp입력날짜.CustomFormat = "yyyy-MM-dd";
            this.dtp입력날짜.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp입력날짜.Location = new System.Drawing.Point(328, 10);
            this.dtp입력날짜.Name = "dtp입력날짜";
            this.dtp입력날짜.Size = new System.Drawing.Size(119, 21);
            this.dtp입력날짜.TabIndex = 112;
            this.dtp입력날짜.Value = new System.DateTime(2019, 7, 31, 18, 37, 0, 0);
            this.dtp입력날짜.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Dtp입력날짜_KeyDown);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label12.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(287, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 22);
            this.label12.TabIndex = 111;
            this.label12.Text = "기간";
            // 
            // txb사업장명
            // 
            this.txb사업장명.Enabled = false;
            this.txb사업장명.Location = new System.Drawing.Point(148, 9);
            this.txb사업장명.Name = "txb사업장명";
            this.txb사업장명.Size = new System.Drawing.Size(110, 21);
            this.txb사업장명.TabIndex = 110;
            // 
            // cbb사업장코드
            // 
            this.cbb사업장코드.DataSource = this.사업장등록BindingSource;
            this.cbb사업장코드.DisplayMember = "사업장코드";
            this.cbb사업장코드.Font = new System.Drawing.Font("굴림", 10F);
            this.cbb사업장코드.FormattingEnabled = true;
            this.cbb사업장코드.Location = new System.Drawing.Point(85, 9);
            this.cbb사업장코드.Name = "cbb사업장코드";
            this.cbb사업장코드.Size = new System.Drawing.Size(57, 21);
            this.cbb사업장코드.TabIndex = 109;
            this.cbb사업장코드.ValueMember = "사업장코드";
            // 
            // 사업장등록BindingSource
            // 
            this.사업장등록BindingSource.DataSource = typeof(ClassLibrary.사업장등록);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(17, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 22);
            this.label2.TabIndex = 108;
            this.label2.Text = "회계단위";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(656, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 98;
            this.button5.Text = "양식선택";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("굴림체", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(55, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 25);
            this.label8.TabIndex = 97;
            this.label8.Text = "손익계산서";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(818, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 96;
            this.button7.Text = "환경설정";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(737, 2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 95;
            this.button8.Text = "통합계정";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Location = new System.Drawing.Point(7, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(1025, 1);
            this.label9.TabIndex = 94;
            // 
            // 손익계산서
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "손익계산서";
            this.Size = new System.Drawing.Size(1044, 645);
            this.Load += new System.EventHandler(this.손익계산서_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv손익계산서)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.손익계산서BindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.사업장등록BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbb금액구분;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp입력날짜;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txb사업장명;
        private System.Windows.Forms.ComboBox cbb사업장코드;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv손익계산서;
        private System.Windows.Forms.DataGridViewTextBoxColumn 계정과목DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 당기금액차변DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 당기금액대변DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 전기금액차변DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 전기금액대변DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource 손익계산서BindingSource;
        private System.Windows.Forms.BindingSource 사업장등록BindingSource;
    }
}
