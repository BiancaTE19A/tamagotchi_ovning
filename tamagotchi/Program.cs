using System;

namespace tamagotchi
{
    class Program
    {
        static void Main(string[] args)
        {

            Tamagotchi avatar = new Tamagotchi();

            avatar.name = Setup();
            DogArt();
            Choices(avatar);
            Console.WriteLine("Your Tamagitchi is dead");
            Console.ReadLine();
        }

        static void Choices(Tamagotchi t)
        {
            bool tIsAlive = t.GetAlive();
            t.PrintStats();

            string userChoice = "";

            while (tIsAlive)
            {
                Console.WriteLine($"What do you want to do?       Feed, Greet, Teach or Nothing");

                userChoice = Console.ReadLine();

                if (userChoice.ToLower() == "feed")
                {
                    t.Feed();
                }
                if (userChoice.ToLower() == "greet")
                {
                    t.Hi();
                }
                if (userChoice.ToLower() == "teach")
                {
                    t.Teach(Console.ReadLine());
                }
                if (userChoice.ToLower() == "nothing")
                {
                    Console.WriteLine("You chose to do nothing.");
                }
                tIsAlive = t.GetAlive();
                t.Tick();
            }

        }


        static string Setup()
        {
            string name = "";
            Console.Write(@"
            Your Tamagotchi has arrived!
            What would you like to name it?
            ");

            DogArt();

            name = Console.ReadLine();

            Console.Write(
            $@"
            {name}, how cute!






            ");

            return name;
        }
        static void DogArt()
        {
            Console.Write(@"                     




                                                    |\_/|                  
                                                    | @ @   Woof! 
                                                    |   <>              _  
                                                    |  _/\------____ ((| |))
                                                    |               `--' |   
                                                ____|_       ___|   |___.' 
                                               /_/_____/____/_______|
                                              
                                            
            ");
        }
    }
}
