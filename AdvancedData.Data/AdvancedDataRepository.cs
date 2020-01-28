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

        public IEnumerable<Receivers> GetReceiversByPhone(string phone)
        {
            return _context.Receivers.Where(receiver =>
                receiver.HomePhone == phone
                || receiver.CellPhone == phone);
        }

        public void AddNewReceiver(string firstName, string lastName, string homePhone)
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
                AddUserID = 1,
                ModifyDate = date,
                ModifyUserID = 1
            };

            _context.Receivers.Add(receiver);
            _context.SaveChanges();
        }
    }
}
