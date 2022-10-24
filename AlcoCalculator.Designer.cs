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
            this.iloscSztuk = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.resultTextBoxAlcohol = new System.Windows.Forms.TextBox();
            this.resultTextBoxVolume = new System.Windows.Forms.TextBox();
            this.begunokNaczunia = new System.Windows.Forms.PictureBox();
            this.begunokSpirt = new System.Windows.Forms.PictureBox();
            this.iloscNaczyniaLabel = new System.Windows.Forms.Label();
            this.iloscSpirtLabel = new System.Windows.Forms.Label();
            this.zawartoscSpirytusu = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.Button();
            this.begunokSztuk = new System.Windows.Forms.PictureBox();
            this.iloscSztukLabel = new System.Windows.Forms.Label();
            this.Clear = new System.Windows.Forms.Button();
            this.pbNaczynia = new System.Windows.Forms.PictureBox();
            this.cbTypoweNaczynia = new System.Windows.Forms.ComboBox();
            this.cbTypoweNapoje = new System.Windows.Forms.ComboBox();
            this.lTypoweNaczynia = new System.Windows.Forms.Label();
            this.lTypoweNapoje = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.begunokNaczunia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.begunokSpirt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.begunokSztuk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNaczynia)).BeginInit();
            this.SuspendLayout();
            // 
            // wielkoscNaczynia
            // 
            this.wielkoscNaczynia.Location = new System.Drawing.Point(164, 35);
            this.wielkoscNaczynia.Name = "wielkoscNaczynia";
            this.wielkoscNaczynia.Size = new System.Drawing.Size(100, 23);
            this.wielkoscNaczynia.TabIndex = 1;
            this.wielkoscNaczynia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // iloscSztuk
            // 
            this.iloscSztuk.Location = new System.Drawing.Point(164, 160);
            this.iloscSztuk.Name = "iloscSztuk";
            this.iloscSztuk.Size = new System.Drawing.Size(100, 23);
            this.iloscSztuk.TabIndex = 2;
            this.iloscSztuk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Location = new System.Drawing.Point(164, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Wielkosc naczynia(ml)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Location = new System.Drawing.Point(164, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Zawartosc spirytusu(%)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label3.Location = new System.Drawing.Point(164, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ilosc sztuk naczynia(sz)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label4.Location = new System.Drawing.Point(164, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Objetosc spirytusu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label5.Location = new System.Drawing.Point(305, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Objetosc napoju";
            // 
            // resultTextBoxAlcohol
            // 
            this.resultTextBoxAlcohol.Location = new System.Drawing.Point(164, 347);
            this.resultTextBoxAlcohol.Name = "resultTextBoxAlcohol";
            this.resultTextBoxAlcohol.ReadOnly = true;
            this.resultTextBoxAlcohol.Size = new System.Drawing.Size(114, 23);
            this.resultTextBoxAlcohol.TabIndex = 8;
            this.resultTextBoxAlcohol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.resultTextBoxAlcohol.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // resultTextBoxVolume
            // 
            this.resultTextBoxVolume.Location = new System.Drawing.Point(305, 347);
            this.resultTextBoxVolume.Name = "resultTextBoxVolume";
            this.resultTextBoxVolume.ReadOnly = true;
            this.resultTextBoxVolume.Size = new System.Drawing.Size(100, 23);
            this.resultTextBoxVolume.TabIndex = 9;
            this.resultTextBoxVolume.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // begunokNaczunia
            // 
            this.begunokNaczunia.BackColor = System.Drawing.SystemColors.Control;
            this.begunokNaczunia.Location = new System.Drawing.Point(269, 33);
            this.begunokNaczunia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.begunokNaczunia.Name = "begunokNaczunia";
            this.begunokNaczunia.Size = new System.Drawing.Size(382, 22);
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
            this.begunokSpirt.Location = new System.Drawing.Point(269, 94);
            this.begunokSpirt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.begunokSpirt.Name = "begunokSpirt";
            this.begunokSpirt.Size = new System.Drawing.Size(383, 22);
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
            this.iloscNaczyniaLabel.Location = new System.Drawing.Point(333, 11);
            this.iloscNaczyniaLabel.Name = "iloscNaczyniaLabel";
            this.iloscNaczyniaLabel.Size = new System.Drawing.Size(0, 15);
            this.iloscNaczyniaLabel.TabIndex = 13;
            // 
            // iloscSpirtLabel
            // 
            this.iloscSpirtLabel.AutoSize = true;
            this.iloscSpirtLabel.Location = new System.Drawing.Point(333, 76);
            this.iloscSpirtLabel.Name = "iloscSpirtLabel";
            this.iloscSpirtLabel.Size = new System.Drawing.Size(0, 15);
            this.iloscSpirtLabel.TabIndex = 14;
            // 
            // zawartoscSpirytusu
            // 
            this.zawartoscSpirytusu.Location = new System.Drawing.Point(164, 96);
            this.zawartoscSpirytusu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.zawartoscSpirytusu.Name = "zawartoscSpirytusu";
            this.zawartoscSpirytusu.Size = new System.Drawing.Size(100, 23);
            this.zawartoscSpirytusu.TabIndex = 15;
            this.zawartoscSpirytusu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(181, 210);
            this.result.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(82, 71);
            this.result.TabIndex = 16;
            this.result.Text = "Obliczyс";
            this.result.UseVisualStyleBackColor = true;
            this.result.Click += new System.EventHandler(this.result_Click);
            // 
            // begunokSztuk
            // 
            this.begunokSztuk.BackColor = System.Drawing.SystemColors.Control;
            this.begunokSztuk.Location = new System.Drawing.Point(269, 158);
            this.begunokSztuk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.begunokSztuk.Name = "begunokSztuk";
            this.begunokSztuk.Size = new System.Drawing.Size(383, 30);
            this.begunokSztuk.TabIndex = 17;
            this.begunokSztuk.TabStop = false;
            this.begunokSztuk.Paint += new System.Windows.Forms.PaintEventHandler(this.beginokSztuk_Draw);
            this.begunokSztuk.MouseDown += new System.Windows.Forms.MouseEventHandler(this.begunokSztuk_MouseDown);
            this.begunokSztuk.MouseMove += new System.Windows.Forms.MouseEventHandler(this.begunokSztuk_MouseMove);
            this.begunokSztuk.MouseUp += new System.Windows.Forms.MouseEventHandler(this.begunokSztuk_MouseUp);
            // 
            // iloscSztukLabel
            // 
            this.iloscSztukLabel.AutoSize = true;
            this.iloscSztukLabel.Location = new System.Drawing.Point(333, 132);
            this.iloscSztukLabel.Name = "iloscSztukLabel";
            this.iloscSztukLabel.Size = new System.Drawing.Size(0, 15);
            this.iloscSztukLabel.TabIndex = 18;
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(305, 210);
            this.Clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(82, 71);
            this.Clear.TabIndex = 19;
            this.Clear.Text = "Wyczyscic";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // pbNaczynia
            // 
            this.pbNaczynia.BackColor = System.Drawing.Color.White;
            this.pbNaczynia.Location = new System.Drawing.Point(424, 196);
            this.pbNaczynia.Name = "pbNaczynia";
            this.pbNaczynia.Size = new System.Drawing.Size(225, 171);
            this.pbNaczynia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNaczynia.TabIndex = 20;
            this.pbNaczynia.TabStop = false;
            // 
            // cbTypoweNaczynia
            // 
            this.cbTypoweNaczynia.FormattingEnabled = true;
            this.cbTypoweNaczynia.Items.AddRange(new object[] {
            "Brak",
            "Roks",
            "Margarita",
            "Fantaniver",
            "Kufel"});
            this.cbTypoweNaczynia.Location = new System.Drawing.Point(12, 35);
            this.cbTypoweNaczynia.Name = "cbTypoweNaczynia";
            this.cbTypoweNaczynia.Size = new System.Drawing.Size(121, 23);
            this.cbTypoweNaczynia.TabIndex = 21;
            this.cbTypoweNaczynia.SelectedIndexChanged += new System.EventHandler(this.cbTypoweNaczynia_SelectedIndexChanged);
            // 
            // cbTypoweNapoje
            // 
            this.cbTypoweNapoje.FormattingEnabled = true;
            this.cbTypoweNapoje.Items.AddRange(new object[] {
            "Brak",
            "Piwo (5%)",
            "Wino (17%)",
            "Wodka (40%)",
            "Jin (43%)",
            "Whisky (45%)"});
            this.cbTypoweNapoje.Location = new System.Drawing.Point(12, 96);
            this.cbTypoweNapoje.Name = "cbTypoweNapoje";
            this.cbTypoweNapoje.Size = new System.Drawing.Size(121, 23);
            this.cbTypoweNapoje.TabIndex = 22;
            this.cbTypoweNapoje.SelectedIndexChanged += new System.EventHandler(this.cbTypoweNapoje_SelectedIndexChanged);
            // 
            // lTypoweNaczynia
            // 
            this.lTypoweNaczynia.AutoSize = true;
            this.lTypoweNaczynia.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lTypoweNaczynia.Location = new System.Drawing.Point(12, 11);
            this.lTypoweNaczynia.Name = "lTypoweNaczynia";
            this.lTypoweNaczynia.Size = new System.Drawing.Size(96, 15);
            this.lTypoweNaczynia.TabIndex = 23;
            this.lTypoweNaczynia.Text = "Typowe naczynia";
            // 
            // lTypoweNapoje
            // 
            this.lTypoweNapoje.AutoSize = true;
            this.lTypoweNapoje.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lTypoweNapoje.Location = new System.Drawing.Point(12, 69);
            this.lTypoweNapoje.Name = "lTypoweNapoje";
            this.lTypoweNapoje.Size = new System.Drawing.Size(86, 15);
            this.lTypoweNapoje.TabIndex = 24;
            this.lTypoweNapoje.Text = "Typowe napoje";
            // 
            // AlcoCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 377);
            this.Controls.Add(this.lTypoweNapoje);
            this.Controls.Add(this.lTypoweNaczynia);
            this.Controls.Add(this.cbTypoweNapoje);
            this.Controls.Add(this.cbTypoweNaczynia);
            this.Controls.Add(this.pbNaczynia);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.iloscSztukLabel);
            this.Controls.Add(this.begunokSztuk);
            this.Controls.Add(this.result);
            this.Controls.Add(this.zawartoscSpirytusu);
            this.Controls.Add(this.iloscSpirtLabel);
            this.Controls.Add(this.iloscNaczyniaLabel);
            this.Controls.Add(this.begunokSpirt);
            this.Controls.Add(this.begunokNaczunia);
            this.Controls.Add(this.resultTextBoxVolume);
            this.Controls.Add(this.resultTextBoxAlcohol);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iloscSztuk);
            this.Controls.Add(this.wielkoscNaczynia);
            this.Name = "AlcoCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlcoCalculator";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.backgroundGradient);
            ((System.ComponentModel.ISupportInitialize)(this.begunokNaczunia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.begunokSpirt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.begunokSztuk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNaczynia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox wielkoscNaczynia;
        private TextBox iloscSztuk;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox resultTextBoxAlcohol;
        private TextBox resultTextBoxVolume;
        private PictureBox begunokNaczunia;
        private PictureBox begunokSpirt;
        private Label iloscNaczyniaLabel;
        private Label iloscSpirtLabel;
        private TextBox zawartoscSpirytusu;
        private Button result;
        private PictureBox begunokSztuk;
        private Label iloscSztukLabel;
        private Button Clear;
        private PictureBox pbNaczynia;
        private ComboBox cbTypoweNaczynia;
        private ComboBox cbTypoweNapoje;
        private Label lTypoweNaczynia;
        private Label lTypoweNapoje;
    }
}