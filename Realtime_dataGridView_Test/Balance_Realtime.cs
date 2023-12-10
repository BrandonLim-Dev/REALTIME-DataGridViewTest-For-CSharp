using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Realtime_dataGridView_Test
{
    class Balance_Realtime
    {
        public string CodeName { get; set; }        // 종목명
        public decimal CurPrice { get; set; }       // 현재가
        public decimal EvalPrice { get; set; }      // 평가손익
        public double EvalRate { get; set; }        // 손익률

        // Stop Loss
        public decimal BasePrice { get; set; }      // 기준가
        public decimal Stoploss { get; set; }       // 스탑로스

        public Balance_Realtime(string CodeName, decimal CurPrice, decimal EvalPrice, double EvalRate, decimal BasePrice, decimal Stoploss)
        {
            this.CodeName = CodeName;
            this.CurPrice = CurPrice;
            this.EvalPrice = EvalPrice;
            this.EvalRate = EvalRate;
            this.BasePrice = BasePrice;
            this.Stoploss = Stoploss;
        }
    }
}
