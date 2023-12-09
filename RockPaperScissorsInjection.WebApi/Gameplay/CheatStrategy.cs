using RockPaperScissorsInjection.Common;

namespace RockPaperScissorsInjection.WebApi.Gameplay
{
    public class CheatStrategy : IRpsStrategy
    {
        public Sign Throw(Sign opponentThrow)
        {
            return (Sign)(((int)opponentThrow + 1) % 3);
        }
    }
}
