using System;

namespace MathExpressionEvaluator.Expressions.Value
{
    internal sealed class NaturalExpression : Expression
    {
        internal override decimal Evaluate()
        {
            return (decimal) Math.E;
        }
    }
}