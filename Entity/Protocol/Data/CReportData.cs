using System;
using System.Text;

namespace Hydrology.Entity
{
    public class CReportData
    {
        /// <summary>
        /// 数据采集时间
        /// </summary>
        public DateTime Time { get; set; }
        /// <summary>
        /// 水量
        /// </summary>
        public Nullable<Decimal> Water { get; set; }
        /// <summary>
        /// 雨量
        /// </summary>
        public Nullable<Decimal> Rain { get; set; }
        /// <summary>
        /// 电压
        /// </summary>
        public Nullable<Decimal> Voltge { get; set; }

        /**
         * 流速相关数据
         * */
        public Nullable<Decimal> Vm { get; set; }
        public Nullable<Decimal> W1 { get; set; }
        public Nullable<Decimal> Q { get; set; }
        public Nullable<Decimal> v1 { get; set; }
        public Nullable<Decimal> v2 { get; set; }
        public Nullable<Decimal> v3 { get; set; }
        public Nullable<Decimal> v4 { get; set; }
        public Nullable<Decimal> v5 { get; set; }
        public Nullable<Decimal> v6 { get; set; }
        public Nullable<Decimal> v7 { get; set; }
        public Nullable<Decimal> v8 { get; set; }
        public Nullable<Decimal> beta1 { get; set; }
        public Nullable<Decimal> beta2 { get; set; }
        public Nullable<Decimal> beta3 { get; set; }
        public Nullable<Decimal> beta4 { get; set; }
        public Nullable<Decimal> W2 { get; set; }
        public string errorCode { get; set; }
    }
}
