using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecondLessonSP
{
    public partial class Form1 : Form
    {
        static int count;
        public Form1()
        {
        
            InitializeComponent();

        }


        private void DrwaLines(Rectangle rect)
        {
         
            Random rand = new Random();
            Graphics gr = CreateGraphics();
            Point point = new Point();
            int red = rand.Next(100, 255);
            int green = rand.Next(100, 255);
            int blue = rand.Next(100, 255);
            int width = rand.Next();
            Color color = Color.FromArgb(red, green, blue);
            Pen pen = new Pen(color, width);
            float x1 = rect.X;
            float y1 = rand.Next(rect.Top, rect.Bottom);
            float x2 = rand.Next(rect.X, rect.X + rect.Width);
            float y2 = rect.Y;
            float x3 = rect.X + rect.Width;
            float y3 = rand.Next(rect.Top, rect.Bottom);
            float x4 = rand.Next(rect.X, rect.X + rect.Width);
            float y4 = rect.Bottom;
            gr.DrawLine(pen, x1, y1, x2, y2);
            gr.DrawLine(pen, x2, y2, x3, y3);
            gr.DrawLine(pen, x3, y3, x4, y4);
            gr.DrawLine(pen, x4, y4, x1, y1);
       
        }

        private void ThreadFunction()
        {
            //подготовка к синхронизации 
            Rectangle rec = new Rectangle(10, 10, 100, 100);
            DrwaLines(rec);
            //потока завершение потока
        }

        private void MyRoutine()
        {
            Application.Run(new Form1());
        }


        Thread th;
        private void firstButton(object sender, EventArgs e)
        {
            button1.Text = "Pause";
            ThreadFunction();
        }

        private void secondButton(object sender, EventArgs e)
        {

        }


    }
}
