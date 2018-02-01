namespace DataLibrary.Domain
{
    public class Address : BaseEntity
    {  
        /// <summary>
        /// 订单编号
        /// </summary>
        public string Poco { get; set; }

        /// <summary>
        /// 收货人
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 收货详情地址
        /// </summary>
        public string AddressDetile { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// 区域编号 省+市+区 拼接
        /// </summary>
        public string AreaCode { get; set; }

        /// <summary>
        /// 邮编
        /// </summary>
        public string PostalCode { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        public string Emaile { get; set; }

        /// <summary>
        /// 电话
        /// </summary>
        public string Tel { get; set; }
    }
}
