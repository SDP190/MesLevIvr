using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using AdvancedData.Data.Entities;

namespace AdvancedData.Data
{
    public partial class AdvancedDataContext : DbContext
    {
        public AdvancedDataContext()
        {
        }

        public AdvancedDataContext(DbContextOptions<AdvancedDataContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DonorsTendersCreditCards> DonorsTendersCreditCards { get; set; }
        public virtual DbSet<MLItemView> MLItemView { get; set; }
        public virtual DbSet<MLItemsOutStockView> MLItemsOutStockView { get; set; }
        public virtual DbSet<MLReceiversItemsOrderItemsView> MLReceiversItemsOrderItemsView { get; set; }
        public virtual DbSet<MLReceiversItemsOrderItemsViewNotCom> MLReceiversItemsOrderItemsViewNotCom { get; set; }
        public virtual DbSet<MLReceiversQuantityMatzosView> MLReceiversQuantityMatzosView { get; set; }
        public virtual DbSet<Payments> Payments { get; set; }
        public virtual DbSet<PaymentsCharges> PaymentsCharges { get; set; }
        public virtual DbSet<Receivers> Receivers { get; set; }
        public virtual DbSet<ReceiversItemsOrderItems> ReceiversItemsOrderItems { get; set; }
        public virtual DbSet<ReceiversItemsOrderPayments> ReceiversItemsOrderPayments { get; set; }
        public virtual DbSet<ReceiversItemsOrders> ReceiversItemsOrders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("SERVER=LAPTOP-4M04VP7E\\SQLEXPRESS; Initial Catalog=AFSMes;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DonorsTendersCreditCards>(entity =>
            {
                entity.HasKey(e => e.DonorTenderCreditCardId);

                entity.Property(e => e.DonorTenderCreditCardId)
                    .HasColumnName("DonorTenderCreditCardID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Address).HasMaxLength(200);

                entity.Property(e => e.CardNumber).HasMaxLength(100);

                entity.Property(e => e.CardNumberLast4)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.CardholderName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.Country).HasMaxLength(50);

                entity.Property(e => e.CreditCardType).HasMaxLength(100);

                entity.Property(e => e.Cvv)
                    .HasColumnName("CVV")
                    .HasMaxLength(50);

                entity.Property(e => e.DonorId)
                    .HasColumnName("DonorID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.ExpirationDateYear).HasColumnType("numeric(4, 0)");

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.State).HasMaxLength(50);

                entity.Property(e => e.TokenId)
                    .HasColumnName("TokenID")
                    .HasMaxLength(100);

                entity.Property(e => e.Zip).HasMaxLength(50);
            });

            modelBuilder.Entity<MLItemView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("MLItemView");

                entity.Property(e => e.ItemId)
                    .HasColumnName("ItemID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ItemName).HasMaxLength(100);

                entity.Property(e => e.Price).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Quantity).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.Was)
                    .HasColumnName("was")
                    .HasColumnType("numeric(38, 2)");

