using System.Drawing.Drawing2D;

namespace AlcoCalculator
{
    public partial class AlcoCalculator : Form
    {
        public AlcoCalculator()
        {
            InitializeComponent();
            begunokNaczunia.Height = 30;
            begunokSpirt.Height = 30;
            thumbNaczynia(0);
            thumbSpirt(0);
            
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
            float liczaba = (float)(begunokNaczynia_width(e.X))*valNaczynia;          
            iloscNaczyniaLabel.Text = liczaba.ToString("#")+" ml";
            if (liczaba < minNaczynia*valNaczynia)
            {
                liczaba = minNaczynia * valNaczynia;             
                iloscNaczyniaLabel.Text = liczaba.ToString()+" ml";
            }
            else if (liczaba > maxNaczynia*valNaczynia)
            {
                liczaba = maxNaczynia*valNaczynia;               
                iloscNaczyniaLabel.Text = liczaba.ToString()+" ml";
            }
           
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
            e.Graphics.FillRectangle(Brushes.Azure,0,y,begunokNaczunia.Width,y/2);
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
        int valSpirt = 95;//этодля преобразования перемещения ползунка в градусы
        bool mouseSpirt = false;
        public float BarSpirt(float value)
        {
            return (begunokSpirt.Width - 24) * (value - minSpirt) / (float)(maxSpirt - minSpirt);
        }

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
            float liczaba = (float)(begunokSpirt_width(e.X)) * valSpirt;
            iloscSpirtLabel.Text = liczaba.ToString("#") + " %";
            if (liczaba < minSpirt * valSpirt)
            {
                liczaba = minSpirt * valSpirt;
                iloscSpirtLabel.Text = liczaba.ToString() + " %";
            }
            else if (liczaba > maxSpirt * valSpirt)
            {
                liczaba = maxSpirt * valSpirt;
                iloscSpirtLabel.Text = liczaba.ToString() + " %";
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

        private void beginokSpirt_Draw(object sender, PaintEventArgs e)
        {
            float bar_Size = 0.45f;
            float x = BarSpirt(default_ValueSpirt);
            int y = (int)(begunokSpirt.Height * bar_Size);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.FillRectangle(Brushes.Azure, 0, y, begunokSpirt.Width, y / 2);
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
        private void result_Click(object sender, EventArgs e)
        {
            int naczynia = Convert.ToInt32(wielkoscNaczynia.Text);
            int spirt = Convert.ToInt32(zawartoscSpirytusu.Text);
            float x = naczynia / valNaczynia;
            float y = spirt / valSpirt;
            thumbNaczynia(maxNaczynia/valNaczynia*naczynia);
            thumbSpirt(maxSpirt/valSpirt*spirt);       
            iloscNaczyniaLabel.Text = naczynia.ToString() + " ml";
            iloscSpirtLabel.Text = spirt.ToString()+" %";
        }

    }
}