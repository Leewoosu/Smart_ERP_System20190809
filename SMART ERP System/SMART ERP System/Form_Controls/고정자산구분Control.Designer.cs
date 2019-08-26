﻿namespace SMART_ERP_System.MainForm_Control
{
    partial class 고정자산구분Control
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
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv고정자산List = new System.Windows.Forms.DataGridView();
            this.고정자산과목코드DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.고정자산과목명DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.고정자산계정과목BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv고정자산List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.고정자산계정과목BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
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
            this.splitContainer.Panel2.Controls.Add(this.dgv고정자산List);
            this.splitContainer.Size = new System.Drawing.Size(316, 380);
            this.splitContainer.SplitterDistance = 43;
            this.splitContainer.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txbSearch);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 43);
            this.groupBox1.TabIndex = 7;
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
            // dgv고정자산List
            // 
            this.dgv고정자산List.AllowUserToAddRows = false;
            this.dgv고정자산List.AllowUserToDeleteRows = false;
            this.dgv고정자산List.AutoGenerateColumns = false;
            this.dgv고정자산List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv고정자산List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.고정자산과목코드DataGridViewTextBoxColumn,
            this.고정자산과목명DataGridViewTextBoxColumn});
            this.dgv고정자산List.DataSource = this.고정자산계정과목BindingSource;
            this.dgv고정자산List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv고정자산List.Location = new System.Drawing.Point(0, 0);
            this.dgv고정자산List.Name = "dgv고정자산List";
            this.dgv고정자산List.ReadOnly = true;
            this.dgv고정자산List.RowHeadersVisible = false;
            this.dgv고정자산List.RowTemplate.Height = 23;
            this.dgv고정자산List.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv고정자산List.Size = new System.Drawing.Size(316, 333);
            this.dgv고정자산List.TabIndex = 7;
            this.dgv고정자산List.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv고정자산List_CellDoubleClick);
            this.dgv고정자산List.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.Dgv고정자산List_RowPostPaint);
            this.dgv고정자산List.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Dgv고정자산List_KeyDown);
            // 
            // 고정자산과목코드DataGridViewTextBoxColumn
            // 
            this.고정자산과목코드DataGridViewTextBoxColumn.DataPropertyName = "고정자산과목코드";
            this.고정자산과목코드DataGridViewTextBoxColumn.HeaderText = "코드";
            this.고정자산과목코드DataGridViewTextBoxColumn.Name = "고정자산과목코드DataGridViewTextBoxColumn";
            this.고정자산과목코드DataGridViewTextBoxColumn.ReadOnly = true;
            this.고정자산과목코드DataGridViewTextBoxColumn.Width = 120;
            // 
            // 고정자산과목명DataGridViewTextBoxColumn
            // 
            this.고정자산과목명DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.고정자산과목명DataGridViewTextBoxColumn.DataPropertyName = "고정자산과목명";
            this.고정자산과목명DataGridViewTextBoxColumn.HeaderText = "고정자산명";
            this.고정자산과목명DataGridViewTextBoxColumn.Name = "고정자산과목명DataGridViewTextBoxColumn";
            this.고정자산과목명DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 고정자산계정과목BindingSource
            // 
            this.고정자산계정과목BindingSource.DataSource = typeof(ClassLibrary.고정자산계정과목);
            // 
            // 고정자산구분Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer);
            this.Name = "고정자산구분Control";
            this.Size = new System.Drawing.Size(316, 380);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv고정자산List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.고정자산계정과목BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbSearch;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dgv고정자산List;
        private System.Windows.Forms.DataGridViewTextBoxColumn 고정자산과목코드DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 고정자산과목명DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource 고정자산계정과목BindingSource;
    }
}
