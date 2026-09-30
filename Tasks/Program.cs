//Tapsiriq1

using System;
using System.Collections.Generic;

public class Task1
{
    public static void Main(string[] args)
    {
        Dictionary<int, string> students = new Dictionary<int, string>() {
            { 102, "Elvin Huseynov" },
            { 103, "Leyla Aliyeva" },
            { 104, "Rashad Ahmadov" },
        };

        bool isRunning = true;

        while (isRunning)
        {
            Console.WriteLine("\n--- MENYU ---");
            Console.WriteLine("1) Telebe elave et");
            Console.WriteLine("2) Telebeni ID ile axtar");
            Console.WriteLine("3) Butun telebeleri goster");
            Console.WriteLine("4) Cixis");
            Console.Write("Seciminizi daxil edin (1-4): ");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                    case 1:
                        Console.Write("Yeni telebe ID-si daxil edin: ");
                        if (int.TryParse(Console.ReadLine(), out int newId))
                        {
                            if (students.ContainsKey(newId))
                            {
                                Console.WriteLine("Bu ID artiqlamasilə movcuddur!");
                            }
                            else
                            {
                                Console.Write("Telebenin adini daxil edin: ");
                                string name = Console.ReadLine();
                                students.Add(newId, name);
                                Console.WriteLine("Telebe ugurla elave olundu!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Xeta: Duzgun ID daxil etmediniz!");
                        }
                        break;

                    case 2:
                        Console.Write("Axtarilan ID-ni daxil edin: ");
                        if (int.TryParse(Console.ReadLine(), out int searchId))
                        {
                            if (students.TryGetValue(searchId, out string foundName))
                            {
                                Console.WriteLine($"Tapildi: ID: {searchId}, Ad: {foundName}");
                            }
                            else
                            {
                                Console.WriteLine("Bu ID ile telebe tapilmadi!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Xeta: Duzgun ID daxil etmediniz!");
                        }
                        break;

                    case 3:
                        Console.WriteLine("\n--- Butun Telebeler ---");
                        foreach (var item in students)
                        {
                            Console.WriteLine($"ID: {item.Key} | Ad: {item.Value}");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Proqramdan cixilir...");
                        isRunning = false;
                        break;

                    default:
                        Console.WriteLine("Yanlis secim! 1-4 arasi reqem daxil edin.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Xeta: Duzgun secim daxil etmediniz!");
            }
        }
    }
}

//Tapsiriq2

using System;

public class Task2
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Fiqur secin: 1) Daire, 2) Duzbucaqli, 3) Ucbucaq");
        Console.Write("Seciminiz (ve ya adini yazin): ");
        string choice = Console.ReadLine()?.ToLower();

        switch (choice)
        {
            case "1":
            case "daire":
                Console.Write("Dairenin radiusunu daxil edin: ");
                if (double.TryParse(Console.ReadLine(), out double r))
                {
                    double area = Math.PI * Math.Pow(r, 2);
                    Console.WriteLine("Dairenin sahesi: " + Math.Round(area, 2));
                }
                else
                {
                    Console.WriteLine("Xeta: Duzgun mebleg daxil etmediniz!");
                }
                break;

            case "2":
            case "duzbucaqli":
                Console.Write("Enini daxil edin: ");
                bool checkA = double.TryParse(Console.ReadLine(), out double a);
                Console.Write("Uzunlugunu daxil edin: ");
                bool checkB = double.TryParse(Console.ReadLine(), out double b);

                if (checkA && checkB)
                {
                    double area = a * b;
                    Console.WriteLine("Duzbucaqlinin sahesi: " + Math.Round(area, 2));
                }
                else
                {
                    Console.WriteLine("Xeta: Duzgun mebleg daxil etmediniz!");
                }
                break;

            case "3":
            case "ucbucaq":
                Console.Write("1-ci terefi daxil edin: ");
                bool check1 = double.TryParse(Console.ReadLine(), out double side1);
                Console.Write("2-ci terefi daxil edin: ");
                bool check2 = double.TryParse(Console.ReadLine(), out double side2);
                Console.Write("3-cu terefi daxil edin: ");
                bool check3 = double.TryParse(Console.ReadLine(), out double side3);

                if (check1 && check2 && check3)
                {
                    double p = (side1 + side2 + side3) / 2;
                    double areaVal = p * (p - side1) * (p - side2) * (p - side3);

                    if (areaVal > 0)
                    {
                        double area = Math.Sqrt(areaVal);
                        Console.WriteLine("Ucbucaqin sahesi: " + Math.Round(area, 2));
                    }
                    else
                    {
                        Console.WriteLine("Xeta: Bele tereflere malik ucbucaq movcud ola bilmez!");
                    }
                }
                else
                {
                    Console.WriteLine("Xeta: Duzgun mebleg daxil etmediniz!");
                }
                break;

            default:
                Console.WriteLine("Xeta: Yanlis fiqur secildi!");
                break;
        }
    }
}

//Tapsiriq3

using System;
using System.Collections.Generic;

public class Task3
{
    public static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("10 dene eded daxil edin:");

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"{i + 1}-ci ededi daxil edin: ");
            if (int.TryParse(Console.ReadLine(), out int num))
            {
                numbers.Add(num);
            }
            else
            {
                Console.WriteLine("Xeta: Duzgun eded daxil etmediniz! Yeniden cehd edin.");
                i--;
            }
        }

        int max = numbers[0];
        int min = numbers[0];
        int evenCount = 0;
        int oddCount = 0;

        foreach (int n in numbers)
        {
            max = Math.Max(max, n);
            min = Math.Min(min, n);

            if (n % 2 == 0)
            {
                evenCount++;
            }
            else
            {
                oddCount++;
            }
        }

        Console.WriteLine("\n--- Neticeler ---");
        Console.WriteLine("En boyuk eded: " + max);
        Console.WriteLine("En kicik eded: " + min);
        Console.WriteLine("Cut ededlerin sayi: " + evenCount);
        Console.WriteLine("Tek ededlerin sayi: " + oddCount);
    }
}

//Tapsiriq4
using System;

public class Task4
{
    public static void Main(string[] args)
    {
        Random random = new Random();
        int randomNumber = random.Next(0, 101);
        int guess;

        Console.WriteLine("0-100 arasi tesadufi eded secildi. Tapmaga cehd edin!");

        do
        {
            Console.Write("Texmininizi daxil edin: ");
            if (int.TryParse(Console.ReadLine(), out guess))
            {
                if (guess > randomNumber)
                {
                    Console.WriteLine("Daha kicik eded cehd edin");
                }
                else if (guess < randomNumber)
                {
                    Console.WriteLine("Daha boyuk eded cehd edin");
                }
                else
                {
                    Console.WriteLine("Tebrikler!");
                }
            }
            else
            {
                Console.WriteLine("Xeta: Duzgun eded daxil etmediniz!");
                guess = -1;
            }
        } while (guess != randomNumber);
    }
}
