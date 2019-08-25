namespace SMART_ERP_System.MenuUserControl
{
    partial class 결산자료입력
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
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.noDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.결산자료코드DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.결산자료구분DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.결산계정코드DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.결산계정적요DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.결산계정명DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.상대계정코드DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.상대계정적요DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.상대계정명DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.비고DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.결산자료입력bds = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.결산자료dgv = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtp종료일 = new System.Windows.Forms.DateTimePicker();
            this.dtp시작일 = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.결산자료입력bds)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.결산자료dgv)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabControl2);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1041, 651);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Location = new System.Drawing.Point(7, 29);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1025, 581);
            this.tabControl2.TabIndex = 95;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1017, 555);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "계정설정";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noDataGridViewTextBoxColumn,
            this.결산자료코드DataGridViewTextBoxColumn,
            this.결산자료구분DataGridViewTextBoxColumn,
            this.결산계정코드DataGridViewTextBoxColumn,
            this.결산계정적요DataGridViewTextBoxColumn,
            this.결산계정명DataGridViewTextBoxColumn,
            this.상대계정코드DataGridViewTextBoxColumn,
            this.상대계정적요DataGridViewTextBoxColumn,
            this.상대계정명DataGridViewTextBoxColumn,
            this.비고DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.결산자료입력bds;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1011, 549);
            this.dataGridView1.TabIndex = 0;
            // 
            // noDataGridViewTextBoxColumn
            // 
            this.noDataGridViewTextBoxColumn.DataPropertyName = "No";
            this.noDataGridViewTextBoxColumn.HeaderText = "No";
            this.noDataGridViewTextBoxColumn.Name = "noDataGridViewTextBoxColumn";
            // 
            // 결산자료코드DataGridViewTextBoxColumn
            // 
            this.결산자료코드DataGridViewTextBoxColumn.DataPropertyName = "결산자료코드";
            this.결산자료코드DataGridViewTextBoxColumn.HeaderText = "결산자료코드";
            this.결산자료코드DataGridViewTextBoxColumn.Name = "결산자료코드DataGridViewTextBoxColumn";
            // 
            // 결산자료구분DataGridViewTextBoxColumn
            // 
            this.결산자료구분DataGridViewTextBoxColumn.DataPropertyName = "결산자료구분";
            this.결산자료구분DataGridViewTextBoxColumn.HeaderText = "결산자료구분";
            this.결산자료구분DataGridViewTextBoxColumn.Name = "결산자료구분DataGridViewTextBoxColumn";
            // 
            // 결산계정코드DataGridViewTextBoxColumn
            // 
            this.결산계정코드DataGridViewTextBoxColumn.DataPropertyName = "결산계정코드";
            this.결산계정코드DataGridViewTextBoxColumn.HeaderText = "결산계정코드";
            this.결산계정코드DataGridViewTextBoxColumn.Name = "결산계정코드DataGridViewTextBoxColumn";
            // 
            // 결산계정적요DataGridViewTextBoxColumn
            // 
            this.결산계정적요DataGridViewTextBoxColumn.DataPropertyName = "결산계정적요";
            this.결산계정적요DataGridViewTextBoxColumn.HeaderText = "결산계정적요";
            this.결산계정적요DataGridViewTextBoxColumn.Name = "결산계정적요DataGridViewTextBoxColumn";
            // 
            // 결산계정명DataGridViewTextBoxColumn
            // 
            this.결산계정명DataGridViewTextBoxColumn.DataPropertyName = "결산계정명";
            this.결산계정명DataGridViewTextBoxColumn.HeaderText = "결산계정명";
            this.결산계정명DataGridViewTextBoxColumn.Name = "결산계정명DataGridViewTextBoxColumn";
            // 
            // 상대계정코드DataGridViewTextBoxColumn
            // 
            this.상대계정코드DataGridViewTextBoxColumn.DataPropertyName = "상대계정코드";
            this.상대계정코드DataGridViewTextBoxColumn.HeaderText = "상대계정코드";
            this.상대계정코드DataGridViewTextBoxColumn.Name = "상대계정코드DataGridViewTextBoxColumn";
            // 
            // 상대계정적요DataGridViewTextBoxColumn
            // 
            this.상대계정적요DataGridViewTextBoxColumn.DataPropertyName = "상대계정적요";
            this.상대계정적요DataGridViewTextBoxColumn.HeaderText = "상대계정적요";
            this.상대계정적요DataGridViewTextBoxColumn.Name = "상대계정적요DataGridViewTextBoxColumn";
            // 
            // 상대계정명DataGridViewTextBoxColumn
            // 
            this.상대계정명DataGridViewTextBoxColumn.DataPropertyName = "상대계정명";
            this.상대계정명DataGridViewTextBoxColumn.HeaderText = "상대계정명";
            this.상대계정명DataGridViewTextBoxColumn.Name = "상대계정명DataGridViewTextBoxColumn";
            // 
            // 비고DataGridViewTextBoxColumn
            // 
            this.비고DataGridViewTextBoxColumn.DataPropertyName = "비고";
            this.비고DataGridViewTextBoxColumn.HeaderText = "비고";
            this.비고DataGridViewTextBoxColumn.Name = "비고DataGridViewTextBoxColumn";
            // 
            // 결산자료입력bds
            // 
            this.결산자료입력bds.DataSource = typeof(ClassLibrary.결산자료입력);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.결산자료dgv);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.textBox4);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.textBox3);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.textBox2);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.richTextBox2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1017, 555);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "결산자료";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // 결산자료dgv
            // 
            this.결산자료dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.결산자료dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.결산자료dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.결산자료dgv.Location = new System.Drawing.Point(3, 47);
            this.결산자료dgv.Name = "결산자료dgv";
            this.결산자료dgv.RowTemplate.Height = 23;
            this.결산자료dgv.Size = new System.Drawing.Size(1011, 505);
            this.결산자료dgv.TabIndex = 87;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.dtp종료일);
            this.groupBox2.Controls.Add(this.dtp시작일);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1011, 44);
            this.groupBox2.TabIndex = 95;
            this.groupBox2.TabStop = false;
            // 
            // dtp종료일
            // 
            this.dtp종료일.CustomFormat = "yyyy-MM-dd";
            this.dtp종료일.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp종료일.Location = new System.Drawing.Point(621, 10);
            this.dtp종료일.Name = "dtp종료일";
            this.dtp종료일.Size = new System.Drawing.Size(179, 21);
            this.dtp종료일.TabIndex = 93;
            this.dtp종료일.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Dtp종료일_KeyDown);
            // 
            // dtp시작일
            // 
            this.dtp시작일.CustomFormat = "yyyy-MM-dd";
            this.dtp시작일.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp시작일.Location = new System.Drawing.Point(424, 10);
            this.dtp시작일.Name = "dtp시작일";
            this.dtp시작일.Size = new System.Drawing.Size(173, 21);
            this.dtp시작일.TabIndex = 92;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label11.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(600, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 22);
            this.label11.TabIndex = 91;
            this.label11.Text = "~";
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label12.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(383, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 22);
            this.label12.TabIndex = 90;
            this.label12.Text = "기간";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(231, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(82, 21);
            this.textBox1.TabIndex = 89;
            this.textBox1.Text = "회사명";
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("굴림", 10F);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(150, 9);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(77, 21);
            this.comboBox2.TabIndex = 88;
            this.comboBox2.Text = "회사코드";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(82, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 22);
            this.label2.TabIndex = 87;
            this.label2.Text = "회계단위";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(660, 563);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 21);
            this.textBox4.TabIndex = 94;
            this.textBox4.Text = "[금액]";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(581, 566);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 22);
            this.label4.TabIndex = 93;
            this.label4.Text = "소득평율 : ";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(397, 563);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 21);
            this.textBox3.TabIndex = 92;
            this.textBox3.Text = "[금액]";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(304, 566);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 22);
            this.label3.TabIndex = 91;
            this.label3.Text = "당기순이익 : ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(108, 563);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 90;
            this.textBox2.Text = "[금액]";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(42, 566);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 22);
            this.label1.TabIndex = 89;
            this.label1.Text = "매출액 : ";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox2.Location = new System.Drawing.Point(0, 556);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(1011, 33);
            this.richTextBox2.TabIndex = 88;
            this.richTextBox2.Text = "";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(658, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 94;
            this.button5.Text = "감가상각";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(577, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 93;
            this.button4.Text = "계정생성";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(496, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 92;
            this.button3.Text = "분개";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(417, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 91;
            this.button2.Text = "새로작성";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(417, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 90;
            this.button1.Text = "정렬순서";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("굴림체", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(56, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 25);
            this.label8.TabIndex = 89;
            this.label8.Text = "결산자료입력";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(820, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 88;
            this.button7.Text = "조건검색";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(739, 2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 87;
            this.button8.Text = "적요등록";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Location = new System.Drawing.Point(7, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(1025, 1);
            this.label9.TabIndex = 86;
            // 
            // 결산자료입력
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "결산자료입력";
            this.Size = new System.Drawing.Size(1044, 645);
            this.Load += new System.EventHandler(this.결산자료입력_Load);
            this.groupBox1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.결산자료입력bds)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.결산자료dgv)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.DataGridView 결산자료dgv;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtp종료일;
        private System.Windows.Forms.DateTimePicker dtp시작일;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn noDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 결산자료코드DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 결산자료구분DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 결산계정코드DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 결산계정적요DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 결산계정명DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 상대계정코드DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 상대계정적요DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 상대계정명DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 비고DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource 결산자료입력bds;
    }
}
