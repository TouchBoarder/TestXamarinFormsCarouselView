using TestCarouselViewScreenRotation.ViewModels;
using Xamarin.Forms.Xaml;

namespace TestCarouselViewScreenRotation.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FrameTestView : SizeAllocatedView
    {
        public FrameTestView()
        {
            InitializeComponent();
        }
        public FrameTestView(CountViewModel model) : base(model)
        {
            InitializeComponent();
        }
    }
}