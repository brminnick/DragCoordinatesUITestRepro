using System;

using Xamarin.Forms;
using System.Threading.Tasks;

namespace DragCoordinatesUITestRepro
{
    public class App : Application
    {
        public App() => MainPage = new NavigationPage(new ListViewContentPage());

        class ListViewContentPage : ContentPage
        {
            public ListViewContentPage()
            {
                var listView = new ListView
                {
                    IsPullToRefreshEnabled = true,
                    ItemsSource = new string[]{
                        "Hello",
                        "Hello",
                        "Hello",
                        "Hello",
                        "Hello",
                        "Hello",
                        "Hello",
                        "Hello",
                        "Hello"
                    },
                    AutomationId = "ListView"
                };
				listView.RefreshCommand = new Command(async () =>
				{
					await Task.Delay(2000);
					listView.EndRefresh();
                });

                Content = listView;
            }
        }
    }
}
