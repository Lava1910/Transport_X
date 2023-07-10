using Azure.Core;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Transport_X.EF;
using Transport_X.Entities;
using Transport_X.Interfaces;
using Transport_X.Requests.Order;
using Transport_X.ViewModel;

namespace Transport_X.Services
{
    public class OrderService : IOrderService
    {
        public readonly TransportXDbContext _context;
        public OrderService(TransportXDbContext context)
        {
            _context = context;
        }
        public string WardToDistrict(int WardCode)
        {
            var ward = _context.Wards.Where(e => e.WardCode == WardCode);
            var districtId = ward.First().DistrictId;
            var district = _context.Districts.Where(e => e.DistrictId == districtId);
            var districtName = district.First().DistrictName;
            return districtName;
        }
        public string DistrictToProvince(int WardCode)
        {
            var ward = _context.Wards.Where(e => e.WardCode == WardCode);
            var districtId = ward.First().DistrictId;
            var district = _context.Districts.Where(e => e.DistrictId == districtId);
            var provinceID = district.First().ProvinceId;
            var province = _context.Provinces.Where(e => e.ProvinceId == provinceID);
            var provinceName = province.First().ProvinceName;
            return provinceName;
        }
        public string RandomId()
        {
            string allowedChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random random = new Random();
            string randomString = new string(Enumerable.Repeat(allowedChars, 7)
                .Select(s => s[random.Next(s.Length)]).ToArray());
            return randomString;
        }
        public async Task<string> Create(OrderCreateRequest request)
        {
            var Order = new Order()
            {
                //chưa có userID
                OrderId = RandomId(),
                SenderName = request.SenderName,
                SenderPhone = request.SenderPhone,
                SenderAddress = request.SenderAddress,
                SenderWard = request.SenderWard,
                SenderDistrict = WardToDistrict(request.SenderWard),
                SenderProvince = DistrictToProvince(request.SenderWard),
                DeliveryDate = DateTime.Now.AddDays(1),
                Note = request.Note,
                Proceeds = request.Proceeds,
                ReceiverName = request.ReceiverName,
                ReceiverPhone = request.ReceiverPhone,
                ReceiverAddress = request.ReceiverAddress,
                ReceiverWard = request.ReceiverWard,
                ReceiverDistrict = WardToDistrict(request.ReceiverWard),
                ReceiverProvince = DistrictToProvince(request.ReceiverWard),
                ReceiveDate = DateTime.Now.AddDays(5), //chưa có theo địa lý
                GoodsName = request.GoodsName,
                WeightName = request.WeightName,
                InsuranceName = request.InsuranceName,
                StatusName = _context.Status.First().StatusName,
                UserId = request.UserId
            };
            _context.Orders.Add(Order);
            await _context.SaveChangesAsync();
            return Order.OrderId;
        }   
        public Task<int> Delete(int orderId)
        {
            throw new NotImplementedException();
        }

        public Task<string> Update(OrderEditRequest request)
        {
            throw new NotImplementedException();
        }

        public async Task<List<OrderViewModel>> GetOrderListByUserId(Guid userId)
        {
            var data = await _context.Orders.Where(x => x.UserId == userId)
            .Select(y => new OrderViewModel
            {
                OrderId = y.OrderId,
                SenderName = y.SenderName,
                SenderPhone = y.SenderPhone,
                SenderAddress = y.SenderAddress,
                SenderWard = y.SenderWard,
                SenderDistrict = y.SenderDistrict,
                SenderProvince = y.SenderProvince,
                DeliveryDate = y.DeliveryDate,
                Note = y.Note,
                Proceeds = y.Proceeds,
                ReceiverName = y.ReceiverName,
                ReceiverPhone = y.ReceiverPhone,
                ReceiverAddress = y.ReceiverAddress,
                ReceiverWard = y.ReceiverWard,
                ReceiverDistrict = y.ReceiverDistrict,
                ReceiverProvince = y.ReceiverProvince,
                ReceiveDate = y.ReceiveDate,
                GoodsName = y.GoodsName,
                WeightName = y.WeightName,
                InsuranceName = y.InsuranceName,
                StatusName = y.StatusName
            }).ToListAsync();
            return data;
        }

        public Task<string> ChangeOrder(OrderEditRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
