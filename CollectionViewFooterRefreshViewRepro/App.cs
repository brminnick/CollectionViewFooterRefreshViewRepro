using Xamarin.Forms;

namespace CollectionViewFooterRefreshViewRepro
{
    public class App : Application
    {
        public App() => MainPage = new NavigationPage(new SelectionPage());
    }

    class SelectionPage : ContentPage
    {
        public SelectionPage()
        {
            var withFooterButton = new Button
            {
                Text = "CollectionView with Footer"
            };
            withFooterButton.Clicked += async (sender, e) => await Navigation.PushAsync(new CollectionViewPage(true));

            var noFooterButton = new Button
            {
                Text = "CollectionView without Footer"
            };
            noFooterButton.Clicked += async (sender, e) => await Navigation.PushAsync(new CollectionViewPage(false));

            Content = new StackLayout
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                Children =
                {
                    withFooterButton,
                    noFooterButton
                }
            };
        }
    }
}
