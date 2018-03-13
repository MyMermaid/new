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
    public partial class OdabirAlgoritma : Form
    {

        Algoritam algoritam;


        public OdabirAlgoritma()
        {
            InitializeComponent();

            //labela, groupbox, dugme centrirani
            label1.Left = (this.ClientSize.Width - label1.Size.Width) / 2;
            panel1.Left = (this.ClientSize.Width - panel1.Size.Width) / 2;
            btnDalje.Left= (this.ClientSize.Width - btnDalje.Size.Width) / 2;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnDalje_Click(object sender, EventArgs e)
        {
            this.Hide();

            if (rbtnCodebook.Checked)
            {
                algoritam = new Codebook();
                CodebookForm cod = new CodebookForm(this,algoritam);
                cod.ShowDialog();
            }
            if(rbtnKnapsack.Checked)
            {
                algoritam = new Knapsack();
                KnapsackForm knap = new KnapsackForm(this,algoritam);
                knap.ShowDialog();
            }
            if(rbtnRC6.Checked)
            {
                algoritam = new RC6();
                RC6Form rc6 = new RC6Form(this,algoritam);
                rc6.ShowDialog();
            }
            if(rbtnTEA.Checked)
            {
                algoritam = new TEAXTEA_PCBC_mod();
                TEAXTEAForm tea = new TEAXTEAForm(this,algoritam);
                tea.ShowDialog();
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
