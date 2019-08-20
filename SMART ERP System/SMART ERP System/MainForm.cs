using MetroFramework.Forms;
using System;
using System.Windows.Forms;
using ClassLibrary.FormHelper;
using System.Collections.Generic;
using ClassLibrary;
using System.Linq;
using SMART_ERP_System.Class;
using System.Runtime.InteropServices;
using System.Drawing;

namespace SMART_ERP_System
{
    public partial class MainForm : MetroForm
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;

        [DllImport("User32.dll")]
        public static extern void keybd_event(uint vk, uint scan, uint flags, uint extraInfo);

        LoginForm loginForm;
        List<메뉴등록> menuItems;
        UserControlList UserControlList = new UserControlList();
        public MainForm()
        {
            InitializeComponent();
            treeView.SetMenuItems(out menuItems);

            bgWorker.WorkerSupportsCancellation = true;
        }

        #region Event
        private void MainForm_Load(object sender, EventArgs e)
        {
            loginMember.EmployeeName = loginForm.loginControl.txbEmployeeName.Text;
            loginMember.EmployeeCode = loginForm.loginControl.txbEmployeeCode.Text;
            this.Text = loginForm.loginControl.txbEmployeeName.Text +
                "님 환영합니다.";

            ImageList imageList = new ImageList();
            imageList.Images.Add(Properties.Resources.folder);
            treeView.ImageList = imageList;
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            loginForm.Dispose();
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            if (metroTabControl.TabCount != 0)
            {
                int tabindex = metroTabControl.SelectedIndex;

                foreach (KeyValuePair<string, UserControl> userControl in UserControlList.DicUserControls)
                {
                    if (userControl.Key == metroTabControl.SelectedTab.Text)
                    {
                        userControl.Value.Hide();
                        userControl.Value.Refresh();
                    }
                }
                metroTabControl.TabPages.Remove(metroTabControl.SelectedTab);
                metroTabControl.SelectedIndex = tabindex - 1;
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
            bgWorker.RunWorkerAsync();

            TreeView treeView = (TreeView)sender;

            if (treeView.SelectedNode == null)
                return;

            string SerchName = treeView.SelectedNode.Text;
            int i = metroTabControl.TabPages.Count;

            if (i == 0)
            {
                bool res = UserControlList.DicUserControls.TryGetValue(SerchName, out UserControl control);

                if (res == true)
                {
                    TabPage tabPage = new TabPage();

                    tabPage.Text = $"{control.Name}";
                    metroTabControl.TabPages.Add(tabPage);

                    control.Parent = tabPage;
                    control.Show();
                    control.Dock = DockStyle.Fill;
                    metroTabControl.SelectedTab = tabPage;
                    metroTabControl.Focus();
                    SendKeys.Send("{TAB}");
                    return;
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

                bool res = UserControlList.DicUserControls.TryGetValue(SerchName, out UserControl control);

                if (res == true)
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

                metroTabControl.SelectedIndex = CurrentPageNumber;
            }
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

            if (e.KeyData == Keys.Down)
            {
                listBox.Focus();
                // VK_DOWN 0x28 : DOWN ARROW key
                keybd_event((byte)Keys.Down, 0x28, 0x01, 0); // DownUp            
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

        private void ListBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                ListBox_DoubleClick(listBox.SelectedItem, null);
        }

        private void MetroTabControl_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                EventHandler eventHandler = new EventHandler(TabControl_TypeMenuClick);

                mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, (uint)Cursor.Position.X, (uint)Cursor.Position.Y, 0, 0);
                MenuItem[] items =
                {
                    new MenuItem("모두 닫기", eventHandler),
                    new MenuItem("닫기", eventHandler)
                    };


                ContextMenu = new ContextMenu(items);
                mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, (uint)Cursor.Position.X, (uint)Cursor.Position.Y, 0, 0);
                ContextMenu.Show(metroTabControl, new Point(e.X, e.Y));
            }
            else
            {
                if (ContextMenu != null)
                    ContextMenu.Dispose();
            }
        }

        private void TabControl_TypeMenuClick(object obj, EventArgs e)
        {
            MenuItem menuItem = (MenuItem)obj;
            string str = menuItem.Text;

            if (str == "모두 닫기")
            {
                metroTabControl.TabPages.Clear();
                if (ContextMenu != null)
                    ContextMenu.Dispose();
            }

            if (str == "닫기")
            {
                metroTabControl.TabPages.Remove(metroTabControl.SelectedTab);
                if (ContextMenu != null)
                    ContextMenu.Dispose();
            }
        }

        private void BgWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            // 작업이 취소 되었을 경우
            if ((bgWorker.CancellationPending == true))
            {
                e.Cancel = true;
                return;
            }
            else
            {

            }
        }

        private void BgWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            // 에러가 있는지 체크
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message, "Error");
                return;
            }
        }
    }
}