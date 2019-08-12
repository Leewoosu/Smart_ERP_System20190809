using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary.EntityData;
using ClassLibrary;

namespace SMART_ERP_System.MenuUserControl
{
    public partial class 품목등록 : UserControl
    {
        public 품목등록()
        {
            InitializeComponent();
            string[] 검사여부 = { "1. 예", "2. 아니요" };
            cbbSearch검사여부.Items.AddRange(검사여부);
            cbb검사여부.Items.AddRange(검사여부);
        }
        public void LoadData()
        {
            bds제품.DataSource = DB.제품.GetAll();
        }

        private void dgv제품_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int colum = dgv제품.CurrentCell.ColumnIndex;
            int 제품번호 = int.Parse(dgv제품.CurrentRow.Cells[0].Value.ToString());
            if (colum == 0) return;
            if(colum == 1)
            {
                txb제품번호.Text = dgv제품.CurrentRow.Cells[0].Value.ToString();
                txb제품명.Text = dgv제품.CurrentRow.Cells[1].Value.ToString();
                txbLOT수량.Text = null;
                cbb검사여부.Text = null;
                txb리드타임.Text = null;
                txb실제원가.Text = null;
                txb안전재고량.Text = null;
                txb외경.Text = null;
                txb일별생산량.Text = null;
                txb전공정.Text = null;
                txb최종공정.Text = null;
                txb층.Text = null;
                txb표준원가.Text = null;
                txb품목군.Text = null;
                txb후공정.Text = null;
                txb품목군.Focus();

            }
            제품 product = dgv제품.CurrentRow.DataBoundItem as 제품;

            if (product != null) return;

