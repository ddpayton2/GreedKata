namespace GreedKata
{
    public interface IRuleGroup
    {
        bool Applies(int numberOfDice);
        int Score(int diceValue);
    }

    public class ThreeOfAKind : IRuleGroup
    {
        public bool Applies(int numberOfDice)
        {
            return numberOfDice == 3;
        }

        public int Score(int diceValue)
        {
            return GroupScore.GetScore(diceValue);
        }
    }

    public class FourOfAKind : IRuleGroup
    {
        public bool Applies(int numberOfDice)
        {
            return numberOfDice == 4;
        }

        public int Score(int diceValue)
        {
            return GroupScore.GetScore(diceValue) * 2;
        }
    }

    public class FiveOfAKind : IRuleGroup
    {
        public bool Applies(int numberOfDice)
        {
            return numberOfDice == 5;
        }

        public int Score(int diceValue)
        {
            return GroupScore.GetScore(diceValue) * 4;
        }
    }

    public class SixOfAKind : IRuleGroup
    {
        public bool Applies(int numberOfDice)
        {
            return numberOfDice == 6;
        }

        public int Score(int diceValue)
        {
            return GroupScore.GetScore(diceValue) * 8;
        }
    }

    static class GroupScore
    {
        public static int GetScore(int diceValue)
        {
            switch (diceValue)
            {
                case 1:
                    return 1000;

                default:
                    return diceValue * 100;
            }
        }
    }

}