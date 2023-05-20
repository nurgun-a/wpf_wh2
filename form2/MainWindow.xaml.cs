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

namespace form2
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

        private void LeftClick(object sender, RoutedEventArgs e)
        {

            Close();
        }

        private void TopClick(object sender, RoutedEventArgs e)
        {
            LeftClick(sender,e);
        }

        private void CenterClick(object sender, RoutedEventArgs e)
        {
            LeftClick(sender, e);
        }

        private void RighClick(object sender, RoutedEventArgs e)
        {
            LeftClick(sender, e);
        }

        private void BottomClick(object sender, RoutedEventArgs e)
        {
            LeftClick(sender, e);
        }
    }
}
