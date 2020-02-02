using System;
using System.Collections.Generic;

namespace AdvancedData.Data.Entities
{
    public partial class ReceiversItemsOrders
    {
        public ReceiversItemsOrders()
        {
            ReceiversItemsOrderItems = new HashSet<ReceiversItemsOrderItems>();
        }

        public decimal ReceiversOrderId { get; set; }
        public decimal ReceiverId { get; set; }
        public decimal ShippingCharge { get; set; }
        public byte Status { get; set; }
        public DateTime Date { get; set; }
        public string Notes { get; set; }
        public int? AddUserId { get; set; }
        public int? ModifyUserId { get; set; }
        public decimal? TotalAmount { get; set; }
        public decimal? Taxes { get; set; }
        public int? DiscountId { get; set; }
        public int? PickupPlace { get; set; }
        public Guid? Oid { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string Packing { get; set; }
        public int? PackNo { get; set; }
        public string Note { get; set; }
        public string ShippingAddress { get; set; }

        public virtual Receivers Receiver { get; set; }
        public virtual ICollection<ReceiversItemsOrderItems> ReceiversItemsOrderItems { get; set; }
    }
}
