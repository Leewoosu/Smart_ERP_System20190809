namespace SMART_ERP_System.MainForm_Control
{
    partial class 관할세무서구분Control
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv관할세무서 = new System.Windows.Forms.DataGridView();
            this.관할세무서BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.관할세무서코드DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.관할세무서명DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv관할세무서)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.관할세무서BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv관할세무서);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 340);
            this.panel1.TabIndex = 2;
            // 
            // dgv관할세무서
            // 
            this.dgv관할세무서.AllowUserToAddRows = false;
            this.dgv관할세무서.AllowUserToDeleteRows = false;
            this.dgv관할세무서.AllowUserToResizeRows = false;
            this.dgv관할세무서.AutoGenerateColumns = false;
            this.dgv관할세무서.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv관할세무서.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.관할세무서코드DataGridViewTextBoxColumn,
            this.관할세무서명DataGridViewTextBoxColumn});
            this.dgv관할세무서.DataSource = this.관할세무서BindingSource;
            this.dgv관할세무서.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv관할세무서.Location = new System.Drawing.Point(0, 0);
            this.dgv관할세무서.Name = "dgv관할세무서";
            this.dgv관할세무서.ReadOnly = true;
            this.dgv관할세무서.RowHeadersVisible = false;
            this.dgv관할세무서.RowTemplate.Height = 23;
            this.dgv관할세무서.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv관할세무서.Size = new System.Drawing.Size(250, 340);
            this.dgv관할세무서.TabIndex = 8;
            this.dgv관할세무서.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv관할세무서_CellDoubleClick);
            this.dgv관할세무서.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Dgv관할세무서_KeyDown);
            // 
            // 관할세무서BindingSource
            // 
            this.관할세무서BindingSource.DataSource = typeof(ClassLibrary.관할세무서);
            // 
            // 관할세무서코드DataGridViewTextBoxColumn
            // 
            this.관할세무서코드DataGridViewTextBoxColumn.DataPropertyName = "관할세무서코드";
            this.관할세무서코드DataGridViewTextBoxColumn.HeaderText = "코드";
            this.관할세무서코드DataGridViewTextBoxColumn.Name = "관할세무서코드DataGridViewTextBoxColumn";
            // 
            // 관할세무서명DataGridViewTextBoxColumn
            // 
            this.관할세무서명DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.관할세무서명DataGridViewTextBoxColumn.DataPropertyName = "관할세무서명";
            this.관할세무서명DataGridViewTextBoxColumn.HeaderText = "세무서명";
            this.관할세무서명DataGridViewTextBoxColumn.Name = "관할세무서명DataGridViewTextBoxColumn";
            // 
            // 관할세무서구분Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "관할세무서구분Control";
            this.Size = new System.Drawing.Size(250, 340);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv관할세무서)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.관할세무서BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DataGridView dgv관할세무서;
        private System.Windows.Forms.DataGridViewTextBoxColumn 관할세무서코드DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 관할세무서명DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource 관할세무서BindingSource;
    }
}
