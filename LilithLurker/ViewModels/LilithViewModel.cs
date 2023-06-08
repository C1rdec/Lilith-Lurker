using System.Windows;
using Caliburn.Micro;
using LilithLurker.Helpers;
using LilithLurker.Models;

namespace LilithLurker.ViewModels;

public class LilithViewModel : ScreenViewModelBase
{
    private IEventAggregator _eventAggregator;

    public LilithViewModel(DockingHelper helper, IEventAggregator eventAggregator)
        : base(helper)
    {
        _eventAggregator = eventAggregator;

        IsVisible = true;
    }

    public void OnClick()
    {
        _eventAggregator.PublishOnCurrentThreadAsync(new LilithMessage());
    }

    protected override void SetWindowPosition(WindowInformation windowInformation)
    {
        var width = 50 * windowInformation.Height / 1440;
        var height = 50 * windowInformation.Height / 1440;
        var rigthMargin = 30 * windowInformation.Height / 1440;
        var topMargin = 300 * windowInformation.Height / 1440;
        Execute.OnUIThread(() =>
        {
            Window.Height = ApplyAbsoluteScalingY(height);
            Window.Width = ApplyAbsoluteScalingX(width);
            Window.Left = ApplyScalingX(windowInformation.Position.Right - width - rigthMargin);
            Window.Top = ApplyScalingY(windowInformation.Position.Top + topMargin);
        });
    }
}
