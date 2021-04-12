namespace vozovy_park
{
    partial class FormUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOdhlásitSe = new System.Windows.Forms.Button();
            this.buttonZmenitHeslo = new System.Windows.Forms.Button();
            this.buttonZrusitRezervaci = new System.Windows.Forms.Button();
            this.buttonZadatRezervaci = new System.Windows.Forms.Button();
            this.buttonZrusitUcet = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.labelPosledniPrihlaseni = new System.Windows.Forms.Label();
            this.buttonAktualizovatSeznamRezervaci = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Přehled aktuálních rezervací:";
            // 
            // buttonOdhlásitSe
            // 
            this.buttonOdhlásitSe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonOdhlásitSe.Location = new System.Drawing.Point(12, 290);
            this.buttonOdhlásitSe.Name = "buttonOdhlásitSe";
            this.buttonOdhlásitSe.Size = new System.Drawing.Size(228, 40);
            this.buttonOdhlásitSe.TabIndex = 2;
            this.buttonOdhlásitSe.Text = "Odhlásit se";
            this.buttonOdhlásitSe.UseVisualStyleBackColor = true;
            this.buttonOdhlásitSe.Click += new System.EventHandler(this.buttonOdhlásitSe_Click);
            // 
            // buttonZmenitHeslo
            // 
            this.buttonZmenitHeslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonZmenitHeslo.Location = new System.Drawing.Point(246, 290);
            this.buttonZmenitHeslo.Name = "buttonZmenitHeslo";
            this.buttonZmenitHeslo.Size = new System.Drawing.Size(215, 40);
            this.buttonZmenitHeslo.TabIndex = 3;
            this.buttonZmenitHeslo.Text = "Změnit heslo";
            this.buttonZmenitHeslo.UseVisualStyleBackColor = true;
            this.buttonZmenitHeslo.Click += new System.EventHandler(this.buttonZmenitHeslo_Click);
            // 
            // buttonZrusitRezervaci
            // 
            this.buttonZrusitRezervaci.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonZrusitRezervaci.Location = new System.Drawing.Point(246, 244);
            this.buttonZrusitRezervaci.Name = "buttonZrusitRezervaci";
            this.buttonZrusitRezervaci.Size = new System.Drawing.Size(215, 40);
            this.buttonZrusitRezervaci.TabIndex = 5;
            this.buttonZrusitRezervaci.Text = "Zrušit rezervaci";
            this.buttonZrusitRezervaci.UseVisualStyleBackColor = true;
            this.buttonZrusitRezervaci.Click += new System.EventHandler(this.buttonZrusitRezervaci_Click);
            // 
            // buttonZadatRezervaci
            // 
            this.buttonZadatRezervaci.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonZadatRezervaci.Location = new System.Drawing.Point(12, 244);
            this.buttonZadatRezervaci.Name = "buttonZadatRezervaci";
            this.buttonZadatRezervaci.Size = new System.Drawing.Size(228, 40);
            this.buttonZadatRezervaci.TabIndex = 4;
            this.buttonZadatRezervaci.Text = "Zadat rezervaci";
            this.buttonZadatRezervaci.UseVisualStyleBackColor = true;
            this.buttonZadatRezervaci.Click += new System.EventHandler(this.buttonZadatRezervaci_Click);
            // 
            // buttonZrusitUcet
            // 
            this.buttonZrusitUcet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonZrusitUcet.Location = new System.Drawing.Point(338, 9);
            this.buttonZrusitUcet.Name = "buttonZrusitUcet";
            this.buttonZrusitUcet.Size = new System.Drawing.Size(123, 27);
            this.buttonZrusitUcet.TabIndex = 6;
            this.buttonZrusitUcet.Text = "Zrušit účet";
            this.buttonZrusitUcet.UseVisualStyleBackColor = true;
            this.buttonZrusitUcet.Click += new System.EventHandler(this.buttonZrusitUcet_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 42);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(449, 196);
            this.listBox1.TabIndex = 7;
            // 
            // labelPosledniPrihlaseni
            // 
            this.labelPosledniPrihlaseni.AutoSize = true;
            this.labelPosledniPrihlaseni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPosledniPrihlaseni.Location = new System.Drawing.Point(12, 396);
            this.labelPosledniPrihlaseni.Name = "labelPosledniPrihlaseni";
            this.labelPosledniPrihlaseni.Size = new System.Drawing.Size(105, 13);
            this.labelPosledniPrihlaseni.TabIndex = 8;
            this.labelPosledniPrihlaseni.Text = "Poslední přihlášení: ";
            // 
            // buttonAktualizovatSeznamRezervaci
            // 
            this.buttonAktualizovatSeznamRezervaci.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAktualizovatSeznamRezervaci.Location = new System.Drawing.Point(12, 336);
            this.buttonAktualizovatSeznamRezervaci.Name = "buttonAktualizovatSeznamRezervaci";
            this.buttonAktualizovatSeznamRezervaci.Size = new System.Drawing.Size(449, 40);
            this.buttonAktualizovatSeznamRezervaci.TabIndex = 9;
            this.buttonAktualizovatSeznamRezervaci.Text = "Aktualizovat seznam rezervací";
            this.buttonAktualizovatSeznamRezervaci.UseVisualStyleBackColor = true;
            this.buttonAktualizovatSeznamRezervaci.Click += new System.EventHandler(this.buttonAktualizovatSeznamRezervaci_Click);
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 420);
            this.Controls.Add(this.buttonAktualizovatSeznamRezervaci);
            this.Controls.Add(this.labelPosledniPrihlaseni);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonZrusitUcet);
            this.Controls.Add(this.buttonZrusitRezervaci);
            this.Controls.Add(this.buttonZadatRezervaci);
            this.Controls.Add(this.buttonZmenitHeslo);
            this.Controls.Add(this.buttonOdhlásitSe);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormUser";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormUser_FormClosed);
            this.Load += new System.EventHandler(this.FormUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonOdhlásitSe;
        private System.Windows.Forms.Button buttonZmenitHeslo;
        private System.Windows.Forms.Button buttonZrusitRezervaci;
        private System.Windows.Forms.Button buttonZadatRezervaci;
        private System.Windows.Forms.Button buttonZrusitUcet;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label labelPosledniPrihlaseni;
        private System.Windows.Forms.Button buttonAktualizovatSeznamRezervaci;
    }
}