                entity.Property(e => e.Went)
                    .HasColumnName("went")
                    .HasColumnType("decimal(38, 2)");
            });

            modelBuilder.Entity<MLItemsOutStockView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("MLItemsOutStockView");

                entity.Property(e => e.Gender).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.Size)
                    .HasColumnName("size")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.SubcategoriesList).HasMaxLength(50);
            });

            modelBuilder.Entity<MLReceiversItemsOrderItemsView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("MLReceiversItemsOrderItemsView");

                entity.Property(e => e.Address).HasMaxLength(150);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.HomePhone).HasMaxLength(50);

                entity.Property(e => e.ItemId)
                    .HasColumnName("ItemID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ReceiverId)
                    .HasColumnName("ReceiverID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ReceiversOrderId)
                    .HasColumnName("Receivers_OrderID")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.State)
                    .HasColumnName("STATE")
                    .HasMaxLength(50);

                entity.Property(e => e.Zip).HasMaxLength(50);
            });

            modelBuilder.Entity<MLReceiversItemsOrderItemsViewNotCom>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("MLReceiversItemsOrderItemsViewNotCom");

                entity.Property(e => e.Address).HasMaxLength(150);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.HomePhone).HasMaxLength(50);

                entity.Property(e => e.ItemId)
                    .HasColumnName("ItemID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ReceiverId)
                    .HasColumnName("ReceiverID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ReceiversOrderId)
                    .HasColumnName("Receivers_OrderID")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.State)
                    .HasColumnName("STATE")
                    .HasMaxLength(50);

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Zip).HasMaxLength(50);
            });

            modelBuilder.Entity<MLReceiversQuantityMatzosView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("MLReceiversQuantityMatzosView");

                entity.Property(e => e.Quantity).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.ReceiverId)
                    .HasColumnName("ReceiverID")
                    .HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<Payments>(entity =>
            {
                entity.HasKey(e => e.PaymentId)
                    .HasName("PK_Donation");

                entity.HasIndex(e => e.AddDate)
                    .HasName("NonClusteredIndex-20180326-140210");

                entity.HasIndex(e => e.AddUserId)
                    .HasName("AddUserId");

                entity.HasIndex(e => e.Date)
                    .HasName("Date");

                entity.HasIndex(e => e.DonorId)
                    .HasName("Donor");

                entity.HasIndex(e => e.MemoryDonorId)
                    .HasName("MemoryDonor");

                entity.HasIndex(e => e.ModifyUserId)
                    .HasName("ModifyUserId");

                entity.HasIndex(e => e.ReceiptNumber)
                    .HasName("PaymentsReNum");

                entity.HasIndex(e => e.RecurringId)
                    .HasName("RecurringID");

                entity.HasIndex(e => e.ShulId)
                    .HasName("ShulID");

                entity.HasIndex(e => e.SolicitorId)
                    .HasName("PaymentsSolicitorsIndex");

                entity.HasIndex(e => e.Status)
                    .HasName("Status");

                entity.HasIndex(e => e.Value)
                    .HasName("Value");

                entity.HasIndex(e => new { e.AccountId, e.DepositId })
                    .HasName("AcountTRID");

                entity.HasIndex(e => new { e.SubSolicitorId, e.SubCampaignId, e.LocationId, e.SubLocationid })
                    .HasName("subID");

                entity.HasIndex(e => new { e.CurrencyId, e.CampaignId, e.OrganizationId, e.AccountId, e.SolicitorId, e.JournalId })
                    .HasName("PaymentDetailsIndex");

                entity.HasIndex(e => new { e.PaymentId, e.PaymentType, e.PaymentTotalAmount, e.RecurringId, e.Date, e.DonorId })
                    .HasName("nci_payments_date_did_pid_pt_pta_rid");

                entity.HasIndex(e => new { e.PaymentId, e.DonorId, e.Value, e.PaymentType, e.TenderId, e.RecurringId, e.DepositId, e.Status })
                    .HasName("ixPaymentsDepositIDPayments");

                entity.Property(e => e.PaymentId)
                    .HasColumnName("PaymentID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AccountId)
                    .HasColumnName("AccountID")
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1/1/2000')");

                entity.Property(e => e.AddUserId)
                    .HasColumnName("AddUserID")
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.BatchId)
                    .HasColumnName("BatchID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CampaignId)
                    .HasColumnName("CampaignID")
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ChargeId)
                    .HasColumnName("ChargeID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CurrencyId)
                    .HasColumnName("CurrencyID")
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1/1/2000')");

                entity.Property(e => e.DepositId)
                    .HasColumnName("DepositID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.DonorEmailPayment).HasMaxLength(550);

                entity.Property(e => e.DonorId)
                    .HasColumnName("DonorID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.EmailReceipt).HasDefaultValueSql("((0))");

                entity.Property(e => e.EmailTemplate).HasMaxLength(550);

                entity.Property(e => e.JournalId)
                    .HasColumnName("JournalID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.LocationId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MemoryDonorId)
                    .HasColumnName("MemoryDonorID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ModifyDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1/1/2000')");

                entity.Property(e => e.ModifyUserId)
                    .HasColumnName("ModifyUserID")
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.OrganizationId)
                    .HasColumnName("OrganizationID")
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PaymentAddress).HasMaxLength(150);

                entity.Property(e => e.PaymentAddress2).HasMaxLength(200);

                entity.Property(e => e.PaymentAddress3).HasMaxLength(200);

                entity.Property(e => e.PaymentAddress4).HasMaxLength(200);

                entity.Property(e => e.PaymentCity).HasMaxLength(50);

                entity.Property(e => e.PaymentCountry).HasMaxLength(50);

                entity.Property(e => e.PaymentDonorAddressId)
                    .HasColumnName("PaymentDonorAddressID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.PaymentNote).HasMaxLength(2000);

                entity.Property(e => e.PaymentState).HasMaxLength(50);

                entity.Property(e => e.PaymentTotalAmount)
                    .HasColumnName("Payment_TotalAmount")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.PaymentTotalPaidPledges)
                    .HasColumnName("Payment_TotalPaidPledges")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.PaymentType)
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((3))");

                entity.Property(e => e.PaymentZip).HasMaxLength(50);

                entity.Property(e => e.RebillNumber).HasMaxLength(2000);

                entity.Property(e => e.ReceiptName).HasMaxLength(100);

                entity.Property(e => e.ReceiptNote).HasMaxLength(2000);

                entity.Property(e => e.ReceiptNumber).HasMaxLength(100);

                entity.Property(e => e.ReceiverId)
                    .HasColumnName("ReceiverID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.RecurringId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SchoolYearId)
                    .HasColumnName("SchoolYearID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ShulId).HasColumnName("ShulID");

                entity.Property(e => e.SolicitorId)
                    .HasColumnName("SolicitorID")
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SubCampaignId).HasColumnName("SubCampaignID");

                entity.Property(e => e.SubLocationid).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.SubSolicitorId).HasColumnName("SubSolicitorID");

                entity.Property(e => e.TenderId)
                    .HasColumnName("TenderID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TenderTypeVia).HasMaxLength(50);

                entity.Property(e => e.Tysend).HasColumnName("TYSend");

                entity.Property(e => e.Value).HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<PaymentsCharges>(entity =>
            {
                entity.HasKey(e => e.ChargeId);

                entity.HasIndex(e => e.PaymentId)
                    .HasName("PaymentID");

                entity.Property(e => e.ChargeId)
                    .HasColumnName("ChargeID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.Amount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CreditCardId)
                    .HasColumnName("CreditCardID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('07.07.2007')");

                entity.Property(e => e.DepositId)
                    .HasColumnName("DepositID")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.FullRefund).HasDefaultValueSql("((0))");

                entity.Property(e => e.FullResult).HasColumnName("fullResult");

                entity.Property(e => e.Merchant).HasMaxLength(50);

                entity.Property(e => e.PaymentId)
                    .HasColumnName("PaymentID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TokenId)
                    .HasColumnName("TokenID")
                    .HasMaxLength(100);

                entity.Property(e => e.TransactionId).HasColumnName("TransactionID");
            });

            modelBuilder.Entity<Receivers>(entity =>
            {
                entity.HasKey(e => e.ReceiverId);

                entity.Property(e => e.ReceiverId)
                    .HasColumnName("ReceiverID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.AddUserId)
                    .HasColumnName("AddUserID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Address).HasMaxLength(150);

                entity.Property(e => e.Address2).HasMaxLength(150);

                entity.Property(e => e.AskenNameandnumber).HasMaxLength(200);

                entity.Property(e => e.CardId)
                    .HasColumnName("CardID")
                    .HasMaxLength(500);

                entity.Property(e => e.Category).HasMaxLength(50);

                entity.Property(e => e.CellPhone).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.Country).HasMaxLength(250);

                entity.Property(e => e.DTitle)
                    .HasColumnName("dTitle")
                    .HasMaxLength(50);

                entity.Property(e => e.DebtDescription).HasMaxLength(500);

                entity.Property(e => e.Debttowhomandhowmuch).HasMaxLength(500);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Father).HasMaxLength(50);

                entity.Property(e => e.FatherInLaw).HasMaxLength(50);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.FoodStampsAmount).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.GrocerysMoney)
                    .HasColumnName("Grocerys_money")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.HdTitle).HasMaxLength(50);

                entity.Property(e => e.HfirstName)
                    .HasColumnName("HFirstName")
                    .HasMaxLength(50);

                entity.Property(e => e.HlastName)
                    .HasColumnName("HLastName")
                    .HasMaxLength(50);

                entity.Property(e => e.Hmi)
                    .HasColumnName("HMI")
                    .HasMaxLength(50);

                entity.Property(e => e.HnickName)
                    .HasColumnName("HNickName")
                    .HasMaxLength(50);

                entity.Property(e => e.HomePhone).HasMaxLength(50);

                entity.Property(e => e.HspouseSuffix)
                    .HasColumnName("HSpouseSuffix")
                    .HasMaxLength(50);

                entity.Property(e => e.Hsuffix)
                    .HasColumnName("HSuffix")
                    .HasMaxLength(50);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(50);

                entity.Property(e => e.Idspouse)
                    .HasColumnName("IDSpouse")
                    .HasMaxLength(50);

                entity.Property(e => e.Incomeperweek).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Kollel).HasMaxLength(250);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.MiddleInitial).HasMaxLength(50);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.ModifyUserId)
                    .HasColumnName("ModifyUserID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.NameandNumberofRav)
                    .HasColumnName("NameandNumberofRAV")
                    .HasMaxLength(200);

                entity.Property(e => e.Nickname).HasMaxLength(50);

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Party).HasMaxLength(50);

                entity.Property(e => e.Rent).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Section8Amount).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Shul).HasMaxLength(50);

                entity.Property(e => e.SpouseCellPhone).HasMaxLength(50);

                entity.Property(e => e.SpouseHebrewName).HasMaxLength(50);

                entity.Property(e => e.SpouseHebrewTitle).HasMaxLength(50);

                entity.Property(e => e.SpouseIncome).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.SpouseName).HasMaxLength(50);

                entity.Property(e => e.SpouseNickname).HasMaxLength(50);

                entity.Property(e => e.SpouseTitle).HasMaxLength(50);

                entity.Property(e => e.SpouseWark).HasMaxLength(50);

                entity.Property(e => e.SpouseWarkPlace).HasMaxLength(50);

                entity.Property(e => e.State).HasMaxLength(50);

                entity.Property(e => e.Tuition).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.WelfareAmount).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Work).HasMaxLength(50);

                entity.Property(e => e.WorkPlace).HasMaxLength(50);

                entity.Property(e => e.Zip).HasMaxLength(50);
            });

            modelBuilder.Entity<ReceiversItemsOrderItems>(entity =>
            {
                entity.HasKey(e => e.ReceiverItemId);

                entity.ToTable("Receivers.Items.OrderItems");

                entity.HasIndex(e => e.ItemId)
                    .HasName("NonClusteredIndex-20170314-164103");

                entity.HasIndex(e => e.ReceiversOrderId)
                    .HasName("NonClusteredIndex-20170314-164138");

                entity.Property(e => e.ReceiverItemId)
                    .HasColumnName("ReceiverItemID")
                    .HasColumnType("decimal(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.DiscountAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FromPrice).HasColumnName("from_price");

                entity.Property(e => e.FromStock1).HasColumnName("from_stock");

                entity.Property(e => e.ItemId)
                    .HasColumnName("ItemID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.OrderOid).HasColumnName("OrderOID");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ReceiversOrderId)
                    .HasColumnName("Receivers_OrderID")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.RegularPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SalesTaxPercentage).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ShippedQuantity).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.ReceiversOrder)
                    .WithMany(p => p.ReceiversItemsOrderItems)
                    .HasForeignKey(d => d.ReceiversOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Receivers.Items.OrderItems_Receivers.Items.Orders");
            });

            modelBuilder.Entity<ReceiversItemsOrderPayments>(entity =>
            {
                entity.HasKey(e => e.ReceiverOrderPayments);

                entity.ToTable("Receivers.Items.OrderPayments");

                entity.Property(e => e.ReceiverOrderPayments)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.PaymentId)
                    .HasColumnName("PaymentID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ReceiversOrderId)
                    .HasColumnName("Receivers_OrderID")
                    .HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.ReceiversItemsOrderPayments)
                    .HasForeignKey(d => d.PaymentId)
                    .HasConstraintName("FK_Receivers.Items.OrderPayments_Payments");
            });

            modelBuilder.Entity<ReceiversItemsOrders>(entity =>
            {
                entity.HasKey(e => e.ReceiversOrderId);

                entity.ToTable("Receivers.Items.Orders");

                entity.HasIndex(e => e.Date)
                    .HasName("NonClusteredIndex-20170319-143543");

                entity.HasIndex(e => e.ReceiverId)
                    .HasName("NonClusteredIndex-20170319-143647");

                entity.Property(e => e.ReceiversOrderId)
                    .HasColumnName("Receivers_OrderID")
                    .HasColumnType("decimal(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AddUserId).HasColumnName("AddUserID");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DiscountId).HasColumnName("DiscountID");

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.ModifyUserId).HasColumnName("ModifyUserID");

                entity.Property(e => e.Note).HasMaxLength(250);

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.PackNo).HasColumnName("Pack_no");

                entity.Property(e => e.Packing).HasMaxLength(250);

                entity.Property(e => e.ReceiverId)
                    .HasColumnName("ReceiverID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ShippingCharge).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Taxes).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Receiver)
                    .WithMany(p => p.ReceiversItemsOrders)
                    .HasForeignKey(d => d.ReceiverId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Receivers.Items.Orders_Receivers");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
