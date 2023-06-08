using Caliburn.Micro;

namespace LilithLurker.ViewModels
{
    public class ZoneSelectorViewModel : PropertyChangedBase
    {
        public ZoneSelectorViewModel()
        {
            SelectedZone = new ZoneViewModel();    
        }

        public ZoneViewModel SelectedZone { get; set; }
    }
}
