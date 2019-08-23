namespace SMART_ERP_System.MenuUserControl
{
    partial class 생산계획현황
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.cbb품목군 = new System.Windows.Forms.ComboBox();
            this.제품BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtp작업일2 = new System.Windows.Forms.DateTimePicker();
            this.dtp작업일1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txb품번 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbx사원명 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx부서명 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.생산계획현황번호DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.작업예정일DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.작업확정일DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.수량DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.제품번호DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.생산계획현황BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.제품BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.생산계획현황BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1018, 1);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.cbb품목군);
            this.groupBox1.Controls.Add(this.dtp작업일2);
            this.groupBox1.Controls.Add(this.dtp작업일1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txb품번);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbx사원명);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbx부서명);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(7, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1018, 122);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Location = new System.Drawing.Point(721, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(135, 47);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "구분";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(70, 20);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(59, 16);
            this.radioButton2.TabIndex = 20;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "확정일";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(5, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(59, 16);
            this.radioButton1.TabIndex = 19;
            this.radioButton1.Text = "예정일";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // cbb품목군
            // 
            this.cbb품목군.DataSource = this.제품BindingSource;
            this.cbb품목군.DisplayMember = "품목군";
            this.cbb품목군.FormattingEnabled = true;
            this.cbb품목군.Location = new System.Drawing.Point(493, 55);
            this.cbb품목군.Name = "cbb품목군";
            this.cbb품목군.Size = new System.Drawing.Size(100, 20);
            this.cbb품목군.TabIndex = 18;
            this.cbb품목군.ValueMember = "제품번호";
            this.cbb품목군.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // 제품BindingSource
            // 
            this.제품BindingSource.DataSource = typeof(ClassLibrary.제품);
            // 
            // dtp작업일2
            // 
            this.dtp작업일2.Location = new System.Drawing.Point(247, 91);
            this.dtp작업일2.Name = "dtp작업일2";
            this.dtp작업일2.Size = new System.Drawing.Size(112, 21);
            this.dtp작업일2.TabIndex = 14;
            // 
            // dtp작업일1
            // 
            this.dtp작업일1.Location = new System.Drawing.Point(114, 91);
            this.dtp작업일1.Name = "dtp작업일1";
            this.dtp작업일1.Size = new System.Drawing.Size(112, 21);
            this.dtp작업일1.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(70, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 11);
            this.label6.TabIndex = 12;
            this.label6.Text = "작업일";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(449, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 11);
            this.label5.TabIndex = 9;
            this.label5.Text = "품목군";
            // 
            // txb품번
            // 
            this.txb품번.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txb품번.Location = new System.Drawing.Point(114, 56);
            this.txb품번.Name = "txb품번";
            this.txb품번.Size = new System.Drawing.Size(100, 20);
            this.txb품번.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(81, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 11);
            this.label4.TabIndex = 6;
            this.label4.Text = "품번";
            // 
            // tbx사원명
            // 
            this.tbx사원명.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbx사원명.Location = new System.Drawing.Point(493, 17);
            this.tbx사원명.Name = "tbx사원명";
            this.tbx사원명.Size = new System.Drawing.Size(100, 20);
            this.tbx사원명.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(460, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 11);
            this.label3.TabIndex = 3;
            this.label3.Text = "사원";
            // 
            // tbx부서명
            // 
            this.tbx부서명.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbx부서명.Location = new System.Drawing.Point(114, 17);
            this.tbx부서명.Name = "tbx부서명";
            this.tbx부서명.Size = new System.Drawing.Size(100, 20);
            this.tbx부서명.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(81, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 11);
            this.label2.TabIndex = 0;
            this.label2.Text = "부서";
            // 
            // btnSearch1
            // 
            this.btnSearch1.Location = new System.Drawing.Point(933, 3);
            this.btnSearch1.Name = "btnSearch1";
            this.btnSearch1.Size = new System.Drawing.Size(55, 23);
            this.btnSearch1.TabIndex = 8;
            this.btnSearch1.Text = "조회";
            this.btnSearch1.UseVisualStyleBackColor = true;
            this.btnSearch1.Click += new System.EventHandler(this.btnSearch1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 12);
            this.label7.TabIndex = 2;
            this.label7.Text = "생산계획현황";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.생산계획현황번호DataGridViewTextBoxColumn,
            this.작업예정일DataGridViewTextBoxColumn,
            this.작업확정일DataGridViewTextBoxColumn,
            this.수량DataGridViewTextBoxColumn,
            this.제품번호DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.생산계획현황BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(7, 163);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1018, 306);
            this.dataGridView1.TabIndex = 3;
            // 
            // 생산계획현황번호DataGridViewTextBoxColumn
            // 
            this.생산계획현황번호DataGridViewTextBoxColumn.DataPropertyName = "생산계획현황번호";
            this.생산계획현황번호DataGridViewTextBoxColumn.HeaderText = "생산계획현황번호";
            this.생산계획현황번호DataGridViewTextBoxColumn.Name = "생산계획현황번호DataGridViewTextBoxColumn";
            // 
            // 작업예정일DataGridViewTextBoxColumn
            // 
            this.작업예정일DataGridViewTextBoxColumn.DataPropertyName = "작업예정일";
            this.작업예정일DataGridViewTextBoxColumn.HeaderText = "작업예정일";
            this.작업예정일DataGridViewTextBoxColumn.Name = "작업예정일DataGridViewTextBoxColumn";
            // 
            // 작업확정일DataGridViewTextBoxColumn
            // 
            this.작업확정일DataGridViewTextBoxColumn.DataPropertyName = "작업확정일";
            this.작업확정일DataGridViewTextBoxColumn.HeaderText = "작업확정일";
            this.작업확정일DataGridViewTextBoxColumn.Name = "작업확정일DataGridViewTextBoxColumn";
            // 
            // 수량DataGridViewTextBoxColumn
            // 
            this.수량DataGridViewTextBoxColumn.DataPropertyName = "수량";
            this.수량DataGridViewTextBoxColumn.HeaderText = "수량";
            this.수량DataGridViewTextBoxColumn.Name = "수량DataGridViewTextBoxColumn";
            // 
            // 제품번호DataGridViewTextBoxColumn
            // 
            this.제품번호DataGridViewTextBoxColumn.DataPropertyName = "제품번호";
            this.제품번호DataGridViewTextBoxColumn.HeaderText = "제품번호";
            this.제품번호DataGridViewTextBoxColumn.Name = "제품번호DataGridViewTextBoxColumn";
            // 
            // 생산계획현황BindingSource
            // 
            this.생산계획현황BindingSource.DataSource = typeof(ClassLibrary.생산계획현황);
            // 
            // 생산계획현황
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch1);
            this.Name = "생산계획현황";
            this.Size = new System.Drawing.Size(1044, 645);
            this.Load += new System.EventHandler(this.생산계획현황_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.제품BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.생산계획현황BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx사원명;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx부서명;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp작업일2;
        private System.Windows.Forms.DateTimePicker dtp작업일1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSearch1;
        private System.Windows.Forms.TextBox txb품번;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource 생산계획현황BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn 생산계획현황번호DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 작업예정일DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 작업확정일DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 수량DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 제품번호DataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cbb품목군;
        private System.Windows.Forms.BindingSource 제품BindingSource;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}
