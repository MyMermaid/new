using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace ZIProjekat
{
    public partial class Client : Form
    {
        RC6 rc6;
        private Thread clientThread;
        private static readonly Socket ClientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        private const int PORT = 4030;

        System.Timers.Timer timer;

        string odabrano;

        //delegate void StringArgReturningVoidDelegate(string text);
        private delegate void ObjectDelegate(object obj);
        ObjectDelegate del;


        public Client(RC6 alg)
        {
            InitializeComponent();

            odabrano = "Alisa";

            timer = new System.Timers.Timer(300);

            timer.Elapsed += new System.Timers.ElapsedEventHandler(Obradi);
            timer.Enabled = false;

            del = new ObjectDelegate(UpdateTextBox);

            Rc6 = alg;

            txtDestinationText.Enabled = false;
            txtSourceText.Enabled = false;
            btnSend.Enabled = false;

            lblPrimUnesi.Text = "Unesi poruku ispod";
            lblPrimPosl.Text = "Poslato:";

            btnPokreni.Left = (this.ClientSize.Width - btnPokreni.Size.Width) / 2;
            lblPokretanje.Left = (this.ClientSize.Width - lblPokretanje.Size.Width + (btnPokreni.Size.Width - lblPokretanje.Size.Width) / 2) / 2;
            lblPokusaj.Left = (this.ClientSize.Width - lblPokretanje.Size.Width + (btnPokreni.Size.Width - lblPokretanje.Size.Width) / 2) / 2;


        }

        private void Obradi(object sender, ElapsedEventArgs e)
        {
            if (String.Equals(odabrano, "Bob"))
            {
                clientThread = new Thread(ReceiveResponse);
                clientThread.Start();

            }
        }

        private void ConnectToServer()
        {
            int attempts = 0;

            while (!ClientSocket.Connected)
            {
                try
                {
                    attempts++;
                    lblPokusaj.Text = "Broj pokušaja " + attempts;
                    // Change IPAddress.Loopback to a remote IP to connect to a remote host.
                    ClientSocket.Connect(IPAddress.Loopback, PORT);
                }
                catch (SocketException)
                {
                    lblPokusaj.Text = "Neuspešno pokretanje...";
                } 
            }


            lblPokretanje.Text = "Klijent pokrenut.";
            //lblInfo2.Text = "<Type \"exit\" to properly disconnect client>";

        }

        private void SendMessage()
        {
            string msg = txtSourceText.Text;
            SendString(msg);

            //if (request.ToLower() == "exit")
            //{
            //    Exit();
            //}
        }

        private void SendString(string text)
        {

            byte[] buffer = Rc6.GetBytes(text);

            byte[] outputText = Rc6.Enc(buffer);

            ClientSocket.Send(outputText, 0, outputText.Length, SocketFlags.None);
        }

        private void ReceiveResponse()
        {
            var buffer = new byte[2048];
            int received = ClientSocket.Receive(buffer, SocketFlags.None);
            if (received == 0) return;
           
                var data = new byte[received];
                Array.Copy(buffer, data, received);


            if (String.Equals(odabrano, "Bob"))
            {
                String text1 = Rc6.GetString(data);
                txtSourceText.Text = text1;

                byte[] outputText = Rc6.Dec(data);
                string text = Rc6.GetString(outputText);

                string dekr = Rc6.Dekriptuj(text);
                String zaPrikaz = "Primljeno: " + text;
                txtDestinationText.Text += zaPrikaz;
                txtDestinationText.Text += "\r\n";
            }
            else
            {
                String text1 = Rc6.GetString(data);
                String zaPrikaz = "Poslato: " + text1;
                txtDestinationText.Text += zaPrikaz;
                txtDestinationText.Text += "\r\n";
            }
            // listMessages.Items.Add("Received: " + text);

        }

        //private static void Exit()
        //{
        //    SendString("exit"); // Tell the server we are exiting
        //    ClientSocket.Shutdown(SocketShutdown.Both);
        //    ClientSocket.Close();
        //    Environment.Exit(0);
        //}

        private void UpdateTextBox(object obj)
        {

            // do we need to switch threads?

            if (InvokeRequired)

            {

                // we then create the delegate again

                // if you've made it global then you won't need to do this

                ObjectDelegate method = new ObjectDelegate(UpdateTextBox);



                // we then simply invoke it and return

                Invoke(method, obj);

                return;

            }

            // ok so now we're here, this means we're able to update the control

            // so we unbox the object into a string

            string text = (string)obj;

            // and update

            if (String.Equals(odabrano, "Bob"))
            {
                txtSourceText.Text = text;

                string dekr = Rc6.Dekriptuj(text);

                txtDestinationText.Text += dekr + "\r\n";

            }
            else
            {
                txtDestinationText.Text += text + "\r\n";
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

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

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

        private void btnPokreni_Click(object sender, EventArgs e)
        {
            btnPokreni.Enabled = false;
            rbtnAlisa.Enabled = false;
            rbtnBob.Enabled = false;

            lblPokretanje.Visible = true;
            lblPokusaj.Visible = true;

            ConnectToServer();

            if (String.Equals(odabrano, "Bob"))
            {
                timer.Enabled = true;
            }


            // SendString(odabrano);
            byte[] outputText = ASCIIEncoding.ASCII.GetBytes(odabrano);
            ClientSocket.Send(outputText, 0, outputText.Length, SocketFlags.None);

            txtDestinationText.Enabled = true;
            txtSourceText.Enabled = true;

            if (rbtnAlisa.Checked)
            {
                btnSend.Enabled = true;

                lblPrimUnesi.Text = "Unesi poruku ispod";
                lblPrimPosl.Text = "Poslato:";
            }
            else
            {
                btnSend.Visible = false;

                lblPrimUnesi.Text = "Primljena poruka:";
                lblPrimPosl.Text = "Sve dekodirane poruke:";
            }

        }

        private void rbtnAlisa_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnAlisa.Checked)
            {
                odabrano = "Alisa";
                clientThread = null;
            }
            else
            {
                odabrano = "Bob";
                btnSend.Enabled = false;
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            SendMessage();
            txtSourceText.Clear();
            ReceiveResponse();
        }

        private void Client_FormClosing(object sender, FormClosingEventArgs e)
        {
            //ClientSocket.Shutdown(SocketShutdown.Both);
            //ClientSocket.Close();
            e.Cancel = false;
        }
    }
}
