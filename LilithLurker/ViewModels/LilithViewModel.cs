using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows;
using Caliburn.Micro;
using LilithLurker.Helpers;
using LilithLurker.Models;
using LilithLurker.Services;

namespace LilithLurker.ViewModels;

public class LilithViewModel : ScreenViewModelBase
{
    private readonly IEventAggregator _eventAggregator;
    private HelltideStatus _helltideStatus;
    private string _source;
    private string _timer;
    private bool _helltideActive;

    public LilithViewModel(DockingHelper helper, IEventAggregator eventAggregator)
        : base(helper)
    {
        _eventAggregator = eventAggregator;
        WatchHelltide();
    }

    public string Timer
    {
        get => _timer;
        set
        {
            _timer = value;
            NotifyOfPropertyChange();
        }
    }

    public bool HelltideActive
    {
        get => _helltideActive;
        set
        {
            _helltideActive = value;
            NotifyOfPropertyChange();
        }
    }

    public string Source
    {
        get
        {
            return _source;
        }

        set
        {
            _source = value;
            NotifyOfPropertyChange();
        }
    }

    public void OnClick()
    {
        _eventAggregator.PublishOnCurrentThreadAsync(new LilithMessage());
    }

    public void OnTimerClick()
    {
        if (HelltideActive)
        {
            var psi = new ProcessStartInfo
            {
                FileName = "https://helltides.com/",
                UseShellExecute = true
            };
            Process.Start(psi);
        }
    }

    protected override void SetWindowPosition(WindowInformation windowInformation)
    {
        var width = 390 * windowInformation.Height / 1440;
        var height = 50 * windowInformation.Height / 1440;
        Execute.OnUIThread(() =>
        {
            Window.Height = ApplyAbsoluteScalingY(height);
            Window.Width = ApplyAbsoluteScalingX(width);
            Window.Left = ApplyScalingX(windowInformation.Position.Right - width);
            Window.Top = ApplyScalingY(windowInformation.Position.Bottom - height);
        });
    }

    private string GetSource()
    {
        return _helltideStatus.State switch
        {
            HelltideState.Active => "/Resources/LilithActive.png",
            HelltideState.Over => "/Resources/Lilith.png",
            HelltideState.Verge => "/Resources/LilithVerge.png",
            _ => "/Resources/Lilith.png",
        };
    }

    private async void WatchHelltide()
    {
        while (true)
        {
            _helltideStatus = HelltideService.GetStatus();
            Source = GetSource();
            Timer = _helltideStatus.GetDisplay();
            HelltideActive = _helltideStatus.State == HelltideState.Active;

            await Task.Delay(1000);
        }
    }
}
