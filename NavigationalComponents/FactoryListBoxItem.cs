using System;
using System.Collections.Generic;
using System.Windows.Media;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace NavigationalComponents
{
    class FactoryListBoxItem
    {
        public static int heightBox = 30;
        public FactoryListBoxItem() { }

        public ListBoxItem AddListBoxItem(String _textListItem)
        {
            ListBoxItem listBoxItem = new ListBoxItem();
            listBoxItem.Foreground = Brushes.Black;
            listBoxItem.Content = _textListItem.ToString();
            listBoxItem.Height = heightBox;
            listBoxItem.FontSize = 10;
            return listBoxItem;
        }
    }
}
