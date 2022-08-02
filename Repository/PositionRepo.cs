using System;
using System.Linq;
using StudentsVotingSystem.Models;
using System.Collections.Generic;
using System.Text;

namespace StudentsVotingSystem.Repository
{
    public class PositionRepo
    {
        private readonly ApplicationContext _context;

        public PositionRepo(ApplicationContext context)
        {
            _context = context;
        }
        public void CreatePosition()
        {
            Console.WriteLine("==========Create Position===========");
            Console.Write("Enter Admin password: ");
            var password = Console.ReadLine();
            var passwordVerification = _context.Admins.SingleOrDefault(adm => adm.Password == password);
            if (passwordVerification != null)
            {
                Console.Write("Enter Positioon Name: ");
                var positionName = Console.ReadLine();
                var position = new Position
                {
                    Name = positionName,
                };
                _context.Positions.Add(position);
                _context.SaveChanges();
                Console.WriteLine("Position Creation Sucessfull!");
            }
            else
            {
                Console.WriteLine("Admin Password Verification Fail");
            }
        }
        public void PrintAvailablePositions()
        {
            Console.WriteLine("===========Available Positions=============");
            var AllPositions = _context.Positions.ToList();
            foreach (var post in AllPositions)
            {
                Console.WriteLine($"{post.Name} --- {post.Id}");
            }
        }
        public void UpdatePositionName()
        {
            Console.WriteLine("---------Update Position Name---------");
            Console.Write("Enter Admin password: ");
            var password = Console.ReadLine();
            var passwordVerification = _context.Admins.SingleOrDefault(adm => adm.Password == password);
            if (passwordVerification != null)
            {
                Console.WriteLine("Enter the Position Id");
                var positionId = int.Parse(Console.ReadLine());
                var position = _context.Positions.Find(positionId);
                if (position != null)
                {
                    Console.Write("Enter the new Position Name: ");
                    var positionName = Console.ReadLine();
                    position.Name = positionName;
                    _context.Positions.Update(position);
                    _context.SaveChanges();
                    Console.WriteLine("Position Name Updated Sucessfully!");
                }
                else
                {
                    Console.WriteLine("There is no position that correspond the provided Id");
                }
                    

                _context.Positions.Add(position);
                _context.SaveChanges();
                Console.WriteLine("Position Creation Sucessfull!");
            }
            else
            {
                Console.WriteLine("Admin Password Verification Fail");
            }
        }
        public void DeletePosition()
        {
            Console.WriteLine("-----------Delete Position--------------");
            Console.Write("Enter Admin password: ");
            var password = Console.ReadLine();
            var passwordVerification = _context.Admins.SingleOrDefault(adm => adm.Password == password);
            if (passwordVerification != null)
            {
                Console.WriteLine("Enter the Position Id");
                var positionId = int.Parse(Console.ReadLine());
                var position = _context.Positions.Find(positionId);
                if (position != null)
                {
                    _context.Positions.Remove(position);
                    _context.SaveChanges();
                    Console.WriteLine("Position Deleted Sucessfully!");
                }
                else
                {
                    Console.WriteLine("There is no position that correspond the provided Id");
                }
            }
            else
            {
                Console.WriteLine("Admin Password Verification Fail");
            }
        }
    }
}
