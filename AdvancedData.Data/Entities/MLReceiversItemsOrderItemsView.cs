// ReSharper disable InconsistentNaming
namespace AdvancedData.Data.Entities
{
    public class MLReceiversItemsOrderItemsView
    {
        public decimal Receivers_OrderID { get; set; }
        public decimal ItemID { get; set; }
        public decimal Quantity { get; set; }
        public int? PickupPlace { get; set; }
        public string HomePhone { get; set; }
        public decimal? ReceiverID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string STATE { get; set; }
        public string Zip { get; set; }
    }
}
