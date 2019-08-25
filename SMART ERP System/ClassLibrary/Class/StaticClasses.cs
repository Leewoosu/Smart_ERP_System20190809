using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMART_ERP_System.Class
{
    public static class CommonUnit
    {    }

    public static class loginMember
    {
        public static string EmployeeName { get; set; }
        public static string EmployeeCode { get; set; }
        public static int AccountingPeriod { get; set; }
    }

    public static class ImageOpacity
    {
        /// <summary>
        /// 해당 이미지의 투명도를 변경한다.
        /// </summary>
        /// <param name="img"></param>
        /// <param name="opacityvalue"></param>
        /// <returns></returns>
        public static Bitmap ChangeOpacity(Image img, float opacityvalue)
        {
            Bitmap bmp = new Bitmap(img.Width, img.Height);
            Graphics graphics = Graphics.FromImage(bmp);
            ColorMatrix colormatrix = new ColorMatrix();

            colormatrix.Matrix33 = opacityvalue;

            ImageAttributes imgAttribute = new ImageAttributes();

            imgAttribute.SetColorMatrix(colormatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

            graphics.DrawImage(img, new Rectangle(0, 0, bmp.Width, bmp.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, imgAttribute);

            graphics.Dispose();

            return bmp;
        }
    }

    public static class 계정과목단위
    {
        public static string AccountCode { get; set; }
        public static string AccountName { get; set; }
        public static string SelectAccountName { get; set; }
    }

    public static class 관할세무서단위
    {
        public static string CompetentTaxOfficeCode { get; set; }
        public static string CompetentTaxOfficeName { get; set; }
    }

    public static class 부문단위
    {
        public static string SectorCode { get; set; }
        public static string SectorName { get; set; }
    }

    public static class 사업장단위
    {
        public static string WorkPlaceCode { get; set; }
        public static string WorkPlaceName { get; set; }
    }

    public static class 전표단위
    {
        public static int Index { get; set; }
        public static int RowCnt { get; set; }
        public static int ColumnCnt { get; set; }
        public static int ColumnIndex { get; set; }
        public static int RowIndex { get; set; }
        public static int LoadCnt { get; set; }
    }

    public static class 전표리스트단위
    {
        public static int Index { get; set; }
        public static int ColumnCnt { get; set; }
        public static int RowCnt { get; set; }
        public static int ColumnIndex { get; set; }
        public static int RowIndex { get; set; }
        public static int LoadCnt { get; set; }
        public static string AccountCode { get; set; }
        public static string AccountName { get; set; }
        public static string FinanceCustomerCode { get; set; }
        public static string FinanceCustomerName { get; set; }
        public static string FinanceAccontNumber { get; set; }
        public static string FinanceCorporateRegistrationNumber { get; set; }
        public static string GeneralCustomerCode { get; set; }
        public static string GeneralCustomerName { get; set; }
        public static string GeneralCorporateRegistrationNumber { get; set; }
    }
}
