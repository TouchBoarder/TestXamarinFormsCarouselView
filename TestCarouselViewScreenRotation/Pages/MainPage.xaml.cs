using System.Collections.ObjectModel;
using System.ComponentModel;
using TestCarouselViewScreenRotation.ViewModels;
using Xamarin.Forms;

namespace TestCarouselViewScreenRotation
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private CountViewModel.CountEventType CountEventType = CountViewModel.CountEventType.NONE;

        private void Button_Clicked(object sender, System.EventArgs e)
        {
            //prevent double click
            if (Navigation?.NavigationStack?.Count > 1) 
                return;
            Page page = new CarouselViewPage();
            if (sender is Button button && button.CommandParameter is string test)
            {
                switch(test)
                {
                    case "All":

                        page = new CarouselViewPage(new CarouselViewModel(button.Text, new Collection<CountViewModel>
                        {
                            new CountViewModel(){CountType = CountEventType, ContentType = CountViewModel.Type.FRAME ,Color = Color.Red.MultiplyAlpha(0.2)},
                            new CountViewModel(){CountType = CountEventType, ContentType = CountViewModel.Type.STACK ,Color = Color.Blue.MultiplyAlpha(0.2)},
                            new CountViewModel(){CountType = CountEventType, ContentType = CountViewModel.Type.WEB ,Color = Color.Orange.MultiplyAlpha(0.2)},
                            new CountViewModel(){CountType = CountEventType, ContentType = CountViewModel.Type.MEDIA ,Color = Color.Green.MultiplyAlpha(0.2)},
                            new CountViewModel(){CountType = CountEventType, ContentType = CountViewModel.Type.FRAME ,Color = Color.Red.MultiplyAlpha(0.2)},
                            new CountViewModel(){CountType = CountEventType, ContentType = CountViewModel.Type.STACK ,Color = Color.Blue.MultiplyAlpha(0.2)},
                            new CountViewModel(){CountType = CountEventType, ContentType = CountViewModel.Type.WEB ,Color = Color.Orange.MultiplyAlpha(0.2)},
                        }));
                        break;
                    case "Frame":
                        page = new CarouselViewPage(new CarouselViewModel(button.Text, new Collection<CountViewModel>
                        {
                            new CountViewModel(){CountType = CountEventType, ContentType = CountViewModel.Type.FRAME ,Color = Color.Red.MultiplyAlpha(0.2)},
                            new CountViewModel(){CountType = CountEventType, ContentType = CountViewModel.Type.FRAME ,Color = Color.Blue.MultiplyAlpha(0.2)},
                             new CountViewModel(){CountType = CountEventType, ContentType = CountViewModel.Type.FRAME ,Color = Color.Green.MultiplyAlpha(0.2)},
                        }));
                        break;
                    case "Stack":
                        page = new CarouselViewPage(new CarouselViewModel(button.Text, new Collection<CountViewModel>
                        {
                           new CountViewModel(){CountType = CountEventType, ContentType = CountViewModel.Type.STACK ,Color = Color.Blue.MultiplyAlpha(0.2)},
                           new CountViewModel(){CountType = CountEventType, ContentType = CountViewModel.Type.STACK ,Color = Color.Green.MultiplyAlpha(0.2)},
                           new CountViewModel(){CountType = CountEventType, ContentType = CountViewModel.Type.STACK ,Color = Color.Red.MultiplyAlpha(0.2)},
                        }));
                        break;
                    case "Web":
                        page = new CarouselViewPage(new CarouselViewModel(button.Text, new Collection<CountViewModel>
                        {
                          new CountViewModel(){CountType = CountEventType, ContentType = CountViewModel.Type.WEB},
                          new CountViewModel(){CountType = CountEventType, ContentType = CountViewModel.Type.WEB},
                          new CountViewModel(){CountType = CountEventType, ContentType = CountViewModel.Type.WEB},
                        }));
                        break;
                    case "Media":
                        page = new CarouselViewPage(new CarouselViewModel(button.Text, new Collection<CountViewModel>
                        {
                          new CountViewModel(){CountType = CountEventType, ContentType = CountViewModel.Type.MEDIA ,Color = Color.Green.MultiplyAlpha(0.2)},
                          new CountViewModel(){CountType = CountEventType, ContentType = CountViewModel.Type.MEDIA ,Color = Color.Green.MultiplyAlpha(0.2)},
                          new CountViewModel(){CountType = CountEventType, ContentType = CountViewModel.Type.MEDIA ,Color = Color.Green.MultiplyAlpha(0.2)},
                        }));
                        break;
                }

            }
            Navigation.PushAsync(page);

        }

        private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if(sender is RadioButton rButton && rButton.IsChecked && rButton.CommandParameter is string countType)
                switch (countType) {
                    case "None":
                        CountEventType = CountViewModel.CountEventType.NONE;
                        break;
                    case "All":
                        CountEventType = CountViewModel.CountEventType.ALL;
                        break;
                    case "Portrait":
                        CountEventType = CountViewModel.CountEventType.PORTRAIT;
                        break;
                    case "Landscape":
                        CountEventType = CountViewModel.CountEventType.LANDSCAPE;
                        break;
                }
        }
    }
}
