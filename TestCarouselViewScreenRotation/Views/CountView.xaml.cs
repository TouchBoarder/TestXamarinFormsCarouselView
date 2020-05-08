using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestCarouselViewScreenRotation.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CountView : StackLayout
    {
        public CountView()
        {
            InitializeComponent();
        }
    }
}