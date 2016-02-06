using System;

namespace MathExpressionEvaluator.Expressions.Value
{
    internal sealed class EExpression : Expression
    {
        internal override decimal Evaluate()
        {
            return (decimal) Math.E;
        }
    }
}