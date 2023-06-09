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
    private bool _open;
    private bool _helltideActive;

    public LilithViewModel(DockingHelper helper, IEventAggregator eventAggregator)
        : base(helper)
    {
        _eventAggregator = eventAggregator;
        
        IsVisible = true;
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

    public bool Open
    {
        get => _open;
        set
        {
            _open = value;
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
        Open = !Open;
        _eventAggregator.PublishOnCurrentThreadAsync(new LilithMessage());
    }

    public void OnTimerClick()
    {
        if (HelltideActive)
        {

        }
    }

    protected override void SetWindowPosition(WindowInformation windowInformation)
    {
        var width = 390 * windowInformation.Height / 1440;
        var height = 100 * windowInformation.Height / 1440;
        var rigthMargin = 30 * windowInformation.Height / 1440;
        var topMargin = 290 * windowInformation.Height / 1440;
        Execute.OnUIThread(() =>
        {
            Window.Height = ApplyAbsoluteScalingY(height);
            Window.Width = ApplyAbsoluteScalingX(width);
            Window.Left = ApplyScalingX(windowInformation.Position.Right - width - rigthMargin);
            Window.Top = ApplyScalingY(windowInformation.Position.Top + topMargin);
        });
    }

    private string GetSource()
    {
        switch(_helltideStatus.State)
        {
            case HelltideState.Active:
                return "/Resources/LilithActive.png";
            case HelltideState.Over:
                return "/Resources/Lilith.png";
            case HelltideState.Verge:
                return "/Resources/LilithVerge.png";
        }

        return "/Resources/Lilith.png";
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
