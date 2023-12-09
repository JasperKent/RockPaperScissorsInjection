using RockPaperScissorsInjection.Common;

namespace RockPaperScissorsInjection.WebApi.Gameplay
{
    public interface IRpsStrategy
    {
        Sign Throw(Sign? opponentPreviousThrow);
    }
}
