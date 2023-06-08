using System;
using System.Windows;
using Caliburn.Micro;
using LilithLurker.Helpers;
using LilithLurker.Models;

namespace LilithLurker.ViewModels;

public abstract class ScreenViewModelBase : Screen, IViewAware, IDisposable
{
    private DockingHelper _dockingHelper;
    private double _scaleX = 1;
    private double _scaleY = 1;
    private bool _isVisible;

    public ScreenViewModelBase(DockingHelper dockingHelper)
    {
        _dockingHelper = dockingHelper;
        _dockingHelper.OnForegroundChange += Helper_OnForegroundChange;
        _dockingHelper.OnWindowMove += Helper_OnWindowMove;
    }

    protected Window Window { get; private set; }

    public bool IsVisible 
    { 
        get => _isVisible;
        set
        {
            _isVisible = value;
            NotifyOfPropertyChange();
        }
    }
    public void Dispose()
    {
        Dispose(true);
    }

    protected virtual void Dispose(bool isDisposing)
    {
        if (isDisposing) 
        {
            _dockingHelper.OnForegroundChange -= Helper_OnForegroundChange;
            _dockingHelper.OnWindowMove -= Helper_OnWindowMove;
        }
    }

    protected abstract void SetWindowPosition(WindowInformation windowInformation);

    protected override void OnViewLoaded(object view)
    {
        Window = view as Window;
        Window.ShowActivated = false;

        var source = PresentationSource.FromVisual(Window);
        if (source != null)
        {
            _scaleX = source.CompositionTarget.TransformToDevice.M11;
            _scaleY = source.CompositionTarget.TransformToDevice.M22;
        }

        SetWindowPosition(_dockingHelper.WindowInformation);
    }

    protected double ApplyAbsoluteScalingY(double value)
    {
        return Scale(value, _scaleY, true);
    }

    protected double ApplyScalingY(double value)
    {
        return Scale(value, _scaleY, false);
    }

    protected double ApplyAbsoluteScalingX(double value)
    {
        return Scale(value, this._scaleX, true);
    }

    protected double ApplyScalingX(double value)
    {
        return Scale(value, this._scaleX, false);
    }

    private static double Scale(double value, double scale, bool absolute)
    {
        var current = absolute ? Math.Abs(value) : value;

        return current / scale;
    }

    private void Helper_OnWindowMove(object sender, WindowInformation e)
    {
        SetWindowPosition(e);
    }

    private void Helper_OnForegroundChange(object sender, bool e)
    {
    }
}
