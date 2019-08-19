﻿using ClassLibrary;
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
        /// <summary>
        /// 화면 해상도에 맞추어 정중앙에 폼을 뛰움
        /// </summary>
        /// <param name="form">해당 Form</param>
        public static void SetFormLocation(this Form form)
        {
            form.StartPosition = FormStartPosition.Manual;
            form.Location = new Point(
                Screen.PrimaryScreen.Bounds.Width / 2 - form.Size.Width / 2,
                Screen.PrimaryScreen.Bounds.Height / 2 - form.Size.Height / 2);
        }

        /// <summary>
        /// TreeView에 기능별 메뉴등록
        /// </summary>
        /// <param name="treeView">해당 TreeView</param>
        /// <param name="menuItems">메뉴등록 메뉴</param>
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

        /// <summary>
        /// TreeView에 계정과목등록
        /// </summary>
        /// <param name="treeView">해당 TreeView</param>
        /// <param name="MenuItems">계정과목등록 메뉴</param>
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
                        if (int.Parse(item.CodeNum) < 10000)
                            treeView.Nodes.Find(item.PrentKey, true)[check - 1].Nodes.Add(item.CodeNum, item.Title);
                        else
                            treeView.Nodes.Find(item.PrentKey, true)[check - 1].Nodes.Add(item.CodeNum, item.CodeNum + " " + item.Title);
                    }
                }
            }
        }

        /// <summary>
        /// 데이터그리드뷰 컬럼 병합
        /// </summary>
        /// <param name="view">해당 DataGridView</param>
        /// <param name="e">PaintEventArgs e</param>
        /// <param name="groupName">병합할 그룹명</param>
        /// <param name="start">시작 범위, 단위 2</param>
        /// <param name="end">끝나는 범위</param>
        public static void MergeHeaderCell(this DataGridView view, PaintEventArgs e, string groupName, int start, int end)
        {
            for (int j = start; j < end;)
            {
                Rectangle rectangle = view.GetCellDisplayRectangle(j, -1, true);
                int w2 = view.GetCellDisplayRectangle(j + 1, -1, true).Width;
                rectangle.X += 1;
                rectangle.Y += 1;
                rectangle.Width = rectangle.Width + w2 - 2;
                rectangle.Height = rectangle.Height / 2 - 2;
                e.Graphics.FillRectangle(new SolidBrush(view.ColumnHeadersDefaultCellStyle.BackColor), rectangle);
                StringFormat format = new StringFormat();
                format.Alignment = StringAlignment.Center;
                format.LineAlignment = StringAlignment.Center;
                e.Graphics.DrawString(groupName, view.ColumnHeadersDefaultCellStyle.Font, new SolidBrush(view.ColumnHeadersDefaultCellStyle.ForeColor), rectangle, format);
                j += 2;
            }
        }
    }
}
