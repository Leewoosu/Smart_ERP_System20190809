using ClassLibrary.FormHelper;
using MetroFramework.Forms;
using SMART_ERP_System.MainForm_Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMART_ERP_System
{
    public partial class CodeHelperForm : MetroForm
    {
        private 계정코드구분Control 계정코드구분Control;
        private 금융거래처구분Control 금융거래처구분Control;
        private 일반거래처구분Control 일반거래처구분Control;
        private 계정합계Control 계정합계Control;
        private 부문구분Control 부문구분Control;
        private 사업장구분Control 사업장구분Control;
        private 관할세무서구분Control 관할세무서구분Control;
        private 고정자산구분Control 고정자산구분Control;

        public CodeHelperForm()
        {
            InitializeComponent();
        }

        public CodeHelperForm(계정코드구분Control 계정코드구분Control)
        {
            InitializeComponent();
            this.계정코드구분Control = 계정코드구분Control;

            this.panel.Controls.Add(계정코드구분Control);
            계정코드구분Control.Dock = DockStyle.Fill;
            this.Resizable = false;
            ActiveControl = 계정코드구분Control.dgv계정과목List;
            계정코드구분Control.RecieveLoginForm(this);
            this.SetFormLocation();
        }

        public CodeHelperForm(고정자산구분Control 고정자산구분Control)
        {
            InitializeComponent();
            this.고정자산구분Control = 고정자산구분Control;

            this.panel.Controls.Add(고정자산구분Control);
            고정자산구분Control.Dock = DockStyle.Fill;
            this.Resizable = false;
            ActiveControl = 고정자산구분Control.dgv고정자산List;
            고정자산구분Control.RecieveLoginForm(this);
            this.SetFormLocation();
        }

        public CodeHelperForm(계정합계Control 계정합계Control)
        {
            InitializeComponent();
            this.계정합계Control = 계정합계Control;

            this.panel.Controls.Add(계정합계Control);
            계정합계Control.Dock = DockStyle.Fill;
            this.Text = "계정별합계";
            this.Size = new Size(630, 440);
            this.Resizable = false;

            계정합계Control.RecieveMenuForm(this);
            ActiveControl = 계정합계Control.dgv전표리스트;
            this.SetFormLocation();
        }

        public CodeHelperForm(금융거래처구분Control 금융거래처구분Control)
        {
            InitializeComponent();
            this.금융거래처구분Control = 금융거래처구분Control;

            this.ClientSize = new System.Drawing.Size(금융거래처구분Control.Width+30, 금융거래처구분Control.Height);

            this.panel.Controls.Add(금융거래처구분Control);
            금융거래처구분Control.Dock = DockStyle.Fill;
            ActiveControl = 금융거래처구분Control.dgv거래처List;
            금융거래처구분Control.RecieveLoginForm(this);
            this.SetFormLocation();
        }

        public CodeHelperForm(일반거래처구분Control 일반거래처구분Control)
        {
            InitializeComponent();
            this.일반거래처구분Control = 일반거래처구분Control;

            this.ClientSize = new System.Drawing.Size(일반거래처구분Control.Width+30, 일반거래처구분Control.Height);

            this.panel.Controls.Add(일반거래처구분Control);
            일반거래처구분Control.Dock = DockStyle.Fill;
            ActiveControl = 일반거래처구분Control.dgv거래처List;
            일반거래처구분Control.RecieveLoginForm(this);
            this.SetFormLocation();
        }
        
        public CodeHelperForm(부문구분Control 부문구분Control)
        {
            InitializeComponent();
            this.부문구분Control = 부문구분Control;

            this.ClientSize = new System.Drawing.Size(부문구분Control.Width+30, 부문구분Control.Height);

            this.panel.Controls.Add(부문구분Control);
            부문구분Control.Dock = DockStyle.Fill;
            this.Size = new Size(450, 400);
            this.Resizable = false;
            ActiveControl = 부문구분Control.dgv부문;
            부문구분Control.RecieveLoginForm(this);
            this.SetFormLocation();
        }

        public CodeHelperForm(사업장구분Control 사업장구분Control)
        {
            InitializeComponent();
            this.사업장구분Control = 사업장구분Control;

            this.ClientSize = new System.Drawing.Size(사업장구분Control.Width+30, 사업장구분Control.Height);

            this.panel.Controls.Add(사업장구분Control);
            사업장구분Control.Dock = DockStyle.Fill;
            this.Size = new Size(335, 400);
            this.Resizable = false;
            ActiveControl = 사업장구분Control.dgv사업장;
            사업장구분Control.RecieveLoginForm(this);
            this.SetFormLocation();
        }

        public CodeHelperForm(관할세무서구분Control 관할세무서구분Control)
        {
            InitializeComponent();
            this.관할세무서구분Control = 관할세무서구분Control;

            this.ClientSize = new System.Drawing.Size(관할세무서구분Control.Width+30, 관할세무서구분Control.Height);

            this.panel.Controls.Add(관할세무서구분Control);
            관할세무서구분Control.Dock = DockStyle.Fill;
            this.Size = new Size(335, 400);
            this.Resizable = false;
            ActiveControl = 관할세무서구분Control.dgv관할세무서;
            관할세무서구분Control.RecieveLoginForm(this);
            this.SetFormLocation();
        }

        private void MenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.panel.Dispose();
        }
    }
}
