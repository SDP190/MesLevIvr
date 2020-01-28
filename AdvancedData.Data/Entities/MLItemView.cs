// ReSharper disable InconsistentNaming
namespace AdvancedData.Data.Entities
{
    public class MLItemView
    {
        public decimal ItemID { get; set; }
        public string ItemName { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? was { get; set; }
        public decimal? went { get; set; }
        public decimal Price { get; set; }
    }
}
