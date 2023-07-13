using Transport_X.Entities;

namespace Transport_X.Requests.Order
{
    public class OrderCreateRequest
    {
        public string OrderId { get; set; }
        public string SenderName { get; set; }
        public string SenderPhone { get; set; }
        public string SenderAddress { get; set; }
        public string ReceiverName { get; set; }
        public string ReceiverPhone { get; set; }
        public string ReceiverAddress { get; set; }
        public string Note { get; set; }
        //thu hộ
        public int Proceeds { get; set; }
        public int ReceiverProvinceId { get; set; }
        public int ReceiverWardId { get; set; }
        public int ReceiverDistrictId { get; set; }
        public int SenderProvinceId { get; set; }
        public int SenderDistrictId { get; set; }
        public int SenderWardId { get; set; }
        //loại hàng hóa
        public int GoodsId { get; set; }
        //loại cân nặng
        public int WeightId { get; set; }
        //giá trị hàng - bảo hiểm
        public int InsuranceId { get; set; }
        public Guid? UserId { get; set; }
    }
}
