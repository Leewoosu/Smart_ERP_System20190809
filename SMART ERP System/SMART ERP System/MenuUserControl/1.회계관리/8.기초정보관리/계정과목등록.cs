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

            SetData();
            treeView.SetMenuItemsByAccount(out MenuItems);
        }

        private void SetData()
        {
            cbb계정구분.DataSource = MenuLists.accountSeparations;
            txb그룹명.Text = null;
            계정과목s = DB.계정과목.GetAll();

            ImageList imageList = new ImageList();
            imageList.Images.Add(Properties.Resources.folder);
            treeView.ImageList = imageList;
        }

        /// <summary>
        /// 선택된 노드의 이름과 일치하는 세부사항들을 가져옴
        /// </summary>
        /// <param name="treeView"></param>
        private void FillDetails(TreeView treeView)
        {
            계정과목단위.SelectAccountName = treeView.SelectedNode.Text;
            계정과목단위.SearchingCode = DB.계정과목.FindCode(계정과목단위.SelectAccountName);

            if (계정과목단위.SearchingCode == null)
            {
                foreach (Control control in gbx세부항목.Controls)
                {
                    if ((typeof(TextBox) == control.GetType()) || (typeof(ComboBox) == control.GetType()))
                    {
                        control.Text = null;
                        control.Enabled = false;
                    }
                }
            }
            else
            {
                foreach (Control control in gbx세부항목.Controls)
                {
                    if (!control.Name.IsOneOf("txb그룹코드", "txb계정코드", "txb그룹명"))
                        control.Enabled = true;
                }

                foreach (계정과목 item in 계정과목s)
                {
                    if (계정과목단위.SearchingCode == item.계정과목코드번호)
                    {
                        txb그룹코드.Text = item.그룹코드번호;
                        txb계정코드.Text = item.계정과목코드번호;
                        txb출력계정명.Text = item.출력계정명;
                        txb계정명.Text = item.계정과목명;
                        cbb계정구분.Text = item.계정구분;
                        cbb차대구분.Text = item.차대구분;
                        cbb입력구분.Text = item.입력구분;
                        txb관련계정코드.Text = item.계정과목코드번호;
                        txb계정과목설명.Text = item.비고;
                        cbb필수입력여부.Text = item.필수입력여부;

                        txb관련계정명.Text = 계정과목s.Where(x => x.계정과목코드번호 == txb관련계정코드.Text).Select(x => x.계정과목명).FirstOrDefault();
                    }
                }
            }
        }

        private void Txb관련계정코드_KeyDown(object sender, KeyEventArgs e)
        {
            // F2 코드도움 팝업
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

        private void TreeView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Down)
            {
                if (treeView.SelectedNode == null)
                    return;

                FillDetails(treeView);
            }
        }

        private void TreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeView treeView = (TreeView)sender;

            if (treeView.SelectedNode == null)
                return;

            FillDetails(treeView);
        }

        private void FIllAccountCode(out 계정과목 계정과목)
        {
            계정과목 = new 계정과목();
            계정과목.계정과목코드번호 = txb계정코드.Text;
            계정과목.계정과목명 = txb계정명.Text;
            계정과목.출력계정명 = txb출력계정명.Text;
            계정과목.관련계정코드 = txb관련계정코드.Text;
            계정과목.계정구분 = cbb계정구분.Text;
            계정과목.차대구분 = cbb차대구분.Text;
            계정과목.입력구분 = cbb입력구분.Text;
            계정과목.필수입력여부 = cbb필수입력여부.Text;
            계정과목.비고 = txb계정과목설명.Text;
            계정과목.그룹코드번호 = txb그룹코드.Text;
        }

        private void Txb그룹코드_TextChanged(object sender, EventArgs e)
        {
            if (txb그룹코드.Text != null)
            {
                txb그룹명.Text = DB.계정과목그룹
                    .GetAll()
                    .Where(x => x.그룹코드번호 == txb그룹코드.Text)
                    .Select(x => x.그룹명)
                    .FirstOrDefault();
            }
        }

        private void SplitContainer1_Panel2_Leave(object sender, EventArgs e)
        {
            FIllAccountCode(out 계정과목 계정과목);

            bool isUpdated = DB.계정과목.IsUpdateAccountCode(계정과목);

            if (isUpdated == false)
            {
                if (DialogResult.Yes == MessageBox.Show("수정된 내용이 있습니다.\n변경사항을 저장하시겠습니까?", "저장", MessageBoxButtons.YesNo))
                    DB.계정과목.Update(계정과목);
            }
            else
                return;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
           // treeView.SelectedNode.Nodes.Add(, "");
        }
    }
}
