using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.EntityData
{
    public class DB
    {
        public static 사원등록Data 사원등록 { get; } = new 사원등록Data();    
        public static 계정과목등록Data 계정과목등록 { get; } = new 계정과목등록Data();
        public static 계정과목Data 계정과목 { get; } = new 계정과목Data();
        public static 계정과목그룹Data 계정과목그룹 { get; } = new 계정과목그룹Data();
        public static 거래처Data 거래처 { get; } = new 거래처Data();
        public static 결산자료Data 결산자료 { get; } = new 결산자료Data();
        public static 금융거래처Data 금융거래처 { get; } = new 금융거래처Data();
        public static 일반거래처Data 일반거래처 { get; } = new 일반거래처Data();
        public static 전표리스트Data 전표리스트 { get; } = new 전표리스트Data();
        public static 전표Data 전표 { get; } = new 전표Data();
        public static 수주Data 수주 { get; } = new 수주Data();
        public static 제품Data 제품 { get; } = new 제품Data();
        public static 생산계획Data 생산계획 { get; } = new 생산계획Data();
        public static 부서등록Data 부서 { get; } = new 부서등록Data();
        public static 발주서Data 발주서 { get; } = new 발주서Data();
        public static 발주리스트Data 발주리스트 { get; } = new 발주리스트Data();
        public static 자재명세서Data 자재명세서 { get; } = new 자재명세서Data();
        public static 재무상태표Data 재무상태표 { get; } = new 재무상태표Data();
        public static 손익계산서Data 손익계산서 { get; } = new 손익계산서Data();
        public static 예금종류Data 예금종류 { get; } = new 예금종류Data();
        public static 자재Data 자재 { get; } = new 자재Data();
        public static 고정자산등록Data 고정자산 { get; } = new 고정자산등록Data();
        public static 고정자산계정과목Data 고정자산계정과목 { get; } = new 고정자산계정과목Data();
        public static 입고검사Data 입고검사 { get; } = new 입고검사Data();
        public static 회사등록Data 회사 { get; } = new 회사등록Data();
        public static 합계잔액시산표Data 합계잔액시산표 { get; } = new 합계잔액시산표Data();

        public static 공급자재리스트Data 공급자재리스트 { get; } = new 공급자재리스트Data();
        public static 입고등록Data 입고등록 { get; } = new 입고등록Data();
        public static 입고등록리스트Data 입고등록리스트 { get; } = new 입고등록리스트Data();
        public static 불량상세정보Data 불량상세정보 { get; } = new 불량상세정보Data();
        public static 불량코드내역Data 불량코드내역 { get; } = new 불량코드내역Data();
        public static 반품처리서Data 반품처리서 { get; } = new 반품처리서Data();
        public static 반품처리리스트Data 반품처리리스트 { get; } = new 반품처리리스트Data();
        public static 자재전표Data 자재전표 { get; } = new 자재전표Data();
        public static 자재상세전표Data 자재상세전표 { get; } = new 자재상세전표Data();
        public static 작업지시현황Data 작업지시현황 { get; } = new 작업지시현황Data();
        public static 인사정보등록Data 사원상세정보 { get; } = new 인사정보등록Data();
    }
}
