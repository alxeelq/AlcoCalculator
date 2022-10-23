using System.Drawing.Drawing2D;

namespace AlcoCalculator
{
    public partial class AlcoCalculator : Form
    {
        public AlcoCalculator()
        {
            InitializeComponent();
            begunok.Height = 30;
            
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

        //Это отрисовка компонентов для ползунка начало
        float default_Value = 0.1f, min = 0.0f, max = 1.0f;
        int val = 5000;//этодля преобразования перемещения ползунка в миллилитры
        public float Bar(float value)
        {
            return(begunok.Width-24)*(value-min)/(float)(max-min);          
        }

        public void thumb(float value)
        {
            if(value < min) value = min;
            if(value > max) value = max;
            default_Value = value;
            begunok.Refresh();
        }

        bool mouse = false;
        private void begunok_MouseDown(object sender, MouseEventArgs e)
        {
            mouse = true;
            thumb(begunok_width(e.X));
            
            float liczba = (float)(begunok_width(e.X)) * val;
            wielkoscNaczynia.Text = liczba.ToString("#") + " ml";
            if (liczba < min * val)
            {
                liczba = min * val;
                wielkoscNaczynia.Text = liczba.ToString() + " ml";
            }
            else if (liczba > max * val)
            {
                liczba = max * val;
                wielkoscNaczynia.Text = liczba.ToString() + " ml";
            }
        }

        private void begunok_MouseMove(object sender, MouseEventArgs e)
        {
            if(!mouse) return;
            thumb(begunok_width(e.X));
            float liczaba = (float)(begunok_width(e.X))*val;          
            wielkoscNaczynia.Text = liczaba.ToString("#")+" ml";
            if (liczaba < min*val)
            {
                liczaba = min * val;             
                wielkoscNaczynia.Text = liczaba.ToString()+" ml";
            }
            else if (liczaba > max*val)
            {
                liczaba = max*val;               
                wielkoscNaczynia.Text = liczaba.ToString()+" ml";
            }
           
        }
        private void begunok_MouseUp(object sender, MouseEventArgs e)
        {
            mouse=false;
        }



        public float begunok_width(int x)
        {
            return min+(max-min)*x/(float)(begunok.Width);
        }

        private void beginok_Draw(object sender, PaintEventArgs e)
        {
            float bar_Size = 0.45f;
            float x = Bar(default_Value);
            int y = (int)(begunok.Height * bar_Size);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.FillRectangle(Brushes.Azure,0,y,begunok.Width,y/2);
            e.Graphics.FillRectangle(Brushes.Red,0,y,x,begunok.Height-2*y);
            using (Pen pen = new Pen(Color.Black, 8))
            {
                e.Graphics.DrawEllipse(pen, x+4 , y - 6, begunok.Height/2, begunok.Height / 2);
                e.Graphics.FillEllipse(Brushes.Red, x+4 , y - 6, begunok.Height / 2, begunok.Height / 2);
            }
            using (Pen pen = new Pen(Color.White, 5))
            {
                e.Graphics.DrawEllipse(pen,x+4, y - 6, begunok.Height / 2,begunok.Height/2);
            }
        }
//Здесь конец
        
    }
}