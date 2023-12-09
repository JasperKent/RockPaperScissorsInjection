using RockPaperScissorsInjection.Common;

namespace RockPaperScissorsInjection.WebApi.Gameplay
{
    public class CopyOpponentStrategy (RandomStrategy random) : IRpsStrategy
    {
        private Sign? _opponentPreviousThrow;

        public Sign Throw(Sign? opponentPreviousThrow)
        {
            var result = _opponentPreviousThrow ?? random.Throw(null);

            _opponentPreviousThrow = opponentPreviousThrow;

            return result;
        }
    }
}
