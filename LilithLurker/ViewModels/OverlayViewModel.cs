using System.Threading;
using System.Threading.Tasks;
using Caliburn.Micro;
using LilithLurker.Helpers;
using LilithLurker.Models;

namespace LilithLurker.ViewModels;

public class OverlayViewModel : ScreenViewModelBase, IHandle<LilithMessage>
{
    private bool _hasZoneSelected;
    private IEventAggregator _eventAggregator;

    public OverlayViewModel(DockingHelper helper, IEventAggregator eventAggregator)
        : base(helper)
    {
        _eventAggregator = eventAggregator;
        Selector = new ZoneSelectorViewModel();
        Selector.PropertyChanged += Selector_PropertyChanged;

        _eventAggregator.SubscribeOnPublishedThread(this);
    }

    public ZoneSelectorViewModel Selector { get; set; }

    public bool HasZoneSelected
    {
        get => _hasZoneSelected;
        set
        {
            _hasZoneSelected = value;
            NotifyOfPropertyChange();
        }
    }

    public void Back()
        => Selector.Back();

    protected override void SetWindowPosition(WindowInformation windowInformation)
    {
        var width = 390 * windowInformation.Height / 1440;
        var height = 560 * windowInformation.Height / 1440;
        var rigthMargin = 30 * windowInformation.Height / 1440;
        var topMargin = 400 * windowInformation.Height / 1440;
        Execute.OnUIThread(() =>
        {
            Window.Height = ApplyAbsoluteScalingY(height);
            Window.Width = ApplyAbsoluteScalingX(width);
            Window.Left = ApplyScalingX(windowInformation.Position.Right - width - rigthMargin);
            Window.Top = ApplyScalingY(windowInformation.Position.Top + topMargin);
        });
    }

    public Task HandleAsync(LilithMessage message, CancellationToken cancellationToken)
    {
        IsVisible = !IsVisible;

        return Task.CompletedTask;
    }

    protected override void Dispose(bool isDisposing)
    {
        _eventAggregator.Unsubscribe(this);
        Selector.PropertyChanged -= Selector_PropertyChanged;

        base.Dispose(isDisposing);
    }

    private void Selector_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
        if (e.PropertyName ==  nameof(ZoneSelectorViewModel.CurrentView)) 
        {
            HasZoneSelected = Selector.HasZoneSelected;
        }
    }
}
