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

namespace SMART_ERP_System
{
    public partial class LoginControl : UserControl
    {
        private LoginForm _loginForm;

        public void RecieveLoginForm(LoginForm loginForm)
        {
            _loginForm = loginForm;
        }

        public LoginControl()
        {
            InitializeComponent();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {            
            int checkResult;

            DB.사원등록.Check(txbEmployeeCode.Text, txbPassWord.Text, out checkResult);

            if (checkResult == 1)
            {
                _loginForm.Hide();
            }
            else
            {
                MessageBox.Show("PassWord를 확인하세요");
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //public void Check(string id, out int employeeCnt, out string employeeName)
        //{
        //    //int employeeCnt;
        //    //string employeeName;

        //    using (ERPEntities entity = new ERPEntities())
        //    {
        //        employeeCnt = entity.사원등록.Where(x => x.사원코드 == id).ToList().Count;

        //        employeeName = entity.사원등록.Where(x => x.사원코드 == id).Select(x => x.사원명).ToList().FirstOrDefault();

        //        //if (employeeCnt == 1)
        //       //     txbEmployeeName.Text = employeeName;
        //    }

        //    //return employeeCnt;
        //}

        //public void Check(string id, string pwd, out int employeeCnt)
        //{
        //    //int employeeCnt;

        //    using (ERPEntities entity = new ERPEntities())
        //    {
        //        employeeCnt = entity.사원등록.Where(x => x.사원코드 == id && x.암호 == pwd).ToList().Count;
        //    }

        //    //return employeeCnt;
        //}

        private void TxbEmployeeCode_KeyUp(object sender, KeyEventArgs e)
        {
            int checkResult;
            string employeeName;

            if (e.KeyCode == Keys.Enter)
            {
                //checkResult = Check(txbEmployeeCode.Text);
                DB.사원등록.Check(txbEmployeeCode.Text, out checkResult, out employeeName);

                if (checkResult == 1)
                {
                    txbEmployeeName.Text = employeeName;
                    txbPassWord.Focus();
                }
                else
                {
                    txbEmployeeName.Text = "ID를 확인하세요";
                }
            }
        }

        private void TxbPassWord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                BtnOk_Click(null, null);
        }
    }
}