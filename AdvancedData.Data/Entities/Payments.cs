using System;
using System.Collections.Generic;

namespace AdvancedData.Data.Entities
{
    public partial class Payments
    {
        public Payments()
        {
            ReceiversItemsOrderPayments = new HashSet<ReceiversItemsOrderPayments>();
        }

        public decimal PaymentId { get; set; } //Test change
        public decimal DonorId { get; set; }
        public DateTime Date { get; set; }
        public decimal Value { get; set; }
        public decimal CurrencyId { get; set; }
        public decimal CampaignId { get; set; }
        public decimal OrganizationId { get; set; }
        public decimal AccountId { get; set; }
        public decimal SolicitorId { get; set; }
        public decimal JournalId { get; set; }
        public decimal BatchId { get; set; }
        public decimal DepositId { get; set; }
        public decimal PaymentType { get; set; }
        public decimal TenderId { get; set; }
        public byte Status { get; set; }
        public bool Tysend { get; set; }
        public string PaymentNote { get; set; }
        public string ReceiptNote { get; set; }
        public DateTime AddDate { get; set; }
        public decimal AddUserId { get; set; }
        public DateTime ModifyDate { get; set; }
        public decimal ModifyUserId { get; set; }
        public string ReceiptName { get; set; }
        public string ReceiptNumber { get; set; }
        public decimal ChargeId { get; set; }
        public string RebillNumber { get; set; }
        public decimal PaymentDonorAddressId { get; set; }
        public string PaymentAddress { get; set; }
        public string PaymentCity { get; set; }
        public string PaymentState { get; set; }
        public string PaymentZip { get; set; }
        public string PaymentCountry { get; set; }
        public decimal MemoryDonorId { get; set; }
        public bool School { get; set; }
        public bool IsFuturePledgePayment { get; set; }
        public bool FillMemoryWithFamilyRelations { get; set; }
        public string PaymentAddress2 { get; set; }
        public decimal? SchoolYearId { get; set; }
        public bool OrderPaymnent { get; set; }
        public bool UpdateTotalAmount { get; set; }
        public decimal PaymentTotalAmount { get; set; }
        public decimal PaymentTotalPaidPledges { get; set; }
        public string PaymentAddress3 { get; set; }
        public string PaymentAddress4 { get; set; }
        public int SchoolType { get; set; }
        public decimal? ReceiverId { get; set; }
        public int? ShulId { get; set; }
        public string DonorEmailPayment { get; set; }
        public string EmailTemplate { get; set; }
        public bool? EmailReceipt { get; set; }
        public decimal? RecurringId { get; set; }
        public int? SubSolicitorId { get; set; }
        public int? SubCampaignId { get; set; }
        public decimal? LocationId { get; set; }
        public decimal? SubLocationid { get; set; }
        public bool? OfficialReceipt { get; set; }
        public string TenderTypeVia { get; set; }

        public virtual ICollection<ReceiversItemsOrderPayments> ReceiversItemsOrderPayments { get; set; }
    }
}
