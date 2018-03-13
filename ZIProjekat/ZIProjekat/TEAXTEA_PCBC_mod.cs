using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZIProjekat
{
    public class TEAXTEA_PCBC_mod : Algoritam
    {

        String key;
        String iv;

        UInt32[] K;

        uint delta;

        public TEAXTEA_PCBC_mod()
        {
            K = new UInt32[4];
            delta = 0x9e3779b9;
        }

        public string Key
        {
            get
            {
                return key;
            }

            set
            {
                key = value;
                string asciiKey = FromCharArrayToString(this.GetAsciiChars(this.key));

                int point = 0;
                for (int i = 0; i < K.Length; i++)
                {
                    uint output;
                    output = ((uint)asciiKey[point]);
                    output += ((uint)asciiKey[point + 1] << 8);
                    output += ((uint)asciiKey[point + 2] << 16);
                    output += ((uint)asciiKey[point + 3] << 24);
                    point += 4;
                    K[i] = output;
                }
            }
        }

        public string Iv
        {
            get
            {
                return iv;
            }

            set
            {
                iv = value;
            }
        }

        public string Dekriptuj(string tekst)
        {
            String dekriptovanTekst = "";


            while(tekst.Length % 8 !=0)
            {
                tekst += " ";
            }

            byte[] dataBytes = new byte[tekst.Length / 8 * 2];

            int x = 0;

            UInt32 H;
            UInt32 HH;
            UInt32 IV = Convert.ToUInt32(Iv);

            for (int i = 0; i < tekst.Length; i += 8)
            {
                
                    uint L = ConvertStringToUInt(tekst.Substring(i, 4));
                    uint R = ConvertStringToUInt(tekst.Substring(i + 4, 4));

                HH = (uint)(R << 8);
                HH += L; //ciphertext

                UInt32 sum = delta << 5;

                    for (int j = 0; j < 32; j++)
                    {
                        R -= (((L << 4) + K[2]) ^ (L + sum) ^ ((L >> 5) + K[3]));
                        L -= (((R << 4) + K[0]) ^ (R + sum) ^ ((R >> 5) + K[1]));

                        sum -= delta;
                    }


                H = (uint)(R << 8);
                H += L; //decrypted text

                H = H ^ IV; //decrypted text XOR IV

                L = H & 0x00FF;
                R = H & 0xFF00; //plaintext
                R = R >> 8;

                dataBytes[x++] = (byte)L;
                dataBytes[x++] = (byte)R;

                IV = H ^ HH; //plaintext XOR ciphertext


            }

            dekriptovanTekst= System.Text.ASCIIEncoding.ASCII.GetString(dataBytes, 0, dataBytes.Length);
            if(dekriptovanTekst[dekriptovanTekst.Length-1] == '\0')
            {
                dekriptovanTekst = dekriptovanTekst.Substring(0, dekriptovanTekst.Length - 1);
            }



            return dekriptovanTekst;
        }

        public string Kriptuj(string tekst)
        {
            String kriptovanTekst = "";


            if (tekst.Length % 2 != 0)
            {
                tekst += " ";

            }

            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(tekst);

            UInt32 H;
            UInt32 HH;
            UInt32 IV = Convert.ToUInt32(Iv);

            for (int i=0; i< inputBytes.Length;i+=2)
            {

                HH = (uint)(inputBytes[i + 1] << 8);
                HH += inputBytes[i]; //plaintext for xor with iv

                H = (uint)(inputBytes[i + 1] << 8);
                H += inputBytes[i]; //plaintext for crypting

                H = H ^ IV; //plaintext XOR IV

                uint LL = inputBytes[i];
                uint L = H & 0x00FF;

                uint RR = inputBytes[i + 1]; 
                uint R = H & 0xFF00;
                R = R >> 8;



                UInt32 sum = 0;

                for (int j = 0; j < 32; j++)
                {
                    sum += delta;
                    L+= (((R << 4) + K[0]) ^ (R + sum) ^ ((R >> 5) + K[1]));
                    R += (((L << 4) + K[2]) ^ (L + sum) ^ ((L >> 5) + K[3]));
                }


                IV = (uint)(R << 8);
                IV += L;

                IV = IV ^ HH; //ciphertext XOR plaintext

                kriptovanTekst += this.ConvertUIntToString(L) + this.ConvertUIntToString(R);

            }


            return kriptovanTekst;
        }


        public uint ConvertStringToUInt(string Input)
        {
            uint output;
            output = ((uint)Input[0]);
            output += ((uint)Input[1] << 8);
            output += ((uint)Input[2] << 16);
            output += ((uint)Input[3] << 24);
            return output;
        }

        public string ConvertUIntToString(uint Input)
        {
            System.Text.StringBuilder output = new System.Text.StringBuilder();
            output.Append((char)((Input & 0xFF)));
            output.Append((char)((Input >> 8) & 0xFF));
            output.Append((char)((Input >> 16) & 0xFF));
            output.Append((char)((Input >> 24) & 0xFF));
            return output.ToString();
        }


        char[] GetAsciiChars(string source)
        {
            Encoding ascii = Encoding.ASCII;
            Encoding enc_default = Encoding.Default;

            byte[] asciiBytes = Encoding.Convert(enc_default, ascii, enc_default.GetBytes(Key));
            char[] asciiChars = new char[ascii.GetCharCount(asciiBytes, 0, asciiBytes.Length)];

            ascii.GetChars(asciiBytes, 0, asciiBytes.Length, asciiChars, 0);

            return asciiChars;
        }

        string FromCharArrayToString(char[] start)
        {
            string ret = "";
            for (int i = 0; i < start.Length; i++)
            {
                ret += start[i];
            }

            return ret;
        }


    }
}
