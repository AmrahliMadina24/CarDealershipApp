using System;
using System.Security.Cryptography.X509Certificates;

namespace CarDealershipApp.util;
public class MenuUtil
{
    public static void MenuStart()
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
                    CarSaleMenu();

                    break;
                case 2:
                    RentCarMenu();
                    break;
                case 3:
                    BankMenu();
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

    public static void CarSaleMenu()
    {
        //Tuncay yaz
        bool back = false;
        while (!back)
        {
            Console.WriteLine("---------- Car Sale Menu ----------");
            Console.WriteLine("1. Maşın elavə et");
            Console.WriteLine("2. Maşınlara Bax");
            Console.WriteLine("3. Maşın Sil ");
            Console.WriteLine("4. Maşınları Filtrlə");
            Console.WriteLine("5. Maşınları Çeşidlə");
            Console.WriteLine("6. Maşın İcarəyə Ver");
            Console.WriteLine("0. Geri");
            Console.Write("Seçiminizi edin: ");
            int secim = Convert.ToInt32(Console.ReadLine());
            switch (secim)
            {
                case 1:
                    Console.WriteLine("Yeni masin elave etmek");
                    //masin elave etme metodu cagirilir
                    break;
                case 2:
                    Console.WriteLine("Butun masinlar gosterilir");
                    // butun masinlar gosterilir
                    break;
                case 3:
                    Console.WriteLine("Masin silinir...");
                    //masin silme funksiyasi
                    break;
                case 4:
                    Console.WriteLine("Masinlari filtrlemek");
                    //filtr funksiyasi
                    break;
                case 5:
                    Console.WriteLine("Cesidleme emeliyyati");
                    //sort funksiyasi
                    break;
                case 6:
                    Console.WriteLine("Maşın icarəyə verilir...");
                    Console.WriteLine("Qaydalar:");
                    Console.WriteLine("- İcarəyə verilən maşın 'rented' statusu alır.");
                    Console.WriteLine("- Statusu 'rented' olan maşın yenidən icarəyə verilə bilməz.");
                    Console.WriteLine("- İcarə məbləği avtomobilin dəyərinə görə müəyyən edilir.");
                    break;
                case 0:
                    Console.WriteLine("Əsas menyuya qayıdılır...");
                    back = true;
                    break;
                default:
                    Console.WriteLine("Yanlış seçim etdiniz!");
                    break;
            }
            Console.WriteLine();
        }
    }
    public static void RentCarMenu()
    {
        bool back = false;

        while (!back)
        {
            Console.WriteLine("---------- Rent a Car Menu ----------");
            Console.WriteLine("1. Maşın elave et");
            Console.WriteLine("2. Maşınlara Bax");
            Console.WriteLine("3. Maşın Sil");
            Console.WriteLine("4. Maşınları Filtrle");
            Console.WriteLine("5. Maşınları Çeşidle");
            Console.WriteLine("6. Maşın İcareye Ver");
            Console.WriteLine("0. Geri");
            Console.Write("Seçiminizi edin: ");

            int secim = Convert.ToInt32(Console.ReadLine());
            switch (secim)
            {
                case 1:
                    Console.WriteLine("Yeni maşın əlavə edilir...");
                    // AddRentCar() metodu çağırılacaq
                    break;
                case 2:
                    Console.WriteLine("Bütün icare maşınları gösterilir...");
                    // ShowRentCars()
                    break;
                case 3:
                    Console.WriteLine("Maşın silinir...");
                    // DeleteRentCar()
                    break;
                case 4:
                    Console.WriteLine("Filtrleme emeliyyatı...");
                    // FilterRentCars()
                    break;
                case 5:
                    Console.WriteLine("Çeşidleme emeliyyatı...");
                    // SortRentCars()
                    break;
                case 6:
                    Console.WriteLine("İcare emeliyyatı...");
                    Console.WriteLine("- İcarəye verilən maşın 'rented' statusu alır.");
                    Console.WriteLine("- Statusu 'rented' olan maşın yeniden icareye verile bilmez.");
                    Console.WriteLine("- İcare mebleği avtomobilin deyerine göre müeyyen edilir.");
                    // RentCar()
                    break;
                case 0:
                    Console.WriteLine("Esas menyuya qayıdılır...");
                    back = true;
                    break;
                default:
                    Console.WriteLine("Yanlış seçim!");
                    break;
            }
        }
    }
    public static void BankMenu()
    {
        bool back = false;
        while (!back)
        {
            Console.WriteLine("-------------Bank Menu-------------");
            Console.WriteLine("1. Bank Accountum (Balansi goster)");
            Console.WriteLine("2. Emeliyatlarim  (satislar, icare gelirleri, tarixce ve s.)");
            Console.WriteLine("3. Cixis");
            Console.Write("Secimizini edin: ");
            int secim = Convert.ToInt32(Console.ReadLine());
            switch (secim)
            {
                case 1:
                    Console.WriteLine("Balans gösterilir...");
                    // ShowBalance()
                    break;
                case 2:
                    Console.WriteLine("Emeliyyat tarixçesi gösterilir...");
                    // ShowTransactions()
                    break;
                case 3:
                    Console.WriteLine("Esas menyuya qayıdılır...");
                    back = true;
                    break;
                default:
                    Console.WriteLine("Yanlış seçim!");
                    break;
            }

            Console.WriteLine();
        }
    }
}