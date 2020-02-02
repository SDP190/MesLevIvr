using System;
using System.Collections.Generic;

namespace AdvancedData.Data.Entities
{
    public partial class MLItemsOutStockView
    {
        public int? Quantity { get; set; }
        public decimal Size { get; set; }
        public decimal Gender { get; set; }
        public string SubcategoriesList { get; set; }
    }
}
