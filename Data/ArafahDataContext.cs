using Arafah_Honey.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arafah_Honey.Data
{
    public class ArafahDataContext : DbContext
    {
        public ArafahDataContext(DbContextOptions<ArafahDataContext> options) : base(options) { }

        public DbSet<Neracas> tbl_mst_neraca { get; set; }
    }
}
