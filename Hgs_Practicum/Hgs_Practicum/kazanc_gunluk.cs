using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hgs_Practicum
{
    class kazanc_gunluk
    {
        int toplamButce = 0;

        public void butce(Int64 hgsNo)
        {
            if (hgsNo == 1234567891)
            {
                toplamButce += 30;
            }
            else if (hgsNo == 1211456723)
            {
                toplamButce += 40;
            }
            else if (hgsNo == 469898064)
            {
                toplamButce += 50;
            }
        }

        public void Butce_sorgula()
        {
            Console.WriteLine("Gün içinde elde edilen bütçe: " + toplamButce);
        }
    }
}
