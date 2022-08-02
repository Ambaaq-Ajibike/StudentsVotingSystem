using System;
using System.Linq;
using System.Collections.Generic;
using StudentsVotingSystem.Models;
using System.Text;

namespace StudentsVotingSystem.Repository
{
    public class CandidateRepo
    {
        private readonly ApplicationContext _context;
        public PositionRepo CandidatePositionRepository;

        public CandidateRepo(ApplicationContext context)
        {
            _context = context;
        }
        public void RegisterCandidate()
        {
            var email = Console.ReadLine();
            CandidatePositionRepository.PrintAvailablePositions();
            Console.Write("Select a position to vy for, from the above list and enter the corresponding Id: ");
            var poition = int.Parse(Console.ReadLine());
            var candidate = new Candidate
            {
                VoterId = 
                EmailAddress = email,
                PositionId = poition 
            };
            _context.Candidates.Add(candidate);
            _context.SaveChanges();
            Console.WriteLine("Candiate Registration Sucessfull!");
        }
        public void UpdateCandidateDetails()
        {
            Console.Write("Enter your Candidate id: ");
            var candidateId= int.Parse(Console.ReadLine());
            var CandidateIdverification = _context.Candidates.Find(candidateId);
            if (CandidateIdverification != null)
            {
                Console.Write("Enter your First name: ");
                var firstName = Console.ReadLine();
                Console.Write("Enter your Last name: ");
                var lastName = Console.ReadLine();
                Console.Write("Enter your Phone Number: ");
                var phoneNumber = Console.ReadLine();
                Console.Write("Enter your email: ");
                var email = Console.ReadLine();
                Console.Write("Enter your Matric Number: ");
                CandidatePositionRepository.PrintAvailablePositions();
                Console.Write("Select a from the above list and enter the corresponding Id: ");
                var poition = int.Parse(Console.ReadLine());

                CandidateIdverification.FirstName = firstName;
                CandidateIdverification.LastName = lastName;
                CandidateIdverification.PhoneNUmber = phoneNumber;
                CandidateIdverification.EmailAddress = email;
                CandidateIdverification.PositionId = poition;

                _context.Candidates.Update(CandidateIdverification);
                _context.SaveChanges();
                Console.WriteLine("Candidate Details Update Scuccessfull!");
            }
            else
            {
                Console.WriteLine("Invalid Voter Id");
            }
            
        }
        public void PrintRegisteredCandidates()
        {
            Console.WriteLine("===========Registered Candidates=============");
            var AllCandidates = _context.Candidates.ToList();
            foreach (var person in AllCandidates)
            {
                Console.WriteLine($"{person.FirstName} {person.LastName} --- {person.PositionId}");
            }
        }

    }
}
