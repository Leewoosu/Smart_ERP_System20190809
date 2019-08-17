using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary.FormHelper;
using ClassLibrary;
using ClassLibrary.EntityData;
using SMART_ERP_System.Class;
using SMART_ERP_System.MainForm_Control;

namespace SMART_ERP_System.MenuUserControl
{
    public partial class 계정과목등록 : UserControl
    {
        List<ClassLibrary.계정과목등록> MenuItems;
        List<계정과목> 계정과목s;

        public 계정과목등록()
        {
            InitializeComponent();

            treeView.SetMenuItemsByAccount(out MenuItems);
            SetData();
        }

        private void SetData()
        {
            cbb계정구분.DataSource = MenuLists.accountSeparations;
            cbb그룹코드.DataSource = DB.계정과목그룹.GetAll();
            계정과목s = DB.계정과목.GetAll();

            cbb계정구분.SelectedIndex = -1;
            cbb그룹코드.SelectedIndex = -1;
        }

        private void TreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeView treeView = (TreeView)sender;

            if (treeView.SelectedNode == null)
                return;

            string searchName = treeView.SelectedNode.Text;

            foreach (계정과목 item in 계정과목s)
            {
                if (searchName == item.계정과목명)
                {
                    cbb그룹코드.Text = item.그룹코드번호;
                    txb계정코드.Text = item.계정과목코드번호;
                    txb계정명.Text = item.계정과목명;
                    cbb계정구분.Text = item.계정구분;
                    cbb차대구분.Text = item.차대구분;
                    cbb입력구분.Text = item.입력구분;
                    txb관련계정코드.Text = item.계정과목코드번호;
                    txb계정과목설명.Text = item.비고;
                }
            }
        }

        private void Cbb그룹코드_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbb그룹코드.SelectedValue != null)
            {
                txb그룹명.Text = DB.계정과목그룹.GetAll().Where(x => x.그룹코드번호 == cbb그룹코드.SelectedValue.ToString()).Select(x => x.그룹명).FirstOrDefault();
            }
        }

        private void Txb관련계정코드_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F2)
            {
                계정코드구분Control control = new 계정코드구분Control();
                CodeHelperForm menuForm = new CodeHelperForm(control);
                menuForm.SetFormLocation();
                menuForm.ShowDialog();

                txb관련계정코드.Text = 계정과목단위.AccountCode;
                txb관련계정명.Text = 계정과목단위.AccountName;
            }
        }

        private void Txb관련계정코드_TextChanged(object sender, EventArgs e)
        {
            계정과목s = DB.계정과목.GetAll();
            txb관련계정명.Text = 계정과목s.Where(x => x.계정과목코드번호 == txb관련계정코드.Text).Select(x => x.계정과목명).FirstOrDefault();
        }
    }
}
