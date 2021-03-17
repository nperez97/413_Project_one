using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _413_Project_one.Models
{
    public class EFGroupRepository : IGroupRepository
    {
        private BookingDBContext _context;

        public EFGroupRepository(BookingDBContext context)
        {
            _context = context;
        }

        public IQueryable<Group> Groups => (_context.Groups);
    }
}