using RockPaperScissorsInjection.Common;

namespace RockPaperScissorsInjection.WebApi.Gameplay
{
    public class CopyOpponentStrategy (RandomStrategy random) : IRpsStrategy
    {
        private Sign? _opponentPreviousThrow;

        public Sign Throw(Sign opponentThrow)
        {
            var result = _opponentPreviousThrow ?? random.Throw(opponentThrow);

            _opponentPreviousThrow = opponentThrow;

            return result;
        }
    }
}
