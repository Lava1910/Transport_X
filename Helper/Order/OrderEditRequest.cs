using Transport_X.Entities;

namespace Transport_X.Requests.Order
{
    public class OrderEditRequest
    {
        public int OrderId { get; set; }
        public string SenderName { get; set; }
        public string SenderPhone { get; set; }
        public string SenderAddress { get; set; }
        public string ReceiverName { get; set; }
        public string ReceiverPhone { get; set; }
        public string ReceiverAddress { get; set; }
        public string Note { get; set; }
        //thu hộ
        public int Proceeds { get; set; }
        public int ReceiverWard { get; set; }
        public int SenderWard { get; set; }
        //loại hàng hóa
        public int GoodsId { get; set; }
        //loại cân nặng
        public int WeightId { get; set; }
        //giá trị hàng - bảo hiểm
        public int InsuranceId { get; set; }
    }
}
