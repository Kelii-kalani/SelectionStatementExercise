namespace SelectionStatementExercise
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var myNumber = 6;
            int userInput;
            do
            {
                Console.WriteLine("Can you Guess my favorite number from 0-10?");
                userInput = int.Parse(Console.ReadLine());

                if (userInput < myNumber)
                {
                    Console.WriteLine("too low");
                }
                else if (userInput > myNumber)
                {
                    Console.WriteLine("too high");
                }
                else
                {
                    Console.WriteLine("you guessed it!!!");
                }
            } while (userInput != myNumber);

            Console.WriteLine("What is your favorite school subject?");
            string subject = Console.ReadLine();


            switch (subject.ToLower())
            { 


                case "math":
                    Console.WriteLine("Neeeerd!!!");
                    break;

                case "history":
                    Console.WriteLine("Great to know, boring to learn.");
                    break;

                case "science":
                    Console.WriteLine("Lets make a volcano!!");
                    break;

                case "english":
                    Console.WriteLine("We all need to know it if we goin speak it");
                    break;

                case "art":
                    Console.WriteLine("Artsy Fartsy");
                    break;

                default:
                    Console.WriteLine("Not that subject try again");
                    break;


            }
        }
    }
}
