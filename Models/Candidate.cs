using System;
using StudentsVotingSystem.Models;
using System.Collections.Generic;
using System.Text;

namespace StudentsVotingSystem.Models
{
    public class Candidate : Person
    {
        public int VoterId { get; set; }
        public Voter Voter { get; set; }
        public int PositionId { get; set; }
        public Position Positions { get; set; }
        public List<Vote> Votes { get; set; } = new List<Vote>();



    }
}
