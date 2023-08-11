namespace CasgemMicroservices.Services.Discount.Models
{
    public class DiscountCoupons
    {
        public int DiscountCouponsId { get; set; }
        public string UserId { get; set; }
        public int Rate { get; set; }
        public string Code { get; set; }
        public DateTime CreatedTime { get; set; }
    }
}
