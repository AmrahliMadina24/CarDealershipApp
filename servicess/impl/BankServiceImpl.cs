using CarDealershipApp.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealershipApp.servicess.impl
{
    internal class BankServiceImpl : IBankService
    {
        public void ShowBalance(Bank bank)
        {
            Console.WriteLine($"Bank balansınız: {bank.Balance} AZN");
        }

        public void AddIncome(Bank bank, double amount)
        {
            bank.Balance += amount;
            Console.WriteLine($"+{amount} AZN əlavə olundu. Yeni balans: {bank.Balance} AZN");
        }

        public bool Withdraw(Bank bank, double amount)
        {
            if (bank.Balance >= amount)
            {
                bank.Balance -= amount;
                Console.WriteLine($"-{amount} AZN çıxıldı. Yeni balans: {bank.Balance} AZN");
                return true;
            }
            else
            {
                Console.WriteLine("Balansda kifayət qədər vəsait yoxdur.");
                return false;
            }
        }
    }
}
