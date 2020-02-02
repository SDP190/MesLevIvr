using System;
using System.Collections.Generic;

namespace AdvancedData.Data.Entities
{
    public partial class DonorsTendersCreditCards
    {
        public decimal DonorTenderCreditCardId { get; set; }
        public decimal DonorId { get; set; }
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
        public bool? Active { get; set; }
        public string Cvv { get; set; }
        public string CardNumberLast4 { get; set; }
        public byte[] Data { get; set; }
        public bool? SaveCard { get; set; }
        public string TokenId { get; set; }
    }
}
