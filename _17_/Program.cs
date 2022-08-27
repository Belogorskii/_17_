/*Создать класс для моделирования счета в банке. Предусмотреть закрытые поля для номера счета, 
  баланса, ФИО владельца. Класс должен быть объявлен как обобщенный. Универсальный параметр T 
  должен определять тип номера счета. Разработать методы  для  доступа  к  данным  –  заполнения  
  и чтения. Создать  несколько экземпляров класса, параметризированного различными типам. Заполнить 
  его поля и вывести информацию об экземпляре класса на печать.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Введите числовой номер");
            //int numInt = Convert.ToInt32(Console.ReadLine());        
            //Console.WriteLine("Введите имя");
            //string name = Console.ReadLine();
            //Console.WriteLine("Введите зп");
            //int summa = Convert.ToInt32(Console.ReadLine());
            //Employee<int> employee1 = new Employee<int>(numInt, name, summa);
            //Console.WriteLine(employee1.GoInfo());

            //Console.WriteLine("Введите числовой номер");
            //string numString = Console.ReadLine();
            //Console.WriteLine("Введите имя");
            //name = Console.ReadLine();
            //Console.WriteLine("Введите зп");
            //summa = Convert.ToInt32(Console.ReadLine());
            //Employee<string> employee2 = new Employee<string>(numString, name, summa);
            //Console.WriteLine(employee2.GoInfo());

            Employee<string> employee1 = new Employee<string>();
            employee1.Input();
            Console.WriteLine(employee1.GoInfo());
            Employee<string> employee2 = new Employee<string>();
            employee2.Input();
            Console.WriteLine(employee2.GoInfo());
            Console.ReadKey();
        }
    }
}
