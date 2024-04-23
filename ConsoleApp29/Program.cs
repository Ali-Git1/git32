using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task-1
            //User russianUser = new User(new RussianLanguage());
            //User englishUser = new User(new EnglishLanguage());
            //User frenchUser = new User(new FrenchLanguage());

            //Console.Write("Rusca danisan:");
            //russianUser.Speak();

            //Console.Write("Ingilisce danisan:");
            //englishUser.Speak();

            //Console.Write("Fransizca danisan:");
            //frenchUser.Speak();


            //Console.ReadLine();
            #endregion


            Circle circle = new Circle(5);

            Duzbucaqli duzbucaqli = new Duzbucaqli(2,4);

            double dairesahe = circle.CalculateArea();
            Console.WriteLine(dairesahe);

            double daireperimetr=circle.CalculatePerimetr();
            Console.WriteLine(daireperimetr);

            double duzbucaqlisahe = duzbucaqli.CalculateArea();
            Console.WriteLine(dairesahe);

            double duzbucaqliperimetr = duzbucaqli.CalculatePerimetr();
            Console.WriteLine(daireperimetr);
        }
    }
}
