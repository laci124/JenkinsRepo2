using Calculator;

namespace CalculatorTest
{
    public class CalcTest
    {

        [Property(3.5, 2.5, 6)]
        public void Test_1_AddingTwoNumber(double a, double b, double result)
        {
            Assert.assertEqual(result, Calc.Add(a, b), "[1]Adding failed.");
        }

        [Property(3.5, 2.5, 1)]
        public void Test_2_SubtractTwoNumber(double a, double b, double result)
        {
            Assert.assertEqual(result, Calc.Subtract(a, b), "[1]Subtract failed.");
        }

        public void Test_3_MultiplyTwoNumber(double a, double b, double result)
        {
            Assert.assertEqual(result, Calc.Multiply(a, b), "[1]Multiply failed.");
        }

        public void Test_1_DevideTwoNumber(double a, double b, double result)
        {
            Assert.assertEqual(result, Calc.Devide(a, b), "[1]Devide failed.");
        }
    }
}
