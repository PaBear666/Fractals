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
                if (int.TryParse((length.Text), out int result) && int.Parse(length.Text) >= 1)
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
                if (int.TryParse(angle.Text,out int result) && int.Parse(angle.Text) >= 0)
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
        private void Default_Values_Click(object sender, EventArgs e)
        {
            line_length.Text = "10";
            length.Text = "5";
            angle.Text = "20";
        }
        private void DrawPicture_Click(object sender, EventArgs e)
        {
            try
            {
                panel1.CreateGraphics().Clear(Color.Gray);
                RuleForFractals rulefor = new RuleForFractals(Length, "X", Angle,Line_Length,panel1.Width / 2,panel1.Height/2);
                rulefor.Draw(panel1);
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }


    }
}
