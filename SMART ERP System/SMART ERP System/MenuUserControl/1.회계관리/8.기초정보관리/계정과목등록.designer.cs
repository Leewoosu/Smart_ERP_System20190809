namespace SMART_ERP_System.MenuUserControl
{
    partial class 계정과목등록
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.계정과목그룹BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.treeView = new System.Windows.Forms.TreeView();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.계정과목그룹BindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.treeView);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(-1, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1042, 651);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(260, 378);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(765, 216);
            this.dataGridView1.TabIndex = 104;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "NO";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "코드";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "관리항목명";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "입력필수";
            this.Column4.Name = "Column4";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox4.Controls.Add(this.textBox7);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(258, 256);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(767, 116);
            this.groupBox4.TabIndex = 103;
            this.groupBox4.TabStop = false;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(24, 34);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(737, 63);
            this.textBox7.TabIndex = 119;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(22, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 22);
            this.label11.TabIndex = 118;
            this.label11.Text = "계정과목설명";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Controls.Add(this.comboBox5);
            this.groupBox3.Controls.Add(this.comboBox2);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.textBox4);
            this.groupBox3.Controls.Add(this.comboBox4);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.comboBox3);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.comboBox7);
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(255, 68);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(770, 182);
            this.groupBox3.TabIndex = 102;
            this.groupBox3.TabStop = false;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Gulim", 10F);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(85, 129);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(75, 21);
            this.comboBox2.TabIndex = 130;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(25, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 22);
            this.label10.TabIndex = 129;
            this.label10.Text = "입력구분";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(484, 83);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(137, 21);
            this.textBox4.TabIndex = 123;
            this.textBox4.Text = "계정명";
            // 
            // comboBox4
            // 
            this.comboBox4.Font = new System.Drawing.Font("Gulim", 10F);
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(403, 82);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(75, 21);
            this.comboBox4.TabIndex = 122;
            this.comboBox4.Text = "계정코드";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(343, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 22);
            this.label6.TabIndex = 121;
            this.label6.Text = "관련계정";
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("Gulim", 10F);
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(228, 82);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(75, 21);
            this.comboBox3.TabIndex = 120;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(166, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 22);
            this.label5.TabIndex = 119;
            this.label5.Text = "차대구분";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(25, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 22);
            this.label4.TabIndex = 117;
            this.label4.Text = "계정구분";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(484, 30);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(137, 21);
            this.textBox2.TabIndex = 116;
            this.textBox2.Text = "계정명";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Gulim", 10F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(403, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(75, 21);
            this.comboBox1.TabIndex = 115;
            this.comboBox1.Text = "계정코드";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(343, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 22);
            this.label1.TabIndex = 113;
            this.label1.Text = "계정코드";
            // 
            // comboBox7
            // 
            this.comboBox7.DataSource = this.계정과목그룹BindingSource;
            this.comboBox7.DisplayMember = "그룹명";
            this.comboBox7.Font = new System.Drawing.Font("Gulim", 10F);
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(85, 30);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(75, 21);
            this.comboBox7.TabIndex = 112;
            this.comboBox7.ValueMember = "그룹코드번호";
            // 
            // 계정과목그룹BindingSource
            // 
            this.계정과목그룹BindingSource.DataSource = typeof(ClassLibrary.계정과목그룹);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(166, 30);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(137, 21);
            this.textBox3.TabIndex = 111;
            this.textBox3.Text = "그룹명";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(25, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 22);
            this.label3.TabIndex = 110;
            this.label3.Text = "그룹코드";
            // 
            // treeView
            // 
            this.treeView.Location = new System.Drawing.Point(7, 68);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(242, 526);
            this.treeView.TabIndex = 101;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(462, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(137, 23);
            this.button4.TabIndex = 100;
            this.button4.Text = "양식선택";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(605, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(137, 23);
            this.button3.TabIndex = 99;
            this.button3.Text = "계정별";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(748, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 23);
            this.button2.TabIndex = 98;
            this.button2.Text = "일괄설정";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(7, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(242, 32);
            this.groupBox2.TabIndex = 96;
            this.groupBox2.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(78, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 21);
            this.textBox1.TabIndex = 98;
            this.textBox1.Text = "2007 NEW 회계기준적용";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Font = new System.Drawing.Font("Gulim", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 22);
            this.label2.TabIndex = 96;
            this.label2.Text = "선택양식";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("GulimChe", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(57, 1);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 24);
            this.label8.TabIndex = 86;
            this.label8.Text = "계정과목등록";
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Location = new System.Drawing.Point(7, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(1018, 1);
            this.label9.TabIndex = 84;
            // 
            // comboBox5
            // 
            this.comboBox5.Font = new System.Drawing.Font("Gulim", 10F);
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(85, 82);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(75, 21);
            this.comboBox5.TabIndex = 131;
            // 
            // 계정과목등록
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "계정과목등록";
            this.Size = new System.Drawing.Size(1044, 645);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.계정과목그룹BindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.BindingSource 계정과목그룹BindingSource;
        private System.Windows.Forms.ComboBox comboBox5;
    }
}
