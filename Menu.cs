using System;
using System.Collections.Generic;
using System.Text;

namespace StudentsVotingSystem
{
    public class Menu
    {
        public void MainMenu()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"+++++++++++++++++++++++++++++++++++++++++++++++");
                Console.WriteLine($"+++++ WELCOME TO THE STUDENT VOTING PORTAL+++++");
                Console.WriteLine($"++++++++++++++++++++++++++++++++++++++++++++++++");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Select one of the following options to proceed ");
                Console.WriteLine("\t2. Candidate Registration");
                Console.WriteLine("\t3. Voter Registration");
                Console.WriteLine("\t4. Admin Details Updates");
                Console.WriteLine("\t5. Candidate Details Updates");
                Console.WriteLine("\t6. Voter Details Updates");
                Console.WriteLine("\t7. Delete Admin");
                Console.WriteLine("\t8. Delete Candidate");
                Console.WriteLine("\t9. Delete Voter");
                Console.WriteLine("\t10. Vote");
                Console.WriteLine("\t11. RegistrationList");
                Console.WriteLine("\t12. Exit");

                var request = Convert.ToInt32(Console.ReadLine());

                if (request == 1)
                {
                    
                }
                else if (request == 2)
                {
                }
                else if (request == 3)
                {
                }
                else if (request == 4)
                {
                    return;
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            }
        }
    }
}
