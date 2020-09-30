using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public int Line_Length 
        {
            
            get
            {
                if (int.TryParse((line_length.Text),out int result))
                {
                    return int.Parse(line_length.Text);
                }
                else 
                {
                    throw new Exception();
                }
            }
        }
        public int  Length
        {
            get
            {
                if (int.TryParse((length.Text), out int result) && int.Parse(length.Text) > 1)
                {
                    return int.Parse(length.Text);
                }
                else
                {
                    throw new Exception();
                }
            }
        }
        public int Angle
        {
            get
            {
                if (int.TryParse(angle.Text,out int result) && int.Parse(angle.Text) >= 1 && int.Parse(angle.Text) <= 90)
                {
                    return int.Parse(angle.Text);
                }
                else
                {
                    throw new Exception();
                }
            }
        }
        public Form1()
        {
            InitializeComponent();
        }
        public void FractalDraw(int x, int y, double startangel, double angel, int length, int length_reduction)
        {
            double x1, y1, y2, x2;
            x1 = x + length * Math.Sin(startangel * Math.PI * 2 / 360.0);
            y1 = y + length * Math.Cos(startangel * Math.PI * 2 / 360.0);
            y2 = y + length * Math.Cos(startangel * Math.PI * 2 / 360.0) / 2;
            x2 = x + length * Math.Sin(startangel * Math.PI * 2 / 360.0) / 2;
            CreateGraphics().DrawLine(new Pen(Color.Black), x, panel1.Height - y, (int)x1,panel1.Height - (int)y1);
            if (length > 2)
            {
                FractalDraw((int)x2, (int)y2, startangel + angel, angel, (int)(length / length_reduction), length_reduction);
                FractalDraw((int)x1, (int)y1, startangel - angel, angel, (int)(length / length_reduction), length_reduction);
                FractalDraw((int)x1, (int)y1, startangel + angel, angel, (int)(length / length_reduction), length_reduction);
            }
        }
        private void Default_Values_Click(object sender, EventArgs e)
        {
            line_length.Text = "10";
            length.Text = "6";
            angle.Text = "20";
        }

        private void DrawPicture_Click(object sender, EventArgs e)
        {
            try
            {
                panel1.CreateGraphics().Clear(Color.Gray);
                //FractalDraw(Width / 2, 0, 0, Angle, Begin_Length, Length_Reduction);
                RuleForFractals rulefor = new RuleForFractals(Length, "X",Angle,Line_Length,panel1.Width / 2,0);
                Console.WriteLine(rulefor.LengthUp());
                rulefor.Draw(panel1);
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }


    }
}
