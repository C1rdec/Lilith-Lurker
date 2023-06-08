using System;
using System.Windows;
using Caliburn.Micro;
using LilithLurker.Helpers;
using LilithLurker.Models;

namespace LilithLurker.ViewModels;

public class OverlayViewModel : Screen, IDisposable, IViewAware
{
    private Window _window;
    private DockingHelper _dockingHelper;
    private double _scaleX = 1;
    private double _scaleY = 1;

    public OverlayViewModel(DockingHelper helper)
    {
        _dockingHelper = helper;
        helper.OnForegroundChange += Helper_OnForegroundChange;
        helper.OnWindowMove += Helper_OnWindowMove;
        Selector = new ZoneSelectorViewModel();
    }

    public ZoneSelectorViewModel Selector { get; set; }

    private void Helper_OnWindowMove(object sender, WindowInformation e)
    {
        SetWindowPosition(e);
    }

    public void Dispose()
    {
        _dockingHelper.OnForegroundChange -= Helper_OnForegroundChange;
        _dockingHelper.OnWindowMove -= Helper_OnWindowMove;
    }

    private void Helper_OnForegroundChange(object sender, bool e)
    {
        
    }

    protected override void OnViewLoaded(object view)
    {
        _window = view as Window;
        _window.ShowActivated = false;

        var source = PresentationSource.FromVisual(_window);
        if (source != null)
        {
            _scaleX = source.CompositionTarget.TransformToDevice.M11;
            _scaleY = source.CompositionTarget.TransformToDevice.M22;
        }

        SetWindowPosition(_dockingHelper.WindowInformation);
    }

    private void SetWindowPosition(WindowInformation windowInformation)
    {
        var width = 390 * windowInformation.Height / 1440;
        var height = 560 * windowInformation.Height / 1440;
        var rigthMargin = 30 * windowInformation.Height / 1440;
        var topMargin = 380 * windowInformation.Height / 1440;
        Execute.OnUIThread(() =>
        {
            _window.Height = ApplyAbsoluteScalingY(height);
            _window.Width = ApplyAbsoluteScalingX(width);
            _window.Left = ApplyScalingX(windowInformation.Position.Right - width - rigthMargin);
            _window.Top = ApplyScalingY(windowInformation.Position.Top + topMargin);
        });
    }

    private static double Scale(double value, double scale, bool absolute)
    {
        var current = absolute ? Math.Abs(value) : value;

        return current / scale;
    }

    private double ApplyAbsoluteScalingY(double value)
    {
        return Scale(value, _scaleY, true);
    }

    private double ApplyScalingY(double value)
    {
        return Scale(value, _scaleY, false);
    }

    private double ApplyAbsoluteScalingX(double value)
    {
        return Scale(value, this._scaleX, true);
    }

    private double ApplyScalingX(double value)
    {
        return Scale(value, this._scaleX, false);
    }
}
