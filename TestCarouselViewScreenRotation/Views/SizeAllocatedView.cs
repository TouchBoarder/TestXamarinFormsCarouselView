using TestCarouselViewScreenRotation.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestCarouselViewScreenRotation.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SizeAllocatedView : ContentView
    {
        private CountViewModel ViewModel { get { return BindingContext as CountViewModel; } }
        public SizeAllocatedView()
        {
            Visual = VisualMarker.MatchParent;
            BindingContext = new CountViewModel();
        }
        public SizeAllocatedView(CountViewModel viewModel)
        {
            Visual = VisualMarker.MatchParent;
            BindingContext = viewModel;
        }
        int count = 0;
        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);
            if(ViewModel != null)
                switch (ViewModel.CountType)
                {
                    case CountViewModel.CountEventType.NONE:
                        break;
                    case CountViewModel.CountEventType.PORTRAIT:
                        if (width < height)
                            ViewModel.Count = count++;
                        break;
                    case CountViewModel.CountEventType.LANDSCAPE:
                        if(width>height)
                            ViewModel.Count = count++;
                        break;
                    case CountViewModel.CountEventType.ALL:
                        ViewModel.Count = count++;
                        break;
                }   
        }
    }
}