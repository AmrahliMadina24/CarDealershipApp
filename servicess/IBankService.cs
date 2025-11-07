using CarDealershipApp.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealershipApp.servicess
{
    internal interface IBankService
    {
        void ShowBalance(Bank bank);

       
        void AddIncome(Bank bank, double amount);

        
        bool Withdraw(Bank bank, double amount);
    }
}
