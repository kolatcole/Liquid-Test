using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Model;

namespace WebApplication3
{
    public class Service : IService
    {

        private readonly WRI6283Context _context;

        public Service(WRI6283Context context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Nltran>> getAll()
        {
            return await _context.Nltrans.ToListAsync();
        }
    }
}
