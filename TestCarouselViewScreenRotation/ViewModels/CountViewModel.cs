using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;

namespace TestCarouselViewScreenRotation.ViewModels
{
    public class CountViewModel : INotifyPropertyChanged
    {
        public enum Type{
        FRAME,
        MEDIA,
        STACK,
        WEB
        };
        public enum CountEventType
        {
            NONE,
            PORTRAIT,
            LANDSCAPE,
            ALL,
        };
        public Type ContentType { get; set; }
        public CountEventType CountType { get; set; } = CountEventType.NONE;
        public bool IsCountVisible => CountType != CountEventType.NONE;

        public ICommand ViewCommand { get; set; }

        private Color color = Color.White;
        public Color Color
        {
            get { return color; }
            set
            {
                color = value;
                OnPropertyChanged();
            }
        }
        private int count;
        public int Count
        {
            get { return count; }
            set
            {
                count = value;
                OnPropertyChanged();
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
