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
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent(); ;
            b.DisplayOn(canvas);
            c.DisplayOn(canvas);
            d.DisplayOn(canvas);
        }
        Balloon b = new Balloon();
        Balloon c = new Balloon();
        Balloon d = new Balloon();

        private void right_Click(object sender, RoutedEventArgs e)
        {
            b.MoveRight(1);
            c.MoveRight(2);
            d.MoveRight(5);
        }

        private void grow_Click(object sender, RoutedEventArgs e)
        {
            b.Bigger(5);
            c.Bigger(2);
            d.Bigger(20);         
        }

        private void down_Click(object sender, RoutedEventArgs e)
        {
            b.MoveDown(1);
            c.MoveDown(2);
            d.MoveDown(5);
        }

        private void left_Click(object sender, RoutedEventArgs e)
        {
            b.MoveLeft(1);
            c.MoveLeft(2);
            d.MoveLeft(5);
        }

        private void up_Click(object sender, RoutedEventArgs e)
        {
            b.MoveUp(1);
            c.MoveUp(2);
            d.MoveUp(5);
        }

        private void shrink_Click(object sender, RoutedEventArgs e)
        {
            b.Smaller(5);
            c.Smaller(2);
            d.Smaller(20);
        }
    }
}