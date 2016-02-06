using System;

namespace MathExpressionEvaluator.Expressions.Value
{
    internal sealed class PiExpression : Expression
    {
        internal override double Evaluate()
        {
            return Math.PI;
        }
    }
}