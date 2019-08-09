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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.지시번호 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.지시일 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.완료일 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.품번 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.품명 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.단위 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.지시수량 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.공정 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.작업장 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.상태 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LOT번호 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.지시번호,
            this.지시일,
            this.완료일,
            this.품번,
            this.품명,
            this.단위,
            this.지시수량,
            this.공정,
            this.작업장,
            this.상태,
            this.LOT번호});
            this.dataGridView1.Location = new System.Drawing.Point(7, 172);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1018, 332);
            this.dataGridView1.TabIndex = 0;
            // 
            // 지시번호
            // 
            this.지시번호.HeaderText = "지시번호";
            this.지시번호.Name = "지시번호";
            // 
            // 지시일
            // 
            this.지시일.HeaderText = "지시일";
            this.지시일.Name = "지시일";
            // 
            // 완료일
            // 
            this.완료일.HeaderText = "완료일";
            this.완료일.Name = "완료일";
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
            // 공정
            // 
            this.공정.HeaderText = "공정";
            this.공정.Name = "공정";
            // 
            // 작업장
            // 
            this.작업장.HeaderText = "작업장";
            this.작업장.Name = "작업장";
            // 
            // 상태
            // 
            this.상태.HeaderText = "상태";
            this.상태.Name = "상태";
            // 
            // LOT번호
            // 
            this.LOT번호.HeaderText = "LOT번호";
            this.LOT번호.Name = "LOT번호";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.comboBox4);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(7, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1018, 117);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Gulim", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox7.Location = new System.Drawing.Point(773, 82);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 60;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Gulim", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox2.Location = new System.Drawing.Point(510, 82);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 59;
            // 
            // comboBox4
            // 
            this.comboBox4.Font = new System.Drawing.Font("Gulim", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(665, 82);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(102, 19);
            this.comboBox4.TabIndex = 58;
            this.comboBox4.Text = "작업장코드";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Gulim", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(627, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 12);
            this.label9.TabIndex = 57;
            this.label9.Text = "작업장";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gulim", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(371, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 11);
            this.label3.TabIndex = 20;
            this.label3.Text = "사원";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gulim", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(66, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 11);
            this.label4.TabIndex = 20;
            this.label4.Text = "부서";
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("Gulim", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(402, 82);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(100, 19);
            this.comboBox3.TabIndex = 56;
            this.comboBox3.Text = "공정코드";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Gulim", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(371, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 12);
            this.label2.TabIndex = 55;
            this.label2.Text = "공정";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Gulim", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dateTimePicker2.Location = new System.Drawing.Point(241, 82);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(108, 20);
            this.dateTimePicker2.TabIndex = 54;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Gulim", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dateTimePicker1.Location = new System.Drawing.Point(122, 82);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(113, 20);
            this.dateTimePicker1.TabIndex = 53;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Gulim", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(404, 16);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(100, 19);
            this.comboBox2.TabIndex = 52;
            this.comboBox2.Text = "사원코드";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Gulim", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox1.Location = new System.Drawing.Point(510, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 51;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Gulim", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(122, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 19);
            this.comboBox1.TabIndex = 50;
            this.comboBox1.Text = "부서코드";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(771, 45);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(26, 24);
            this.button6.TabIndex = 46;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(510, 45);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(24, 24);
            this.button5.TabIndex = 45;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(228, 45);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(24, 24);
            this.button4.TabIndex = 44;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Gulim", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox6.Location = new System.Drawing.Point(665, 48);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(102, 20);
            this.textBox6.TabIndex = 38;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Gulim", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox5.Location = new System.Drawing.Point(404, 48);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 37;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Gulim", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox4.Location = new System.Drawing.Point(122, 48);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 36;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Gulim", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox3.Location = new System.Drawing.Point(228, 17);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Gulim", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(40, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 11);
            this.label8.TabIndex = 31;
            this.label8.Text = "작업지시일";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Gulim", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(627, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 12);
            this.label7.TabIndex = 30;
            this.label7.Text = "품명";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gulim", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(371, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 11);
            this.label6.TabIndex = 29;
            this.label6.Text = "품번";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gulim", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(44, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 11);
            this.label5.TabIndex = 28;
            this.label5.Text = "지시번호";
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
            this.label10.Size = new System.Drawing.Size(81, 12);
            this.label10.TabIndex = 3;
            this.label10.Text = "생산현황 조회";
            // 
            // 작업지시현황
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "작업지시현황";
            this.Size = new System.Drawing.Size(1044, 645);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn 지시번호;
        private System.Windows.Forms.DataGridViewTextBoxColumn 지시일;
        private System.Windows.Forms.DataGridViewTextBoxColumn 완료일;
        private System.Windows.Forms.DataGridViewTextBoxColumn 품번;
        private System.Windows.Forms.DataGridViewTextBoxColumn 품명;
        private System.Windows.Forms.DataGridViewTextBoxColumn 단위;
        private System.Windows.Forms.DataGridViewTextBoxColumn 지시수량;
        private System.Windows.Forms.DataGridViewTextBoxColumn 공정;
        private System.Windows.Forms.DataGridViewTextBoxColumn 작업장;
        private System.Windows.Forms.DataGridViewTextBoxColumn 상태;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOT번호;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox2;
    }
}
