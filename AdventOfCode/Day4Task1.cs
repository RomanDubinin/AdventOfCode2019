namespace AdventOfCode
{
    public static class Day4Task1
    {
        public static int Solve()
        {
            var count = 0;
            for (int i = 134564; i < 585159; i++)
            {
                if (IsProper(i))
                    count++;
            }

            return count;
        }

        private static bool IsProper(int value)
        {
            var stringVal = value.ToString();

            for (int i = 1; i < stringVal.Length; i++)
            {
                if (stringVal[i - 1] > stringVal[i])
                    return false;
            }

            for (int i = 1; i < stringVal.Length; i++)
            {
                if (stringVal[i - 1] == stringVal[i])
                    return true;
            }

            return false;
        }
    }
}