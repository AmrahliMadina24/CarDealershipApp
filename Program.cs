using CarDealershipApp.entity;
using CarDealershipApp.servicess.impl;
using CarDealershipApp.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealershipApp
{
    internal class Program
    {
        public static void Main(string[] args) 
        {

            CarServiceImpl serviceImpl = new CarServiceImpl();
            RentCarImpl rentCarImpl = new RentCarImpl();
            Bank bank = new Bank(10000);
            MenuUtil.MenuStart(serviceImpl, bank , rentCarImpl);
        }
    }
}
