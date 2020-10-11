using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class RuleForFractals
    {

        private int Length { get; set; }
        private string Axiom { get; set; }
        private string Rule { get; set; }
        private int Line_Length { get; set; }
        public string[] Levels { get; private set; }
        private int Angle { get; set; }
        private int StartAngle { get; set; }
        private double X { get; set; }
        private double Y { get; set; }

        //"F" – переместиться вперед на шаг h в направлении , оставив след
        //(нарисовав отрезок);
        //"f" – переместиться вперед на шаг h в направлении , не оставляя следа;
        //"+" – повернуть направо(по часовой стрелке) на угол  (изменить
        //направление движения);
        //"–" – повернуть налево(против часовой стрелки) на угол  (изменить
        //направление движения);
        //"[" – запомнить(отложить в стек) текущее состояние(x, y, );
        //"]" – вспомнить(взять из стека и установить) последнее сохраненное в
        //памяти состояние(x, y, );
        public RuleForFractals(int length, string axiom, int angle,int line_length,double x,double y)
        {
            X = x;
            Y = y;
            Line_Length = line_length;
            StartAngle = 0;
            Angle = angle;
            Length = length + 1;
            Axiom = axiom;
            Levels = new string[Length];
            Levels[0] = axiom;
        }
        public string LengthUp()
        {
            
            for(int i = 0; i < Length - 1;i++)
            {
                foreach (char letter in Levels[i])
                {
                    switch (letter)
                    {
                        case 'F':
                            Levels[i + 1] = Levels[i + 1] + "-F++F-";
                            break;
                        case 'X':
                            Levels[i + 1] = Levels[i + 1] + "F[+X]F[-X]+X";
                            break;
                        default:
                            Levels[i + 1] = Levels[i + 1] + letter;
                            break;
                    }
                }
            }
            return Levels[Length - 1];
        }
        public void Draw(Panel form) 
        {
            Stack<string> position = new Stack<string>();
            foreach (char letter in Levels[Length - 1]) 
            {
                switch (letter)
                {
                    case 'F':
                        double x1 = X + Line_Length * Math.Sin(StartAngle * Math.PI * 2 / 360.0);
                        double y1 = Y + Line_Length * Math.Cos(StartAngle * Math.PI * 2 / 360.0);
                        form.CreateGraphics().DrawLine(new Pen(Color.White), (int)X, (int)(form.Height - Y), (int)x1, form.Height - (int)y1);
                        X = x1;
                        Y = y1;
                        break;
                    case '+':
                        StartAngle += Angle;
                        break;
                    case '-':
                        StartAngle -= Angle;
                        break;
                    case '[':
                        position.Push($"{X} {Y} {StartAngle}");
                        break;
                    case ']':
                        string[] words = position.Pop().Split(new char[] {' '});
                        X = double.Parse(words[0]);
                        Y = double.Parse(words[1]);
                        StartAngle = int.Parse(words[2]);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
