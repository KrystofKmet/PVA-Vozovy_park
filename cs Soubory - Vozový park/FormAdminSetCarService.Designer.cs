namespace vozovy_park
{
    partial class FormAdminSetCarService
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
            this.labelPrazdneCisloFaktury = new System.Windows.Forms.Label();
            this.labelPrazdnaCena = new System.Windows.Forms.Label();
            this.labelPrazdneDatum = new System.Windows.Forms.Label();
            this.labelPrazdnyServisniUkon = new System.Windows.Forms.Label();
            this.buttonSmazat = new System.Windows.Forms.Button();
            this.buttonPridat = new System.Windows.Forms.Button();
            this.dateTimePickerDatumProvedeni = new System.Windows.Forms.DateTimePicker();
            this.textBoxCisloFaktury = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCena = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxServisniUkon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelPrazdneCisloFaktury
            // 
            this.labelPrazdneCisloFaktury.AutoSize = true;
            this.labelPrazdneCisloFaktury.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPrazdneCisloFaktury.ForeColor = System.Drawing.Color.Red;
            this.labelPrazdneCisloFaktury.Location = new System.Drawing.Point(8, 250);
            this.labelPrazdneCisloFaktury.Name = "labelPrazdneCisloFaktury";
            this.labelPrazdneCisloFaktury.Size = new System.Drawing.Size(149, 20);
            this.labelPrazdneCisloFaktury.TabIndex = 58;
            this.labelPrazdneCisloFaktury.Text = "Vyplňte číslo faktury";
            this.labelPrazdneCisloFaktury.Visible = false;
            // 
            // labelPrazdnaCena
            // 
            this.labelPrazdnaCena.AutoSize = true;
            this.labelPrazdnaCena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPrazdnaCena.ForeColor = System.Drawing.Color.Red;
            this.labelPrazdnaCena.Location = new System.Drawing.Point(8, 193);
            this.labelPrazdnaCena.Name = "labelPrazdnaCena";
            this.labelPrazdnaCena.Size = new System.Drawing.Size(101, 20);
            this.labelPrazdnaCena.TabIndex = 57;
            this.labelPrazdnaCena.Text = "Vyplňte cenu";
            this.labelPrazdnaCena.Visible = false;
            // 
            // labelPrazdneDatum
            // 
            this.labelPrazdneDatum.AutoSize = true;
            this.labelPrazdneDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPrazdneDatum.ForeColor = System.Drawing.Color.Red;
            this.labelPrazdneDatum.Location = new System.Drawing.Point(8, 136);
            this.labelPrazdneDatum.Name = "labelPrazdneDatum";
            this.labelPrazdneDatum.Size = new System.Drawing.Size(184, 20);
            this.labelPrazdneDatum.TabIndex = 56;
            this.labelPrazdneDatum.Text = "Vyplňte datum provedení";
            this.labelPrazdneDatum.Visible = false;
            // 
            // labelPrazdnyServisniUkon
            // 
            this.labelPrazdnyServisniUkon.AutoSize = true;
            this.labelPrazdnyServisniUkon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPrazdnyServisniUkon.ForeColor = System.Drawing.Color.Red;
            this.labelPrazdnyServisniUkon.Location = new System.Drawing.Point(8, 79);
            this.labelPrazdnyServisniUkon.Name = "labelPrazdnyServisniUkon";
            this.labelPrazdnyServisniUkon.Size = new System.Drawing.Size(157, 20);
            this.labelPrazdnyServisniUkon.TabIndex = 55;
            this.labelPrazdnyServisniUkon.Text = "Vyplňte servisní úkon";
            this.labelPrazdnyServisniUkon.Visible = false;
            // 
            // buttonSmazat
            // 
            this.buttonSmazat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSmazat.Location = new System.Drawing.Point(10, 273);
            this.buttonSmazat.Name = "buttonSmazat";
            this.buttonSmazat.Size = new System.Drawing.Size(237, 29);
            this.buttonSmazat.TabIndex = 54;
            this.buttonSmazat.Text = "Smazat";
            this.buttonSmazat.UseVisualStyleBackColor = true;
            this.buttonSmazat.Click += new System.EventHandler(this.buttonSmazat_Click);
            // 
            // buttonPridat
            // 
            this.buttonPridat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPridat.Location = new System.Drawing.Point(253, 273);
            this.buttonPridat.Name = "buttonPridat";
            this.buttonPridat.Size = new System.Drawing.Size(237, 29);
            this.buttonPridat.TabIndex = 53;
            this.buttonPridat.Text = "Přidat";
            this.buttonPridat.UseVisualStyleBackColor = true;
            this.buttonPridat.Click += new System.EventHandler(this.buttonPridat_Click);
            // 
            // dateTimePickerDatumProvedeni
            // 
            this.dateTimePickerDatumProvedeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePickerDatumProvedeni.Location = new System.Drawing.Point(194, 102);
            this.dateTimePickerDatumProvedeni.Name = "dateTimePickerDatumProvedeni";
            this.dateTimePickerDatumProvedeni.Size = new System.Drawing.Size(296, 31);
            this.dateTimePickerDatumProvedeni.TabIndex = 52;
            // 
            // textBoxCisloFaktury
            // 
            this.textBoxCisloFaktury.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxCisloFaktury.Location = new System.Drawing.Point(150, 216);
            this.textBoxCisloFaktury.Name = "textBoxCisloFaktury";
            this.textBoxCisloFaktury.Size = new System.Drawing.Size(340, 31);
            this.textBoxCisloFaktury.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(7, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 50;
            this.label1.Text = "Číslo faktury:";
            // 
            // textBoxCena
            // 
            this.textBoxCena.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxCena.Location = new System.Drawing.Point(82, 159);
            this.textBoxCena.Name = "textBoxCena";
            this.textBoxCena.Size = new System.Drawing.Size(408, 31);
            this.textBoxCena.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(7, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 48;
            this.label2.Text = "Cena:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(7, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 25);
            this.label3.TabIndex = 47;
            this.label3.Text = "Datum provedení:";
            // 
            // textBoxServisniUkon
            // 
            this.textBoxServisniUkon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxServisniUkon.Location = new System.Drawing.Point(161, 45);
            this.textBoxServisniUkon.Name = "textBoxServisniUkon";
            this.textBoxServisniUkon.Size = new System.Drawing.Size(329, 31);
            this.textBoxServisniUkon.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(7, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 25);
            this.label4.TabIndex = 45;
            this.label4.Text = "Servisní úkon:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.Location = new System.Drawing.Point(12, 308);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(478, 95);
            this.listBox1.TabIndex = 44;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(12, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(478, 33);
            this.label10.TabIndex = 43;
            this.label10.Text = "Náklady na údržbu";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormAdminSetCarService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 415);
            this.Controls.Add(this.labelPrazdneCisloFaktury);
            this.Controls.Add(this.labelPrazdnaCena);
            this.Controls.Add(this.labelPrazdneDatum);
            this.Controls.Add(this.labelPrazdnyServisniUkon);
            this.Controls.Add(this.buttonSmazat);
            this.Controls.Add(this.buttonPridat);
            this.Controls.Add(this.dateTimePickerDatumProvedeni);
            this.Controls.Add(this.textBoxCisloFaktury);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCena);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxServisniUkon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormAdminSetCarService";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAdminSetCarService";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAdminSetCarService_FormClosed);
            this.Load += new System.EventHandler(this.FormAdminSetCarService_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPrazdneCisloFaktury;
        private System.Windows.Forms.Label labelPrazdnaCena;
        private System.Windows.Forms.Label labelPrazdneDatum;
        private System.Windows.Forms.Label labelPrazdnyServisniUkon;
        private System.Windows.Forms.Button buttonSmazat;
        private System.Windows.Forms.Button buttonPridat;
        private System.Windows.Forms.DateTimePicker dateTimePickerDatumProvedeni;
        private System.Windows.Forms.TextBox textBoxCisloFaktury;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCena;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxServisniUkon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label10;
    }
}