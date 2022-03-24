using System;

namespace _1_240322
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int VehicleQuantity = IntChecker("sayi daxil edin: ");
            Car[] cars = new Car[VehicleQuantity];
            for (int i = 0; i < cars.Length; i++)
            {

                Console.WriteLine($"=============={i + 1}.Car==============");
                Console.Write("Markani daxil edin: ");
                string brand = Console.ReadLine();
                Console.Write("Rengini daxil edin: ");
                string color = Console.ReadLine();
                double millage = DoubleChecker("Yuruyusun daxil edin: ");
                int fuelCapasity = IntChecker("Maksimum yanacaq ceni : ");

                Car car = new Car()
                {
                    Color = color,
                    Brand = brand,
                    Millage = millage,
                    FuelCapasity = fuelCapasity,

                };
                cars[i] = car;
            }
                Console.WriteLine("\n=======Menu=======\n");
                Console.WriteLine("1. Masinlari millage-e gore filtirle\n2. Butun masinlari goster\n3. Prosesi bitir");
                int choose = IntChecker("Secim edin: ");
                switch (choose)
                {
                    case 1:
                        double min = DoubleChecker("Minimum yuruyus: ");
                        double max = DoubleChecker("Maximum yuruyus: ");
                        Console.WriteLine("\n===========Filirlenmis Masinlar============\n");
                        foreach (var item in MillageFilter(min, max, cars))
                        {
                            Console.WriteLine(item.ShowInfo());
                        }
                        break;
                    case 2:
                        Console.WriteLine("=========Butun Masinlar=========");
                        foreach (var item in cars)
                        {
                            Console.WriteLine(item.ShowInfo());
                        }
                        break;
                    case 3:
                        Console.WriteLine("Proses sonlandirildi.");
                        break;
                    default:
                        Console.WriteLine("Duzgun secim edin");
                        break;
                }
            static double DoubleChecker(string text)
            {
                double Value;
                string StrValue;
                do
                {
                    Console.Write(text);
                    StrValue = Console.ReadLine();
                    if (!double.TryParse(StrValue, out Value))
                        Console.WriteLine("yanliz reqem");
                } while (!double.TryParse(StrValue, out Value));
                Value = Convert.ToDouble(StrValue);
                return Value;
            }



            static int IntChecker(string text)
                {
                    int Value;
                    string StrValue;
                    do
                    {
                        Console.Write(text);
                        StrValue = Console.ReadLine();
                        if (!int.TryParse(StrValue, out Value))
                            Console.WriteLine("yanliz reqem");
                    } while (!int.TryParse(StrValue, out Value));
                    Value = Convert.ToInt32(StrValue);
                    return Value;
                }
                
                static Car[] MillageFilter(double min, double max, Car[] cars)
                {
                    int count = 0;
                    for (int i = 0; i < cars.Length; i++)
                    {
                        if (cars[i].Millage > min && cars[i].Millage < max)
                        {
                            count++;
                        }
                    }
                    Car[] result = new Car[count];
                    int newArr = 0;
                    for (int i = 0; i < cars.Length; i++)
                    {
                        if (cars[i].Millage > min && cars[i].Millage < max)
                        {
                            result[newArr] = cars[i];
                            newArr++;
                        }
                    }
                    return result;
                }


            }

        }
    }
        

