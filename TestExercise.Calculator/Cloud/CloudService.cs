using System.Diagnostics.CodeAnalysis;
using TestExercise.Calculator.Services;

namespace TestExercise.Calculator.Cloud
{
    [ExcludeFromCodeCoverage]
    public class CloudService: ICloudService
    {
        public int RunCloudBasedMultiplication(int a, int b)
        {

            int result = a * b;
            return result;
        }
    }

}
