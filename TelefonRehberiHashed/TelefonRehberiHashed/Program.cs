using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonRehberiHashed
{
    

    class Program
    {
        
        


        public static void Main(string[] args)
        {
            String ism,kontrol="d",aranan;
            int no,asc,j=1,ekleNo;
            Kisi[] rehber = new Kisi[4]; //hocam ödevi test ederken bu değeri azaltabilirsiniz..
            

            for (int i = 0; i < rehber.Length; i++)
            {
                rehber[i] = new Kisi();
                rehber[i].isim = null;
                rehber[i].no = 0;
            }
            for (int i = 0; i < rehber.Length; i++)
            {
                
                Console.WriteLine("{0}. Kisinin adini giriniz: ",i);
                ism=Console.ReadLine();
                Console.WriteLine("{0}. Kisinin telefon numarasini giriniz: ", i);
                no=Convert.ToInt32(Console.ReadLine());
                asc = (Convert.ToInt32(ism[0]))%rehber.Length;
                Console.WriteLine("asc={0}", asc);
                if (rehber[asc].isim==null)
                {
                    rehber[asc].isim = ism;
                    rehber[asc].no = no;
                }
                else
                {
                    if((asc + j)>=rehber.Length)
                    {
                        asc = 0;
                        j = 0;
                    }

                    while ((rehber[asc+j].isim)!=null)
                    {
                        
                        if ((asc + j + 1) >= rehber.Length)
                        {
                            asc = 0;
                            j = 0;
                        }
                        j++;
                    }
                    rehber[asc+j].isim = ism;
                    rehber[asc+j].no = no;
                    j = 1;
                }
                
            }
            



            while(kontrol!="*")
            {
                Console.WriteLine("Komutlar: \nprogramı kapat:* \nlisteden sil:- \n listeye ekle:+ \n listeden bul:b\n listeyi yazdırmak için:y");
                kontrol = Console.ReadLine();
                if (kontrol=="*")
                {
                    break;
                }
                else if (kontrol=="-")
                {
                    Console.WriteLine("rehberden silmek istediginiz ismi giriniz");
                    aranan = Console.ReadLine();
                    Sil.rehberdenSil(rehber, aranan);
                }
                else if (kontrol == "+")
                {
                    Console.WriteLine("rehbere eklemek istediginiz ismi yu girin");
                    aranan = Console.ReadLine();
                    Console.WriteLine("rehbere eklemek istediginiz no yu girin");
                    ekleNo = Convert.ToInt32(Console.ReadLine());
                    Ekle.rehbereEkle(rehber,aranan, ekleNo);

                }
                else if (kontrol == "b")
                {
                    Console.WriteLine("rehberde bulmak istediginiz ismi giriniz");
                    aranan = Console.ReadLine();
                    Bul.rehberBul(rehber, aranan);
                }
                else if (kontrol == "y")
                {
                    Console.WriteLine("Hashli Liste");
                    for (int i = 0; i < rehber.Length; i++)
                    {
                        Console.WriteLine("({0})-" + rehber[i].isim, i);
                    }
                }
                else if (kontrol == "*")
                {
                    break;
                }
            }
            
            Console.ReadKey();
        }
    }
}
