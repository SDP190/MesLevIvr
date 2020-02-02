using System;
using System.Collections.Generic;

namespace AdvancedData.Data.Entities
{
    public partial class PaymentsCharges
    {
        public decimal ChargeId { get; set; }
        public decimal PaymentId { get; set; }
        public decimal CreditCardId { get; set; }
        public decimal Amount { get; set; }
        public string Details { get; set; }
        public bool WentThrough { get; set; }
        public DateTime Date { get; set; }
        public string AuthorizationCode { get; set; }
        public string TransactionId { get; set; }
        public int? AchId { get; set; }
        public string FullResult { get; set; }
        public int? AccountId { get; set; }
        public string Merchant { get; set; }
        public string ApiLogInformation { get; set; }
        public int Status { get; set; }
        public decimal DepositId { get; set; }
        public string TokenId { get; set; }
        public bool? FullRefund { get; set; }
    }
}
