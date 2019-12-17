namespace AdventOfCode
{
    public static class Day4Task2
    {
        public static int Solve()
        {
            var count = 0;
            for (int i = 134564; i < 585159; i++)
            {
                if (IsProper(i))
                {
                    count++;
                }
            }

            return count;
        }

        public static bool IsProper(int value)
        {
            var stringVal = value.ToString();
            var matrix = new int[stringVal.Length];

            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = 1;
            }
            for (int i = 1; i < stringVal.Length; i++)
            {
                if (stringVal[i - 1] > stringVal[i])
                    return false;
            }

            for (int i = 1; i < stringVal.Length; i++)
            {
                if (stringVal[i-1] == stringVal[i])
                {
                    matrix[i] += matrix[i - 1];
                }
            }

            for (int i = 1; i < matrix.Length; i++)
            {
                if (matrix[i] == 1 && matrix[i-1] == 2)
                {
                    return true;
                }
            }

            if (matrix[matrix.Length-1] == 2)
            {
                return true;
            }

            return false;

        }
    }
}