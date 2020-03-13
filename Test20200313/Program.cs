using System;

namespace Test20200313
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int hp = 50;
            while (true)
            {
                //check is game over 
                if (hp <= 0)
                {
                    Console.WriteLine("GG");
                    break;
                }
                //input attack
                string input = Console.ReadLine();
                int attack = int.Parse(input);
                hp = hp - attack;

                //display
                Console.WriteLine("HP =" + hp);
            }
            Console.ReadKey();
        }
    }
}
