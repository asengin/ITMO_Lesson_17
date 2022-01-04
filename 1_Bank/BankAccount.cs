using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Bank
{
    class BankAccount<T>
    {
        private T NumAccount { get; set; }
        private int BalanceAccount { get; set; }
        private string FullnameAccount { get; set; }


        public BankAccount(T numAccount, int balanceAccount, string fullnameAccount)
        {
            NumAccount = numAccount;
            BalanceAccount = balanceAccount;
            FullnameAccount = fullnameAccount;
        }
        public BankAccount()
        { }

        public void InputInfo()
        {
            Console.Write("Введите номер счета: ");
            NumAccount = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
            Console.Write("Введите баланс счета: ");
            BalanceAccount = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите ФИО владельца счета: ");
            FullnameAccount = Console.ReadLine();
        }

        public string GetInfo()
        {
            return $"Владелец: {FullnameAccount}\nБаланс: {BalanceAccount}\nНомер счета: {NumAccount} (тип {typeof(T)})";

        }
    }
}
