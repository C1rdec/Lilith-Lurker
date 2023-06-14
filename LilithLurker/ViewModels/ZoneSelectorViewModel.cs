using Caliburn.Micro;
using LilithLurker.Models;

namespace LilithLurker.ViewModels;

public class ZoneSelectorViewModel : PropertyChangedBase
{
    private PropertyChangedBase _currentView;

    public ZoneSelectorViewModel()
    {
    }

    public PropertyChangedBase CurrentView
    {
        get => _currentView;
        set
        {
            _currentView = value;
            NotifyOfPropertyChange();
            NotifyOfPropertyChange(() => HasZoneSelected);
            NotifyOfPropertyChange(() => HasNoZoneSelected);
        }
    }

    public bool HasZoneSelected => CurrentView != null;

    public bool HasNoZoneSelected => !HasZoneSelected;

    public void Back()
    {
        CurrentView = null;
    }

    public void DrySteppes()
    {
        CurrentView = new ZoneViewModel(ZoneType.DrySteppes);
    }

    public void FracturedPeaks()
    {
        CurrentView = new ZoneViewModel(ZoneType.FracturedPeaks);
    }

    public void Scosglen()
    {
        CurrentView = new ZoneViewModel(ZoneType.Scosglen);
    }

    public void Hawezar()
    {
        CurrentView = new ZoneViewModel(ZoneType.Hawezar);
    }

    public void Kehjistan()
    {
        CurrentView = new ZoneViewModel(ZoneType.Kehjistan);
    }
}
