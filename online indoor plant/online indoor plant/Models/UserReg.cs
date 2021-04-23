using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace online_indoor_plant.Models
{
    public class UserReg
    {
        public class ApplicationUser : DbContext
        {
            public ApplicationUser(DbContextOptions<ApplicationUser> options) : base(options)
            {

            }
            public Microsoft.EntityFrameworkCore.DbSet<User> register_form_user { get; set; }
        }
    }


}

