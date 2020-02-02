using System;
using System.Collections.Generic;

namespace AdvancedData.Data.Entities
{
    public partial class MLReceiversItemsOrderItemsView
    {
        public decimal ReceiversOrderId { get; set; }
        public decimal ItemId { get; set; }
        public decimal Quantity { get; set; }
        public int? PickupPlace { get; set; }
        public string HomePhone { get; set; }
        public decimal? ReceiverId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
    }
}
