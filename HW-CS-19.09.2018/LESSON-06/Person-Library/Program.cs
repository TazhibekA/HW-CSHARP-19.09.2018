using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FIrstLibrary;
namespace Person_Library
{
    class Program
    {
        static void Main(string[] args)
        {
      
        }

        static void FirstTask() {
            FIrstLibrary.Person person = new FIrstLibrary.Person("Aknur", "Tazhibek", 18);

            FIrstLibrary.Class1 firstClass = new Class1();
            string str = firstClass.StaticMethod(person);
            Console.WriteLine(str);
        }

        static void SecondTask() {
            Book harryPotter = new Book();
            Console.WriteLine($"Название: {harryPotter.GetName}");
            Console.WriteLine($"Кол-во страниц: {harryPotter.GetcountOfPages}");
            Console.WriteLine($"Имя автора: {harryPotter.GetauthorName}");
        }
    }
}
