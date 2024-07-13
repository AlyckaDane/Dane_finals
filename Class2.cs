using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finalproj
{
    internal class Class2
    {
        public static void Tips(string tips)
        {
            Console.WriteLine("\n Are you interested in knowing some tips about saving energy while using air conditioning?");
            Console.Write("Yes or No: ");
            string yesorno = Console.ReadLine();

            if (yesorno == "yes")
            {
                Console.WriteLine("\n TIPS ON SAVING ENERGY ");
                Console.WriteLine("______________________________________________");
                Console.Write("\n Okay! Now, do you have a window in your room? ");
                string yesornoo = Console.ReadLine();
                if (yesornoo == "yes")
                {
                    Console.WriteLine("\n Closing curtains and blinds during the hottest portion of the day helps your air conditioner. If you hang blinds or shades as close to the window as possible, they can stop outside heat from entering. Smart window treatment management can reduce heat gain by up to 77%.");
                }
                else
                {
                    Console.WriteLine("\n Just make sure you're not losing cool air. Seal gaps and add silicone or sealing to damaged doors to keep cold air in and warm air out.");
                }

                Console.WriteLine("\n NEXT?");
                Console.ReadKey();

                Console.Write("\n Do you clean your air conditioning filter? ");
                string yesornooo = Console.ReadLine();
                Console.WriteLine("\n You must clean your air conditioner filter since dirty filters might cause the system to work overtime. Daikin, an air conditioning company, as advises that replacing and cleaning your air conditioning filter is essential to a healthy, well-maintained system, which saves you money over time.");

                Console.WriteLine("\n NEXT?");
                Console.ReadKey();

                Console.Write("\n Do you often turn on and off your air conditioning throughout the day? ");
                string yesornoooo = Console.ReadLine();
                Console.WriteLine("\n Do not turn the air conditioner on and off a couple times a day because if we keep turning it on and off, it will be more power-consuming because the compressor will work at full capacity every time it is turned on. Instead, just turn it off when you will be gone for a long time, but do not turn it off when you will leave for just a minute and turn it on again immediately.");

                Console.WriteLine("\n NEXT?");
                Console.ReadKey();

                Console.Write("\n Do you use fan in your room? ");
                string yesornooooo = Console.ReadLine();
                Console.WriteLine("\n Use fans effectively to maximize cold air distribution from your AC, since they circulate air more efficiently, resulting in shorter cycles, lower energy use, and a longer lifespan of the AC unit. The fan helps you feel chilly because of the wind. But remember to turn off the fan when you don't need it and it's already cold in your room. ");

                Console.WriteLine("\n NEXT?");
                Console.ReadKey();

                Console.WriteLine("\n Lastly, it is very important to know that you should install the correct-size air conditioner based on your room size.");
                Console.WriteLine("Do not use an oversize air conditioner. Not only will you consume more energy, but you will also feel overly cold because a big air conditioner cannot adjust its cooling power to meet the room. So make sure you install the appropriate size air conditioner.");
                Console.ReadKey();

                Console.WriteLine("\n That would be all. Thank you for using our Air Conditioning Energy Calculator. I hope you learn from our tips.");
                Console.WriteLine("\n REFERENCE: Epifano, M., & Doidge, K. M. (2024, April 30). How to Use Your Air Conditioner Economically and Save on Your Electric Bill. Apartment Therapy. https://www.apartmenttherapy.com/10-ways-to-save-energy-when-ai-120022");

            }
            else
            {
                Console.WriteLine("Alright, thank you for using our Air Conditioning Energy Calculator. Have a great day!");
            }


        }
    }
}
