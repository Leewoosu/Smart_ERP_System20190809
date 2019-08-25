using SMART_ERP_System.MenuUserControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMART_ERP_System
{
    public static class UserControlList
    {
        public static Dictionary<string, UserControl> Dictionary = new Dictionary<string, UserControl>
        {
            // 회계관리
            { "전표등록", 전표등록 },
            { "전표출력", 전표출력 },
            { "분개장", 분개장 },
            { "결산자료입력", 결산자료입력 },
            { "합계잔액시산표", 합계잔액시산표 },
            { "재무상태표", 재무상태표 },
            { "손익계산서", 손익계산서 },
            { "원가보고서", 원가보고서 },
            { "고정자산등록", 고정자산등록 },
            { "고정자산관리대장", 고정자산관리대장 },
            { "업무용승용차차량등록", 업무용승용차차량등록 },
            { "계정과목등록", 계정과목등록 },
            // 인사관리
            { "소득세액공제환경설정", 소득세액공제환경설정 },
            { "인사급여환경설정", 인사급여환경설정 },
            { "인사정보등록", 인사정보등록 },
            { "급여입력", 급여입력 },
            { "급여대장", 급여대장 },
            { "퇴직기준설정", 퇴직기준설정 },
            { "퇴직금산정", 퇴직금산정 },
            { "퇴직금산정현황", 퇴직금산정현황 },
            // 생산관리
            { "BOM등록및정전개", BOM등록및정전개 },
            { "불량유형등록", 불량유형등록 },
            { "생산계획현황", 생산계획현황 },
            { "작업지시현황", 작업지시현황 },
            { "생산실적입력", 생산실적입력 },
            { "생산실적검사", 생산실적검사 },
            { "일일주간생산일보", 일일주간생산일보 },
            { "재공관리", 재공관리 },
            { "외주입고", 외주입고 },
            { "외주자재출고", 외주자재출고 },
            { "외주발주현황", 외주발주현황 },
            // 물류관리
            { "수주등록", 수주등록 },
            { "발주등록", 발주등록 },
            { "소요량전개",소요량전개 },
            { "입고검사등록",입고검사등록 },
            { "입고등록",입고등록 },
            { "입고처리",입고처리 },
            { "청구등록", 청구등록 },
            { "발주현황",발주현황 },
            { "입고현황",입고현황 },
            { "청구현황",청구현황 },
            { "기초재고및재고조정등록",기초재고및재고조정등록 },
            { "기초재고및재고조정현황",기초재고및재고조정현황 },
            { "출고처리",출고처리 },
            { "매입마감", 매입마감 },
            { "자재등록", 자재등록 },
            { "품목단가등록", 품목단가등록 },
            // 시스템관리
            { "시스템사용권한설정",시스템사용권한설정 },
            { "시스템환경설정", 시스템환경설정 },
            { "부서등록",부서등록 },
            { "사업장등록",사업장등록 },
            { "사원등록",사원등록 },
            { "회사등록",회사등록 },
            { "금융거래처등록",금융거래처등록 },
            { "일반거래처등록",일반거래처등록 },
            { "품목등록", 품목등록 },
            { "프로젝트등록", 프로젝트등록 }
        };

        #region 컨트롤
        // 회계관리
        public static 전표등록 전표등록;
        public static 전표출력 전표출력;
        public static 분개장 분개장;
        public static 결산자료입력 결산자료입력;
        public static 합계잔액시산표 합계잔액시산표;
        public static 재무상태표 재무상태표;
        public static 손익계산서 손익계산서;
        public static 원가보고서 원가보고서;
        public static 고정자산등록 고정자산등록;
        public static 고정자산관리대장 고정자산관리대장;
        public static 업무용승용차차량등록 업무용승용차차량등록;
        public static 계정과목등록 계정과목등록;
        // 인사관리
        public static 소득세액공제환경설정 소득세액공제환경설정;
        public static 인사급여환경설정 인사급여환경설정;
        public static 인사정보등록 인사정보등록;
        public static 급여입력 급여입력;
        public static 급여대장 급여대장;
        public static 퇴직기준설정 퇴직기준설정;
        public static 퇴직금산정 퇴직금산정;
        public static 퇴직금산정현황 퇴직금산정현황;
        // 생산관리
        public static BOM등록및정전개 BOM등록및정전개;
        public static 불량유형등록 불량유형등록;
        public static 생산계획현황 생산계획현황;
        public static 작업지시현황 작업지시현황;
        public static 생산실적입력 생산실적입력;
        public static 생산실적검사 생산실적검사;
        public static 일일주간생산일보 일일주간생산일보;
        public static 재공관리 재공관리;
        public static 외주입고 외주입고;
        public static 외주자재출고 외주자재출고;
        public static 외주발주현황 외주발주현황;
        // 물류관리
        public static 수주등록 수주등록;
        public static 발주등록 발주등록;
        public static 소요량전개 소요량전개;
        public static 입고검사등록 입고검사등록;
        public static 입고등록 입고등록;
        public static 입고처리 입고처리;
        public static 청구등록 청구등록;
        public static 발주현황 발주현황;
        public static 입고현황 입고현황;
        public static 청구현황 청구현황;
        public static 기초재고및재고조정등록 기초재고및재고조정등록;
        public static 기초재고및재고조정현황 기초재고및재고조정현황;
        public static 출고처리 출고처리;
        public static 매입마감 매입마감;
        public static 자재등록 자재등록;
        public static 품목단가등록 품목단가등록;
        // 시스템관리
        public static 시스템사용권한설정 시스템사용권한설정;
        public static 시스템환경설정 시스템환경설정;
        public static 부서등록 부서등록;
        public static 사업장등록 사업장등록;
        public static 사원등록 사원등록;
        public static 회사등록 회사등록;
        public static 금융거래처등록 금융거래처등록;
        public static 일반거래처등록 일반거래처등록;
        public static 품목등록 품목등록;
        public static 프로젝트등록 프로젝트등록;
        #endregion
    }
}
