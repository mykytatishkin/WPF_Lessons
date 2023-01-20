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

namespace WPF_hw_2
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

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                this.Height = 300;
                this.Width = 300;

                this.Top = 0;
                this.Left = 0;
            }
            if (e.Key == Key.Up)
            {
                this.Top = 0;
            }
            if (e.Key == Key.Down)
            {
                this.Top = SystemParameters.WorkArea.Height - this.Height;
            }
            if(e.Key == Key.Left)
            {
                this.Left = 0;
            }
            if(e.Key == Key.Right)
            {
                this.Left = SystemParameters.WorkArea.Width - this.Width;
            }
        }
    }
}
