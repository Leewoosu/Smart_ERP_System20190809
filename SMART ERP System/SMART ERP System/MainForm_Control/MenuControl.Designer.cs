namespace SMART_ERP_System.MainForm_Control
{
    partial class MenuControl
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
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.계정과목코드번호DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.계정과목명DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.계정과목BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.계정과목BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txbSearch);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 46);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txbSearch
            // 
            this.txbSearch.Location = new System.Drawing.Point(74, 12);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(221, 22);
            this.txbSearch.TabIndex = 1;
            this.txbSearch.TextChanged += new System.EventHandler(this.TxbSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "검색";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.AutoGenerateColumns = false;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.계정과목코드번호DataGridViewTextBoxColumn,
            this.계정과목명DataGridViewTextBoxColumn});
            this.dgvList.DataSource = this.계정과목BindingSource;
            this.dgvList.Location = new System.Drawing.Point(3, 55);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.RowHeadersVisible = false;
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(311, 328);
            this.dgvList.TabIndex = 1;
            this.dgvList.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DgvList_RowPostPaint);
            // 
            // 계정과목코드번호DataGridViewTextBoxColumn
            // 
            this.계정과목코드번호DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.계정과목코드번호DataGridViewTextBoxColumn.DataPropertyName = "계정과목코드번호";
            this.계정과목코드번호DataGridViewTextBoxColumn.HeaderText = "계정과목코드";
            this.계정과목코드번호DataGridViewTextBoxColumn.Name = "계정과목코드번호DataGridViewTextBoxColumn";
            this.계정과목코드번호DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 계정과목명DataGridViewTextBoxColumn
            // 
            this.계정과목명DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.계정과목명DataGridViewTextBoxColumn.DataPropertyName = "계정과목명";
            this.계정과목명DataGridViewTextBoxColumn.HeaderText = "계정과목명";
            this.계정과목명DataGridViewTextBoxColumn.Name = "계정과목명DataGridViewTextBoxColumn";
            this.계정과목명DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 계정과목BindingSource
            // 
            this.계정과목BindingSource.DataSource = typeof(ClassLibrary.계정과목);
            // 
            // MenuControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.groupBox1);
            this.Name = "MenuControl";
            this.Size = new System.Drawing.Size(317, 386);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.계정과목BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.DataGridViewTextBoxColumn 계정과목코드번호DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 계정과목명DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource 계정과목BindingSource;
    }
}
