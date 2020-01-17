using System.Collections.Generic;
using System.Linq;

namespace GreedKata
{
    public class Greed
    {
        private readonly List<IRuleSingleDice> _singleDiceRules;
        private readonly List<IRuleGroup> _groupDiceRules;
        private readonly List<IRuleSixDice> _sixDiceRules;

        public Greed()
        {
            _singleDiceRules = new List<IRuleSingleDice>
            {
                new ScoreSingleFives(),
                new ScoreSingleOnes()
            };

            _groupDiceRules = new List<IRuleGroup>
            {
                new ThreeOfAKind(),
                new FourOfAKind(),
                new FiveOfAKind(),
                new SixOfAKind()
            };

            _sixDiceRules = new List<IRuleSixDice>
            {
                new Straight(),
                new ThreePairs()
            };
        }

        public int Score(List<int> diceList)
        {
            var score = 0;
            var diceDictionary = diceList.GroupBy(i => i).ToDictionary(i => i.Key, i => i.Count());

            foreach (var rule in _sixDiceRules)
            {
                if (rule.Applies(diceDictionary)) 
                { 
                    return rule.Score();
                }
            }
            
            foreach (var die in diceDictionary.Where(d => d.Value >= 3)) 
            { 
                foreach (var rule in _groupDiceRules) 
                { 
                    if (rule.Applies(die.Value)) 
                    {
                            score += rule.Score(die.Key);
                    }
                }
            }

            foreach (var die in diceDictionary.Where(d => d.Value < 3))
            {
                foreach (var rule in _singleDiceRules)
                {
                    if (rule.Applies(die.Key))
                    {
                        score += rule.Score(die.Value);
                    }
                }
            }
            return score;
        }
    }
}
