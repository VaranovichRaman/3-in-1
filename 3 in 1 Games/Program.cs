using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_in_1_Games
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Hello!Choose a game. Push: 1 for Sphinx Game, 2 for Integer Guesser:");
            string str = Console.ReadLine();
            
            if(str == "1")
            {
                RiddlesGame();
            }
            else if(str == "2")
            {

                IntegerGuesser();
                Console.ReadLine();

            }
            else if (str == "0")
            {
                Console.WriteLine($"Bye!");
                Console.ReadLine();
                return;
            }
            else
            {
                Console.WriteLine("Wrong Number!Bye!");
            }
        }
        static void IntegerGuesser()
        {
            Random rand = new Random();

            int number = rand.Next(1, 100);

            Console.WriteLine($"Greatings in \"Integer guesser\"! I'll guess a number from 1 to 100, and you should find this number. Let's get started, enter a number:\n");

            Choice(number);
        }
        static void Choice(int number)
        {
            bool flag = true;

            while (flag)
            {
                int result = AnswerCheck();

                if (result > number)
                {
                    Console.WriteLine($"\nThe guessed number is less, try again:\n");
                }
                else if (result < number)
                {
                    Console.WriteLine($"\nThe guessed number is bigger, try again:\n");
                }
                else if (number == result)
                {
                    Console.WriteLine($"\nGreat you won! See you next time.");

                    flag = false;

                }
            }
        }
        static int AnswerCheck()
        {
            int answer = 0;
            bool flag = true;

            while (flag)
            {
                bool answerCheck = Int32.TryParse(Console.ReadLine(), out answer);

                if (answer > 100 || answer < 1 || answerCheck == false)
                {
                    Console.WriteLine($"\nWrong number, enter a number from 1 to 100:\n");
                }
                else
                {
                    flag = false;
                }
            }

            return answer;
        }

        static void RiddlesGame()
        {
            string riddleMessage = "Who goes on morning on 4, on day on 2, on evening on 3";
            Riddle(riddleMessage, "human", 4);

            string harderRiddle = "2 ends 2 rings and a nail in the middle";
            Riddle(harderRiddle, "scissors", 2);

            Riddle("Pear hangs, wtf?", "bulb", 3);

            Console.WriteLine("all riddles solved");
            Console.ReadLine();
        }

        static void Riddle(string riddleText, string rightAnswer, int attemps)
        {
            Console.WriteLine("Here is the riddle:");
            string answer = "";
            string isRight = "You are right, right answer is";
            while (answer != rightAnswer)
            {

                if (attemps == 0)
                {
                    isRight = "No more attempts, right answer was";
                    break;
                }
                Console.WriteLine($"You have {attemps} attempts left");
                Console.WriteLine($"{riddleText}");
                answer = Console.ReadLine();
                attemps--;
            }
            Console.WriteLine($"{isRight} {rightAnswer}");

        }
    }
}
