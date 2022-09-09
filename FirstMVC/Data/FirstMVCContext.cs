using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FirstMVC.Models;

namespace FirstMVC.Data
{
    public class FirstMVCContext : DbContext
    {
        public FirstMVCContext (DbContextOptions<FirstMVCContext> options)
            : base(options)
        {
        }

        public DbSet<FirstMVC.Models.BookingModel> BookingModel { get; set; } = default!;

      
    }
}
