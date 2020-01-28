using System;
// ReSharper disable InconsistentNaming

namespace AdvancedData.Data.Entities
{
    public class PaymentsCharges
    {
        public decimal ChargeID { get; set; }
        public decimal PaymentID { get; set; }
        public decimal CreditCardID { get; set; }
        public decimal Amount { get; set; }
        public string Details { get; set; }
        public bool WentThrough { get; set; }
        public DateTime Date { get; set; }
        public string AuthorizationCode { get; set; }
        public string TransactionID { get; set; }
        public int? AchId { get; set; }
        public string fullResult { get; set; }
        public int? AccountID { get; set; }
        public string Merchant { get; set; }
        public string ApiLogInformation { get; set; }
        public int Status { get; set; }
        public decimal DepositID { get; set; }
        public string TokenID { get; set; }
        public bool? FullRefund { get; set; }
    }
}
