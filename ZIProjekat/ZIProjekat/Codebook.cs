using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZIProjekat
{
    public class Codebook : Algoritam
    {

        private Hashtable HTReci;
        private ICollection keys;

        public Hashtable HTReci1
        {
            get
            {
                return HTReci;
            }

            set
            {
                HTReci = value;
            }
        }

        public ICollection Keys
        {
            get
            {
                return keys;
            }

            set
            {
                keys = value;
            }
        }

        public Codebook()
        {
            HTReci1 = new Hashtable();
           // Keys = HTReci1.Keys;
        }


        public String Kriptuj(String tekst)
        {

            String kriptovanTekst = "";
            String[] separators = { " ","  ","   " };
            String[] reci = tekst.Split(separators,StringSplitOptions.None);

            int l = reci.Length;

            String rec;

            for (int i=0; i< l; i++)
            {
                rec = reci[i];
                String recZaZamenu = rec;
                if (String.Equals(rec, "San"))
                {
                    if (String.Equals(reci[i + 1],"Francisko"))
                    {
                        recZaZamenu += " " + reci[i + 1];
                        i++;
                    }
                }

                String zamenjenoKraj = ""; //ako uzimamo na kraju recenice, ta rec ima tacku ili ? ili !
                String zamenjenoPocetak = ""; // ako je rec uokvirena navodnicima , zagradama

                if (rec.EndsWith("."))
                {
                    int length = rec.Length;
                    recZaZamenu = rec.Remove(length - 1, 1);
                    zamenjenoKraj = ".";
                }
                if (rec.EndsWith(","))
                {
                    int length = rec.Length;
                    recZaZamenu = rec.Remove(length - 1, 1);
                    zamenjenoKraj = ",";
                }
                if (rec.EndsWith("!"))
                {
                    int length = rec.Length;
                    recZaZamenu = rec.Remove(length - 1, 1);
                    zamenjenoKraj = "!";
                }
                if (rec.EndsWith("?"))
                {
                    int length = rec.Length;
                    recZaZamenu = rec.Remove(length - 1, 1);
                    zamenjenoKraj = "?";
                }
                if (rec.EndsWith(":"))
                {
                    int length = rec.Length;
                    recZaZamenu = rec.Remove(length - 1, 1);
                    zamenjenoKraj = ":";
                }
                if (rec.EndsWith("!?"))
                {
                    int length = rec.Length;
                    recZaZamenu = rec.Remove(length - 1, 1);
                    zamenjenoKraj = "!?";
                }
                if (rec.EndsWith("?!"))
                {
                    int length = rec.Length;
                    recZaZamenu = rec.Remove(length - 1, 1);
                    zamenjenoKraj = "?!";
                }
                if (rec.EndsWith(";"))
                {
                    int length = rec.Length;
                    recZaZamenu = rec.Remove(length - 1, 1);
                    zamenjenoKraj = ";";
                }
                if (rec.StartsWith("\"") && rec.EndsWith("\""))
                {
                    int length = rec.Length;
                    recZaZamenu = rec.Remove(length - 1, 1);
                    zamenjenoKraj = "\"";
                    recZaZamenu = recZaZamenu.Remove(0, 1);
                    zamenjenoPocetak = "\"";
                }
                if (rec.StartsWith("\'") && rec.EndsWith("\'"))
                {
                    int length = rec.Length;
                    recZaZamenu = rec.Remove(length - 1, 1);
                    zamenjenoKraj = "\'";
                    recZaZamenu = recZaZamenu.Remove(0, 1);
                    zamenjenoPocetak = "\'";
                }
                if (rec.StartsWith("(") && rec.EndsWith(")"))
                {
                    int length = rec.Length;
                    recZaZamenu = rec.Remove(length - 1, 1);
                    zamenjenoKraj = ")";
                    recZaZamenu = recZaZamenu.Remove(0, 1);
                    zamenjenoPocetak = "(";
                }
                if (rec.StartsWith("[") && rec.EndsWith("]"))
                {
                    int length = rec.Length;
                    recZaZamenu = rec.Remove(length - 1, 1);
                    zamenjenoKraj = "]";
                    recZaZamenu = recZaZamenu.Remove(0, 1);
                    zamenjenoPocetak = "[";
                }
                if (rec.StartsWith("{") && rec.EndsWith("}"))
                {
                    int length = rec.Length;
                    recZaZamenu = rec.Remove(length - 1, 1);
                    zamenjenoKraj = "}";
                    recZaZamenu = recZaZamenu.Remove(0, 1);
                    zamenjenoPocetak = "{";
                }




                if (HTReci1.ContainsKey(recZaZamenu))
                {
                    kriptovanTekst = kriptovanTekst + zamenjenoPocetak + HTReci1[recZaZamenu] + zamenjenoKraj + " ";
                }
                else
                {
                    kriptovanTekst = kriptovanTekst + zamenjenoPocetak + recZaZamenu + zamenjenoKraj + " ";
                }

            }

            return kriptovanTekst;

        }

        public String Dekriptuj(String tekst)
        {
            String dekriptovanTekst = "";
            String[] separators = { " ", "  ", "   " };
            String[] reci = tekst.Split(separators, StringSplitOptions.None);



            foreach (String rec in reci)
            {
                String recZaZamenu = rec;
                String zamenjenoKraj = ""; //ako uzimamo na kraju recenice, ta rec ima tacku ili ? ili !
                String zamenjenoPocetak = ""; // ako je rec uokvirena navodnicima, zagradama

                
                if (rec.EndsWith("."))
                {
                    int length = rec.Length;
                    recZaZamenu = rec.Remove(length - 1, 1);
                    zamenjenoKraj = ".";
                }
                if (rec.EndsWith(","))
                {
                    int length = rec.Length;
                    recZaZamenu = rec.Remove(length - 1, 1);
                    zamenjenoKraj = ",";
                }
                if (rec.EndsWith("!"))
                {
                    int length = rec.Length;
                    recZaZamenu = rec.Remove(length - 1, 1);
                    zamenjenoKraj = "!";
                }
                if (rec.EndsWith("?"))
                {
                    int length = rec.Length;
                    recZaZamenu = rec.Remove(length - 1, 1);
                    zamenjenoKraj = "?";
                }
                if (rec.EndsWith(":"))
                {
                    int length = rec.Length;
                    recZaZamenu = rec.Remove(length - 1, 1);
                    zamenjenoKraj = ":";
                }
                if (rec.EndsWith("!?"))
                {
                    int length = rec.Length;
                    recZaZamenu = rec.Remove(length - 1, 1);
                    zamenjenoKraj = "!?";
                }
                if (rec.EndsWith("?!"))
                {
                    int length = rec.Length;
                    recZaZamenu = rec.Remove(length - 1, 1);
                    zamenjenoKraj = "?!";
                }
                if (rec.EndsWith(";"))
                {
                    int length = rec.Length;
                    recZaZamenu = rec.Remove(length - 1, 1);
                    zamenjenoKraj = ";";
                }
                if (rec.StartsWith("\"") && rec.EndsWith("\""))
                {
                    int length = rec.Length;
                    recZaZamenu = rec.Remove(length - 1, 1);
                    zamenjenoKraj = "\"";
                    recZaZamenu = recZaZamenu.Remove(0, 1);
                    zamenjenoPocetak = "\"";
                }
                if (rec.StartsWith("\'") && rec.EndsWith("\'"))
                {
                    int length = rec.Length;
                    recZaZamenu = rec.Remove(length - 1, 1);
                    zamenjenoKraj = "\'";
                    recZaZamenu = recZaZamenu.Remove(0, 1);
                    zamenjenoPocetak = "\'";
                }
                if (rec.StartsWith("(") && rec.EndsWith(")"))
                {
                    int length = rec.Length;
                    recZaZamenu = rec.Remove(length - 1, 1);
                    zamenjenoKraj = ")";
                    recZaZamenu = recZaZamenu.Remove(0, 1);
                    zamenjenoPocetak = "(";
                }
                if (rec.StartsWith("[") && rec.EndsWith("]"))
                {
                    int length = rec.Length;
                    recZaZamenu = rec.Remove(length - 1, 1);
                    zamenjenoKraj = "]";
                    recZaZamenu = recZaZamenu.Remove(0, 1);
                    zamenjenoPocetak = "[";
                }
                if (rec.StartsWith("{") && rec.EndsWith("}"))
                {
                    int length = rec.Length;
                    recZaZamenu = rec.Remove(length - 1, 1);
                    zamenjenoKraj = "}";
                    recZaZamenu = recZaZamenu.Remove(0, 1);
                    zamenjenoPocetak = "{";
                }

                if (HTReci1.ContainsValue(recZaZamenu))
                {
                    foreach(String key in Keys)
                    {
                        if (String.Equals(recZaZamenu, HTReci1[key]))
                        {
                            dekriptovanTekst = dekriptovanTekst + zamenjenoPocetak + key + zamenjenoKraj + " ";
                            break;
                        }
                    }
                }
                else
                {
                    dekriptovanTekst = dekriptovanTekst + zamenjenoPocetak + recZaZamenu + zamenjenoKraj + " ";
                }

            }

            return dekriptovanTekst;
        }
    }

}
