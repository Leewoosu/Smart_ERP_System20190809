﻿namespace SMART_ERP_System.MenuUserControl
{
    partial class 재무상태표
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv재무상태표 = new System.Windows.Forms.DataGridView();
            this.계정과목DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.당기금액차변DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.당기금액대변DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.전기금액차변DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.전기금액대변DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.재무상태표BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp입력날짜 = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.txb회사명 = new System.Windows.Forms.TextBox();
            this.cbb회사코드 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.회사등록BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv재무상태표)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.재무상태표BindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.회사등록BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.button8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1041, 651);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv재무상태표);
            this.panel1.Location = new System.Drawing.Point(7, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1025, 513);
            this.panel1.TabIndex = 99;
            // 
            // dgv재무상태표
            // 
            this.dgv재무상태표.AllowUserToAddRows = false;
            this.dgv재무상태표.AllowUserToDeleteRows = false;
            this.dgv재무상태표.AutoGenerateColumns = false;
            this.dgv재무상태표.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv재무상태표.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv재무상태표.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.계정과목DataGridViewTextBoxColumn,
            this.당기금액차변DataGridViewTextBoxColumn,
            this.당기금액대변DataGridViewTextBoxColumn,
            this.전기금액차변DataGridViewTextBoxColumn,
            this.전기금액대변DataGridViewTextBoxColumn});
            this.dgv재무상태표.DataSource = this.재무상태표BindingSource;
            this.dgv재무상태표.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv재무상태표.Location = new System.Drawing.Point(0, 0);
            this.dgv재무상태표.Name = "dgv재무상태표";
            this.dgv재무상태표.ReadOnly = true;
            this.dgv재무상태표.RowHeadersVisible = false;
            this.dgv재무상태표.RowTemplate.Height = 23;
            this.dgv재무상태표.Size = new System.Drawing.Size(1025, 513);
            this.dgv재무상태표.TabIndex = 88;
            this.dgv재무상태표.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.Dgv재무상태표_CellFormatting);
            this.dgv재무상태표.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.Dgv재무상태표_CellPainting);
            this.dgv재무상태표.ColumnWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.Dgv재무상태표_ColumnWidthChanged);
            this.dgv재무상태표.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Dgv재무상태표_Scroll);
            this.dgv재무상태표.Paint += new System.Windows.Forms.PaintEventHandler(this.Dgv재무상태표_Paint);
            // 
            // 계정과목DataGridViewTextBoxColumn
            // 
            this.계정과목DataGridViewTextBoxColumn.DataPropertyName = "계정과목";
            this.계정과목DataGridViewTextBoxColumn.HeaderText = "계정과목";
            this.계정과목DataGridViewTextBoxColumn.Name = "계정과목DataGridViewTextBoxColumn";
            this.계정과목DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 당기금액차변DataGridViewTextBoxColumn
            // 
            this.당기금액차변DataGridViewTextBoxColumn.DataPropertyName = "당기금액차변";
            this.당기금액차변DataGridViewTextBoxColumn.HeaderText = "당기금액차변";
            this.당기금액차변DataGridViewTextBoxColumn.Name = "당기금액차변DataGridViewTextBoxColumn";
            this.당기금액차변DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 당기금액대변DataGridViewTextBoxColumn
            // 
            this.당기금액대변DataGridViewTextBoxColumn.DataPropertyName = "당기금액대변";
            this.당기금액대변DataGridViewTextBoxColumn.HeaderText = "당기금액대변";
            this.당기금액대변DataGridViewTextBoxColumn.Name = "당기금액대변DataGridViewTextBoxColumn";
            this.당기금액대변DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 전기금액차변DataGridViewTextBoxColumn
            // 
            this.전기금액차변DataGridViewTextBoxColumn.DataPropertyName = "전기금액차변";
            this.전기금액차변DataGridViewTextBoxColumn.HeaderText = "전기금액차변";
            this.전기금액차변DataGridViewTextBoxColumn.Name = "전기금액차변DataGridViewTextBoxColumn";
            this.전기금액차변DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 전기금액대변DataGridViewTextBoxColumn
            // 
            this.전기금액대변DataGridViewTextBoxColumn.DataPropertyName = "전기금액대변";
            this.전기금액대변DataGridViewTextBoxColumn.HeaderText = "전기금액대변";
            this.전기금액대변DataGridViewTextBoxColumn.Name = "전기금액대변DataGridViewTextBoxColumn";
            this.전기금액대변DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 재무상태표BindingSource
            // 
            this.재무상태표BindingSource.DataSource = typeof(ClassLibrary.재무상태표);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.dtp입력날짜);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txb회사명);
            this.groupBox3.Controls.Add(this.cbb회사코드);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(7, 30);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1025, 44);
            this.groupBox3.TabIndex = 88;
            this.groupBox3.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("굴림", 10F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "0.       원",
            "1. 천   원",
            "2. 백만원"});
            this.comboBox1.Location = new System.Drawing.Point(717, 10);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(59, 21);
            this.comboBox1.TabIndex = 114;
            this.comboBox1.Text = "금액";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(671, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 22);
            this.label4.TabIndex = 113;
            this.label4.Text = "단위";
            // 
            // dtp입력날짜
            // 
            this.dtp입력날짜.CustomFormat = "yyyy-MM-dd";
            this.dtp입력날짜.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp입력날짜.Location = new System.Drawing.Point(417, 10);
            this.dtp입력날짜.Name = "dtp입력날짜";
            this.dtp입력날짜.Size = new System.Drawing.Size(120, 21);
            this.dtp입력날짜.TabIndex = 112;
            this.dtp입력날짜.Value = new System.DateTime(2019, 7, 31, 17, 29, 0, 0);
            this.dtp입력날짜.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Dtp입력날짜_KeyDown);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label12.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(376, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 22);
            this.label12.TabIndex = 111;
            this.label12.Text = "기간";
            // 
            // txb회사명
            // 
            this.txb회사명.Location = new System.Drawing.Point(260, 9);
            this.txb회사명.Name = "txb회사명";
            this.txb회사명.Size = new System.Drawing.Size(82, 21);
            this.txb회사명.TabIndex = 110;
            this.txb회사명.Text = "회사명";
            // 
            // cbb회사코드
            // 
            this.cbb회사코드.DataSource = this.회사등록BindingSource;
            this.cbb회사코드.DisplayMember = "회사코드";
            this.cbb회사코드.Font = new System.Drawing.Font("굴림", 10F);
            this.cbb회사코드.FormattingEnabled = true;
            this.cbb회사코드.Location = new System.Drawing.Point(174, 9);
            this.cbb회사코드.Name = "cbb회사코드";
            this.cbb회사코드.Size = new System.Drawing.Size(80, 21);
            this.cbb회사코드.TabIndex = 109;
            this.cbb회사코드.ValueMember = "회사코드";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(106, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 22);
            this.label2.TabIndex = 108;
            this.label2.Text = "회계단위";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(656, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 98;
            this.button5.Text = "양식선택";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("굴림체", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(55, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 25);
            this.label8.TabIndex = 97;
            this.label8.Text = "재무상태표";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(818, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 96;
            this.button7.Text = "환경설정";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(737, 2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 95;
            this.button8.Text = "통합계정";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Location = new System.Drawing.Point(7, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(1025, 1);
            this.label9.TabIndex = 94;
            // 
            // 회사등록BindingSource
            // 
            this.회사등록BindingSource.DataSource = typeof(ClassLibrary.회사등록);
            // 
            // 재무상태표
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "재무상태표";
            this.Size = new System.Drawing.Size(1044, 645);
            this.Load += new System.EventHandler(this.재무상태표_Load);
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv재무상태표)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.재무상태표BindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.회사등록BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp입력날짜;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txb회사명;
        private System.Windows.Forms.ComboBox cbb회사코드;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv재무상태표;
        private System.Windows.Forms.DataGridViewTextBoxColumn 계정과목DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 당기금액차변DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 당기금액대변DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 전기금액차변DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 전기금액대변DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource 재무상태표BindingSource;
        private System.Windows.Forms.BindingSource 회사등록BindingSource;
    }
}
