

namespace Uge_15___Disaheim
{
    public enum Level
    {
        low,
        medium,
        high
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Amulet myAmulet = new Amulet("13", Level.low, "Capricorn");
            Console.WriteLine(myAmulet.ToString());

            Book myBook = new Book("12", "hej", 12);
            Console.WriteLine(myBook.ToString());

            
            Console.ReadLine();
        }
    }
}
