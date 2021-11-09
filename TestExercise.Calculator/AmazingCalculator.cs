using TestExercise.Calculator.Cloud;
using TestExercise.Calculator.Services;

namespace TestExercise.Calculator
{
    public class AmazingCalculator: IAmazingCalculator
    {
        private readonly ICloudService _cloudService;
        public AmazingCalculator(ICloudService cloudService)
        {
            _cloudService = cloudService;
        }

        public AmazingCalculator()
        {
            _cloudService = new CloudService();
        }

        public int MultiplyMe(int a, int b, bool cloudBasedCalc)
        {

            var retVal = 0;

            if (a == 0 || b == 0)
            {
                return retVal;
            }

            if (cloudBasedCalc)
            {
                return MultiplyInTheCloud(a, b);
            }

            if (a == 1)
            {
                return b;
            }
            else if (b == 1)
            {
                return a;
            }
            if (a < 0 && b > 0)
            {
                for (int count = 0; count < b; count++)
                {
                    retVal += a;
                }
            }
            else if (a > 0 && b < 0)
            {
                for (int count = 0; count < a; count++)
                {
                    retVal += b;
                }
            }
            else if (a < 0 && b < 0)
            {
                for (int count = 0; count < System.Math.Abs(a); count++)
                {
                    retVal += System.Math.Abs(b);
                }
            }
            else
            {
                for (int count = 0; count < a; count++)
                {
                    retVal += b;
                }
            }

            return retVal;
        }

        // Multiplies two numbers using a remote service
        private int MultiplyInTheCloud(int a, int b)
        {
            int retVal = _cloudService.RunCloudBasedMultiplication(a, b);
            return retVal;
        }
    }

}
