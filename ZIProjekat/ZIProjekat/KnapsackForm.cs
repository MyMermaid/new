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
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using iTextSharp.text;
using Word = Microsoft.Office.Interop.Word;
using System.Timers;

namespace ZIProjekat
{
    public partial class KnapsackForm : Form
    {
        private OdabirAlgoritma pocetna;
        private Knapsack knap;

        bool javniGenerisan;
        int im;
        int m;
        int n;
        int[] privatni;
        int[] javni;

        String OdabranFajl;
        String OdabranaLokacija;

        //fsw
        String FSWUlaznaLokacija;
        String FSWOdrediste;
        String FSWOdabranFajl; //fajl koji se odabere za kriptovanje dok je ukljucen FWS
        //fsw
        List<String> obradjeniFajlovi;
        FileSystemWatcher watcher;
        Queue<String> queue; //fajlovi za obradu
        System.Timers.Timer timer;
        bool nijeDekriptovano;

        bool ukljucenFSW;
 

        public KnapsackForm(OdabirAlgoritma poc, Algoritam k)
        {
            InitializeComponent();
            Pocetna = poc;
            Knap = (Knapsack)k;

            privatni = new int[8];
            javni = new int[8];
            javniGenerisan = false;
            im = m = n = -1;
            OdabranFajl = "";
            OdabranaLokacija = "D:\\IV godina\\Zastita informacija\\Projekat\\OdredisnaLokacija\\";
            //fsw
            FSWUlaznaLokacija = "D:\\IV godina\\Zastita informacija\\Projekat\\UlaznaLokacijaKnap\\";
            FSWOdrediste = "D:\\IV godina\\Zastita informacija\\Projekat\\OdredisnaLokacijaKnap\\";

            txtUlaznaLokacija.Text = FSWUlaznaLokacija;
            txtOdredisnaLokacija.Text = FSWOdrediste;
            //fsw
            watcher = new FileSystemWatcher(FSWUlaznaLokacija);
            watcher.EnableRaisingEvents = false;
            watcher.Created += watcher_Created;
            watcher.Renamed += watcher_Renamed;

            queue = new Queue<string>();
            timer = new System.Timers.Timer(300);
            timer.Elapsed += new System.Timers.ElapsedEventHandler(ObradiFajlove);
            timer.Enabled = false;

            nijeDekriptovano = false;

            ukljucenFSW = false;
            obradjeniFajlovi = new List<string>();

            FSWOdabranFajl = "";


        }

        private void watcher_Renamed(object sender, RenamedEventArgs e)
        {
            if (obradjeniFajlovi.Contains(e.OldFullPath))
            {
                obradjeniFajlovi.Remove(e.OldFullPath);
                obradjeniFajlovi.Add(e.FullPath);
            }
        }


        private void watcher_Created(object sender, FileSystemEventArgs e)
        {
            if (!obradjeniFajlovi.Contains(e.FullPath))
            {
                queue.Enqueue(e.FullPath);
            }
        }

