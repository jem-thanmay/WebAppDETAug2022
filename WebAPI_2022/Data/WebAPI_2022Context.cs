using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAPI_2022.Models;

namespace WebAPI_2022.Data
{
    public class WebAPI_2022Context : DbContext
    {
        public WebAPI_2022Context (DbContextOptions<WebAPI_2022Context> options)
            : base(options)
        {
        }

        public DbSet<WebAPI_2022.Models.Users> Users { get; set; } = default!;

        public DbSet<WebAPI_2022.Models.TodoItem>? TodoItem { get; set; }
    }
}
