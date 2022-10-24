using System.Drawing.Drawing2D;

namespace AlcoCalculator
{
    public partial class AlcoCalculator : Form
    {
        private static readonly Image[] Snifter =
        {
            Image.FromFile("Images/Рюмка1.png"),
            Image.FromFile("Images/Рюмка2.png"),
            Image.FromFile("Images/Рюмка3.png"),
            Image.FromFile("Images/Рюмка4.png"),
            Image.FromFile("Images/Рюмка5.png"),
        };
        private static readonly Image[] Wineglass =
        {
            Image.FromFile("Images/Бокал1.png"),
            Image.FromFile("Images/Бокал2.png"),
            Image.FromFile("Images/Бокал3.png"),
            Image.FromFile("Images/Бокал4.png"),
            Image.FromFile("Images/Бокал5.png")
        };
        private static readonly Image[] Beerglass =
        {
            Image.FromFile("Images/ПивнойБокал1.png"),
            Image.FromFile("Images/ПивнойБокал2.png"),
            Image.FromFile("Images/ПивнойБокал3.png"),
            Image.FromFile("Images/ПивнойБокал4.png"),
            Image.FromFile("Images/ПивнойБокал5.png"),
        };
        private static readonly Image[] Glass =
        {
            Image.FromFile("Images/Стакан1.png"),
            Image.FromFile("Images/Стакан2.png"),
            Image.FromFile("Images/Стакан3.png"),
            Image.FromFile("Images/Стакан4.png"),
            Image.FromFile("Images/Стакан5.png"),
        };       

        public AlcoCalculator()
        {
            InitializeComponent();
            begunokNaczunia.Height = 30;
            begunokSpirt.Height = 30;
            thumbNaczynia(0);
            thumbSpirt(0);
            thumbSztuk(0);            
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
        int valNaczynia = 5000;//этодля преобразования перемещения ползунка в миллилитры
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

            UpdatePicture(liczba);
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
        private void begunokSztuk_MouseUp(object sender, MouseEventArgs e)
        {
            mouseSztuk = false;
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
            if (wielkoscNaczynia.Text != null)
            {
                wielkoscNaczynia.Text = iloscNaczyniaLabel.Text;
            }
            else
            {
                int naczynia = Convert.ToInt32(wielkoscNaczynia.Text);
                thumbNaczynia(maxNaczynia / valNaczynia * naczynia);
                iloscNaczyniaLabel.Text = naczynia.ToString() + " ml";
            }
            if(zawartoscSpirytusu.Text != null)
            {
                zawartoscSpirytusu.Text = iloscSpirtLabel.Text;
            }
            else
            {
                int spirt = Convert.ToInt32(zawartoscSpirytusu.Text);
                thumbSpirt(maxSpirt / valSpirt * spirt);
                iloscSpirtLabel.Text = spirt.ToString() + " %";
            }
            if (iloscSztuk.Text != null)
            {
                iloscSztuk.Text = iloscSztukLabel.Text;
            }
            else
            {
                int sztuk = Convert.ToInt32(iloscSztuk.Text);
                thumbSztuk(maxSztuk / valSztuk * sztuk);
                iloscSztukLabel.Text = sztuk.ToString() + " sz";
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
        }

        private void UpdatePicture(float liczba)
        {
            if (liczba >= 0 && liczba <= 50)
            {
                pbNaczynia.Image = Snifter[0];
            }

            if (liczba > 50 && liczba <= 200)
            {
                pbNaczynia.Image = Glass[0];
            }

            if (liczba > 200 && liczba <= 250)
            {
                pbNaczynia.Image = Wineglass[0];
            }

            if (liczba > 250 && liczba <= 500)
            {
                pbNaczynia.Image = Beerglass[0];
            }
        }
    }
}