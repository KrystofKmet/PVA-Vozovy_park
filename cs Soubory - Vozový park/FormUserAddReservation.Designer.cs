namespace vozovy_park
{
    partial class FormUserAddReservation
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonRezervovat = new System.Windows.Forms.Button();
            this.buttonZavrit = new System.Windows.Forms.Button();
            this.dateTimePickerRezervovatDo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownCasHodiny = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCasMinuty = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCasVteriny = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCasHodiny)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCasMinuty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCasVteriny)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 35);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(499, 228);
            this.listBox1.TabIndex = 0;
            // 
            // buttonRezervovat
            // 
            this.buttonRezervovat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRezervovat.Location = new System.Drawing.Point(12, 357);
            this.buttonRezervovat.Name = "buttonRezervovat";
            this.buttonRezervovat.Size = new System.Drawing.Size(248, 39);
            this.buttonRezervovat.TabIndex = 1;
            this.buttonRezervovat.Text = "Rezervovat";
            this.buttonRezervovat.UseVisualStyleBackColor = true;
            this.buttonRezervovat.Click += new System.EventHandler(this.buttonRezervovat_Click);
            // 
            // buttonZavrit
            // 
            this.buttonZavrit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonZavrit.Location = new System.Drawing.Point(263, 357);
            this.buttonZavrit.Name = "buttonZavrit";
            this.buttonZavrit.Size = new System.Drawing.Size(248, 39);
            this.buttonZavrit.TabIndex = 2;
            this.buttonZavrit.Text = "Zavřít";
            this.buttonZavrit.UseVisualStyleBackColor = true;
            this.buttonZavrit.Click += new System.EventHandler(this.buttonZavrit_Click);
            // 
            // dateTimePickerRezervovatDo
            // 
            this.dateTimePickerRezervovatDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePickerRezervovatDo.Location = new System.Drawing.Point(175, 269);
            this.dateTimePickerRezervovatDo.Name = "dateTimePickerRezervovatDo";
            this.dateTimePickerRezervovatDo.Size = new System.Drawing.Size(336, 31);
            this.dateTimePickerRezervovatDo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Rezervovat do:";
            // 
            // numericUpDownCasHodiny
            // 
            this.numericUpDownCasHodiny.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDownCasHodiny.Location = new System.Drawing.Point(175, 312);
            this.numericUpDownCasHodiny.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericUpDownCasHodiny.Name = "numericUpDownCasHodiny";
            this.numericUpDownCasHodiny.Size = new System.Drawing.Size(49, 31);
            this.numericUpDownCasHodiny.TabIndex = 6;
            // 
            // numericUpDownCasMinuty
            // 
            this.numericUpDownCasMinuty.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDownCasMinuty.Location = new System.Drawing.Point(255, 312);
            this.numericUpDownCasMinuty.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDownCasMinuty.Name = "numericUpDownCasMinuty";
            this.numericUpDownCasMinuty.Size = new System.Drawing.Size(49, 31);
            this.numericUpDownCasMinuty.TabIndex = 7;
            // 
            // numericUpDownCasVteriny
            // 
            this.numericUpDownCasVteriny.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDownCasVteriny.Location = new System.Drawing.Point(335, 312);
            this.numericUpDownCasVteriny.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDownCasVteriny.Name = "numericUpDownCasVteriny";
            this.numericUpDownCasVteriny.Size = new System.Drawing.Size(49, 31);
            this.numericUpDownCasVteriny.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(113, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Čas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(230, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(310, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(433, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "(h:m:s)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(9, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(284, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "(Značka | Model | Typ | Spotřeba na 100km)";
            // 
            // FormUserAddReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 405);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownCasVteriny);
            this.Controls.Add(this.numericUpDownCasMinuty);
            this.Controls.Add(this.numericUpDownCasHodiny);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerRezervovatDo);
            this.Controls.Add(this.buttonZavrit);
            this.Controls.Add(this.buttonRezervovat);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormUserAddReservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormUserAddReservation";
            this.Load += new System.EventHandler(this.FormUserAddReservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCasHodiny)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCasMinuty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCasVteriny)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonRezervovat;
        private System.Windows.Forms.Button buttonZavrit;
        private System.Windows.Forms.DateTimePicker dateTimePickerRezervovatDo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownCasHodiny;
        private System.Windows.Forms.NumericUpDown numericUpDownCasMinuty;
        private System.Windows.Forms.NumericUpDown numericUpDownCasVteriny;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}