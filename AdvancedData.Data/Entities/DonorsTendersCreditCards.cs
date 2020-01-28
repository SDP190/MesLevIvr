// ReSharper disable InconsistentNaming
namespace AdvancedData.Data.Entities
{
    public class DonorsTendersCreditCards
    {

        public decimal DonorTenderCreditCardID { get; set; }
        public decimal DonorID { get; set; }
        public string CreditCardType { get; set; }
        public string CardNumber { get; set; }
        public byte? ExpirationDateMonth { get; set; }
        public decimal? ExpirationDateYear { get; set; }
        public string CardholderName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public bool Active { get; set; }
        public string CVV { get; set; }
        public string CardNumberLast4 { get; set; }
        public byte[] Data { get; set; }
        public bool? SaveCard { get; set; }
        public string TokenID { get; set; }
    }
}
