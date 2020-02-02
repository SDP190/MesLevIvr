using System;
using System.Collections.Generic;

namespace AdvancedData.Data.Entities
{
    public partial class MLItemView
    {
        public decimal ItemId { get; set; }
        public string ItemName { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? Was { get; set; }
        public decimal? Went { get; set; }
        public decimal Price { get; set; }
    }
}
