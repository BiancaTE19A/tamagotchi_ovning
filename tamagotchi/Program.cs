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

            Console.ReadLine();
        }

        static void Choices(Tamagotchi t)
        {
            string userChoice = "";
            Console.WriteLine($"What do you want to do?       Feed, Teach, Greet, Nothing");
            userChoice = Console.ReadLine();

            if (userChoice.ToLower() == "feed")
            {
                t.Feed();
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
