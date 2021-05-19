using System;

namespace MontyHall
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            double wins = 0;
            int MoneyDoor, Choice;
            int noOfTrials = 10000;
            double likelihood;
            
            Console.WriteLine("Number of Trials: " + noOfTrials);
            
            for(int i = 0;i < noOfTrials; i++)
            {
                MoneyDoor = rnd.Next(1, 4);
                Choice = rnd.Next(1, 4);

                if(MoneyDoor != Choice)
                {
                    wins++;
                }
            }

            likelihood = (wins / noOfTrials) * 100;

            Console.WriteLine("Likeihood of winning by switching: " + likelihood + "%");
            Console.WriteLine("Likeihood of winning by not switching: " + (100-likelihood) + "%");

            Console.ReadLine();
        }
    }
}
