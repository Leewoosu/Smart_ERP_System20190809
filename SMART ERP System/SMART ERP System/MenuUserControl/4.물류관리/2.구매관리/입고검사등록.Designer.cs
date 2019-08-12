namespace SMART_ERP_System.MenuUserControl
{
    partial class 입고검사등록
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dgv입고검사 = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.불량코드번호DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.불량수량DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bds불량상세정보 = new System.Windows.Forms.BindingSource(this.components);
            this.입고검사번호DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.발주확인서번호DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.자재번호DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.양품수량DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.불량수량DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bds입고검사 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv입고검사)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds불량상세정보)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds입고검사)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.불량코드번호DataGridViewTextBoxColumn,
            this.불량수량DataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.bds불량상세정보;
            this.dataGridView2.Location = new System.Drawing.Point(7, 289);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(1018, 158);
            this.dataGridView2.TabIndex = 97;
            // 
            // dgv입고검사
            // 
            this.dgv입고검사.AutoGenerateColumns = false;
            this.dgv입고검사.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv입고검사.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv입고검사.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.입고검사번호DataGridViewTextBoxColumn,
            this.발주확인서번호DataGridViewTextBoxColumn,
            this.자재번호DataGridViewTextBoxColumn,
            this.양품수량DataGridViewTextBoxColumn,
            this.불량수량DataGridViewTextBoxColumn});
            this.dgv입고검사.DataSource = this.bds입고검사;
            this.dgv입고검사.Location = new System.Drawing.Point(7, 146);
            this.dgv입고검사.Name = "dgv입고검사";
            this.dgv입고검사.RowTemplate.Height = 23;
            this.dgv입고검사.Size = new System.Drawing.Size(1018, 137);
            this.dgv입고검사.TabIndex = 96;
            this.dgv입고검사.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv입고검사_CellEndEdit);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(805, -1);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(92, 23);
            this.button5.TabIndex = 94;
            this.button5.Text = "발주 적용";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox13);
            this.groupBox1.Controls.Add(this.textBox14);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox9);
            this.groupBox1.Controls.Add(this.textBox10);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.textBox8);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(7, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1018, 110);
            this.groupBox1.TabIndex = 93;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(623, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 11);
            this.label2.TabIndex = 67;
            this.label2.Text = "검사담당";
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(682, 50);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(66, 20);
            this.textBox13.TabIndex = 64;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(754, 50);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(108, 20);
            this.textBox14.TabIndex = 65;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(682, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(66, 20);
            this.textBox1.TabIndex = 62;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(754, 23);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(108, 20);
            this.textBox4.TabIndex = 63;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(366, 47);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(66, 20);
            this.textBox9.TabIndex = 56;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(438, 47);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(108, 20);
            this.textBox10.TabIndex = 57;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(366, 21);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(66, 20);
            this.textBox7.TabIndex = 54;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(438, 21);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(108, 20);
            this.textBox8.TabIndex = 55;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(92, 44);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(180, 20);
            this.textBox6.TabIndex = 53;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label15.Location = new System.Drawing.Point(39, 23);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 11);
            this.label15.TabIndex = 51;
            this.label15.Text = "검사기간";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(645, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 11);
            this.label11.TabIndex = 38;
            this.label11.Text = "사원";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(92, 20);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(77, 20);
            this.textBox2.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 11);
            this.label3.TabIndex = 27;
            this.label3.Text = "~";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(195, 20);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(77, 20);
            this.textBox3.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(39, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 11);
            this.label4.TabIndex = 29;
            this.label4.Text = "자재이름";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(333, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 11);
            this.label5.TabIndex = 31;
            this.label5.Text = "부서";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(323, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 11);
            this.label6.TabIndex = 33;
            this.label6.Text = "거래처";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 12);
            this.label8.TabIndex = 92;
            this.label8.Text = "입고검사등록";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1018, 1);
            this.label1.TabIndex = 89;
            this.label1.Text = "label1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.dataGridView3);
            this.groupBox2.Location = new System.Drawing.Point(7, 453);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(481, 195);
            this.groupBox2.TabIndex = 68;
            this.groupBox2.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 99;
            this.label12.Text = "검사내역";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(0, 37);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 23;
            this.dataGridView3.Size = new System.Drawing.Size(475, 158);
            this.dataGridView3.TabIndex = 98;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.dataGridView4);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Location = new System.Drawing.Point(510, 453);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(515, 195);
            this.groupBox3.TabIndex = 98;
            this.groupBox3.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 100;
            this.label9.Text = "불량내역";
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(0, 34);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowTemplate.Height = 23;
            this.dataGridView4.Size = new System.Drawing.Size(509, 158);
            this.dataGridView4.TabIndex = 99;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(417, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 96;
            this.button1.Text = "불량수량적용";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // 불량코드번호DataGridViewTextBoxColumn
            // 
            this.불량코드번호DataGridViewTextBoxColumn.DataPropertyName = "불량코드번호";
            this.불량코드번호DataGridViewTextBoxColumn.HeaderText = "불량코드번호";
            this.불량코드번호DataGridViewTextBoxColumn.Name = "불량코드번호DataGridViewTextBoxColumn";
            // 
            // 불량수량DataGridViewTextBoxColumn1
            // 
            this.불량수량DataGridViewTextBoxColumn1.DataPropertyName = "불량수량";
            this.불량수량DataGridViewTextBoxColumn1.HeaderText = "불량수량";
            this.불량수량DataGridViewTextBoxColumn1.Name = "불량수량DataGridViewTextBoxColumn1";
            // 
            // bds불량상세정보
            // 
            this.bds불량상세정보.DataSource = typeof(ClassLibrary.불량상세정보);
            // 
            // 입고검사번호DataGridViewTextBoxColumn
            // 
            this.입고검사번호DataGridViewTextBoxColumn.DataPropertyName = "입고검사번호";
            this.입고검사번호DataGridViewTextBoxColumn.HeaderText = "입고검사번호";
            this.입고검사번호DataGridViewTextBoxColumn.Name = "입고검사번호DataGridViewTextBoxColumn";
            // 
            // 발주확인서번호DataGridViewTextBoxColumn
            // 
            this.발주확인서번호DataGridViewTextBoxColumn.DataPropertyName = "발주확인서번호";
            this.발주확인서번호DataGridViewTextBoxColumn.HeaderText = "발주확인서번호";
            this.발주확인서번호DataGridViewTextBoxColumn.Name = "발주확인서번호DataGridViewTextBoxColumn";
            // 
            // 자재번호DataGridViewTextBoxColumn
            // 
            this.자재번호DataGridViewTextBoxColumn.DataPropertyName = "자재번호";
            this.자재번호DataGridViewTextBoxColumn.HeaderText = "자재번호";
            this.자재번호DataGridViewTextBoxColumn.Name = "자재번호DataGridViewTextBoxColumn";
            // 
            // 양품수량DataGridViewTextBoxColumn
            // 
            this.양품수량DataGridViewTextBoxColumn.DataPropertyName = "양품수량";
            this.양품수량DataGridViewTextBoxColumn.HeaderText = "양품수량";
            this.양품수량DataGridViewTextBoxColumn.Name = "양품수량DataGridViewTextBoxColumn";
            // 
            // 불량수량DataGridViewTextBoxColumn
            // 
            this.불량수량DataGridViewTextBoxColumn.DataPropertyName = "불량수량";
            this.불량수량DataGridViewTextBoxColumn.HeaderText = "불량수량";
            this.불량수량DataGridViewTextBoxColumn.Name = "불량수량DataGridViewTextBoxColumn";
            // 
            // bds입고검사
            // 
            this.bds입고검사.DataSource = typeof(ClassLibrary.입고검사);
            // 
            // 입고검사등록
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dgv입고검사);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Name = "입고검사등록";
            this.Size = new System.Drawing.Size(1044, 645);
            this.Load += new System.EventHandler(this.입고검사등록_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv입고검사)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds불량상세정보)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds입고검사)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dgv입고검사;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.BindingSource bds불량상세정보;
        private System.Windows.Forms.DataGridViewTextBoxColumn 입고검사번호DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 발주확인서번호DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 자재번호DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 양품수량DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 불량수량DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bds입고검사;
        private System.Windows.Forms.DataGridViewTextBoxColumn 불량코드번호DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 불량수량DataGridViewTextBoxColumn1;
    }
}
