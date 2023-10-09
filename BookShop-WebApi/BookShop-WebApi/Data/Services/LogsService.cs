using BookShop_WebApi.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookShop_WebApi.Data.Services
{
    public class LogsService
    {
        private AppDbContext _context;
        public LogsService(AppDbContext context)
        {
            _context = context;
        }

        public List<Log> GetAllLogsFromDB() => _context.Logs.ToList();
    }
}
