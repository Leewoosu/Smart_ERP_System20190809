namespace SMART_ERP_System.MenuUserControl
{
    partial class 고정자산등록
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
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dtpModificationDate = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.dtpInputDate = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.txbGeneralDepreciation = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbAcquisitionQuantity = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbDurableYears = new System.Windows.Forms.ComboBox();
            this.cbbDepreciationMethod = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txbAcquisitionCost = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txbNote = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txbEmployeeName = new System.Windows.Forms.TextBox();
            this.cbbEmployeeCode = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txbModelName = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txbProductionCompanyName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txbSize = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txbSupplierName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txbAccountName = new System.Windows.Forms.TextBox();
            this.cbbAccountCode = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txbCompanyName = new System.Windows.Forms.TextBox();
            this.cbbCompanyCode = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnStatementForm = new System.Windows.Forms.Button();
            this.btnAccountTotal = new System.Windows.Forms.Button();
            this.btnSortOrder = new System.Windows.Forms.Button();
            this.btnStatementSearch = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabControl2);
            this.groupBox1.Controls.Add(this.txbAccountName);
            this.groupBox1.Controls.Add(this.cbbAccountCode);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dgvList);
            this.groupBox1.Controls.Add(this.txbCompanyName);
            this.groupBox1.Controls.Add(this.cbbCompanyCode);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnStatementForm);
            this.groupBox1.Controls.Add(this.btnAccountTotal);
            this.groupBox1.Controls.Add(this.btnSortOrder);
            this.groupBox1.Controls.Add(this.btnStatementSearch);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.richTextBox2);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1041, 651);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Location = new System.Drawing.Point(555, 105);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(478, 512);
            this.tabControl2.TabIndex = 95;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.label22);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.label21);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Controls.Add(this.dtpModificationDate);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.dtpInputDate);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.txbGeneralDepreciation);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txbAcquisitionQuantity);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.textBox4);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.cbbDurableYears);
            this.tabPage2.Controls.Add(this.cbbDepreciationMethod);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.textBox10);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.txbAcquisitionCost);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(470, 486);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "주요등록사항";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dtpModificationDate
            // 
            this.dtpModificationDate.Location = new System.Drawing.Point(158, 402);
            this.dtpModificationDate.Name = "dtpModificationDate";
            this.dtpModificationDate.Size = new System.Drawing.Size(173, 21);
            this.dtpModificationDate.TabIndex = 108;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(98, 405);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(130, 18);
            this.label13.TabIndex = 107;
            this.label13.Text = "수정일자";
            // 
            // dtpInputDate
            // 
            this.dtpInputDate.Location = new System.Drawing.Point(158, 366);
            this.dtpInputDate.Name = "dtpInputDate";
            this.dtpInputDate.Size = new System.Drawing.Size(173, 21);
            this.dtpInputDate.TabIndex = 106;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(98, 369);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 18);
            this.label11.TabIndex = 105;
            this.label11.Text = "입력일자";
            // 
            // txbGeneralDepreciation
            // 
            this.txbGeneralDepreciation.Location = new System.Drawing.Point(158, 252);
            this.txbGeneralDepreciation.Name = "txbGeneralDepreciation";
            this.txbGeneralDepreciation.Size = new System.Drawing.Size(225, 21);
            this.txbGeneralDepreciation.TabIndex = 104;
            this.txbGeneralDepreciation.Text = "금액";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(87, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 22);
            this.label7.TabIndex = 103;
            this.label7.Text = "일반상각비";
            // 
            // txbAcquisitionQuantity
            // 
            this.txbAcquisitionQuantity.Location = new System.Drawing.Point(308, 212);
            this.txbAcquisitionQuantity.Name = "txbAcquisitionQuantity";
            this.txbAcquisitionQuantity.Size = new System.Drawing.Size(70, 21);
            this.txbAcquisitionQuantity.TabIndex = 102;
            this.txbAcquisitionQuantity.Text = "수량";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(248, 215);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 22);
            this.label10.TabIndex = 98;
            this.label10.Text = "취득수량";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(158, 289);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(225, 21);
            this.textBox4.TabIndex = 97;
            this.textBox4.Text = "금액";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(47, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 22);
            this.label6.TabIndex = 96;
            this.label6.Text = "당기말상각누계액";
            // 
            // cbbDurableYears
            // 
            this.cbbDurableYears.Font = new System.Drawing.Font("Gulim", 10F);
            this.cbbDurableYears.FormattingEnabled = true;
            this.cbbDurableYears.Location = new System.Drawing.Point(308, 177);
            this.cbbDurableYears.Name = "cbbDurableYears";
            this.cbbDurableYears.Size = new System.Drawing.Size(75, 21);
            this.cbbDurableYears.TabIndex = 95;
            this.cbbDurableYears.Text = "연수";
            // 
            // cbbDepreciationMethod
            // 
            this.cbbDepreciationMethod.Font = new System.Drawing.Font("Gulim", 10F);
            this.cbbDepreciationMethod.FormattingEnabled = true;
            this.cbbDepreciationMethod.Location = new System.Drawing.Point(158, 177);
            this.cbbDepreciationMethod.Name = "cbbDepreciationMethod";
            this.cbbDepreciationMethod.Size = new System.Drawing.Size(70, 21);
            this.cbbDepreciationMethod.TabIndex = 94;
            this.cbbDepreciationMethod.ValueMember = "상각방법코드번호";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(248, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 22);
            this.label5.TabIndex = 68;
            this.label5.Text = "내용연수";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(98, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 22);
            this.label4.TabIndex = 66;
            this.label4.Text = "상각방법";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(158, 104);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(225, 21);
            this.textBox10.TabIndex = 65;
            this.textBox10.Text = "금액";
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(47, 108);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(130, 22);
            this.label12.TabIndex = 64;
            this.label12.Text = "전기말상각누계액";
            // 
            // txbAcquisitionCost
            // 
            this.txbAcquisitionCost.Location = new System.Drawing.Point(158, 67);
            this.txbAcquisitionCost.Name = "txbAcquisitionCost";
            this.txbAcquisitionCost.Size = new System.Drawing.Size(225, 21);
            this.txbAcquisitionCost.TabIndex = 51;
            this.txbAcquisitionCost.Text = "금액";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(98, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 22);
            this.label3.TabIndex = 49;
            this.label3.Text = "취득원가";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txbNote);
            this.tabPage3.Controls.Add(this.label19);
            this.tabPage3.Controls.Add(this.txbEmployeeName);
            this.tabPage3.Controls.Add(this.cbbEmployeeCode);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Controls.Add(this.txbModelName);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.txbProductionCompanyName);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.txbSize);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.txbSupplierName);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(470, 486);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "추가등록사항";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txbNote
            // 
            this.txbNote.Location = new System.Drawing.Point(146, 332);
            this.txbNote.Name = "txbNote";
            this.txbNote.Size = new System.Drawing.Size(225, 21);
            this.txbNote.TabIndex = 64;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold);
            this.label19.Location = new System.Drawing.Point(108, 336);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(79, 22);
            this.label19.TabIndex = 63;
            this.label19.Text = "비고";
            // 
            // txbEmployeeName
            // 
            this.txbEmployeeName.Location = new System.Drawing.Point(237, 289);
            this.txbEmployeeName.Name = "txbEmployeeName";
            this.txbEmployeeName.Size = new System.Drawing.Size(82, 21);
            this.txbEmployeeName.TabIndex = 62;
            this.txbEmployeeName.Text = "사원명";
            // 
            // cbbEmployeeCode
            // 
            this.cbbEmployeeCode.Font = new System.Drawing.Font("Gulim", 10F);
            this.cbbEmployeeCode.FormattingEnabled = true;
            this.cbbEmployeeCode.Location = new System.Drawing.Point(148, 289);
            this.cbbEmployeeCode.Name = "cbbEmployeeCode";
            this.cbbEmployeeCode.Size = new System.Drawing.Size(80, 21);
            this.cbbEmployeeCode.TabIndex = 61;
            this.cbbEmployeeCode.Text = "사원코드";
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold);
            this.label18.Location = new System.Drawing.Point(98, 293);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(79, 22);
            this.label18.TabIndex = 60;
            this.label18.Text = "관리자";
            // 
            // txbModelName
            // 
            this.txbModelName.Location = new System.Drawing.Point(148, 237);
            this.txbModelName.Name = "txbModelName";
            this.txbModelName.Size = new System.Drawing.Size(225, 21);
            this.txbModelName.TabIndex = 59;
            this.txbModelName.Text = "모델명";
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold);
            this.label17.Location = new System.Drawing.Point(110, 241);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(79, 22);
            this.label17.TabIndex = 58;
            this.label17.Text = "모델";
            // 
            // txbProductionCompanyName
            // 
            this.txbProductionCompanyName.Location = new System.Drawing.Point(148, 132);
            this.txbProductionCompanyName.Name = "txbProductionCompanyName";
            this.txbProductionCompanyName.Size = new System.Drawing.Size(225, 21);
            this.txbProductionCompanyName.TabIndex = 57;
            this.txbProductionCompanyName.Text = "제작사명";
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(97, 136);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 22);
            this.label16.TabIndex = 56;
            this.label16.Text = "제작사";
            // 
            // txbSize
            // 
            this.txbSize.Location = new System.Drawing.Point(148, 183);
            this.txbSize.Name = "txbSize";
            this.txbSize.Size = new System.Drawing.Size(225, 21);
            this.txbSize.TabIndex = 55;
            this.txbSize.Text = "크기";
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(110, 187);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 22);
            this.label15.TabIndex = 54;
            this.label15.Text = "규격";
            // 
            // txbSupplierName
            // 
            this.txbSupplierName.Location = new System.Drawing.Point(148, 83);
            this.txbSupplierName.Name = "txbSupplierName";
            this.txbSupplierName.Size = new System.Drawing.Size(225, 21);
            this.txbSupplierName.TabIndex = 53;
            this.txbSupplierName.Text = "구입처명";
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(97, 87);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 22);
            this.label14.TabIndex = 52;
            this.label14.Text = "구입처";
            // 
            // txbAccountName
            // 
            this.txbAccountName.Location = new System.Drawing.Point(434, 76);
            this.txbAccountName.Name = "txbAccountName";
            this.txbAccountName.Size = new System.Drawing.Size(82, 21);
            this.txbAccountName.TabIndex = 94;
            this.txbAccountName.Text = "계정명";
            // 
            // cbbAccountCode
            // 
            this.cbbAccountCode.Font = new System.Drawing.Font("Gulim", 10F);
            this.cbbAccountCode.FormattingEnabled = true;
            this.cbbAccountCode.Location = new System.Drawing.Point(346, 76);
            this.cbbAccountCode.Name = "cbbAccountCode";
            this.cbbAccountCode.Size = new System.Drawing.Size(80, 21);
            this.cbbAccountCode.TabIndex = 93;
            this.cbbAccountCode.Text = "계정코드";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Gulim", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(272, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 22);
            this.label1.TabIndex = 92;
            this.label1.Text = "자산유형";
            // 
            // dgvList
            // 
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12});
            this.dgvList.Location = new System.Drawing.Point(13, 105);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.Size = new System.Drawing.Size(540, 512);
            this.dgvList.TabIndex = 91;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 99.8811F;
            this.Column1.HeaderText = "결의일";
            this.Column1.Name = "Column1";
            this.Column1.Width = 70;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 85.5817F;
            this.Column2.HeaderText = "순번";
            this.Column2.Name = "Column2";
            this.Column2.Width = 60;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 112.2143F;
            this.Column3.HeaderText = "기표일자";
            this.Column3.Name = "Column3";
            this.Column3.Width = 79;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 84.57403F;
            this.Column4.HeaderText = "구분";
            this.Column4.Name = "Column4";
            this.Column4.Width = 59;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 85.51608F;
            this.Column5.HeaderText = "코드";
            this.Column5.Name = "Column5";
            this.Column5.Width = 60;
            // 
            // Column6
            // 
            this.Column6.FillWeight = 138.2009F;
            this.Column6.HeaderText = "계정과목명";
            this.Column6.Name = "Column6";
            this.Column6.Width = 97;
            // 
            // Column7
            // 
            this.Column7.FillWeight = 101.6041F;
            this.Column7.HeaderText = "코드";
            this.Column7.Name = "Column7";
            this.Column7.Width = 71;
            // 
            // Column8
            // 
            this.Column8.FillWeight = 115.938F;
            this.Column8.HeaderText = "거래처명";
            this.Column8.Name = "Column8";
            this.Column8.Width = 81;
            // 
            // Column9
            // 
            this.Column9.FillWeight = 90.67206F;
            this.Column9.HeaderText = "적요";
            this.Column9.Name = "Column9";
            this.Column9.Width = 64;
            // 
            // Column10
            // 
            this.Column10.FillWeight = 86.24908F;
            this.Column10.HeaderText = "차변";
            this.Column10.Name = "Column10";
            this.Column10.Width = 60;
            // 
            // Column11
            // 
            this.Column11.FillWeight = 84.78826F;
            this.Column11.HeaderText = "대변";
            this.Column11.Name = "Column11";
            this.Column11.Width = 60;
            // 
            // Column12
            // 
            this.Column12.FillWeight = 114.7804F;
            this.Column12.HeaderText = "출력일자";
            this.Column12.Name = "Column12";
            this.Column12.Width = 80;
            // 
            // txbCompanyName
            // 
            this.txbCompanyName.Location = new System.Drawing.Point(172, 77);
            this.txbCompanyName.Name = "txbCompanyName";
            this.txbCompanyName.Size = new System.Drawing.Size(82, 21);
            this.txbCompanyName.TabIndex = 90;
            this.txbCompanyName.Text = "회사명";
            // 
            // cbbCompanyCode
            // 
            this.cbbCompanyCode.Font = new System.Drawing.Font("Gulim", 10F);
            this.cbbCompanyCode.FormattingEnabled = true;
            this.cbbCompanyCode.Location = new System.Drawing.Point(86, 77);
            this.cbbCompanyCode.Name = "cbbCompanyCode";
            this.cbbCompanyCode.Size = new System.Drawing.Size(80, 21);
            this.cbbCompanyCode.TabIndex = 89;
            this.cbbCompanyCode.Text = "회사코드";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Font = new System.Drawing.Font("Gulim", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(18, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 22);
            this.label2.TabIndex = 88;
            this.label2.Text = "회계단위";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("GulimChe", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(57, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 27);
            this.label8.TabIndex = 87;
            this.label8.Text = "고정자산등록";
            // 
            // btnStatementForm
            // 
            this.btnStatementForm.Location = new System.Drawing.Point(649, 38);
            this.btnStatementForm.Name = "btnStatementForm";
            this.btnStatementForm.Size = new System.Drawing.Size(75, 23);
            this.btnStatementForm.TabIndex = 86;
            this.btnStatementForm.Text = "전표양식";
            this.btnStatementForm.UseVisualStyleBackColor = true;
            // 
            // btnAccountTotal
            // 
            this.btnAccountTotal.Location = new System.Drawing.Point(730, 38);
            this.btnAccountTotal.Name = "btnAccountTotal";
            this.btnAccountTotal.Size = new System.Drawing.Size(75, 23);
            this.btnAccountTotal.TabIndex = 85;
            this.btnAccountTotal.Text = "계정합계";
            this.btnAccountTotal.UseVisualStyleBackColor = true;
            // 
            // btnSortOrder
            // 
            this.btnSortOrder.Location = new System.Drawing.Point(811, 38);
            this.btnSortOrder.Name = "btnSortOrder";
            this.btnSortOrder.Size = new System.Drawing.Size(75, 23);
            this.btnSortOrder.TabIndex = 84;
            this.btnSortOrder.Text = "정렬순서";
            this.btnSortOrder.UseVisualStyleBackColor = true;
            // 
            // btnStatementSearch
            // 
            this.btnStatementSearch.Location = new System.Drawing.Point(568, 38);
            this.btnStatementSearch.Name = "btnStatementSearch";
            this.btnStatementSearch.Size = new System.Drawing.Size(75, 23);
            this.btnStatementSearch.TabIndex = 83;
            this.btnStatementSearch.Text = "전표검색";
            this.btnStatementSearch.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Location = new System.Drawing.Point(9, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(1025, 1);
            this.label9.TabIndex = 82;
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox2.Location = new System.Drawing.Point(13, 70);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(1021, 32);
            this.richTextBox2.TabIndex = 81;
            this.richTextBox2.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(158, 212);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(70, 21);
            this.textBox1.TabIndex = 110;
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold);
            this.label20.Location = new System.Drawing.Point(98, 215);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(130, 22);
            this.label20.TabIndex = 109;
            this.label20.Text = "경비구분";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(158, 139);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(225, 21);
            this.textBox2.TabIndex = 112;
            this.textBox2.Text = "금액";
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold);
            this.label21.Location = new System.Drawing.Point(60, 143);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(130, 22);
            this.label21.TabIndex = 111;
            this.label21.Text = "전기말장부가액";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(159, 325);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(225, 21);
            this.textBox3.TabIndex = 114;
            this.textBox3.Text = "금액";
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold);
            this.label22.Location = new System.Drawing.Point(61, 329);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(130, 22);
            this.label22.TabIndex = 113;
            this.label22.Text = "당기말장부가액";
            // 
            // 고정자산등록
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "고정자산등록";
            this.Size = new System.Drawing.Size(1044, 645);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DateTimePicker dtpModificationDate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtpInputDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txbGeneralDepreciation;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbAcquisitionQuantity;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbDurableYears;
        private System.Windows.Forms.ComboBox cbbDepreciationMethod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txbAcquisitionCost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txbNote;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txbEmployeeName;
        private System.Windows.Forms.ComboBox cbbEmployeeCode;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txbModelName;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txbProductionCompanyName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txbSize;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txbSupplierName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txbAccountName;
        private System.Windows.Forms.ComboBox cbbAccountCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.TextBox txbCompanyName;
        private System.Windows.Forms.ComboBox cbbCompanyCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnStatementForm;
        private System.Windows.Forms.Button btnAccountTotal;
        private System.Windows.Forms.Button btnSortOrder;
        private System.Windows.Forms.Button btnStatementSearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label21;
    }
}
