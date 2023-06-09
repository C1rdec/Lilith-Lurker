using System;

namespace LilithLurker.Models;

public class HelltideStatus
{
    public long TimeInSeconds { get; set; }

    public HelltideState State { get; set; }

    public string GetDisplay()
    {
        var t = TimeSpan.FromSeconds(TimeInSeconds);

        return string.Format("{0:D2}h:{1:D2}m:{2:D2}s", t.Hours, t.Minutes, t.Seconds);
    }
}
