using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akaryakıt_Projesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // DEĞİŞKEN TANIMLARI
            double dizel = 3.12, benzin = 3.28, lpg = 1.78;
            double dizeltank = 1000, benzintank = 1000, lpgtank = 1000;
            double satismiktari = 0;
            char anamenüsecim = '0', altmenusecim = '0', akaryakitfiyatgüncelle = '0', akaryakitsatistipi = '0';

        // ANA MENÜ OLUŞTURMA
        MENU:
            Console.WriteLine("Akaryakıt Satış takip");
            Console.WriteLine("......................");
            Console.WriteLine("1-Birim fiyatı göster");
            Console.WriteLine("2- Birim fiyatı güncelle");
            Console.WriteLine("3-Akaryakıt satışı yap");
            Console.WriteLine("4- Depo durumunu göster");
            Console.WriteLine("5-Toplam satışları göster");
            Console.WriteLine("6-Çıkış");

            Console.Write("Seçiminizi yapınız [1,2,3,4,5,6]");
            anamenüsecim = Convert.ToChar(Console.ReadLine());

            if (anamenüsecim == '1')
            {
                Console.Clear();
                Console.WriteLine("seçiminiz : 1");
                Console.WriteLine("Birim Fiyatlar Listesi");
                Console.WriteLine("Dizel(D): {0} TL/Litre", dizel);
                Console.WriteLine("Benzin(B): {0} TL/Litre", benzin);
                Console.WriteLine("Lpg(L): {0} TL/Litre", lpg);

            ALTMENU:
                Console.WriteLine("Seçiminizi yapınız [1 : Anamenüye dön , 2 : Porogramı kapat] ");
                altmenusecim = Convert.ToChar(Console.ReadLine());
                if (altmenusecim == '1')
                {
                    Console.Clear();
                    goto MENU;

                }

                else if (altmenusecim == '2')
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("1 ve 2 seçenekleri dışında Yanlış seçim yaptınız !!!");
                    goto ALTMENU;
                }

            }
            else if (anamenüsecim == '2')
            {
                Console.Clear();
                Console.WriteLine("seçiminiz :2");
                Console.WriteLine("Birim fiyatlar güncelleme");

            AKARYAKITTIPI:
                Console.WriteLine("Akarayakıt tipini seçiniz [D,B,L]");
                akaryakitfiyatgüncelle = Convert.ToChar(Console.ReadLine());
                if (akaryakitfiyatgüncelle == 'D' || akaryakitfiyatgüncelle == 'd')
                {
                    Console.WriteLine("Dizel(D): {0} TL/Litre", dizel);
                    Console.WriteLine("Dizel fiyat için yeni fiyat giriniz");
                    dizel = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Dizel(D): {0} TL/Litre", dizel);
                }
                else if (akaryakitfiyatgüncelle == 'B' || akaryakitfiyatgüncelle == 'b')
                {
                    Console.WriteLine("Benzin(B): {0} TL/Litre", benzin);
                    Console.WriteLine("Benzin fiyat için yeni fiyat giriniz");
                    benzin = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Benizn(B): {0} TL/Litre", benzin);

                }
                else if (akaryakitfiyatgüncelle == 'L' || akaryakitfiyatgüncelle == 'l')
                {
                    Console.WriteLine("Lpg(L): {0} TL/Litre", lpg);
                    Console.WriteLine("Lpg fiyat için yeni fiyat giriniz");
                    lpg = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Lpg(L): {0} TL/Litre", lpg);
                }
                else
                {
                    Console.WriteLine("D,B,L dışında hatalı seçim yaptınız");
                    goto AKARYAKITTIPI;
                }

            ALTMENU:
                Console.WriteLine("Seçiminizi yapınız [1 : Anamenüye dön , 2 : Porogramı kapat] ");
                altmenusecim = Convert.ToChar(Console.ReadLine());
                if (altmenusecim == '1')
                {
                    Console.Clear();
                    goto MENU;

                }

                else if (altmenusecim == '2')
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("1 ve 2 seçenekleri dışında Yanlış seçim yaptınız !!!");
                    goto ALTMENU;
                }
            }

            else if (anamenüsecim == '3')
            {
                Console.Clear();
                Console.WriteLine("seçimizniz 3");
                Console.WriteLine("Akaryakıt satış işlemleri");

            AKARYAKITSATISI:
                Console.WriteLine("Akaryakıt tipini seçiniz [D,B,L]");
                akaryakitsatistipi = Convert.ToChar(Console.ReadLine());

                if (akaryakitsatistipi == 'D' || akaryakitsatistipi == 'd')
                {
                    if (dizeltank == 0)
                    {
                        Console.WriteLine("yakıt tankında hiç dizel yakıt yok");
                        goto MENU;
                    }
                    else
                    {
                        Console.WriteLine("Ne kadarlık dizel yakıt alacaksınz ?");

                        satismiktari = Convert.ToDouble(Console.ReadLine());
                        if (dizeltank < satismiktari)
                        {
                            Console.WriteLine("Yakıt tankında {0} litre yakıt vardır ! işlem yapılamadı", dizeltank);
                            goto MENU;

                        }
                        else if (satismiktari <= dizeltank)
                        {
                            dizeltank = dizeltank - satismiktari;
                            Console.WriteLine("yakıt dolumu tamamlanmıştır");
                            Console.WriteLine("yakıt tankında {0} miktar yakıt kaldı.", dizeltank);
                        }
                    }

                }
                else if (akaryakitsatistipi == 'b' || akaryakitsatistipi == 'B')
                {
                    if (benzintank == 0)
                    {
                        Console.WriteLine("yakıt tankında hiç benzin yakıt yok");
                        goto MENU;
                    }
                    else
                    {
                        Console.WriteLine("Ne kadarlık benzin yakıt alacaksınz ?");

                        satismiktari = Convert.ToDouble(Console.ReadLine());
                        if (benzintank < satismiktari)
                        {
                            Console.WriteLine("Yakıt tankında {0} litre yakıt vardır ! işlem yapılamadı", benzintank);
                            goto MENU;

                        }
                        else if (satismiktari <= benzintank)
                        {
                            benzintank = benzintank - satismiktari;
                            Console.WriteLine("yakıt dolumu tamamlanmıştır");
                            Console.WriteLine("yakıt tankında {0} miktar yakıt kaldı.", benzintank);
                        }
                    }

                }



            

                    Console.ReadKey();
            }
        }
    }
}    




