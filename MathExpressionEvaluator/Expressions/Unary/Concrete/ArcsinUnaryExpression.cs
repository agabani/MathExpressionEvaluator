using System;

namespace MathExpressionEvaluator.Expressions.Unary.Concrete
{
    internal class ArcsinUnaryExpression : UnaryExpression
    {
        internal ArcsinUnaryExpression(Expression expression)
            : base(expression)
        {
        }

        internal override decimal Evaluate()
        {
            return (decimal) Math.Asin((double) Expression.Evaluate());
        }
    }
}