using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hgs_Practicum
{
    class Hgs_Sayaci
    {
        public int otomobil_ucreti = 30;
        public int minibus_ucreti = 40;
        public int otobus_ucreti = 50;

        public int otomobil_butce_yeni = 2000;
        public int minibus_butce_yeni = 4500;
        public int otobus_butce_yeni = 3900;

        ArrayList Araclar_dizisi = new ArrayList();

        public void Odeme(Int64 hgsNo)
        {
            Arac otomobil = new Arac();
            Arac minibus = new Arac();
            Arac otobus = new Arac();

            otomobil.bakiye = otomobil_butce_yeni;
            minibus.bakiye = minibus_butce_yeni;
            otobus.bakiye = otobus_butce_yeni;

            if (hgsNo == 1234567891)
            {
                otomobil_butce_yeni -= otomobil_ucreti;
                otomobil.bakiye = otomobil_butce_yeni;
                Console.WriteLine("Arabanın geçiş yaptığı tarih ve saat: " + DateTime.Now + " ve güncel bakiye: " + otomobil.bakiye);
            }
            else if (hgsNo == 1211456723)
            {
                minibus_butce_yeni -= minibus_ucreti;
                minibus.bakiye = minibus_butce_yeni;
                Console.WriteLine("Minibüsün geçiş yaptığı tarih ve saat: " + DateTime.Now + " ve güncel bakiye: " + minibus.bakiye);
            }
            else if (hgsNo == 469898064)
            {
                otobus_butce_yeni -= otobus_ucreti;
                otobus.bakiye = otobus_butce_yeni;
                Console.WriteLine("Otobüsün geçiş yaptığı tarih ve saat: " + DateTime.Now + " ve güncel bakiye: " + otobus.bakiye);
            }


            Araclar_dizisi.Add(hgsNo);
        }


    }
}
