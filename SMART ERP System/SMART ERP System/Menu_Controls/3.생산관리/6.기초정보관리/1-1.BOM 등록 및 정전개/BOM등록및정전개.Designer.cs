namespace SMART_ERP_System.MenuUserControl
{
    partial class BOM등록및정전개
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
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.검색btn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.자재번호 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.수량 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.공정순서 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.모품목 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbxLocal = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txbweiht = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbxJo = new System.Windows.Forms.ComboBox();
            this.txbQty = new System.Windows.Forms.TextBox();
            this.txbSpac = new System.Windows.Forms.TextBox();
            this.txbMaterialName = new System.Windows.Forms.TextBox();
            this.txbMaterialNum = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(7, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1018, 1);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.검색btn);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(7, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1018, 80);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(238, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "▷▶▷▶";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(297, 20);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 9;
            // 
            // 검색btn
            // 
            this.검색btn.Location = new System.Drawing.Point(191, 17);
            this.검색btn.Name = "검색btn";
            this.검색btn.Size = new System.Drawing.Size(41, 24);
            this.검색btn.TabIndex = 3;
            this.검색btn.Text = "검색";
            this.검색btn.UseVisualStyleBackColor = true;
            this.검색btn.Click += new System.EventHandler(this.Button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(85, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox1_KeyDown);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(403, 20);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(81, 21);
            this.button3.TabIndex = 8;
            this.button3.Text = "BOM 복사";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(41, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "모품목";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림체", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(45, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "BOM등록 및 정전개";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.treeView1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 146);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1016, 496);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowDrop = true;
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.자재번호,
            this.수량,
            this.공정순서,
            this.모품목});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(502, 490);
            this.dataGridView2.TabIndex = 11;
            this.dataGridView2.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.DataGridView2_CellBeginEdit);
            this.dataGridView2.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView2_CellEndEdit);
            this.dataGridView2.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView2_CellEnter);
            this.dataGridView2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataGridView2_KeyDown);
            // 
            // No
            // 
            this.No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.No.HeaderText = "No";
            this.No.Name = "No";
            this.No.ReadOnly = true;
            this.No.Width = 45;
            // 
            // 자재번호
            // 
            this.자재번호.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.자재번호.HeaderText = "자재번호";
            this.자재번호.Name = "자재번호";
            this.자재번호.Width = 140;
            // 
            // 수량
            // 
            this.수량.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.수량.HeaderText = "수량";
            this.수량.Name = "수량";
            this.수량.Width = 65;
            // 
            // 공정순서
            // 
            this.공정순서.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.공정순서.HeaderText = "공정순서";
            this.공정순서.Name = "공정순서";
            this.공정순서.Width = 65;
            // 
            // 모품목
            // 
            this.모품목.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.모품목.HeaderText = "모품목";
            this.모품목.Name = "모품목";
            this.모품목.Width = 140;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(511, 3);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(248, 490);
            this.treeView1.TabIndex = 12;
            this.treeView1.Click += new System.EventHandler(this.TreeView1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbxLocal);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txbweiht);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.cbxJo);
            this.groupBox2.Controls.Add(this.txbQty);
            this.groupBox2.Controls.Add(this.txbSpac);
            this.groupBox2.Controls.Add(this.txbMaterialName);
            this.groupBox2.Controls.Add(this.txbMaterialNum);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(765, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(248, 490);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "속성변경";
            // 
            // cbxLocal
            // 
            this.cbxLocal.FormattingEnabled = true;
            this.cbxLocal.Location = new System.Drawing.Point(169, 114);
            this.cbxLocal.Name = "cbxLocal";
            this.cbxLocal.Size = new System.Drawing.Size(73, 20);
            this.cbxLocal.TabIndex = 18;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(134, 117);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(31, 12);
            this.label15.TabIndex = 17;
            this.label15.Text = "단위";
            // 
            // txbweiht
            // 
            this.txbweiht.Location = new System.Drawing.Point(41, 166);
            this.txbweiht.Name = "txbweiht";
            this.txbweiht.Size = new System.Drawing.Size(58, 21);
            this.txbweiht.TabIndex = 16;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(6, 169);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 12);
            this.label14.TabIndex = 15;
            this.label14.Text = "무게";
            // 
            // cbxJo
            // 
            this.cbxJo.FormattingEnabled = true;
            this.cbxJo.Location = new System.Drawing.Point(40, 141);
            this.cbxJo.Name = "cbxJo";
            this.cbxJo.Size = new System.Drawing.Size(59, 20);
            this.cbxJo.TabIndex = 12;
            // 
            // txbQty
            // 
            this.txbQty.Location = new System.Drawing.Point(41, 114);
            this.txbQty.Name = "txbQty";
            this.txbQty.Size = new System.Drawing.Size(58, 21);
            this.txbQty.TabIndex = 10;
            // 
            // txbSpac
            // 
            this.txbSpac.Location = new System.Drawing.Point(41, 87);
            this.txbSpac.Name = "txbSpac";
            this.txbSpac.Size = new System.Drawing.Size(201, 21);
            this.txbSpac.TabIndex = 9;
            // 
            // txbMaterialName
            // 
            this.txbMaterialName.Location = new System.Drawing.Point(41, 60);
            this.txbMaterialName.Name = "txbMaterialName";
            this.txbMaterialName.Size = new System.Drawing.Size(201, 21);
            this.txbMaterialName.TabIndex = 8;
            // 
            // txbMaterialNum
            // 
            this.txbMaterialNum.Location = new System.Drawing.Point(41, 33);
            this.txbMaterialNum.Name = "txbMaterialNum";
            this.txbMaterialNum.Size = new System.Drawing.Size(201, 21);
            this.txbMaterialNum.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(6, 144);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 12);
            this.label13.TabIndex = 6;
            this.label13.Text = "조달";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(6, 117);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 12);
            this.label12.TabIndex = 5;
            this.label12.Text = "수량";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(105, 169);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 12);
            this.label10.TabIndex = 3;
            this.label10.Text = "KG";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(6, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 12);
            this.label9.TabIndex = 2;
            this.label9.Text = "단가";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(6, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 12);
            this.label8.TabIndex = 1;
            this.label8.Text = "품명";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(6, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "품번";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(514, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "공정 순서도";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(10, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "BOM정전개";
            // 
            // BOM등록및정전개
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "BOM등록및정전개";
            this.Size = new System.Drawing.Size(1044, 645);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button 검색btn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn 자재번호;
        private System.Windows.Forms.DataGridViewTextBoxColumn 수량;
        private System.Windows.Forms.DataGridViewTextBoxColumn 공정순서;
        private System.Windows.Forms.DataGridViewTextBoxColumn 모품목;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbxJo;
        private System.Windows.Forms.TextBox txbQty;
        private System.Windows.Forms.TextBox txbSpac;
        private System.Windows.Forms.TextBox txbMaterialName;
        private System.Windows.Forms.TextBox txbMaterialNum;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxLocal;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txbweiht;
        private System.Windows.Forms.Label label14;
    }
}