        private void ObradiFajlove(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (queue.Count != 0)
            {
                string file = queue.Dequeue();
                OdabranFajl = file;
                obradjeniFajlovi.Add(file);
                OdabranaLokacija = FSWOdrediste;

                    if (file.EndsWith(".txt"))
                    {
                        ProcitajTXT();
                    }
                    if (file.EndsWith(".bin"))
                    {
                        ProcitajBIN();
                    }
                    if (file.EndsWith(".pdf"))
                    {
                        ProcitajPDF();
                    }
                    if (file.EndsWith(".doc") || OdabranFajl.EndsWith(".docx"))
                    {
                        ProcitajDOCX();
                    }



                    if (String.Equals(FSWOdabranFajl, file))
                    {
                        FSWOdabranFajl = "";
                        lblUcitanKFajl.Visible = false;

                        lblFajlSacuvan.Visible = true;
                        lblLokacija.Width = 384;
                        lblLokacija.Height = 40;
                        String prviDeo = OdabranaLokacija.Substring(0, 59);
                        String drugiDeo = OdabranaLokacija.Remove(0, 59);
                        lblLokacija.Text = prviDeo + "\n" + drugiDeo;
                        //MessageBox.Show(OdabranaLokacija.Length.ToString());
                        lblLokacija.Visible = true;

                        OdabranaLokacija = FSWOdrediste;

                    }


            }
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

        public Knapsack Knap
        {
            get
            {
                return knap;
            }

            set
            {
                knap = value;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void KnapsackForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //try
            //{
            //    StreamWriter sw = new StreamWriter(new FileStream(cryptLog, FileMode.Create));

            //    foreach(string f in obradjeniFajlovi)
            //    {
            //        sw.WriteLine(f);
            //    }
            //    sw.Close();
            //}
            //catch(IOException ee)
            //{
            //    MessageBox.Show("Greska kod upisa u log fajl " + ee);
            //    return;
            //}

            e.Cancel = false;
            this.Dispose();
            Pocetna.Show();
        }

        private void btnCrypt_Click(object sender, EventArgs e)
        {
            if(!javniGenerisan)
            {
                MessageBox.Show("Morate prvo generisati javni ključ.");
                return;
            }
            txtDestinationText.Text = Knap.Kriptuj(txtSourceText.Text);
            nijeDekriptovano = true;
        }


        private void btnGenerisiJavni_Click(object sender, EventArgs e)
        {
            string[] privatniK = txtPrivatni.Text.Split(',');
            string javniK = "";

            m = System.Convert.ToInt32(txtM.Text);
            n = System.Convert.ToInt32(txtN.Text);
            Knap.N = n;
            Knap.M = m;

            int k = 1;
            int rez = -1;
            do
            {
                im = (n * k + 1) / m;
                k++;
                rez = (im * m) % n;
            }
            while (rez != 1);

            Knap.Im = im;

            lblIM.Text = "im = " + im.ToString();
            lblIM.Visible = true;

            int i = 0;
            
            foreach(string pk in privatniK)
            {
                privatni[i] = Convert.ToInt32(pk);

                javni[i] = (privatni[i] * m) % n;

                if(i!=7)
                    javniK += javni[i].ToString() + ",";
                else
                    javniK += javni[i].ToString();

                i++;
            }

            Knap.JavniKjuc = javni;
            Knap.PrivatniKljuc = privatni;

            txtJavni.Text = javniK;
            javniGenerisan = true;
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if(!nijeDekriptovano)
            {
                return;
            }
            if (!javniGenerisan)
            {
                MessageBox.Show("Morate prvo generisati javni ključ.");
                return;
            }

            txtDestinationText.Text = Knap.Dekriptuj(txtDestinationText.Text);
            nijeDekriptovano = false;
        }

        private void btnKriptujFajl_Click(object sender, EventArgs e)
        {
            if (!javniGenerisan)
            {
                MessageBox.Show("Morate prvo generisati javni ključ.");
                return;
            }
           if(ofdDeKriptuj.ShowDialog()==DialogResult.OK)
            {
                if (!ukljucenFSW)
                {
                    OdabranFajl = ofdDeKriptuj.FileName;
                }
                else
                {
                    FSWOdabranFajl= ofdDeKriptuj.FileName;
                   // queue.Enqueue(ofdDeKriptuj.FileName);
                }
                lblUcitanKFajl.Visible = true;
            }
            lblFajlSacuvan.Visible = false;
            lblLokacija.Visible = false;

            txtIzlaz.Text = " ";
            txtUlaz.Text = " ";
        }

        private void ProcitajTXT()
        {
            String line;
            String ceoText="";
            String IME= " ";
            String EKSTENZIJA= " ";
            bool kriptovanje;
            try
            {

                StreamReader sr = new StreamReader(OdabranFajl);
                StreamWriter sw;
                

                line = sr.ReadLine();
                if (line.Contains("Kriptovano knapsackom"))
                {
                    kriptovanje = false;
                    //prvu liniju preskacemo, sledeca linija je ime
                    IME=sr.ReadLine();
                    //sledeca ekstenzija
                    EKSTENZIJA= sr.ReadLine();
                    //sad pocinje tekst
                    line = sr.ReadLine();

                    //novi fajl u odnosu na ekst
                    String novoIme = IME + "k." + EKSTENZIJA;
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
                  

                }
                obradjeniFajlovi.Add(OdabranaLokacija);
                sw = new StreamWriter(OdabranaLokacija);

                if (kriptovanje)
                {
                    sw.WriteLine("Kriptovano knapsackom");
                    sw.WriteLine(IME);
                    sw.WriteLine(EKSTENZIJA);
                }
                while (line != null)
                {
                    if (!ukljucenFSW || (ukljucenFSW && String.Equals(FSWOdabranFajl, OdabranFajl)))
                    {
                        txtUlaz.Text += line;
                    }
                    if (kriptovanje)
                    {
                        String text = Knap.Kriptuj(line);
                        if (!ukljucenFSW || (ukljucenFSW && String.Equals(FSWOdabranFajl, OdabranFajl)))
                        {
                            txtIzlaz.Text += text;
                        }
                        sw.WriteLine(text);
                    }
                    else
                    {
                        ceoText += line;
                    }


                    line = sr.ReadLine();

                }

                sr.Close();
                sw.Close();

                if (!kriptovanje)
                {
                    if(String.Equals(EKSTENZIJA,"txt"))
                    {
                        NapraviDekodiraniTXT(OdabranaLokacija, ceoText,OdabranFajl);
                    }
                    if (String.Equals(EKSTENZIJA, "pdf"))
                    {
                        NapraviDekodiraniPDF(OdabranaLokacija, ceoText, OdabranFajl);
                    }
                    if (String.Equals(EKSTENZIJA, "bin"))
                    {
                        NapraviDekodiraniBIN(OdabranaLokacija, ceoText, OdabranFajl);
                    }
                    if (String.Equals(EKSTENZIJA, "doc") || String.Equals(EKSTENZIJA, "docx"))
                    {
                        NapraviDekodiraniDOCX(OdabranaLokacija, ceoText, OdabranFajl);
                    }
                }

                

            }
            catch (Exception ee)
            {
                MessageBox.Show("Izuzetak prilikom citanja fajla: " + ee, "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

            }
        }


        private void ProcitajBIN()
        {
            BinaryReader br;
            Byte[] bytes;
            FileStream fs = new FileStream(OdabranFajl, FileMode.Open);

            StreamWriter sw;
            String[] putanja = OdabranFajl.Split('\\');
            String ime = putanja[putanja.Length - 1];
            String[] imee = ime.Split('.');
            String imeee = imee[0];
            String ekst = "txt";
            String novoIme = imeee + "k." + ekst;
            OdabranaLokacija += novoIme;
            obradjeniFajlovi.Add(OdabranaLokacija);
            sw = new StreamWriter(OdabranaLokacija);

            sw.WriteLine("Kriptovano knapsackom");
            sw.WriteLine(imeee);
            sw.WriteLine(imee[1]);
            try
            {
                br = new BinaryReader(fs);
            }
            catch (IOException e)
            {
                MessageBox.Show("Otvaranje fajla neuspešno: " + e, "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {

                String text = "";

                bytes = br.ReadBytes((int)fs.Length);

                foreach (byte b in bytes)
                {
                    text += b.ToString() + " ";
  
                }

                String novi= Knap.Kriptuj(text);
                if (!ukljucenFSW || (ukljucenFSW && String.Equals(FSWOdabranFajl, OdabranFajl)))
                {
                    txtUlaz.Text = text;
                    txtIzlaz.Text = novi;
                }
                sw.WriteLine(novi);

            }
            catch (IOException e)
            {
                MessageBox.Show("Izuzetak prilikom citanja fajla: " + e, "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            finally
            {
                br.Close();
                sw.Close();
            }

        }


        private void ProcitajPDF()
        {
            try
            {
                StreamWriter sw;
                String[] putanja = OdabranFajl.Split('\\');
                String ime = putanja[putanja.Length - 1];
                String[] imee = ime.Split('.');
                String imeee = imee[0];
                String ekst = "txt";
                String novoIme = imeee + "k." + ekst;
                OdabranaLokacija += novoIme;
                obradjeniFajlovi.Add(OdabranaLokacija);
                sw = new StreamWriter(OdabranaLokacija);

                sw.WriteLine("Kriptovano knapsackom");
                sw.WriteLine(imeee);
                sw.WriteLine(imee[1]);

                StringBuilder textb = new StringBuilder();

                using (PdfReader pr = new PdfReader(OdabranFajl))
                {
                    for (int i=1; i< pr.NumberOfPages + 1 ;i++)
                    {
                        textb.Append(PdfTextExtractor.GetTextFromPage(pr, i));
                    }
                }

                String text = textb.ToString();
                if (!ukljucenFSW || (ukljucenFSW && String.Equals(FSWOdabranFajl, OdabranFajl)))
                {
                    txtUlaz.Text = text;
                }
                text= Knap.Kriptuj(text);
                if (!ukljucenFSW || (ukljucenFSW && String.Equals(FSWOdabranFajl, OdabranFajl)))
                {
                    txtIzlaz.Text = text;
                }
                sw.WriteLine(text);

                sw.Close();

            }
            catch (IOException e)
            {
                MessageBox.Show("Izuzetak prilikom citanja fajla: " + e, "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void ProcitajDOCX()
        {
            try
            {
                StreamWriter sw;
                String[] putanja = OdabranFajl.Split('\\');
                String ime = putanja[putanja.Length - 1];
                String[] imee = ime.Split('.');
                String imeee = imee[0];
                String ekst = "txt";
                String novoIme = imeee + "k." + ekst;
                OdabranaLokacija += novoIme;
                obradjeniFajlovi.Add(OdabranaLokacija);
                sw = new StreamWriter(OdabranaLokacija);

                sw.WriteLine("Kriptovano knapsackom");
                sw.WriteLine(imeee);
                sw.WriteLine(imee[1]);


                Word.Application objWord = new Word.Application();
                objWord.Visible = false;

                Word.Document doc = null;
                doc = objWord.Documents.Open(OdabranFajl, Type.Missing, false);

                String text = doc.Content.Text;
                if (!ukljucenFSW || (ukljucenFSW && String.Equals(FSWOdabranFajl, OdabranFajl)))
                    txtUlaz.Text = text;
                text = Knap.Kriptuj(text);
                if (!ukljucenFSW || (ukljucenFSW && String.Equals(FSWOdabranFajl, OdabranFajl)))
                    txtIzlaz.Text = text;
                sw.WriteLine(text);

                sw.Close();

                doc.Close();
                objWord.Quit();
                System.Runtime.InteropServices.Marshal.ReleaseComObject(objWord);



            }
            catch(IOException e)
            {
                MessageBox.Show("Izuzetak prilikom citanja fajla: " + e, "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }


        private void btnPocni_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(OdabranFajl))
            {
                MessageBox.Show("Nije odabran fajl!");
                return;
            }
            if (!ukljucenFSW)
            {
                if (OdabranFajl.EndsWith(".txt"))
                {
                    ProcitajTXT();
                }
                if (OdabranFajl.EndsWith(".bin"))
                {
                    ProcitajBIN();
                }
                if (OdabranFajl.EndsWith(".pdf"))
                {
                    ProcitajPDF();
                }
                if (OdabranFajl.EndsWith(".doc") || OdabranFajl.EndsWith(".docx"))
                {
                    ProcitajDOCX();
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

                OdabranaLokacija = "D:\\IV godina\\Zastita informacija\\Projekat\\OdredisnaLokacija\\";
            }
            else
            {
                if(!String.IsNullOrEmpty(FSWOdabranFajl))
                {
                    queue.Enqueue(FSWOdabranFajl);
                }
            }

        }


        private void NapraviDekodiraniTXT(String lokacija,String text,String startniFajl)
        {
            try
            {
                StreamWriter sw = new StreamWriter(lokacija);
                String dekriptovano = Knap.Dekriptuj(text);
                sw.Write(dekriptovano);
                if (!ukljucenFSW || (ukljucenFSW && String.Equals(FSWOdabranFajl, startniFajl)))
                    txtIzlaz.Text = dekriptovano;
                sw.Close();
                //if(ukljucenFSW)
                //{
                //    obradjeniFajlovi.Add(lokacija);
                //}
            }
            catch(IOException e)
            {
                MessageBox.Show("Izuzetak prilikom citanja fajla: " + e, "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void NapraviDekodiraniPDF(String lokacija, String text, String startniFajl)
        {

            Document doc = new Document(iTextSharp.text.PageSize.A4, 20, 20, 42, 35);
            PdfWriter pw = PdfWriter.GetInstance(doc, new FileStream(lokacija, FileMode.Create));

            doc.Open();
            String dekriptovano = Knap.Dekriptuj(text);
            if (!ukljucenFSW || (ukljucenFSW && String.Equals(FSWOdabranFajl, startniFajl)))
                txtIzlaz.Text = dekriptovano;
            Paragraph p = new Paragraph(dekriptovano);
            doc.Add(p);
            doc.Close();
            //if (ukljucenFSW)
            //{
            //    obradjeniFajlovi.Add(lokacija);
            //}

        }

        private void NapraviDekodiraniBIN(String lokacija, String text, String startniFajl)
        {

            try
            {
                using (BinaryWriter bw = new BinaryWriter(new FileStream(lokacija, FileMode.Create)))
                {
                    String dekriptovano = Knap.Dekriptuj(text);
                    bw.Write(dekriptovano);
                    if (!ukljucenFSW || (ukljucenFSW && String.Equals(FSWOdabranFajl, startniFajl)))
                        txtIzlaz.Text = dekriptovano;
                    bw.Close();

                    //if (ukljucenFSW)
                    //{
                    //    obradjeniFajlovi.Add(lokacija);
                    //}
                }

            }
            catch (IOException e)
            {
                MessageBox.Show("Izuzetak prilikom citanja fajla: " + e, "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }


        private void NapraviDekodiraniDOCX(String lokacija, String text, String startniFajl)
        {
            Word.Application objWord = new Word.Application();
            objWord.Visible = false;

            Word.Document objDoc = objWord.Documents.Add();

            Word.Paragraph objPara;
            objPara = objDoc.Paragraphs.Add();

            String dekriptovano = Knap.Dekriptuj(text);
            if (!ukljucenFSW || (ukljucenFSW && String.Equals(FSWOdabranFajl, startniFajl)))
                txtIzlaz.Text = dekriptovano;

            objPara.Range.Text = dekriptovano;

            objDoc.SaveAs(lokacija);
            objDoc.Close();
            objWord.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(objWord);
            //if (ukljucenFSW)
            //{
            //    obradjeniFajlovi.Add(lokacija);
            //}


        }

        private void cbxFSW_CheckedChanged(object sender, EventArgs e)
        {
            if(cbxFSW.Checked)
            {
                if (!javniGenerisan)
                {
                    MessageBox.Show("Morate prvo generisati javni ključ.");
                    cbxFSW.Checked = false;
                    return;
                }

                ukljucenFSW = true;
                watcher.EnableRaisingEvents = true;
                timer.Enabled = true;
            }
            else
            {
                ukljucenFSW = false;
                watcher.EnableRaisingEvents = false;
                timer.Enabled = false;
                OdabranaLokacija = "D:\\IV godina\\Zastita informacija\\Projekat\\OdredisnaLokacija\\";
                OdabranFajl = "";

            }
        }

        private void btnOdredisnaLok_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                FSWOdrediste = folderBrowserDialog.SelectedPath + "\\";
            }
            txtOdredisnaLokacija.Text = FSWOdrediste;
        }

        private void KnapsackForm_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    StreamReader sr = new StreamReader(new FileStream(cryptLog, FileMode.Open));
            //    String line = sr.ReadLine();

            //    while(line != null)
            //    {
            //        obradjeniFajlovi.Add(line);
            //        sr.ReadLine();
            //    }

            //    sr.Close();

            //}
            //catch (IOException ee)
            //{
            //    MessageBox.Show("Greska kod ucitavanja log fajla " + ee);
            //    return;
            //}



            String[] files = Directory.GetFiles(FSWUlaznaLokacija);

            foreach( string f in files)
            {
                if( !obradjeniFajlovi.Contains(f))
                {
                    queue.Enqueue(f);
                }
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
