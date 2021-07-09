using Sharpnado.HorizontalListView.RenderedViews;
using System;
using System.Globalization;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static SampleApp.ViewModels.CollectionViewTestViewModel;

namespace SampleApp.Converters
{
    public class ListModeToListLayout : IValueConverter, IMarkupExtension
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var mode = (ListMode)value;

            switch (mode)
            {
                case ListMode.List:
                    return HorizontalListViewLayout.Vertical;
                case ListMode.Grid:
                    return HorizontalListViewLayout.Grid;
                default:
                    return HorizontalListViewLayout.Vertical;
            }
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }
    }
}
