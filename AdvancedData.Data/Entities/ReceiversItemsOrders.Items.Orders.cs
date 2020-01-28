using System;
// ReSharper disable InconsistentNaming

namespace AdvancedData.Data.Entities
{
    public class ReceiversItemsOrders
    {
        public decimal Receivers_OrderID { get; set; }
        public decimal ReceiverID { get; set; }
        public decimal ShippingCharge { get; set; }
        public byte Status { get; set; }
        public DateTime Date { get; set; }
        public string Notes { get; set; }
        public int? AddUserID { get; set; }
        public int? ModifyUserID { get; set; }
        public decimal? TotalAmount { get; set; }
        public decimal? Taxes { get; set; }
        public int? DiscountID { get; set; }
        public int? PickupPlace { get; set; }
        public Guid? OID { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string Packing { get; set; }
        public int? Pack_no { get; set; }
        public string Note { get; set; }
        public string ShippingAddress { get; set; }
    }
}
