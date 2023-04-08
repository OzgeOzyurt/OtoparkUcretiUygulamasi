using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_2_Ozge_Ozyurt
{
    internal class Uygulama
    {
        public void Calistir()
        {


            Console.WriteLine("Merhaba, araba tipi ve kalınan saat bilgisi girildikten sonra ödenecek otopark ücretini hesaplayan programı kullanıyorsunuz.");
            Console.WriteLine();

            ArabaTipiAl();



        }



        public void ArabaTipiAl()
        {

            Console.WriteLine("Otomobil için 1'e basın.");
            Console.WriteLine("Minibüs için 2'ye basın.");
            Console.WriteLine("Ticari araç için 3'e basın.");
            Console.WriteLine();


            while (true)
            {


                try
                {

                    int secim;
                    Console.Write("Araba tipi giriniz: ");
                    string giris = Console.ReadLine();
                    if (int.TryParse(giris, out secim))
                    {
                        switch (giris)
                        {
                            case "1":

                                OtoSureAlipUcretHesapla(SureAl());
                                break;

                            case "2":
                                MiniSureAlipUcretHesapla(SureAl());
                                break;
                            case "3":
                                TicariSureAlipUcretHesapla(SureAl());
                                break;
                            default:
                                Console.WriteLine("Hatalı giriş yapıldı. Tekrar Deneyiniz.");
                                break;
                        }
                    }
                    else
                    {
                        throw new Exception("Hatalı giriş yapıldı. Tekrar Deneyiniz.");
                    }
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                }
            }
        }


        public int SureAl()
        {
            Console.WriteLine();

            while (true)
            {
                try
                {

                    int sure;
                    Console.Write("Arabanın otoparkta kaç saat kaldığını giriniz: ");
                    string giris = Console.ReadLine();
                    if (int.TryParse(giris, out sure))
                    {

                        return sure;

                    }
                    else
                    {
                        throw new Exception("Hatalı giriş yapıldı. Tekrar Deneyiniz.");
                    }
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                }
            }
        }


        public void OtoSureAlipUcretHesapla(int sure)
        {
            Console.WriteLine();

            double saatlikTutar = 20.5;
            double toplamTutar = 0;
            for (int i = 1; i <= sure; i++)
            {

                toplamTutar = toplamTutar + saatlikTutar + (toplamTutar * 20 / 100);
            }
            TutarYazdir(toplamTutar);
        }


        public void MiniSureAlipUcretHesapla(int sure)
        {
            Console.WriteLine();

            double saatlikTutar = 30.5;
            double toplamTutar = 0;

            for (int i = 1; i <= sure; i++)
            {

                toplamTutar = toplamTutar + saatlikTutar + (toplamTutar * 21.5 / 100);
            }
            TutarYazdir(toplamTutar);
        }

        public void TicariSureAlipUcretHesapla(int sure)
        {
            Console.WriteLine();

            double saatlikTutar = 45.5;
            double toplamTutar = 0;

            for (int i = 1; i <= sure; i++)
            {

                toplamTutar = toplamTutar + saatlikTutar + (toplamTutar * 25 / 100);
            }
            TutarYazdir(toplamTutar);
        }

        public void TutarYazdir(double toplam)
        {

            Console.WriteLine("Ödenecek tutar: " + toplam + " TL");
            Cikis();
        }


        public void Cikis()
        {
            Environment.Exit(0);
        }



    }
}
