namespace Transport_X.Entities
{
    public class Order
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
        public int ReceiverWard { get; set;}
        public string? ReceiverDistrict { get; set; }
        public string? ReceiverProvince { get; set; }
        public int SenderWard { get; set; }
        public string? SenderDistrict { get; set; }
        public string? SenderProvince { get; set; }
        public string? GoodsName { get; set; }
        public string? WeightName { get; set; }
        public string? InsuranceName { get; set; }
        public string? StatusName { get; set; }
        public Guid? UserId { get; set; }

        public AppUser AppUser { get; set; }
        public Ward Ward { get; set; }
        public Goods Goods { get; set; }
        public Weight Weight { get; set; }  
        public Insurance Insurance { get; set; }
        public Status Status { get; set; }

       
        //public District District { get; set; }
        //public Province Province { get; set; }
    }
}
