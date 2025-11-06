namespace CarDealershipApp.entity
{
    internal class Bank
    {
       
        public double Balance { get; set; }

        public Bank(double initialBalance)
        {
            Balance = initialBalance;
        }


        public void Deposit(double amount)
        {
            Balance += amount;
            Console.WriteLine($"Balanciniza elave olundu: {amount} , Cari Balanciniz: {Balance}");
        }

    }
}
 