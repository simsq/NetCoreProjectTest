using System;

namespace DataLibrary.Domain
{
    public class OrderMaster : BaseEntity
    {
        /// <summary>
        /// 订单编号
        /// </summary>
        public string Poco { get; set; }

        /// <summary>
        /// 来源编号
        /// </summary>
        public string SourceCode { get; set; }

        /// <summary>
        /// 来源名称
        /// </summary>
        public string SourceName { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 订单总额
        /// </summary>
        public Decimal Total { get; set; }

        /// <summary>
        /// 付款方式: 货到付款 账期支付
        /// </summary>
        public int PaymentType { get; set; }
    }
}
