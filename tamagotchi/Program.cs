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
            string userChoice = "";

            while (tIsAlive)
            {
                t.PrintStats();

                Console.WriteLine($@"
                What do you want to do?                      [FEED]    [GREET]    [TEACH]    [NOTHING]");
                userChoice = Console.ReadLine();

                if (userChoice.ToLower() == "feed")
                {
                    Console.Write($@"
                    
                    Your Tamagothi has been fed.

                    ");
                    t.Feed();
                }
                if (userChoice.ToLower() == "greet")
                {
                    t.Hi();
                }
                if (userChoice.ToLower() == "teach")
                {
                    Console.WriteLine($@"
                    

                    What word do you want to teach {t.name}?
                    



                    ");
                    t.Teach(Console.ReadLine());
                    Console.WriteLine($@"
                    
                    {t.name} just learned a new word!
                    Choose [GREET] to try it out.
                    
                    ");
                }
                if (userChoice.ToLower() == "nothing")
                {
                    Console.Write($@"

                    You chose to do nothing.
                    
                    ");
                }
                t.Tick();
                tIsAlive = t.GetAlive();
            }
        }

        static string Setup()
        {
            string name;
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
