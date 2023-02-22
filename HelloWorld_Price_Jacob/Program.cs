using System;


namespace HelloWorld_Price_Jacob
{
    class Program
    {
        static void Main(string[] args)
        {
            //This Prints The question
            Console.WriteLine("Hey there user, whats your first name?");

            // this gets the input
            string firstname = Console.ReadLine();

            //repeated here
            Console.WriteLine("And your Last?");
            string lastName = Console.ReadLine();

            //prints out the greeting
            Console.WriteLine(firstname + " " + lastName + "? nice to meet you!");

            Console.WriteLine("Now lets do someting cool... we are going to play a game. I am thinking of a number between... lets say... -2147483648 and 2147483648 try to guess the number");
            string answer = Console.ReadLine();
            int guessedNum;
            Int32.TryParse(answer, out guessedNum);

            Console.WriteLine("Your answer is " + guessedNum);
            Console.WriteLine("the number i was tinking of is...");
            System.Random random = new Random();
            int correctGuess = random.Next();

            Console.WriteLine(correctGuess);

            Console.WriteLine("looks like you were about...");
            int distancefromcorrect = correctGuess - guessedNum;
            Console.WriteLine(Math.Abs(distancefromcorrect) + " off from te correct coice");

            Console.WriteLine("wow, now wasnt that a fun game?");

            //huston I went on a bit of a tangent there

        }
    }
}
