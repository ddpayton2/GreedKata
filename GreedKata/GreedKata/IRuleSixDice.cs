using System.Collections.Generic;
using System.Linq;

namespace GreedKata
{
    public interface IRuleSixDice
    {
        bool Applies(Dictionary<int,int> diceRolls);
        int Score();
    }

    public class Straight : IRuleSixDice
    {
        public bool Applies(Dictionary<int, int> diceRolls)
        {
            return diceRolls.Keys.Count == 6;
        }

        public int Score()
        {
            return 1200;
        }
    }

    public class ThreePairs : IRuleSixDice
    {
        public bool Applies(Dictionary<int, int> diceRolls)
        {
            return diceRolls.Count(x => x.Value == 2) == 3;
        }

        public int Score()
        {
            return 800;
        }
    }
}