using System;
using System.Drawing.Drawing2D;

namespace AlcoCalculator
{
    public partial class AlcoCalculator : Form
    {
    

        private static readonly Image[] Snifter =
        {
            Properties.Resources.roks1,
            Properties.Resources.roks2,
            Properties.Resources.roks3,
            Properties.Resources.roks4,
            Properties.Resources.roks5,
        };
        private static readonly Image[] Wineglass =
        {
            Properties.Resources.fantanaiver1,
            Properties.Resources.fantanaiver2,
            Properties.Resources.fantanaiver3,
            Properties.Resources.fantanaiver4,
            Properties.Resources.fantanaiver5
        };
        private static readonly Image[] Beerglass =
        {
            Properties.Resources.beer1,
            Properties.Resources.beer2,
            Properties.Resources.beer3,
            Properties.Resources.beer4,
            Properties.Resources.beer5,
        };
        private static readonly Image[] Glass =
        {
            Properties.Resources.margarita1,
            Properties.Resources.margarita2,
            Properties.Resources.margarita3,
            Properties.Resources.margarita4,
            Properties.Resources.margarita5,
        };       

        public AlcoCalculator()
        {
            InitializeComponent();
            begunokNaczunia.Height = 30;
            begunokSpirt.Height = 30;
            begunokSpirt.Height = 30;
            thumbNaczynia(0);
            thumbSpirt(0);
            thumbSztuk(0);
            cbTypoweNaczynia.SelectedIndex = 0;
            cbTypoweNapoje.SelectedIndex = 0;
        }
        public double VolumeAlcohol(double alkochol, double volume, double amount)
        {       
            return volume * amount * (alkochol/100);
        }

        public double VolumeAll(double volume, double amount)
        {
            return volume * amount;
        }

        private void backgroundGradient(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Pen pen = new Pen(Color.FromArgb(96, 155, 173), 1);
            Rectangle area = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            LinearGradientBrush linear = new LinearGradientBrush(area, Color.FromArgb(153, 204, 255), Color.FromArgb(76, 0,153), LinearGradientMode.ForwardDiagonal);
            graphics.FillRectangle(linear, area);
            graphics.DrawRectangle(pen, area);
        }

        //Это отрисовка компонентов для ползунка ОБЪЁМА начало
        float default_ValueNaczynia = 0.1f, minNaczynia = 0.0f, maxNaczynia = 1.0f;
        int valNaczynia = 1000;//этодля преобразования перемещения ползунка в миллилитры
        bool mouseNaczynia = false;
        public float BarNaczynia(float value)
        {
            return(begunokNaczunia.Width-24)*(value-minNaczynia)/(float)(maxNaczynia-minNaczynia);          
        }

        public void thumbNaczynia(float value)
        {
            if(value < minNaczynia) value = minNaczynia;
            if(value > maxNaczynia) value = maxNaczynia;
            default_ValueNaczynia = value;
            begunokNaczunia.Refresh();
        }

        
        private void begunokNaczynia_MouseDown(object sender, MouseEventArgs e)
        {
            mouseNaczynia = true;
            thumbNaczynia(begunokNaczynia_width(e.X));
            
            float liczba = (float)(begunokNaczynia_width(e.X)) * valNaczynia;
            iloscNaczyniaLabel.Text = liczba.ToString("#") + " ml";
            if (liczba < minNaczynia * valNaczynia)
            {
                liczba = minNaczynia * valNaczynia;
                iloscNaczyniaLabel.Text = liczba.ToString() + " ml";
            }
            else if (liczba > maxNaczynia * valNaczynia)
            {
                liczba = maxNaczynia * valNaczynia;
                iloscNaczyniaLabel.Text = liczba.ToString() + " ml";
            }

        }

        private void begunokNaczynia_MouseMove(object sender, MouseEventArgs e)
        {
            if(!mouseNaczynia) return;
            thumbNaczynia(begunokNaczynia_width(e.X));
            float liczba = (float)(begunokNaczynia_width(e.X))*valNaczynia;          
            iloscNaczyniaLabel.Text = liczba.ToString("#")+" ml";
            if (liczba < minNaczynia*valNaczynia)
            {
                liczba = minNaczynia * valNaczynia;             
                iloscNaczyniaLabel.Text = liczba.ToString()+" ml";
            }
            else if (liczba > maxNaczynia*valNaczynia)
            {
                liczba = maxNaczynia*valNaczynia;               
                iloscNaczyniaLabel.Text = liczba.ToString()+" ml";
            }

            ZmienicObrazNaczynia(liczba, 0);
        }
        private void begunokNaczynia_MouseUp(object sender, MouseEventArgs e)
        {
            mouseNaczynia=false;
        }


        public float begunokNaczynia_width(int x)
        {
            return minNaczynia+(maxNaczynia-minNaczynia)*x/(float)(begunokNaczunia.Width);
            
        }

