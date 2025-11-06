using System;

namespace CarDealershipApp.util;
public class MenuUtil
{
	public static void MenuStart()
	{
		bool stop = false;

		while (!stop) {
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
					Console.WriteLine("Bura carsale menu gelecey");
					break;
				case 2:
					Console.WriteLine("Bura rent a car menu gelecey ");
					break;
				case 3:
					Console.WriteLine("BankMenu gelecey");
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
	}

	
}
