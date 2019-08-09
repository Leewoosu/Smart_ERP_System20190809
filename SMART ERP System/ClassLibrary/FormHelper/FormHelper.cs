using ClassLibrary.EntityData;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary.FormHelper
{
    public static class FormHelper
    {
        public static void SetFormLocation(this Form form)
        {
            form.StartPosition = FormStartPosition.Manual;
            form.Location = new Point(
                Screen.PrimaryScreen.Bounds.Width / 2 - form.Size.Width / 2,
                Screen.PrimaryScreen.Bounds.Height / 2 - form.Size.Height / 2);
        }

        public static void SetMenuItems(this TreeView treeView, 
            out List<메뉴등록> menuItems)
        {
            using (ERPEntities entity = new ERPEntities())
            {
                menuItems = entity.메뉴등록.ToList();

                foreach (var item in menuItems)
                {
                    if (item.PrentKey == null)
                        treeView.Nodes.Add(item.CodeNum, item.Title);
                }

                foreach (var item in menuItems)
                {
                    int check = treeView.Nodes.Find(item.PrentKey, true).Length;
                    if (check > 0)
                    {
                        int inputNum = treeView.Nodes.Find(item.PrentKey, true).Length - 1;
                        treeView.Nodes.Find(item.PrentKey, true)[inputNum].Nodes.Add(item.CodeNum, item.Title);
                    }
                }
            }
        }

        public static void SetMenuItemsByAccount(this TreeView treeView, 
            out List<계정과목등록> MenuItems)
        {
            using (ERPEntities entity = new ERPEntities())
            {
                MenuItems = entity.계정과목등록.ToList();

                foreach (var item in MenuItems)
                {
                    if (item.PrentKey == null)
                        treeView.Nodes.Add(item.CodeNum, item.Title);
                }

                foreach (var item in MenuItems)
                {
                    int check = treeView.Nodes.Find(item.PrentKey, true).Length;
                    if (check > 0)
                    {
                        int inputNum = treeView.Nodes.Find(item.PrentKey, true).Length - 1;
                        treeView.Nodes.Find(item.PrentKey, true)[inputNum].Nodes.Add(item.CodeNum, item.Title);
                    }
                }
            }
        }
    }
}
