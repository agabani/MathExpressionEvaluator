using System;

namespace MathExpressionEvaluator.Expressions.Value
{
    internal sealed class NaturalExpression : Expression
    {
        internal override double Evaluate()
        {
            return Math.E;
        }
    }
}