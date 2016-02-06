using System;

namespace MathExpressionEvaluator.Expressions.Unary.Concrete
{
    internal sealed class InverseSineUnaryExpression : UnaryExpression
    {
        internal InverseSineUnaryExpression(Expression expression)
            : base(expression)
        {
        }

        internal override decimal Evaluate()
        {
            return (decimal) Math.Asin((double) Expression.Evaluate());
        }
    }
}