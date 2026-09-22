namespace User_input_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PartOne();
            //PartTwo();
            //PartThree();
            PartFour();


        }
        public static void PartOne()
        {
            String name;
            String age;
            String income;
            String FirstName;
            String LastName;
            String LoginName;
            String Grade;
            String StudentIDNumber;
            String Average;
            Console.WriteLine("Hello, What is your name?");
            name = Console.ReadLine();
            Console.WriteLine("Hi, " + name + "! How old are you?");
            age = Console.ReadLine();
            Console.WriteLine("So you're " + age + " years old, eh? That's not old at all! How much do you make?");
            income = Console.ReadLine();
            Console.WriteLine("$" + income + "! I hope that's per hour and not per year!");
        }
        public static void PartTwo()
        {
            String FirstName;
            String LastName;
            String LoginName;
            String Grade;
            String StudentIDNumber;
            String Average;
            Console.WriteLine("Please enter the following data so i can sell it for a profit");
            Console.WriteLine("first name: ");
            FirstName = Console.ReadLine();
            Console.WriteLine("last name: ");
            LastName = Console.ReadLine();
            Console.WriteLine("login name: ");
            LoginName = Console.ReadLine();
            Console.WriteLine("grade: ");
            Grade = Console.ReadLine();
            Console.WriteLine("student ID number: ");
            StudentIDNumber = Console.ReadLine();
            Console.WriteLine("average: ");
            Average = Console.ReadLine();
            Console.WriteLine("Your information");
            Console.WriteLine("Login:\t\t" + LoginName);
            Console.WriteLine("ID:\t\t" + StudentIDNumber);
            Console.WriteLine("Name:\t\t" + LastName + ", " + FirstName);
            Console.WriteLine("Average:\t" + Average + "%");
            Console.WriteLine("Grade:\t\t" + Grade);
        }
        public static void PartThree()
        {
            String Name;
            String Age;
            Console.WriteLine("Hello, what is your name?");
            Name = Console.ReadLine();
            Console.WriteLine("Hi, " + Name + "! How old are you?");
            Age = Console.ReadLine();
            Console.WriteLine("Did you know that in five years you will be " + (int.Parse(Age) + 5) + " years old? And five years ago you were " + (int.Parse(Age) - 5) + "! Imagine that!");
        }
        public static void PartFour() 
        {
            String num1;
            String num2;
            String num3;

        }
}
