using System;

namespace konsol
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.Title = "Sifre Güvenlik Testi";

            string sifre = "";

            Console.WriteLine("----------SIFRE GUVENLIK TESTI----------");

            Console.Write("Sifre Giriniz :");

            sifre = Console.ReadLine();

            char[] charArray;

            string bosluk = "";

            int karakterSayisi = 0;

            bool kontrol = true;

            int sifrePuan = 0;

            do
            {
                charArray = sifre.ToCharArray();
              
                foreach (char ch in charArray)
                {
                    if (ch == ' ')
                    {
                        bosluk = "var";
                    }

                    karakterSayisi++;
                }

                if (bosluk == "var")
                {
                    Console.WriteLine("Bosluk iceren sifre girdiniz. Lutfen tekrar deneyiniz :");

                    sifre = Console.ReadLine();

                    bosluk = "yok";
                }
                else if (karakterSayisi < 9)
                {
                    Console.WriteLine("Karakter sayisi 9 ve ustu olmalidir. Lutfen tekrar deneyiniz :");

                    sifre = Console.ReadLine();

                    karakterSayisi = 0;
                }
                else if (karakterSayisi == 9)
                {
                    sifrePuan += 10;
                }
                else if (9 <= karakterSayisi)
                {
                    if (sifreElemanlar.buyukHarf(charArray) == 0 || sifreElemanlar.kucukHarf(charArray) == 0 || sifreElemanlar.rakam(charArray) == 0 || sifreElemanlar.sembol(charArray) == 0) 
                    {
                        Console.WriteLine("En az birer adet küçük harf, büyük harf, rakam ve sembol içermelidir. Lutfen tekrar deneyiniz :");

                        sifre = Console.ReadLine();

                        karakterSayisi = 0;
                        sifrePuan = 0;
                    }
                    else
                    {
                        kontrol = false;
                    }
                }
                else
                {
                    kontrol = false;
                }

                
            } while (kontrol);

            int buyuk = sifreElemanlar.buyukHarf(charArray);
            int kucuk = sifreElemanlar.kucukHarf(charArray);
            int rakam = sifreElemanlar.rakam(charArray);
            int sembol = sifreElemanlar.sembol(charArray);

            if (buyuk > 2) 
            {
                sifrePuan += 20;
            }
            else
            {
                sifrePuan += buyuk * 10;
            }

            if (kucuk > 2)
            {
                sifrePuan += 20;
            }
            else
            {
                sifrePuan += kucuk * 10;
            }

            if (rakam > 2)
            {
                sifrePuan += 20;
            }
            else
            {
                sifrePuan += rakam * 10;
            }

            if (sembol > 0)
            {
                sifrePuan += sembol * 10;
            }

            Console.WriteLine("----------------------------------------");

            if (sifrePuan < 70)
            {
                Console.WriteLine("Guvenlik puanınız:" + sifrePuan);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sifrenizin guvenligi zayif, kabul edilemez.");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (70 <= sifrePuan && sifrePuan < 90)  
            {
                Console.WriteLine("Guvenlik puanınız:" + sifrePuan);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Sifrenizin guvenligi orta, kabul edilebilir.");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (90 <= sifrePuan)
            {
                Console.WriteLine("Guvenlik puanınız:" + sifrePuan);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Sifrenizin guvenligi guclu, kabul edilebilir.");
                Console.ForegroundColor = ConsoleColor.White;
            }

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Buyuk harf sayisi :" + buyuk);
            Console.WriteLine("Kucuk harf sayisi :" + kucuk); 
            Console.WriteLine("Rakam sayisi :" + rakam);
            Console.WriteLine("Sembol sayisi :" + sembol);

        }
    }
}
