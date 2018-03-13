using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace ZIProjekat
{
    public partial class CodebookForm : Form
    {
        private OdabirAlgoritma pocetna;
        private Codebook codeb;
        private bool modSimulacije;
        private bool SimulacijaText;
        private String OdabranFajl;

        private Hashtable prvi;
        private Hashtable drugi;

        public CodebookForm( OdabirAlgoritma poc,Algoritam cod)
        {
            InitializeComponent();
            Pocetna = poc;
            Codeb = (Codebook)cod;
            modSimulacije = false;
            SimulacijaText = true;

            prvi = new Hashtable();
            drugi = new Hashtable();

            cbxRecnici.SelectedIndex = 0;
           
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

        public Codebook Codeb
        {
            get
            {
                return codeb;
            }

            set
            {
                codeb = value;
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

        private void CodebookForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
            this.Dispose();
            Pocetna.Show();
            
        }

        private void btnCrypt_Click(object sender, EventArgs e)
        {
            if (!modSimulacije)
            {
                txtDestinationText.Text = Codeb.Kriptuj(txtSourceText.Text);
            }
            else
            { 
                
                btnCrypt.Enabled = false;
                btnDecrypt.Enabled = false;

                String kriptovanaRecenica = "";
                txtDestinationText.Text = " ";
                String[] separators = { " ", "  ", "   " };
                String[] reci = txtSourceText.Text.Split(separators, StringSplitOptions.None);

                int l = reci.Length;

                String rec;

                for (int i=0; i< l; i++)
                {
                    rec = reci[i];
                    if (String.Equals(rec, "San"))
                    {
                        if (String.Equals(reci[i + 1], "Francisko"))
                        {
                            rec += " " + reci[i + 1];
                            i++;
                        }
                    }

                    txtUlaz.Text = rec;
                    String kriptovanaRec = Codeb.Kriptuj(rec);
                    txtIzlaz.Text = kriptovanaRec;
                    kriptovanaRecenica += kriptovanaRec;

                    //cekanje 2 sekunde
                    DateTime Tthen = DateTime.Now;
                    do
                    {
                        Application.DoEvents();
                    } while (Tthen.AddSeconds(2) > DateTime.Now);
                }

                
                txtDestinationText.Text = kriptovanaRecenica;

                btnCrypt.Enabled = true;
                btnDecrypt.Enabled = true;
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (!modSimulacije)
            {
                txtDestinationText.Text = Codeb.Dekriptuj(txtDestinationText.Text);
            }
            else
            {
                btnCrypt.Enabled = false;
                btnDecrypt.Enabled = false;
                String dekriptovanaRecenica = "";
                String[] separators = { " ", "  ", "   " };
                String[] reci = txtDestinationText.Text.Split(separators, StringSplitOptions.None);
                foreach (String rec in reci)
                {
                    txtUlaz.Text = rec;
                    String dekriptovanaRec = Codeb.Dekriptuj(rec);
                    txtIzlaz.Text = dekriptovanaRec;
                    dekriptovanaRecenica += dekriptovanaRec;

                    //cekanje 2 sekunde
                    DateTime Tthen = DateTime.Now;
                    do
                    {
                        Application.DoEvents();
                    } while (Tthen.AddSeconds(2) > DateTime.Now);
                }
                txtDestinationText.Text = dekriptovanaRecenica;

                btnCrypt.Enabled = true;
                btnDecrypt.Enabled = true;
            }
        }

        private void cbxSimulacija_CheckedChanged(object sender, EventArgs e)
        {
            if(cbxSimulacija.Checked)
            {
                label5.ForeColor = Color.WhiteSmoke;
                label2.ForeColor = Color.WhiteSmoke;
                modSimulacije = true;

                rbtnFajl.Enabled = true;
                rbtnUnetiTekst.Enabled = true;
                if (rbtnFajl.Checked)
                {
                    btnPocniFajl.Enabled = true;
                    btnIzaberiFajl.Enabled = true;
                    btnCrypt.Enabled = false;
                    btnDecrypt.Enabled = false;
                }
                else
                {
                    btnPocniFajl.Enabled = false;
                    btnIzaberiFajl.Enabled = false;
                    btnCrypt.Enabled = true;
                    btnDecrypt.Enabled = true;
                }

            }
            else
            {
                label5.ForeColor = Color.DarkGray;
                label2.ForeColor = Color.DarkGray;
                txtUlaz.Text = "";
                txtIzlaz.Text = "";
                modSimulacije = false;

                rbtnFajl.Enabled = false;
                rbtnUnetiTekst.Enabled = false;
                btnPocniFajl.Enabled = false;
                btnIzaberiFajl.Enabled = false;

                btnCrypt.Enabled = true;
                btnDecrypt.Enabled = true;

            }
        }

        private void btnRecnik_Click(object sender, EventArgs e)
        {
            CodebookRecnik recnik = new CodebookRecnik(Codeb);
            recnik.Show();
        }

        private void rbtnUnetiTekst_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtnUnetiTekst.Checked)
            {
                btnCrypt.Enabled = true;
                btnDecrypt.Enabled = true;
                btnIzaberiFajl.Enabled = false;
                btnPocniFajl.Enabled = false;
            }
            else
            {
                btnCrypt.Enabled = false;
                btnDecrypt.Enabled = false;
                btnIzaberiFajl.Enabled = true;
                btnPocniFajl.Enabled = true;
            }
        }

        private void rbtnFajl_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtnFajl.Checked)
            {
                btnCrypt.Enabled = false;
                btnDecrypt.Enabled = false;
                btnIzaberiFajl.Enabled = true;
                btnPocniFajl.Enabled = true;
            }
            else
            {
                btnCrypt.Enabled = true;
                btnDecrypt.Enabled = true;
                btnIzaberiFajl.Enabled = false;
                btnPocniFajl.Enabled = false;
            }
        }

        private void btnIzaberiFajl_Click(object sender, EventArgs e)
        {
            if(IzaberiFajl.ShowDialog()==DialogResult.OK)
            {
                OdabranFajl = IzaberiFajl.FileName;

                lblUcitanFajl.Visible = true;
            }

            
        }

        private void btnPocniFajl_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(OdabranFajl))
            {
                MessageBox.Show("Nije odabran fajl!");
                return;
            }

            if (OdabranFajl.EndsWith(".txt"))
            {
                ProcitajTXT();
            }
            else
            {
                ProcitajBIN();
            }

            OdabranFajl = "";
            lblUcitanFajl.Visible = false;
        }

        private void ProcitajTXT()
        {
            String line;
            bool kriptovanje;
            try
            {

                StreamReader sr = new StreamReader(OdabranFajl);
              //  StreamWriter sw = new StreamWriter("D:\\IV godina\\Zastita informacija\\Projekat\\OdredisnaLokacija\\BBBlakod.txt");

                line = sr.ReadLine();
                if (line.Contains("Kriptovano codebookom"))
                {
                    kriptovanje = false;
                    //prvu liniju preskacemo
                    line = sr.ReadLine();

                }
                else
                {
                    kriptovanje = true;
                  //  sw.WriteLine("Kriptovano codebookom");
                }

                while (line != null)
                {
                    txtUlaz.Text = line;

                    if (kriptovanje)
                    {
                        String text = Codeb.Kriptuj(line);
                        txtIzlaz.Text = text;
                      //  sw.WriteLine(text);
                    }
                    else
                    {
                        txtIzlaz.Text = Codeb.Dekriptuj(line);

                    }


                    line = sr.ReadLine();

                    //cekanje 3 sekunde
                    DateTime Tthen = DateTime.Now;
                    do
                    {
                        Application.DoEvents();
                    } while (Tthen.AddSeconds(3) > DateTime.Now);

                }

                sr.Close();
               // sw.Close();

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
                //while (br.BaseStream.Position != br.BaseStream.Length)
                //{
                //    b = br.ReadByte();

                //    txtUlaz.Text = b.ToString();

                //    txtIzlaz.Text = Codeb.Dekriptuj(b.ToString());

                //}
                //while (br.PeekChar() != -1)
                //{
                //    b = br.ReadByte();

                //    txtUlaz.Text = b.ToString();
                //    txtIzlaz.Text = Codeb.Dekriptuj(b.ToString());
                //}

                String text = "";

                bytes = br.ReadBytes((int)fs.Length);

                foreach(byte b in bytes)
                {
                    text += b.ToString() + " ";
                }
                if (text.Length > 30)
                {
                    String subtext = "";
                    while (!String.IsNullOrEmpty(text))
                    {
                        if(text.Length<30)
                        {
                            subtext = text.Substring(0, text.Length);
                            text = "";
                        }
                        else
                        {
                            subtext = text.Substring(0, 30);
                            text = text.Remove(0, 30);

                        }


                        txtUlaz.Text = subtext;

                        txtIzlaz.Text = Codeb.Dekriptuj(subtext);
                        //cekanje 3 sekunde
                        DateTime Tthen = DateTime.Now;
                        do
                        {
                            Application.DoEvents();
                        } while (Tthen.AddSeconds(3) > DateTime.Now);

                    }
                }
                else
                {
                    txtUlaz.Text = text;
                    txtIzlaz.Text = Codeb.Dekriptuj(text);
                }

            }
            catch (IOException e)
            {
                MessageBox.Show("Izuzetak prilikom citanja fajla: " + e, "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            finally
            {
                br.Close();
            }

        }

        private void cbxRecnici_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxRecnici.SelectedIndex == 0)
            {
                Codeb.HTReci1 = prvi;
                Codeb.Keys = prvi.Keys;
            }
            else
            {
                Codeb.HTReci1 = drugi;
                Codeb.Keys = drugi.Keys;
            }
        }

        private void CodebookForm_Load(object sender, EventArgs e)
        {
            String line;

            using (StreamReader sr = new StreamReader("C:\\Users\\Nina\\documents\\visual studio 2015\\Projects\\ZIProjekat\\ZIProjekat\\Rečnici\\Recnik1.txt"))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    String[] reci = line.Split('-');
                    prvi.Add(reci[0], reci[1]);
                }
            }
            using (StreamReader sr = new StreamReader("C:\\Users\\Nina\\documents\\visual studio 2015\\Projects\\ZIProjekat\\ZIProjekat\\Rečnici\\Recnik2.txt"))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    String[] reci = line.Split('-');
                    drugi.Add(reci[0], reci[1]);
                }
            }

            if(cbxRecnici.SelectedIndex==0)
            {
                Codeb.HTReci1 = prvi;
                Codeb.Keys = prvi.Keys;
            }
            else
            {
                Codeb.HTReci1 = drugi;
                Codeb.Keys = drugi.Keys;
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
