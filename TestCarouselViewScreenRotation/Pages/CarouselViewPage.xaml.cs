using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using TestCarouselViewScreenRotation.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestCarouselViewScreenRotation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarouselViewPage : ContentPage
    {

        private CarouselViewModel ViewModel { get { return BindingContext as CarouselViewModel; } }
        public CarouselViewPage()
        {
            InitializeComponent(); 
            BindingContext = new CarouselViewModel("Test Frame",new Collection<CountViewModel>() { 
                new CountViewModel(){ContentType = CountViewModel.Type.FRAME}
            });
        }
        public CarouselViewPage(CarouselViewModel carouselViewModel)
        {
            InitializeComponent();
            BindingContext = carouselViewModel;
        }
        protected override void OnDisappearing()
        {   
            //NB! This is only applied here to continue testing without a hard restart of the app.
            //A better solution for this is to handle it in carouselview current item changed
            if (Device.RuntimePlatform == Device.iOS)
            {
                foreach (var item in ViewModel?.Items)
                {
                    if(item.ContentType == CountViewModel.Type.MEDIA)
                    {
                    //Fix MediaElement playback continues to play in the background on iOS!
                    //BUG: CarouselView on iOS do not stopp playback like Android does when 
                    //current carousel view is changed or parent page is popped from stack.
                    item.ViewCommand?.Execute(null);
                    //NB! This do not work if multiple MediaElement has been started 
                    //or because of screen rotation carouselview bug on iOS. It looks like it initializes 
                    //new instances of the views instead of re-using the view from the datatemplate?       
                    }
                }
            }
            base.OnDisappearing();


        }
    }
}