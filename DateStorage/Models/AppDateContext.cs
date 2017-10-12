using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace DateStorage.Models
{
    public class AppDateContext:DbContext
    {
        public AppDateContext() : base("DbConnection"){}

        public DbSet<UserDate> UserDates { get; set; }
    }
    
}