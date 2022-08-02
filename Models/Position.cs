using System;
using System.Collections.Generic;
using System.Text;

namespace StudentsVotingSystem.Models
{
    public class Position
    {
      public int Id { get; set; }
      public string Name { get; set; }
     public List<Candidate> Candidates { get; set; }
    }
}
