using System;

namespace helloworld
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Clear();
            Random random = new Random();
            int randomNumber = random.Next(1, 101);
            bool won = false;
            while(!won){
                Console.WriteLine("Guess a number between 1 and 100.");
                string guess = Console.ReadLine();
                int num;
                if(Int32.TryParse(guess, out num)){

                if( num == randomNumber)
                {
                        Console.Clear();
                        Console.WriteLine("You've won!");
                        won = true;
                    }
                    else if( num < randomNumber)
                    {
                        Console.Clear();
                        Console.WriteLine("Not quite, guess higher.");
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Not quite, guess lower.");
                    }
                }
            }
            Console.WriteLine("Thanks for playing!");
        }
    }
}
