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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gbx세부항목 = new System.Windows.Forms.GroupBox();
            this.txb관할세무서코드 = new System.Windows.Forms.TextBox();
            this.btnCodeHelper = new System.Windows.Forms.Button();
            this.txb관할세무서명 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp페업일 = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.dtp개업일 = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.txb종목 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txb업태 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txb전화번호뒤 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txb전화번호앞 = new System.Windows.Forms.TextBox();
            this.txb사업장번지 = new System.Windows.Forms.TextBox();
            this.txb사업장주소 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txb대표자명 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txb사업자등록번호 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv사업장 = new System.Windows.Forms.DataGridView();
            this.사업장코드DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.사업장명DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.사업장등록BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbx세부항목.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv사업장)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.사업장등록BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Controls.Add(this.dgv사업장);
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
            this.tabControl1.Leave += new System.EventHandler(this.TabControl1_Leave);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gbx세부항목);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(708, 585);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "기본등록사항";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gbx세부항목
            // 
            this.gbx세부항목.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gbx세부항목.Controls.Add(this.txb관할세무서코드);
            this.gbx세부항목.Controls.Add(this.btnCodeHelper);
            this.gbx세부항목.Controls.Add(this.txb관할세무서명);
            this.gbx세부항목.Controls.Add(this.label3);
            this.gbx세부항목.Controls.Add(this.label1);
            this.gbx세부항목.Controls.Add(this.dtp페업일);
            this.gbx세부항목.Controls.Add(this.label15);
            this.gbx세부항목.Controls.Add(this.dtp개업일);
            this.gbx세부항목.Controls.Add(this.label14);
            this.gbx세부항목.Controls.Add(this.txb종목);
            this.gbx세부항목.Controls.Add(this.label12);
            this.gbx세부항목.Controls.Add(this.txb업태);
            this.gbx세부항목.Controls.Add(this.label11);
            this.gbx세부항목.Controls.Add(this.txb전화번호뒤);
            this.gbx세부항목.Controls.Add(this.label10);
            this.gbx세부항목.Controls.Add(this.txb전화번호앞);
            this.gbx세부항목.Controls.Add(this.txb사업장번지);
            this.gbx세부항목.Controls.Add(this.txb사업장주소);
            this.gbx세부항목.Controls.Add(this.label6);
            this.gbx세부항목.Controls.Add(this.txb대표자명);
            this.gbx세부항목.Controls.Add(this.label4);
            this.gbx세부항목.Controls.Add(this.txb사업자등록번호);
            this.gbx세부항목.Controls.Add(this.label2);
            this.gbx세부항목.Location = new System.Drawing.Point(0, 0);
            this.gbx세부항목.Name = "gbx세부항목";
            this.gbx세부항목.Size = new System.Drawing.Size(702, 585);
            this.gbx세부항목.TabIndex = 0;
            this.gbx세부항목.TabStop = false;
            // 
            // txb관할세무서코드
            // 
            this.txb관할세무서코드.Location = new System.Drawing.Point(124, 403);
            this.txb관할세무서코드.Name = "txb관할세무서코드";
            this.txb관할세무서코드.Size = new System.Drawing.Size(59, 21);
            this.txb관할세무서코드.TabIndex = 152;
            this.txb관할세무서코드.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txb관할세무서코드_KeyDown);
            // 
            // btnCodeHelper
            // 
            this.btnCodeHelper.Image = global::SMART_ERP_System.Properties.Resources.findIcon;
            this.btnCodeHelper.Location = new System.Drawing.Point(183, 401);
            this.btnCodeHelper.Name = "btnCodeHelper";
            this.btnCodeHelper.Size = new System.Drawing.Size(22, 23);
            this.btnCodeHelper.TabIndex = 151;
            this.btnCodeHelper.UseVisualStyleBackColor = true;
            this.btnCodeHelper.Click += new System.EventHandler(this.BtnCodeHelper_Click);
            // 
            // txb관할세무서명
            // 
            this.txb관할세무서명.Location = new System.Drawing.Point(211, 402);
            this.txb관할세무서명.Name = "txb관할세무서명";
            this.txb관할세무서명.Size = new System.Drawing.Size(82, 21);
            this.txb관할세무서명.TabIndex = 150;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(40, 405);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 22);
            this.label3.TabIndex = 148;
            this.label3.Text = "관할세무서";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(37, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 22);
            this.label1.TabIndex = 147;
            this.label1.Text = "사업장번지";
            // 
            // dtp페업일
            // 
            this.dtp페업일.CustomFormat = "yyyy-MM-dd";
            this.dtp페업일.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp페업일.Location = new System.Drawing.Point(123, 504);
            this.dtp페업일.Name = "dtp페업일";
            this.dtp페업일.Size = new System.Drawing.Size(117, 21);
            this.dtp페업일.TabIndex = 146;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label15.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(39, 506);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 22);
            this.label15.TabIndex = 145;
            this.label15.Text = "폐업년월일";
            // 
            // dtp개업일
            // 
            this.dtp개업일.CustomFormat = "yyyy-MM-dd";
            this.dtp개업일.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp개업일.Location = new System.Drawing.Point(123, 458);
            this.dtp개업일.Name = "dtp개업일";
            this.dtp개업일.Size = new System.Drawing.Size(117, 21);
            this.dtp개업일.TabIndex = 144;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label14.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(39, 460);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 22);
            this.label14.TabIndex = 143;
            this.label14.Text = "개업년월일";
            // 
            // txb종목
            // 
            this.txb종목.Location = new System.Drawing.Point(123, 354);
            this.txb종목.Name = "txb종목";
            this.txb종목.Size = new System.Drawing.Size(170, 21);
            this.txb종목.TabIndex = 140;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(82, 356);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 22);
            this.label12.TabIndex = 139;
            this.label12.Text = "종목";
            // 
            // txb업태
            // 
            this.txb업태.Location = new System.Drawing.Point(123, 304);
            this.txb업태.Name = "txb업태";
            this.txb업태.Size = new System.Drawing.Size(170, 21);
            this.txb업태.TabIndex = 138;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(82, 306);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 22);
            this.label11.TabIndex = 137;
            this.label11.Text = "업태";
            // 
            // txb전화번호뒤
            // 
            this.txb전화번호뒤.Location = new System.Drawing.Point(189, 249);
            this.txb전화번호뒤.Name = "txb전화번호뒤";
            this.txb전화번호뒤.Size = new System.Drawing.Size(212, 21);
            this.txb전화번호뒤.TabIndex = 136;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(8, 251);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 22);
            this.label10.TabIndex = 135;
            this.label10.Text = "사업장전화번호";
            // 
            // txb전화번호앞
            // 
            this.txb전화번호앞.Location = new System.Drawing.Point(123, 249);
            this.txb전화번호앞.Name = "txb전화번호앞";
            this.txb전화번호앞.Size = new System.Drawing.Size(60, 21);
            this.txb전화번호앞.TabIndex = 134;
            // 
            // txb사업장번지
            // 
            this.txb사업장번지.Location = new System.Drawing.Point(124, 195);
            this.txb사업장번지.Name = "txb사업장번지";
            this.txb사업장번지.Size = new System.Drawing.Size(364, 21);
            this.txb사업장번지.TabIndex = 133;
            // 
            // txb사업장주소
            // 
            this.txb사업장주소.Location = new System.Drawing.Point(124, 141);
            this.txb사업장주소.Name = "txb사업장주소";
            this.txb사업장주소.Size = new System.Drawing.Size(364, 21);
            this.txb사업장주소.TabIndex = 131;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(37, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 22);
            this.label6.TabIndex = 130;
            this.label6.Text = "사업장주소";
            // 
            // txb대표자명
            // 
            this.txb대표자명.Location = new System.Drawing.Point(124, 85);
            this.txb대표자명.Name = "txb대표자명";
            this.txb대표자명.Size = new System.Drawing.Size(225, 21);
            this.txb대표자명.TabIndex = 126;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(40, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 22);
            this.label4.TabIndex = 125;
            this.label4.Text = "대표자성명";
            // 
            // txb사업자등록번호
            // 
            this.txb사업자등록번호.Location = new System.Drawing.Point(124, 32);
            this.txb사업자등록번호.Name = "txb사업자등록번호";
            this.txb사업자등록번호.Size = new System.Drawing.Size(225, 21);
            this.txb사업자등록번호.TabIndex = 124;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(11, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 22);
            this.label2.TabIndex = 123;
            this.label2.Text = "사업자등록번호";
            // 
            // dgv사업장
            // 
            this.dgv사업장.AutoGenerateColumns = false;
            this.dgv사업장.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv사업장.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv사업장.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.사업장코드DataGridViewTextBoxColumn,
            this.사업장명DataGridViewTextBoxColumn});
            this.dgv사업장.DataSource = this.사업장등록BindingSource;
            this.dgv사업장.Location = new System.Drawing.Point(6, 29);
            this.dgv사업장.Name = "dgv사업장";
            this.dgv사업장.RowTemplate.Height = 23;
            this.dgv사업장.Size = new System.Drawing.Size(297, 611);
            this.dgv사업장.TabIndex = 98;
            this.dgv사업장.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv사업장_CellEnter);
            this.dgv사업장.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Dgv사업장_KeyDown);
            // 
            // 사업장코드DataGridViewTextBoxColumn
            // 
            this.사업장코드DataGridViewTextBoxColumn.DataPropertyName = "사업장코드";
            this.사업장코드DataGridViewTextBoxColumn.HeaderText = "사업장코드";
            this.사업장코드DataGridViewTextBoxColumn.Name = "사업장코드DataGridViewTextBoxColumn";
            // 
            // 사업장명DataGridViewTextBoxColumn
            // 
            this.사업장명DataGridViewTextBoxColumn.DataPropertyName = "사업장명";
            this.사업장명DataGridViewTextBoxColumn.HeaderText = "사업장명";
            this.사업장명DataGridViewTextBoxColumn.Name = "사업장명DataGridViewTextBoxColumn";
            // 
            // 사업장등록BindingSource
            // 
            this.사업장등록BindingSource.DataSource = typeof(ClassLibrary.사업장등록);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("굴림체", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
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
            this.gbx세부항목.ResumeLayout(false);
            this.gbx세부항목.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv사업장)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.사업장등록BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgv사업장;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gbx세부항목;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp페업일;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtp개업일;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txb종목;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txb업태;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txb전화번호뒤;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txb전화번호앞;
        private System.Windows.Forms.TextBox txb사업장번지;
        private System.Windows.Forms.TextBox txb사업장주소;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txb대표자명;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb사업자등록번호;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb관할세무서명;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn 사업장코드DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 사업장명DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource 사업장등록BindingSource;
        private System.Windows.Forms.Button btnCodeHelper;
        private System.Windows.Forms.TextBox txb관할세무서코드;
    }
}
