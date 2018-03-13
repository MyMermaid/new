using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZIProjekat
{
    public partial class CodebookRecnik : Form
    {
        Codebook codeb;
        public CodebookRecnik(Codebook c)
        {
            InitializeComponent();
            Codeb = c;

            int lokY = 90;
            foreach (String rec in Codeb.Keys)
            {

                NapraviLabeluReci(rec, lokY);
                NapraviLabeluKoda((String)Codeb.HTReci1[rec], lokY);
                lokY += 40;
            }

            NapraviLabeluZavrsnu(lokY);
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

        private void CodebookRecnik_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
            this.Dispose();
        }

        private void CodebookRecnik_Load(object sender, EventArgs e)
        {
           
        }

        private void NapraviLabeluReci(String tekst, int locationY)
        {
            Label l = new Label();
            l.Text = tekst;
            l.Width = l.Text.Length * 11;
            l.AutoSize = true;
            l.Location = new System.Drawing.Point(96, locationY);
            panel1.Controls.AddRange(new System.Windows.Forms.Control[] { l, });

        }
        private void NapraviLabeluKoda(String tekst, int locationY)
        {
            Label l = new Label();
            l.Text = tekst;
            l.Width = l.Text.Length * 11;
            l.AutoSize = true;
            l.Location = new System.Drawing.Point(289, locationY);
            panel1.Controls.AddRange(new System.Windows.Forms.Control[] { l, });

        }
        private void NapraviLabeluZavrsnu(int locationY)
        {
            Label l = new Label();
            l.Text = "";
            l.Width = 200;
            l.Location = new System.Drawing.Point(63, locationY);
            panel1.Controls.AddRange(new System.Windows.Forms.Control[] { l, });

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
