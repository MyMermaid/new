using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class Server : Form
    {
        private static readonly Socket serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        private static readonly List<Socket> clientSockets = new List<Socket>();
        //  private static readonly List<Socket> clientSocketsAlisa = new List<Socket>();
        private static readonly List<Socket> clientSocketsBob = new List<Socket>();
        private const int BUFFER_SIZE = 2048;
        private const int PORT = 4030;
        private static readonly byte[] buffer = new byte[BUFFER_SIZE];

        public Server()
        {
            InitializeComponent();
            txtIP.Text = "127.0.0.1";
            txtPort.Text = "4030";

            lblPokretanje.Left= (this.ClientSize.Width - btnPokreni.Size.Width + (btnPokreni.Size.Width - lblPokretanje.Size.Width)/2) / 2;
            btnPokreni.Left= (this.ClientSize.Width - lblPokretanje.Size.Width ) / 2;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public void SetupServer()
        {

            lblPokretanje.Visible = true;
            serverSocket.Bind(new IPEndPoint(IPAddress.Any, PORT));
            serverSocket.Listen(5);
            serverSocket.BeginAccept(AcceptCallback, null);
            lblPokretanje.Text = "Server pokrenut.";
            lblPokretanje.Left = (this.ClientSize.Width - lblPokretanje.Size.Width + (btnPokreni.Size.Width - lblPokretanje.Size.Width)/2) / 2;

            btnMinimize.Focus();
        }

        private void AcceptCallback(IAsyncResult AR)
        {
            Socket socket;

            try
            {
                socket = serverSocket.EndAccept(AR);
            }
            catch (ObjectDisposedException) // I cannot seem to avoid this (on exit when properly closing sockets)
            {
                return;
            }

            clientSockets.Add(socket);
            socket.BeginReceive(buffer, 0, BUFFER_SIZE, SocketFlags.None, ReceiveCallback, socket);
            // lblClientInfo.Text="Client connected, waiting for request...";
            serverSocket.BeginAccept(AcceptCallback, null);
        }

        private void ReceiveCallback(IAsyncResult AR)
        {
            Socket current = (Socket)AR.AsyncState;
            int received;

            try
            {
                received = current.EndReceive(AR);
            }
            catch (SocketException)
            {

                // Don't shutdown because the socket may be disposed and its disconnected anyway.
                current.Close();
                clientSockets.Remove(current);
                return;
            }

            byte[] recBuf = new byte[received];
            Array.Copy(buffer, recBuf, received);
            string text = Encoding.ASCII.GetString(recBuf);

            if (text.ToLower() == "alisa") // Client requested time
            {
               
            }
            else
            {
                if (text.ToLower() == "bob") // Client requested time
                {
                    
                    clientSocketsBob.Add(current);
                }
                else if (text.ToLower() == "exit") // Client wants to exit gracefully
                {
                    // Always Shutdown before closing
                    current.Shutdown(SocketShutdown.Both);
                    current.Close();
                    clientSockets.Remove(current);

                    foreach (Socket s in clientSocketsBob)
                    {
                        s.Shutdown(SocketShutdown.Both);
                        s.Close();
                        clientSocketsBob.Remove(s);
                    }

                  
                    return;
                }
                else
                {

                    foreach (Socket s in clientSocketsBob)
                    {
                        s.Send(recBuf);
                        s.BeginReceive(buffer, 0, BUFFER_SIZE, SocketFlags.None, ReceiveCallback, current);
                    }

                    current.Send(recBuf);
                }
            }
            current.BeginReceive(buffer, 0, BUFFER_SIZE, SocketFlags.None, ReceiveCallback, current);
        }

        private static void CloseAllSockets()
        {
            foreach (Socket socket in clientSockets)
            {
                socket.Shutdown(SocketShutdown.Both);
                socket.Close();
            }
            //foreach (Socket socket in clientSocketsBob)
            //{
            //    socket.Shutdown(SocketShutdown.Both);
            //    socket.Close();
            //}
            serverSocket.Close();
        }



        private void btnPokreni_Click(object sender, EventArgs e)
        {
            SetupServer();
            btnPokreni.Enabled = false;
        }

        private void Server_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseAllSockets();
            e.Cancel = false;
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
