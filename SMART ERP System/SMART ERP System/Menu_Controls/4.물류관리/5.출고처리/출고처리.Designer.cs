namespace SMART_ERP_System.MenuUserControl
{
    partial class 출고처리
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
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.품번1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.고객이름 = new System.Windows.Forms.TextBox();
            this.고객번호 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtps = new System.Windows.Forms.DateTimePicker();
            this.dtpe = new System.Windows.Forms.DateTimePicker();
            this.품번2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.수주번호1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.수주번호2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.제품번호 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.주문수량 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.납품업체번호 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.주문일 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.납기일 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.출고 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(643, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(84, 23);
            this.button4.TabIndex = 132;
            this.button4.Text = "주문적용";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(728, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 23);
            this.button3.TabIndex = 131;
            this.button3.Text = "주문일괄적용";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(814, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 23);
            this.button1.TabIndex = 130;
            this.button1.Text = "검사적용";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(7, 368);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(1018, 244);
            this.dataGridView2.TabIndex = 129;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.수주번호1,
            this.수주번호2,
            this.제품번호,
            this.주문수량,
            this.납품업체번호,
            this.주문일,
            this.납기일,
            this.출고});
            this.dataGridView1.Location = new System.Drawing.Point(7, 159);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1018, 203);
            this.dataGridView1.TabIndex = 128;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 126;
            this.label8.Text = "출고처리";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1018, 1);
            this.label1.TabIndex = 125;
            this.label1.Text = "label1";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Location = new System.Drawing.Point(911, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 136;
            this.button2.Text = "재고확인";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(165, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 11);
            this.label7.TabIndex = 133;
            this.label7.Text = "재고단위현재고";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox21);
            this.groupBox2.Controls.Add(this.textBox22);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.textBox19);
            this.groupBox2.Controls.Add(this.textBox20);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(8, 603);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1017, 45);
            this.groupBox2.TabIndex = 133;
            this.groupBox2.TabStop = false;
            // 
            // textBox21
            // 
            this.textBox21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox21.Location = new System.Drawing.Point(617, 18);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(194, 21);
            this.textBox21.TabIndex = 138;
            // 
            // textBox22
            // 
            this.textBox22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox22.Location = new System.Drawing.Point(813, 18);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(58, 21);
            this.textBox22.TabIndex = 139;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(529, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 11);
            this.label9.TabIndex = 137;
            this.label9.Text = "관리단위현재고";
            // 
            // textBox19
            // 
            this.textBox19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox19.Location = new System.Drawing.Point(253, 18);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(195, 21);
            this.textBox19.TabIndex = 134;
            // 
            // textBox20
            // 
            this.textBox20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox20.Location = new System.Drawing.Point(449, 18);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(58, 21);
            this.textBox20.TabIndex = 135;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 11);
            this.label3.TabIndex = 27;
            this.label3.Text = "~";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(785, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 11);
            this.label11.TabIndex = 38;
            this.label11.Text = "사원";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label15.Location = new System.Drawing.Point(9, 47);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 11);
            this.label15.TabIndex = 51;
            this.label15.Text = "출고기간";
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(891, 44);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(107, 20);
            this.textBox15.TabIndex = 128;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(818, 44);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(67, 20);
            this.textBox14.TabIndex = 127;
            // 
            // 품번1
            // 
            this.품번1.Location = new System.Drawing.Point(64, 70);
            this.품번1.Name = "품번1";
            this.품번1.Size = new System.Drawing.Size(105, 20);
            this.품번1.TabIndex = 132;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(29, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 11);
            this.label2.TabIndex = 135;
            this.label2.Text = "고객";
            // 
            // 고객이름
            // 
            this.고객이름.Location = new System.Drawing.Point(135, 18);
            this.고객이름.Name = "고객이름";
            this.고객이름.ReadOnly = true;
            this.고객이름.Size = new System.Drawing.Size(107, 20);
            this.고객이름.TabIndex = 137;
            // 
            // 고객번호
            // 
            this.고객번호.Location = new System.Drawing.Point(62, 18);
            this.고객번호.Name = "고객번호";
            this.고객번호.Size = new System.Drawing.Size(67, 20);
            this.고객번호.TabIndex = 136;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.품번2);
            this.groupBox1.Controls.Add(this.dtpe);
            this.groupBox1.Controls.Add(this.dtps);
            this.groupBox1.Controls.Add(this.고객번호);
            this.groupBox1.Controls.Add(this.고객이름);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.품번1);
            this.groupBox1.Controls.Add(this.textBox14);
            this.groupBox1.Controls.Add(this.textBox15);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(7, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1018, 118);
            this.groupBox1.TabIndex = 127;
            this.groupBox1.TabStop = false;
            // 
            // dtps
            // 
            this.dtps.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtps.Location = new System.Drawing.Point(62, 44);
            this.dtps.Name = "dtps";
            this.dtps.Size = new System.Drawing.Size(107, 20);
            this.dtps.TabIndex = 138;
            // 
            // dtpe
            // 
            this.dtpe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpe.Location = new System.Drawing.Point(192, 44);
            this.dtpe.Name = "dtpe";
            this.dtpe.Size = new System.Drawing.Size(110, 20);
            this.dtpe.TabIndex = 139;
            // 
            // 품번2
            // 
            this.품번2.Location = new System.Drawing.Point(192, 70);
            this.품번2.Name = "품번2";
            this.품번2.Size = new System.Drawing.Size(110, 20);
            this.품번2.TabIndex = 140;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(9, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 11);
            this.label4.TabIndex = 141;
            this.label4.Text = "품목번호";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(175, 73);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(11, 11);
            this.label12.TabIndex = 142;
            this.label12.Text = "~";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(308, 41);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(84, 23);
            this.button5.TabIndex = 134;
            this.button5.Text = "조회";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // 수주번호1
            // 
            this.수주번호1.HeaderText = "수주번호1";
            this.수주번호1.Name = "수주번호1";
            // 
            // 수주번호2
            // 
            this.수주번호2.HeaderText = "수주번호2";
            this.수주번호2.Name = "수주번호2";
            // 
            // 제품번호
            // 
            this.제품번호.HeaderText = "제품번호";
            this.제품번호.Name = "제품번호";
            // 
            // 주문수량
            // 
            this.주문수량.HeaderText = "주문수량";
            this.주문수량.Name = "주문수량";
            // 
            // 납품업체번호
            // 
            this.납품업체번호.HeaderText = "납품업체번호";
            this.납품업체번호.Name = "납품업체번호";
            // 
            // 주문일
            // 
            this.주문일.HeaderText = "주문일";
            this.주문일.Name = "주문일";
            // 
            // 납기일
            // 
            this.납기일.HeaderText = "납기일";
            this.납기일.Name = "납기일";
            // 
            // 출고
            // 
            this.출고.HeaderText = "출고";
            this.출고.Name = "출고";
            // 
            // 출고처리
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Name = "출고처리";
            this.Size = new System.Drawing.Size(1044, 645);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox21;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox 품번1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox 고객이름;
        private System.Windows.Forms.TextBox 고객번호;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox 품번2;
        private System.Windows.Forms.DateTimePicker dtpe;
        private System.Windows.Forms.DateTimePicker dtps;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridViewTextBoxColumn 수주번호1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 수주번호2;
        private System.Windows.Forms.DataGridViewTextBoxColumn 제품번호;
        private System.Windows.Forms.DataGridViewTextBoxColumn 주문수량;
        private System.Windows.Forms.DataGridViewTextBoxColumn 납품업체번호;
        private System.Windows.Forms.DataGridViewTextBoxColumn 주문일;
        private System.Windows.Forms.DataGridViewTextBoxColumn 납기일;
        private System.Windows.Forms.DataGridViewCheckBoxColumn 출고;
    }
}
