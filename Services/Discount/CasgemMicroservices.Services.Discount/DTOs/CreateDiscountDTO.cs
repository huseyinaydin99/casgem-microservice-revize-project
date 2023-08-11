namespace CasgemMicroservices.Services.Discount.DTOs
{
    public class CreateDiscountDTO
    {
        //public int DiscountCouponsId { get; set; }
        public string UserId { get; set; }
        public int Rate { get; set; }
        public string Code { get; set; }
        public DateTime CreatedTime { get; set; }
    }
}
