namespace GreedKata
{
    public interface IRuleSingleDice
    {
        bool Applies(int diceValue);
        int Score(int numberOfSingles);
    }

    public class ScoreSingleOnes : IRuleSingleDice
    {
        public bool Applies(int diceValue)
        {
            return diceValue == 1;
        }

        public int Score(int numberOfSingles)
        {
            return numberOfSingles * 100;
        }
    }

    public class ScoreSingleFives : IRuleSingleDice
    {
        public bool Applies(int diceValue)
        {
            return diceValue == 5;
        }

        public int Score(int numberOfSingles)
        {
            return numberOfSingles * 50;
        }
    }
}