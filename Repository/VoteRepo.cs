using System;
using System.Linq;
using StudentsVotingSystem.Models;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace StudentsVotingSystem.Repository
{
    public class VoteRepo
    {
        private readonly ApplicationContext _context;

        public VoteRepo(ApplicationContext context)
        {
            _context = context;
        }
        public void Voting()
        {
            Console.Write("Enter your voter Registration Id: ");
            var voterRegId = int.Parse(Console.ReadLine());
            var verifyvoterById = _context.Voters.Find(voterRegId);

            if (verifyvoterById != null)
            {
                Console.Write("Enter your Candidate Id: ");
                var CandidateId = int.Parse(Console.ReadLine());
                var VerifyCandidateById = _context.Candidates.Find(CandidateId);
                if (VerifyCandidateById != null)
                {
                    Console.Write("Enter the Position Id: ");
                    var PositionId = Console.ReadLine();
                    var verifyPositionById = _context.Positions.Find(voterRegId);
                    if (verifyPositionById != null)
                    {
                        var Vote = new Vote()
                        {
                            Voters = verifyvoterById,
                            Candidates = VerifyCandidateById,
                            Positions = verifyPositionById
                        };
                        _context.Votings.Add(Vote);
                        _context.SaveChanges();
                        Console.WriteLine("Voting Scuccessful!");
                    }
                    else
                    {
                        Console.WriteLine("Invalid Position Id");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Candidate Id");
                }
            }
            else
            {
                Console.WriteLine("Invalid Registration Id");
            }
        }
        public void ViewVoting()
        {
            var query = _context.Votings.Include(a => a.Candidates).ThenInclude(b => b.Positions).Include(vo => vo.Voters).ToList();
            foreach (var item in query)
            {
                Console.WriteLine($"Position: {item.Positions.Name} Candididate FullName: {item.Candidates.FirstName} {item.Candidates.LastName} Voter Full Name {item.Voters.FirstName + " " + item.Voters.LastName }");
            }
        }
        public void GetVoterr() 
        {
            var ca = from i in _context.Votings orderby i.Candidates select i;
             

        } 
    }
}
