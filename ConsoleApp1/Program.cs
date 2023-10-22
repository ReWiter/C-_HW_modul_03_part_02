using System.Linq.Expressions;
using System.Runtime.InteropServices;

namespace N1
{
    class Prog
{
[DllImport("msvcrt")]
static extern int _getch();
static void Two(int a)
{
string BinaryCode = Convert.ToString(a, 2);
Console.WriteLine(BinaryCode);
}
static void Eight(int a)
{
string BinaryCode = Convert.ToString(a, 8);
Console.WriteLine(BinaryCode);
}
static void Sixteen(int a)
{
Console.WriteLine(a.ToString("X2"));
}
static void Main(string[] args)
{
Console.WriteLine("Укажите число");
int b = Convert.ToInt32(Console.ReadLine());
int a = 15;
while (a != 0)
{
Console.WriteLine("Выберите в какую систему счисления хотите перевести");
Console.WriteLine("1-Двоичная");
Console.WriteLine("2-Восмиричная");
Console.WriteLine("3-Шестнадцатеричная");
Console.WriteLine("0-Exit");
a = Convert.ToInt32(Console.ReadLine());
if (a > int.MaxValue)
{
Console.WriteLine("ERROR");
return;
}
if (a == 1)
{
Two(b);
}
if (a == 2)
{
Eight(b);
}
if (a == 3)
{
Sixteen(b);
}
_getch();
Console.Clear();
}
}
}
}
namespace N2
{
    class PPG
    {
        static int number(string a)
        {
            if (a == "zero")
            {
                return 0;
            }
            if (a == "one")
            {
                return 1;
            }
            if (a == "two")
            {
                return 2;
            }
            if (a == "three")
            {
                return 3;
            }
            if (a == "four")
            {
                return 4;
            }
            if (a == "five")
            {
                return 5;
            }
            if (a == "six")
            {
                return 6;
            }
            if (a == "seven")
            {
                return 7;
            }
            if (a == "eight")
            {
                return 8;
            }
            if (a == "nine")
            {
                return 9;
            }
            else
            {
                return 000000000;
            }
        }
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            Console.WriteLine(number(a));
        }
    }
}
namespace N3
{
    class Passport
    {
        public int Series;
        public string Name;
        public int Number;
        public string Surname;
        public string Patronymic;
        public string Whom;
        public string Date;
        public int series
        {
            get { return Series; }
            set { Series = value; }
        }
        public string name
        {
            get { return Name; }
            set { Name = value; }
        }
        public int number
        {
            get { return Number; }
            set { Series = value; }
        }
        public string surname
        {
            get { return Surname; }
            set { Surname = value; }
        }
        public string patronymic
        {
            get { return Patronymic; }
            set { Patronymic = value; }
        }
        public string whom
        {
            get { return Whom; }
            set { Whom = value; }
        }
        public string date
        {
            get { return Date; }
            set { Date = value; }
        }
    }
    class Re
    {
        static void Main(string[] args)
        {
            Passport e = new Passport();
            try
            {
                e.Series = Convert.ToInt32(Console.ReadLine());
                if (e.Series < 1000)
                {
                    throw new Exception("Серия меньше 4 символов");
                }
            }
            catch (Exception a)
            {
                Console.WriteLine(a.Message);
            }
            try
            {
                e.Number = Convert.ToInt32(Console.ReadLine());
                if (e.Number < 100000)
                {
                    throw new Exception("Серия меньше 6 символов");
                }
            }
            catch (Exception a)
            {
                Console.WriteLine(a.Message);
            }
            e.Name = Console.ReadLine();
            e.Surname = Console.ReadLine();
            e.Patronymic = Console.ReadLine();
            e.Whom = Console.ReadLine();
            e.Date = Console.ReadLine();
            Console.WriteLine($"Серия-{e.Series}");
            Console.WriteLine($"Номер-{e.Number}");
            Console.WriteLine($"Имя-{e.Name}");
            Console.WriteLine($"Фамилия-{e.Surname}");
            Console.WriteLine($"Отчество-{e.Patronymic}");
            Console.WriteLine($"Кем выдан-{e.Whom}");
            Console.WriteLine($"Дата-{e.Date}");
        }
    }
}
namespace N4
{
    class Prog
    {
        static bool prr(string a)
        {
            string[] c = a.Split(new char[] { });
            int d = int.Parse(c[0]);
            int e = int.Parse(c[2]);
            if (c[1] == ">")
            {
                return d > e;
            }
            else if (c[1] == "<")
            {
                return d < e;
            }
            else if (c[1] == "<=")
            {
                return d <= e;
            }
            else if (c[1] == ">=")
            {
                return d >= e;
            }
            else if (c[1] == "==")
            {
                return d == e;
            }
            else if (c[1] == "!=")
            {
                return d != e;
            }
            else { return false; }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Укажите неравенство через пробел");
            string a = Console.ReadLine();
            Console.WriteLine($"{prr(a)}");
        }
    }
}