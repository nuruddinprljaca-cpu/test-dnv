namespace CodeScenePOC
{
    public static class HealthFactorsDisabled
    {
        // Need to disable in code-health-rules.json
        public static void TooManyArgumentsFunction(
            int a, int b, int c, int d, int e, int f, int g)
        {
        }

        // @codescene(disable:"Bumpy Road") - Disabled due to some reason
        public static void SomeBumpyRoadFunction()
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

        // @codescene(disable:"Complex Method") - Disabled due to some reason
        public static void SomeComplexFunction()
        {
            var a = 0;

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
                        a =0;
                        break;
                }
            }
            else
            {
                a = 0;
            }
        }

        public static void SomeDuplicateFunction1(int a)
        {
            if (a % 2 == 0)
            {
                a += a;
            }
            else
            {
                a -= a;
            }
        }

        public static void SomeDuplicateFunction2(int a)
        {
            if (a % 2 == 0)
            {
                a += a;
            }
            else
            {
                a -= a;
            }
        }

        public static void SomeDuplicateFunction3(int a)
        {
            if (a % 2 == 0)
            {
                a += a;
            }
            else
            {
                a -= a;
            }
        }


        public static void SomeDuplicateFunction4(int a)
        {
            if (a % 2 == 0)
            {
                a += a;
            }
            else
            {
                a -= a;
            }
        }
    }
}
