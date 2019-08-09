namespace SMART_ERP_System.MenuUserControl
{
    partial class 사업장등록
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker5 = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1033, 651);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(309, 34);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(716, 611);
            this.tabControl1.TabIndex = 99;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(708, 585);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "기본등록사항";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dateTimePicker5);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.dateTimePicker4);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.textBox9);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.textBox8);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.textBox7);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.textBox6);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(702, 585);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.GroupBox2_Enter);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(187, 402);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(82, 21);
            this.textBox2.TabIndex = 150;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Gulim", 10F);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(123, 402);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(59, 21);
            this.comboBox2.TabIndex = 149;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Font = new System.Drawing.Font("Gulim", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(40, 405);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 22);
            this.label3.TabIndex = 148;
            this.label3.Text = "관할세무서";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gulim", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(37, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 22);
            this.label1.TabIndex = 147;
            this.label1.Text = "사업장번지";
            // 
            // dateTimePicker5
            // 
            this.dateTimePicker5.Location = new System.Drawing.Point(123, 504);
            this.dateTimePicker5.Name = "dateTimePicker5";
            this.dateTimePicker5.Size = new System.Drawing.Size(171, 21);
            this.dateTimePicker5.TabIndex = 146;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label15.Font = new System.Drawing.Font("Gulim", 10F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(39, 506);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 22);
            this.label15.TabIndex = 145;
            this.label15.Text = "폐업년월일";
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Location = new System.Drawing.Point(123, 458);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(171, 21);
            this.dateTimePicker4.TabIndex = 144;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label14.Font = new System.Drawing.Font("Gulim", 10F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(39, 460);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 22);
            this.label14.TabIndex = 143;
            this.label14.Text = "개업년월일";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(123, 354);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(130, 21);
            this.textBox9.TabIndex = 140;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Gulim", 10F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(82, 356);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 22);
            this.label12.TabIndex = 139;
            this.label12.Text = "종목";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(123, 304);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(130, 21);
            this.textBox8.TabIndex = 138;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Gulim", 10F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(82, 306);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 22);
            this.label11.TabIndex = 137;
            this.label11.Text = "업태";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(189, 249);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(212, 21);
            this.textBox7.TabIndex = 136;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Gulim", 10F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(8, 251);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 22);
            this.label10.TabIndex = 135;
            this.label10.Text = "사업장전화번호";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(123, 249);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(60, 21);
            this.textBox6.TabIndex = 134;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(124, 195);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(364, 21);
            this.textBox5.TabIndex = 133;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(124, 141);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(364, 21);
            this.textBox4.TabIndex = 131;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Gulim", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(37, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 22);
            this.label6.TabIndex = 130;
            this.label6.Text = "사업장주소";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(124, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(225, 21);
            this.textBox1.TabIndex = 126;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Gulim", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(40, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 22);
            this.label4.TabIndex = 125;
            this.label4.Text = "대표자성명";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(124, 32);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(225, 21);
            this.textBox3.TabIndex = 124;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Gulim", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(11, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 22);
            this.label2.TabIndex = 123;
            this.label2.Text = "사업자등록번호";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(6, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(297, 611);
            this.dataGridView1.TabIndex = 98;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "코드";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "사업장명";
            this.Column2.Name = "Column2";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("GulimChe", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(55, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 25);
            this.label8.TabIndex = 97;
            this.label8.Text = "사업장등록";
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Location = new System.Drawing.Point(7, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(1018, 1);
            this.label9.TabIndex = 94;
            // 
            // 사업장등록
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "사업장등록";
            this.Size = new System.Drawing.Size(1044, 645);
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
    }
}
