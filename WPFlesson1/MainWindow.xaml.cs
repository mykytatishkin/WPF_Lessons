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

namespace WPFlesson1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        int leftButton = 0;
        int rightButton = 0;
        int middleButton = 0;
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                leftButton++;
            }
            if (e.ChangedButton == MouseButton.Right)
            {
                rightButton++;
            }
            if (e.ChangedButton == MouseButton.Middle)
            {
                middleButton++;
            }
            this.Title = "Left: " + leftButton.ToString() + " Right: " + rightButton.ToString() + " Middle: " + middleButton.ToString();
        }
    }
}
