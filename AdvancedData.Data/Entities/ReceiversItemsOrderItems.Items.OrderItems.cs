using System;
// ReSharper disable InconsistentNaming

namespace AdvancedData.Data.Entities
{
    public class ReceiversItemsOrderItems
    {
        public decimal ReceiverItemID { get; set; }
        public decimal Receivers_OrderID { get; set; }
        public decimal ItemID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
        public decimal ShippedQuantity { get; set; }
        public decimal SalesTaxPercentage { get; set; }
        public decimal? RegularPrice { get; set; }
        public decimal? TotalAmount { get; set; }
        public decimal? DiscountAmount { get; set; }
        public DateTime? ModifyDate { get; set; }
        public Guid? OID { get; set; }
        public Guid? OrderOID { get; set; }
        public bool? FromStock { get; set; }
        public bool? from_price { get; set; }
        public bool? from_stock { get; set; }
        public int? ItemDiscount { get; set; }
    }
}
