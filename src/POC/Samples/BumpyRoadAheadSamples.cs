namespace CodeScenePOC.Samples
{
    /// <summary>
    /// A class containing methods that will trigger the Bumpy Road Ahead code smell.
    /// </summary>
    public static class BumpyRoadAheadSamples
    {
        /// <summary>
        /// A bumpy road ahead function that will trigger the Bumpy Road Ahead code smells.
        /// </summary>
        public static void SomeBumpyRoadAheadFunction()
        {
            var a = 0;
            for (var b = 0; b < 10; b++)
            {
                if (b % 2 == 0)
                {
                    a += b;
                }
                else
                {
                    a -= b;
                }
                for (var c = 0; c < 5; c++)
                {
                    if (c == 3)
                    {
                        a *= 2;
                    }
                    else
                    {
                        a /= 2;
                    }
                }
            }
        }

        /// <summary>
        /// A bumpy road ahead function that will NOT trigger the Bumpy Road Ahead code smells.
        /// </summary>
        public static void DisabledSomeBumpyRoadAheadFunction()
        {
            var a = 0;
            for (var b = 0; b < 10; b++)
            {
                if (b % 2 == 0)
                {
                    a += b;
                }
                else
                {
                    a -= b;
                }
                for (var c = 0; c < 5; c++)
                {
                    if (c == 3)
                    {
                        a *= 2;
                    }
                    else
                    {
                        a /= 2;
                    }
                }
            }
        }
    }
}
