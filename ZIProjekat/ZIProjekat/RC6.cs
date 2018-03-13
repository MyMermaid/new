using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ZIProjekat
{

    public class RC6 : Algoritam
    {

        byte[] key;

        public RC6()
        {
        }

    
        public void GenerisiKljuc(byte[] input)
        {
            key = new byte[input.Length];
            for(int i=0; i<input.Length; i++)
            {
                key[i] = input[i];
            }
        }

        public byte[] Enc(byte[] inp)
        {
            byte[] outputText = encrypt(inp, key);
            return outputText;
        }
        public byte[] Dec(byte[] inp)
        {
            byte[] outputText = decrypt(inp, key);
            return outputText;
        }

        public string Dekriptuj(string tekst)
        {
            String dekriptovanTekst = "";

            byte[] inputText = GetBytes(tekst);

            byte[] outputText = decrypt(inputText, key);

            dekriptovanTekst = GetString(outputText);

            return dekriptovanTekst;
        }

        public string Kriptuj(string tekst)
        {
            String kriptovanTekst = "";


            byte[] inputText = GetBytes(tekst);
            //byte[] inp = ASCIIEncoding.ASCII.GetBytes(tekst);
            byte[] outputText = encrypt(inputText, key);

            kriptovanTekst = GetString(outputText);


            return kriptovanTekst;
        }


        private static int w = 32, r = 20;

        private static int Pw = unchecked((int)0xb7e15163), Qw = unchecked((int)0x9e3779b9);

        private static int[] S;

        private static int[] convBytesWords(byte[] key, int u, int c)
        {
            int[] tmp = new int[c];
            for (int i = 0; i < tmp.Length; i++)
                tmp[i] = 0;

            for (int i = 0, off = 0; i < c; i++)
                tmp[i] = ((key[off++] & 0xFF)) | ((key[off++] & 0xFF) << 8)
                        | ((key[off++] & 0xFF) << 16) | ((key[off++] & 0xFF) << 24);

            return tmp;
        }

        private static int[] generateSubkeys(byte[] key)
        {

            int u = w / 8;
            int c = key.Length / u;
            int t = 2 * r + 4;

            int[] L = convBytesWords(key, u, c);



            int[] S = new int[t];
            S[0] = Pw;
            for (int i = 1; i < t; i++)
                S[i] = S[i - 1] + Qw;


            int A = 0;
            int B = 0;
            int k = 0, j = 0;

            int v = 3 * Math.Max(c, t);

            for (int i = 0; i < v; i++)
            {
                A = S[k] = rotl((S[k] + A + B), 3);
                B = L[j] = rotl(L[j] + A + B, A + B);
                k = (k + 1) % t;
                j = (j + 1) % c;

            }

            return S;
        }

        private static int rotl(int val, int pas)
        {
            return (val << pas) | ((int)((uint)val >> (32 - pas)));
        }
        private static int rotr(int val, int pas)
        {
            return ((int)((uint)val >> pas)) | (val << (32 - pas));
        }

        private static byte[] decryptBloc(byte[] input)
        {
            byte[] tmp = new byte[input.Length];
            int t, u;
            int aux;
            int[] data = new int[input.Length / 4];
            for (int i = 0; i < data.Length; i++)
                data[i] = 0;
            int off = 0;
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = ((input[off++] & 0xff)) |
                            ((input[off++] & 0xff) << 8) |
                            ((input[off++] & 0xff) << 16) |
                            ((input[off++] & 0xff) << 24);
            }


            int A = data[0], B = data[1], C = data[2], D = data[3];

            C = C - S[2 * r + 3];
            A = A - S[2 * r + 2];
            for (int i = r; i >= 1; i--)
            {
                aux = D;
                D = C;
                C = B;
                B = A;
                A = aux;

                u = rotl(D * (2 * D + 1), 5);
                t = rotl(B * (2 * B + 1), 5);
                C = rotr(C - S[2 * i + 1], t) ^ u;
                A = rotr(A - S[2 * i], u) ^ t;
            }
            D = D - S[1];
            B = B - S[0];

            data[0] = A; data[1] = B; data[2] = C; data[3] = D;


            for (int i = 0; i < tmp.Length; i++)
            {
                tmp[i] = unchecked((byte)(((int)((uint)data[i / 4] >> (i % 4) * 8)) & 0xff));
            }

            return tmp;
        }

        private static byte[] encryptBloc(byte[] input)
        {

            byte[] tmp = new byte[input.Length];
            int t, u;
            int aux;
            int[] data = new int[input.Length / 4];
            for (int i = 0; i < data.Length; i++)
                data[i] = 0;
            int off = 0;
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = ((input[off++] & 0xff)) |
                            ((input[off++] & 0xff) << 8) |
                            ((input[off++] & 0xff) << 16) |
                            ((input[off++] & 0xff) << 24);
            }

            int A = data[0], B = data[1], C = data[2], D = data[3];

            B = B + S[0];
            D = D + S[1];
            for (int i = 1; i <= r; i++)
            {
                t = rotl(B * (2 * B + 1), 5);
                u = rotl(D * (2 * D + 1), 5);
                A = rotl(A ^ t, u) + S[2 * i];
                C = rotl(C ^ u, t) + S[2 * i + 1];

                aux = A;
                A = B;
                B = C;
                C = D;
                D = aux;
            }
            A = A + S[2 * r + 2];
            C = C + S[2 * r + 3];

            data[0] = A; data[1] = B; data[2] = C; data[3] = D;

            for (int i = 0; i < tmp.Length; i++)
            {
                tmp[i] = unchecked((byte)(((int)((uint)data[i / 4] >> (i % 4) * 8)) & 0xff));
            }

            return tmp;
        }

        private static byte[] paddingKey(byte[] key)
        {
            int l = key.Length % 4;
            byte[] newkey = new byte[key.Length + l];
            Array.Copy(key, 0, newkey, 0, key.Length);
            for (int i = 0; i < l; i++)
                newkey[key.Length + i] = 0;

            return newkey;
        }

        public static byte[] encrypt(byte[] data, byte[] key)
        {

            byte[] bloc = new byte[16];
            key = paddingKey(key);
            S = generateSubkeys(key);



            int lenght = 16 - data.Length % 16;
            byte[] padding = new byte[lenght];
            padding[0] = (byte)0x80;
            int i;
            for (i = 1; i < lenght; i++)
                padding[i] = 0;
            int count = 0;
            byte[] tmp = new byte[data.Length + lenght];
            //afiseazaMatrice(S);

            for (i = 0; i < data.Length + lenght; i++)
            {
                if (i > 0 && i % 16 == 0)
                {
                    bloc = encryptBloc(bloc);
                    Array.Copy(bloc, 0, tmp, i - 16, bloc.Length);
                }

                if (i < data.Length)
                    bloc[i % 16] = data[i];
                else
                {
                    bloc[i % 16] = padding[count];
                    count++;
                    if (count > lenght - 1) count = 1;
                }
            }
            bloc = encryptBloc(bloc);
            Array.Copy(bloc, 0, tmp, i - 16, bloc.Length);
            return tmp;
        }

        public static byte[] decrypt(byte[] data, byte[] key)
        {
            byte[] tmp = new byte[data.Length];
            byte[] bloc = new byte[16];
            key = paddingKey(key);
            S = generateSubkeys(key);

            int i;
            for (i = 0; i < data.Length; i++)
            {
                if (i > 0 && i % 16 == 0)
                {
                    bloc = decryptBloc(bloc);
                    Array.Copy(bloc, 0, tmp, i - 16, bloc.Length);
                }

                if (i < data.Length)
                    bloc[i % 16] = data[i];
            }

            bloc = decryptBloc(bloc);
            Array.Copy(bloc, 0, tmp, i - 16, bloc.Length);

            tmp = deletePadding(tmp);
            return tmp;
        }

        private static byte[] deletePadding(byte[] input)
        {
            int count = 0;

            int i = input.Length - 1;
            while (input[i] == 0)
            {
                count++;
                i--;
            }

            byte[] tmp = new byte[input.Length - count - 1];
            Array.Copy(input, 0, tmp, 0, tmp.Length);
            return tmp;
        }


       public byte[] GetBytes(string str)
        {
            byte[] bytes = new byte[str.Length * sizeof(char)];
            System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }
       public string GetString(byte[] bytes)
        {
            char[] chars = new char[bytes.Length /*/ sizeof(char)*/];
            System.Buffer.BlockCopy(bytes, 0, chars, 0, bytes.Length);
            return new string(chars);
        }


    }
}