            if (DB.제품.IsSearch제품번호(dgv제품.CurrentRow.Cells[0].Value.ToString())) {
                MessageBox.Show("등록되어있는 제품번호입니다", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (DB.제품.IsSearch제품명(dgv제품.CurrentRow.Cells[1].Value.ToString()))
            {
                MessageBox.Show("등록되어있는 제품이름입니다", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            


        }

        private void dgv제품_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            제품 product = dgv제품.CurrentRow.DataBoundItem as 제품;

            if (product == null) return;

            string 제품번호 = dgv제품.CurrentRow.Cells[0].Value.ToString();
            //제품정보불러오기
            txb제품번호.Text = 제품번호.ToString();
            txb제품명.Text = dgv제품.CurrentRow.Cells[1].Value.ToString();
            txbLOT수량.Text = DB.제품.SearchLOT수량(제품번호);
            cbb검사여부.Text = DB.제품.Search검사여부(제품번호);
            txb리드타임.Text = DB.제품.Search리드타임(제품번호);
            txb실제원가.Text = DB.제품.Search실제원가(제품번호);
            txb안전재고량.Text = DB.제품.Search안전재고량(제품번호);
            txb외경.Text = DB.제품.Search외경(제품번호);
            txb일별생산량.Text = DB.제품.Search일별생산량(제품번호);
            
            txb층.Text = DB.제품.Search층(제품번호);
            txb표준원가.Text = DB.제품.Search표준원가(제품번호);
            txb품목군.Text = DB.제품.Search품목군(제품번호);
           
        }

        private void btn등록_Click(object sender, EventArgs e)
        {
            제품 productInfo = new 제품();

            productInfo.제품번호 = txb제품번호.Text;
            productInfo.제품명 = txb제품명.Text;
            productInfo.LOT수량 = int.Parse(txbLOT수량.Text);
            productInfo.검사여부 = cbb검사여부.Text;
            productInfo.리드타임 = int.Parse(txb리드타임.Text);
            productInfo.실제원가 = int.Parse(txb실제원가.Text);
            productInfo.안전재고량 = int.Parse(txb안전재고량.Text);
            productInfo.외경 = int.Parse(txb외경.Text);
            productInfo.일별생산량 = int.Parse(txb일별생산량.Text);
            
            productInfo.층 = int.Parse(txb층.Text);
            productInfo.표준원가 = int.Parse(txb표준원가.Text);
            productInfo.품목군 = txb품목군.Text;
            
            DB.제품.Insert(productInfo);
            OnButton등록();
        }

        private void btn삭제_Click(object sender, EventArgs e)
        {
            제품 orderList = dgv제품.CurrentRow.DataBoundItem as 제품;

            if (orderList == null) return;

            DB.제품.Delete(orderList);
            OnButton삭제();
        }

        private void btn변경_Click(object sender, EventArgs e)
        {
            제품 productInfo = new 제품();
           
            productInfo.제품번호 = txb제품번호.Text;
            productInfo.제품명 = txb제품명.Text;
            productInfo.LOT수량 = int.Parse(txbLOT수량.Text);
            productInfo.검사여부 = cbb검사여부.Text;
            productInfo.리드타임 = int.Parse(txb리드타임.Text);
            productInfo.실제원가 = int.Parse(txb실제원가.Text);
            productInfo.안전재고량 = int.Parse(txb안전재고량.Text);
            productInfo.외경 = int.Parse(txb외경.Text);
            productInfo.일별생산량 = int.Parse(txb일별생산량.Text);
            productInfo.층 = int.Parse(txb층.Text);
            productInfo.표준원가 = int.Parse(txb표준원가.Text);
            productInfo.품목군 = txb품목군.Text;

            DB.제품.Update(productInfo);
            OnButton변경();
        }

        private void btn조회_Click(object sender, EventArgs e)
        {
            string 품목군 = txbSearch품목군.Text;
            string 검사여부 = cbbSearch검사여부.Text;
            bds제품.DataSource = DB.제품.Search제품(품목군, 검사여부);
            OnButton조회();
        }

        #region Button조회 event things for C# 3.0
        public event EventHandler<Button조회EventArgs> Button조회;

        protected virtual void OnButton조회(Button조회EventArgs e)
        {
            if (Button조회 != null)
                Button조회(this, e);
        }

        private Button조회EventArgs OnButton조회()
        {
            Button조회EventArgs args = new Button조회EventArgs();
            OnButton조회(args);

            return args;
        }

        /*private Button조회EventArgs OnButton조회ForOut()
        {
            Button조회EventArgs args = new Button조회EventArgs();
            OnButton조회(args);

            return args;
        }*/

        public class Button조회EventArgs : EventArgs
        {


            /*public Button조회EventArgs()
            {
            }

            public Button조회EventArgs()
            {

            }*/
        }
        #endregion
        #region Button변경 event things for C# 3.0
        public event EventHandler<Button변경EventArgs> Button변경;

        protected virtual void OnButton변경(Button변경EventArgs e)
        {
            if (Button변경 != null)
                Button변경(this, e);
        }

        private Button변경EventArgs OnButton변경()
        {
            Button변경EventArgs args = new Button변경EventArgs();
            OnButton변경(args);

            return args;
        }

        /*private Button변경EventArgs OnButton변경ForOut()
        {
            Button변경EventArgs args = new Button변경EventArgs();
            OnButton변경(args);

            return args;
        }*/

        public class Button변경EventArgs : EventArgs
        {


            /*public Button변경EventArgs()
            {
            }

            public Button변경EventArgs()
            {

            }*/
        }
        #endregion
        #region Button등록 event things for C# 3.0
        public event EventHandler<Button등록EventArgs> Button등록;

        protected virtual void OnButton등록(Button등록EventArgs e)
        {
            if (Button등록 != null)
                Button등록(this, e);
        }

        private Button등록EventArgs OnButton등록()
        {
            Button등록EventArgs args = new Button등록EventArgs();
            OnButton등록(args);

            return args;
        }

        /*private Button등록EventArgs OnButton등록ForOut()
        {
            Button등록EventArgs args = new Button등록EventArgs();
            OnButton등록(args);

            return args;
        }*/

        public class Button등록EventArgs : EventArgs
        {


            /*public Button등록EventArgs()
            {
            }

            public Button등록EventArgs()
            {

            }*/
        }
        #endregion
        #region Button삭제 event things for C# 3.0
        public event EventHandler<Button삭제EventArgs> Button삭제;

        protected virtual void OnButton삭제(Button삭제EventArgs e)
        {
            if (Button삭제 != null)
                Button삭제(this, e);
        }

        private Button삭제EventArgs OnButton삭제()
        {
            Button삭제EventArgs args = new Button삭제EventArgs();
            OnButton삭제(args);

            return args;
        }

        /*private Button삭제EventArgs OnButton삭제ForOut()
        {
            Button삭제EventArgs args = new Button삭제EventArgs();
            OnButton삭제(args);

            return args;
        }*/

        public class Button삭제EventArgs : EventArgs
        {


            /*public Button삭제EventArgs()
            {
            }

            public Button삭제EventArgs()
            {

            }*/
        }
        #endregion
    }
}
