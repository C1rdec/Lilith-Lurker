using System;
using LilithLurker.Models;

namespace LilithLurker.Services;

public class HelltideService
{
    #region Fields

    private static readonly long RecordedHelltide = 1686056400;
    private static readonly long HelltideTime = 3600;
    private static readonly long HelltideCooldown = 4500;

    #endregion

    #region Methods

    public static HelltideStatus GetStatus()
    {
        var difference = DateTimeOffset.Now.ToUnixTimeSeconds() - RecordedHelltide;
        var isActive = false;

        while (difference > 0)
        {
            difference -= HelltideTime;
            isActive = true;
            if (difference > 0)
            {
                difference -= HelltideCooldown;
                isActive = false;
            }
        }

        var state = isActive ? HelltideState.Active : HelltideState.Over;
        var seconds = Math.Abs(difference);
        if (!isActive && seconds <= TimeSpan.FromMinutes(10).TotalSeconds)
        {
            state = HelltideState.Verge;
        }

        return new HelltideStatus
        {
            TimeInSeconds = Math.Abs(difference),
            State = state,
        };
    }

    #endregion
}
