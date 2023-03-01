using System;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;

namespace _010323_NBUY
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Kullanıcı Giren Sayıları Toplayan ve 0'a basılınca duran program
            /*   int toplam = 0, x;

               while (true)
               {
                   Console.WriteLine("Bir Sayı Giriniz");

                   x = Convert.ToInt32((Console.ReadLine()));

                   if (x == 0)
                   {
                       break;
                   }
                   toplam += x;
               }

               Console.WriteLine("Toplam=" + toplam); */
            #endregion

            #region Girilen Sayıların Toplamı 100 olunca kaç sayı girildiğini yazma
            /*  int toplam = 0, i = 0;

              while (toplam < 100)

              {
                  Console.WriteLine("Bir Sayı Girin");
                  int sayi = Convert.ToInt32(Console.ReadLine());
                  i++;
                  toplam += sayi;


              }
              Console.WriteLine("Girilen Sayı Adeti" + " " + i); */
            #endregion

            #region İstenilen Sayıyı Kaç Denemede Bulunduğunu Hesaplama
            /*   Random random = new Random();
               int sayi = 0, adet = 0, sayacsayi = 0, sayacdongu = 0;
               int rnd;

               bool bl = true;

               Console.WriteLine("Bulunacak sayi:");
               sayi = Convert.ToInt32(Console.ReadLine());
               Console.WriteLine("Adet sayisi");
               adet = Convert.ToInt32(Console.ReadLine());

               while (bl)
               {

                   rnd = random.Next(0, 100);
                   sayacdongu++;
                   if (sayi == rnd)
                   {
                       sayacsayi++;
                       if (sayacsayi == adet)
                       {
                           bl = false;
                       }
                   }
               }

               Console.WriteLine("Üretilen toplam rasgele sayı:" + sayacdongu); */
            #endregion

            #region 1-10 arası rakamları do-while yazdırma
            /* int sayi = 1, x = 1;
             do
             {
                 Console.WriteLine(sayi);
                 sayi++;
                 x++;

             }
             while (x < 10);*/
            #endregion

            #region kullancı girdiği 10 sayıdan en büyük en küçük sayıyı yazdırma do-while
            /*  int sayi1, x = 0, enbuyuk = 0, enkucuk = 0;


              do
              {
                  Console.WriteLine("10 sayi gir:");
                  sayi1 = Convert.ToInt32(Console.ReadLine());

                  if (sayi1 < enkucuk)
                  {
                      enkucuk = sayi1;
                  }
                  if (sayi1 > enbuyuk)
                  {
                      enbuyuk = sayi1;
                  }
                  x++;

              }

              while (x < 10);
              Console.WriteLine("En Büyük" + " " + enbuyuk + "\n" + "En Küçük" + " " + enkucuk);*/
            #endregion

            #region klavyeden girilen 10 tane sayıdan en büyük ve en küçük sayıyı veren algoritma
            /* int enkucuksayi = 0, enbuyuksayi = 0;
             int counter = 0;
             do
             {
                 Console.Write("Bir değer giriniz :");
                 int value = Convert.ToInt32(Console.ReadLine());

                 if (value < enkucuksayi)
                 {
                     enkucuksayi = value;
                 }
                 if (value > enbuyuksayi)
                 {
                     enbuyuksayi = value;
                 }

                 counter++;

             } while (counter < 10);

             Console.WriteLine(enbuyuksayi + "  " + enkucuksayi);*/
            #endregion

            #region Kullanıcının girdiği 10 Sayıdan En Buyuk ve En Küçük Yazdırma
            /*  Console.WriteLine("");
              int i = 1, ek = 0, eb = 0;
              Console.WriteLine("sayı gir");
              int y = Convert.ToInt32(Console.ReadLine());
              ek = eb = y;
              do
              {
                  Console.WriteLine("sayı gir");

                  x = Convert.ToInt32(Console.ReadLine());

                  if (x < ek)
                      ek = x;
                  if (x > eb)
                      eb = x;
                  i++;
              } while (i < 11);
              Console.WriteLine(ek + " " + eb); */
            #endregion

            #region asal sayı hesaplama
            /* go:
                 Console.WriteLine("sayı gir");
                 int x = Convert.ToInt32(Console.ReadLine());
                 int i = 1, k = 0;
                 while (i < x)
                 {
                     if (x % i == 0)
                         k++;
                     i++;
                 }

                 if (k == 1)
                     Console.WriteLine("asal sayı ");
                 else if (k >= 1)
                     Console.WriteLine("asal  değil ");
                 else Console.WriteLine("hata");
                 Console.WriteLine();
                 goto go; */
            #endregion

            #region asal sayı hesaplama 2
            /* Console.WriteLine("sayı giriniz=");
             int x = Convert.ToInt32(Console.ReadLine());
             int kalan = 0;
             for (int i = x; i > 0; i--)
             {
                 if (x % i == 0)
                 {
                     kalan++;
                 }
             }
             if (kalan > 2)
             {
                 Console.WriteLine("asal değildir.");
             }
             else
                 Console.WriteLine("asaldır"); */
            #endregion

            #region girilen sayıdan daha asagıdakı asal sayıları bulma
            /*   Console.WriteLine("Sayı Gir");
               int x = Convert.ToInt32(Console.ReadLine());
               int i = 1, k = 0, y = 2;
               while (y <= x)
               {
                   i = 1; k = 0;
                   do
                   {
                       if (y % i == 0)
                           k++;
                       i++;
                   } while (i < y);
                   if (k == 1)
                   {
                       Console.WriteLine("asal sayi:" + y);
                   }
                   y++;

               } */
            #endregion

            #region girilen sayıdan daha kucuk asal sayıları bulma 2
            /*    Console.WriteLine("Sayı Gir");
                int sayi = Convert.ToInt32(Console.ReadLine());
                int sayac;

                for (int i = 1; i < sayi; i++)
                {
                    sayac = 0;
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            sayac++;
                        }
                    }
                    if (sayac == 0)
                    {
                        Console.WriteLine("Asal Sayi :" + i);
                    }
                } */
            #endregion

            #region ahmet hasan maas hesaplama
            /* int ahmet = 5000, hasan = 5000, ahmetzam = 0, hasanzam = 0;
             string isim;
             Console.WriteLine("calisan adı gir : ");
             isim = Console.ReadLine();
             isim = isim.ToLower();

             if (isim == "ahmet")
             {
                 Console.WriteLine("Kac ay hesaplanacak :");
                 int ay1 = Convert.ToInt32(Console.ReadLine());

                 for (int i = 1; i <= ay1; i++)
                 {
                     if (i % 2 == 0)
                     {
                         ahmet -= ahmet * 1 / 4;
                     }
                     else
                     {
                         ahmet += ahmet * 1 / 2;
                     }
                 }
                 ahmetzam = ahmet;
             }
             if (isim == "hasan")
             {
                 Console.WriteLine("Kac ay hesaplanacak :");
                 int ay2 = Convert.ToInt32(Console.ReadLine());

                 for (int i = 1; i <= ay2; i++)

                 {

                     hasan += hasan * 1 / 4;


                 }
                 hasanzam = hasan;
             }

             Console.WriteLine("ahmet maas : " + ahmetzam);
             Console.WriteLine("hasan maas : " + hasanzam); */
            #endregion

            #region ahmet-hasan maas hesabı farklı cozum
            /*double ahmetMaas = 5000;
            double hasanMaas = 5000;

            Console.Write("Kaç ayın ücretini hesaplamak istiyorsunuz: ");
            int aySayisi = Convert.ToInt16(Console.ReadLine());

            for (int ay = 1; ay <= aySayisi; ay++)
            {
                if (ay % 2 == 1)
                {
                    ahmetMaas = ahmetMaas * 1.5;
                }

                else
                {
                    ahmetMaas = ahmetMaas * 0.75;
                }

                hasanMaas = hasanMaas * 1.25;

                Console.WriteLine("{0}. Ay, Ahmetin maaşı {1}, Hasanın maaşı {2}", ay, ahmetMaas, hasanMaas);

            }

            if (ahmetMaas > hasanMaas)
            {
                Console.WriteLine("Ahmetin maaşı Hasanın maaşından fazladır");
            }
            else if (hasanMaas > ahmetMaas)
            {
                Console.WriteLine("Hasanın maaşı Ahmetin maaşından fazladır");
            }
            else
            {
                Console.WriteLine("Ahmetin maaşı ile Hasanın maaşı eşittir");
            } */
            #endregion

            #region 24.sndeki bakteri sayısı 12.sndeki bakteri sayısının kaç katıdır
            /*  int initialBacteriaCount = 16;
              int divisionTime = 2; // seconds
              int timeElapsed = 24; // seconds

              int bacteriaCount = initialBacteriaCount;
              for (int i = 0; i < 12; i++)
              {
                  bacteriaCount *= 2;
              }

              Console.WriteLine("Bacteria count at time {0} seconds: {1}", timeElapsed, bacteriaCount);

              bacteriaCount = initialBacteriaCount;
              for (int i = 0; i < 6; i++)
              {
                  bacteriaCount *= 2;
              }

              Console.WriteLine("Bacteria count at time {0} seconds: {1}", 12, bacteriaCount);

              int multiple = bacteriaCount == 0 ? 0 : bacteriaCount;
              for (int i = 0; i < (timeElapsed - 12) / divisionTime; i++)
              {
                  multiple *= 2;
              }
              Console.WriteLine("The bacteria count at time {0} seconds is {1} times the bacteria count at time {2} seconds.", timeElapsed, multiple / bacteriaCount, 12); */
            #endregion

            #region girilen saniyedeki bakteri sayısı 12.sndeki bakteri sayısının kaç katıdır
          /*  Console.WriteLine("Saniye Girin");
            int saniye = Convert.ToInt32(Console.ReadLine());
            int bakteri = 16;
            int bakteri1 = 16;
            int bakteri2 = 16;

            for (int i = 1; i <= saniye; i += 2)
            {
                bakteri = bakteri * 2;
                Console.WriteLine($"{i}.Saniyede Bakteri Sayısı={bakteri}");
                Console.WriteLine($"{i + 1}.Saniyede Bakteri Sayısı={bakteri}");

            }
            Console.WriteLine($"******************************************");


            for (int i = 1; i <= 12; i += 2)
            {
                bakteri2 = bakteri2 * 2;
            }

            for (int i = 1; i <= 24; i += 2)
            {
                bakteri2 = bakteri2 * 2;
            }

            int sonuc = bakteri2 / bakteri1;
            Console.WriteLine($"12.Saniyede Bakteri Sayısı = {bakteri1}");
            Console.WriteLine($"24.Saniyede Bakteri Sayısı = {bakteri2}");
            Console.WriteLine($"kat = {sonuc}"); */
            #endregion



        }
    }
}
