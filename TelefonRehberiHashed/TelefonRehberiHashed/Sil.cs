using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonRehberiHashed
{
    class Sil
    {
        public static void rehberdenSil(Kisi[] kisi, string aranan)
        {
            int id = Convert.ToInt32(aranan[0]) % kisi.Length;
            int j = 0,flag=0;
            if (kisi[id].isim == aranan)
            {
                flag = 1;
                Console.WriteLine("{0} Adlı kişinin telefon numarası: {1}", aranan, kisi[id].no);
                kisi[id + j].no = 0;
                kisi[id + j].isim = null;
                Console.WriteLine("Kişi başarıyla silindi");
            }
            else
            {
                j = 0;
                for (int i = 0; i < kisi.Length; i++)
                {
                    if (id + j >= kisi.Length)
                    {
                        id = 0;
                        j = 0;
                    }

                    if (kisi[id + j].isim == aranan)
                    {
                        flag = 1;
                        Console.WriteLine("{0} Adlı kişinin telefon numarası: {1}", aranan, kisi[id + j].no);
                        kisi[id + j].no = 0;
                        kisi[id + j].isim = null;
                        Console.WriteLine("Kişi başarıyla silindi");
                        break;
                    }
                    j++;
                }
                if (flag == 0)
                {
                    Console.WriteLine("Aranan isimde bir kayıt bulunmamaktadır.");
                }
                
            }
            Console.WriteLine("Silinik Liste");
            for (int i = 0; i < kisi.Length; i++)
            {
                Console.WriteLine("({0})-" + kisi[i].isim, i);
            }
        }
    }
}
