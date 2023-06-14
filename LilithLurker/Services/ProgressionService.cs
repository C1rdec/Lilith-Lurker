using System.Collections;
using System.Collections.Generic;
using LilithLurker.Models;
using Lurker.AppData;

namespace LilithLurker.Services;

public class ProgressionService : AppDataFileBase<StatueProgression>
{
    protected override string FileName => "Statues.json";

    protected override string FolderName => "LilithLurker";

    public List<LilithStatue> GetStatues(ZoneType zone) => zone switch
    {
        ZoneType.FracturedPeaks => Entity.FracturePeaks,
        ZoneType.DrySteppes => Entity.DrySteppes,
        ZoneType.Hawezar => Entity.Hawezar,
        ZoneType.Kehjistan => Entity.Kehjistan,
        ZoneType.Scosglen => Entity.Scosglen,
        _ => throw new System.NotImplementedException(),
    };
}
