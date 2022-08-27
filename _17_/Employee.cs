using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17
{
    class Employee<T>
    {
        public T Num { get; set; }
        public string Name { get; set; }
        public int Balance { get; set; }
        //public Employee(T num, string name, int summa)
        //{
        //    Num = num;
        //    Name = name;
        //    Balance = balance;
        //}
        public string GoInfo()
        {
            return $"{Num} {Name} {Balance}";
        }
        public void Input()
        {
            Console.WriteLine("Введите номер счета");
            Num = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
            Console.WriteLine("Введите ФИО владельца счета");
            Name = Console.ReadLine();
            Console.WriteLine("Введите желаемый баланс :=) ");
            Balance = Convert.ToInt32(Console.ReadLine());
        }
    }
}
