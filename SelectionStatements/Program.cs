using System;
using System.Dynamic;
using System.Xml.Schema;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            // First excercise
            var r = new Random();
            var favNumber = r.Next(1, 1000);
            
            Console.WriteLine("Can you guess a number from 1 to 1000?");
            var userInput = int.Parse(Console.ReadLine());
            
    
            if (userInput < favNumber && userInput >= 1 && userInput <=1000)
            {
                Console.WriteLine("Too Low");
            }
            else if (userInput > favNumber && userInput >= 1 && userInput <= 1000)
            {
                Console.WriteLine("Too High");
            }
            else if (userInput == favNumber && userInput >= 1 && userInput <= 1000)
            {
                Console.WriteLine("Too High");
            }
            else
            {
                Console.WriteLine("Nevermind!");
            }



            // Second Excercise
            Console.WriteLine("\n======================================================\n");
            Console.WriteLine("What is your favourite subject?");
            string answer = Console.ReadLine().ToLower();

            switch(answer)
            {
                case "biology":
                    Console.WriteLine("Volunteering at the Aquarium or Park and Recreation program can provide you with a lot of hand-on experience.");
                    break;
                case "geography":
                    Console.WriteLine("Glad to hear that. It is useful to learn about the physical features of the earth and its atmosphere, and of human activity as it affects and is affected by these.");
                    break;
                case "physics":
                    Console.WriteLine("Have you learned the Theory of Relativity by Einstein yet?");
                    break;
                case "chemistry":
                    Console.WriteLine("I like to read biographies of famous scientists, such as Marie Curie, who was awarded a Nobel Prize in Chemistry.");
                    break;
                case "mathematics":
                case "maths":
                case "math":
                    Console.WriteLine("Maths is everywhere in our lives, we need maths in the simpliest tasks such as counting to sophisticated projects such as building houses and bridges.");
                    break;
                case "art":
                    Console.WriteLine("Art is essential to capture beauty, memories and to convey emotions.");
                    break;
                case "literature":
                    Console.WriteLine("Literature is a form of art expressed through words.");
                    break;
                case "history":
                    Console.WriteLine("It is important to learn from history, so we don't repeat the same mistakes.");
                    break;
                case "spanish":
                    Console.WriteLine("Spanish is used in many countries, such as Mexico and countries in South American.");
                    break;
                default:
                    Console.WriteLine("Oh, I would never have thought it would be your favourite school subject.");
                    break;

            }

        }
    }
}
