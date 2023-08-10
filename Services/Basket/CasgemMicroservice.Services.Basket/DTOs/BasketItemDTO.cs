namespace CasgemMicroservice.Services.Basket.DTOs
{
    public class BasketItemDTO
    {
        public int Quantity { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
    }
}
