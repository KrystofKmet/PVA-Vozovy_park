namespace vozovy_park
{
    partial class FormAdminSetUser
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
            this.buttonNovyUzivatel = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonZrusitUzivatele = new System.Windows.Forms.Button();
            this.buttonVynutitZmenuHesla = new System.Windows.Forms.Button();
            this.buttonAktualizovatSeznamUzivatelu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonNovyUzivatel
            // 
            this.buttonNovyUzivatel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonNovyUzivatel.Location = new System.Drawing.Point(12, 257);
            this.buttonNovyUzivatel.Name = "buttonNovyUzivatel";
            this.buttonNovyUzivatel.Size = new System.Drawing.Size(221, 38);
            this.buttonNovyUzivatel.TabIndex = 0;
            this.buttonNovyUzivatel.Text = "Nový uživatel";
            this.buttonNovyUzivatel.UseVisualStyleBackColor = true;
            this.buttonNovyUzivatel.Click += new System.EventHandler(this.buttonNovyUzivatel_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.Location = new System.Drawing.Point(12, 39);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(448, 212);
            this.listBox1.TabIndex = 1;
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seznam uživatelů:";
            // 
            // buttonZrusitUzivatele
            // 
            this.buttonZrusitUzivatele.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonZrusitUzivatele.Location = new System.Drawing.Point(301, 8);
            this.buttonZrusitUzivatele.Name = "buttonZrusitUzivatele";
            this.buttonZrusitUzivatele.Size = new System.Drawing.Size(159, 28);
            this.buttonZrusitUzivatele.TabIndex = 3;
            this.buttonZrusitUzivatele.Text = "Zrušit uživatele";
            this.buttonZrusitUzivatele.UseVisualStyleBackColor = true;
            this.buttonZrusitUzivatele.Click += new System.EventHandler(this.buttonZrusitUzivatele_Click);
            // 
            // buttonVynutitZmenuHesla
            // 
            this.buttonVynutitZmenuHesla.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonVynutitZmenuHesla.Location = new System.Drawing.Point(239, 257);
            this.buttonVynutitZmenuHesla.Name = "buttonVynutitZmenuHesla";
            this.buttonVynutitZmenuHesla.Size = new System.Drawing.Size(221, 38);
            this.buttonVynutitZmenuHesla.TabIndex = 4;
            this.buttonVynutitZmenuHesla.Text = "Vynutit změnu hesla";
            this.buttonVynutitZmenuHesla.UseVisualStyleBackColor = true;
            this.buttonVynutitZmenuHesla.Click += new System.EventHandler(this.buttonVynutitZmenuHesla_Click);
            // 
            // buttonAktualizovatSeznamUzivatelu
            // 
            this.buttonAktualizovatSeznamUzivatelu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAktualizovatSeznamUzivatelu.Location = new System.Drawing.Point(12, 301);
            this.buttonAktualizovatSeznamUzivatelu.Name = "buttonAktualizovatSeznamUzivatelu";
            this.buttonAktualizovatSeznamUzivatelu.Size = new System.Drawing.Size(448, 38);
            this.buttonAktualizovatSeznamUzivatelu.TabIndex = 5;
            this.buttonAktualizovatSeznamUzivatelu.Text = "Aktualizovat seznam uživatelů";
            this.buttonAktualizovatSeznamUzivatelu.UseVisualStyleBackColor = true;
            this.buttonAktualizovatSeznamUzivatelu.Click += new System.EventHandler(this.buttonAktualizovatSeznamUzivatelu_Click);
            // 
            // FormAdminSetUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 347);
            this.Controls.Add(this.buttonAktualizovatSeznamUzivatelu);
            this.Controls.Add(this.buttonVynutitZmenuHesla);
            this.Controls.Add(this.buttonZrusitUzivatele);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonNovyUzivatel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormAdminSetUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAdminSetUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNovyUzivatel;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonZrusitUzivatele;
        private System.Windows.Forms.Button buttonVynutitZmenuHesla;
        private System.Windows.Forms.Button buttonAktualizovatSeznamUzivatelu;
    }
}