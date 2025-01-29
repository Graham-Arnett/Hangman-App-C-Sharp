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
            bool isGuess = false;
            int wrongGuess = 0;//how many times you can get it wrong
            //int pickedIndex = random.Next(0, answers.Length);
            //string pickedAnswer = answers[pickedIndex];
            string pickedAnswer = answers[1];
            Console.WriteLine(pickedAnswer);
            do
            {
                while(gameEnd == false) 
                    { 
                    
                //pickedIndex = random.Next(0,answers.Length);
                //pickedAnswer = answers[pickedIndex];
                //Console.WriteLine(pickedAnswer); 
                Console.Write("\nGuess a letter: ");
                string guess = Console.ReadLine();
                if(guess.Length == 1) 
                        { 
                        
                for(int i = pickedAnswer.Length -1; i >= 0; i--)
                {
                           char letter = pickedAnswer[i];
                            Console.WriteLine(pickedAnswer);
                          
                            if (pickedAnswer.Contains(guess))
                            {


                                for (int j = pickedAnswer.Length - 1; j >= 0; j--)
                                {
                                    if (pickedAnswer[i] == guess[j])
                                    {
                                        Console.Write(guess);
                                    }
                                    
                                }
                            }
                            else if (!pickedAnswer.Contains(guess))
                            {
                                Console.WriteLine("That was a wrong guess.");
                                wrongGuess++;
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
