namespace SMART_ERP_System.MenuUserControl
{
    partial class 자재등록
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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "자재등록";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(7, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1017, 118);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(95, 67);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(150, 21);
            this.textBox3.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(465, 18);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(150, 21);
            this.textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(95, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 21);
            this.textBox1.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "품목군 : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(370, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "공급업체이름 : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "자재이름 : ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(656, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "조회";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(737, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "변경";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(818, 1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "삭제";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(7, 160);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 488);
            this.panel1.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(466, 488);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox14);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.textBox12);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.textBox13);
            this.panel2.Controls.Add(this.textBox10);
            this.panel2.Controls.Add(this.textBox11);
            this.panel2.Controls.Add(this.textBox8);
            this.panel2.Controls.Add(this.textBox9);
            this.panel2.Controls.Add(this.textBox6);
            this.panel2.Controls.Add(this.textBox7);
            this.panel2.Controls.Add(this.textBox5);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(492, 158);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(532, 488);
            this.panel2.TabIndex = 7;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(353, 231);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(150, 21);
            this.textBox14.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(279, 234);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 26;
            this.label10.Text = "상도 : ";
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(88, 284);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(150, 21);
            this.textBox12.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 24;
            this.label7.Text = "하도 : ";
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(88, 228);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(150, 21);
            this.textBox13.TabIndex = 23;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(353, 177);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(150, 21);
            this.textBox10.TabIndex = 22;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(353, 128);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(150, 21);
            this.textBox11.TabIndex = 21;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(353, 75);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(150, 21);
            this.textBox8.TabIndex = 20;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(353, 26);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(150, 21);
            this.textBox9.TabIndex = 19;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(88, 177);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(150, 21);
            this.textBox6.TabIndex = 18;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(88, 128);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(150, 21);
            this.textBox7.TabIndex = 17;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(88, 75);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(150, 21);
            this.textBox5.TabIndex = 16;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(88, 26);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(150, 21);
            this.textBox4.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(270, 180);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 12);
            this.label13.TabIndex = 15;
            this.label13.Text = "LOT수량 : ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(270, 131);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 12);
            this.label15.TabIndex = 14;
            this.label15.Text = "리드타임 : ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(270, 78);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 12);
            this.label16.TabIndex = 13;
            this.label16.Text = "안전재고량 : ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(270, 29);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 12);
            this.label17.TabIndex = 12;
            this.label17.Text = "자재이름 : ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(14, 231);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 12);
            this.label14.TabIndex = 9;
            this.label14.Text = "무게 : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 8;
            this.label9.Text = "검사여부 : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 131);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 6;
            this.label11.Text = "재고량 : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "품목군 : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 3;
            this.label8.Text = "자재번호 : ";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1018, 1);
            this.label2.TabIndex = 8;
            // 
            // 자재등록
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "자재등록";
            this.Size = new System.Drawing.Size(1044, 645);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label2;
    }
}
