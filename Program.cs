// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework23_09
{
    struct Person
    {
        public int age;
        public int id;
        public string name;
        public string firstname;
        public string categhory;
        public int kol;
        public string town;
        public void Print()
        {
            Console.WriteLine($"Имя: {name} , Фамилия: {firstname} , Возраст: {age} , ID: {id} , Категория алколизма - {categhory} , Количество выпитого: {kol}");
        }
        public void Print1()
        {
            Console.WriteLine($"Имя: {name}, Город: {town}, Возраст: {age}, ID: {id}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            Person person = new Person();
            person.age = 18;
            person.id = 092221;
            person.name = "Мария";
            string a1 = person.name;
            person.firstname = "Мошкина";
            person.categhory = "с";
            person.kol = 1;
            double a = person.kol;
            person.Print();

            person.age = 18;
            person.id = 092222;
            person.name = "Юлия";
            string b1 = person.name;
            person.firstname = "Лешина";
            person.categhory = "d";
            person.kol = 0;
            double b = person.kol;
            person.Print();

            person.age = 18;
            person.id = 092223;
            person.name = "Виктория";
            string c1 = person.name;
            person.firstname = "Елисеева";
            person.categhory = "b";
            person.kol = 2;
            double c = person.kol;
            person.Print();

            person.age = 20;
            person.id = 092224;
            person.name = "Екатерина";
            string d1 = person.name;
            person.firstname = "Мирская";
            person.categhory = "a";
            person.kol = 4;
            double d = person.kol;
            person.Print();

            person.age = 20;
            person.id = 092225;
            person.name = "Карина";
            string e1 = person.name;
            person.firstname = "Козловская";
            person.categhory = "b";
            person.kol = 3;
            double e = person.kol;
            person.Print();

            double f = a + b + c + d + e;
            Console.WriteLine(f);
            double a3 = (a / f) * 100;
            Console.WriteLine(a3);
            double b3 = (b / f) * 100;
            double c3 = (c / f) * 100;
            double d3 = (d / f) * 100;
            double e3 = (e / f) * 100;
            Math.Round(a3);
            Math.Round(b3);
            Math.Round(c3);
            Math.Round(d3);
            Math.Round(e3);
            Console.WriteLine($"{a3}% выпила {a1}, {b3}% выпила {b1}, {c3}% выпила {c1}, {d3}% выпила {d1}, {e3}% выпила {e1}");

            Console.WriteLine("Задание 2");
            Console.WriteLine($"sbyte: {sbyte.MinValue} ... {sbyte.MaxValue}" + "\n" +
            $"byte: {byte.MinValue} ... {byte.MaxValue}" + "\n" +
            $"short: {short.MinValue} ... {short.MaxValue}" + "\n" +
            $"ushort: {ushort.MinValue} ... {ushort.MaxValue}" + "\n" +
            $"int: {int.MinValue} ... {int.MaxValue}" + "\n" +
            $"uint: {uint.MinValue} ... {uint.MaxValue}" + "\n" +
            $"long: {long.MinValue} ... {long.MaxValue}" + "\n" +
            $"ulong: {ulong.MinValue} ... {ulong.MaxValue}" + "\n" +
            $"char: U+000 ... U+ffff" + "\n" +
            $"float: {float.MinValue} ... {float.MaxValue}" + "\n" +
            $"double: {double.MinValue} ... {double.MaxValue}" + "\n" +
            "bool: true ... false" + "\n" +
            $"decimal: {decimal.MinValue} ... {decimal.MaxValue}" + "\n" +
            "string: Ограничено только системной памятью" + "\n" +
            "object: Почти всё" + "\n");

            Console.WriteLine("Задание 3");
            Person friend = new Person();
            Console.WriteLine("Введите имя:");
            friend.name = Console.ReadLine();
            Console.WriteLine("Введите город:");
            friend.town = Console.ReadLine();
            Console.WriteLine("Введите возраст:");
            friend.age = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите ПИН-КОД:");
            friend.id = int.Parse(Console.ReadLine());
            friend.Print1();
            Console.WriteLine("Задание 4");
            Console.WriteLine("Введите имя:");
            string name = Console.ReadLine();
            Console.WriteLine("Введите фамилию:");
            string surname = Console.ReadLine();
            Console.WriteLine($"{name[0].ToString().ToUpper()}.{surname[0].ToString().ToUpper()}.");

            Console.WriteLine("Задание 5");
            Console.WriteLine("Введите сумму вашего отпуска:");
            double holidayPrice = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите цену одной бутылки виски:");
            double normPrice = int.Parse(Console.ReadLine());
            Console.WriteLine("Какова скидка в процентах?");
            double salePrice = int.Parse(Console.ReadLine());
            double sale = ((100 - salePrice) / 100) * normPrice; ///цена за одну бутылку sale
            double sale_ = normPrice - sale;
            double kolvo_but = holidayPrice / sale_;
            Console.WriteLine($"Количество бутылок = {kolvo_but}");

            Console.WriteLine("Задание 6");
            Console.WriteLine("Введите скорость (км/ч): ");
            int v = int.Parse(Console.ReadLine());
            Console.WriteLine($"Скорость (см/с) = {(v * 100000 / 3600) - (v * 100000 / 3600) % 1}");

            Console.WriteLine("Задание 7");
            string stIn = Console.ReadLine();
            StringBuilder stroka = new StringBuilder();
            foreach (Char i in stIn.ToCharArray())
            {
                if (Char.IsLower(i))
                {
                    stroka.Append(Char.ToUpper(i));
                }
                else
                {
                    stroka.Append(Char.ToLower(i));
                }
            }
            Console.WriteLine(stroka);
            


        }
    }
}
