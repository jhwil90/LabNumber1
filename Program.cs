using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserContinue
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ProgramContinue = true;

            while (ProgramContinue == true)
            {




                int x;
                int y;
                int result;
                Console.Write("\n Please enter the length of the room: ");
                x = Convert.ToInt32(Console.ReadLine());
                Console.Write("\n Please enter the length of the room: ");
                y = Convert.ToInt32(Console.ReadLine());
                result = x + y;
                Console.Write("\n The area of the room is: " + result);
                Console.ReadLine();



                string UserChoice;
                Console.WriteLine("Would you like to calculate another premiter? (No/Yes)");
                UserChoice = Console.ReadLine();
                if (UserChoice == "No" || UserChoice == "No")
                {
                    ProgramContinue = false;
                }
            }



        }
    }
}