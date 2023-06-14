using System.Collections.Generic;
using Caliburn.Micro;
using LilithLurker.Models;
using LilithLurker.Services;

namespace LilithLurker.ViewModels;

public class ZoneViewModel : PropertyChangedBase
{
    private ZoneType _zone;
    private ProgressionService _service;

    public ZoneViewModel(ZoneType zone, ProgressionService service)
    {
        _zone = zone;
        _service = service;

        Statues = new List<StatueViewModel>();

        foreach (var statue in _service.GetStatues(zone))
        {
            Statues.Add(new StatueViewModel(statue, _service));
        }
    }

    public string Source => $"/Resources/{_zone}.jpg";

    public List<StatueViewModel> Statues { get; set; }
}
