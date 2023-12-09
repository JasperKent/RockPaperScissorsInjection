using RockPaperScissorsInjection.Common;

namespace RockPaperScissorsInjection.WebApi.Gameplay
{
    public class RandomStrategy : IRpsStrategy
    {
        public Sign Throw(Sign? opponentPreviousThrow) 
        {
            return (Sign)Random.Shared.Next(3);
        }
    }
}
