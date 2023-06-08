using System.Diagnostics;
using Caliburn.Micro;

namespace LilithLurker.ViewModels
{
    public class ZoneViewModel : PropertyChangedBase
    {
        private string _name;

        public ZoneViewModel(string name)
        {
            _name = name;
        }

        public string Source => $"/Resources/{_name}.jpg";

        public void OpenPatreon()
        {
            var psi = new ProcessStartInfo
            {
                FileName = "https://www.patreon.com/poelurker",
                UseShellExecute = true
            };
            Process.Start(psi);
        }
    }
}
