using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            string userResult = "0";

            VPDog myDog = new VPDog();  

            Console.WriteLine("Enter dog name"); // User name's dog and breed.  Only appears at beginning
            myDog.name = Console.ReadLine();

            Console.WriteLine("Enter dog breed");
            myDog.breed = Console.ReadLine();

            Console.WriteLine("Your dog's name is {0} and its breed is a {1}.", myDog.name, myDog.breed);
            Console.WriteLine("Let's check {0}'s stats.", myDog.name);


            Console.WriteLine("{0} likes his hunger, thirst, and boredom numbers to be below 5.", myDog.name);

            while (userResult != "4") //Main console display for user to enter options
            {
                myDog.ShowStats();

                ActionMenu();

               Console.WriteLine("enter an option");

                userResult = Console.ReadLine();
                if (userResult == "1")
                {
                    myDog.FeedPet();

                }
                else if (userResult == "2")
                {
                    myDog.WaterPet();
                }
                else if (userResult == "3")
                {
                    myDog.PlayPet();
                }
                else
                {
                    break;
                }

            }
        }
        public static void ActionMenu() //User choices for changing the dog's status levels
        {
            Console.WriteLine("\nChoose one of the following to make the dog happy:");
            Console.WriteLine("1) Feed the dog");
            Console.WriteLine("2) Fill the water bowl");
            Console.WriteLine("3) Take the dog out to play");
            Console.WriteLine("4) Quit");
           
        
        }
        

    }

}
