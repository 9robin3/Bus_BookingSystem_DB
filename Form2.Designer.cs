namespace WindowsFormsApplication_bussbolag
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.lblValdResa = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblTid = new System.Windows.Forms.Label();
            this.lblKostnad = new System.Windows.Forms.Label();
            this.lblPersuppgSök = new System.Windows.Forms.Label();
            this.lblNamn = new System.Windows.Forms.Label();
            this.lblPersnr = new System.Windows.Forms.Label();
            this.lblAdress = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.telnr = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.btnAvbryt = new System.Windows.Forms.Button();
            this.btnBetala = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblValdResa
            // 
            this.lblValdResa.AutoSize = true;
            this.lblValdResa.Location = new System.Drawing.Point(16, 24);
            this.lblValdResa.Name = "lblValdResa";
            this.lblValdResa.Size = new System.Drawing.Size(54, 13);
            this.lblValdResa.TabIndex = 0;
            this.lblValdResa.Text = "Vald resa:";
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(16, 68);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(41, 13);
            this.lblDatum.TabIndex = 1;
            this.lblDatum.Text = "Datum:";
            // 
            // lblTid
            // 
            this.lblTid.AutoSize = true;
            this.lblTid.Location = new System.Drawing.Point(16, 111);
            this.lblTid.Name = "lblTid";
            this.lblTid.Size = new System.Drawing.Size(63, 13);
            this.lblTid.TabIndex = 2;
            this.lblTid.Text = "Avgångstid:";
            this.lblTid.Click += new System.EventHandler(this.lblTid_Click);
            // 
            // lblKostnad
            // 
            this.lblKostnad.AutoSize = true;
            this.lblKostnad.Location = new System.Drawing.Point(16, 148);
            this.lblKostnad.Name = "lblKostnad";
            this.lblKostnad.Size = new System.Drawing.Size(46, 13);
            this.lblKostnad.TabIndex = 3;
            this.lblKostnad.Text = "Kostnad";
            // 
            // lblPersuppgSök
            // 
            this.lblPersuppgSök.AutoSize = true;
            this.lblPersuppgSök.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersuppgSök.Location = new System.Drawing.Point(15, 232);
            this.lblPersuppgSök.Name = "lblPersuppgSök";
            this.lblPersuppgSök.Size = new System.Drawing.Size(214, 19);
            this.lblPersuppgSök.TabIndex = 4;
            this.lblPersuppgSök.Text = "Fyll i personuppgifter för att boka:";
            // 
            // lblNamn
            // 
            this.lblNamn.AutoSize = true;
            this.lblNamn.Location = new System.Drawing.Point(16, 278);
            this.lblNamn.Name = "lblNamn";
            this.lblNamn.Size = new System.Drawing.Size(38, 13);
            this.lblNamn.TabIndex = 5;
            this.lblNamn.Text = "Namn:";
            this.lblNamn.Click += new System.EventHandler(this.lblNamn_Click);
            // 
            // lblPersnr
            // 
            this.lblPersnr.AutoSize = true;
            this.lblPersnr.Location = new System.Drawing.Point(16, 319);
            this.lblPersnr.Name = "lblPersnr";
            this.lblPersnr.Size = new System.Drawing.Size(80, 13);
            this.lblPersnr.TabIndex = 6;
            this.lblPersnr.Text = "Personnummer:";
            this.lblPersnr.Click += new System.EventHandler(this.lblPersnr_Click);
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Location = new System.Drawing.Point(16, 360);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(42, 13);
            this.lblAdress.TabIndex = 7;
            this.lblAdress.Text = "Adress:";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(16, 406);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(39, 13);
            this.lblMail.TabIndex = 8;
            this.lblMail.Text = "E-Mail:";
            // 
            // telnr
            // 
            this.telnr.AutoSize = true;
            this.telnr.Location = new System.Drawing.Point(16, 449);
            this.telnr.Name = "telnr";
            this.telnr.Size = new System.Drawing.Size(83, 13);
            this.telnr.TabIndex = 9;
            this.telnr.Text = "Telefonnummer:";
            this.telnr.Click += new System.EventHandler(this.telnr_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(141, 20);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(95, 403);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 11;
            this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(95, 316);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 12;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged_1);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(95, 278);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 13;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(93, 145);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 14;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(93, 104);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 15;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(93, 65);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 16;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(95, 357);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(148, 20);
            this.textBox7.TabIndex = 17;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(95, 446);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 20);
            this.textBox9.TabIndex = 18;
            this.textBox9.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // btnAvbryt
            // 
            this.btnAvbryt.Location = new System.Drawing.Point(266, 14);
            this.btnAvbryt.Name = "btnAvbryt";
            this.btnAvbryt.Size = new System.Drawing.Size(100, 32);
            this.btnAvbryt.TabIndex = 19;
            this.btnAvbryt.Text = "Avbryt bokning";
            this.btnAvbryt.UseVisualStyleBackColor = true;
            this.btnAvbryt.Click += new System.EventHandler(this.btnAvbryt_Click);
            // 
            // btnBetala
            // 
            this.btnBetala.Location = new System.Drawing.Point(95, 485);
            this.btnBetala.Name = "btnBetala";
            this.btnBetala.Size = new System.Drawing.Size(100, 34);
            this.btnBetala.TabIndex = 20;
            this.btnBetala.Text = "Boka";
            this.btnBetala.UseVisualStyleBackColor = true;
            this.btnBetala.Click += new System.EventHandler(this.btnBetala_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 380);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 21;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 380);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Ex. Vägen 32 34543 Göteborg";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Ex. 6408207052";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 541);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBetala);
            this.Controls.Add(this.btnAvbryt);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.telnr);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblAdress);
            this.Controls.Add(this.lblPersnr);
            this.Controls.Add(this.lblNamn);
            this.Controls.Add(this.lblPersuppgSök);
            this.Controls.Add(this.lblKostnad);
            this.Controls.Add(this.lblTid);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.lblValdResa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blomstermåla bussbolag - Bokning";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValdResa;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblTid;
        private System.Windows.Forms.Label lblKostnad;
        private System.Windows.Forms.Label lblPersuppgSök;
        private System.Windows.Forms.Label lblNamn;
        private System.Windows.Forms.Label lblPersnr;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label telnr;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Button btnAvbryt;
        private System.Windows.Forms.Button btnBetala;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

