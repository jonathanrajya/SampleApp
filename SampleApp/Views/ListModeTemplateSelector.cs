using Sharpnado.HorizontalListView.RenderedViews;
using Xamarin.Forms;

namespace SampleApp.Views
{
    public class ListModeTemplateSelector : DataTemplateSelector
    {
        public DataTemplate GridTemplate { get; set; }
        public DataTemplate VerticalTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var horizontalList = (HorizontalListView)container;
            HorizontalListViewLayout layout = horizontalList.ListLayout;

            switch (layout)
            {
                case HorizontalListViewLayout.Grid:
                    return GridTemplate;

                case HorizontalListViewLayout.Vertical:
                    return VerticalTemplate;

                default:
                    return VerticalTemplate;
            }
        }
    }
}
