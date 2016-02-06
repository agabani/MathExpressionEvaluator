using System;
using System.Numerics;

namespace MathExpressionEvaluator.Expressions.Unary.Concrete
{
    internal sealed class FactorialUnaryExpression : UnaryExpression
    {
        private static readonly double[] P =
        {
            676.5203681218851,
            -1259.1392167224028,
            771.32342877765313,
            -176.61502916214059,
            12.507343278686905,
            -0.13857109526572012,
            9.9843695780195716e-6,
            1.5056327351493116e-7
        };

        internal FactorialUnaryExpression(Expression expression)
            : base(expression)
        {
        }

        internal override double Evaluate()
        {
            return Gamma((Complex) Expression.Evaluate() + 1).Real;
        }

        private static Complex Gamma(Complex z)
        {
            const double epsilon = 0.0000001;

            Complex result;

            if (z.Real < 0.5)
            {
                result = Math.PI/Complex.Sin(Math.PI*z)*Gamma(1 - z);
            }
            else
            {
                z -= 1;
                var x = (Complex) 0.99999999999980993;

                for (var i = 0; i < P.Length; i++)
                {
                    x += P[i]/(z + i + 1);
                }

                var t = z + P.Length - 0.5;
                result = Math.Sqrt(2*Math.PI)*Complex.Pow(t, z + 0.5)*Complex.Exp(-t)*x;
            }

            if (Math.Abs(z.Imaginary) < epsilon)
            {
                return result.Real;
            }

            return result;
        }
    }
}