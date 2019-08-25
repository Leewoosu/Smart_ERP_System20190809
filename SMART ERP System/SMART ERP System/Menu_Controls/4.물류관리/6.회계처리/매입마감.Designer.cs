namespace SMART_ERP_System.MenuUserControl
{
    partial class 매입마감
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
            this.dgv자재전표 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.txb거래처 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv자재상세전표 = new System.Windows.Forms.DataGridView();
            this.btn조회 = new System.Windows.Forms.Button();
            this.bds자재상세전표 = new System.Windows.Forms.BindingSource(this.components);
            this.bds자재전표 = new System.Windows.Forms.BindingSource(this.components);
            this.자재전표번호DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.입고등록번호DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.거래처번호DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.총금액DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.자재번호DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.금액DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv자재전표)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv자재상세전표)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds자재상세전표)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds자재전표)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv자재전표
            // 
            this.dgv자재전표.AutoGenerateColumns = false;
            this.dgv자재전표.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv자재전표.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv자재전표.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.자재전표번호DataGridViewTextBoxColumn,
            this.입고등록번호DataGridViewTextBoxColumn,
            this.거래처번호DataGridViewTextBoxColumn,
            this.총금액DataGridViewTextBoxColumn});
            this.dgv자재전표.DataSource = this.bds자재전표;
            this.dgv자재전표.Location = new System.Drawing.Point(7, 138);
            this.dgv자재전표.Name = "dgv자재전표";
            this.dgv자재전표.RowTemplate.Height = 23;
            this.dgv자재전표.Size = new System.Drawing.Size(1018, 244);
            this.dgv자재전표.TabIndex = 119;
            this.dgv자재전표.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox14);
            this.groupBox1.Controls.Add(this.textBox15);
            this.groupBox1.Controls.Add(this.txb거래처);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.textBox9);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(7, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1018, 73);
            this.groupBox1.TabIndex = 118;
            this.groupBox1.TabStop = false;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(451, 18);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(67, 20);
            this.textBox14.TabIndex = 127;
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(524, 18);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(107, 20);
            this.textBox15.TabIndex = 128;
            // 
            // txb거래처
            // 
            this.txb거래처.Location = new System.Drawing.Point(771, 18);
            this.txb거래처.Name = "txb거래처";
            this.txb거래처.Size = new System.Drawing.Size(180, 20);
            this.txb거래처.TabIndex = 124;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(130, 17);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(70, 20);
            this.textBox7.TabIndex = 121;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(206, 17);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(104, 20);
            this.textBox9.TabIndex = 122;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(418, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 11);
            this.label11.TabIndex = 38;
            this.label11.Text = "사원";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(97, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 11);
            this.label5.TabIndex = 31;
            this.label5.Text = "부서";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(727, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 11);
            this.label6.TabIndex = 33;
            this.label6.Text = "거래처";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 117;
            this.label8.Text = "매입마감";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1018, 1);
            this.label1.TabIndex = 116;
            this.label1.Text = "label1";
            // 
            // dgv자재상세전표
            // 
            this.dgv자재상세전표.AutoGenerateColumns = false;
            this.dgv자재상세전표.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv자재상세전표.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv자재상세전표.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.자재번호DataGridViewTextBoxColumn,
            this.금액DataGridViewTextBoxColumn});
            this.dgv자재상세전표.DataSource = this.bds자재상세전표;
            this.dgv자재상세전표.Location = new System.Drawing.Point(7, 388);
            this.dgv자재상세전표.Name = "dgv자재상세전표";
            this.dgv자재상세전표.RowTemplate.Height = 23;
            this.dgv자재상세전표.Size = new System.Drawing.Size(1018, 198);
            this.dgv자재상세전표.TabIndex = 121;
            // 
            // btn조회
            // 
            this.btn조회.Location = new System.Drawing.Point(851, 0);
            this.btn조회.Name = "btn조회";
            this.btn조회.Size = new System.Drawing.Size(84, 23);
            this.btn조회.TabIndex = 124;
            this.btn조회.Text = "조회";
            this.btn조회.UseVisualStyleBackColor = true;
            this.btn조회.Click += new System.EventHandler(this.Btn조회_Click);
            // 
            // bds자재상세전표
            // 
            this.bds자재상세전표.DataSource = typeof(ClassLibrary.자재상세전표);
            // 
            // bds자재전표
            // 
            this.bds자재전표.DataSource = typeof(ClassLibrary.자재전표);
            // 
            // 자재전표번호DataGridViewTextBoxColumn
            // 
            this.자재전표번호DataGridViewTextBoxColumn.DataPropertyName = "자재전표번호";
            this.자재전표번호DataGridViewTextBoxColumn.HeaderText = "자재전표번호";
            this.자재전표번호DataGridViewTextBoxColumn.Name = "자재전표번호DataGridViewTextBoxColumn";
            // 
            // 입고등록번호DataGridViewTextBoxColumn
            // 
            this.입고등록번호DataGridViewTextBoxColumn.DataPropertyName = "입고등록번호";
            this.입고등록번호DataGridViewTextBoxColumn.HeaderText = "발주번호";
            this.입고등록번호DataGridViewTextBoxColumn.Name = "입고등록번호DataGridViewTextBoxColumn";
            // 
            // 거래처번호DataGridViewTextBoxColumn
            // 
            this.거래처번호DataGridViewTextBoxColumn.DataPropertyName = "거래처번호";
            this.거래처번호DataGridViewTextBoxColumn.HeaderText = "거래처";
            this.거래처번호DataGridViewTextBoxColumn.Name = "거래처번호DataGridViewTextBoxColumn";
            // 
            // 총금액DataGridViewTextBoxColumn
            // 
            this.총금액DataGridViewTextBoxColumn.DataPropertyName = "총금액";
            this.총금액DataGridViewTextBoxColumn.HeaderText = "총금액";
            this.총금액DataGridViewTextBoxColumn.Name = "총금액DataGridViewTextBoxColumn";
            // 
            // 자재번호DataGridViewTextBoxColumn
            // 
            this.자재번호DataGridViewTextBoxColumn.DataPropertyName = "자재번호";
            this.자재번호DataGridViewTextBoxColumn.HeaderText = "자재";
            this.자재번호DataGridViewTextBoxColumn.Name = "자재번호DataGridViewTextBoxColumn";
            // 
            // 금액DataGridViewTextBoxColumn
            // 
            this.금액DataGridViewTextBoxColumn.DataPropertyName = "금액";
            this.금액DataGridViewTextBoxColumn.HeaderText = "금액";
            this.금액DataGridViewTextBoxColumn.Name = "금액DataGridViewTextBoxColumn";
            // 
            // 매입마감
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn조회);
            this.Controls.Add(this.dgv자재상세전표);
            this.Controls.Add(this.dgv자재전표);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Name = "매입마감";
            this.Size = new System.Drawing.Size(1044, 645);
            this.Load += new System.EventHandler(this.매입마감_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv자재전표)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv자재상세전표)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds자재상세전표)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds자재전표)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv자재전표;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox txb거래처;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn조회;
        private System.Windows.Forms.BindingSource bds자재전표;
        private System.Windows.Forms.BindingSource bds자재상세전표;
        private System.Windows.Forms.DataGridView dgv자재상세전표;
        private System.Windows.Forms.DataGridViewTextBoxColumn 자재전표번호DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 입고등록번호DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 거래처번호DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 총금액DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 자재번호DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 금액DataGridViewTextBoxColumn;
    }
}
