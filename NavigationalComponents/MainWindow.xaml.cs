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

namespace NavigationalComponents{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window{
        String stringBreadCumb;
        public MainWindow(){
            InitializeComponent();
        }
        
        private void OnClickOpenMenu_btn(object sender, RoutedEventArgs e){
            openMenu_btn.Visibility = Visibility.Collapsed;
            closeMenu_btn.Visibility = Visibility.Visible;
            closeMenu_btn.HorizontalAlignment = HorizontalAlignment.Right;
            breadCumb_tb.Margin = new Thickness(220, 10, 10, 10);
        }

        private void OnClickCloseMenu_btn(object sender, RoutedEventArgs e){
            openMenu_btn.Visibility = Visibility.Visible;
            closeMenu_btn.Visibility = Visibility.Collapsed;
            breadCumb_tb.Margin = new Thickness(80, 10, 10, 10);
        }

        private void OnClickCloseWindow_btn(object sender, RoutedEventArgs e){
            AlertMessage alertMessage = new AlertMessage();
            alertMessage.ShowDialog();
        }

        private void OnPreviewMouseLeftButtonDownAbout_lvi(object sender, MouseButtonEventArgs e){
            About about = new About();
            about.ShowDialog();
        }

        private void OnPreviewMouseLeftButtonDownHome_lvi(object sender, MouseButtonEventArgs e){
            stringBreadCumb = "";
            stringBreadCumb += home_tb.Text;
            breadCumb_tb.Text = stringBreadCumb;
        }
        private void OnPreviewMouseLeftButtonDownProfile_lvi(object sender, MouseButtonEventArgs e){
            stringBreadCumb = "";
            stringBreadCumb += profile_tb.Text;
            breadCumb_tb.Text = stringBreadCumb;
        }
    }
}
