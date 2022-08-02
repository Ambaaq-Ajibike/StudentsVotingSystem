using System;
using System.Linq;
using StudentsVotingSystem.Models;
using System.Collections.Generic;
using System.Text;

namespace StudentsVotingSystem.Repository
{
    public class AdminRepo
    {
        private readonly ApplicationContext _context;

        public AdminRepo(ApplicationContext context)
        {
            _context = context;
        }
        public void RegisterAdmin()
        {
            Console.Write("Enter your First name: ");
            var firstName = Console.ReadLine();
            Console.Write("Enter your Last name: ");
            var lastName = Console.ReadLine();
            Console.Write("Enter your Phone Number: ");
            var phoneNumber = Console.ReadLine();
            Console.Write("Enter your email: ");
            var email = Console.ReadLine();
            Console.Write("Enter your Password: ");
            var Password = Console.ReadLine();
            
            var admin = new Admin()
            {
                FirstName = firstName,
                LastName = lastName,
                PhoneNUmber = phoneNumber,
                EmailAddress = email,
                Password = Password
            };
            _context.Admins.Add(admin);
            _context.SaveChanges();
            Console.WriteLine("Registration Scuccessful!");
        }
        public void UpdateVotersDetails()
        {
            Console.Write("Enter password: ");
            var password = Console.ReadLine();
            var passwordVerification = _context.Admins.SingleOrDefault(adm => adm.Password == password);
            if (passwordVerification != null)
            {
                Console.Write("Enter your First name: ");
                var firstName = Console.ReadLine();
                Console.Write("Enter your Last name: ");
                var lastName = Console.ReadLine();
                Console.Write("Enter your Phone Number: ");
                var phoneNumber = Console.ReadLine();
                Console.Write("Enter your email: ");
                var email = Console.ReadLine();
                Console.Write("Enter your Password: ");
                var Password = Console.ReadLine();

                passwordVerification.FirstName = firstName;
                passwordVerification.LastName = lastName;
                passwordVerification.PhoneNUmber = phoneNumber;
                passwordVerification.EmailAddress = email;
                passwordVerification.Password = password;

                    _context.Admins.Update(passwordVerification);
                    _context.SaveChanges();
                    Console.WriteLine("Details Update Scuccessfull!");
            }
            else
            {
                Console.WriteLine("Password Verification Fail");
            }
        }
    }
}
