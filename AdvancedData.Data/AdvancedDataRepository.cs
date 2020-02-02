using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdvancedData.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

// ReSharper disable InconsistentNaming

namespace AdvancedData.Data
{
    public class AdvancedDataRepository
    {
        private readonly AdvancedDataContext _context;
        private readonly ILogger<AdvancedDataRepository> _logger;

        public AdvancedDataRepository(AdvancedDataContext context, ILogger<AdvancedDataRepository> logger)
        {
            _context = context;
            _logger = logger;
        }

        //public IEnumerable<Receivers> GetSomeReceivers()
        //{
        //    return _context.Receivers.Take(20);
        //}

        public IQueryable<Receivers> GetReceiversByPhone(string phone)
        {
             return _context.Receivers.Where(receiver =>
                receiver.HomePhone == phone
                || receiver.CellPhone == phone);
        }

        public async Task<Receivers> AddNewReceiverAsync(string firstName, string lastName, string homePhone)
        {
            var date = DateTime.Now;
            var receiver = new Receivers
            {
                FirstName = firstName,
                LastName = lastName,
                Address = "",
                City = "",
                State = "",
                Zip = "",
                HomePhone = homePhone,
                AddDate = date,
                AddUserId = 1,
                ModifyDate = date,
                ModifyUserId = 1
            };

            var nreceiver = _context.Receivers.Add(receiver);
            await _context.SaveChangesAsync();
            return nreceiver.Entity;
        }

        public async Task<bool> ReceiverHasOrdersAsync(decimal receiverId)
        {
            var mlrQMV = await this._context.MLReceiversQuantityMatzosView.FirstOrDefaultAsync(ml => ml.ReceiverId == receiverId);
            return (mlrQMV!=null && mlrQMV.Quantity > 0);
            
        }

        public async Task<MLItemView> GetMatzahTypeItemInfoAsync(decimal matzahTypeId)
        {
            return await this._context.MLItemView.FirstOrDefaultAsync(mlIv => mlIv.ItemId == matzahTypeId);
        }
    }
}
