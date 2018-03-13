namespace ZIProjekat
{
    partial class KnapsackForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KnapsackForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrivatni = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.txtJavni = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGenerisiJavni = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblIM = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.txtDestinationText = new System.Windows.Forms.TextBox();
            this.btnCrypt = new System.Windows.Forms.Button();
            this.txtSourceText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnOdredisnaLok = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtOdredisnaLokacija = new System.Windows.Forms.TextBox();
            this.txtUlaznaLokacija = new System.Windows.Forms.TextBox();
            this.cbxFSW = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
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
            this.ofdDeKriptuj = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btnMinimize);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Location = new System.Drawing.Point(1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(968, 58);
            this.panel2.TabIndex = 8;
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
            this.label6.Size = new System.Drawing.Size(129, 28);
            this.label6.TabIndex = 27;
            this.label6.Text = "Knapsack";
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
            this.btnMinimize.Location = new System.Drawing.Point(888, 11);
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
            this.btnExit.Location = new System.Drawing.Point(926, 11);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(32, 32);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(21, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 21);
            this.label4.TabIndex = 35;
            this.label4.Text = "Privatni:";
            // 
            // txtPrivatni
            // 
            this.txtPrivatni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtPrivatni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrivatni.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrivatni.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtPrivatni.Location = new System.Drawing.Point(103, 45);
            this.txtPrivatni.Name = "txtPrivatni";
            this.txtPrivatni.ReadOnly = true;
            this.txtPrivatni.Size = new System.Drawing.Size(200, 26);
            this.txtPrivatni.TabIndex = 36;
            this.txtPrivatni.Text = "2, 3, 7, 14, 30, 57, 120, 251";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(322, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 21);
            this.label1.TabIndex = 37;
            this.label1.Text = "m:";
            // 
            // txtM
            // 
            this.txtM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtM.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtM.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtM.Location = new System.Drawing.Point(358, 45);
            this.txtM.Name = "txtM";
            this.txtM.ReadOnly = true;
            this.txtM.Size = new System.Drawing.Size(28, 26);
            this.txtM.TabIndex = 38;
            this.txtM.Text = "41";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(401, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 21);
            this.label2.TabIndex = 39;
            this.label2.Text = "n:";
            // 
            // txtN
            // 
            this.txtN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtN.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtN.Location = new System.Drawing.Point(431, 45);
            this.txtN.Name = "txtN";
            this.txtN.ReadOnly = true;
            this.txtN.Size = new System.Drawing.Size(37, 26);
            this.txtN.TabIndex = 40;
            this.txtN.Text = "491";
            // 
            // txtJavni
            // 
            this.txtJavni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtJavni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtJavni.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJavni.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtJavni.Location = new System.Drawing.Point(103, 99);
            this.txtJavni.Name = "txtJavni";
            this.txtJavni.ReadOnly = true;
            this.txtJavni.Size = new System.Drawing.Size(200, 26);
            this.txtJavni.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(38, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 21);
            this.label3.TabIndex = 42;
            this.label3.Text = "Javni:";
            // 
            // btnGenerisiJavni
            // 
            this.btnGenerisiJavni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnGenerisiJavni.FlatAppearance.BorderSize = 0;
            this.btnGenerisiJavni.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnGenerisiJavni.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnGenerisiJavni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerisiJavni.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerisiJavni.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGenerisiJavni.Location = new System.Drawing.Point(313, 92);
            this.btnGenerisiJavni.Name = "btnGenerisiJavni";
            this.btnGenerisiJavni.Size = new System.Drawing.Size(155, 36);
            this.btnGenerisiJavni.TabIndex = 45;
            this.btnGenerisiJavni.Text = "Generiši javni ";
            this.btnGenerisiJavni.UseVisualStyleBackColor = false;
            this.btnGenerisiJavni.Click += new System.EventHandler(this.btnGenerisiJavni_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblIM);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtPrivatni);
            this.groupBox1.Controls.Add(this.btnGenerisiJavni);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtJavni);
            this.groupBox1.Controls.Add(this.txtM);
            this.groupBox1.Controls.Add(this.txtN);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(21, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(491, 141);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            // 
            // lblIM
            // 
            this.lblIM.AutoSize = true;
            this.lblIM.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIM.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblIM.Location = new System.Drawing.Point(118, 71);
            this.lblIM.Name = "lblIM";
            this.lblIM.Size = new System.Drawing.Size(42, 20);
            this.lblIM.TabIndex = 69;
            this.lblIM.Text = "im = ";
            this.lblIM.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label5.Location = new System.Drawing.Point(18, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 21);
            this.label5.TabIndex = 47;
            this.label5.Text = "Privatni i javni ključ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.btnDecrypt);
            this.groupBox3.Controls.Add(this.txtDestinationText);
            this.groupBox3.Controls.Add(this.btnCrypt);
            this.groupBox3.Controls.Add(this.txtSourceText);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(520, 64);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(427, 331);
            this.groupBox3.TabIndex = 48;
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
            this.btnDecrypt.Location = new System.Drawing.Point(246, 281);
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
            this.txtDestinationText.Location = new System.Drawing.Point(22, 202);
            this.txtDestinationText.Multiline = true;
            this.txtDestinationText.Name = "txtDestinationText";
            this.txtDestinationText.ReadOnly = true;
            this.txtDestinationText.Size = new System.Drawing.Size(382, 76);
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
            this.btnCrypt.Location = new System.Drawing.Point(246, 160);
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
            this.txtSourceText.Location = new System.Drawing.Point(22, 80);
            this.txtSourceText.Multiline = true;
            this.txtSourceText.Name = "txtSourceText";
            this.txtSourceText.Size = new System.Drawing.Size(382, 76);
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
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnOdredisnaLok);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.txtOdredisnaLokacija);
            this.groupBox4.Controls.Add(this.txtUlaznaLokacija);
            this.groupBox4.Controls.Add(this.cbxFSW);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Location = new System.Drawing.Point(520, 395);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(427, 183);
            this.groupBox4.TabIndex = 58;
            this.groupBox4.TabStop = false;
            // 
            // btnOdredisnaLok
            // 
            this.btnOdredisnaLok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnOdredisnaLok.FlatAppearance.BorderSize = 0;
            this.btnOdredisnaLok.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnOdredisnaLok.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnOdredisnaLok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdredisnaLok.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdredisnaLok.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnOdredisnaLok.Location = new System.Drawing.Point(186, 142);
            this.btnOdredisnaLok.Name = "btnOdredisnaLok";
            this.btnOdredisnaLok.Size = new System.Drawing.Size(218, 26);
            this.btnOdredisnaLok.TabIndex = 46;
            this.btnOdredisnaLok.Text = "Promeni izlaznu lokaciju";
            this.btnOdredisnaLok.UseVisualStyleBackColor = false;
            this.btnOdredisnaLok.Click += new System.EventHandler(this.btnOdredisnaLok_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label13.Location = new System.Drawing.Point(20, 103);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 21);
            this.label13.TabIndex = 45;
            this.label13.Text = "Izlaz:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label14.Location = new System.Drawing.Point(20, 71);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 21);
            this.label14.TabIndex = 44;
            this.label14.Text = "Ulaz:";
            // 
            // txtOdredisnaLokacija
            // 
            this.txtOdredisnaLokacija.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtOdredisnaLokacija.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOdredisnaLokacija.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOdredisnaLokacija.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtOdredisnaLokacija.Location = new System.Drawing.Point(75, 102);
            this.txtOdredisnaLokacija.Name = "txtOdredisnaLokacija";
            this.txtOdredisnaLokacija.ReadOnly = true;
            this.txtOdredisnaLokacija.Size = new System.Drawing.Size(331, 26);
            this.txtOdredisnaLokacija.TabIndex = 43;
            // 
            // txtUlaznaLokacija
            // 
            this.txtUlaznaLokacija.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtUlaznaLokacija.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUlaznaLokacija.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUlaznaLokacija.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtUlaznaLokacija.Location = new System.Drawing.Point(75, 70);
            this.txtUlaznaLokacija.Name = "txtUlaznaLokacija";
            this.txtUlaznaLokacija.ReadOnly = true;
            this.txtUlaznaLokacija.Size = new System.Drawing.Size(331, 26);
            this.txtUlaznaLokacija.TabIndex = 42;
            // 
            // cbxFSW
            // 
            this.cbxFSW.AutoSize = true;
            this.cbxFSW.Location = new System.Drawing.Point(88, 37);
            this.cbxFSW.Name = "cbxFSW";
            this.cbxFSW.Size = new System.Drawing.Size(245, 25);
            this.cbxFSW.TabIndex = 35;
            this.cbxFSW.Text = "Uključi file system watcher";
            this.cbxFSW.UseVisualStyleBackColor = true;
            this.cbxFSW.CheckedChanged += new System.EventHandler(this.cbxFSW_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label10.Location = new System.Drawing.Point(18, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(174, 21);
            this.label10.TabIndex = 34;
            this.label10.Text = "File System Watcher";
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
            this.groupBox2.Location = new System.Drawing.Point(21, 204);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(491, 374);
            this.groupBox2.TabIndex = 59;
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
            this.btnPocni.Location = new System.Drawing.Point(227, 62);
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
            this.lblLokacija.Location = new System.Drawing.Point(18, 332);
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
            this.lblFajlSacuvan.Location = new System.Drawing.Point(18, 314);
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
            this.label12.Location = new System.Drawing.Point(18, 206);
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
            this.txtIzlaz.Location = new System.Drawing.Point(22, 228);
            this.txtIzlaz.Multiline = true;
            this.txtIzlaz.Name = "txtIzlaz";
            this.txtIzlaz.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtIzlaz.Size = new System.Drawing.Size(446, 82);
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
            this.txtUlaz.Size = new System.Drawing.Size(446, 82);
            this.txtUlaz.TabIndex = 54;
            // 
            // lblUcitanKFajl
            // 
            this.lblUcitanKFajl.AutoSize = true;
            this.lblUcitanKFajl.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUcitanKFajl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblUcitanKFajl.Location = new System.Drawing.Point(74, 39);
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
            this.btnKriptujFajl.Location = new System.Drawing.Point(50, 62);
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
            // ofdDeKriptuj
            // 
            this.ofdDeKriptuj.Filter = "Txt files (*.txt)|*.txt|Bin Files (*.bin)|*.bin|All files (*.*)|*.*";
            // 
            // KnapsackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(971, 589);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "KnapsackForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Knapsack";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KnapsackForm_FormClosing);
            this.Load += new System.EventHandler(this.KnapsackForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrivatni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.TextBox txtJavni;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGenerisiJavni;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDestinationText;
        private System.Windows.Forms.Button btnCrypt;
        private System.Windows.Forms.TextBox txtSourceText;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtIzlaz;
        private System.Windows.Forms.TextBox txtUlaz;
        private System.Windows.Forms.Button btnKriptujFajl;
        private System.Windows.Forms.Label lblUcitanKFajl;
        private System.Windows.Forms.OpenFileDialog ofdDeKriptuj;
        private System.Windows.Forms.Label lblLokacija;
        private System.Windows.Forms.Label lblFajlSacuvan;
        private System.Windows.Forms.Label lblIM;
        private System.Windows.Forms.Button btnPocni;
        private System.Windows.Forms.CheckBox cbxFSW;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button btnOdredisnaLok;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtOdredisnaLokacija;
        private System.Windows.Forms.TextBox txtUlaznaLokacija;
    }
}