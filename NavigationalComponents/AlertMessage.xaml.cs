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
using System.Windows.Shapes;

namespace NavigationalComponents{
    /// <summary>
    /// Interaction logic for ErrorMessage.xaml
    /// </summary>
    public partial class AlertMessage : Window{
        public AlertMessage(){
            InitializeComponent();
        }

        private void OnClickOk_btn(object sender, RoutedEventArgs e){
            this.Close();
            ProgressBarControl progressBarControl = new ProgressBarControl();
            progressBarControl.ShowDialog();
        }

        private void OnClickCancel_btn(object sender, RoutedEventArgs e){
            this.Close();
        }
    }
}
