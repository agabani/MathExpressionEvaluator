using System;

namespace MathExpressionEvaluator.Expressions.Value
{
    internal sealed class PiExpression : Expression
    {
        internal override decimal Evaluate()
        {
            return (decimal) Math.PI;
        }
    }
}