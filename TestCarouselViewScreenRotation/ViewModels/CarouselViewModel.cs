using System.Collections.Generic;
using System.Collections.ObjectModel;
using TestCarouselViewScreenRotation.Selectors;
using Xamarin.Forms;

namespace TestCarouselViewScreenRotation.ViewModels
{
    public class CarouselViewModel
    {
        public string Title { get; set; }
        public ObservableCollection<CountViewModel> Items { get; set; }
        public DataTemplateSelector TemplateSelector { get; set; }

        public CarouselViewModel(string title,IEnumerable<CountViewModel> items)
        {
            Title = title;
            Items = new ObservableCollection<CountViewModel>(items);
            TemplateSelector = new CountViewDataTemplateSelector();
            IndicatorIsVisible = Items.Count > 1;
        }
        public bool IndicatorIsVisible { get; set; }
    }
   
}
