using CarDealershipApp.entity;
using CarDealershipApp.servicess;
using CarDealershipApp.servicess.impl;


namespace CarDealershipApp.util;
internal class MenuUtil
{
    public static void MenuStart(CarServiceImpl carServiceImpl, Bank bank, RentCarImpl rentCarImpl)
    {
        bool stop = false;

        while (!stop)
        {
            const int first = 0;
            Console.WriteLine("WELCOME");

            Console.WriteLine("1. CAR SALE");
            Console.WriteLine("2. RENT A CAR");
            Console.WriteLine("3. BANK");
            Console.WriteLine("4. EXIT");
            Console.Write("Menudan secim edin: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    CarSaleMenu(carServiceImpl, bank);

                    break;
                case 2:
                    RentCarMenu(rentCarImpl, bank);
                    break;
                case 3:
                    BankMenu(bank);
                    break;
                case 4:
                    Console.WriteLine("EXIT....");
                    stop = true;
                    break;

                default:
                    Console.WriteLine("Yalnis secim");
                    break;
            }

        }
    }

    public static void CarSaleMenu(CarServiceImpl carService, Bank bank)
    {
        //Tuncay yaz
        bool back = false;
        while (!back)
        {
            Console.WriteLine("---------- Car Sale Menu ----------");
            Console.WriteLine("1. Maşın elave et");
            Console.WriteLine("2. Maşınlara Bax");
            Console.WriteLine("3. Maşın Sil ");
            Console.WriteLine("4. Maşınları Filtrle");
            Console.WriteLine("5. Maşınları Çeşidle");
            Console.WriteLine("0. Geri");
            Console.Write("Seçiminizi edin: ");
            int secim = Convert.ToInt32(Console.ReadLine());
            switch (secim)
            {
                case 1:
                    Console.Write("Brand: ");
                    string brand = Console.ReadLine();
                    Console.Write("Model: ");
                    string model = Console.ReadLine();
                    Console.Write("Year: ");
                    int year = int.Parse(Console.ReadLine());
                    Console.Write("CostPrice: ");
                    double cost = double.Parse(Console.ReadLine());
                    Console.Write("SalePrice: ");
                    double sale = double.Parse(Console.ReadLine());

                    Car newCar = new Car(brand, model, year, cost, sale, false);
                    carService.AddCar(newCar, bank);

                    break;
                case 2:
                    Console.WriteLine("Bütün maşınlar:");
                    List<Car> carList = carService.GetAllCars();
                    foreach (Car car in carList)
                    {
                        car.ShowInfo();
                    }
                    break;
                    // butun masinlar gosterilir
                    break;
                case 3:
                    Console.Write("Silmek istediyz avtomobil id dagil et: ");
                    int removeId = Convert.ToInt32(Console.ReadLine());
                    carService.RemoveCar(removeId);
                    break;
                    //masin silme funksiyasi
                    break;
                case 4:
                    Console.Write("Year dagl et: ");
                    int finYear = Convert.ToInt32(Console.ReadLine());
                    List<Car> filterdCar = carService.FilterCar(finYear);
                    foreach (Car car in filterdCar)
                    {
                        car.ShowInfo();
                    }

                    //filtr funksiyasi
                    break;
                case 5:
                    Console.WriteLine("Masinlar qiymete gore siralanib");
                    List<Car> filterCar = carService.SortCars();
                    foreach (var item in filterCar)
                    {
                        item.ShowInfo();
                    }
                    break;
                case 6:
                    Console.WriteLine("Maşın icarəye verilir...");
                    Console.WriteLine("Qaydalar:");
                    Console.WriteLine("- İcareye verilen maşın 'rented' statusu alır.");
                    Console.WriteLine("- Statusu 'rented' olan maşın yeniden icareye verile bilmez.");
                    Console.WriteLine("- İcare mebleği avtomobilin deyerinə göre müeyyən edilir.");
                    break;
                case 0:
                    Console.WriteLine("Esas menyuya qayıdılır...");
                    back = true;
                    break;
                default:
                    Console.WriteLine("Yanlış seçim etdiniz!");
                    break;
            }
            Console.WriteLine();
        }
    }
    public static void RentCarMenu(RentCarImpl rentService, Bank bank)
    {
        bool back = false;

        while (!back)
        {
            Console.WriteLine("---------- Rent a Car Menu ----------");
            Console.WriteLine("1. Maşın elave et");
            Console.WriteLine("2. Maşınlara Bax");
            Console.WriteLine("3. Maşın Sil ");
            Console.WriteLine("4. Maşınları Filtrle");
            Console.WriteLine("5. Maşınları Çeşidle");
            Console.WriteLine("6. Maşınl kiraye ver");
            Console.WriteLine("0. Geri");
            Console.Write("Seçiminizi edin: ");

            int secim = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            switch (secim)
            {
                case 1:
                    Console.Write("Brand: ");
                    string brand = Console.ReadLine();
                    Console.Write("Model: ");
                    string model = Console.ReadLine();
                    Console.Write("Year: ");
                    int year = int.Parse(Console.ReadLine());
                    Console.Write("CostPrice: ");
                    double cost = double.Parse(Console.ReadLine());
                    Console.Write("RentPrice (gündelik): ");
                    double rentPrice = double.Parse(Console.ReadLine());

                    Car newCar = new Car(brand, model, year, cost, rentPrice, false);
                    rentService.AddCar(newCar, bank);

                    Console.WriteLine(" Maşın uğurla elave olundu!");
                    break;

                case 2:
                    Console.WriteLine("Bütün icare maşınları:");
                    List<Car> rentCars = rentService.GetAllCars();
                    foreach (var car in rentCars)
                    {
                        car.ShowInfo();
                    }
                    break;

                case 3:
                    Console.Write("Silinecek maşının ID-sini daxil edin: ");
                    int removeId = Convert.ToInt32(Console.ReadLine());
                    rentService.RemoveCar(removeId);
                    Console.WriteLine(" Maşın uğurla silindi!");
                    break;

                case 4:
                    Console.Write("İl daxil edin (filtrlemek üçün): ");
                    int findYear = Convert.ToInt32(Console.ReadLine());
                    List<Car> filteredCars = rentService.FilterCar(findYear);
                    foreach (var car in filteredCars)
                    {
                        car.ShowInfo();
                    }
                    break;

                case 5:
                    Console.WriteLine("Maşınlar qiymete göre çeşidlenir:");
                    List<Car> sortedCars = rentService.SortCars();
                    foreach (var car in sortedCars)
                    {
                        car.ShowInfo();
                    }
                    break;

                case 6:
                    Console.Write("Icarəyə veriləcək maşının ID-sini daxil edin: ");
                    int rentId = Convert.ToInt32(Console.ReadLine());
                    rentService.RentCar(rentId, bank);
                    break;

                case 0:
                    Console.WriteLine("Esas menyuya qayıdılır...");
                    back = true;
                    break;

                default:
                    Console.WriteLine(" Yanlış seçim etdiniz!");
                    break;
            }

            Console.WriteLine();
        }
    }

    public static void BankMenu(Bank bank)
    {
        bool back = false;

        while (!back)
        {
            Console.WriteLine("------------- Bank Menu -------------");
            
            Console.WriteLine("1. Bank hesabım (balansı goster)");           
            Console.WriteLine("2. Emeliyyat tarixçesi (satışlar, icare gelirleri ve s.)");
            Console.WriteLine("0. Geri");
            Console.Write("Seçiminizi edin: ");

            int secim = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            switch (secim)
            {
                case 1:
                    Console.WriteLine(" Mövcud balans:");
                    Console.WriteLine($"Balans: {bank.Balance} AZN");
                    break;

                case 2:
                    //Emeliyyatlarin siyahisi
                    Console.WriteLine();
                    Console.WriteLine("Emeliyyat tarixçesi:");
                    bank.ShowHistory();
                    break;

                case 0:
                    Console.WriteLine("Esas menyuya qayıdılır...");
                    back = true;
                    break;

                default:
                    Console.WriteLine(" Yanlış seçim etdiniz!");
                    break;
            }

            Console.WriteLine();
        }
    }
}