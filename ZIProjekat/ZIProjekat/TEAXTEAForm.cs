using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZIProjekat
{
    public partial class TEAXTEAForm : Form
    {
        private OdabirAlgoritma pocetna;
        private TEAXTEA_PCBC_mod tea;

        private String OdabranFajl;
        private String OdabranaLokacija;
        private bool nijeDekriptovano;




        public TEAXTEAForm(OdabirAlgoritma poc,Algoritam t)
        {
            InitializeComponent();
            Pocetna = poc;
            Tea=(TEAXTEA_PCBC_mod)t;
            nijeDekriptovano = false;
            OdabranFajl = "";

            OdabranaLokacija = "D:\\IV godina\\Zastita informacija\\Projekat\\OdredisnaLokacijaTea\\";

          

        }

        public OdabirAlgoritma Pocetna
        {
            get
            {
                return pocetna;
            }

            set
            {
                pocetna = value;
            }
        }

        public TEAXTEA_PCBC_mod Tea
        {
            get
            {
                return tea;
            }

            set
            {
                tea = value;
            }
        }

        private void TEAXTEAForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
            this.Dispose();
            Pocetna.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCrypt_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtKljuc.Text))
            {
                MessageBox.Show("Morate uneti ključ.");
                return;
            }
            if(txtKljuc.Text.Length % 4 != 0 )
            {
                MessageBox.Show("Morate uneti ključ čija je dužina deljiva sa 4.");
                return;
            }
            if (String.IsNullOrEmpty(txtIV.Text))
            {
                MessageBox.Show("Morate uneti IV vektor.");
                return;
            }
           
            Tea.Iv = txtIV.Text;
            Tea.Key = txtKljuc.Text;

            txtDestinationText.Text = Tea.Kriptuj(txtSourceText.Text);
            nijeDekriptovano = true;
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if(!nijeDekriptovano)
            {
                return;
            }
            if (String.IsNullOrEmpty(txtKljuc.Text))
            {
                MessageBox.Show("Morate uneti ključ.");
                return;
            }
            if (txtKljuc.Text.Length % 4 != 0)
            {
                MessageBox.Show("Morate uneti ključ čija je dužina deljiva sa 4.");
                return;
            }
            if (String.IsNullOrEmpty(txtIV.Text))
            {
                MessageBox.Show("Morate uneti IV vektor.");
                return;
            }
           

            Tea.Key = txtKljuc.Text;
            Tea.Iv = txtIV.Text;

            txtDestinationText.Text = Tea.Dekriptuj(txtDestinationText.Text);
            nijeDekriptovano = false;

        }

        private void btnKriptujFajl_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtKljuc.Text))
            {
                MessageBox.Show("Morate uneti ključ.");
                return;
            }
            if (txtKljuc.Text.Length % 4 != 0)
            {
                MessageBox.Show("Morate uneti ključ čija je dužina deljiva sa 4.");
                return;
            }
            if (String.IsNullOrEmpty(txtIV.Text))
            {
                MessageBox.Show("Morate uneti IV vektor.");
                return;
            }
           
            Tea.Iv = txtIV.Text;
            Tea.Key = txtKljuc.Text;
            if (ofdDeKriptuj.ShowDialog() == DialogResult.OK)
            {
                OdabranFajl = ofdDeKriptuj.FileName;
                lblUcitanKFajl.Visible = true;

            }
            lblFajlSacuvan.Visible = false;
            lblLokacija.Visible = false;

            txtIzlaz.Text = " ";
            txtUlaz.Text = " ";
        }

        private void btnPocni_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(OdabranFajl))
            {
                MessageBox.Show("Nije odabran fajl!");
                return;
            }

            if (OdabranFajl.EndsWith(".txt"))
            {
                ProcitajTXT();
            }


            OdabranFajl = "";
            lblUcitanKFajl.Visible = false;

            lblFajlSacuvan.Visible = true;
            lblLokacija.Width = 384;
            lblLokacija.Height = 40;
            int l = OdabranaLokacija.Length - 1;
            String prviDeo = OdabranaLokacija.Substring(0, 59);
            String drugiDeo = OdabranaLokacija.Remove(0, 59);
            lblLokacija.Text = prviDeo + "\n" + drugiDeo;
            //MessageBox.Show(OdabranaLokacija.Length.ToString());
            lblLokacija.Visible = true;

            OdabranaLokacija = "D:\\IV godina\\Zastita informacija\\Projekat\\OdredisnaLokacijaTea\\";

        }

        private void ProcitajTXT()
        {
            String line;
            String ceoText = "";
            String IME = " ";
            String EKSTENZIJA = " ";
            bool kriptovanje;


            try
            {

                StreamReader sr = new StreamReader(OdabranFajl);
                StreamWriter sw;

                line = sr.ReadLine();
                if (line.Contains("Kriptovano teom"))
                {
                    kriptovanje = false;
                    //prvu liniju preskacemo, sledeca linija je ime
                    IME = sr.ReadLine();
                    //sledeca ekstenzija
                    EKSTENZIJA = sr.ReadLine();
                    //sad pocinje tekst
                    //line = sr.ReadLine();

                    //novi fajl u odnosu na ekst
                    String novoIme = IME + "d." + EKSTENZIJA;
                    OdabranaLokacija += novoIme;


                }
                else
                {
                    kriptovanje = true;
                    String[] putanja = OdabranFajl.Split('\\');
                    String ime = putanja[putanja.Length - 1];
                    String[] imee = ime.Split('.');
                    IME = imee[0];
                    EKSTENZIJA = imee[1];
                    String novoIme = IME + "k." + "txt";
                    OdabranaLokacija += novoIme;

                    ceoText += line; //linija koja je vec procitana
                }

                sw = new StreamWriter(OdabranaLokacija);

                if (kriptovanje)
                {
                    sw.WriteLine("Kriptovano teom");
                    sw.WriteLine(IME);
                    sw.WriteLine(EKSTENZIJA);
                }
                //while (line != null)
                //{
                //    ceoText += line;

                //    line = sr.ReadToEnd();
                //}

                ceoText += sr.ReadToEnd();

                if (kriptovanje)
                {
                    String text = Tea.Kriptuj(ceoText);
                    txtIzlaz.Text += text;
                    sw.WriteLine(text);
                }

                sr.Close();
                sw.Close();

                txtUlaz.Text = ceoText;

                if (!kriptovanje)
                {
                    if (String.Equals(EKSTENZIJA, "txt"))
                    {
                        NapraviDekodiraniTXT(OdabranaLokacija, ceoText);
                    }

                }

               


                }
            catch (IOException e)
            {
                MessageBox.Show("Izuzetak prilikom citanja fajla: " + e, "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }



        private void NapraviDekodiraniTXT(String lokacija, String text)
        {
            try
            {
                StreamWriter sw = new StreamWriter(lokacija);
                String dekriptovano = Tea.Dekriptuj(text);

                dekriptovano = dekriptovano.Remove(dekriptovano.Length -2, 2);
                sw.WriteLine(dekriptovano);
                
                txtIzlaz.Text = dekriptovano;
                sw.Close();
               
            }
            catch (IOException e)
            {
                MessageBox.Show("Izuzetak prilikom citanja fajla: " + e, "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }


    }
}
