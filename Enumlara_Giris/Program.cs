using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumlara_Giris
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gunler gun = Gunler.pazartesi;

            if(gun == Gunler.pazartesi)
            {
                Console.WriteLine("Gün Pazartesidir");
            }
            else if(gun == Gunler.salı)
            {
                Console.WriteLine("Gün Salıdır.");
            }
            else if(gun == Gunler.çarşamba)
            {
                Console.WriteLine("Gün Çarşambadır.");
            }
            else if(gun == Gunler.perşembe)
            {
                Console.WriteLine("Gün Perşembedir.");
            }
            else if(gun == Gunler.cuma)
            {
                 Console.WriteLine("Gün Cumadır");
            }
            else if (gun == Gunler.cumartesi)
            {
                Console.WriteLine("Gün Cumartesidir");
            }
            else if (gun == Gunler.pazar)
            {
                Console.WriteLine("Gün Pazartesidir");
            }
        }
    }
}
