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
    public partial class RC6Form : Form
    {
        private OdabirAlgoritma pocetna;
        private RC6 rc6;

        bool kljucGenerisan;
        private bool nijeDekriptovano;

        private String OdabranFajl;
        private String OdabranaLokacija;


        public RC6Form(OdabirAlgoritma poc,Algoritam r)
        {
            InitializeComponent();
            Pocetna = poc;
            Rc6 = (RC6)r;

            kljucGenerisan = false;
            nijeDekriptovano = false;
            OdabranFajl = "";

            OdabranaLokacija = "D:\\IV godina\\Zastita informacija\\Projekat\\OdredisnaLokacijaRC6\\";


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

        public RC6 Rc6
        {
            get
            {
                return rc6;
            }

            set
            {
                rc6 = value;
            }
        }

        private void RC6Form_FormClosing(object sender, FormClosingEventArgs e)
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
            if (!kljucGenerisan)
            {
                MessageBox.Show("Morate prvo generisati ključ.");
                return;
            }

            txtDestinationText.Text = Rc6.Kriptuj(txtSourceText.Text);
            nijeDekriptovano = true;
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (!nijeDekriptovano)
            {
                return;
            }
            if (!kljucGenerisan)
            {
                MessageBox.Show("Morate prvo generisati ključ.");
                return;
            }

            txtDestinationText.Text = Rc6.Dekriptuj(txtDestinationText.Text);
            nijeDekriptovano = false;
        }

        private void btnGenerisiKljuc_Click(object sender, EventArgs e)
        {
            if(kljucGenerisan)
            {
                MessageBox.Show("Ključ je već generisan.");
                return;
            }

            if(String.IsNullOrEmpty(txtKljuc.Text))
            {
                MessageBox.Show("Morate prvo uneti ključ.");
                return;
            }


            byte[] kljuc = GetBytes(txtKljuc.Text);
            Rc6.GenerisiKljuc(kljuc);

            kljucGenerisan = true;
            lblKljucGenerisan.Visible = true;
        }

        private void btnKriptujFajl_Click(object sender, EventArgs e)
        {
            if (!kljucGenerisan)
            {
                MessageBox.Show("Morate prvo generisati ključ.");
                return;
            }
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
            if (OdabranFajl.EndsWith(".bin"))
            {
                ProcitajBIN();
            }
            if(OdabranFajl.EndsWith(".cryp"))
            {
                ProcitajKriptovano();
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

            OdabranaLokacija = "D:\\IV godina\\Zastita informacija\\Projekat\\OdredisnaLokacijaRC6\\";

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

                String[] putanja = OdabranFajl.Split('\\');
                String ime = putanja[putanja.Length - 1];
                String[] imee = ime.Split('.');
                IME = imee[0];
                String novoIme = IME + "t." + "cryp";
                OdabranaLokacija += novoIme;

                StreamReader sr = new StreamReader(OdabranFajl);

                line = sr.ReadLine();
                String ceoTekst = "";

                while(line != null)
                {
                    txtUlaz.Text += line;
                    ceoTekst += line;
                    line = sr.ReadLine();
                }
                sr.Close();

                byte[] output = File.ReadAllBytes(OdabranFajl);
                byte[] rez = Rc6.Enc(output);
                String text = GetString(rez);
                txtIzlaz.Text = text;

                //String rez = Rc6.Kriptuj(ceoTekst);
                //txtIzlaz.Text = rez;
                try
                {
                    using (BinaryWriter bw = new BinaryWriter(new FileStream(OdabranaLokacija, FileMode.Create)))
                    {
                        bw.Write(rez);
                        bw.Close();
                    }

                }
                catch (IOException e)
                {
                    MessageBox.Show("Izuzetak prilikom citanja fajla: " + e, "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


               
               


            }
            catch (IOException e)
            {
                MessageBox.Show("Izuzetak prilikom citanja fajla: " + e, "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }


        private void ProcitajBIN()
        {
            BinaryReader br;
            BinaryWriter bw;
            Byte[] bytes;
           FileStream fs = new FileStream(OdabranFajl, FileMode.Open);

            String[] putanja = OdabranFajl.Split('\\');
            String ime = putanja[putanja.Length - 1];
            String[] imee = ime.Split('.');
            String imeee = imee[0];
            String ekst = "cryp";
            String novoIme = imeee + "b." + ekst;
            OdabranaLokacija += novoIme;


            try
            {
                br = new BinaryReader(fs);
                bw = new BinaryWriter(new FileStream(OdabranaLokacija, FileMode.Create));
            }
            catch (IOException e)
            {
                MessageBox.Show("Otvaranje fajla neuspešno: " + e, "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {

                String text = "";

               // bytes = File.ReadAllBytes(OdabranFajl);
                bytes = br.ReadBytes((int)fs.Length);
                //String ucitano = GetString(bytes);

                String ucitano = " ";
                byte[] rez = Rc6.Enc(bytes);
                foreach (byte b in bytes)
                {
                    ucitano += b.ToString() + " ";

                }
                txtUlaz.Text = ucitano;
                String novi = GetString(rez);

                txtIzlaz.Text = novi;
              
                bw.Write(rez);
               

            }
            catch (IOException e)
            {
                MessageBox.Show("Izuzetak prilikom citanja fajla: " + e, "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            finally
            {
                br.Close();
                bw.Close();
            }

        }

        private void ProcitajKriptovano()
        {
            BinaryReader br;
            BinaryWriter bw;
            Byte[] bytes;
           //FileStream fs = new FileStream(OdabranFajl, FileMode.Open);
           

            String[] putanja = OdabranFajl.Split('\\');
            String ime = putanja[putanja.Length - 1];
            String[] imee = ime.Split('.');
            String imeee = imee[0];
            String ekst = "bin";
            String novoIme = imeee + "d." + ekst;

            String novaLok = OdabranaLokacija;

            OdabranaLokacija += novoIme;

            novaLok += imeee + "tt.txt";

            try
            {
               // br = new BinaryReader(fs);
                bw = new BinaryWriter(new FileStream(OdabranaLokacija, FileMode.Create));
               
            }
            catch (IOException e)
            {
                MessageBox.Show("Otvaranje fajla neuspešno: " + e, "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {

                String text = "";

                bytes = File.ReadAllBytes(OdabranFajl);
               // bytes = br.ReadBytes((int)fs.Length);
                //String ucitano = GetString(bytes);


                String ucitano = " ";
                byte[] rez = Rc6.Dec(bytes);
                foreach (byte b in bytes)
                {
                    ucitano += b.ToString() + " ";

                }
                txtUlaz.Text = ucitano;
                bw.Write(rez);
                bw.Close();
                if (!OdabranFajl.EndsWith("t.cryp"))
                {
                    
                    String novi = GetString(rez);

                    txtIzlaz.Text = novi;
                }
                else
                {
                    br = new BinaryReader(new FileStream(OdabranaLokacija, FileMode.Open));
                    String novi = br.ReadString();
                    txtIzlaz.Text = novi;
                    br.Close();

                    //StreamWriter sw = new StreamWriter(new FileStream(novaLok, FileMode.Create));
                    //sw.Write(novi);
                    //sw.Close();
                }
                
               

            }
            catch (IOException e)
            {
                MessageBox.Show("Izuzetak prilikom citanja fajla: " + e, "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            finally
            {
                //br.Close();
                //bw.Close();
              
            }
        }


        byte[] GetBytes(string str)
        {
            byte[] bytes = new byte[str.Length * sizeof(char)];
            System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }

        string GetString(byte[] bytes)
        {
            char[] chars = new char[bytes.Length /*/ sizeof(char)*/];
            System.Buffer.BlockCopy(bytes, 0, chars, 0, bytes.Length);
            return new string(chars);
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

        private void btnKomunikacija_Click(object sender, EventArgs e)
        {
            if (!kljucGenerisan)
            {
                MessageBox.Show("Morate prvo generisati ključ.");
                return;
            }

            Client cli = new Client(Rc6);
            cli.Show();

            this.WindowState = FormWindowState.Minimized;

        }
    }
}
