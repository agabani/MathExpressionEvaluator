using System;

namespace MathExpressionEvaluator.Console
{
    internal class Program
    {
        private static void Main()
        {
            while (true)
            {
                try
                {
                    System.Console.Write("Expression: ");
                    System.Console.WriteLine("Evaluation: {0}", new MathExpression(System.Console.ReadLine()).Evaluate());
                }
                catch (Exception exception)
                {
                    System.Console.WriteLine("Exception : {0} : {1}", exception.GetType().FullName, exception.Message);
                }
            }
        }
    }
}