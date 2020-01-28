using System;
// ReSharper disable InconsistentNaming

namespace AdvancedData.Data.Entities
{
    public class Payments
    {
        public decimal PaymentID { get; set; }
        public decimal DonorID { get; set; }
        public DateTime Date { get; set; }
        public decimal Value { get; set; }
        public decimal CurrencyID { get; set; }
        public decimal CampaignID { get; set; }
        public decimal OrganizationID { get; set; }
        public decimal AccountID { get; set; }
        public decimal SolicitorID { get; set; }
        public decimal JournalID { get; set; }
        public decimal BatchID { get; set; }
        public decimal DepositID { get; set; }
        public decimal PaymentType { get; set; }
        public decimal TenderID { get; set; }
        public byte Status { get; set; }
        public bool TYSend { get; set; }
        public string PaymentNote { get; set; }
        public string ReceiptNote { get; set; }
        public DateTime AddDate { get; set; }
        public decimal AddUserID { get; set; }
        public DateTime ModifyDate { get; set; }
        public decimal ModifyUserID { get; set; }
        public string ReceiptName { get; set; }
        public string ReceiptNumber { get; set; }
        public decimal ChargeID { get; set; }
        public string RebillNumber { get; set; }
        public decimal PaymentDonorAddressID { get; set; }
        public string PaymentAddress { get; set; }
        public string PaymentCity { get; set; }
        public string PaymentState { get; set; }
        public string PaymentZip { get; set; }
        public string PaymentCountry { get; set; }
        public decimal MemoryDonorID { get; set; }
        public bool School { get; set; }
        public bool IsFuturePledgePayment { get; set; }
        public bool FillMemoryWithFamilyRelations { get; set; }
        public string PaymentAddress2 { get; set; }
        public decimal? SchoolYearID { get; set; }
        public bool OrderPaymnent { get; set; }
        public bool UpdateTotalAmount { get; set; }
        public decimal Payment_TotalAmount { get; set; }
        public decimal Payment_TotalPaidPledges { get; set; }
        public string PaymentAddress3 { get; set; }
        public string PaymentAddress4 { get; set; }
        public int SchoolType { get; set; }
        public decimal? ReceiverID { get; set; }
        public int? ShulID { get; set; }
        public string DonorEmailPayment { get; set; }
        public string EmailTemplate { get; set; }
        public bool? EmailReceipt { get; set; }
        public decimal? RecurringId { get; set; }
        public int? SubSolicitorID { get; set; }
        public int? SubCampaignID { get; set; }
        public decimal? LocationId { get; set; }
        public decimal? SubLocationid { get; set; }
        public bool? OfficialReceipt { get; set; }
        public string TenderTypeVia { get; set; }
    }
}
