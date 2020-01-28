using System;
// ReSharper disable InconsistentNaming

namespace AdvancedData.Data.Entities
{
    public class Receivers
    {
        public decimal ReceiverID { get; set; }
        public string dTitle { get; set; }
        public string FirstName { get; set; }
        public string MiddleInitial { get; set; }
        public string LastName { get; set; }
        public string Nickname { get; set; }
        public string HdTitle { get; set; }
        public string HFirstName { get; set; }
        public string HMI { get; set; }
        public string HLastName { get; set; }
        public string HNickName { get; set; }
        public string HSuffix { get; set; }
        public string SpouseTitle { get; set; }
        public string SpouseName { get; set; }
        public string SpouseHebrewTitle { get; set; }
        public string SpouseHebrewName { get; set; }
        public string SpouseNickname { get; set; }
        public string HSpouseSuffix { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public string HomePhone { get; set; }
        public string CellPhone { get; set; }
        public string SpouseCellPhone { get; set; }
        public bool? Employment { get; set; }
        public decimal? Incomeperweek { get; set; }
        public bool? SpouseEmployed { get; set; }
        public decimal? SpouseIncome { get; set; }
        public bool? GovernmentPrograms { get; set; }
        public bool? FoodStamps { get; set; }
        public decimal? FoodStampsAmount { get; set; }
        public bool? Section8 { get; set; }
        public decimal? Section8Amount { get; set; }
        public bool? Welfare { get; set; }
        public decimal? WelfareAmount { get; set; }
        public decimal? Rent { get; set; }
        public decimal? Tuition { get; set; }
        public string DebtDescription { get; set; }
        public string Debttowhomandhowmuch { get; set; }
        public decimal? Grocerys_money { get; set; }
        public string Shul { get; set; }
        public string NameandNumberofRAV { get; set; }
        public string AskenNameandnumber { get; set; }
        public bool? Active { get; set; }
        public DateTime AddDate { get; set; }
        public string CardID { get; set; }
        public decimal AddUserID { get; set; }
        public DateTime ModifyDate { get; set; }
        public decimal ModifyUserID { get; set; }
        public string Address2 { get; set; }
        public bool? Car { get; set; }
        public string Father { get; set; }
        public string FatherInLaw { get; set; }
        public string ID { get; set; }
        public string IDSpouse { get; set; }
        public int? Kids { get; set; }
        public int? KidsMarried { get; set; }
        public string Kollel { get; set; }
        public string Note { get; set; }
        public string Party { get; set; }
        public string SpouseWark { get; set; }
        public string SpouseWarkPlace { get; set; }
        public string Work { get; set; }
        public string WorkPlace { get; set; }
        public string Category { get; set; }
        public int? KidsOver16 { get; set; }
        public Guid? OID { get; set; }
        public string Email { get; set; }
    }
}
