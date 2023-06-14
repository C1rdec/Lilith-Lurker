using Caliburn.Micro;
using LilithLurker.Models;
using LilithLurker.Services;

namespace LilithLurker.ViewModels;

public class StatueViewModel : PropertyChangedBase
{
    private LilithStatue _statue;
    private ProgressionService _progressionService;

    public StatueViewModel(LilithStatue statue, ProgressionService service)
    {
        _statue = statue;
        _progressionService = service;
    }

    public Position Position => _statue.Position;

    public double Border => _statue.Acquired ? 0 : 0.7;

    public void OnClick()
    {
        _statue.Acquired = !_statue.Acquired;
        _progressionService.Save(true);

        NotifyOfPropertyChange(() => Border);
    }
}
