using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestCarouselViewScreenRotation
{
    public partial class App : Application
    {
        public App()
        {
            Device.SetFlags(new string[] { "CarouselView_Experimental", "MediaElement_Experimental", "IndicatorView_Experimental", "RadioButton_Experimental" });
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
