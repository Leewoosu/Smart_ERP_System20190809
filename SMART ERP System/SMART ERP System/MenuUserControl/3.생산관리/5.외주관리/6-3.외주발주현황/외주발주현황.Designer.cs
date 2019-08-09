namespace SMART_ERP_System.MenuUserControl
{
    partial class 외주발주현황
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.생산지시번호 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.자재출고상태 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.지시일 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.납기일 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.품번 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.품명 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.규격 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.단위 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.지시수량 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.단가 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.검사 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.비고 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
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
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(7, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1018, 89);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(710, 14);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(100, 20);
            this.comboBox3.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Gulim", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(357, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 11);
            this.label7.TabIndex = 23;
            this.label7.Text = "사원";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gulim", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(64, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 11);
            this.label6.TabIndex = 22;
            this.label6.Text = "부서";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(817, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(24, 24);
            this.button2.TabIndex = 21;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Gulim", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox4.Location = new System.Drawing.Point(710, 54);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 19;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Gulim", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dateTimePicker2.Location = new System.Drawing.Point(239, 51);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(114, 21);
            this.dateTimePicker2.TabIndex = 18;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Gulim", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dateTimePicker1.Location = new System.Drawing.Point(123, 51);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(110, 21);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gulim", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(663, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 11);
            this.label5.TabIndex = 16;
            this.label5.Text = "품번";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gulim", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(44, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 11);
            this.label4.TabIndex = 15;
            this.label4.Text = "지시기간";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gulim", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(652, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 11);
            this.label3.TabIndex = 13;
            this.label3.Text = "외주처";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Gulim", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox2.Location = new System.Drawing.Point(508, 19);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 12;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Gulim", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(402, 19);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(100, 19);
            this.comboBox2.TabIndex = 11;
            this.comboBox2.Text = "사원코드";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Gulim", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox1.Location = new System.Drawing.Point(226, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 10;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Gulim", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(120, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 19);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.Text = "부서코드";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "외주발주현황";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.생산지시번호,
            this.자재출고상태,
            this.지시일,
            this.납기일,
            this.품번,
            this.품명,
            this.규격,
            this.단위,
            this.지시수량,
            this.단가,
            this.검사,
            this.비고});
            this.dataGridView1.Location = new System.Drawing.Point(7, 130);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1018, 224);
            this.dataGridView1.TabIndex = 0;
            // 
            // 생산지시번호
            // 
            this.생산지시번호.HeaderText = "생산지시번호";
            this.생산지시번호.Name = "생산지시번호";
            // 
            // 자재출고상태
            // 
            this.자재출고상태.HeaderText = "자재출고상태";
            this.자재출고상태.Name = "자재출고상태";
            // 
            // 지시일
            // 
            this.지시일.HeaderText = "지시일";
            this.지시일.Name = "지시일";
            // 
            // 납기일
            // 
            this.납기일.HeaderText = "납기일";
            this.납기일.Name = "납기일";
            // 
            // 품번
            // 
            this.품번.HeaderText = "품번";
            this.품번.Name = "품번";
            // 
            // 품명
            // 
            this.품명.HeaderText = "품명";
            this.품명.Name = "품명";
            // 
            // 규격
            // 
            this.규격.HeaderText = "규격";
            this.규격.Name = "규격";
            // 
            // 단위
            // 
            this.단위.HeaderText = "단위";
            this.단위.Name = "단위";
            // 
            // 지시수량
            // 
            this.지시수량.HeaderText = "지시수량";
            this.지시수량.Name = "지시수량";
            // 
            // 단가
            // 
            this.단가.HeaderText = "단가";
            this.단가.Name = "단가";
            // 
            // 검사
            // 
            this.검사.HeaderText = "검사";
            this.검사.Name = "검사";
            // 
            // 비고
            // 
            this.비고.HeaderText = "비고";
            this.비고.Name = "비고";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.dataGridView2.Location = new System.Drawing.Point(7, 374);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(1018, 246);
            this.dataGridView2.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "청구일";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "품번";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "품명";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "규격";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "단위";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "정미수량";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "LOSS(%)";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "확정수량";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "구분";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(663, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(74, 18);
            this.button3.TabIndex = 4;
            this.button3.Text = "조회";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(743, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(74, 18);
            this.button4.TabIndex = 5;
            this.button4.Text = "수정";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(823, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(74, 18);
            this.button5.TabIndex = 6;
            this.button5.Text = "삭제";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // 외주발주현황
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "외주발주현황";
            this.Size = new System.Drawing.Size(1044, 645);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 생산지시번호;
        private System.Windows.Forms.DataGridViewTextBoxColumn 자재출고상태;
        private System.Windows.Forms.DataGridViewTextBoxColumn 지시일;
        private System.Windows.Forms.DataGridViewTextBoxColumn 납기일;
        private System.Windows.Forms.DataGridViewTextBoxColumn 품번;
        private System.Windows.Forms.DataGridViewTextBoxColumn 품명;
        private System.Windows.Forms.DataGridViewTextBoxColumn 규격;
        private System.Windows.Forms.DataGridViewTextBoxColumn 단위;
        private System.Windows.Forms.DataGridViewTextBoxColumn 지시수량;
        private System.Windows.Forms.DataGridViewTextBoxColumn 단가;
        private System.Windows.Forms.DataGridViewTextBoxColumn 검사;
        private System.Windows.Forms.DataGridViewTextBoxColumn 비고;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox3;
    }
}
