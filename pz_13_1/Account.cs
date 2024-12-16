using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_13_1
{
    public class Account
    {
        public decimal Balance { get; private set; }

        public Account(decimal initialBalance)
        {
            Balance = initialBalance;
        }

        // Операция пополнения счета
        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        // Операция снятия со счета
        public void Withdraw(decimal amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
            }
            else
            {
                Console.WriteLine("Недостаточно средств.");
            }
        }

        // Создание снимка состояния счета
        public Memento Save()
        {
            return new Memento(Balance);
        }

        // Восстановление состояния счета из снимка
        public void Restore(Memento memento)
        {
            Balance = memento.GetState();
        }
    }
}
