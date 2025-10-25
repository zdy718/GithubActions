namespace MathLib
{
    public static class PowerOps
    {
        // computes base^exp for non-negative integer exp
        public static int Power(int @base, int exp)
        {
            if (exp < 0) throw new System.ArgumentOutOfRangeException(nameof(exp));
            int result = 1;
            for (int i = 0; i < exp; i++)
                result *= @base;
            return result;
        }
    }
}

