namespace ZIProjekat
{
    partial class RC6Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RC6Form));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.txtDestinationText = new System.Windows.Forms.TextBox();
            this.btnCrypt = new System.Windows.Forms.Button();
            this.txtSourceText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPocni = new System.Windows.Forms.Button();
            this.lblLokacija = new System.Windows.Forms.Label();
            this.lblFajlSacuvan = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtIzlaz = new System.Windows.Forms.TextBox();
            this.txtUlaz = new System.Windows.Forms.TextBox();
            this.lblUcitanKFajl = new System.Windows.Forms.Label();
            this.btnKriptujFajl = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblKljucGenerisan = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGenerisiKljuc = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKljuc = new System.Windows.Forms.TextBox();
            this.ofdDeKriptuj = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnKomunikacija = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btnMinimize);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Location = new System.Drawing.Point(0, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(910, 56);
            this.panel2.TabIndex = 9;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(14, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 28);
            this.label6.TabIndex = 27;
            this.label6.Text = "RC6";
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnMinimize.Location = new System.Drawing.Point(827, 11);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(32, 32);
            this.btnMinimize.TabIndex = 5;
            this.btnMinimize.Text = "_";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnExit.Location = new System.Drawing.Point(865, 11);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(32, 32);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.btnDecrypt);
            this.groupBox3.Controls.Add(this.txtDestinationText);
            this.groupBox3.Controls.Add(this.btnCrypt);
            this.groupBox3.Controls.Add(this.txtSourceText);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(471, 64);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(427, 408);
            this.groupBox3.TabIndex = 63;
            this.groupBox3.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(18, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 21);
            this.label8.TabIndex = 49;
            this.label8.Text = "Unesite tekst ispod";
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnDecrypt.FlatAppearance.BorderSize = 0;
            this.btnDecrypt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnDecrypt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecrypt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrypt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDecrypt.Location = new System.Drawing.Point(248, 359);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(158, 31);
            this.btnDecrypt.TabIndex = 53;
            this.btnDecrypt.Text = "Dekriptovanje";
            this.btnDecrypt.UseVisualStyleBackColor = false;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // txtDestinationText
            // 
            this.txtDestinationText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtDestinationText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDestinationText.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDestinationText.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtDestinationText.Location = new System.Drawing.Point(22, 240);
            this.txtDestinationText.Multiline = true;
            this.txtDestinationText.Name = "txtDestinationText";
            this.txtDestinationText.ReadOnly = true;
            this.txtDestinationText.Size = new System.Drawing.Size(384, 116);
            this.txtDestinationText.TabIndex = 52;
            // 
            // btnCrypt
            // 
            this.btnCrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnCrypt.FlatAppearance.BorderSize = 0;
            this.btnCrypt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnCrypt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnCrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrypt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrypt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCrypt.Location = new System.Drawing.Point(248, 195);
            this.btnCrypt.Name = "btnCrypt";
            this.btnCrypt.Size = new System.Drawing.Size(158, 31);
            this.btnCrypt.TabIndex = 51;
            this.btnCrypt.Text = "Kriptovanje";
            this.btnCrypt.UseVisualStyleBackColor = false;
            this.btnCrypt.Click += new System.EventHandler(this.btnCrypt_Click);
            // 
            // txtSourceText
            // 
            this.txtSourceText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtSourceText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSourceText.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSourceText.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtSourceText.Location = new System.Drawing.Point(22, 76);
            this.txtSourceText.Multiline = true;
            this.txtSourceText.Name = "txtSourceText";
            this.txtSourceText.Size = new System.Drawing.Size(384, 116);
            this.txtSourceText.TabIndex = 50;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label7.Location = new System.Drawing.Point(18, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(233, 21);
            this.label7.TabIndex = 49;
            this.label7.Text = "Kriptovanje unetog teksta ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPocni);
            this.groupBox2.Controls.Add(this.lblLokacija);
            this.groupBox2.Controls.Add(this.lblFajlSacuvan);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtIzlaz);
            this.groupBox2.Controls.Add(this.txtUlaz);
            this.groupBox2.Controls.Add(this.lblUcitanKFajl);
            this.groupBox2.Controls.Add(this.btnKriptujFajl);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(22, 183);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(437, 390);
            this.groupBox2.TabIndex = 64;
            this.groupBox2.TabStop = false;
            // 
            // btnPocni
            // 
            this.btnPocni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnPocni.FlatAppearance.BorderSize = 0;
            this.btnPocni.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnPocni.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnPocni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPocni.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPocni.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPocni.Location = new System.Drawing.Point(223, 62);
            this.btnPocni.Name = "btnPocni";
            this.btnPocni.Size = new System.Drawing.Size(152, 26);
            this.btnPocni.TabIndex = 69;
            this.btnPocni.Text = "Počni";
            this.btnPocni.UseVisualStyleBackColor = false;
            this.btnPocni.Click += new System.EventHandler(this.btnPocni_Click);
            // 
            // lblLokacija
            // 
            this.lblLokacija.AutoSize = true;
            this.lblLokacija.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLokacija.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblLokacija.Location = new System.Drawing.Point(18, 345);
            this.lblLokacija.Name = "lblLokacija";
            this.lblLokacija.Size = new System.Drawing.Size(66, 20);
            this.lblLokacija.TabIndex = 68;
            this.lblLokacija.Text = "lokacija\r\n";
            this.lblLokacija.Visible = false;
            // 
            // lblFajlSacuvan
            // 
            this.lblFajlSacuvan.AutoSize = true;
            this.lblFajlSacuvan.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFajlSacuvan.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblFajlSacuvan.Location = new System.Drawing.Point(18, 326);
            this.lblFajlSacuvan.Name = "lblFajlSacuvan";
            this.lblFajlSacuvan.Size = new System.Drawing.Size(215, 20);
            this.lblFajlSacuvan.TabIndex = 67;
            this.lblFajlSacuvan.Text = "Rezultat sacuvan na lokaciji:\r\n";
            this.lblFajlSacuvan.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label12.Location = new System.Drawing.Point(18, 209);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 21);
            this.label12.TabIndex = 63;
            this.label12.Text = "Izlaz";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label11.Location = new System.Drawing.Point(18, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 21);
            this.label11.TabIndex = 54;
            this.label11.Text = "Ulaz";
            // 
            // txtIzlaz
            // 
            this.txtIzlaz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtIzlaz.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIzlaz.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIzlaz.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtIzlaz.Location = new System.Drawing.Point(22, 230);
            this.txtIzlaz.Multiline = true;
            this.txtIzlaz.Name = "txtIzlaz";
            this.txtIzlaz.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtIzlaz.Size = new System.Drawing.Size(391, 83);
            this.txtIzlaz.TabIndex = 62;
            // 
            // txtUlaz
            // 
            this.txtUlaz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtUlaz.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUlaz.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUlaz.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtUlaz.Location = new System.Drawing.Point(22, 121);
            this.txtUlaz.Multiline = true;
            this.txtUlaz.Name = "txtUlaz";
            this.txtUlaz.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtUlaz.Size = new System.Drawing.Size(391, 85);
            this.txtUlaz.TabIndex = 54;
            // 
            // lblUcitanKFajl
            // 
            this.lblUcitanKFajl.AutoSize = true;
            this.lblUcitanKFajl.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUcitanKFajl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblUcitanKFajl.Location = new System.Drawing.Point(62, 39);
            this.lblUcitanKFajl.Name = "lblUcitanKFajl";
            this.lblUcitanKFajl.Size = new System.Drawing.Size(98, 20);
            this.lblUcitanKFajl.TabIndex = 61;
            this.lblUcitanKFajl.Text = "* Fajl učitan*\r\n";
            this.lblUcitanKFajl.Visible = false;
            // 
            // btnKriptujFajl
            // 
            this.btnKriptujFajl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnKriptujFajl.FlatAppearance.BorderSize = 0;
            this.btnKriptujFajl.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnKriptujFajl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnKriptujFajl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKriptujFajl.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKriptujFajl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnKriptujFajl.Location = new System.Drawing.Point(33, 62);
            this.btnKriptujFajl.Name = "btnKriptujFajl";
            this.btnKriptujFajl.Size = new System.Drawing.Size(152, 26);
            this.btnKriptujFajl.TabIndex = 60;
            this.btnKriptujFajl.Text = "Izaberi fajl";
            this.btnKriptujFajl.UseVisualStyleBackColor = false;
            this.btnKriptujFajl.Click += new System.EventHandler(this.btnKriptujFajl_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label9.Location = new System.Drawing.Point(18, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(167, 21);
            this.label9.TabIndex = 54;
            this.label9.Text = "Kriptovanje fajlova";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblKljucGenerisan);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnGenerisiKljuc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtKljuc);
            this.groupBox1.Location = new System.Drawing.Point(22, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 120);
            this.groupBox1.TabIndex = 65;
            this.groupBox1.TabStop = false;
            // 
            // lblKljucGenerisan
            // 
            this.lblKljucGenerisan.AutoSize = true;
            this.lblKljucGenerisan.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKljucGenerisan.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblKljucGenerisan.Location = new System.Drawing.Point(240, 18);
            this.lblKljucGenerisan.Name = "lblKljucGenerisan";
            this.lblKljucGenerisan.Size = new System.Drawing.Size(135, 20);
            this.lblKljucGenerisan.TabIndex = 76;
            this.lblKljucGenerisan.Text = "* Ključ generisan*\r\n";
            this.lblKljucGenerisan.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label10.Location = new System.Drawing.Point(125, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 21);
            this.label10.TabIndex = 75;
            this.label10.Text = "32";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(14, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 21);
            this.label5.TabIndex = 74;
            this.label5.Text = "Dužina reči:";
            // 
            // btnGenerisiKljuc
            // 
            this.btnGenerisiKljuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnGenerisiKljuc.FlatAppearance.BorderSize = 0;
            this.btnGenerisiKljuc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnGenerisiKljuc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnGenerisiKljuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerisiKljuc.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerisiKljuc.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGenerisiKljuc.Location = new System.Drawing.Point(214, 76);
            this.btnGenerisiKljuc.Name = "btnGenerisiKljuc";
            this.btnGenerisiKljuc.Size = new System.Drawing.Size(199, 31);
            this.btnGenerisiKljuc.TabIndex = 73;
            this.btnGenerisiKljuc.Text = "Generiši ključ";
            this.btnGenerisiKljuc.UseVisualStyleBackColor = false;
            this.btnGenerisiKljuc.Click += new System.EventHandler(this.btnGenerisiKljuc_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(14, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 21);
            this.label3.TabIndex = 72;
            this.label3.Text = "Korisnički ključ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(109, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 21);
            this.label1.TabIndex = 71;
            this.label1.Text = "20";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label2.Location = new System.Drawing.Point(18, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 21);
            this.label2.TabIndex = 70;
            this.label2.Text = "Generisanje ključa ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(14, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 21);
            this.label4.TabIndex = 44;
            this.label4.Text = "Broj rundi:";
            // 
            // txtKljuc
            // 
            this.txtKljuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtKljuc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKljuc.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKljuc.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtKljuc.Location = new System.Drawing.Point(148, 41);
            this.txtKljuc.Name = "txtKljuc";
            this.txtKljuc.Size = new System.Drawing.Size(265, 26);
            this.txtKljuc.TabIndex = 42;
            this.txtKljuc.Text = "264826313683";
            // 
            // ofdDeKriptuj
            // 
            this.ofdDeKriptuj.Filter = "Bin Files (*.bin)|*.bin|All files (*.*)|*.*";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnKomunikacija);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Location = new System.Drawing.Point(471, 474);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(427, 99);
            this.groupBox4.TabIndex = 66;
            this.groupBox4.TabStop = false;
            // 
            // btnKomunikacija
            // 
            this.btnKomunikacija.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnKomunikacija.FlatAppearance.BorderSize = 0;
            this.btnKomunikacija.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnKomunikacija.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnKomunikacija.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKomunikacija.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKomunikacija.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnKomunikacija.Location = new System.Drawing.Point(80, 46);
            this.btnKomunikacija.Name = "btnKomunikacija";
            this.btnKomunikacija.Size = new System.Drawing.Size(277, 33);
            this.btnKomunikacija.TabIndex = 38;
            this.btnKomunikacija.Text = "Pokreni komunikaciju";
            this.btnKomunikacija.UseVisualStyleBackColor = false;
            this.btnKomunikacija.Click += new System.EventHandler(this.btnKomunikacija_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label13.Location = new System.Drawing.Point(18, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(119, 21);
            this.label13.TabIndex = 34;
            this.label13.Text = "Komunikacija";
            // 
            // RC6Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(911, 585);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RC6Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RC6";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RC6Form_FormClosing);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.TextBox txtDestinationText;
        private System.Windows.Forms.Button btnCrypt;
        private System.Windows.Forms.TextBox txtSourceText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPocni;
        private System.Windows.Forms.Label lblLokacija;
        private System.Windows.Forms.Label lblFajlSacuvan;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtIzlaz;
        private System.Windows.Forms.TextBox txtUlaz;
        private System.Windows.Forms.Label lblUcitanKFajl;
        private System.Windows.Forms.Button btnKriptujFajl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKljuc;
        private System.Windows.Forms.Button btnGenerisiKljuc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblKljucGenerisan;
        private System.Windows.Forms.OpenFileDialog ofdDeKriptuj;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnKomunikacija;
        private System.Windows.Forms.Label label13;
    }
}