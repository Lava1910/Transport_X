namespace Transport_X.ViewModel
{
    public class OrderViewModel
    {
        public string? OrderId { get; set; }
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
        public int ReceiverWardId { get; set; }
        public int? ReceiverDistrictId { get; set; }
        public int? ReceiverProvinceId { get; set; }
        public int SenderWardId { get; set; }
        public int? SenderDistrictId { get; set; }
        public int? SenderProvinceId { get; set; }
        public int GoodsId { get; set; }
        public int WeightId { get; set; }
        public int InsuranceId { get; set; }
        public int StatusId { get; set; }
        public Guid? UserId { get; set; }
    }
}
