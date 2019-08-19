using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SMART_ERP_System.MenuUserControl;
using ClassLibrary;
using ClassLibrary.EntityData;
using SMART_ERP_System.Class;
using System.Globalization;

namespace SMART_ERP_System.MainForm_Control
{
    public partial class 계정합계Control : UserControl
    {
        전표출력 전표출력;
        List<전표리스트> 전표리스트s;

        public 계정합계Control()
        {
            InitializeComponent();
            전표출력 = new 전표출력();
            전표출력.Recieve계정합계Control(this);

            cbb전표유형.DataSource = MenuLists.types;
            cbb전표상태.DataSource = MenuLists.status;

            dgv전표리스트.Rows.Clear();
            lbl건수총계.Text = "";
            lbl대변합계.Text = "";
            lbl차변합계.Text = "";
        }

        public void SendList(List<전표리스트> 전표리스트s)
        {
            this.전표리스트s = 전표리스트s;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string comparer = "전체";

            if (cbb전표상태.Text == comparer && cbb전표유형.Text == comparer)
            {
                var list = 전표리스트s;
                Calculate(list);

                전표리스트BindingSource.DataSource = list;
            }
        }

        private void Calculate(List<전표리스트> 전표리스트s)
        {
            foreach (var item in 전표리스트s)
            {
                if (item.구분 == "차변" || item.구분 == "입금")
                {
                    item.건수++;
                    item.차변합계 = int.Parse(전표리스트s.Sum(x => x.차변).ToString());
                }
                else
                {
                    item.건수 += 0;
                    item.차변합계 = 0;
                }

                if (item.구분 == "대변" || item.구분 == "출금")
                {
                    item.건수++;
                    item.대변합계 = int.Parse(전표리스트s.Sum(x => x.대변).ToString());
                }
                else
                {
                    item.건수 += 0;
                    item.대변합계 = 0;
                }

                lbl건수총계.Text = 전표리스트s.Select(x => x.건수).Count().ToString();
                lbl차변합계.Text = 전표리스트s.Sum(x => x.차변합계).ToString("##,#", CultureInfo.InvariantCulture);
                lbl대변합계.Text = 전표리스트s.Sum(x => x.대변합계).ToString("##,#", CultureInfo.InvariantCulture);
            }
        }

        private void Cbb전표상태_SelectedValueChanged(object sender, EventArgs e)
        {
            전표리스트s = DB.전표리스트.SearchPeriod(dtpFrom.Value, dtpTo.Value);
            string comparer = "전체";

            if (cbb전표상태.SelectedValue != null)
                ChangeSearchingTerms(전표리스트s, comparer);
        }
               
        private void Cbb전표유형_SelectedValueChanged(object sender, EventArgs e)
        {
            전표리스트s = DB.전표리스트.SearchPeriod(dtpFrom.Value, dtpTo.Value);
            string comparer = "전체";

            if (cbb전표유형.SelectedValue != null)
                ChangeSearchingTerms(전표리스트s, comparer);
        }

        private void ChangeSearchingTerms(List<전표리스트> 전표리스트s, string comparer)
        {
            if ((cbb전표상태.Text == comparer)
                 && (cbb전표유형.Text == comparer))
            {
                var list = 전표리스트s;

                Calculate(list);
                전표리스트BindingSource.DataSource = list;
            }
            else
            {
                var list = 전표리스트s.Where(x =>
               x.전표상태 == cbb전표상태.Text &&
               x.전표유형 == cbb전표유형.Text
                    ).ToList();

                Calculate(list);

                전표리스트BindingSource.DataSource = list;
            }

            if ((cbb전표상태.Text == comparer)
            && (cbb전표유형.Text != comparer))
            {
                var list
                = 전표리스트s.Where(x => x.전표유형 == cbb전표유형.Text).ToList();

                Calculate(list);

                전표리스트BindingSource.DataSource = list;
            }

            if ((cbb전표상태.Text != comparer)
            && (cbb전표유형.Text == comparer))
            {
                var list
                = 전표리스트s.Where(x => x.전표상태 == cbb전표상태.Text).ToList();

                Calculate(list);

                전표리스트BindingSource.DataSource = list;
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            dgv전표리스트.Rows.Clear();
            lbl건수총계.Text = "";
            lbl대변합계.Text = "";
            lbl차변합계.Text = "";
        }

        private void DtpFrom_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFrom.Value != null)
                전표리스트s = DB.전표리스트.SearchPeriod(dtpFrom.Value, dtpTo.Value);
        }

        private void DtpTo_ValueChanged(object sender, EventArgs e)
        {
            if (dtpTo.Value != null)
                전표리스트s = DB.전표리스트.SearchPeriod(dtpFrom.Value, dtpTo.Value);
        }
    }
}
