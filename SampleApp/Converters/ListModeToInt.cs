using System;
using System.Globalization;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static SampleApp.ViewModels.CollectionViewTestViewModel;

namespace SampleApp.Converters
{
    public class ListModeToInt : IValueConverter, IMarkupExtension
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (int)value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (ListMode)value;
        }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }
    }
}