        private void beginokNaczynia_Draw(object sender, PaintEventArgs e)
        {
            float bar_Size = 0.45f;
            float x = BarNaczynia(default_ValueNaczynia);
            int y = (int)(begunokNaczunia.Height * bar_Size);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.FillRectangle(Brushes.DarkOrchid,0,y,begunokNaczunia.Width,y/2);
            e.Graphics.FillRectangle(Brushes.Red,0,y,x,begunokNaczunia.Height-2*y);
            using (Pen pen = new Pen(Color.Black, 8))
            {
                e.Graphics.DrawEllipse(pen, x+4 , y - 6, begunokNaczunia.Height/2, begunokNaczunia.Height / 2);
                e.Graphics.FillEllipse(Brushes.Red, x+4 , y - 6, begunokNaczunia.Height / 2, begunokNaczunia.Height / 2);
            }
            using (Pen pen = new Pen(Color.White, 5))
            {
                e.Graphics.DrawEllipse(pen,x+4, y - 6, begunokNaczunia.Height / 2,begunokNaczunia.Height/2);
            }
        }

        //Здесь конец

        //Это отрисовка компонентов для ползунка СПИРТА начало
        float default_ValueSpirt = 0.1f, minSpirt = 0.0f, maxSpirt = 1.0f;
        int valSpirt = 95;//это для преобразования перемещения ползунка в градусы
        bool mouseSpirt = false;
        public float BarSpirt(float value)
        {
            return (begunokSpirt.Width - 24) * (value - minSpirt) / (float)(maxSpirt - minSpirt);
        }
//Задает начальные координаты бегунка
        public void thumbSpirt(float value)
        {
            if (value < minSpirt) value = minSpirt;
            if (value > maxSpirt) value = maxSpirt;
            default_ValueSpirt = value;
            begunokSpirt.Refresh();
        }


        private void begunokSpirt_MouseDown(object sender, MouseEventArgs e)
        {
            mouseSpirt = true;
            thumbSpirt(begunokSpirt_width(e.X));

            float liczba = (float)(begunokSpirt_width(e.X)) * valSpirt;
            iloscSpirtLabel.Text = liczba.ToString("#") + " %";
            if (liczba < minSpirt * valSpirt)
            {
                liczba = minSpirt * valSpirt;
                iloscSpirtLabel.Text = liczba.ToString() + " %";
            }
            else if (liczba > maxSpirt * valSpirt)
            {
                liczba = maxSpirt * valSpirt;
                iloscSpirtLabel.Text = liczba.ToString() + " %";
            }
        }

        private void begunokSpirt_MouseMove(object sender, MouseEventArgs e)
        {
            if (!mouseSpirt) return;
            thumbSpirt(begunokSpirt_width(e.X));
            float liczba = (float)(begunokSpirt_width(e.X)) * valSpirt;
            iloscSpirtLabel.Text = liczba.ToString("#") + " %";
            if (liczba < minSpirt * valSpirt)
            {
                liczba = minSpirt * valSpirt;
                iloscSpirtLabel.Text = liczba.ToString() + " %";
            }
            else if (liczba > maxSpirt * valSpirt)
            {
                liczba = maxSpirt * valSpirt;
                iloscSpirtLabel.Text = liczba.ToString() + " %";
            }

        }
        private void begunokSpirt_MouseUp(object sender, MouseEventArgs e)
        {
            mouseSpirt = false;
        }


        public float begunokSpirt_width(int x)
        {
            return minSpirt + (maxSpirt - minSpirt) * x / (float)(begunokSpirt.Width);

        }
//Отрисовка самого бегунка
        private void beginokSpirt_Draw(object sender, PaintEventArgs e)
        {
            float bar_Size = 0.45f;
            float x = BarSpirt(default_ValueSpirt);
            int y = (int)(begunokSpirt.Height * bar_Size);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.FillRectangle(Brushes.DarkBlue, 0, y, begunokSpirt.Width, y / 2);
            e.Graphics.FillRectangle(Brushes.Red, 0, y, x, begunokSpirt.Height - 2 * y);
            using (Pen pen = new Pen(Color.Black, 8))
            {
                e.Graphics.DrawEllipse(pen, x + 4, y - 6, begunokSpirt.Height / 2, begunokSpirt.Height / 2);
                e.Graphics.FillEllipse(Brushes.Red, x + 4, y - 6, begunokSpirt.Height / 2, begunokSpirt.Height / 2);
            }
            using (Pen pen = new Pen(Color.White, 5))
            {
                e.Graphics.DrawEllipse(pen, x + 4, y - 6, begunokSpirt.Height / 2, begunokSpirt.Height / 2);
            }
        }
        //Здесь конец

