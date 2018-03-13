using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZIProjekat
{
    public class Knapsack : Algoritam
    {

        private int[] javniKjuc;
        private int[] privatniKljuc;
        private int m;
        private int n;
        private int im;

        public int[] JavniKjuc
        {
            get
            {
                return javniKjuc;
            }

            set
            {
                javniKjuc = value;
            }
        }

        public int[] PrivatniKljuc
        {
            get
            {
                return privatniKljuc;
            }

            set
            {
                privatniKljuc = value;
            }
        }

        public int M
        {
            get
            {
                return m;
            }

            set
            {
                m = value;
            }
        }

        public int N
        {
            get
            {
                return n;
            }

            set
            {
                n = value;
            }
        }

        public int Im
        {
            get
            {
                return im;
            }

            set
            {
                im = value;
            }
        }

        public Knapsack()
        {
            JavniKjuc = new int[8];
            PrivatniKljuc = new int[8];

        }

        public string Dekriptuj(string tekst)
        {
            String dekriptovanTekst = "";
            String[] reci = tekst.Split(' ');

            int vr;
            int TC;
            int[] dobijeno = new int[8];
            int MM;
            
            foreach(string rec in reci)
            {
                if (String.IsNullOrEmpty(rec))
                    continue;
                for (int i = 0; i < 8; i++)
                {
                    dobijeno[i] = 0;
                }
                vr = Convert.ToInt32(rec);
                TC = (vr * Im) % N;

                for (int j = 7; j > -1; j--)
                {

                    if (PrivatniKljuc[j] <= TC)
                    {
                        dobijeno[7-j] = 1;
                        TC = TC - PrivatniKljuc[j];
                    }

                }

                MM = ToDec(dobijeno);

                dekriptovanTekst += Convert.ToChar(MM);
            }

            return dekriptovanTekst;
        }

        public string Kriptuj(string tekst)
        {
            String kriptovanTekst = "";
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(tekst);

            int vr;
            int[] vrNiz;
            int C;
            foreach(byte b in inputBytes)
            {
                C = 0;
                vr = Convert.ToInt32(b);
                vrNiz = ToBin(vr);

                for (int i=0;i<8;i++)
                {
                    C += JavniKjuc[i] * vrNiz[7-i];
                }

                kriptovanTekst += C.ToString() + " ";
            }


            return kriptovanTekst;
        }

        public int[] ToBin(int broj)
        {
            int[] vrNiz = new int[8];
            for(int i=0; i<8;i++)
            {
                vrNiz[i] = 0;
            }

            int j = 7;
            if(broj> 128)
            {
                j = 7;
            }
            if(broj >= 64 && broj <128)
            {
                j = 6;
            }
            if(broj >= 32 && broj < 64)
            {
                j = 5;
            }
            if (broj >= 16 && broj < 32)
            {
                j = 4;
            }
            if (broj >= 8 && broj < 16)
            {
                j = 3;
            }
            if (broj >= 4 && broj < 8)
            {
                j = 2;
            }
            if (broj >= 2 && broj < 4)
            {
                j = 1;
            }
            if (broj == 1)
            {
                j = 0;
            }

            for(int k=0; k<j+1;k++)
            {
                vrNiz[k] = broj % 2;
                broj = broj / 2;
            }


            return vrNiz;
        }

        public int ToDec(int[] bin)
        {
            int dobijeno = 0;

            int mn = (int)Math.Pow(2, 7);

            for(int i=7;i>-1;i--)
            {
                dobijeno += mn * bin[i];
                mn = mn / 2;
            }

            return dobijeno;
        }


    }
}
