namespace ChallengesWithTestsMark8
{
    public class ChallengesSet01Base
    {

        public int GetSmallestNumber(int number1, int number2)
        {
            int lowestValue = 100;
            if (number1 < lowestValue)
            {
                lowestValue = number1;
            }
            if (number2 < lowestValue)
            {
                lowestValue = number2;
            }
        }
    }
}