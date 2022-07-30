using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konsol
{
    public static class sifreElemanlar
    {
        public static int buyukHarf(char[] charArray1)
        {
            int buyukHarfSayisi = 0;

            foreach (char ch in charArray1)
            {
                if (ch >= 'A' && ch <= 'Z') 
                {
                   buyukHarfSayisi++;
                }
            }

            return buyukHarfSayisi;
        }

        public static int kucukHarf (char[] charArray2)
        {
            int kucukHarfSayisi = 0;

            foreach (char ch in charArray2)
            {
                if (ch >= 'a' && ch <= 'z')
                {
                    kucukHarfSayisi++;
                }
            }

            return kucukHarfSayisi;
        }

        public static int rakam(char[] charArray3)
        {
            int rakamSayisi = 0;

            foreach (char ch in charArray3)
            {
                if(char.IsDigit(ch))
                {
                    rakamSayisi++;
                }
            }

            return rakamSayisi;
        }

        public static  int sembol(char[] charArray4)
        {
            int sembolSayisi = 0;

            foreach (char ch in charArray4)
            {
                if (!char.IsLetterOrDigit(ch)) 
                {
                    sembolSayisi++;
                }
            }

            return sembolSayisi;
        }

    }
}
