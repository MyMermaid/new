namespace ZIProjekat
{
    partial class Client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblPrimPosl = new System.Windows.Forms.Label();
            this.txtDestinationText = new System.Windows.Forms.TextBox();
            this.lblPrimUnesi = new System.Windows.Forms.Label();
            this.btnPokreni = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnBob = new System.Windows.Forms.RadioButton();
            this.rbtnAlisa = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSourceText = new System.Windows.Forms.TextBox();
            this.lblPokusaj = new System.Windows.Forms.Label();
            this.lblPokretanje = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnMinimize);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(438, 56);
            this.panel2.TabIndex = 9;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
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
            this.btnMinimize.Location = new System.Drawing.Point(352, 10);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(32, 32);
            this.btnMinimize.TabIndex = 4;
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
            this.btnExit.Location = new System.Drawing.Point(390, 10);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(32, 32);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblPrimPosl
            // 
            this.lblPrimPosl.AutoSize = true;
            this.lblPrimPosl.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimPosl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPrimPosl.Location = new System.Drawing.Point(12, 390);
            this.lblPrimPosl.Name = "lblPrimPosl";
            this.lblPrimPosl.Size = new System.Drawing.Size(76, 21);
            this.lblPrimPosl.TabIndex = 89;
            this.lblPrimPosl.Text = "Poslato:";
            // 
            // txtDestinationText
            // 
            this.txtDestinationText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtDestinationText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDestinationText.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDestinationText.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtDestinationText.Location = new System.Drawing.Point(16, 414);
            this.txtDestinationText.Multiline = true;
            this.txtDestinationText.Name = "txtDestinationText";
            this.txtDestinationText.ReadOnly = true;
            this.txtDestinationText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDestinationText.Size = new System.Drawing.Size(408, 120);
            this.txtDestinationText.TabIndex = 88;
            // 
            // lblPrimUnesi
            // 
            this.lblPrimUnesi.AutoSize = true;
            this.lblPrimUnesi.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimUnesi.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPrimUnesi.Location = new System.Drawing.Point(12, 259);
            this.lblPrimUnesi.Name = "lblPrimUnesi";
            this.lblPrimUnesi.Size = new System.Drawing.Size(183, 21);
            this.lblPrimUnesi.TabIndex = 85;
            this.lblPrimUnesi.Text = "Unesite poruku ispod";
            // 
            // btnPokreni
            // 
            this.btnPokreni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnPokreni.FlatAppearance.BorderSize = 0;
            this.btnPokreni.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnPokreni.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnPokreni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPokreni.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPokreni.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPokreni.Location = new System.Drawing.Point(121, 150);
            this.btnPokreni.Name = "btnPokreni";
            this.btnPokreni.Size = new System.Drawing.Size(199, 31);
            this.btnPokreni.TabIndex = 84;
            this.btnPokreni.Text = "Pokreni klijenta";
            this.btnPokreni.UseVisualStyleBackColor = false;
            this.btnPokreni.Click += new System.EventHandler(this.btnPokreni_Click);
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnSend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSend.Location = new System.Drawing.Point(307, 365);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(117, 31);
            this.btnSend.TabIndex = 87;
            this.btnSend.Text = "Šalji";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnBob);
            this.groupBox1.Controls.Add(this.rbtnAlisa);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(412, 84);
            this.groupBox1.TabIndex = 83;
            this.groupBox1.TabStop = false;
            // 
            // rbtnBob
            // 
            this.rbtnBob.AutoSize = true;
            this.rbtnBob.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnBob.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rbtnBob.Location = new System.Drawing.Point(239, 42);
            this.rbtnBob.Name = "rbtnBob";
            this.rbtnBob.Size = new System.Drawing.Size(69, 27);
            this.rbtnBob.TabIndex = 75;
            this.rbtnBob.Text = "Bob";
            this.rbtnBob.UseVisualStyleBackColor = true;
            // 
            // rbtnAlisa
            // 
            this.rbtnAlisa.AutoSize = true;
            this.rbtnAlisa.Checked = true;
            this.rbtnAlisa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnAlisa.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rbtnAlisa.Location = new System.Drawing.Point(117, 42);
            this.rbtnAlisa.Name = "rbtnAlisa";
            this.rbtnAlisa.Size = new System.Drawing.Size(76, 27);
            this.rbtnAlisa.TabIndex = 74;
            this.rbtnAlisa.TabStop = true;
            this.rbtnAlisa.Text = "Alisa";
            this.rbtnAlisa.UseVisualStyleBackColor = true;
            this.rbtnAlisa.CheckedChanged += new System.EventHandler(this.rbtnAlisa_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label2.Location = new System.Drawing.Point(18, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 21);
            this.label2.TabIndex = 70;
            this.label2.Text = "Odabir tipa klijenta";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSourceText
            // 
            this.txtSourceText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtSourceText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSourceText.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSourceText.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtSourceText.Location = new System.Drawing.Point(16, 283);
            this.txtSourceText.Multiline = true;
            this.txtSourceText.Name = "txtSourceText";
            this.txtSourceText.Size = new System.Drawing.Size(408, 76);
            this.txtSourceText.TabIndex = 86;
            // 
            // lblPokusaj
            // 
            this.lblPokusaj.AutoSize = true;
            this.lblPokusaj.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPokusaj.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPokusaj.Location = new System.Drawing.Point(164, 226);
            this.lblPokusaj.Name = "lblPokusaj";
            this.lblPokusaj.Size = new System.Drawing.Size(110, 20);
            this.lblPokusaj.TabIndex = 82;
            this.lblPokusaj.Text = "Broj pokušaja:\r\n";
            this.lblPokusaj.Visible = false;
            // 
            // lblPokretanje
            // 
            this.lblPokretanje.AutoSize = true;
            this.lblPokretanje.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPokretanje.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPokretanje.Location = new System.Drawing.Point(145, 193);
            this.lblPokretanje.Name = "lblPokretanje";
            this.lblPokretanje.Size = new System.Drawing.Size(159, 20);
            this.lblPokretanje.TabIndex = 81;
            this.lblPokretanje.Text = " Pokretanje klijenta...\r\n";
            this.lblPokretanje.Visible = false;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(439, 561);
            this.Controls.Add(this.lblPrimPosl);
            this.Controls.Add(this.txtDestinationText);
            this.Controls.Add(this.lblPrimUnesi);
            this.Controls.Add(this.btnPokreni);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSourceText);
            this.Controls.Add(this.lblPokusaj);
            this.Controls.Add(this.lblPokretanje);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Client_FormClosing);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblPrimPosl;
        private System.Windows.Forms.TextBox txtDestinationText;
        private System.Windows.Forms.Label lblPrimUnesi;
        private System.Windows.Forms.Button btnPokreni;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnBob;
        private System.Windows.Forms.RadioButton rbtnAlisa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSourceText;
        private System.Windows.Forms.Label lblPokusaj;
        private System.Windows.Forms.Label lblPokretanje;
    }
}