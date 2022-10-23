namespace AlcoCalculator
{
    partial class AlcoCalculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.wielkoscNaczynia = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.begunokNaczunia = new System.Windows.Forms.PictureBox();
            this.begunokSpirt = new System.Windows.Forms.PictureBox();
            this.iloscNaczyniaLabel = new System.Windows.Forms.Label();
            this.iloscSpirtLabel = new System.Windows.Forms.Label();
            this.zawartoscSpirytusu = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.begunokNaczunia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.begunokSpirt)).BeginInit();
            this.SuspendLayout();
            // 
            // wielkoscNaczynia
            // 
            this.wielkoscNaczynia.Location = new System.Drawing.Point(14, 44);
            this.wielkoscNaczynia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.wielkoscNaczynia.Name = "wielkoscNaczynia";
            this.wielkoscNaczynia.Size = new System.Drawing.Size(114, 27);
            this.wielkoscNaczynia.TabIndex = 1;
            this.wielkoscNaczynia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.wielkoscNaczynia.TextChanged += new System.EventHandler(this.wielkoscNaczynia_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(353, 249);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(114, 27);
            this.textBox3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Wielkosc naczynia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Zawartosc spirytusu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(353, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ilosc sztuk naczynia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Objetosc spirytusu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(200, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Objetosc napoju";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(39, 249);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(114, 27);
            this.textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(200, 249);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(114, 27);
            this.textBox5.TabIndex = 9;
            // 
            // begunokNaczunia
            // 
            this.begunokNaczunia.BackColor = System.Drawing.SystemColors.Control;
            this.begunokNaczunia.Location = new System.Drawing.Point(134, 41);
            this.begunokNaczunia.Name = "begunokNaczunia";
            this.begunokNaczunia.Size = new System.Drawing.Size(436, 30);
            this.begunokNaczunia.TabIndex = 11;
            this.begunokNaczunia.TabStop = false;
            this.begunokNaczunia.Paint += new System.Windows.Forms.PaintEventHandler(this.beginokNaczynia_Draw);
            this.begunokNaczunia.MouseDown += new System.Windows.Forms.MouseEventHandler(this.begunokNaczynia_MouseDown);
            this.begunokNaczunia.MouseMove += new System.Windows.Forms.MouseEventHandler(this.begunokNaczynia_MouseMove);
            this.begunokNaczunia.MouseUp += new System.Windows.Forms.MouseEventHandler(this.begunokNaczynia_MouseUp);
            // 
            // begunokSpirt
            // 
            this.begunokSpirt.BackColor = System.Drawing.SystemColors.Control;
            this.begunokSpirt.Location = new System.Drawing.Point(134, 122);
            this.begunokSpirt.Name = "begunokSpirt";
            this.begunokSpirt.Size = new System.Drawing.Size(438, 30);
            this.begunokSpirt.TabIndex = 12;
            this.begunokSpirt.TabStop = false;
            this.begunokSpirt.Paint += new System.Windows.Forms.PaintEventHandler(this.beginokSpirt_Draw);
            this.begunokSpirt.MouseDown += new System.Windows.Forms.MouseEventHandler(this.begunokSpirt_MouseDown);
            this.begunokSpirt.MouseMove += new System.Windows.Forms.MouseEventHandler(this.begunokSpirt_MouseMove);
            this.begunokSpirt.MouseUp += new System.Windows.Forms.MouseEventHandler(this.begunokSpirt_MouseUp);
            // 
            // iloscNaczyniaLabel
            // 
            this.iloscNaczyniaLabel.AutoSize = true;
            this.iloscNaczyniaLabel.Location = new System.Drawing.Point(149, 12);
            this.iloscNaczyniaLabel.Name = "iloscNaczyniaLabel";
            this.iloscNaczyniaLabel.Size = new System.Drawing.Size(0, 20);
            this.iloscNaczyniaLabel.TabIndex = 13;
            // 
            // iloscSpirtLabel
            // 
            this.iloscSpirtLabel.AutoSize = true;
            this.iloscSpirtLabel.Location = new System.Drawing.Point(159, 92);
            this.iloscSpirtLabel.Name = "iloscSpirtLabel";
            this.iloscSpirtLabel.Size = new System.Drawing.Size(0, 20);
            this.iloscSpirtLabel.TabIndex = 14;
            // 
            // zawartoscSpirytusu
            // 
            this.zawartoscSpirytusu.Location = new System.Drawing.Point(14, 125);
            this.zawartoscSpirytusu.Name = "zawartoscSpirytusu";
            this.zawartoscSpirytusu.Size = new System.Drawing.Size(114, 27);
            this.zawartoscSpirytusu.TabIndex = 15;
            // 
            // AlcoCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 503);
            this.Controls.Add(this.zawartoscSpirytusu);
            this.Controls.Add(this.iloscSpirtLabel);
            this.Controls.Add(this.iloscNaczyniaLabel);
            this.Controls.Add(this.begunokSpirt);
            this.Controls.Add(this.begunokNaczunia);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.wielkoscNaczynia);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AlcoCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlcoCalculator";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.backgroundGradient);
            ((System.ComponentModel.ISupportInitialize)(this.begunokNaczunia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.begunokSpirt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox wielkoscNaczynia;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox4;
        private TextBox textBox5;
        private PictureBox begunokNaczunia;
        private PictureBox begunokSpirt;
        private Label iloscNaczyniaLabel;
        private Label iloscSpirtLabel;
        private TextBox zawartoscSpirytusu;
    }
}