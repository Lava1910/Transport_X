namespace Transport_X.ViewModel
{
    public class OrderViewModel
    {
        public string OrderId { get; set; }
        public string? SenderName { get; set; }
        public string? SenderPhone { get; set; }
        public string? SenderAddress { get; set; }
        public string? ReceiverName { get; set; }
        public string? ReceiverPhone { get; set; }
        public string? ReceiverAddress { get; set; }
        public string? Note { get; set; }
        public int Proceeds { get; set; }
        public DateTime DeliveryDate { get; set; }
        public DateTime ReceiveDate { get; set; }
        //fk
        public int ReceiverWard { get; set; }
        public string? ReceiverDistrict { get; set; }
        public string? ReceiverProvince { get; set; }
        public int SenderWard { get; set; }
        public string? SenderDistrict { get; set; }
        public string? SenderProvince { get; set; }
        public string? GoodsName { get; set; }
        public string? WeightName { get; set; }
        public string? InsuranceName { get; set; }
        public string? StatusName { get; set; }
        public Guid? userId { get; set; }
    }
}
