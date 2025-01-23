namespace ConcatenationTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string firstName;
        Console.Write("Enter first name: ");
        firstName = Console.ReadLine();
		string lastName;
		Console.WriteLine("enter your last name");
		lastName = Console.ReadLine();
		string age;
		Console.WriteLine("enter your age");
		age = Console.ReadLine();
		Console.WriteLine(firstName + lastName + age);
        }
    }
}
