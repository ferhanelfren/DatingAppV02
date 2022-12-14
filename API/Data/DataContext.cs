using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {
        //THIS IS CONSTRUCTOR
        public DataContext(DbContextOptions options) : base(options)
        {

        }

        //THIS IS CREATING A DB TABLE NAMED USERS WITH THE 
        //COLUMN UNDER THE APPUSER ENTITIES
        public DbSet<AppUser> Users {get; set;}
    }
}