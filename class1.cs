using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finalproj
{
    internal class class1
    {
        public static void Call(int typeofac, int howmanyhours, int howmanydays, int howmanyweeksamonth)
        {
           
            switch (typeofac)
            {
                case 1:

                    Console.WriteLine("\nWattage is 5,200");
                    double kwhperhour = 5.2;

                    double kwhperday = (5.2 * howmanyhours);

                    double kwhperweek = kwhperday * howmanydays;

                    double kwhpermonth = kwhperweek * howmanyweeksamonth;




                    double cph = kwhperhour * 9;
                    Console.WriteLine($"Cost per hour  = {cph} PHP");

                    double cpd = kwhperday * 9;
                    Console.WriteLine($"Cost per day   = {cpd} PHP");

                    double cpw = kwhperweek * 9;
                    Console.WriteLine($"Cost per week  = {cpw}  PHP");

                    double cpm = kwhpermonth * 9;
                    Console.WriteLine($"Cost per month = {cpm}  PHP");

                    break;

                case 2:

                    Console.WriteLine("\nWattage is 2,700");
                    double kwperhour = 2.7;

                    double kwperday = 2.7 * howmanyhours;

                    double kwperweek = kwperday * howmanydays;

                    double kwpermonth = kwperweek * howmanyweeksamonth;


                    double cphh = kwperhour * 9;
                    Console.WriteLine($"Cost per hour  = {cphh} PHP");

                    double cpdd = kwperday * 9;
                    Console.WriteLine($"Cost per day   = {cpdd} PHP");

                    double cpww = kwperweek * 9;
                    Console.WriteLine($"Cost per week  = {cpww}  PHP");

                    double cpmm = kwpermonth * 9;
                    Console.WriteLine($"Cost per month = {cpmm}  PHP");

                    break;

                case 3:

                    Console.WriteLine("\nWattage is 3,950");
                    double kwperhoura = 3.95;

                    double kwperdaya = 3.95 * howmanyhours;

                    double kwperweeka = kwperdaya * howmanydays;

                    double kwpermontha = kwperweeka * howmanyweeksamonth;


                    double cpha = kwperhoura * 9;
                    
                    Console.WriteLine($"Cost per hour  = {cpha} PHP");

                    double cpda = kwperdaya * 9;
                    Console.WriteLine($"Cost per day   = {cpda} PHP");

                    double cpwa = kwperweeka * 9;
                    Console.WriteLine($"Cost per week  = {cpwa}  PHP");

                    double cpma = kwpermontha * 9;
                    Console.WriteLine($"Cost per month = {cpma}  PHP");

                    break;

                case 4:

                    Console.WriteLine("\nWattage is 800");
                    double kwperhourb = 0.8;

                    double kwperdayb = 0.8 * howmanyhours;

                    double kwperweekb = kwperdayb * howmanydays;

                    double kwpermonthb = kwperweekb * howmanyweeksamonth;


                    double cphb = kwperhourb * 9;
                    Console.WriteLine($"Cost per hour  = {cphb} PHP");

                    double cpdb = kwperdayb * 9;
                    Console.WriteLine($"Cost per day   = {cpdb} PHP");

                    double cpwb = kwperweekb * 9;
                    Console.WriteLine($"Cost per week  = {cpwb}  PHP");

                    double cpmb = kwpermonthb * 9;
                    Console.WriteLine($"Cost per month = {cpmb}  PHP");

                    break;

                case 5:

                    Console.WriteLine("\nWattage is 1,100");
                    double kwperhourc = 1.1;

                    double kwperdayc = 1.1 * howmanyhours;

                    double kwperweekc = kwperdayc * howmanydays;

                    double kwpermonthc = kwperweekc * howmanyweeksamonth;


                    double cphc = kwperhourc * 9;
                    Console.WriteLine($"Cost per hour  = {cphc} PHP");

                    double cpdc = kwperdayc * 9;
                    Console.WriteLine($"Cost per day   = {cpdc} PHP");

                    double cpwc = kwperweekc * 9;
                    Console.WriteLine($"Cost per week  = {cpwc}  PHP");

                    double cpmc = kwpermonthc * 9;
                    Console.WriteLine($"Cost per month = {cpmc}  PHP");

                    break;

                case 6:

                    Console.WriteLine("\nWattage is 1,500");
                    double kwperhourd = 1.5;

                    double kwperdayd = 1.5 * howmanyhours;

                    double kwperweekd = kwperdayd * howmanydays;

                    double kwpermonthd = kwperweekd * howmanyweeksamonth;


                    double cphd = kwperhourd * 9;
                    Console.WriteLine($"Cost per hour  = {cphd} PHP");

                    double cpddd = kwperdayd * 9;
                    Console.WriteLine($"Cost per day   = {cpddd} PHP");

                    double cpwd = kwperweekd * 9;
                    Console.WriteLine($"Cost per week  = {cpwd}  PHP");

                    double cpmd = kwpermonthd * 9;
                    Console.WriteLine($"Cost per month = {cpmd}  PHP");

                    break;

                case 7:

                    Console.WriteLine("\nWattage is 2,100");
                    double kwperhoure = 2.1;

                    double kwperdaye = 2.1 * howmanyhours;

                    double kwperweeke = kwperdaye * howmanydays;

                    double kwpermonthe = kwperweeke * howmanyweeksamonth;


                    double cphe = kwperhoure * 9;
                    Console.WriteLine($"Cost per hour  = {cphe} PHP");

                    double cpde = kwperdaye * 9;
                    Console.WriteLine($"Cost per day   = {cpde} PHP");

                    double cpwe = kwperweeke * 9;
                    Console.WriteLine($"Cost per hours = {cpwe}  PHP");

                    double cpme = kwpermonthe * 9;
                    Console.WriteLine($"Cost per month = {cpme}  PHP");

                    break;

                case 8:

                    Console.WriteLine("\nWattage is 1,000");
                    double kwperhourf = 1;

                    double kwperdayf = 1 * howmanyhours;

                    double kwperweekf = kwperdayf * howmanydays;

                    double kwpermonthf = kwperweekf * howmanyweeksamonth;


                    double cphf = kwperhourf * 9;
                    Console.WriteLine($"Cost per hour  = {cphf} PHP");

                    double cpdf = kwperdayf * 9;
                    Console.WriteLine($"Cost per day   = {cpdf} PHP");

                    double cpwf = kwperweekf * 9;
                    Console.WriteLine($"Cost per week  = {cpwf}  PHP");

                    double cpmf = kwpermonthf * 9;
                    Console.WriteLine($"Cost per month = {cpmf}  PHP");

                    break;

                case 9:

                    Console.WriteLine("\nWattage is 1,500");
                    double kwperhourg = 1.5;

                    double kwperdayg = 1.5 * howmanyhours;

                    double kwperweekg = kwperdayg * howmanydays;

                    double kwpermonthg = kwperweekg * howmanyweeksamonth;


                    double cphg = kwperhourg * 9;
                    Console.WriteLine($"Cost per hour  = {cphg} PHP");

                    double cpdg = kwperdayg * 9;
                    Console.WriteLine($"Cost per day   = {cpdg} PHP");

                    double cpwg = kwperweekg * 9;
                    Console.WriteLine($"Cost per week  = {cpwg}  PHP");

                    double cpmg = kwpermonthg * 9;
                    Console.WriteLine($"Cost per month = {cpmg}  PHP");

                    break;

                case 10:

                    Console.WriteLine("\nWattage is 1,800");
                    double kwperhourh = 1.8;

                    double kwperdayh = 1.8 * howmanyhours;

                    double kwperweekh = kwperdayh * howmanydays;

                    double kwpermonthh = kwperweekh * howmanyweeksamonth;


                    double cphhh = kwperhourh * 9;
                    Console.WriteLine($"Cost per hour  = {cphhh} PHP");

                    double cpdh = kwperdayh * 9;
                    Console.WriteLine($"Cost per day   = {cpdh} PHP");

                    double cpwh = kwperweekh * 9;
                    Console.WriteLine($"Cost per week  = {cpwh}  PHP");

                    double cpmh = kwpermonthh * 9;
                    Console.WriteLine($"Cost per month = {cpmh}  PHP");

                    break;

                case 11:

                    Console.WriteLine("\nWattage is 2,300");
                    double kwperhouri = 2.3;

                    double kwperdayi = 2.3 * howmanyhours;

                    double kwperweeki = kwperdayi * howmanydays;

                    double kwpermonthi = kwperweeki * howmanyweeksamonth;


                    double cphi = kwperhouri * 9;
                    Console.WriteLine($"Cost per hour  = {cphi} PHP");

                    double cpdi = kwperdayi * 9; 
                    Console.WriteLine($"Cost per day   = {cpdi} PHP");

                    double cpwi = kwperweeki * 9;
                    Console.WriteLine($"Cost per week  = {cpwi}  PHP");

                    double cpmi = kwpermonthi * 9;
                    Console.WriteLine($"Cost per month = {cpmi}  PHP");

                    break;

                case 12:

                    Console.WriteLine("\nWattage is 2,400");
                    double kwperhourj = 2.4;

                    double kwperdayj = 2.4 * howmanyhours;

                    double kwperweekj = kwperdayj * howmanydays;

                    double kwpermonthj = kwperweekj * howmanyweeksamonth;


                    double cphj = kwperhourj * 9;
                    Console.WriteLine($"Cost per hour  = {cphj} PHP");

                    double cpdj = kwperdayj * 9;
                    Console.WriteLine($"Cost per day   = {cpdj} PHP");

                    double cpwj = kwperweekj * 9;
                    Console.WriteLine($"Cost per week  = {cpwj}  PHP");

                    double cpmj = kwpermonthj * 9;
                    Console.WriteLine($"Cost per month = {cpmj}  PHP");

                    break;

                case 13:

                    Console.WriteLine("\nWattage is 760");
                    double kwperhourk = 0.76;

                    double kwperdayk = 0.76 * howmanyhours;

                    double kwperweekk = kwperdayk * howmanydays;

                    double kwpermonthk = kwperweekk * howmanyweeksamonth;


                    double cphk = kwperhourk * 9;
                    Console.WriteLine($"Cost per hour  = {cphk} PHP");

                    double cpdk = kwperdayk * 9;
                    Console.WriteLine($"Cost per day   = {cpdk} PHP");

                    double cpwk = kwperweekk * 9;
                    Console.WriteLine($"Cost per week  = {cpwk}  PHP");

                    double cpmk = kwpermonthk * 9;
                    Console.WriteLine($"Cost per month = {cpmk}  PHP");

                    break;

                case 14:

                    Console.WriteLine("\nWattage is 1000");
                    double kwperhourl = 1;

                    double kwperdayl = 1 * howmanyhours;

                    double kwperweekl = kwperdayl * howmanydays;

                    double kwpermonthl = kwperweekl * howmanyweeksamonth;


                    double cphl = kwperhourl * 9;
                    Console.WriteLine($"Cost per hour  = {cphl} PHP");

                    double cpdl = kwperdayl * 9;
                    Console.WriteLine($"Cost per day   = {cpdl} PHP");

                    double cpwl = kwperweekl * 9;
                    Console.WriteLine($"Cost per week  = {cpwl}  PHP");

                    double cpml = kwpermonthl * 9;
                    Console.WriteLine($"Cost per month = {cpml}  PHP");

                    break;

                case 15:

                    Console.WriteLine("\nWattage is 1,400");
                    double kwperhourm = 1.4;

                    double kwperdaym = 1.4 * howmanyhours;

                    double kwperweekm = kwperdaym * howmanydays;

                    double kwpermonthm = kwperweekm * howmanyweeksamonth;


                    double cphm = kwperhourm * 9;
                    Console.WriteLine($"Cost per hour  = {cphm} PHP");

                    double cpdm = kwperdaym * 9;
                    Console.WriteLine($"Cost per day   = {cpdm} PHP");

                    double cpwm = kwperweekm * 9;
                    Console.WriteLine($"Cost per week  = {cpwm}  PHP");

                    double cpmmm = kwpermonthm * 9;
                    Console.WriteLine($"Cost per month = {cpmmm}  PHP");

                    break;

                case 16:

                    Console.WriteLine("\nWattage is 2,000");
                    double kwperhourn = 2;

                    double kwperdayn = 2 * howmanyhours;

                    double kwperweekn = kwperdayn * howmanydays;

                    double kwpermonthn = kwperweekn * howmanyweeksamonth;


                    double cphn = kwperhourn * 9;
                    Console.WriteLine($"Cost per hour  = {cphn} PHP");

                    double cpdn = kwperdayn * 9;
                    Console.WriteLine($"Cost per day   = {cpdn} PHP");

                    double cpwn = kwperweekn * 9;
                    Console.WriteLine($"Cost per week  = {cpwn}  PHP");

                    double cpmn = kwpermonthn * 9;
                    Console.WriteLine($"Cost per month = {cpmn}  PHP");

                    break;

                case 17:

                    Console.WriteLine("\nWattage is 568");
                    double kwperhouro = 0.568;

                    double kwperdayo = 0.568 * howmanyhours;

                    double kwperweeko = kwperdayo * howmanydays;

                    double kwpermontho = kwperweeko * howmanyweeksamonth;


                    double cpho = kwperhouro * 9;
                    Console.WriteLine($"Cost per hour  = {cpho} PHP");

                    double cpdo = kwperdayo * 9;
                    Console.WriteLine($"Cost per day   = {cpdo} PHP");

                    double cpwo = kwperweeko * 9;
                    Console.WriteLine($"Cost per week  = {cpwo}  PHP");

                    double cpmo = kwpermontho * 9;
                    Console.WriteLine($"Cost per month = {cpmo}  PHP");

                    break;

                case 18:

                    Console.WriteLine("\nWattage is 652");
                    double kwperhourp = 0.652;

                    double kwperdayp = 0.652 * howmanyhours;

                    double kwperweekp = kwperdayp * howmanydays;

                    double kwpermonthp = kwperweekp * howmanyweeksamonth;


                    double cphp = kwperhourp * 9;
                    Console.WriteLine($"Cost per hour  = {cphp} PHP");

                    double cpdp = kwperdayp * 9;
                    Console.WriteLine($"Cost per day   = {cpdp} PHP");

                    double cpwp = kwperweekp * 9;
                    Console.WriteLine($"Cost per week  = {cpwp}  PHP");

                    double cpmp = kwpermonthp * 9;
                    Console.WriteLine($"Cost per month = {cpmp}  PHP");

                    break;

                case 19:

                    Console.WriteLine("\nWattage is 727");
                    double kwperhourq = 0.727;

                    double kwperdayq = 0.727 * howmanyhours;

                    double kwperweekq = kwperdayq * howmanydays;

                    double kwpermonthq = kwperweekq * howmanyweeksamonth;


                    double cphq = kwperhourq * 9;
                    Console.WriteLine($"Cost per hour  = {cphq} PHP");

                    double cpdq = kwperdayq * 9;
                    Console.WriteLine($"Cost per day   = {cpdq} PHP");

                    double cpwq = kwperweekq * 9;
                    Console.WriteLine($"Cost per week  = {cpwq}  PHP");

                    double cpmq = kwpermonthq * 9;
                    Console.WriteLine($"Cost per month = {cpmq}  PHP");

                    break;

                case 20:

                    Console.WriteLine("\nWattage is 748");
                    double kwperhourr = 0.748;

                    double kwperdayr = 0.748 * howmanyhours;

                    double kwperweekr = kwperdayr * howmanydays;

                    double kwpermonthr = kwperweekr * howmanyweeksamonth;


                    double cphr = kwperhourr * 9;
                    Console.WriteLine($"Cost per hour  = {cphr} PHP");

                    double cpdr = kwperdayr * 9;
                    Console.WriteLine($"Cost per day   = {cpdr} PHP");

                    double cpwr = kwperweekr * 9;
                    Console.WriteLine($"Cost per week  = {cpwr}  PHP");

                    double cpmr = kwpermonthr * 9;
                    Console.WriteLine($"Cost per month = {cpmr}  PHP");

                    break;

                case 21:

                    Console.WriteLine("\nWattage is 944");
                    double kwperhours = 0.944;

                    double kwperdays = 0.944 * howmanyhours;

                    double kwperweeks = kwperdays * howmanydays;

                    double kwpermonths = kwperweeks * howmanyweeksamonth;


                    double cphs = kwperhours * 9;
                    Console.WriteLine($"Cost per hour  = {cphs} PHP");

                    double cpds = kwperdays * 9;
                    Console.WriteLine($"Cost per day   = {cpds} PHP");

                    double cpws = kwperweeks * 9;
                    Console.WriteLine($"Cost per week  = {cpws}  PHP");

                    double cpms = kwpermonths * 9;
                    Console.WriteLine($"Cost per month = {cpms}  PHP");

                    break;

                case 22:

                    Console.WriteLine("\nWattage is 1,300");
                    double kwperhourt = 1.3;

                    double kwperdayt = 1.3 * howmanyhours;

                    double kwperweekt = kwperdayt * howmanydays;

                    double kwpermontht = kwperweekt * howmanyweeksamonth;


                    double cpht = kwperhourt * 9;
                    Console.WriteLine($"Cost per hour  = {cpht} PHP");

                    double cpdt = kwperdayt * 9;
                    Console.WriteLine($"Cost per day   = {cpdt} PHP");

                    double cpwt = kwperweekt * 9;
                    Console.WriteLine($"Cost per week  = {cpwt}  PHP");

                    double cpmt = kwpermontht * 9;
                    Console.WriteLine($"Cost per month = {cpmt}  PHP");

                    break;

                case 23:

                    Console.WriteLine("\nWattage is 1,913");
                    double kwperhouru = 1.913;

                    double kwperdayu = 1.913 * howmanyhours;

                    double kwperweeku = kwperdayu * howmanydays;

                    double kwpermonthu = kwperweeku * howmanyweeksamonth;


                    double cphu = kwperhouru * 9;
                    Console.WriteLine($"Cost per hour  = {cphu} PHP");

                    double cpdu = kwperdayu * 9;
                    Console.WriteLine($"Cost per day   = {cpdu} PHP");

                    double cpwu = kwperweeku * 9;
                    Console.WriteLine($"Cost per week  = {cpwu}  PHP");

                    double cpmu = kwpermonthu * 9;
                    Console.WriteLine($"Cost per month = {cpmu}  PHP");


                    break;

                case 24:

                    Console.WriteLine("\nWattage is 2,664");
                    double kwperhourv = 2.664;

                    double kwperdayv = 2.664 * howmanyhours;

                    double kwperweekv = kwperdayv * howmanydays;

                    double kwpermonthv = kwperweekv * howmanyweeksamonth;


                    double cphv = kwperhourv * 9;
                    Console.WriteLine($"Cost per hour  = {cphv} PHP");

                    double cpdv = kwperdayv * 9;
                    Console.WriteLine($"Cost per day   = {cpdv} PHP");

                    double cpwv = kwperweekv * 9;
                    Console.WriteLine($"Cost per week  = {cpwv}  PHP");

                    double cpmv = kwpermonthv * 9;
                    Console.WriteLine($"Cost per month = {cpmv}  PHP");

                    break;
            }

        }
    }
}
