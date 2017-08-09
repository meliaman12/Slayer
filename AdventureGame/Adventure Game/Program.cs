using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my adventure game");
            Console.WriteLine("Press 1 to be a Mage" +
                              " or Press 2 to be a Warrior");

            string player = "";
          
            
            bool incorrect = true;

            while (incorrect)
            {
                 string Job = Console.ReadLine();
                 
                if (Job == "1" || Job == "2")
                {
                    if (Job == "1")
                    {
                        Console.WriteLine("You have selected Mage");                                                
                        incorrect = false;
                        player = "Mage";
                    }

                    if (Job == "2")
                    {
                        Console.WriteLine("You have selected Warrior");                      
                        incorrect = false;
                        player = "Warrior";
                    }                   
                }
                else
                {
                    Console.WriteLine("Invalid Option");
                }
            }
            
            Console.WriteLine("What is your name");
            string name = Console.ReadLine();

            Console.WriteLine("You wake up and get out of bed" + 
                             "\nThere is a loud bang on your door" +
                             "\nA man shouts \"Help there is a dragon attacking the village!\"" +
                             "\nYou run to your weapon room");

            if(player == "Mage")
            {
                Console.WriteLine("You quickly grab your staff.");
            }

            if (player == "Warrior")
            {
                Console.WriteLine("You quickly grab your sword.");          
            }

            Console.WriteLine("You run outside of your cabin and see a dragon in the middle of the village." +
                               "\nYou have never seen a dragon before, it is ferocious and is spewing fire everywhere burning down the village." +
                               "\nYou need to stop it!");

          Console.WriteLine("You confront the dragon" +
                            "\nPress ENTER to begin fight");

            Console.ReadLine();
            

            Console.WriteLine("Press 1 for light attack " +
                              "Press 2 for heavy attack");


            incorrect = true;

            while (incorrect)
            {
                string input = Console.ReadLine();

                if (input == "1") //Light Attack
                {                 
                    if (player == "Mage")
                    {
                        Console.WriteLine("You shoot a thunderbolt at the dragon");
                        incorrect = false;
                    }

                    if (player == "Warrior")
                    {
                        Console.WriteLine("You swing your sword at the dragon");
                        incorrect = false;
                    }
                }
                else
                {
                    Console.WriteLine("Inavlid Option");           
                }
            }

            
            
            
            Console.WriteLine("Dragon health:" +
                              "\nPlayer health")

        



          

           

           
;
       

            Console.ReadLine();





        }

    }

  
}
