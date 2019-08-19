namespace SMART_ERP_System.MenuUserControl
{
    partial class 소요량전개
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn소요량전개 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.dgv발주서 = new System.Windows.Forms.DataGridView();
            this.자재번호DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.전개수량DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bds소요량전개 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv발주서)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds소요량전개)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(92, 20);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(77, 20);
            this.textBox2.TabIndex = 26;
            // 
            // btn소요량전개
            // 
            this.btn소요량전개.Location = new System.Drawing.Point(732, 0);
            this.btn소요량전개.Name = "btn소요량전개";
            this.btn소요량전개.Size = new System.Drawing.Size(75, 23);
            this.btn소요량전개.TabIndex = 20;
            this.btn소요량전개.Text = "소요량전개";
            this.btn소요량전개.UseVisualStyleBackColor = true;
            this.btn소요량전개.Click += new System.EventHandler(this.btn소요량전개_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1018, 1);
            this.label1.TabIndex = 18;
            this.label1.Text = "label1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 12);
            this.label8.TabIndex = 36;
            this.label8.Text = "소요량전개(MRP)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(7, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1018, 139);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(92, 50);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(77, 20);
            this.textBox3.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(15, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 11);
            this.label4.TabIndex = 50;
            this.label4.Text = "제품번호";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(15, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 11);
            this.label2.TabIndex = 49;
            this.label2.Text = "자재번호";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.Location = new System.Drawing.Point(33, 89);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 11);
            this.label13.TabIndex = 48;
            this.label13.Text = "계획기간";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(92, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(77, 20);
            this.textBox1.TabIndex = 45;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(175, 88);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(11, 11);
            this.label12.TabIndex = 46;
            this.label12.Text = "~";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(195, 85);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(77, 20);
            this.textBox4.TabIndex = 47;
            // 
            // dgv발주서
            // 
            this.dgv발주서.AutoGenerateColumns = false;
            this.dgv발주서.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv발주서.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv발주서.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.자재번호DataGridViewTextBoxColumn,
            this.전개수량DataGridViewTextBoxColumn});
            this.dgv발주서.DataSource = this.bds소요량전개;
            this.dgv발주서.Location = new System.Drawing.Point(13, 174);
            this.dgv발주서.Name = "dgv발주서";
            this.dgv발주서.RowTemplate.Height = 23;
            this.dgv발주서.Size = new System.Drawing.Size(1018, 467);
            this.dgv발주서.TabIndex = 44;
            // 
            // 자재번호DataGridViewTextBoxColumn
            // 
            this.자재번호DataGridViewTextBoxColumn.DataPropertyName = "자재번호";
            this.자재번호DataGridViewTextBoxColumn.HeaderText = "자재번호";
            this.자재번호DataGridViewTextBoxColumn.Name = "자재번호DataGridViewTextBoxColumn";
            // 
            // 전개수량DataGridViewTextBoxColumn
            // 
            this.전개수량DataGridViewTextBoxColumn.DataPropertyName = "전개수량";
            this.전개수량DataGridViewTextBoxColumn.HeaderText = "전개수량";
            this.전개수량DataGridViewTextBoxColumn.Name = "전개수량DataGridViewTextBoxColumn";
            // 
            // bds소요량전개
            // 
            //this.bds소요량전개.DataSource = typeof(ClassLibrary.소요량전개);
            // 
            // 소요량전개
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv발주서);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn소요량전개);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(7, 35);
            this.Name = "소요량전개";
            this.Size = new System.Drawing.Size(1044, 645);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv발주서)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds소요량전개)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btn소요량전개;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DataGridView dgv발주서;
        private System.Windows.Forms.DataGridViewTextBoxColumn 자재번호DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 전개수량DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bds소요량전개;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
    }
}
