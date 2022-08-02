using StudentsVotingSystem.Models;
using StudentsVotingSystem.Repository;
using System;

namespace StudentsVotingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            ApplicationContext _context = new();
            VoteRepo votingRepository = new VoteRepo(_context);
            votingRepository.ViewVoting();
            Console.ReadKey();
        }
    }
}
