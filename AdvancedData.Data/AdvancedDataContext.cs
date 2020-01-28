using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdvancedData.Data.Entities;
using Microsoft.EntityFrameworkCore;
// ReSharper disable InconsistentNaming

namespace AdvancedData.Data
{
    public class AdvancedDataContext : DbContext
    {
        public virtual DbSet<DonorsTendersCreditCards> DonorsTendersCreditCards { get; set; }

        public virtual DbSet<Payments> Payments { get; set; }

        public virtual DbSet<PaymentsCharges> PaymentsCharges { get; set; }

        public virtual DbSet<Receivers> Receivers { get; set; }

        public virtual DbSet<ReceiversItemsOrderItems> ReceiversItemsOrderItems { get; set; }

        public virtual DbSet<ReceiversItemsOrderPayments> ReceiversItemsOrderPayments { get; set; }

        public virtual DbSet<ReceiversItemsOrders> ReceiversItemsOrders { get; set; }

        public virtual DbSet<MLItemsOutStockView> MLItemsOutStockViews { get; set; }

        public virtual DbSet<MLItemView> MLItemViews { get; set; }

        public virtual DbSet<MLReceiversItemsOrderItemsView> MLReceiversItemsOrderItemsViews { get; set; }

        public virtual DbSet<MLReceiversItemsOrderItemsViewNotCom> MLReceiversItemsOrderItemsViewNotComs { get; set; }

        public virtual DbSet<MLReceiversQuantityMatzosView> MLReceiversQuantityMatzosViews { get; set; }


    }
}
