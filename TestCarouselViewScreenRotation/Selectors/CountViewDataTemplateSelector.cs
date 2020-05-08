using System;
using System.Collections.Generic;
using System.Text;
using TestCarouselViewScreenRotation.ViewModels;
using TestCarouselViewScreenRotation.Views;
using Xamarin.Forms;

namespace TestCarouselViewScreenRotation.Selectors
{
    public class CountViewDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate DataTemplateFrame { get; set; }
        public DataTemplate DataTemplateStack { get; set; }
        public DataTemplate DataTemplateMedia { get; set; }
        public DataTemplate DataTemplateWeb { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            if (item is CountViewModel model)
                switch (model.ContentType)
                {
                    case CountViewModel.Type.FRAME:
                        if (DataTemplateFrame == null)
                            DataTemplateFrame = new DataTemplate(() =>
                            {
                                return new FrameTestView(model);
                            });
                        return DataTemplateFrame;
                    case CountViewModel.Type.STACK:
                        if (DataTemplateStack == null)
                            DataTemplateStack = new DataTemplate(() =>
                            {
                                return new StackTestView(model);
                            });
                        return DataTemplateStack;
                    case CountViewModel.Type.MEDIA:
                        if (DataTemplateMedia == null)
                            DataTemplateMedia = new DataTemplate(() =>
                            {
                                return new MediaTestView(model);
                            });
                        return DataTemplateMedia;
                    case CountViewModel.Type.WEB:
                        if (DataTemplateWeb == null)
                            DataTemplateWeb = new DataTemplate(() =>
                            {
                                return new WebTestView(model);
                            });
                        return DataTemplateWeb;
                }
            return new DataTemplate(() =>
            {
                return new SizeAllocatedView();
            });
        }
    }
}
