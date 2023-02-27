using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EkaterinaChernikova.Models;

namespace EkaterinaChernikova.Data
{
    public class EkaterinaChernikovaContext : DbContext
    {
        public EkaterinaChernikovaContext(DbContextOptions<EkaterinaChernikovaContext> options)
            : base(options)
        {
        }

        public DbSet<EkaterinaChernikova.Models.Movie> Movie { get; set; }
    }
}
