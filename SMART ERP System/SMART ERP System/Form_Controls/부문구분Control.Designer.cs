namespace SMART_ERP_System.MainForm_Control
{
    partial class 부문구분Control
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
            this.dgv부문 = new System.Windows.Forms.DataGridView();
            this.btnRegist = new System.Windows.Forms.Button();
            this.부문등록BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.부문코드DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.부문명DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.사용시작기간DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.사용종료기간DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv부문)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.부문등록BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv부문);
            this.panel1.Location = new System.Drawing.Point(3, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 340);
            this.panel1.TabIndex = 0;
            // 
            // dgv부문
            // 
            this.dgv부문.AllowUserToResizeRows = false;
            this.dgv부문.AutoGenerateColumns = false;
            this.dgv부문.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv부문.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.부문코드DataGridViewTextBoxColumn,
            this.부문명DataGridViewTextBoxColumn,
            this.사용시작기간DataGridViewTextBoxColumn,
            this.사용종료기간DataGridViewTextBoxColumn});
            this.dgv부문.DataSource = this.부문등록BindingSource;
            this.dgv부문.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv부문.Location = new System.Drawing.Point(0, 0);
            this.dgv부문.Name = "dgv부문";
            this.dgv부문.RowHeadersVisible = false;
            this.dgv부문.RowTemplate.Height = 23;
            this.dgv부문.Size = new System.Drawing.Size(404, 340);
            this.dgv부문.TabIndex = 8;
            this.dgv부문.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv부문_CellDoubleClick);
            this.dgv부문.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv부문_CellEndEdit);
            this.dgv부문.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Dgv부문_KeyDown);
            // 
            // btnRegist
            // 
            this.btnRegist.Location = new System.Drawing.Point(317, 0);
            this.btnRegist.Name = "btnRegist";
            this.btnRegist.Size = new System.Drawing.Size(75, 31);
            this.btnRegist.TabIndex = 1;
            this.btnRegist.Text = "부문등록";
            this.btnRegist.UseVisualStyleBackColor = true;
            this.btnRegist.Click += new System.EventHandler(this.BtnRegist_Click);
            // 
            // 부문등록BindingSource
            // 
            this.부문등록BindingSource.DataSource = typeof(ClassLibrary.부문등록);
            // 
            // 부문코드DataGridViewTextBoxColumn
            // 
            this.부문코드DataGridViewTextBoxColumn.DataPropertyName = "부문코드";
            this.부문코드DataGridViewTextBoxColumn.HeaderText = "부문코드";
            this.부문코드DataGridViewTextBoxColumn.Name = "부문코드DataGridViewTextBoxColumn";
            // 
            // 부문명DataGridViewTextBoxColumn
            // 
            this.부문명DataGridViewTextBoxColumn.DataPropertyName = "부문명";
            this.부문명DataGridViewTextBoxColumn.HeaderText = "부문명";
            this.부문명DataGridViewTextBoxColumn.Name = "부문명DataGridViewTextBoxColumn";
            // 
            // 사용시작기간DataGridViewTextBoxColumn
            // 
            this.사용시작기간DataGridViewTextBoxColumn.DataPropertyName = "사용시작기간";
            this.사용시작기간DataGridViewTextBoxColumn.HeaderText = "사용시작기간";
            this.사용시작기간DataGridViewTextBoxColumn.Name = "사용시작기간DataGridViewTextBoxColumn";
            // 
            // 사용종료기간DataGridViewTextBoxColumn
            // 
            this.사용종료기간DataGridViewTextBoxColumn.DataPropertyName = "사용종료기간";
            this.사용종료기간DataGridViewTextBoxColumn.HeaderText = "사용종료기간";
            this.사용종료기간DataGridViewTextBoxColumn.Name = "사용종료기간DataGridViewTextBoxColumn";
            // 
            // 부문구분Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRegist);
            this.Controls.Add(this.panel1);
            this.Name = "부문구분Control";
            this.Size = new System.Drawing.Size(410, 380);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv부문)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.부문등록BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DataGridView dgv부문;
        private System.Windows.Forms.BindingSource 부문등록BindingSource;
        private System.Windows.Forms.Button btnRegist;
        private System.Windows.Forms.DataGridViewTextBoxColumn 부문코드DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 부문명DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 사용시작기간DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 사용종료기간DataGridViewTextBoxColumn;
    }
}
