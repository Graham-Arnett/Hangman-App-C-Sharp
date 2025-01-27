namespace HangManApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, welcome to my Hangmanapp");
            Random random = new Random();
            string choice;
            //lets put the array for possible answers here for now
            string[] answers = {"London", "Paris","Berlin","Tokyo","Beijing","Seoul","Brussels"};
            //char guess;
            bool gameEnd = false;
            do
            {
                while(gameEnd == false) 
                    { 
                int pickedIndex = random.Next(0,answers.Length);
                string pickedAnswer = answers[pickedIndex];
                //Console.WriteLine(pickedAnswer); was used to make sure the below logic worked
                Console.Write("\nGuess a letter: ");
                string guess = Console.ReadLine();
                if(guess.Length == 1) 
                        { 
                for(int i = pickedAnswer.Length -1; i >= 0; i--)
                {
                           
                            //if (pickedAnswer.Contains(guess))
                            if(pickedAnswer.Substring(i).Contains(guess))
                            {
                                Console.Write(guess);
                            }
                    Console.Write('_');//to show how many characters and also the empty spaces
                }
                        }
                    else
                    {
                        Console.WriteLine("Invalid input, enter a single letter");
                    }

                    }
                Console.Write("\n\nWould you like to go again? (y/n): ");
                choice = Console.ReadLine().ToLower();
            } while (choice == "y");
        }
    }
}
