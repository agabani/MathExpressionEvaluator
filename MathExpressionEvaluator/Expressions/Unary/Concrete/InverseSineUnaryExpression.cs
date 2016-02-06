using System;

namespace MathExpressionEvaluator.Expressions.Unary.Concrete
{
    internal sealed class InverseSineUnaryExpression : UnaryExpression
    {
        internal InverseSineUnaryExpression(Expression expression)
            : base(expression)
        {
        }

        internal override double Evaluate()
        {
            return Math.Asin(Expression.Evaluate());
        }
    }
}