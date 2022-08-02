using System;
using System.Linq;
using StudentsVotingSystem.Models;
using System.Collections.Generic;
using System.Text;

namespace StudentsVotingSystem.Repository
{
    public class VoterRepo
    {
        ApplicationContext _context;

        public VoterRepo(ApplicationContext context)
        {
            _context = context;
        }
        public void RegisterVoter()
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
            var matricNumber = Console.ReadLine();
            Console.Write("Enter your Course And Dept: ");
            var courseAndDept = Console.ReadLine();
            Console.WriteLine("Choose your Level: ");
            Console.WriteLine("1.Level100 \n2. Level200, \n3.Level300, \n4.Level400");
            var level = (Level)int.Parse(Console.ReadLine());
            Random random = new Random();
            var Voter = new Voter()
            {
                FirstName = firstName,
                LastName = lastName,
                PhoneNUmber = phoneNumber,
                EmailAddress = email,
                MatricNumber = matricNumber,
                CourseAndDept = courseAndDept,
                Level = level,
                VoterRegId= $"STEL{random.Next(45, 99).ToString("000")}",
            };
            _context.Voters.Add(Voter);
            _context.SaveChanges();
            Console.WriteLine("Registration Scuccessful!");
        }
        public void UpdateVotersDetails()
        {
            Console.Write("Enter Id: ");
            var Id = Console.ReadLine();

            Console.Write("Enter  password: ");
            var password = Console.ReadLine();
            var passwordVerification = _context.Voters.SingleOrDefault(vot => vot.Password == password && vot.VoterRegId == Id);
            if (passwordVerification != null)
            {
                Console.Write("Enter the Voters id: ");
                var voterId = int.Parse(Console.ReadLine());
                var voterIdverification = _context.Voters.Find(voterId);
                if (voterIdverification != null)
                {
                    Console.Write("Enter the voter First name: ");
                    var firstName = Console.ReadLine();
                    Console.Write("Enter  the voter Last name: ");
                    var lastName = Console.ReadLine();
                    Console.Write("Enter  the voter Phone Number: ");
                    var phoneNumber = Console.ReadLine();
                    Console.Write("Enter  the voter email: ");
                    var email = Console.ReadLine();
                    Console.Write("Enter  the voter Matric Number: ");
                    var matricNumber = Console.ReadLine();
                    Console.Write("Enter  the voter Course And Dept: ");
                    var courseAndDept = Console.ReadLine();
                    Console.WriteLine("Choose  the voter Level: ");
                    Console.WriteLine("1.Level100 \n2. Level200, \n3.Level300, \n4.Level400");
                    var level = (Level)int.Parse(Console.ReadLine());

                    voterIdverification.FirstName = firstName;
                    voterIdverification.LastName = lastName;
                    voterIdverification.PhoneNUmber = phoneNumber;
                    voterIdverification.EmailAddress = email;
                    voterIdverification.MatricNumber = matricNumber;
                    voterIdverification.CourseAndDept = courseAndDept;
                    voterIdverification.Level = level;

                    _context.Voters.Update(voterIdverification);
                    _context.SaveChanges();
                    Console.WriteLine("Voters Details Update Scuccessfull!");
                    Console.WriteLine(voterIdverification.ToString());
                }
                else
                {
                    Console.WriteLine("Invalid Voter Id");
                }
            }
            else
            {
                Console.WriteLine("Admin Password Verification Fail");
            }
        }
        public void PrintRegisteredVoters()
        {
            Console.WriteLine("===========Registered Voters=============");
            var AllVoters = _context.Voters.ToList();
            foreach (var person in AllVoters)
            {
                Console.WriteLine($"{person.FirstName} {person.LastName} {person.MatricNumber} --- {person.Id}");
            }
        }
    }
}
