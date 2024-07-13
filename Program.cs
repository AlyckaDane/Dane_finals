using System;

namespace Finalproj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] airconbrands = { "Carrier", "Daikin", "Panasonic", "LG", "Fujidenzo", "Condura", "Kolin", "Samsung", "Midea", "American home" };

            Console.WriteLine("It is summer again! Due to the heat that we are experiencing, we have tended to use air conditioning more often these past few months.");
            Console.WriteLine("\n Do you want to know how much it costs to have an air conditioner in your house?");
            Console.Write("Type YES or NO: ");
            string yesno = Console.ReadLine();

            string tips = "";
            if (yesno == "yes")
            {
                Console.WriteLine("\n Okay! Let us find out using our Air Conditioning Energy Calculator.");


                Console.WriteLine("\n Think of one of your air conditioners that you want to examine, then answer the questions here based on it.");

                Console.ReadKey();
                Console.WriteLine("                                  ");
                Console.WriteLine("AIRCON ENERGY CALCULATOR");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~");

                Console.WriteLine("Choose the number of aircon brand you use.");

                Console.WriteLine("0  - Carrier");
                Console.WriteLine("1  - Daikin");
                Console.WriteLine("2  - Panasonic");
                Console.WriteLine("3  - LG");
                Console.WriteLine("4  - Fujidenzo");
                Console.WriteLine("5  - Condura");
                Console.WriteLine("6  - Kolin");
                Console.WriteLine("7  - Samsung");
                Console.WriteLine("9  - Midea");
                Console.WriteLine("10 - American home");

                Console.Write("\n Enter number here: ");
                int numaircon = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\n                                      ");
                Console.WriteLine("             AIRCON HP BASED ON THE ROOM SIZE");
                Console.WriteLine("__________________________________________________________ ");
                Console.WriteLine("|  ROOM TYPE  |      ROOM SIZE        |   AIRCON HP      |");
                Console.WriteLine("|_____________|_______________________|__________________| ");
                Console.WriteLine("|  Small      | smaller than 25 sq.m  | 1 HP or below    |");
                Console.WriteLine("|_____________|_______________________|__________________| ");
                Console.WriteLine("|  Medium     | 25 - 44 sq.m          | 1.5 or 2.0 HP    |");
                Console.WriteLine("|_____________|_______________________|__________________| ");
                Console.WriteLine("|  Large      | 50 - 72 sq.m          | 2.5 or 3.0 HP    |");
                Console.WriteLine("|_____________|_______________________|__________________|");

                Console.WriteLine("\n  What's yours there? Press Enter to move on ");
                Console.ReadKey();

                Console.WriteLine("\n                 TYPE OF AIR CONDITIONERS");
                Console.WriteLine("________________________________________________________________");
                Console.WriteLine("| 1  ~ Air Conditioner - Floor Stand, Non - Inverter (2.50 HP) |");
                Console.WriteLine("| 2  ~ Air Conditioner - Floor Stand, Non - Inverter (3.00 HP) |");
                Console.WriteLine("| 3  ~ Air Conditioner - Floor Stand, Non - Inverter (4.50 HP) |");
                Console.WriteLine("| 4  ~ Air Conditioner - Split Type ,       Inverter (1.00 HP) |");
                Console.WriteLine("| 5  ~ Air Conditioner - Split Type ,       Inverter (1.50 HP) |");
                Console.WriteLine("| 6  ~ Air Conditioner - Split Type ,       Inverter (2.00 HP) |");
                Console.WriteLine("| 7  ~ Air Conditioner - Split Type ,       Inverter (2.50 HP) |");
                Console.WriteLine("| 8  ~ Air Conditioner - Split Type , Non - Inverter (1.00 HP) |");
                Console.WriteLine("| 9  ~ Air Conditioner - Split Type , Non - Inverter (1.50 HP) |");
                Console.WriteLine("| 10 ~ Air Conditioner - Split Type , Non - Inverter (2.00 HP) |");
                Console.WriteLine("| 11 ~ Air Conditioner - Split Type , Non - Inverter (2.50 HP) |");
                Console.WriteLine("| 12 ~ Air Conditioner - Split Type , Non - Inverter (3.00 HP) |");
                Console.WriteLine("| 13 ~ Air Conditioner - Window Type,       Inverter (1.00 HP) |");
                Console.WriteLine("| 14 ~ Air Conditioner - Window Type,       Inverter (1.50 HP) |");
                Console.WriteLine("| 15 ~ Ai  Conditioner - Window Type,       Inverter (2.00 HP) |");
                Console.WriteLine("| 16 ~ Air Conditioner - Window Type,       Inverter (2.50 HP) |");
                Console.WriteLine("| 17 ~ Air Conditioner - Window Type, Non - Inverter (0.50 HP) |");
                Console.WriteLine("| 18 ~ Air Conditioner - Window Type, Non - Inverter (0.60 HP) |");
                Console.WriteLine("| 19 ~ Air Conditioner - Window Type, Non - Inverter (0.75 HP) |");
                Console.WriteLine("| 20 ~ Air Conditioner - Window Type, Non - Inverter (0.80 HP) |");
                Console.WriteLine("| 21 ~ Air Conditioner - Window Type, Non - Inverter (1.00 HP) |");
                Console.WriteLine("| 22 ~ Air Conditioner - Window Type, Non - Inverter (1.50 HP) |");
                Console.WriteLine("| 23 ~ Air Conditioner - Window Type, Non - Inverter (2.00 HP) |");
                Console.WriteLine("| 24 ~ Air Conditioner - Window Type, Non - Inverter (2.50 HP) |");
                Console.WriteLine("|______________________________________________________________|");

                Console.Write("\n Enter the number you use            : ");
                int typeofac = Convert.ToInt32(Console.ReadLine());

                Console.Write("\n How many hours do you use it per day: ");
                int howmanyhours = Convert.ToInt32(Console.ReadLine());

                Console.Write("\n How many days do you use it per week: ");
                int howmanydays = Convert.ToInt32(Console.ReadLine());

                Console.Write("\n How many weeks a month              : ");
                int howmanyweeksamonth = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\n Are you ready to know how much it cost? Press Enter ");
                Console.ReadLine();

                Console.WriteLine("\n PROCESSING...........");
                Console.ReadLine();


                Console.WriteLine($"\n This is all the money your {airconbrands[numaircon]} air conditioner costs on your electric bill.");
                class1.Call(typeofac, howmanyhours, howmanydays, howmanyweeksamonth);


                Class2.Tips(tips);

            }
            else
            {
                Console.WriteLine("Okay, then this program is not for you :( ");
            }

        }
       
    }

}