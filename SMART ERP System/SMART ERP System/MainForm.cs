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
using System.Reflection;
using ClassLibrary.Class;
using System.Diagnostics;

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
        List<UserControl> controls;

        public MainForm()
        {
            InitializeComponent();
            treeView.SetMenuItems(out menuItems);

            controls = new List<UserControl>();
        }

        #region Event
        private void MainForm_Load(object sender, EventArgs e)
        {
            loginMember.EmployeeName = loginForm.loginControl.txbEmployeeName.Text;
            loginMember.EmployeeCode = loginForm.loginControl.txbEmployeeCode.Text;
            lblUser.Text = loginForm.loginControl.txbEmployeeName.Text +
                "님 환영합니다.";
            loginMember.AccountingPeriod = DateTime.Now.Year;

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
            UserControl removeitem = null;

            if (metroTabControl.TabCount != 0)
            {
                int tabindex = metroTabControl.SelectedIndex;

                foreach (UserControl control in controls)
                {
                    if (control.Name == metroTabControl.SelectedTab.Text)
                    {
                        removeitem = control;
                        control.Dispose();                        
                    }
                }

                controls.Remove(removeitem);

                metroTabControl.TabPages.Remove(metroTabControl.SelectedTab);
                metroTabControl.SelectedIndex = tabindex - 1;
            }

            if (metroTabControl.TabCount == 0)
                pbx메인.Visible = true;
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            PrintForm printForm = new PrintForm();
            printForm.SetFormLocation();
            printForm.ShowDialog();
        }

        private void TreeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeView treeView = (TreeView)sender;

            if (treeView.SelectedNode == null)
                return;

            string SearchName = treeView.SelectedNode.Text;
            int tabPageCnt = metroTabControl.TabPages.Count;

            bool res = UserControlList.Dictionary.TryGetValue(SearchName, out UserControl control);

            if (res == true)
            {
                string name = "SMART_ERP_System.MenuUserControl." + SearchName;
                Assembly assembly = Assembly.GetExecutingAssembly();
                Type type = assembly.GetType(name);

                pbx메인.Visible = false;

                if (tabPageCnt == 0)
                {
                    control = (UserControl)Activator.CreateInstance(type);
                    controls.Add(control);
                    MakeTabPage(control);
                    return;
                }
                else
                {
                    int CurrentPageNumber = metroTabControl.SelectedIndex;

                    foreach (UserControl item in controls)
                    {
                        if (item.Name == SearchName)
                        {                            
                            return;
                        }
                    }

                    // tab 10개 제한
                    if (tabPageCnt < 10)
                    {
                        control = (UserControl)Activator.CreateInstance(type);
                        controls.Add(control);

                        MakeTabPage(control);

                       // metroTabControl.SelectedIndex = CurrentPageNumber;
                    }
                    else
                        return;
                }
            }
            else
                return;
        }

        private void MakeTabPage(UserControl control)
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

        private void NotifyTest_Resize(object sender, EventArgs e)
        {
            //윈도우 상태가 Minimized일 경우
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Visible = false; //창을 보이지 않게 한다.

                this.ShowIcon = false; //작업표시줄에서 제거.

                notifyIcon.Visible = true; //트레이 아이콘을 표시한다.
            }
        }

        private void NotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //Notify Icon을 더블클릭했을시 일어나는 이벤트.
            this.Visible = true;

            this.ShowIcon = true;

            notifyIcon.Visible = false; //트레이 아이콘을 숨긴다.
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            //ProcessCall();
        }

        [DllImport("user32")]
        private static extern bool SetForegroundWindow(IntPtr handle);
        [DllImport("User32")]
        private static extern int ShowWindow(IntPtr hwnd, int nCmdShow);

        private void BtnSearch_Click_1(object sender, EventArgs e)
        {
            // Button1_Click(sender, e);
        }
    }
}