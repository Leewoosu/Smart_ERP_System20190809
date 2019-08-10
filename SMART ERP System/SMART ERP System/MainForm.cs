using MetroFramework.Forms;
using System;
using System.Windows.Forms;
using ClassLibrary.FormHelper;
using System.Collections.Generic;
using ClassLibrary;
using System.Linq;
using SMART_ERP_System.Class;

namespace SMART_ERP_System
{
    
    public partial class MainForm : MetroForm
    {
        LoginForm loginForm;
        List<메뉴등록> menuItems;
        List<UserControl> controls;

        public MainForm()
        {
            InitializeComponent();
            treeView.SetMenuItems(out menuItems);
        }

        #region Event
        private void MainForm_Load(object sender, EventArgs e)
        {
            loginMember.EmployeeName = loginForm.loginControl.txbEmployeeName.Text;
            this.Text = loginForm.loginControl.txbEmployeeName.Text +
                "님 환영합니다.";
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            loginForm.Dispose();
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            if (metroTabControl.TabCount != 0)
            {
                foreach (UserControl userControl in controls)
                {
                    if (userControl.Name == metroTabControl.SelectedTab.Text)
                    {

                        userControl.Dispose();
                    }
                }
                metroTabControl.TabPages.Remove(metroTabControl.SelectedTab);
            }
        }
        private void BtnPrint_Click(object sender, EventArgs e)
        {
            PrintForm printForm = new PrintForm();
            printForm.SetFormLocation();
            printForm.ShowDialog();
        }
        private void TreeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            UserControlList UserControlList = new UserControlList();
            UserControlList.AddControls(out controls);

            TreeView treeView = (TreeView)sender;

            if (treeView.SelectedNode == null)
                return;

            string SerchName = treeView.SelectedNode.Text;
            int i = metroTabControl.TabPages.Count;

            if (i == 0)
            {
                foreach (UserControl control in controls)
                {
                    if (SerchName == control.Name)                   
                    {
                        TabPage tabPage = new TabPage();

                        tabPage.Text = $"{control.Name}";
                        metroTabControl.TabPages.Add(tabPage);

                        control.Parent = tabPage;
                        control.Show();
                        control.Dock = DockStyle.Fill;
                        metroTabControl.SelectedTab = tabPage;
                        return;
                    }
                }
            }
            else
            {
                int CurrentPageNumber = metroTabControl.SelectedIndex;

                for (int j = 0; j < i; j++)
                {
                    metroTabControl.Visible = false;
                    metroTabControl.SelectedIndex = j;
                    if (metroTabControl.SelectedTab.Text == SerchName)
                    {
                        metroTabControl.Visible = true;
                        return;
                    }
                }
                
                metroTabControl.Visible = true;

                foreach (var control in controls)
                {
                    if (SerchName == control.Name)
                    {
                        TabPage tabPage = new TabPage();
                        tabPage.Text = $"{control.Name}";
                        metroTabControl.TabPages.Add(tabPage);

                        control.Parent = tabPage;
                        control.Show();
                        control.Dock = DockStyle.Fill;
                        metroTabControl.SelectedTab = tabPage;
                        return;
                    }
                }
                metroTabControl.SelectedIndex = CurrentPageNumber;
            }
        }
        private void BtnMenuSearch_Click(object sender, EventArgs e)
        {
            TreeNode findNode = SearchNode(txbMenuSearch.Text, treeView.TopNode);
            listBox.Visible = false;
            findNode.ExpandAll();
        }
        private void BtnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Info");
        }
        private void TxbMenuSearch_KeyUp(object sender, KeyEventArgs e)
        {
            List<string> searchingMenu = new List<string>();
            listBox.Visible = false;
            listBox.Items.Clear();

            if (txbMenuSearch.Text.Length >= 2)
            {
                foreach (var item in menuItems)
                {
                    if (item.Title.ToLower().Contains(txbMenuSearch.Text.ToLower()) == true)
                    {
                        listBox.Items.Add(item.Title);
                    }
                }

                foreach (var item in searchingMenu)
                {
                    listBox.Items.Add(item);
                }
                listBox.Visible = true;
            }
        }
        private void ListBox_DoubleClick(object sender, EventArgs e)
        {
            if (listBox.SelectedItem == null)
                return;

            listBox.Visible = false;
            string keyValue = listBox.SelectedItem.ToString();
            TreeNode node = SearchNode(keyValue, treeView.Nodes[0]);

            treeView.SelectedNode = node;
            TreeView_NodeMouseDoubleClick(treeView, null);
        }
        #endregion

        public void RecieveLoginForm(LoginForm loginForm)
        {
            this.loginForm = loginForm;
        }

        public TreeNode SearchNode(string SearchText, TreeNode StartNode)
        {
            TreeNode node = null;
            while (StartNode != null)
            {
                if (StartNode.Text.ToLower().Contains(SearchText.ToLower()))
                {
                    node = StartNode;
                    break;
                }

                if (StartNode.Nodes.Count != 0)
                {
                    node = SearchNode(SearchText, StartNode.Nodes[0]);
                    if (node != null)
                    {
                        break;
                    }
                }
                StartNode = StartNode.NextNode;
            }
            return node;
        }
    }
}