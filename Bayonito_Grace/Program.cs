namespace Bayonito_Grace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();


            Console.Write("Enter total of your Enrolled courses: ");
            int course;
            course = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the price of your favorite book:");
            double price;
            price = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Hi! Your name is: " + name);
            Console.WriteLine("your couse is: " + course);
            Console.WriteLine("price of your my book is: " + price);
        }
    }
}
       