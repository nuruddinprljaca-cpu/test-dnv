namespace MoreCodeScenePOC.Samples
{
    /// <summary>
    /// A class containing methods that will trigger the Complex Method and Bumpy Road Ahead code smells.
    /// </summary>
    public static class MoreComplexSamples
    {
        /// <summary>
        /// A complex function that will trigger the Complex Method and Bumpy Road Ahead code smells.
        /// </summary>
        public static void SomeComplexFunction()
        {
            var a = 0;
            var b = 0;

            if (a >= 0)
            {
                switch (a)
                {

                    case 0:
                        a += 1;
                        break;
                    case 1:
                        a += 2;
                        break;
                    case 2:
                        a += 3;
                        break;
                    case 3:
                        a += 4;
                        break;
                    case 4:
                        a += 5;
                        break;
                    case 5:
                        a += 6;
                        break;
                    case 6:
                        a += 7;
                        break;
                    case 7:
                        a += 8;
                        break;
                    case 8:
                        a += 2;
                        break;
                    case 9:
                        a += 8;
                        break;
                    default:
                        a = 0;
                        break;
                }
            }
            else
            {
                switch (b)
                {

                    case 0:
                        b += 1;
                        break;
                    case 1:
                        b += 2;
                        break;
                    case 2:
                        b += 3;
                        break;
                    case 3:
                        b += 4;
                        break;
                    case 4:
                        b += 5;
                        break;
                    case 5:
                        b += 6;
                        break;
                    case 6:
                        b += 7;
                        break;
                    case 7:
                        b += 8;
                        break;
                    case 8:
                        b += 2;
                        break;
                    case 9:
                        b += 8;
                        break;
                    default:
                        b = 0;
                        break;
                }
            }
        }

        /// <summary>
        /// A complex function that will NOT trigger the Complex Method and Bumpy Road Ahead code smells.
        /// </summary>
        /// @codescene(disable:"Complex Method", disable:"Bumpy Road Ahead", disable:"Large Method") - Disabled due to some reason
        public static void SomeComplexFunctionDisabled()
        {
            var a = 0;
            var b = 0;

            if (a >= 0)
            {
                switch (a)
                {

                    case 0:
                        a += 1;
                        break;
                    case 1:
                        a += 2;
                        break;
                    case 2:
                        a += 3;
                        break;
                    case 3:
                        a += 4;
                        break;
                    case 4:
                        a += 5;
                        break;
                    case 5:
                        a += 6;
                        break;
                    case 6:
                        a += 7;
                        break;
                    case 7:
                        a += 8;
                        break;
                    case 8:
                        a += 2;
                        break;
                    case 9:
                        a += 8;
                        break;
                    default:
                        a = 0;
                        break;
                }
            }
            else
            {
                switch (b)
                {

                    case 0:
                        b+= 1;
                        break;
                    case 1:
                        b += 2;
                        break;
                    case 2:
                        b += 3;
                        break;
                    case 3:
                        b += 4;
                        break;
                    case 4:
                        b += 5;
                        break;
                    case 5:
                        b += 6;
                        break;
                    case 6:
                        b += 7;
                        break;
                    case 7:
                        b += 8;
                        break;
                    case 8:
                        b += 2;
                        break;
                    case 9:
                        b += 8;
                        break;
                    default:
                        b = 0;
                        break;
                }
            }
        }
    }
}
