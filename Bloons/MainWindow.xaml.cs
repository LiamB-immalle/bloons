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
        }
        Balloon b = new Balloon();
        Balloon c = new Balloon();
        Balloon d = new Balloon();
        Balloon e = new Balloon();

        private void move_Click(object sender, RoutedEventArgs e)
        {
            b.MoveRight(5);
        }

        private void grow_Click(object sender, RoutedEventArgs e)
        {
            b.ChangeSize(5);
        }
    }
}       