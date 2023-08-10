namespace CasgemMicroservice.Services.Basket.DTOs
{
    public class BasketDTO
    {
        public string UserId { get; set; }
        public string Discount { get; set; }
        public int? DiscountRate { get; set; }
        public List<BasketItemDTO> BasketItems { get; set; }
        public decimal TotalPrice
        {
            get => BasketItems.Sum(x => x.Price * x.Quantity);
        }
    }
}