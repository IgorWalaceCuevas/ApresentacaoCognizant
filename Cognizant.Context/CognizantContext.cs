using Cognizant.Context.Interface;
using Cognizant.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cognizant.Context
{
    public class CognizantContext : DbContext, ICognizantContext
    {
        public CognizantContext() : base(nameOrConnectionString: "Cognizant"){}
        public DbSet<Client> Client { get; set; }
        public DbSet<BankAccount> BankAccount { get; set; }
        public DbSet<HistoricalTransaction> HistoricalTransaction { get; set; }
    }
}
