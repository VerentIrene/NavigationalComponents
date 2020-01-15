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

namespace NavigationalComponents
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        String stringBreadCumb = "";
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void OnClickOpenMenu_btn(object sender, RoutedEventArgs e)
        {
            openMenu_btn.Visibility = Visibility.Collapsed;
            closeMenu_btn.Visibility = Visibility.Visible;
            closeMenu_btn.HorizontalAlignment = HorizontalAlignment.Right;
        }

        private void OnClickCloseMenu_btn(object sender, RoutedEventArgs e)
        {
            openMenu_btn.Visibility = Visibility.Visible;
            closeMenu_btn.Visibility = Visibility.Collapsed;
        }

        private void OnClickCloseWindow_btn(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void OnDownHome_sp(object sender, MouseButtonEventArgs e)
        {
            stringBreadCumb = home_tb.Text;
            breadCumb_tb.Text = stringBreadCumb;
        }
    }
}
