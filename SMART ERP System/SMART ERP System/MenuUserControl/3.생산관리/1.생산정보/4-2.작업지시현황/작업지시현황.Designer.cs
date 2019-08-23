namespace SMART_ERP_System.MenuUserControl
{
    partial class 작업지시현황
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.작업지시번호DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.생산계획현황번호DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.제품번호DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.수량DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.작업장번호DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.작업상태번호DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.작업지시일DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.작업완료예정일DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.자재명세번호DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.상태DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtp작업지시일2 = new System.Windows.Forms.DateTimePicker();
            this.dtp작업지시일1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbb사원코드 = new System.Windows.Forms.ComboBox();
            this.txb사원명 = new System.Windows.Forms.TextBox();
            this.cbb부서코드 = new System.Windows.Forms.ComboBox();
            this.txb품번 = new System.Windows.Forms.TextBox();
            this.txb지시번호 = new System.Windows.Forms.TextBox();
            this.txb부서명 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn조회 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.작업지시현황BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.작업지시현황BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.작업지시번호DataGridViewTextBoxColumn,
            this.생산계획현황번호DataGridViewTextBoxColumn,
            this.제품번호DataGridViewTextBoxColumn,
            this.수량DataGridViewTextBoxColumn,
            this.작업장번호DataGridViewTextBoxColumn,
            this.작업상태번호DataGridViewTextBoxColumn,
            this.작업지시일DataGridViewTextBoxColumn,
            this.작업완료예정일DataGridViewTextBoxColumn,
            this.자재명세번호DataGridViewTextBoxColumn,
            this.상태DataGridViewTextBoxColumn});
            this.dataGridView1.Location = new System.Drawing.Point(-17, 158);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1018, 332);
            this.dataGridView1.TabIndex = 0;
            // 
            // 작업지시번호DataGridViewTextBoxColumn
            // 
            this.작업지시번호DataGridViewTextBoxColumn.DataPropertyName = "작업지시번호";
            this.작업지시번호DataGridViewTextBoxColumn.HeaderText = "작업지시번호";
            this.작업지시번호DataGridViewTextBoxColumn.Name = "작업지시번호DataGridViewTextBoxColumn";
            // 
            // 생산계획현황번호DataGridViewTextBoxColumn
            // 
            this.생산계획현황번호DataGridViewTextBoxColumn.DataPropertyName = "생산계획현황번호";
            this.생산계획현황번호DataGridViewTextBoxColumn.HeaderText = "생산계획현황번호";
            this.생산계획현황번호DataGridViewTextBoxColumn.Name = "생산계획현황번호DataGridViewTextBoxColumn";
            // 
            // 제품번호DataGridViewTextBoxColumn
            // 
            this.제품번호DataGridViewTextBoxColumn.DataPropertyName = "제품번호";
            this.제품번호DataGridViewTextBoxColumn.HeaderText = "제품번호";
            this.제품번호DataGridViewTextBoxColumn.Name = "제품번호DataGridViewTextBoxColumn";
            // 
            // 수량DataGridViewTextBoxColumn
            // 
            this.수량DataGridViewTextBoxColumn.DataPropertyName = "수량";
            this.수량DataGridViewTextBoxColumn.HeaderText = "수량";
            this.수량DataGridViewTextBoxColumn.Name = "수량DataGridViewTextBoxColumn";
            // 
            // 작업장번호DataGridViewTextBoxColumn
            // 
            this.작업장번호DataGridViewTextBoxColumn.DataPropertyName = "작업장번호";
            this.작업장번호DataGridViewTextBoxColumn.HeaderText = "작업장번호";
            this.작업장번호DataGridViewTextBoxColumn.Name = "작업장번호DataGridViewTextBoxColumn";
            // 
            // 작업상태번호DataGridViewTextBoxColumn
            // 
            this.작업상태번호DataGridViewTextBoxColumn.DataPropertyName = "작업상태번호";
            this.작업상태번호DataGridViewTextBoxColumn.HeaderText = "작업상태번호";
            this.작업상태번호DataGridViewTextBoxColumn.Name = "작업상태번호DataGridViewTextBoxColumn";
            // 
            // 작업지시일DataGridViewTextBoxColumn
            // 
            this.작업지시일DataGridViewTextBoxColumn.DataPropertyName = "작업지시일";
            this.작업지시일DataGridViewTextBoxColumn.HeaderText = "작업지시일";
            this.작업지시일DataGridViewTextBoxColumn.Name = "작업지시일DataGridViewTextBoxColumn";
            // 
            // 작업완료예정일DataGridViewTextBoxColumn
            // 
            this.작업완료예정일DataGridViewTextBoxColumn.DataPropertyName = "작업완료_예정_일";
            this.작업완료예정일DataGridViewTextBoxColumn.HeaderText = "작업완료_예정_일";
            this.작업완료예정일DataGridViewTextBoxColumn.Name = "작업완료예정일DataGridViewTextBoxColumn";
            // 
            // 자재명세번호DataGridViewTextBoxColumn
            // 
            this.자재명세번호DataGridViewTextBoxColumn.DataPropertyName = "자재명세번호";
            this.자재명세번호DataGridViewTextBoxColumn.HeaderText = "자재명세번호";
            this.자재명세번호DataGridViewTextBoxColumn.Name = "자재명세번호DataGridViewTextBoxColumn";
            // 
            // 상태DataGridViewTextBoxColumn
            // 
            this.상태DataGridViewTextBoxColumn.DataPropertyName = "상태";
            this.상태DataGridViewTextBoxColumn.HeaderText = "상태";
            this.상태DataGridViewTextBoxColumn.Name = "상태DataGridViewTextBoxColumn";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.dtp작업지시일2);
            this.groupBox1.Controls.Add(this.dtp작업지시일1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbb사원코드);
            this.groupBox1.Controls.Add(this.txb사원명);
            this.groupBox1.Controls.Add(this.cbb부서코드);
            this.groupBox1.Controls.Add(this.txb품번);
            this.groupBox1.Controls.Add(this.txb지시번호);
            this.groupBox1.Controls.Add(this.txb부서명);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(7, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1018, 117);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // dtp작업지시일2
            // 
            this.dtp작업지시일2.Location = new System.Drawing.Point(293, 79);
            this.dtp작업지시일2.Name = "dtp작업지시일2";
            this.dtp작업지시일2.Size = new System.Drawing.Size(117, 21);
            this.dtp작업지시일2.TabIndex = 53;
            // 
            // dtp작업지시일1
            // 
            this.dtp작업지시일1.Location = new System.Drawing.Point(170, 79);
            this.dtp작업지시일1.Name = "dtp작업지시일1";
            this.dtp작업지시일1.Size = new System.Drawing.Size(117, 21);
            this.dtp작업지시일1.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(553, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 11);
            this.label3.TabIndex = 20;
            this.label3.Text = "사원";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(114, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 11);
            this.label4.TabIndex = 20;
            this.label4.Text = "부서";
            // 
            // cbb사원코드
            // 
            this.cbb사원코드.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbb사원코드.FormattingEnabled = true;
            this.cbb사원코드.Location = new System.Drawing.Point(586, 16);
            this.cbb사원코드.Name = "cbb사원코드";
            this.cbb사원코드.Size = new System.Drawing.Size(100, 19);
            this.cbb사원코드.TabIndex = 52;
            this.cbb사원코드.Text = "사원코드";
            // 
            // txb사원명
            // 
            this.txb사원명.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txb사원명.Location = new System.Drawing.Point(692, 17);
            this.txb사원명.Name = "txb사원명";
            this.txb사원명.Size = new System.Drawing.Size(100, 20);
            this.txb사원명.TabIndex = 51;
            // 
            // cbb부서코드
            // 
            this.cbb부서코드.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbb부서코드.FormattingEnabled = true;
            this.cbb부서코드.Location = new System.Drawing.Point(170, 16);
            this.cbb부서코드.Name = "cbb부서코드";
            this.cbb부서코드.Size = new System.Drawing.Size(100, 19);
            this.cbb부서코드.TabIndex = 50;
            this.cbb부서코드.Text = "부서코드";
            this.cbb부서코드.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txb품번
            // 
            this.txb품번.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txb품번.Location = new System.Drawing.Point(586, 48);
            this.txb품번.Name = "txb품번";
            this.txb품번.Size = new System.Drawing.Size(100, 20);
            this.txb품번.TabIndex = 37;
            // 
            // txb지시번호
            // 
            this.txb지시번호.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txb지시번호.Location = new System.Drawing.Point(170, 48);
            this.txb지시번호.Name = "txb지시번호";
            this.txb지시번호.Size = new System.Drawing.Size(100, 20);
            this.txb지시번호.TabIndex = 36;
            // 
            // txb부서명
            // 
            this.txb부서명.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txb부서명.Location = new System.Drawing.Point(276, 17);
            this.txb부서명.Name = "txb부서명";
            this.txb부서명.Size = new System.Drawing.Size(100, 20);
            this.txb부서명.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(88, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 11);
            this.label8.TabIndex = 31;
            this.label8.Text = "작업지시일";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(553, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 11);
            this.label6.TabIndex = 29;
            this.label6.Text = "품번";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(92, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 11);
            this.label5.TabIndex = 28;
            this.label5.Text = "지시번호";
            // 
            // btn조회
            // 
            this.btn조회.Location = new System.Drawing.Point(937, 0);
            this.btn조회.Name = "btn조회";
            this.btn조회.Size = new System.Drawing.Size(51, 26);
            this.btn조회.TabIndex = 44;
            this.btn조회.Text = "조회";
            this.btn조회.UseVisualStyleBackColor = true;
            this.btn조회.Click += new System.EventHandler(this.btn조회_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.CausesValidation = false;
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1018, 1);
            this.label1.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 12);
            this.label10.TabIndex = 3;
            this.label10.Text = "작업지시현황";
            // 
            // 작업지시현황BindingSource
            // 
            this.작업지시현황BindingSource.DataSource = typeof(ClassLibrary.작업지시현황);
            // 
            // 작업지시현황
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn조회);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "작업지시현황";
            this.Size = new System.Drawing.Size(1044, 645);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.작업지시현황BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn조회;
        private System.Windows.Forms.TextBox txb품번;
        private System.Windows.Forms.TextBox txb지시번호;
        private System.Windows.Forms.TextBox txb부서명;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbb부서코드;
        private System.Windows.Forms.ComboBox cbb사원코드;
        private System.Windows.Forms.TextBox txb사원명;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource 작업지시현황BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn 작업지시번호DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 생산계획현황번호DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 제품번호DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 수량DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 작업장번호DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 작업상태번호DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 작업지시일DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 작업완료예정일DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 자재명세번호DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 상태DataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker dtp작업지시일2;
        private System.Windows.Forms.DateTimePicker dtp작업지시일1;
    }
}
