using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentsVotingSystem.Models
{
    public class ApplicationContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;user=root;database=StudentsVotingSystem;port=3306;password=Olaitan1991*");
        }
        public DbSet<Voter>  Voters {get; set;}
        public DbSet<Vote>  Votings {get; set;}
        public DbSet<Admin> Admins{get; set;}
        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<Position> Positions {get; set;}
        public DbSet<VoterVote> VoterVoting  {get; set;}
    }
}
