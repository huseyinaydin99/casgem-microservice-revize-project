namespace CasgemMicroservice.Services.Payment.WebAPI.DAL
{
    public class PaymentDetail
    {
        public int PaymentDetailId { get; set; }
        public string CardNumber { get; set; }
        public string CustomerNameSurname { get; set; }
        public decimal Price { get; set; }
        public string PaymentStatus { get; set; }
    }
}