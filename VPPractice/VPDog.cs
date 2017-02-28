using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPPractice
{
    class VPDog
    {
        private string name; //Variables
        private string breed;
        private int dogLevelHunver;
        private int dogLevelThirst;
        private int dogLevelBoredom;

        public string Name { get; set; } //Properties to set variables for VPDog class
        public string Breed { get; set; }

        public int DogLevelHunger { get; set; }  //Properties to set levels for dog status
        public int DogLevelThirst { get; set; }
        public int DogLevelBoredom { get; set; }
        
        public VPDog() // Constructor for dog status levels
        {
            DogLevelHunger = 5;
            DogLevelThirst = 5;
            DogLevelBoredom = 5;
       
        }

        public void FeedPet() //Methods for changing dog status levels when user enters a number
        {
            DogLevelHunger--;
            DogLevelThirst++;

            if (DogLevelHunger <= 2)
            {
                Bathroom();
            }
        }

        public void WaterPet() 
        {
            DogLevelThirst--;
            if (DogLevelThirst > 9)
            {
                Console.WriteLine("Fill the dog's water bowl!");
            }
        }
        public void PlayPet() 
        {
            DogLevelBoredom--; 
            DogLevelThirst++;
        }
        public void Bathroom()
        {
            DogLevelHunger++; 
            Console.WriteLine("\nIf the dog's Hunger level goes below 2 it uses the bathroom \n and makes his hunger increase.");//explains hunger status change
        }


        public void ShowStats() //Method to show dog status levels
        {
            Console.WriteLine("\nHunger: " + DogLevelHunger);
            Console.WriteLine("Thirst: " + DogLevelThirst);
            Console.WriteLine("Boredom: " + DogLevelBoredom);
        }
    }
    }
     


