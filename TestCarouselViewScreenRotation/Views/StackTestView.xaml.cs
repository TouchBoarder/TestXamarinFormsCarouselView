using TestCarouselViewScreenRotation.ViewModels;
using Xamarin.Forms.Xaml;

namespace TestCarouselViewScreenRotation.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StackTestView : SizeAllocatedView
    {
        public StackTestView()
        {
            InitializeComponent();
        }
        public StackTestView(CountViewModel model) : base(model)
        {
            InitializeComponent();
        }
    }
}