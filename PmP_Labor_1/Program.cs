namespace PmP_Labor_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WindowHeight = 20;
            Console.WindowWidth = 60;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(5, 5);
            Console.WriteLine("Hello World!");
            Console.ResetColor();
            Console.CursorVisible = true;

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Add meg a neved:");
            string name = Console.ReadLine();
            Console.WriteLine($"Szia {name}!");

            Console.WriteLine("Melyik évben születtél? ");
            int age = 2024 - int.Parse(Console.ReadLine());
            Console.WriteLine($"Ennyi éves vagy: {age}, {name}!");
            Console.WriteLine($"Ennyi éves leszel jövőre: {age + 1}, {name}!");

            Console.WriteLine("Kérem add meg a magasságodat(méterben): ");
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine("Kérem add meg a testsúlyodat(kilogrammban): ");
            double weight = double.Parse(Console.ReadLine());
            double BMI = weight / Math.Pow(height, 2);
            Console.WriteLine($"Ennyi a testtömegindexed: {BMI:0.0000}");

            Console.WriteLine("Add meg az idő másodpercben!");
            int timeInSec = int.Parse(Console.ReadLine());
            int minutes = timeInSec / 60;
            int remainingSeconds = timeInSec % 60;
            if (remainingSeconds < 10)
            {
                Console.WriteLine(minutes + ":0" + remainingSeconds);
            }
            else
            {
                Console.WriteLine(minutes + ":" + remainingSeconds);
            }


            Console.WriteLine("Írd be a jelszavad: ");
            string password = Console.ReadLine();
            Console.WriteLine("Írd be megint a jelszavad: ");
            string passwordConfirm = Console.ReadLine();
            if (passwordConfirm == password)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Helyes");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Helytelen");
            }
            Console.ResetColor();

            Console.WriteLine("Add meg az első számot: ");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Add meg a második számot: ");
            double secondNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Adj meg az műveleti jelet: ");
            string operation = Console.ReadLine();
            double result = 0;

            if (operation == "+")
            {
                result = firstNumber + secondNumber;
                Console.WriteLine($"{firstNumber} + {secondNumber} = {result}");
            }
            else if (operation == "-")
            {
                result = firstNumber - secondNumber;
                Console.WriteLine($"{firstNumber} - {secondNumber} = {result}");
            }
            else if (operation == "*")
            {
                result = firstNumber * secondNumber;
                Console.WriteLine($"{firstNumber} * {secondNumber} = {result}");
            }
            else if (operation == "/")
            {
                result = firstNumber / secondNumber;
                Console.WriteLine($"{firstNumber} / {secondNumber} = {result}");
            }
            else
            {
                Console.WriteLine("Helytelen művelet");
            }

            Console.WriteLine("Adj meg egy számot (0-9): ");
            int x = int.Parse(Console.ReadLine());
            if (x == 0)
            {
                Console.WriteLine("nulla");
            }
            else if (x == 1)
            {
                Console.WriteLine("egy");
            }
            else if (x == 2)
            {
                Console.WriteLine("kettő");
            }
            else if (x == 3)
            {
                Console.WriteLine("három");
            }
            else if (x == 4)
            {
                Console.WriteLine("négy");
            }
            else if (x == 5)
            {
                Console.WriteLine("öt");
            }
            else if (x == 6)
            {
                Console.WriteLine("hat");
            }
            else if (x == 7)
            {
                Console.WriteLine("hét");
            }
            else if (x == 8)
            {
                Console.WriteLine("nyolc");
            }
            else if (x == 9)
            {
                Console.WriteLine("kilenc");
            }
            else
            {
                Console.WriteLine("Hibás szám!");
            }

            Console.WriteLine("Adj meg egy betűt");
            char letter = char.Parse(Console.ReadLine());

            if (letter == 'a' || letter == 'e' || letter == 'u' || letter == 'o' || letter == 'i')
            {
                Console.WriteLine("Ez egy magánhangzó");
            }
            else
            {
                Console.WriteLine("Ez egy mássalhangzó");
            }

            Console.WriteLine("Add meg a V-t");
            double v = double.Parse(Console.ReadLine());
            Console.WriteLine("Add meg az R1-t");
            double r1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Add meg az R2-t");
            double r2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Add meg a T-t");
            double t = double.Parse(Console.ReadLine());

            double waterA = r1 * t + r2 * t;

            if (waterA <= v)
            {
                double waterP = waterA / v * 100;
                Console.WriteLine($"{waterP}%");
            }
            else 
            {
                double leftover = waterA - v;
                Console.WriteLine($"Ennyivel lett több a viz: {leftover} m3");
            }
            
        }
    }
}