using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class StoreContext :DbContext
    {
     public StoreContext(DbContextOptions options): base(options) {

     }

    // Product :  name of the table
     public DbSet<Product> Products { get; set; }
    }
}