using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace NavigationalComponents
{
    class FactoryButton
    {
        public FactoryButton()
        {

        }

        public Button AddButton(string caption, int row, int column, Grid parent)
        {
            Button button = new Button();
            button.Content = caption;
            parent.Children.Add(button);
            Grid.SetRow(button, row);
            Grid.SetColumn(button, column);          
            return button;
        }
    }
}
