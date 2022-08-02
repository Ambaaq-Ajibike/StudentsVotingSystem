using System;
using System.Collections.Generic;
using System.Text;

namespace StudentsVotingSystem.Models
{
    public class Voter : Person
    {
        public string MatricNumber { get; set; }
        public string CourseAndDept { get; set; }
        public Level Level { get; set; }
        public string VoterRegId { get; set; } 
        public Candidate Candidates { get; set; }
        public List<VoterVote> VoterVotes { get; set; } = new List<VoterVote>();
    }
}
