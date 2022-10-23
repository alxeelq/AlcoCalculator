namespace AlcoCalculator
{
    public partial class AlcoCalculator : Form
    {
        public AlcoCalculator()
        {
            InitializeComponent();
            begunok.Height = 30;
            
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
            
            float liczaba = (float)(begunok_width(e.X)) * val;
            wielkoscNaczynia.Text = liczaba.ToString("#") + " ml";
            if (liczaba < min * val)
            {
                liczaba = min * val;
                wielkoscNaczynia.Text = liczaba.ToString() + " ml";
            }
            else if (liczaba > max * val)
            {
                liczaba = max * val;
                wielkoscNaczynia.Text = liczaba.ToString() + " ml";
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

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
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