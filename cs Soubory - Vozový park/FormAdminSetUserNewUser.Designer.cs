namespace vozovy_park
{
    partial class FormAdminSetUserNewUser
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
            this.buttonVytvorit = new System.Windows.Forms.Button();
            this.textBoxJmeno = new System.Windows.Forms.TextBox();
            this.textBoxPrijmeni = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxHeslo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxHesloZnovu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelSpatneHeslo = new System.Windows.Forms.Label();
            this.labelPrazdneHeslo = new System.Windows.Forms.Label();
            this.labelPrazdneJmeno = new System.Windows.Forms.Label();
            this.labelPrazdnePrijmeni = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBoxJeAdmin = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jméno:";
            // 
            // buttonVytvorit
            // 
            this.buttonVytvorit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonVytvorit.Location = new System.Drawing.Point(13, 350);
            this.buttonVytvorit.Name = "buttonVytvorit";
            this.buttonVytvorit.Size = new System.Drawing.Size(387, 45);
            this.buttonVytvorit.TabIndex = 1;
            this.buttonVytvorit.Text = "Vytvořit";
            this.buttonVytvorit.UseVisualStyleBackColor = true;
            this.buttonVytvorit.Click += new System.EventHandler(this.buttonVytvorit_Click);
            // 
            // textBoxJmeno
            // 
            this.textBoxJmeno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxJmeno.Location = new System.Drawing.Point(100, 76);
            this.textBoxJmeno.Name = "textBoxJmeno";
            this.textBoxJmeno.Size = new System.Drawing.Size(299, 31);
            this.textBoxJmeno.TabIndex = 2;
            // 
            // textBoxPrijmeni
            // 
            this.textBoxPrijmeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPrijmeni.Location = new System.Drawing.Point(114, 133);
            this.textBoxPrijmeni.Name = "textBoxPrijmeni";
            this.textBoxPrijmeni.Size = new System.Drawing.Size(286, 31);
            this.textBoxPrijmeni.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(13, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Příjmení:";
            // 
            // textBoxHeslo
            // 
            this.textBoxHeslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxHeslo.Location = new System.Drawing.Point(92, 190);
            this.textBoxHeslo.Name = "textBoxHeslo";
            this.textBoxHeslo.Size = new System.Drawing.Size(308, 31);
            this.textBoxHeslo.TabIndex = 6;
            this.textBoxHeslo.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(13, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Heslo:";
            // 
            // textBoxHesloZnovu
            // 
            this.textBoxHesloZnovu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxHesloZnovu.Location = new System.Drawing.Point(156, 247);
            this.textBoxHesloZnovu.Name = "textBoxHesloZnovu";
            this.textBoxHesloZnovu.Size = new System.Drawing.Size(244, 31);
            this.textBoxHesloZnovu.TabIndex = 8;
            this.textBoxHesloZnovu.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(13, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Heslo znovu:";
            // 
            // labelSpatneHeslo
            // 
            this.labelSpatneHeslo.AutoSize = true;
            this.labelSpatneHeslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSpatneHeslo.ForeColor = System.Drawing.Color.Red;
            this.labelSpatneHeslo.Location = new System.Drawing.Point(14, 281);
            this.labelSpatneHeslo.Name = "labelSpatneHeslo";
            this.labelSpatneHeslo.Size = new System.Drawing.Size(295, 20);
            this.labelSpatneHeslo.TabIndex = 10;
            this.labelSpatneHeslo.Text = "Špatné heslo - zkuste zadat heslo znovu";
            this.labelSpatneHeslo.Visible = false;
            // 
            // labelPrazdneHeslo
            // 
            this.labelPrazdneHeslo.AutoSize = true;
            this.labelPrazdneHeslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPrazdneHeslo.ForeColor = System.Drawing.Color.Red;
            this.labelPrazdneHeslo.Location = new System.Drawing.Point(14, 224);
            this.labelPrazdneHeslo.Name = "labelPrazdneHeslo";
            this.labelPrazdneHeslo.Size = new System.Drawing.Size(104, 20);
            this.labelPrazdneHeslo.TabIndex = 11;
            this.labelPrazdneHeslo.Text = "Vyplňte heslo";
            this.labelPrazdneHeslo.Visible = false;
            // 
            // labelPrazdneJmeno
            // 
            this.labelPrazdneJmeno.AutoSize = true;
            this.labelPrazdneJmeno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPrazdneJmeno.ForeColor = System.Drawing.Color.Red;
            this.labelPrazdneJmeno.Location = new System.Drawing.Point(14, 110);
            this.labelPrazdneJmeno.Name = "labelPrazdneJmeno";
            this.labelPrazdneJmeno.Size = new System.Drawing.Size(109, 20);
            this.labelPrazdneJmeno.TabIndex = 13;
            this.labelPrazdneJmeno.Text = "Vyplňte jméno";
            this.labelPrazdneJmeno.Visible = false;
            // 
            // labelPrazdnePrijmeni
            // 
            this.labelPrazdnePrijmeni.AutoSize = true;
            this.labelPrazdnePrijmeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPrazdnePrijmeni.ForeColor = System.Drawing.Color.Red;
            this.labelPrazdnePrijmeni.Location = new System.Drawing.Point(14, 167);
            this.labelPrazdnePrijmeni.Name = "labelPrazdnePrijmeni";
            this.labelPrazdnePrijmeni.Size = new System.Drawing.Size(120, 20);
            this.labelPrazdnePrijmeni.TabIndex = 12;
            this.labelPrazdnePrijmeni.Text = "Vyplňte příjmení";
            this.labelPrazdnePrijmeni.Visible = false;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(387, 64);
            this.label5.TabIndex = 14;
            this.label5.Text = "Nový uživatel";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBoxJeAdmin
            // 
            this.checkBoxJeAdmin.AutoSize = true;
            this.checkBoxJeAdmin.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxJeAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxJeAdmin.Location = new System.Drawing.Point(17, 304);
            this.checkBoxJeAdmin.Name = "checkBoxJeAdmin";
            this.checkBoxJeAdmin.Size = new System.Drawing.Size(304, 29);
            this.checkBoxJeAdmin.TabIndex = 15;
            this.checkBoxJeAdmin.Text = "Administrátorská oprávnění: ";
            this.checkBoxJeAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxJeAdmin.UseVisualStyleBackColor = true;
            // 
            // FormAdminSetUserNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 407);
            this.Controls.Add(this.checkBoxJeAdmin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelPrazdneJmeno);
            this.Controls.Add(this.labelPrazdnePrijmeni);
            this.Controls.Add(this.labelPrazdneHeslo);
            this.Controls.Add(this.labelSpatneHeslo);
            this.Controls.Add(this.textBoxHesloZnovu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxHeslo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPrijmeni);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxJmeno);
            this.Controls.Add(this.buttonVytvorit);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormAdminSetUserNewUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAdminSetUserNewUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonVytvorit;
        private System.Windows.Forms.TextBox textBoxJmeno;
        private System.Windows.Forms.TextBox textBoxPrijmeni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxHeslo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxHesloZnovu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelSpatneHeslo;
        private System.Windows.Forms.Label labelPrazdneHeslo;
        private System.Windows.Forms.Label labelPrazdneJmeno;
        private System.Windows.Forms.Label labelPrazdnePrijmeni;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBoxJeAdmin;
    }
}