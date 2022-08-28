using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hgs_Practicum
{
    class Program
    {
        static void Main(string[] args)
        {
            Int64 num_hgs = 0;

            Hgs_Sayaci giris = new Hgs_Sayaci();
            kazanc_gunluk kazanc2 = new kazanc_gunluk();

            Arac otomobil = new Arac();
            Arac minibus = new Arac();
            Arac otobus = new Arac();

            otomobil.HgsNumarasi =1234567891;
            otomobil.isim = "Esra";
            otomobil.soyisim = "Ertsak";
            otomobil.arac_turu = "Otomobil";

            minibus.HgsNumarasi = 1211456723;
            minibus.isim = "Emir";
            minibus.soyisim = "Yılmaz";
            minibus.arac_turu = "Minibus";

            otobus.HgsNumarasi = 469898064;
            otobus.isim = "Hüseyin";
            otobus.soyisim = "Gözel";
            otobus.arac_turu = "Otobüs";


            while (true)
            {
                Console.WriteLine("Hgs ile geçecek olan aracı seçin:");
                Console.WriteLine("1-Otomobil \n2-Minibüs \n3-Otobüs \n4-Bütçeyi listele ");
                int secim = Convert.ToInt32(Console.ReadLine());
                if (secim == 1)
                {
                    Console.WriteLine("Araç sahibi:" + otomobil.isim + " " + otomobil.soyisim);
                    Console.WriteLine("Seçtiğiniz araç sınıfı otomobil ve hgs numarası: " + otomobil.HgsNumarasi);
                    num_hgs = otomobil.HgsNumarasi;
                    giris.Odeme(num_hgs);
                    kazanc2.butce(num_hgs);

                }
                else if (secim == 2)
                {
                    Console.WriteLine("Araç sahibinin ismi:" + minibus.isim + " " + minibus.soyisim);
                    Console.WriteLine("Seçtiğiniz araç türü minibüs ve hgs numarası: " + minibus.HgsNumarasi);
                    num_hgs = minibus.HgsNumarasi;
                    giris.Odeme(num_hgs);
                    kazanc2.butce(num_hgs);
                }
                else if (secim == 3)
                {
                    Console.WriteLine("Araç sahibi:" + otobus.isim + " " + otobus.soyisim);
                    Console.WriteLine("Seçtiğiniz araç sınıfı otobüs ve hgs numarası: " + otobus.HgsNumarasi);
                    num_hgs = otobus.HgsNumarasi;
                    giris.Odeme(num_hgs);
                    kazanc2.butce(num_hgs);

                }
                else
                {
                    kazanc2.Butce_sorgula();
                    num_hgs = 0;
                   

                }
            }

        }
    }
}
