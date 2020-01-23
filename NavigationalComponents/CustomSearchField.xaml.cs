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
    /// Interaction logic for HomeUserControl.xaml
    /// </summary>
    public partial class CustomSearchField : UserControl
    {
        public CustomSearchField()
        {
            InitializeComponent();
        }

        private void OnPreviewMouseLeftButtonDownSearch_txt(object sender, MouseButtonEventArgs e)
        {
            search_txt.Foreground = Brushes.Black;
            search_txt.Text = String.Empty;
        }

        private void OnKeyDownSearch_txt(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Return)
            {
                FactoryListBoxItem listBoxItem = new FactoryListBoxItem();
                searchList_lb.Items.Add(listBoxItem.AddListBoxItem(search_txt.Text));
                searchList_lb.Height += FactoryListBoxItem.heightBox;

                if (searchList_lb.Items.Count > 10)
                {
                    searchList_lb.Items.RemoveAt(0);
                    searchList_lb.Height -= FactoryListBoxItem.heightBox;
                }
            }
        }
    }
}
