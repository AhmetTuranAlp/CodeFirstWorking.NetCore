using CoreWorking.Entity.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreWorking.Entity
{
    public class CoreWorkingContext : DbContext
    {
        
        public CoreWorkingContext(DbContextOptions<CoreWorkingContext> options):base(options)
        {

        }

        public DbSet<User> User { get; set; }
    }
}
