namespace vozovy_park
{
    partial class FormAdminSetCar
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
            this.buttonVlozitNovyAutomobil = new System.Windows.Forms.Button();
            this.buttonZrusitAutomobil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonDostupnyNedostupny = new System.Windows.Forms.Button();
            this.buttonAktualizovatSeznamAut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonVlozitNovyAutomobil
            // 
            this.buttonVlozitNovyAutomobil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonVlozitNovyAutomobil.Location = new System.Drawing.Point(12, 274);
            this.buttonVlozitNovyAutomobil.Name = "buttonVlozitNovyAutomobil";
            this.buttonVlozitNovyAutomobil.Size = new System.Drawing.Size(244, 38);
            this.buttonVlozitNovyAutomobil.TabIndex = 10;
            this.buttonVlozitNovyAutomobil.Text = "Vložit nový automobil";
            this.buttonVlozitNovyAutomobil.UseVisualStyleBackColor = true;
            this.buttonVlozitNovyAutomobil.Click += new System.EventHandler(this.buttonVlozitNovyAutomobil_Click);
            // 
            // buttonZrusitAutomobil
            // 
            this.buttonZrusitAutomobil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonZrusitAutomobil.Location = new System.Drawing.Point(357, 12);
            this.buttonZrusitAutomobil.Name = "buttonZrusitAutomobil";
            this.buttonZrusitAutomobil.Size = new System.Drawing.Size(149, 25);
            this.buttonZrusitAutomobil.TabIndex = 9;
            this.buttonZrusitAutomobil.Text = "Zrušit automobil";
            this.buttonZrusitAutomobil.UseVisualStyleBackColor = true;
            this.buttonZrusitAutomobil.Click += new System.EventHandler(this.buttonZrusitAutomobil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Seznam automobilů:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.Location = new System.Drawing.Point(12, 43);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(494, 225);
            this.listBox1.TabIndex = 7;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // buttonDostupnyNedostupny
            // 
            this.buttonDostupnyNedostupny.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDostupnyNedostupny.Location = new System.Drawing.Point(262, 274);
            this.buttonDostupnyNedostupny.Name = "buttonDostupnyNedostupny";
            this.buttonDostupnyNedostupny.Size = new System.Drawing.Size(244, 38);
            this.buttonDostupnyNedostupny.TabIndex = 11;
            this.buttonDostupnyNedostupny.Text = "Nedostupný/Dostupný";
            this.buttonDostupnyNedostupny.UseVisualStyleBackColor = true;
            this.buttonDostupnyNedostupny.Click += new System.EventHandler(this.buttonDostupnyNedostupny_Click);
            // 
            // buttonAktualizovatSeznamAut
            // 
            this.buttonAktualizovatSeznamAut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAktualizovatSeznamAut.Location = new System.Drawing.Point(12, 318);
            this.buttonAktualizovatSeznamAut.Name = "buttonAktualizovatSeznamAut";
            this.buttonAktualizovatSeznamAut.Size = new System.Drawing.Size(494, 38);
            this.buttonAktualizovatSeznamAut.TabIndex = 12;
            this.buttonAktualizovatSeznamAut.Text = "Aktualizovat seznam automobilů";
            this.buttonAktualizovatSeznamAut.UseVisualStyleBackColor = true;
            this.buttonAktualizovatSeznamAut.Click += new System.EventHandler(this.buttonAktualizovatSeznamAut_Click);
            // 
            // FormAdminSetCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 366);
            this.Controls.Add(this.buttonAktualizovatSeznamAut);
            this.Controls.Add(this.buttonDostupnyNedostupny);
            this.Controls.Add(this.buttonVlozitNovyAutomobil);
            this.Controls.Add(this.buttonZrusitAutomobil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormAdminSetCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAdminSetCar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonVlozitNovyAutomobil;
        private System.Windows.Forms.Button buttonZrusitAutomobil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonDostupnyNedostupny;
        private System.Windows.Forms.Button buttonAktualizovatSeznamAut;
    }
}