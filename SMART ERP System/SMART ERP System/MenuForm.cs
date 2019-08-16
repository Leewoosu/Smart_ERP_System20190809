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
    public partial class MenuForm : MetroForm
    {
        private 계정코드구분Control 계정코드구분Control;
        private 금융거래처구분Control 금융거래처구분Control;
        private 일반거래처구분Control 일반거래처구분Control;

        public MenuForm()
        {
            InitializeComponent();
        }

        public MenuForm(계정코드구분Control 계정코드구분Control)
        {
            InitializeComponent();
            this.계정코드구분Control = 계정코드구분Control;

            this.panel.Controls.Add(계정코드구분Control);
            계정코드구분Control.Dock = DockStyle.Fill;
            ActiveControl = 계정코드구분Control.dgv계정과목List;
            계정코드구분Control.RecieveLoginForm(this);
        }

        public MenuForm(금융거래처구분Control 금융거래처구분Control)
        {
            InitializeComponent();
            this.금융거래처구분Control = 금융거래처구분Control;

            this.ClientSize = new System.Drawing.Size(금융거래처구분Control.Width+30, 금융거래처구분Control.Height);

            this.panel.Controls.Add(금융거래처구분Control);
            금융거래처구분Control.Dock = DockStyle.Fill;
            ActiveControl = 금융거래처구분Control.dgv거래처List;
            금융거래처구분Control.RecieveLoginForm(this);
        }

        public MenuForm(일반거래처구분Control 일반거래처구분Control)
        {
            InitializeComponent();
            this.일반거래처구분Control = 일반거래처구분Control;

            this.ClientSize = new System.Drawing.Size(일반거래처구분Control.Width+30, 일반거래처구분Control.Height);

            this.panel.Controls.Add(일반거래처구분Control);
            일반거래처구분Control.Dock = DockStyle.Fill;
            ActiveControl = 일반거래처구분Control.dgv거래처List;
            일반거래처구분Control.RecieveLoginForm(this);
        }

        private void MenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.panel.Dispose();
        }
    }
}
