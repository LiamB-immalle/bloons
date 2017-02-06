using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Bloons
{
    public class Balloon
    {
        private int x = 50;
        private int y = 50;
        private int d = 20;
        private Ellipse elli;

        public Balloon()
        {
            CreateEllipse();
            UpdateEllipse();
        }
        public void MoveRight(int xStep)
        {
            x = x + xStep;
            UpdateEllipse();
        }
        public void MoveLeft(int xStep)
        {
            x = x - xStep;
            UpdateEllipse();
        }
        public void MoveUp(int yStep)
        {
            y = y - yStep;
            UpdateEllipse();
        }
        public void MoveDown(int yStep)
        {
            y = y + yStep;
            UpdateEllipse();
        }
        public void Bigger(int change)
        {
            d = d + change;
            UpdateEllipse();
        }
        public void Smaller(int change)
        {
            d = d - change;
            UpdateEllipse();
        }
        public void DisplayOn(Canvas canvas)
        {
            canvas.Children.Add(elli);
        }
        private void CreateEllipse()
        {
            elli = new Ellipse();
            elli.Stroke = new SolidColorBrush(Colors.Red);
            elli.StrokeThickness = 2;
        }
        private void UpdateEllipse()
        {
            elli.Margin = new Thickness(x, y, 0, 0);
            elli.Width = d;
            elli.Height = d;
        }
    }
}
