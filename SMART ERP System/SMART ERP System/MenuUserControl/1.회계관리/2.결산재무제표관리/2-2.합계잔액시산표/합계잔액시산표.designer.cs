namespace SMART_ERP_System.MenuUserControl
{
    partial class 합계잔액시산표
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp입력날짜 = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.txb회사명 = new System.Windows.Forms.TextBox();
            this.cbb회사코드 = new System.Windows.Forms.ComboBox();
            this.회사등록BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txb대변잔액총액 = new System.Windows.Forms.TextBox();
            this.txb대변합계총액 = new System.Windows.Forms.TextBox();
            this.txb차변합계총액 = new System.Windows.Forms.TextBox();
            this.txb차변잔액총액 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv합계잔액시산표 = new System.Windows.Forms.DataGridView();
            this.합계잔액시산표BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.차변잔액 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.차변합계 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.계정과목 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.대변합계 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.대변잔액 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.회사등록BindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv합계잔액시산표)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.합계잔액시산표BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.splitContainer1);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
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
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(3, 31);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel2.Controls.Add(this.dgv합계잔액시산표);
            this.splitContainer1.Size = new System.Drawing.Size(1035, 617);
            this.splitContainer1.SplitterDistance = 38;
            this.splitContainer1.TabIndex = 106;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dtp입력날짜);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txb회사명);
            this.groupBox2.Controls.Add(this.cbb회사코드);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1035, 42);
            this.groupBox2.TabIndex = 106;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(974, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 112;
            this.label1.Text = "단위 : 원";
            // 
            // dtp입력날짜
            // 
            this.dtp입력날짜.CustomFormat = "yyyy-MM-dd";
            this.dtp입력날짜.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp입력날짜.Location = new System.Drawing.Point(526, 9);
            this.dtp입력날짜.Name = "dtp입력날짜";
            this.dtp입력날짜.Size = new System.Drawing.Size(121, 21);
            this.dtp입력날짜.TabIndex = 111;
            this.dtp입력날짜.Value = new System.DateTime(2019, 7, 31, 16, 36, 0, 0);
            this.dtp입력날짜.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Dtp입력날짜_KeyDown);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label12.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(485, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 22);
            this.label12.TabIndex = 110;
            this.label12.Text = "기간";
            // 
            // txb회사명
            // 
            this.txb회사명.Enabled = false;
            this.txb회사명.Location = new System.Drawing.Point(333, 9);
            this.txb회사명.Name = "txb회사명";
            this.txb회사명.Size = new System.Drawing.Size(82, 21);
            this.txb회사명.TabIndex = 109;
            // 
            // cbb회사코드
            // 
            this.cbb회사코드.DataSource = this.회사등록BindingSource;
            this.cbb회사코드.DisplayMember = "회사코드";
            this.cbb회사코드.Enabled = false;
            this.cbb회사코드.Font = new System.Drawing.Font("굴림", 10F);
            this.cbb회사코드.FormattingEnabled = true;
            this.cbb회사코드.Location = new System.Drawing.Point(252, 8);
            this.cbb회사코드.Name = "cbb회사코드";
            this.cbb회사코드.Size = new System.Drawing.Size(75, 21);
            this.cbb회사코드.TabIndex = 108;
            this.cbb회사코드.ValueMember = "회사코드";
            // 
            // 회사등록BindingSource
            // 
            this.회사등록BindingSource.DataSource = typeof(ClassLibrary.회사등록);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(184, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 22);
            this.label2.TabIndex = 107;
            this.label2.Text = "회계단위";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox3.Controls.Add(this.txb대변잔액총액);
            this.groupBox3.Controls.Add(this.txb대변합계총액);
            this.groupBox3.Controls.Add(this.txb차변합계총액);
            this.groupBox3.Controls.Add(this.txb차변잔액총액);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 493);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1035, 60);
            this.groupBox3.TabIndex = 118;
            this.groupBox3.TabStop = false;
            // 
            // txb대변잔액총액
            // 
            this.txb대변잔액총액.Location = new System.Drawing.Point(788, 17);
            this.txb대변잔액총액.Name = "txb대변잔액총액";
            this.txb대변잔액총액.Size = new System.Drawing.Size(169, 21);
            this.txb대변잔액총액.TabIndex = 122;
            this.txb대변잔액총액.Text = "[금액]";
            // 
            // txb대변합계총액
            // 
            this.txb대변합계총액.Location = new System.Drawing.Point(602, 17);
            this.txb대변합계총액.Name = "txb대변합계총액";
            this.txb대변합계총액.Size = new System.Drawing.Size(169, 21);
            this.txb대변합계총액.TabIndex = 121;
            this.txb대변합계총액.Text = "[금액]";
            // 
            // txb차변합계총액
            // 
            this.txb차변합계총액.Location = new System.Drawing.Point(267, 18);
            this.txb차변합계총액.Name = "txb차변합계총액";
            this.txb차변합계총액.Size = new System.Drawing.Size(169, 21);
            this.txb차변합계총액.TabIndex = 120;
            this.txb차변합계총액.Text = "[금액]";
            // 
            // txb차변잔액총액
            // 
            this.txb차변잔액총액.Location = new System.Drawing.Point(75, 18);
            this.txb차변잔액총액.Name = "txb차변잔액총액";
            this.txb차변잔액총액.Size = new System.Drawing.Size(169, 21);
            this.txb차변잔액총액.TabIndex = 119;
            this.txb차변잔액총액.Text = "[금액]";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(482, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 22);
            this.label3.TabIndex = 118;
            this.label3.Text = "합       계";
            // 
            // dgv합계잔액시산표
            // 
            this.dgv합계잔액시산표.AllowUserToAddRows = false;
            this.dgv합계잔액시산표.AllowUserToDeleteRows = false;
            this.dgv합계잔액시산표.AllowUserToResizeColumns = false;
            this.dgv합계잔액시산표.AllowUserToResizeRows = false;
            this.dgv합계잔액시산표.AutoGenerateColumns = false;
            this.dgv합계잔액시산표.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv합계잔액시산표.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv합계잔액시산표.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.차변잔액,
            this.차변합계,
            this.계정과목,
            this.대변합계,
            this.대변잔액});
            this.dgv합계잔액시산표.DataSource = this.합계잔액시산표BindingSource;
            this.dgv합계잔액시산표.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgv합계잔액시산표.Location = new System.Drawing.Point(0, 0);
            this.dgv합계잔액시산표.Name = "dgv합계잔액시산표";
            this.dgv합계잔액시산표.ReadOnly = true;
            this.dgv합계잔액시산표.RowHeadersVisible = false;
            this.dgv합계잔액시산표.RowTemplate.Height = 23;
            this.dgv합계잔액시산표.Size = new System.Drawing.Size(1035, 493);
            this.dgv합계잔액시산표.TabIndex = 111;
            this.dgv합계잔액시산표.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.Dgv합계잔액시산표_CellFormatting);
            this.dgv합계잔액시산표.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.Dgv합계잔액시산표_CellPainting);
            this.dgv합계잔액시산표.ColumnWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.Dgv합계잔액시산표_ColumnWidthChanged);
            this.dgv합계잔액시산표.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Dgv합계잔액시산표_Scroll);
            this.dgv합계잔액시산표.Paint += new System.Windows.Forms.PaintEventHandler(this.Dgv합계잔액시산표_Paint);
            // 
            // 합계잔액시산표BindingSource
            // 
            this.합계잔액시산표BindingSource.DataSource = typeof(ClassLibrary.합계잔액시산표);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(656, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 99;
            this.button5.TabStop = false;
            this.button5.Text = "감가상각";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(575, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 98;
            this.button4.TabStop = false;
            this.button4.Text = "계정생성";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(494, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 97;
            this.button3.TabStop = false;
            this.button3.Text = "분개";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(415, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 96;
            this.button2.TabStop = false;
            this.button2.Text = "새로작성";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("굴림체", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(55, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 25);
            this.label8.TabIndex = 95;
            this.label8.Text = "합계잔액시산표";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(818, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 94;
            this.button7.TabStop = false;
            this.button7.Text = "조건검색";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Visible = false;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(737, 2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 93;
            this.button8.TabStop = false;
            this.button8.Text = "적요등록";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Visible = false;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Location = new System.Drawing.Point(7, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(1025, 1);
            this.label9.TabIndex = 92;
            // 
            // 차변잔액
            // 
            this.차변잔액.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.차변잔액.DataPropertyName = "차변잔액";
            this.차변잔액.HeaderText = "차변잔액";
            this.차변잔액.Name = "차변잔액";
            this.차변잔액.ReadOnly = true;
            // 
            // 차변합계
            // 
            this.차변합계.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.차변합계.DataPropertyName = "차변합계";
            this.차변합계.HeaderText = "차변합계";
            this.차변합계.Name = "차변합계";
            this.차변합계.ReadOnly = true;
            // 
            // 계정과목
            // 
            this.계정과목.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.계정과목.DataPropertyName = "계정과목";
            this.계정과목.HeaderText = "계정과목";
            this.계정과목.Name = "계정과목";
            this.계정과목.ReadOnly = true;
            // 
            // 대변합계
            // 
            this.대변합계.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.대변합계.DataPropertyName = "대변합계";
            this.대변합계.HeaderText = "대변합계";
            this.대변합계.Name = "대변합계";
            this.대변합계.ReadOnly = true;
            // 
            // 대변잔액
            // 
            this.대변잔액.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.대변잔액.DataPropertyName = "대변잔액";
            this.대변잔액.HeaderText = "대변잔액";
            this.대변잔액.Name = "대변잔액";
            this.대변잔액.ReadOnly = true;
            // 
            // 합계잔액시산표
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "합계잔액시산표";
            this.Size = new System.Drawing.Size(1044, 645);
            this.Load += new System.EventHandler(this.합계잔액시산표_Load);
            this.groupBox1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.회사등록BindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv합계잔액시산표)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.합계잔액시산표BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtp입력날짜;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txb회사명;
        private System.Windows.Forms.ComboBox cbb회사코드;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgv합계잔액시산표;
        private System.Windows.Forms.TextBox txb대변잔액총액;
        private System.Windows.Forms.TextBox txb대변합계총액;
        private System.Windows.Forms.TextBox txb차변합계총액;
        private System.Windows.Forms.TextBox txb차변잔액총액;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource 합계잔액시산표BindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource 회사등록BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn 차변잔액;
        private System.Windows.Forms.DataGridViewTextBoxColumn 차변합계;
        private System.Windows.Forms.DataGridViewTextBoxColumn 계정과목;
        private System.Windows.Forms.DataGridViewTextBoxColumn 대변합계;
        private System.Windows.Forms.DataGridViewTextBoxColumn 대변잔액;
    }
}
