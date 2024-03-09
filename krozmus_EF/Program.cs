using krozmus_EF;
using krozmus_EF.Model;

namespace krozmus_EF
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine($"Choose your desired table:\nMotherboards(1)\nPower Supply Units(2)\nLeave(3)");

            int input = int.Parse(Console.ReadLine());



            if (input == 1)
            {
                while (true)
                {
                    Console.WriteLine($"\nWhat operation would you like to execute on the chosen table?");
                    Console.WriteLine($"Create(1)\nRead(2)\nUpdate(3)\nDelete(4)\nLeave(5)");

                    int choice = int.Parse(Console.ReadLine());


                    if (choice == 1)
                    {
                        Console.WriteLine($"\nEnter the motherboard's model:");
                        string model = Console.ReadLine() ?? "";
                        Console.WriteLine($"\nEnter the motherboard's brand:");
                        string brand = Console.ReadLine() ?? "";
                        Console.WriteLine($"\nEnter the motherboard's standard:");
                        string standard = Console.ReadLine() ?? "";
                        Console.WriteLine($"\nEnter the motherboard's CPU socket:");
                        string socket = Console.ReadLine() ?? "";
                        Console.WriteLine($"\nEnter the motherboard's chipset:");
                        string chipset = Console.ReadLine() ?? "";

                        AddMotherboard(model, brand, standard, socket, chipset);
                    }

                    else if (choice == 2)
                    {
                        Console.Write("\n");
                        DisplayMotherboard();
                    }

                    else if (choice == 3)
                    {
                        Console.WriteLine($"\nEnter desired motherboard's ID value:");
                        int id = int.Parse(Console.ReadLine());
                        Console.WriteLine($"\nEnter the motherboard's model:");
                        string model = Console.ReadLine() ?? "";
                        Console.WriteLine($"\nEnter the motherboard's brand:");
                        string brand = Console.ReadLine() ?? "";
                        Console.WriteLine($"\nEnter the motherboard's standard:");
                        string standard = Console.ReadLine() ?? "";
                        Console.WriteLine($"\nEnter the motherboard's CPU socket:");
                        string socket = Console.ReadLine() ?? "";
                        Console.WriteLine($"\nEnter the motherboard's chipset:");
                        string chipset = Console.ReadLine() ?? "";

                        UpdateMotherboard(id, model, brand, standard, socket, chipset);
                    }

                    else if (choice == 4)
                    {
                        Console.WriteLine($"\nType in the ID value of the record you would like to delete:");
                        int id = int.Parse(Console.ReadLine());

                        DeleteMotherboard(id);
                    }

                    else if (choice == 5)
                    {
                        return;
                    }
                }
            }


            else if (input == 2)
            {
                while (true)
                {
                    Console.WriteLine($"\nWhat operation would you like to execute on the chosen table?");
                    Console.WriteLine($"Create(1)\nRead(2)\nUpdate(3)\nDelete(4)\nLeave(5)");

                    int choice = int.Parse(Console.ReadLine());


                    if (choice == 1)
                    {
                        Console.WriteLine($"\nEnter the PSU's wattage:");
                        int wattage = int.Parse(Console.ReadLine());
                        Console.WriteLine($"\nEnter the PSU's standard:");
                        string standard = Console.ReadLine() ?? "";
                        Console.WriteLine($"\nEnter the PSU's energy efficiency rating:");
                        string energyEfficiency = Console.ReadLine() ?? "";

                        AddPSU(wattage, standard, energyEfficiency);
                    }

                    else if (choice == 2)
                    {
                        Console.Write("\n");
                        DisplayPSU();
                    }

                    else if (choice == 3)
                    {
                        Console.WriteLine($"\nEnter desired PSU's ID value:");
                        int id = int.Parse(Console.ReadLine());
                        Console.WriteLine($"\nEnter the PSU's wattage:");
                        int wattage = int.Parse(Console.ReadLine());
                        Console.WriteLine($"\nEnter the PSU's standard:");
                        string standard = Console.ReadLine() ?? "";
                        Console.WriteLine($"\nEnter the PSU's energy efficiency rating:");
                        string energyEfficiency = Console.ReadLine() ?? "";

                        UpdatePSU(id, wattage, standard, energyEfficiency);
                    }

                    else if (choice == 4)
                    {
                        Console.WriteLine($"\nType in the ID value of the record you would like to delete:");
                        int id = int.Parse(Console.ReadLine());

                        DeletePSU(id);
                    }


                    else if (choice == 5)
                    {
                        return;
                    }

                }
            }


            else if (input == 3)
            {
                return;
            }


            else
            {
                return;
            }
        }



        public static void DisplayMotherboard()
        {
            using (var context = new ComputerShopContext())
            {
                context.Database.EnsureCreated();


                foreach (var Motherboard in context.Motherboards)
                {
                    Console.WriteLine($"{Motherboard.MotherboardID}:\n{Motherboard.Model}\n{Motherboard.Brand}\n{Motherboard.Standard}\n{Motherboard.Socket}\n{Motherboard.Chipset}");
                }
            }
        }

        public static void DisplayPSU()
        {
            using (var context = new ComputerShopContext())
            {
                context.Database.EnsureCreated();


                foreach (var PSU in context.PSUS)
                {
                    Console.WriteLine($"{PSU.PSUID}:\n{PSU.Wattage}\n{PSU.Standard}\n{PSU.EnergyEfficiency}");
                }
            }
        }


        public static void AddMotherboard(string model, string brand, string standard, string socket, string chipset)
        {
            using (var context = new ComputerShopContext())
            {
                context.Database.EnsureCreated();


                var motherboard = new Motherboard() { Model = model, Brand = brand, Standard = standard, Socket = socket, Chipset = chipset};
                context.Motherboards.Add(motherboard);
                context.SaveChanges();
            }
        }

        public static void AddPSU(int wattage, string standard, string energyEfficiency)
        {
            using (var context = new ComputerShopContext())
            {
                context.Database.EnsureCreated();


                var psu = new PSU() { Wattage = wattage, Standard = standard, EnergyEfficiency = energyEfficiency};
                context.PSUS.Add(psu);
                context.SaveChanges();
            }
        }


        public static void UpdateMotherboard(int motherboardid, string model, string brand, string standard, string socket, string chipset)
        {
            using (var context = new ComputerShopContext())
            {
                context.Database.EnsureCreated();


                var motherboard = context.Motherboards.Where(x => x.MotherboardID == motherboardid).FirstOrDefault() ?? new Motherboard();
                if (motherboard != null)
                {
                    motherboard.Model = model;
                    motherboard.Brand = brand;
                    motherboard.Standard = standard;
                    motherboard.Socket = socket;
                    motherboard.Chipset = chipset;
                    context.SaveChanges();
                }
            }
        }

        public static void UpdatePSU(int psuid, int wattage, string standard, string energyEfficiency)
        {
            using (var context = new ComputerShopContext())
            {
                context.Database.EnsureCreated();


                var psu = context.PSUS.Where(x => x.PSUID == psuid).FirstOrDefault() ?? new PSU();
                if (psu != null)
                {
                    psu.Wattage = wattage;
                    psu.Standard = standard;
                    psu.EnergyEfficiency = energyEfficiency;
                    context.SaveChanges();
                }
            }
        }


        public static void DeleteMotherboard(int motherboardid)
        {
            using (var context = new ComputerShopContext())
            {
                context.Database.EnsureCreated();


                var motherboard = context.Motherboards.Where(x => x.MotherboardID == motherboardid).FirstOrDefault() ?? new Motherboard();
                context.Motherboards.Remove(motherboard);
                context.SaveChanges();
            }
        }

        public static void DeletePSU(int psuid)
        {
            using (var context = new ComputerShopContext())
            {
                context.Database.EnsureCreated();


                var psu = context.PSUS.Where(x => x.PSUID == psuid).FirstOrDefault() ?? new PSU();
                context.PSUS.Remove(psu);
                context.SaveChanges();
            }
        }
    }
}