        //Это отрисовка компонентов для ползунка Штук начало
        float default_ValueSztuk = 0.1f, minSztuk = 0.0f, maxSztuk = 1.0f;
        int valSztuk = 100;//этодля преобразования перемещения ползунка в градусы
        bool mouseSztuk = false;
        public float BarSztuk(float value)
        {
            return (begunokSztuk.Width - 24) * (value - minSztuk) / (float)(maxSztuk - minSztuk);
        }

        public void thumbSztuk(float value)
        {
            if (value < minSztuk) value = minSztuk;
            if (value > maxSztuk) value = maxSztuk;
            default_ValueSztuk = value;
            begunokSztuk.Refresh();
        }

      

        private void begunokSztuk_MouseDown(object sender, MouseEventArgs e)
        {
            mouseSztuk = true;
            thumbSztuk(begunokSztuk_width(e.X));

            float liczba = (float)(begunokSztuk_width(e.X)) * valSztuk;
            iloscSztukLabel.Text = liczba.ToString("#") + " sz";
            if (liczba < minSztuk * valSztuk)
            {
                liczba = minSztuk * valSztuk;
                iloscSztukLabel.Text = liczba.ToString() + " sz";
            }
            else if (liczba > maxSztuk * valSztuk)
            {
                liczba = maxSztuk * valSztuk;
                iloscSztukLabel.Text = liczba.ToString() + " sz";
            }
        }

        private void begunokSztuk_MouseMove(object sender, MouseEventArgs e)
        {
            if (!mouseSztuk) return;
            thumbSztuk(begunokSztuk_width(e.X));
            float liczba = (float)(begunokSztuk_width(e.X)) * valSztuk;
            iloscSztukLabel.Text = liczba.ToString("#") + " sz";
            if (liczba < minSztuk * valSztuk)
            {
                liczba = minSztuk * valSztuk;
                iloscSztukLabel.Text = liczba.ToString() + " sz";
            }
            else if (liczba > maxSztuk * valSztuk)
            {
                liczba = maxSztuk * valSztuk;
                iloscSztukLabel.Text = liczba.ToString() + " sz";
            }

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void begunokSztuk_MouseUp(object sender, MouseEventArgs e)
        {
            mouseSztuk = false;
        }

        private void cbTypoweNaczynia_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbTypoweNaczynia.SelectedIndex)
            {
                case 1:
                    wielkoscNaczynia.Text = "50";
                    ZmienicObrazNaczynia(50, 0);
                    break;

                case 2:
                    wielkoscNaczynia.Text = "150";
                    ZmienicObrazNaczynia(150, 0);
                    break;

                case 3:
                    wielkoscNaczynia.Text = "250";
                    ZmienicObrazNaczynia(250, 0);
                    break;

                case 4:
                    wielkoscNaczynia.Text = "500";
                    ZmienicObrazNaczynia(500, 0);
                    break;

                default:
                    wielkoscNaczynia.Text = "";
                    pbNaczynia.Image = null;
                    break;
            }
        }

