using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Bank
{
    class Program
    {
        /* Условие задачи:
         * Создать класс для моделирования счета в банке. Предусмотреть закрытые поля для номера счета, баланса, ФИО владельца.  
         * Класс должен быть объявлен как обобщенный. Универсальный параметр T должен определять тип номера счета. Разработать  
         * методы  для  доступа  к  данным  –  заполнения  и  чтения. Создать  несколько экземпляров класса, параметризированного 
         * различными типам. Заполнить его поля и вывести информацию об экземпляре класса на печать.
         */
        /* Решение задачи
         * Создан класс BankAccount с обобщенным параметром типа счета. В классе два конструктора, один с передачей параметров
         * и инициализацией закрытых полей, второй по умолчанию. Реализовано 2 метода на ввод и вывод данных.
         * В Main создано 3 экз класса, два экземпляра с передачей параметров типа счета int и string, 3-й экз класса получает данные от
         * пользователя через метод InputInfo. Все три экземпляра выводят данные о пользователе методом GetInfo.
         */
        static void Main(string[] args)
        {
            BankAccount<int> firstUser = new BankAccount<int>(24, 265600, "Иванов Сергей Николаевич");
            BankAccount<string> secondUser = new BankAccount<string>("B-048", 1400000, "Федоров Игорь Николаевич");
            Console.WriteLine(firstUser.GetInfo() + "\n");
            Console.WriteLine(secondUser.GetInfo() + "\n");
            
            Console.WriteLine("\nВведите данные пользователя 3:\n");
            BankAccount<int> thirdUser = new BankAccount<int>();
            thirdUser.InputInfo();
            Console.WriteLine("\nВывод данных о пользователе 3:\n" + thirdUser.GetInfo());

            Console.ReadKey();
        }
    }
}
