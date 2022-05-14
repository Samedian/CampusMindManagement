using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CampusMindManagementDAL.Model
{
    public class CampusMindDbContext : DbContext
    {

        public DbSet<Access> Accesses { get; set; }

        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<Lead> Leads { get; set; }
        public DbSet<Technology> Technologies { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=CodingChallenge6;Integrated Security=true");
            
        }


    }
}
