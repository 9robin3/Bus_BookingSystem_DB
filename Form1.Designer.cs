namespace WindowsFormsApplication_bussbolag
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblSökResa = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblTill = new System.Windows.Forms.Label();
            this.lblFrån = new System.Windows.Forms.Label();
            this.lblTidtabell = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.from = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Departure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.to = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Arrival = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReserveButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnSök = new System.Windows.Forms.Button();
            this.button_visaAlla = new System.Windows.Forms.Button();
            this.button_hjalp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSökResa
            // 
            this.lblSökResa.AutoSize = true;
            this.lblSökResa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSökResa.Location = new System.Drawing.Point(14, 9);
            this.lblSökResa.Name = "lblSökResa";
            this.lblSökResa.Size = new System.Drawing.Size(74, 16);
            this.lblSökResa.TabIndex = 0;
            this.lblSökResa.Text = "Sök resa:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(51, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(208, 37);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblTill
            // 
            this.lblTill.AutoSize = true;
            this.lblTill.Location = new System.Drawing.Point(179, 39);
            this.lblTill.Name = "lblTill";
            this.lblTill.Size = new System.Drawing.Size(23, 13);
            this.lblTill.TabIndex = 3;
            this.lblTill.Text = "Till:";
            // 
            // lblFrån
            // 
            this.lblFrån.AutoSize = true;
            this.lblFrån.Location = new System.Drawing.Point(14, 39);
            this.lblFrån.Name = "lblFrån";
            this.lblFrån.Size = new System.Drawing.Size(31, 13);
            this.lblFrån.TabIndex = 4;
            this.lblFrån.Text = "Från:";
            // 
            // lblTidtabell
            // 
            this.lblTidtabell.AutoSize = true;
            this.lblTidtabell.Location = new System.Drawing.Point(14, 92);
            this.lblTidtabell.Name = "lblTidtabell";
            this.lblTidtabell.Size = new System.Drawing.Size(50, 13);
            this.lblTidtabell.TabIndex = 5;
            this.lblTidtabell.Text = "Tidtabell:";
            this.lblTidtabell.Click += new System.EventHandler(this.lblTidtabell_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.from,
            this.Departure,
            this.to,
            this.Arrival,
            this.Cost,
            this.ReserveButton});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.Location = new System.Drawing.Point(15, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(583, 432);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Datum";
            this.Date.HeaderText = "Datum";
            this.Date.MaxInputLength = 5;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 80;
            // 
            // from
            // 
            this.from.DataPropertyName = "fran";
            this.from.HeaderText = "Från";
            this.from.Name = "from";
            // 
            // Departure
            // 
            this.Departure.HeaderText = "Avgångstid";
            this.Departure.Name = "Departure";
            this.Departure.ReadOnly = true;
            this.Departure.Width = 65;
            // 
            // to
            // 
            this.to.HeaderText = "Till";
            this.to.Name = "to";
            // 
            // Arrival
            // 
            this.Arrival.HeaderText = "Ankomsttid";
            this.Arrival.Name = "Arrival";
            this.Arrival.ReadOnly = true;
            this.Arrival.Width = 65;
            // 
            // Cost
            // 
            this.Cost.HeaderText = "Kostnad";
            this.Cost.Name = "Cost";
            this.Cost.ReadOnly = true;
            this.Cost.Width = 60;
            // 
            // ReserveButton
            // 
            this.ReserveButton.HeaderText = "";
            this.ReserveButton.Name = "ReserveButton";
            this.ReserveButton.ReadOnly = true;
            this.ReserveButton.Width = 90;
            // 
            // btnSök
            // 
            this.btnSök.Location = new System.Drawing.Point(350, 37);
            this.btnSök.Name = "btnSök";
            this.btnSök.Size = new System.Drawing.Size(47, 23);
            this.btnSök.TabIndex = 20;
            this.btnSök.Text = "Sök";
            this.btnSök.UseVisualStyleBackColor = true;
            this.btnSök.Click += new System.EventHandler(this.btnAvbryt_Click);
            // 
            // button_visaAlla
            // 
            this.button_visaAlla.Location = new System.Drawing.Point(495, 34);
            this.button_visaAlla.Name = "button_visaAlla";
            this.button_visaAlla.Size = new System.Drawing.Size(103, 23);
            this.button_visaAlla.TabIndex = 21;
            this.button_visaAlla.Text = "Visa alla resor";
            this.button_visaAlla.UseVisualStyleBackColor = true;
            this.button_visaAlla.Click += new System.EventHandler(this.button_visaAlla_Click);
            // 
            // button_hjalp
            // 
            this.button_hjalp.Location = new System.Drawing.Point(495, 64);
            this.button_hjalp.Name = "button_hjalp";
            this.button_hjalp.Size = new System.Drawing.Size(103, 23);
            this.button_hjalp.TabIndex = 22;
            this.button_hjalp.Text = "Trafik";
            this.button_hjalp.UseVisualStyleBackColor = true;
            this.button_hjalp.Click += new System.EventHandler(this.button_hjalp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(627, 565);
            this.Controls.Add(this.button_hjalp);
            this.Controls.Add(this.button_visaAlla);
            this.Controls.Add(this.btnSök);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblTidtabell);
            this.Controls.Add(this.lblFrån);
            this.Controls.Add(this.lblTill);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblSökResa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blomstermåla bussbolag  - Tidtabell";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSökResa;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblTill;
        private System.Windows.Forms.Label lblFrån;
        private System.Windows.Forms.Label lblTidtabell;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSök;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewButtonColumn from;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departure;
        private System.Windows.Forms.DataGridViewButtonColumn to;
        private System.Windows.Forms.DataGridViewTextBoxColumn Arrival;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DataGridViewButtonColumn ReserveButton;
        private System.Windows.Forms.Button button_visaAlla;
        private System.Windows.Forms.Button button_hjalp;
    }
}

