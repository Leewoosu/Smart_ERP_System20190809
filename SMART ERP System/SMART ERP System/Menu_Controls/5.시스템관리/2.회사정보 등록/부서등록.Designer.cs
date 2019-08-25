namespace SMART_ERP_System.MenuUserControl
{
    partial class 부서등록
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
            this.dgv부서 = new System.Windows.Forms.DataGridView();
            this.부서등록BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbx조회기준적용 = new System.Windows.Forms.CheckBox();
            this.dtp조회기준일 = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.txb사업장명 = new System.Windows.Forms.TextBox();
            this.cbb사업장코드 = new System.Windows.Forms.ComboBox();
            this.사업장등록BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.부서코드 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.부서명 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.사업장코드 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.사업장명 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.부문코드 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.부문명 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.사용시작기간 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.사용종료기간 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv부서)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.부서등록BindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.사업장등록BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv부서);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1033, 651);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // dgv부서
            // 
            this.dgv부서.AutoGenerateColumns = false;
            this.dgv부서.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv부서.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv부서.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.부서코드,
            this.부서명,
            this.사업장코드,
            this.사업장명,
            this.부문코드,
            this.부문명,
            this.사용시작기간,
            this.사용종료기간});
            this.dgv부서.DataSource = this.부서등록BindingSource;
            this.dgv부서.Location = new System.Drawing.Point(7, 66);
            this.dgv부서.Name = "dgv부서";
            this.dgv부서.RowTemplate.Height = 23;
            this.dgv부서.Size = new System.Drawing.Size(1018, 574);
            this.dgv부서.TabIndex = 98;
            this.dgv부서.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv부서_CellEndEdit);
            this.dgv부서.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.Dgv부서_DataError);
            this.dgv부서.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Dgv부서_KeyDown);
            // 
            // 부서등록BindingSource
            // 
            this.부서등록BindingSource.DataSource = typeof(ClassLibrary.부서등록);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.cbx조회기준적용);
            this.groupBox2.Controls.Add(this.dtp조회기준일);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txb사업장명);
            this.groupBox2.Controls.Add(this.cbb사업장코드);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(7, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1018, 32);
            this.groupBox2.TabIndex = 88;
            this.groupBox2.TabStop = false;
            // 
            // cbx조회기준적용
            // 
            this.cbx조회기준적용.AutoSize = true;
            this.cbx조회기준적용.Location = new System.Drawing.Point(554, 11);
            this.cbx조회기준적용.Name = "cbx조회기준적용";
            this.cbx조회기준적용.Size = new System.Drawing.Size(15, 14);
            this.cbx조회기준적용.TabIndex = 113;
            this.cbx조회기준적용.UseVisualStyleBackColor = true;
            this.cbx조회기준적용.CheckedChanged += new System.EventHandler(this.Cbx조회기준적용_CheckedChanged);
            // 
            // dtp조회기준일
            // 
            this.dtp조회기준일.CustomFormat = "yyyy-MM-dd";
            this.dtp조회기준일.Enabled = false;
            this.dtp조회기준일.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp조회기준일.Location = new System.Drawing.Point(573, 7);
            this.dtp조회기준일.Name = "dtp조회기준일";
            this.dtp조회기준일.Size = new System.Drawing.Size(114, 21);
            this.dtp조회기준일.TabIndex = 112;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label12.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(436, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(123, 22);
            this.label12.TabIndex = 111;
            this.label12.Text = "조회기준일 적용";
            // 
            // txb사업장명
            // 
            this.txb사업장명.Location = new System.Drawing.Point(215, 7);
            this.txb사업장명.Name = "txb사업장명";
            this.txb사업장명.Size = new System.Drawing.Size(137, 21);
            this.txb사업장명.TabIndex = 110;
            // 
            // cbb사업장코드
            // 
            this.cbb사업장코드.DataSource = this.사업장등록BindingSource;
            this.cbb사업장코드.DisplayMember = "사업장코드";
            this.cbb사업장코드.Font = new System.Drawing.Font("굴림", 10F);
            this.cbb사업장코드.FormattingEnabled = true;
            this.cbb사업장코드.Location = new System.Drawing.Point(102, 7);
            this.cbb사업장코드.Name = "cbb사업장코드";
            this.cbb사업장코드.Size = new System.Drawing.Size(107, 21);
            this.cbb사업장코드.TabIndex = 109;
            this.cbb사업장코드.ValueMember = "사업장코드";
            this.cbb사업장코드.SelectedValueChanged += new System.EventHandler(this.Cbb사업장코드_SelectedValueChanged);
            // 
            // 사업장등록BindingSource
            // 
            this.사업장등록BindingSource.DataSource = typeof(ClassLibrary.사업장등록);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(49, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 22);
            this.label2.TabIndex = 108;
            this.label2.Text = "사업장";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("굴림체", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(55, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 25);
            this.label8.TabIndex = 97;
            this.label8.Text = "부서등록";
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Location = new System.Drawing.Point(7, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(1018, 1);
            this.label9.TabIndex = 94;
            // 
            // 부서코드
            // 
            this.부서코드.DataPropertyName = "부서코드";
            this.부서코드.HeaderText = "부서코드";
            this.부서코드.Name = "부서코드";
            // 
            // 부서명
            // 
            this.부서명.DataPropertyName = "부서명";
            this.부서명.HeaderText = "부서명";
            this.부서명.Name = "부서명";
            // 
            // 사업장코드
            // 
            this.사업장코드.DataPropertyName = "사업장코드";
            this.사업장코드.HeaderText = "사업장코드";
            this.사업장코드.Name = "사업장코드";
            // 
            // 사업장명
            // 
            this.사업장명.DataPropertyName = "사업장명";
            this.사업장명.HeaderText = "사업장명";
            this.사업장명.Name = "사업장명";
            // 
            // 부문코드
            // 
            this.부문코드.DataPropertyName = "부문코드";
            this.부문코드.HeaderText = "부문코드";
            this.부문코드.Name = "부문코드";
            // 
            // 부문명
            // 
            this.부문명.DataPropertyName = "부문명";
            this.부문명.HeaderText = "부문명";
            this.부문명.Name = "부문명";
            // 
            // 사용시작기간
            // 
            this.사용시작기간.DataPropertyName = "사용시작기간";
            this.사용시작기간.HeaderText = "사용시작기간";
            this.사용시작기간.Name = "사용시작기간";
            // 
            // 사용종료기간
            // 
            this.사용종료기간.DataPropertyName = "사용종료기간";
            this.사용종료기간.HeaderText = "사용종료기간";
            this.사용종료기간.Name = "사용종료기간";
            // 
            // 부서등록
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "부서등록";
            this.Size = new System.Drawing.Size(1044, 645);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv부서)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.부서등록BindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.사업장등록BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbx조회기준적용;
        private System.Windows.Forms.DateTimePicker dtp조회기준일;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txb사업장명;
        private System.Windows.Forms.ComboBox cbb사업장코드;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgv부서;
        private System.Windows.Forms.BindingSource 사업장등록BindingSource;
        private System.Windows.Forms.BindingSource 부서등록BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn 부서코드;
        private System.Windows.Forms.DataGridViewTextBoxColumn 부서명;
        private System.Windows.Forms.DataGridViewTextBoxColumn 사업장코드;
        private System.Windows.Forms.DataGridViewTextBoxColumn 사업장명;
        private System.Windows.Forms.DataGridViewTextBoxColumn 부문코드;
        private System.Windows.Forms.DataGridViewTextBoxColumn 부문명;
        private System.Windows.Forms.DataGridViewTextBoxColumn 사용시작기간;
        private System.Windows.Forms.DataGridViewTextBoxColumn 사용종료기간;
    }
}
