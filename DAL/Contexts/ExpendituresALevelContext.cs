using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DAL.Models;

namespace DAL.Contexts
{
    public class ExpendituresALevelContext : DbContext
    {
        public ExpendituresALevelContext() : base(@"Server=.;Initial Catalog = ExpendituresALevelDB; Integrated Security = true")
        { 
        }

        public DbSet<Category> Catogories { get; set; }
        public DbSet<MyTransactionType> MyTransactionTypes { get; set; }
        public DbSet<MyTransaction> MyTransactions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }


    }
}
