namespace DataLibrary.Domain
{
    public class OrderStatu:BaseEntity
    {
        public string Poco { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        public int Status { get; set; } 

    }
}
