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
            do
            {
                int pickedIndex = random.Next(0,answers.Length);
                string pickedAnswer = answers[pickedIndex];
                //Console.WriteLine(pickedAnswer); was used to make sure the below logic worked
                for(int i = pickedAnswer.Length -1; i >= 0; i--)
                {
                    Console.Write('_');//to show how many characters and also the empty spaces
                }
                Console.Write("\n\nWould you like to go again? (y/n): ");
                choice = Console.ReadLine().ToLower();
            } while (choice == "y");
        }
    }
}
