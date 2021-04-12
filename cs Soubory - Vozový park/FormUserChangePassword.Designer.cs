namespace vozovy_park
{
    partial class FormUserChangePassword
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
            this.textBoxStareHeslo = new System.Windows.Forms.TextBox();
            this.buttonPotvrdit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNoveHeslo = new System.Windows.Forms.TextBox();
            this.textBoxNoveHesloZnovu = new System.Windows.Forms.TextBox();
            this.labelPrazdneNoveHeslo = new System.Windows.Forms.Label();
            this.labelPrazdneNoveHesloZnovu = new System.Windows.Forms.Label();
            this.labelPrazdneStareHeslo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Staré heslo:";
            // 
            // textBoxStareHeslo
            // 
            this.textBoxStareHeslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxStareHeslo.Location = new System.Drawing.Point(146, 22);
            this.textBoxStareHeslo.Name = "textBoxStareHeslo";
            this.textBoxStareHeslo.Size = new System.Drawing.Size(273, 31);
            this.textBoxStareHeslo.TabIndex = 1;
            this.textBoxStareHeslo.UseSystemPasswordChar = true;
            // 
            // buttonPotvrdit
            // 
            this.buttonPotvrdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPotvrdit.Location = new System.Drawing.Point(15, 193);
            this.buttonPotvrdit.Name = "buttonPotvrdit";
            this.buttonPotvrdit.Size = new System.Drawing.Size(404, 36);
            this.buttonPotvrdit.TabIndex = 4;
            this.buttonPotvrdit.Text = "Potvrdit";
            this.buttonPotvrdit.UseVisualStyleBackColor = true;
            this.buttonPotvrdit.Click += new System.EventHandler(this.buttonPotvrdit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nové heslo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(13, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nové heslo znovu:";
            // 
            // textBoxNoveHeslo
            // 
            this.textBoxNoveHeslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxNoveHeslo.Location = new System.Drawing.Point(144, 79);
            this.textBoxNoveHeslo.Name = "textBoxNoveHeslo";
            this.textBoxNoveHeslo.Size = new System.Drawing.Size(275, 31);
            this.textBoxNoveHeslo.TabIndex = 2;
            this.textBoxNoveHeslo.UseSystemPasswordChar = true;
            // 
            // textBoxNoveHesloZnovu
            // 
            this.textBoxNoveHesloZnovu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxNoveHesloZnovu.Location = new System.Drawing.Point(209, 136);
            this.textBoxNoveHesloZnovu.Name = "textBoxNoveHesloZnovu";
            this.textBoxNoveHesloZnovu.Size = new System.Drawing.Size(210, 31);
            this.textBoxNoveHesloZnovu.TabIndex = 3;
            this.textBoxNoveHesloZnovu.UseSystemPasswordChar = true;
            // 
            // labelPrazdneNoveHeslo
            // 
            this.labelPrazdneNoveHeslo.AutoSize = true;
            this.labelPrazdneNoveHeslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPrazdneNoveHeslo.ForeColor = System.Drawing.Color.Red;
            this.labelPrazdneNoveHeslo.Location = new System.Drawing.Point(14, 113);
            this.labelPrazdneNoveHeslo.Name = "labelPrazdneNoveHeslo";
            this.labelPrazdneNoveHeslo.Size = new System.Drawing.Size(142, 20);
            this.labelPrazdneNoveHeslo.TabIndex = 14;
            this.labelPrazdneNoveHeslo.Text = "Vyplňte nové heslo";
            this.labelPrazdneNoveHeslo.Visible = false;
            // 
            // labelPrazdneNoveHesloZnovu
            // 
            this.labelPrazdneNoveHesloZnovu.AutoSize = true;
            this.labelPrazdneNoveHesloZnovu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPrazdneNoveHesloZnovu.ForeColor = System.Drawing.Color.Red;
            this.labelPrazdneNoveHesloZnovu.Location = new System.Drawing.Point(12, 170);
            this.labelPrazdneNoveHesloZnovu.Name = "labelPrazdneNoveHesloZnovu";
            this.labelPrazdneNoveHesloZnovu.Size = new System.Drawing.Size(188, 20);
            this.labelPrazdneNoveHesloZnovu.TabIndex = 15;
            this.labelPrazdneNoveHesloZnovu.Text = "Vyplňte nové heslo znovu";
            this.labelPrazdneNoveHesloZnovu.Visible = false;
            // 
            // labelPrazdneStareHeslo
            // 
            this.labelPrazdneStareHeslo.AutoSize = true;
            this.labelPrazdneStareHeslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPrazdneStareHeslo.ForeColor = System.Drawing.Color.Red;
            this.labelPrazdneStareHeslo.Location = new System.Drawing.Point(12, 56);
            this.labelPrazdneStareHeslo.Name = "labelPrazdneStareHeslo";
            this.labelPrazdneStareHeslo.Size = new System.Drawing.Size(144, 20);
            this.labelPrazdneStareHeslo.TabIndex = 16;
            this.labelPrazdneStareHeslo.Text = "Vyplňte staré heslo";
            this.labelPrazdneStareHeslo.Visible = false;
            // 
            // FormUserChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 243);
            this.Controls.Add(this.labelPrazdneStareHeslo);
            this.Controls.Add(this.labelPrazdneNoveHesloZnovu);
            this.Controls.Add(this.labelPrazdneNoveHeslo);
            this.Controls.Add(this.textBoxNoveHesloZnovu);
            this.Controls.Add(this.textBoxNoveHeslo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonPotvrdit);
            this.Controls.Add(this.textBoxStareHeslo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormUserChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormUserChangePassword";
            this.Load += new System.EventHandler(this.FormUserChangePassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxStareHeslo;
        private System.Windows.Forms.Button buttonPotvrdit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNoveHeslo;
        private System.Windows.Forms.TextBox textBoxNoveHesloZnovu;
        private System.Windows.Forms.Label labelPrazdneNoveHeslo;
        private System.Windows.Forms.Label labelPrazdneNoveHesloZnovu;
        private System.Windows.Forms.Label labelPrazdneStareHeslo;
    }
}