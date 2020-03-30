using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CollectionViewFooterRefreshViewRepro
{
    class CollectionViewPage : ContentPage
    {
        readonly CollectionView _collectionView;
        readonly RefreshView _refreshView;

        public CollectionViewPage(bool shouldUseFooter)
        {
            Title = shouldUseFooter ? "Refresh Indicator is Hidden" : "Refresh Indicator is Visible";

            _collectionView = new CollectionView
            {
                Footer = shouldUseFooter ? new BoxView { HeightRequest = 20 } : null
            };

            _refreshView = new RefreshView
            {
                RefreshColor = Color.Black,
                Content = _collectionView,
                Command = new Command(async () => await GenerateItemSource())
            };

            Content = _refreshView;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            _refreshView.IsRefreshing = true;
        }

        async Task GenerateItemSource()
        {
            var itemSource = new List<string>();

            for (int i = 0; i < 100; i++)
                itemSource.Add($"Row {i}");

            _collectionView.ItemsSource = itemSource;

            await Task.Delay(2000);

            _refreshView.IsRefreshing = false;
        }
    }
}
