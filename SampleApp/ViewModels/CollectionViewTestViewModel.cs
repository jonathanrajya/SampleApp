using System.Collections.ObjectModel;
using System.Net.Http;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace SampleApp.ViewModels
{
    public class CollectionViewTestViewModel : BaseViewModel
    {
        public enum ListMode
        {
            List = 0,
            Grid = 1,
        }
        ListMode _mode;
        public ListMode Mode
        {
            get => _mode;
            set => SetProperty(ref _mode, value);
        }
        public ICommand SwitchListMode { get; set; }
        private ObservableCollection<TestItem> _items;
        public ObservableCollection<TestItem> Items
        {
            get => _items;
            set => SetProperty(ref _items, value);
        }
        public CollectionViewTestViewModel()
        {
            SwitchListMode = new Command<int>((int mode) => Mode = (ListMode)mode);
            Mode = ListMode.List;
            GetDummyData();
        }

        async void GetDummyData()
        {
            try
            {
                if (Connectivity.NetworkAccess == NetworkAccess.Internet)
                {
                    using (var client = new HttpClient())
                    {
                        var response = await client.GetStringAsync("https://jsonplaceholder.typicode.com/photos");
                        Items = new ObservableCollection<TestItem>(JsonConvert.DeserializeObject<List<TestItem>>(response));
                    }
                }
                else
                {
                    await Shell.Current.DisplayAlert("Alert", "Please check your internet connection", "Ok");
                }
            }
            catch (System.Exception)
            {
                await Shell.Current.DisplayAlert("Alert", "An unknown error occurred", "Ok");
            }
        }
    }

    public class TestItem
    {
        public int albumId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public string url { get; set; }
        public string thumbnailUrl { get; set; }
    }
}
