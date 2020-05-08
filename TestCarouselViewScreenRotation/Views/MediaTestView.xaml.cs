using System;
using TestCarouselViewScreenRotation.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestCarouselViewScreenRotation.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MediaTestView : SizeAllocatedView
    {
        public MediaTestView()
        {
            InitializeComponent();
        }
        public MediaTestView(CountViewModel model) : base(model)
        {
            InitializeComponent();
            model.ViewCommand = new Command(ForcePause);
        }
        void OnPlayPauseButtonClicked(object sender, EventArgs args)
        {
            if (mediaElement.CurrentState == MediaElementState.Stopped ||
                mediaElement.CurrentState == MediaElementState.Paused)
            {
                mediaElement.Play();
            }
            else if (mediaElement.CurrentState == MediaElementState.Playing)
            {
                mediaElement.Pause();
            }
        }

        void OnStopButtonClicked(object sender, EventArgs args)
        {
            mediaElement.Stop();
        }
        void ForcePause()
        {
            if(mediaElement?.CurrentState == MediaElementState.Playing)
            Device.BeginInvokeOnMainThread(()=>
             mediaElement?.Pause());
        }
    }
}