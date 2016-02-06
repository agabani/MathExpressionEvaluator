using System;

namespace MathExpressionEvaluator.Expressions.Unary.Concrete
{
    internal sealed class SineUnaryExpression : UnaryExpression
    {
        internal SineUnaryExpression(Expression expression)
            : base(expression)
        {
        }

        internal override decimal Evaluate()
        {
            return (decimal) Math.Sin((double) Expression.Evaluate());
        }
    }
}