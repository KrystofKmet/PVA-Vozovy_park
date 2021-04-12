namespace vozovy_park
{
    partial class FormAdmin
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
            this.buttonSpravaUzivatelu = new System.Windows.Forms.Button();
            this.buttonSpravaAutomobilu = new System.Windows.Forms.Button();
            this.buttonZmenitHeslo = new System.Windows.Forms.Button();
            this.buttonOdhlasitSe = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.labelPosledniPrihlaseni = new System.Windows.Forms.Label();
            this.buttonAktualizovatSeznamyRezervaci = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSpravaUzivatelu
            // 
            this.buttonSpravaUzivatelu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSpravaUzivatelu.Location = new System.Drawing.Point(14, 400);
            this.buttonSpravaUzivatelu.Name = "buttonSpravaUzivatelu";
            this.buttonSpravaUzivatelu.Size = new System.Drawing.Size(207, 44);
            this.buttonSpravaUzivatelu.TabIndex = 0;
            this.buttonSpravaUzivatelu.Text = "Správa uživatelů";
            this.buttonSpravaUzivatelu.UseVisualStyleBackColor = true;
            this.buttonSpravaUzivatelu.Click += new System.EventHandler(this.buttonSpravaUzivatelu_Click);
            // 
            // buttonSpravaAutomobilu
            // 
            this.buttonSpravaAutomobilu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSpravaAutomobilu.Location = new System.Drawing.Point(227, 400);
            this.buttonSpravaAutomobilu.Name = "buttonSpravaAutomobilu";
            this.buttonSpravaAutomobilu.Size = new System.Drawing.Size(207, 44);
            this.buttonSpravaAutomobilu.TabIndex = 3;
            this.buttonSpravaAutomobilu.Text = "Správa automobilů";
            this.buttonSpravaAutomobilu.UseVisualStyleBackColor = true;
            this.buttonSpravaAutomobilu.Click += new System.EventHandler(this.buttonSpravaAutomobilu_Click);
            // 
            // buttonZmenitHeslo
            // 
            this.buttonZmenitHeslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonZmenitHeslo.Location = new System.Drawing.Point(227, 450);
            this.buttonZmenitHeslo.Name = "buttonZmenitHeslo";
            this.buttonZmenitHeslo.Size = new System.Drawing.Size(207, 40);
            this.buttonZmenitHeslo.TabIndex = 6;
            this.buttonZmenitHeslo.Text = "Změnit heslo";
            this.buttonZmenitHeslo.UseVisualStyleBackColor = true;
            this.buttonZmenitHeslo.Click += new System.EventHandler(this.buttonZmenitHeslo_Click);
            // 
            // buttonOdhlasitSe
            // 
            this.buttonOdhlasitSe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonOdhlasitSe.Location = new System.Drawing.Point(14, 450);
            this.buttonOdhlasitSe.Name = "buttonOdhlasitSe";
            this.buttonOdhlasitSe.Size = new System.Drawing.Size(207, 40);
            this.buttonOdhlasitSe.TabIndex = 5;
            this.buttonOdhlasitSe.Text = "Odhlásit se";
            this.buttonOdhlasitSe.UseVisualStyleBackColor = true;
            this.buttonOdhlasitSe.Click += new System.EventHandler(this.buttonOdhlasitSe_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Seznam rezervací po automobilech:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.Location = new System.Drawing.Point(17, 40);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(417, 160);
            this.listBox1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(14, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Seznam rezervací po osobách:";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.HorizontalScrollbar = true;
            this.listBox2.Location = new System.Drawing.Point(17, 234);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(417, 160);
            this.listBox2.TabIndex = 11;
            // 
            // labelPosledniPrihlaseni
            // 
            this.labelPosledniPrihlaseni.AutoSize = true;
            this.labelPosledniPrihlaseni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPosledniPrihlaseni.Location = new System.Drawing.Point(14, 567);
            this.labelPosledniPrihlaseni.Name = "labelPosledniPrihlaseni";
            this.labelPosledniPrihlaseni.Size = new System.Drawing.Size(105, 13);
            this.labelPosledniPrihlaseni.TabIndex = 13;
            this.labelPosledniPrihlaseni.Text = "Poslední přihlášení: ";
            // 
            // buttonAktualizovatSeznamyRezervaci
            // 
            this.buttonAktualizovatSeznamyRezervaci.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAktualizovatSeznamyRezervaci.Location = new System.Drawing.Point(14, 496);
            this.buttonAktualizovatSeznamyRezervaci.Name = "buttonAktualizovatSeznamyRezervaci";
            this.buttonAktualizovatSeznamyRezervaci.Size = new System.Drawing.Size(421, 40);
            this.buttonAktualizovatSeznamyRezervaci.TabIndex = 14;
            this.buttonAktualizovatSeznamyRezervaci.Text = "Aktualizovat seznamy rezervací";
            this.buttonAktualizovatSeznamyRezervaci.UseVisualStyleBackColor = true;
            this.buttonAktualizovatSeznamyRezervaci.Click += new System.EventHandler(this.buttonAktualizovatSeznamyRezervaci_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 588);
            this.Controls.Add(this.buttonAktualizovatSeznamyRezervaci);
            this.Controls.Add(this.labelPosledniPrihlaseni);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonZmenitHeslo);
            this.Controls.Add(this.buttonOdhlasitSe);
            this.Controls.Add(this.buttonSpravaAutomobilu);
            this.Controls.Add(this.buttonSpravaUzivatelu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAdmin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAdmin_FormClosed);
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSpravaUzivatelu;
        private System.Windows.Forms.Button buttonSpravaAutomobilu;
        private System.Windows.Forms.Button buttonZmenitHeslo;
        private System.Windows.Forms.Button buttonOdhlasitSe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label labelPosledniPrihlaseni;
        private System.Windows.Forms.Button buttonAktualizovatSeznamyRezervaci;
    }
}