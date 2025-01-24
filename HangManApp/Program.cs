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

                Console.Write("\n\nWould you like to go again? (y/n): ");
                choice = Console.ReadLine().ToLower();
            } while (choice == "y");
        }
    }
}
