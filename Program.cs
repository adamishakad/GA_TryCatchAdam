// // Adam


namespace GA_TryCatchAdam
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Please inter your age");
            string userInput = Console.ReadLine();

            try
            {
                int age = int.Parse(userInput);

                Console.WriteLine("Welcome you are " + age + " years old");
                Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Invalid input.Please input valid integer for age");
                Console.ReadLine();
            }

        }
    }
}
