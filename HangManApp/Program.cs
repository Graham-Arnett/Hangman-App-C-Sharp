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
            string[] answers = {"london", "paris","berlin","tokyo","beijing","seoul","brussels"};
            //char guess;
            //bool gameEnd = false;
            bool isGuess = false;
            //int lives = 5;
            //int pickedIndex = random.Next(0, answers.Length);
            //string pickedAnswer = answers[pickedIndex];
            string pickedAnswer = answers[3];
            Console.WriteLine(pickedAnswer);
            string fullGuess = "";//testing out to see if I can add the guesses together to make a full guess
            do
            {
                bool gameEnd = false;
                int lives = 5;
                while (gameEnd == false) 
                    { 
                    
                //pickedIndex = random.Next(0,answers.Length);
                //pickedAnswer = answers[pickedIndex];
                //Console.WriteLine(pickedAnswer); 
                Console.Write($"\nYou have {lives}/5 lives remaining.\nGuess a letter: ");
                string guess = Console.ReadLine();
                //char[] letter = guess.ToCharArray();
                if(guess.Length == 1) 
                        {
                        if (pickedAnswer.Contains(guess))
                        {
                            
                            for(int i = 0; i < pickedAnswer.Length; i++)
                            {

                                string thisLetter = Char.ToString(pickedAnswer[i]);

                                //if (pickedAnswer.Contains(guess))
                                //{


                                    //for (int j = pickedAnswer.Length - 1; j >= 0; j--)
                                    //{
                                    //    if (pickedAnswer[i] == guess[j])
                                    //    {
                                    //        Console.Write(guess);
                                    //    }

                                    //}
                                    //pickedAnswer[i].ToString();

                                    if (thisLetter == guess)
                                    {
                                    fullGuess += guess;
                                    Console.Write(fullGuess);
                                    }
                                else
                                {
                                    Console.Write('_');
                                }

                            
                                //}
                                //else
                                //{
                                //    Console.WriteLine("That was a wrong guess.");
                                //    lives--;
                                //}
                                //Console.Write('_');//to show how many characters and also the empty spaces
                            }
                        }
                        else
                        {
                            Console.WriteLine("That was a wrong guess.");
                            lives--;
                        }
                        if(lives == 0)
                        {
                            Console.WriteLine("You have lost.");
                            gameEnd = true;
                        }
                        else if(fullGuess == pickedAnswer)
                        {
                            Console.WriteLine("You have won!");
                            gameEnd = true;
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
