using System.Linq;
using Caliburn.Micro;
using LilithLurker.Models;
using LilithLurker.Services;

namespace LilithLurker.ViewModels;

public class ZoneSelectorViewModel : PropertyChangedBase
{
    private PropertyChangedBase _currentView;
    private ProgressionService _progressService;

    public ZoneSelectorViewModel()
    {
        _progressService = new ProgressionService();
        _progressService.Initialize();

        _progressService.OnFileSaved += ProgressService_OnFileSaved;
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

    public string DrySteppesCompletion => GetCompletion(ZoneType.DrySteppes);

    public string FracturedPeaksCompletion => GetCompletion(ZoneType.FracturedPeaks);

    public string ScosglenCompletion => GetCompletion(ZoneType.Scosglen);

    public string HawezarCompletion => GetCompletion(ZoneType.Hawezar);

    public string KehjistanCompletion => GetCompletion(ZoneType.Kehjistan);


    public void Back()
    {
        CurrentView = null;
    }

    public void DrySteppes()
    {
        CurrentView = new ZoneViewModel(ZoneType.DrySteppes, _progressService);
    }

    public void FracturedPeaks()
    {
        CurrentView = new ZoneViewModel(ZoneType.FracturedPeaks, _progressService);
    }

    public void Scosglen()
    {
        CurrentView = new ZoneViewModel(ZoneType.Scosglen, _progressService);
    }

    public void Hawezar()
    {
        CurrentView = new ZoneViewModel(ZoneType.Hawezar, _progressService);
    }

    public void Kehjistan()
    {
        CurrentView = new ZoneViewModel(ZoneType.Kehjistan, _progressService);
    }

    private string GetCompletion(ZoneType zone)
    {
        var statues = _progressService.GetStatues(zone);

        return $"{statues.Where(s => s.Acquired).Count()}/{statues.Count}";
    }

    private void ProgressService_OnFileSaved(object sender, StatueProgression e)
    {
        NotifyOfPropertyChange(() => DrySteppesCompletion);
        NotifyOfPropertyChange(() => FracturedPeaksCompletion);
        NotifyOfPropertyChange(() => ScosglenCompletion);
        NotifyOfPropertyChange(() => HawezarCompletion);
        NotifyOfPropertyChange(() => KehjistanCompletion);
    }
}
