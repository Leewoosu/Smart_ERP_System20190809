using SMART_ERP_System.MenuUserControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMART_ERP_System
{
    public class UserControlList
    {
        #region 컨트롤
        // 회계관리
        public 전표등록 전표등록;
        public 전표출력 전표출력;
        public 분개장 분개장;
        public 결산자료입력 결산자료입력;
        public 합계잔액시산표 합계잔액시산표;
        public 재무상태표 재무상태표;
        public 손익계산서 손익계산서;
        public 원가보고서 원가보고서;
        public 고정자산등록 고정자산등록;
        public 고정자산관리대장 고정자산관리대장;
        public 업무용승용차차량등록 업무용승용차차량등록;
        public 계정과목등록 계정과목등록;
        // 인사관리
        public 소득세액공제환경설정 소득세액공제환경설정;
        public 인사급여환경설정 인사급여환경설정;
        public 인사정보등록 인사정보등록;
        public 급여입력 급여입력;
        public 급여대장 급여대장;
        public 퇴직기준설정 퇴직기준설정;
        public 퇴직금산정 퇴직금산정;
        public 퇴직금산정현황 퇴직금산정현황;
        // 생산관리
        public BOM등록및정전개 BOM등록및정전개;
        public 불량유형등록 불량유형등록;
        public 생산계획현황 생산계획현황;
        public 작업지시현황 작업지시현황;
        public 생산실적입력 생산실적입력;
        public 생산실적검사 생산실적검사;
        public 일일주간생산일보 일일주간생산일보;
        public 재공관리 재공관리;
        public 외주입고 외주입고;
        public 외주자재출고 외주자재출고;
        public 외주발주현황 외주발주현황;
        // 물류관리
        public 수주등록 수주등록;
        public 발주등록 발주등록;
        public 소요량전개 소요량전개;
        public 입고검사등록 입고검사등록;
        public 입고처리 입고처리;
        public 청구등록 청구등록;
        public 발주현황 발주현황;
        public 입고현황 입고현황;
        public 청구현황 청구현황;
        public 기초재고및재고조정등록 기초재고및재고조정등록;
        public 기초재고및재고조정현황 기초재고및재고조정현황;
        public 출고처리 출고처리;
        public 매출마감 매출마감;
        public 자재등록 자재등록;
        public 품목단가등록 품목단가등록;
        // 시스템관리
        public 시스템사용권한설정 시스템사용권한설정;
        public 시스템환경설정 시스템환경설정;
        public 부서등록 부서등록;
        public 사업장등록 사업장등록;
        public 사원등록 사원등록;
        public 회사등록 회사등록;
        public 금융거래처등록 금융거래처등록;
        public 일반거래처등록 일반거래처등록;
        public 품목등록 품목등록;
        public 프로젝트등록 프로젝트등록;
        #endregion

        public void AddControls(out List<UserControl> controls)
        {
            controls = new List<UserControl>();
            controls.AddRange(new UserControl[]
            {
                // 회계관리
                전표등록 = new 전표등록(),
                전표출력 = new 전표출력(),
                분개장 = new 분개장(),
                결산자료입력 = new 결산자료입력(),
                합계잔액시산표 = new 합계잔액시산표(),
                재무상태표 = new 재무상태표(),
                손익계산서 = new 손익계산서(),
                원가보고서 = new 원가보고서(),
                고정자산등록 = new 고정자산등록(),
                고정자산관리대장 = new 고정자산관리대장(),
                업무용승용차차량등록 = new 업무용승용차차량등록(),
                계정과목등록 = new 계정과목등록(),
                // 인사관리
                소득세액공제환경설정 = new 소득세액공제환경설정(),
                인사급여환경설정 = new 인사급여환경설정(),
                인사정보등록 = new 인사정보등록(),
                급여입력 = new 급여입력(),
                급여대장 = new 급여대장(),
                퇴직기준설정 = new 퇴직기준설정(),
                퇴직금산정 = new 퇴직금산정(),
                퇴직금산정현황 = new 퇴직금산정현황(),
                // 생산관리
                BOM등록및정전개 = new BOM등록및정전개(),
                불량유형등록 = new 불량유형등록(),
                생산계획현황 = new 생산계획현황(),
                작업지시현황 = new 작업지시현황(),
                생산실적입력 = new 생산실적입력(),
                생산실적검사 = new 생산실적검사(),
                일일주간생산일보 = new 일일주간생산일보(),
                재공관리 = new 재공관리(),
                외주입고 = new 외주입고(),
                외주자재출고 = new 외주자재출고(),
                외주발주현황 = new 외주발주현황(),
                // 물류관리
                수주등록 = new 수주등록(),
                발주등록 = new 발주등록(),
                소요량전개 = new 소요량전개(),
                입고검사등록 = new 입고검사등록(),
                입고처리 = new 입고처리(),
                청구등록 = new 청구등록(),
                발주현황 = new 발주현황(),
                입고현황 = new 입고현황(),
                청구현황 = new 청구현황(),
                기초재고및재고조정등록 = new 기초재고및재고조정등록(),
                기초재고및재고조정현황 = new 기초재고및재고조정현황(),
                출고처리 = new 출고처리(),
                매출마감 = new 매출마감(),
                자재등록 = new 자재등록(),
                품목단가등록 = new 품목단가등록(),
                // 시스템관리
                시스템사용권한설정 = new 시스템사용권한설정(),
                시스템환경설정 = new 시스템환경설정(),
                부서등록 = new 부서등록(),
                사업장등록 = new 사업장등록(),
                사원등록 = new 사원등록(),
                회사등록 = new 회사등록(),
                금융거래처등록 = new 금융거래처등록(),
                일반거래처등록 = new 일반거래처등록(),
                품목등록 = new 품목등록(),
                프로젝트등록 = new 프로젝트등록()
            });
        }
    }
}
