using TestCarouselViewScreenRotation.ViewModels;
using Xamarin.Forms.Xaml;

namespace TestCarouselViewScreenRotation.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WebTestView : SizeAllocatedView
    {
        public WebTestView()
        {
            InitializeComponent();
        }
        public WebTestView(CountViewModel model) : base(model)
        {
            InitializeComponent();
        }
    }
}