using System;
using System.Collections.Generic;

namespace AdvancedData.Data.Entities
{
    public partial class ReceiversItemsOrderPayments
    {
        public decimal ReceiverOrderPayments { get; set; }
        public decimal? ReceiversOrderId { get; set; }
        public decimal? PaymentId { get; set; }

        public virtual Payments Payment { get; set; }
    }
}
