
using System.ComponentModel;

namespace BowlingExample2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int bowlingPins = 10;
            int score = 0;
            int bonus;
            int runda = 1;
            Random rand = new Random();

            Frame[] frames = new Frame[10];

            rand.Next(bowlingPins);

            for(int i = 0; i < frames.Length; i++)
            {
                
                int move1 = rand.Next(bowlingPins+1);
                int remainingPins = bowlingPins - move1;
                int move2 = rand.Next(remainingPins+1);
                remainingPins = remainingPins - move2;

                if (remainingPins > 0)
                {
                    frames[i] = new Frame(move1, move2);
                } 
                else if (move1 == 10)
                {
                    frames[i] = new Frame(move1, move2, false, true);
                } 
                else if ((move1 + move2) == 10)
                {
                    frames[i] = new Frame(move1, move2, true, false);
                }
                
            }

            for (int i = 0;i < frames.Length-1;i++)
            {
                Console.WriteLine("Runda: " + runda);

                if (frames[i].isStrike())
                {
                    Console.WriteLine("Prvo bacanje: " + frames[i].getFirstThrow());
                    if (frames[i + 1].isStrike())
                    {
                        score = score + frames[i].getFirstThrow() + frames[i + 1].getFirstThrow() + frames[i+2].getFirstThrow();
                    }
                    else
                    {
                        score = score + frames[i].getFirstThrow() + frames[i + 1].getFirstThrow() + frames[i+1].getSecondThrow();
                    }
                }
                else if (frames[i].isSpare())
                {
                    score = score + frames[i].getFirstThrow() + frames[i].getSecondThrow() + frames[i+1].getFirstThrow();
                    Console.WriteLine("Prvo bacanje: " + frames[i].getFirstThrow());
                    Console.WriteLine("Drugo bacanje: " + frames[i].getSecondThrow());
                } 
                else
                {
                    score = score + frames[i].getFirstThrow() + frames[i].getSecondThrow();
                    Console.WriteLine("Prvo bacanje: " + frames[i].getFirstThrow());
                    Console.WriteLine("Drugo bacanje: " + frames[i].getSecondThrow());
                }

                Console.WriteLine("Rezultat: " + score);
                runda++;
            }

            Console.WriteLine("Runda: " + runda);

            if (frames[9].isSpare())
            {
                bonus = rand.Next(bowlingPins);
                score = score + frames[9].getFirstThrow() + bonus + frames[9].getSecondThrow();
                Console.WriteLine("Prvo bacanje: " + frames[9].getFirstThrow());
                Console.WriteLine("Drugo bacanje: " + frames[9].getSecondThrow());
                Console.WriteLine("Bonus: " + bonus);
                
            }
            else if (frames[9].isStrike())
            {
                bonus = rand.Next(bowlingPins);
                score = score + frames[9].getFirstThrow() + bonus + frames[9].getSecondThrow();
                Console.WriteLine("Prvo bacanje: " + frames[10].getFirstThrow());
                Console.WriteLine("Bonus: " + bonus);
            }
            else
            {
                score = score + frames[9].getFirstThrow() + frames[9].getSecondThrow();
                Console.WriteLine("Prvo bacanje: " + frames[9].getFirstThrow());
                Console.WriteLine("Drugo bacanje: " + frames[9].getSecondThrow());
            }

            Console.WriteLine("Rezultat: " + score);

        }
    }
}