using System;
using System.Collections.Generic;


namespace tamagotchi
{
    public class Tamagotchi
    {
        private int hunger;
        private int boredom;
        private List<string> words = new List<string>() { "Woof!" };
        private bool isAlive = true;
        private Random generator = new Random();
        public string name;


        public void Feed()
        {
            hunger = hunger - 2;

            if (hunger <= 0)
            {
                hunger = -1;
            }
        }

        public void Hi()
        {
            int index = generator.Next(words.Count);
            Console.Write($@"



                               {name}:       {words[index]}
                            



");

            ReduceBoredom();
        }

        public void Teach(string word)
        {
            words.Add(word);

            ReduceBoredom();
        }

        public void Tick()
        {
            hunger++;
            boredom++;
            if (hunger >= 10 || boredom >= 10)
            {
                isAlive = false;
            }
        }

        public void PrintStats()
        {
            GetAlive();
            if (isAlive == true)
            {
                Console.WriteLine($@"
                Your Tamagotchi is alive.   Hunger: {hunger}     Boredom: {boredom}");
            }
            else
            {
                Console.WriteLine("Your Tamagotchi is dead.");
            }
        }

        public bool GetAlive()
        {
            return isAlive;
        }

        private void ReduceBoredom()
        {
            boredom = boredom - 2;
        }
    }
}