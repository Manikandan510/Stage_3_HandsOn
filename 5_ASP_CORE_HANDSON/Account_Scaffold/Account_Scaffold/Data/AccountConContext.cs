using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Account_Scaffold.Models;

namespace Account_Scaffold.Data
{
    public class AccountConContext : DbContext
    {
        public AccountConContext (DbContextOptions<AccountConContext> options)
            : base(options)
        {
        }

        public DbSet<Account_Scaffold.Models.Account> Account { get; set; }
    }
}
