  namespace CarDealershipApp.entity
{
    internal class Bank
    {

        public double Balance { get; set; }
        public List<string> TransactionList { get; set; }
        public Bank(double initialBalance)
        {
            Balance = initialBalance;
            TransactionList = new List<string>();
        }


        public void Deposit(double amount)
        {
            Balance += amount;
            Console.WriteLine($"Balanciniza elave olundu: {amount} , Cari Balanciniz: {Balance}");
            TransactionList.Add($"{DateTime.Now}: +{amount} AZN əlavə olundu. Yeni balans: {Balance} AZN");

        }

        public bool Withdraw(double amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                Console.WriteLine($"-{amount} AZN cıxıldı. Yeni balans: {Balance}");
                TransactionList.Add($"{DateTime.Now}: -{amount} AZN cıxıldı. Yeni balans: {Balance} AZN");
                return true;
            }
            else
            {
                Console.WriteLine("Balansda kifayet qeder vesait yoxdu ");
                return false;
            }
        }
        public void ShowHistory()
        {
            Console.WriteLine("Emeliyyat tarixcesi: ");
            if (TransactionList.Count == 0)
            {
                Console.WriteLine("Hele hec bir emeliyyat yoxdu ");
            }
            else
            {
                foreach (var item in TransactionList)
                {
                    Console.WriteLine(item);
                }
            }



        }
    }
    }