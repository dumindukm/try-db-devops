using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using try_db_code_web.Models;

namespace try_db_code_web.Data
{
    public class WebshopContext : DbContext
    {
        public WebshopContext (DbContextOptions<WebshopContext> options)
            : base(options)
        {
        }

        public DbSet<try_db_code_web.Models.Products> Products { get; set; }
    }
}
