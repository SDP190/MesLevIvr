using System;
using System.Collections.Generic;

namespace AdvancedData.Data.Entities
{
    public partial class ReceiversItemsOrderItems
    {
        public decimal ReceiverItemId { get; set; }
        public decimal ReceiversOrderId { get; set; }
        public decimal ItemId { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
        public decimal ShippedQuantity { get; set; }
        public decimal SalesTaxPercentage { get; set; }
        public decimal? RegularPrice { get; set; }
        public decimal? TotalAmount { get; set; }
        public decimal? DiscountAmount { get; set; }
        public DateTime? ModifyDate { get; set; }
        public Guid? Oid { get; set; }
        public Guid? OrderOid { get; set; }
        public bool? FromStock { get; set; }
        public bool? FromPrice { get; set; }
        public bool? FromStock1 { get; set; }
        public int? ItemDiscount { get; set; }

        public virtual ReceiversItemsOrders ReceiversOrder { get; set; }
    }
}
