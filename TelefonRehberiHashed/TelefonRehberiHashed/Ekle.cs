using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonRehberiHashed
{
    class Ekle
    {
        public static void rehbereEkle(Kisi[] kisi, string aranan,int numara)
        {
            int asc,j=0;
            
            

                
                asc = (Convert.ToInt32(aranan[0])) % kisi.Length;
                Console.WriteLine("asc={0}", asc);
                if (kisi[asc].isim == null)
                {
                    kisi[asc].isim = aranan;
                    kisi[asc].no = numara;
                }
                else
                {
                    if ((asc + j) >= kisi.Length)
                    {
                        asc = 0;
                        j = 0;
                    }

                    while ((kisi[asc + j].isim) != null)
                    {

                        if ((asc + j + 1) >= kisi.Length)
                        {
                            asc = 0;
                            j = 0;
                        }
                        j++;
                    }
                    kisi[asc + j].isim = aranan;
                    kisi[asc + j].no = numara;
                    j = 1;
                }

            
        }
        
    }
}
