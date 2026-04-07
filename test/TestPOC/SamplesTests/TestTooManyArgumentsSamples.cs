namespace TestCodeScenePOC.SamplesTests
{
    public static class TestTooManyArgumentsSamples
    {
        public static void TooManyArgumentsFunction(
            int a, int b, int c, int d, int e, int f, int g)
        {
        }

        // @codescene(disable:"Excess Number of Function Arguments") - Disabled due to okay because it previusly had 6.
        public static void TooManyArgumentsFunction2(
            int a, int b, int c, int d, int e, int f, int g)
        {
        }
    }
}
