using Sharpnado.HorizontalListView.RenderedViews;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SampleApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CollectionViewTest : ContentPage
    {
        public CollectionViewTest()
        {
            InitializeComponent();
        }

        private void List_ListLayoutChanging(object sender, ListLayoutChangedEventArgs e)
        {
            switch (e.ListLayout)
            {
                case HorizontalListViewLayout.Linear:
                    ItemList.ItemWidth = 260;
                    ItemList.ItemHeight = 260;
                    ItemList.ColumnCount = 0;
                    ItemList.Margin = Device.RuntimePlatform == Device.Android
                        ? new Thickness(0, 60, 0, 0)
                        : new Thickness(0, -60, 0, 0);
                    break;

                case HorizontalListViewLayout.Grid:
                    ItemList.ItemHeight = 140;
                    ItemList.ColumnCount = 2;
                    break;

                case HorizontalListViewLayout.Vertical:
                    ItemList.ColumnCount = 1;
                    ItemList.ItemHeight = 80;
                    break;
            }
        }
    }
}