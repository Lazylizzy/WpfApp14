using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace WpfApp14
{
    class PriorityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (((string)value)== "fish")
            {
                return "NewFolder1/fish.jpg";
            }
            if (((string)value) == "iron")
            {
                return "NewFolder1/iron.jpg";
            }
            if (((string)value) == "kettle")
            {
                return "NewFolder1/kettle.jpg";
            }
            
            return "NewFolder1/pizza.jpg";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
           return DependencyProperty.UnsetValue;
        }
    }
}
