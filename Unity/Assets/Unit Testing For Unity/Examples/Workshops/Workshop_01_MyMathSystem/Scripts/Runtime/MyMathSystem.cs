
namespace RMC.UnitTesting.Examples.MyMathSystem
{
    /// <summary>
    /// This performs common math operations on
    /// operands of a and b.
    /// </summary>
    public class MyMathSystem
    {
        public int Add (int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Divide(int a, int b)
        {
            if (b == 0) return a;
            
            return a / b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }
    }
}