        private void cbTypoweNapoje_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbTypoweNapoje.SelectedIndex)
            {
                case 1:
                    zawartoscSpirytusu.Text = "5";
                    break;

                case 2:
                    zawartoscSpirytusu.Text = "17";
                    break;

                case 3:
                    zawartoscSpirytusu.Text = "40";
                    break;

                case 4:
                    zawartoscSpirytusu.Text = "43";
                    break;

                case 5:
                    zawartoscSpirytusu.Text = "45";
                    break;

                default:
                    zawartoscSpirytusu.Text = "";
                    break;
            }
        }

        public float begunokSztuk_width(int x)
        {
            return minSztuk + (maxSztuk - minSztuk) * x / (float)(begunokSztuk.Width);

        }

        private void beginokSztuk_Draw(object sender, PaintEventArgs e)
        {
            float bar_Size = 0.45f;
            float x = BarSztuk(default_ValueSztuk);
            int y = (int)(begunokSztuk.Height * bar_Size);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.FillRectangle(Brushes.DodgerBlue, 0, y, begunokSztuk.Width, y / 2);
            e.Graphics.FillRectangle(Brushes.Red, 0, y, x, begunokSztuk.Height - 2 * y);
            using (Pen pen = new Pen(Color.Black, 8))
            {
                e.Graphics.DrawEllipse(pen, x + 4, y - 6, begunokSztuk.Height / 2, begunokSztuk.Height / 2);
                e.Graphics.FillEllipse(Brushes.Red, x + 4, y - 6, begunokSztuk.Height / 2, begunokSztuk.Height / 2);
            }
            using (Pen pen = new Pen(Color.White, 5))
            {
                e.Graphics.DrawEllipse(pen, x + 4, y - 6, begunokSztuk.Height / 2, begunokSztuk.Height / 2);
            }
        }
  //Здесь конец
        private void result_Click(object sender, EventArgs e)
        {
            try
            {
                if (wielkoscNaczynia.Text == "")
                {
                    string Nacz = iloscNaczyniaLabel.Text;
                    string NewNacz = Nacz.TrimEnd(' ', 'm', 'l');
                    wielkoscNaczynia.Text = NewNacz;
                }
                else
                {
                    int naczynie = Int32.Parse(wielkoscNaczynia.Text);
                    thumbNaczynia(maxNaczynia / valNaczynia * naczynie);
                    iloscNaczyniaLabel.Text = naczynie.ToString() + " ml";

                }

                if (zawartoscSpirytusu.Text == "")
                {
                    string Spitr = iloscSpirtLabel.Text;
                    string NewSpirt = Spitr.TrimEnd(' ', '%');
                    zawartoscSpirytusu.Text = NewSpirt;
                }
                else
                {
                    int spirytus = Int32.Parse(zawartoscSpirytusu.Text);

                    if (spirytus < 0 || spirytus > 95)
                    {
                        MessageBox.Show("Error! Enter true data alcohol!");
                        zawartoscSpirytusu.Text = "";
                        iloscSpirtLabel.Text = "";
                    }
                    else
                    {
                        thumbSpirt(maxSztuk / valSztuk * spirytus);
                        iloscSpirtLabel.Text = spirytus.ToString() + " %";
                    }

                }

                if (iloscSztuk.Text == "")
                {

                    string Ilosc = iloscSztukLabel.Text;
                    string newIlosc = Ilosc.TrimEnd(' ', 's', 'z');
                    iloscSztuk.Text = newIlosc;
                }
                else
                {
                    int sztuk = Int32.Parse(iloscSztuk.Text);
                    thumbSztuk(maxSztuk / valSztuk * sztuk);
                    iloscSztukLabel.Text = sztuk.ToString() + " sz";

                }

                double N = Double.Parse(wielkoscNaczynia.Text);
                double S = Double.Parse(zawartoscSpirytusu.Text);
                double I = Double.Parse(iloscSztuk.Text);

                resultTextBoxAlcohol.Text = VolumeAlcohol(S, N, I).ToString() + " ml";
                resultTextBoxVolume.Text = VolumeAll(N, I).ToString() + " ml";

                ZmienicObrazNaczynia((int)N, AktualizacjaZawartosciSpirytusu(S));
            }
            catch 
            {
                MessageBox.Show("Error! Enter true data!");
                thumbNaczynia(0);
                thumbSpirt(0);
                thumbSztuk(0);
                wielkoscNaczynia.Text = "";
                iloscSztuk.Text = "";
                zawartoscSpirytusu.Text = "";
                iloscNaczyniaLabel.Text = "";
                iloscSpirtLabel.Text = "";
                iloscSztukLabel.Text = "";
                resultTextBoxAlcohol.Text = "";
                resultTextBoxVolume.Text = "";
                cbTypoweNapoje.SelectedIndex = 0;
                cbTypoweNaczynia.SelectedIndex = 0;
                pbNaczynia.Image = null;
            }

        }
        private void Clear_Click(object sender, EventArgs e)
        {
            thumbNaczynia(0);
            thumbSpirt(0);
            thumbSztuk(0);
            wielkoscNaczynia.Text = "";
            iloscSztuk.Text = "";
            zawartoscSpirytusu.Text = "";
            iloscNaczyniaLabel.Text = "";
            iloscSpirtLabel.Text = "";
            iloscSztukLabel.Text = "";
            resultTextBoxAlcohol.Text = "";
            resultTextBoxVolume.Text = "";
            pbNaczynia.Image = null;
            cbTypoweNaczynia.SelectedIndex = 0;
            cbTypoweNapoje.SelectedIndex = 0;
        }

        private void ZmienicObrazNaczynia(float liczba, int index)
        {
            if (liczba >= 0 && liczba <= 50)
            {
                pbNaczynia.Image = Snifter[index];
            }

            if (liczba > 50 && liczba <= 150)
            {
                pbNaczynia.Image = Glass[index];
            }

            if (liczba > 150 && liczba <= 250)
            {
                pbNaczynia.Image = Wineglass[index];
            }

            if (liczba > 250 && liczba <= 1000)
            {
                pbNaczynia.Image = Beerglass[index];
            }
        }

        private int AktualizacjaZawartosciSpirytusu(double S)
        {
            if (S > 0 && S <= 25)
            {
                return 1;
            } 
            else if (S > 25 && S <= 50)
            {
                return 2;
            }
            else if (S > 50 && S <= 75)
            {
                return 3;
            }
            else if (S > 75 && S <= 95)
            {
                return 4;
            }
            else
            {
                return 0;
            }
        }
    }
}