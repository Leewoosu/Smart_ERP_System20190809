namespace SMART_ERP_System.MainForm_Control
{
    partial class 사업장구분Control
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
            this.dgv사업장 = new System.Windows.Forms.DataGridView();
            this.사업장등록BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.사업장코드 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.사업장명 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv사업장)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.사업장등록BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv사업장);
            this.panel1.Location = new System.Drawing.Point(3, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 346);
            this.panel1.TabIndex = 1;
            // 
            // dgv사업장
            // 
            this.dgv사업장.AllowUserToResizeRows = false;
            this.dgv사업장.AutoGenerateColumns = false;
            this.dgv사업장.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv사업장.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.사업장코드,
            this.사업장명});
            this.dgv사업장.DataSource = this.사업장등록BindingSource;
            this.dgv사업장.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv사업장.Location = new System.Drawing.Point(0, 0);
            this.dgv사업장.Name = "dgv사업장";
            this.dgv사업장.RowHeadersVisible = false;
            this.dgv사업장.RowTemplate.Height = 23;
            this.dgv사업장.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv사업장.Size = new System.Drawing.Size(290, 346);
            this.dgv사업장.TabIndex = 8;
            this.dgv사업장.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv사업장_CellDoubleClick);
            this.dgv사업장.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Dgv사업장_KeyDown);
            // 
            // 사업장등록BindingSource
            // 
            this.사업장등록BindingSource.DataSource = typeof(ClassLibrary.사업장등록);
            // 
            // 사업장코드
            // 
            this.사업장코드.DataPropertyName = "사업장코드";
            this.사업장코드.HeaderText = "사업장코드";
            this.사업장코드.Name = "사업장코드";
            // 
            // 사업장명
            // 
            this.사업장명.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.사업장명.DataPropertyName = "사업장명";
            this.사업장명.HeaderText = "사업장명";
            this.사업장명.Name = "사업장명";
            // 
            // 사업장구분Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "사업장구분Control";
            this.Size = new System.Drawing.Size(296, 366);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv사업장)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.사업장등록BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DataGridView dgv사업장;
        private System.Windows.Forms.BindingSource 사업장등록BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn 사업장코드;
        private System.Windows.Forms.DataGridViewTextBoxColumn 사업장명;
    }
}
