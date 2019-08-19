namespace SMART_ERP_System.MainForm_Control
{
    partial class 계정합계Control
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
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbb전표유형 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbb전표상태 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgv전표리스트 = new System.Windows.Forms.DataGridView();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl건수총계 = new System.Windows.Forms.Label();
            this.lbl구분 = new System.Windows.Forms.Label();
            this.lbl차변합계 = new System.Windows.Forms.Label();
            this.lbl대변합계 = new System.Windows.Forms.Label();
            this.계정과목코드번호DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.계정과목명DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.건수DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.구분DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.차변합계DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.대변합계DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.전표리스트BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv전표리스트)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.전표리스트BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.splitContainer1);
            this.splitContainer.Size = new System.Drawing.Size(583, 380);
            this.splitContainer.SplitterDistance = 85;
            this.splitContainer.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dtpTo);
            this.groupBox1.Controls.Add(this.dtpFrom);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.cbb전표유형);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbb전표상태);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(583, 85);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // dtpTo
            // 
            this.dtpTo.CustomFormat = "yyyy-MM-dd";
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(425, 20);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(105, 22);
            this.dtpTo.TabIndex = 167;
            this.dtpTo.Value = new System.DateTime(2019, 12, 31, 16, 26, 0, 0);
            this.dtpTo.ValueChanged += new System.EventHandler(this.DtpTo_ValueChanged);
            // 
            // dtpFrom
            // 
            this.dtpFrom.CustomFormat = "yyyy-MM-dd";
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(282, 20);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(105, 22);
            this.dtpFrom.TabIndex = 166;
            this.dtpFrom.Value = new System.DateTime(2019, 1, 1, 16, 4, 0, 0);
            this.dtpFrom.ValueChanged += new System.EventHandler(this.DtpFrom_ValueChanged);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(397, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 26);
            this.label3.TabIndex = 165;
            this.label3.Text = "~";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(212, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 22);
            this.label4.TabIndex = 164;
            this.label4.Text = "결의기간";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(443, 50);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 23);
            this.btnCancel.TabIndex = 163;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(344, 50);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(87, 23);
            this.btnSearch.TabIndex = 113;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // cbb전표유형
            // 
            this.cbb전표유형.FormattingEnabled = true;
            this.cbb전표유형.Location = new System.Drawing.Point(92, 52);
            this.cbb전표유형.Name = "cbb전표유형";
            this.cbb전표유형.Size = new System.Drawing.Size(75, 21);
            this.cbb전표유형.TabIndex = 3;
            this.cbb전표유형.SelectedValueChanged += new System.EventHandler(this.Cbb전표유형_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.Location = new System.Drawing.Point(21, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "전표유형";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbb전표상태
            // 
            this.cbb전표상태.FormattingEnabled = true;
            this.cbb전표상태.Location = new System.Drawing.Point(92, 20);
            this.cbb전표상태.Name = "cbb전표상태";
            this.cbb전표상태.Size = new System.Drawing.Size(75, 21);
            this.cbb전표상태.TabIndex = 1;
            this.cbb전표상태.SelectedValueChanged += new System.EventHandler(this.Cbb전표상태_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "전표상태";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgv전표리스트);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(583, 291);
            this.splitContainer1.SplitterDistance = 258;
            this.splitContainer1.TabIndex = 8;
            // 
            // dgv전표리스트
            // 
            this.dgv전표리스트.AllowUserToAddRows = false;
            this.dgv전표리스트.AllowUserToDeleteRows = false;
            this.dgv전표리스트.AutoGenerateColumns = false;
            this.dgv전표리스트.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv전표리스트.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv전표리스트.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.계정과목코드번호DataGridViewTextBoxColumn,
            this.계정과목명DataGridViewTextBoxColumn,
            this.건수DataGridViewTextBoxColumn,
            this.구분DataGridViewTextBoxColumn,
            this.차변합계DataGridViewTextBoxColumn,
            this.대변합계DataGridViewTextBoxColumn});
            this.dgv전표리스트.DataSource = this.전표리스트BindingSource;
            this.dgv전표리스트.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv전표리스트.Location = new System.Drawing.Point(0, 0);
            this.dgv전표리스트.Name = "dgv전표리스트";
            this.dgv전표리스트.ReadOnly = true;
            this.dgv전표리스트.RowHeadersVisible = false;
            this.dgv전표리스트.RowTemplate.Height = 23;
            this.dgv전표리스트.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv전표리스트.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv전표리스트.Size = new System.Drawing.Size(583, 258);
            this.dgv전표리스트.TabIndex = 8;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.label5);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(583, 29);
            this.splitContainer2.SplitterDistance = 205;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.lbl건수총계);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer3.Size = new System.Drawing.Size(374, 29);
            this.splitContainer3.SplitterDistance = 61;
            this.splitContainer3.TabIndex = 0;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.lbl구분);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.splitContainer5);
            this.splitContainer4.Size = new System.Drawing.Size(309, 29);
            this.splitContainer4.SplitterDistance = 67;
            this.splitContainer4.TabIndex = 0;
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer5.Location = new System.Drawing.Point(0, 0);
            this.splitContainer5.Name = "splitContainer5";
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.lbl차변합계);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.lbl대변합계);
            this.splitContainer5.Size = new System.Drawing.Size(238, 29);
            this.splitContainer5.SplitterDistance = 116;
            this.splitContainer5.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.LightBlue;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "합계";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl건수총계
            // 
            this.lbl건수총계.BackColor = System.Drawing.Color.LightBlue;
            this.lbl건수총계.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl건수총계.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl건수총계.Location = new System.Drawing.Point(0, 0);
            this.lbl건수총계.Name = "lbl건수총계";
            this.lbl건수총계.Size = new System.Drawing.Size(61, 29);
            this.lbl건수총계.TabIndex = 1;
            this.lbl건수총계.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl구분
            // 
            this.lbl구분.BackColor = System.Drawing.Color.LightBlue;
            this.lbl구분.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl구분.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl구분.Location = new System.Drawing.Point(0, 0);
            this.lbl구분.Name = "lbl구분";
            this.lbl구분.Size = new System.Drawing.Size(67, 29);
            this.lbl구분.TabIndex = 1;
            this.lbl구분.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl차변합계
            // 
            this.lbl차변합계.BackColor = System.Drawing.Color.LightBlue;
            this.lbl차변합계.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl차변합계.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl차변합계.Location = new System.Drawing.Point(0, 0);
            this.lbl차변합계.Name = "lbl차변합계";
            this.lbl차변합계.Size = new System.Drawing.Size(116, 29);
            this.lbl차변합계.TabIndex = 1;
            this.lbl차변합계.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl대변합계
            // 
            this.lbl대변합계.BackColor = System.Drawing.Color.LightBlue;
            this.lbl대변합계.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl대변합계.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl대변합계.Location = new System.Drawing.Point(0, 0);
            this.lbl대변합계.Name = "lbl대변합계";
            this.lbl대변합계.Size = new System.Drawing.Size(118, 29);
            this.lbl대변합계.TabIndex = 1;
            this.lbl대변합계.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // 계정과목코드번호DataGridViewTextBoxColumn
            // 
            this.계정과목코드번호DataGridViewTextBoxColumn.DataPropertyName = "계정과목코드번호";
            this.계정과목코드번호DataGridViewTextBoxColumn.HeaderText = "코드";
            this.계정과목코드번호DataGridViewTextBoxColumn.Name = "계정과목코드번호DataGridViewTextBoxColumn";
            this.계정과목코드번호DataGridViewTextBoxColumn.ReadOnly = true;
            this.계정과목코드번호DataGridViewTextBoxColumn.Width = 90;
            // 
            // 계정과목명DataGridViewTextBoxColumn
            // 
            this.계정과목명DataGridViewTextBoxColumn.DataPropertyName = "계정과목명";
            this.계정과목명DataGridViewTextBoxColumn.HeaderText = "계정과목명";
            this.계정과목명DataGridViewTextBoxColumn.Name = "계정과목명DataGridViewTextBoxColumn";
            this.계정과목명DataGridViewTextBoxColumn.ReadOnly = true;
            this.계정과목명DataGridViewTextBoxColumn.Width = 120;
            // 
            // 건수DataGridViewTextBoxColumn
            // 
            this.건수DataGridViewTextBoxColumn.DataPropertyName = "건수";
            this.건수DataGridViewTextBoxColumn.HeaderText = "건수";
            this.건수DataGridViewTextBoxColumn.Name = "건수DataGridViewTextBoxColumn";
            this.건수DataGridViewTextBoxColumn.ReadOnly = true;
            this.건수DataGridViewTextBoxColumn.Width = 60;
            // 
            // 구분DataGridViewTextBoxColumn
            // 
            this.구분DataGridViewTextBoxColumn.DataPropertyName = "구분";
            this.구분DataGridViewTextBoxColumn.HeaderText = "구분";
            this.구분DataGridViewTextBoxColumn.Name = "구분DataGridViewTextBoxColumn";
            this.구분DataGridViewTextBoxColumn.ReadOnly = true;
            this.구분DataGridViewTextBoxColumn.Width = 70;
            // 
            // 차변합계DataGridViewTextBoxColumn
            // 
            this.차변합계DataGridViewTextBoxColumn.DataPropertyName = "차변합계";
            this.차변합계DataGridViewTextBoxColumn.HeaderText = "차변";
            this.차변합계DataGridViewTextBoxColumn.Name = "차변합계DataGridViewTextBoxColumn";
            this.차변합계DataGridViewTextBoxColumn.ReadOnly = true;
            this.차변합계DataGridViewTextBoxColumn.Width = 120;
            // 
            // 대변합계DataGridViewTextBoxColumn
            // 
            this.대변합계DataGridViewTextBoxColumn.DataPropertyName = "대변합계";
            this.대변합계DataGridViewTextBoxColumn.HeaderText = "대변";
            this.대변합계DataGridViewTextBoxColumn.Name = "대변합계DataGridViewTextBoxColumn";
            this.대변합계DataGridViewTextBoxColumn.ReadOnly = true;
            this.대변합계DataGridViewTextBoxColumn.Width = 120;
            // 
            // 전표리스트BindingSource
            // 
            this.전표리스트BindingSource.DataSource = typeof(ClassLibrary.전표리스트);
            // 
            // 계정합계Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer);
            this.Name = "계정합계Control";
            this.Size = new System.Drawing.Size(583, 380);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv전표리스트)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.전표리스트BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbb전표유형;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbb전표상태;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnSearch;
        public System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.BindingSource 전표리스트BindingSource;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.SplitContainer splitContainer1;
        public System.Windows.Forms.DataGridView dgv전표리스트;
        private System.Windows.Forms.DataGridViewTextBoxColumn 계정과목코드번호DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 계정과목명DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 건수DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 구분DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 차변합계DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 대변합계DataGridViewTextBoxColumn;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl건수총계;
        private System.Windows.Forms.Label lbl구분;
        private System.Windows.Forms.Label lbl차변합계;
        private System.Windows.Forms.Label lbl대변합계;
    }
}
