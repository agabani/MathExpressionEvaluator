using System;

namespace MathExpressionEvaluator.Expressions.Unary.Concrete
{
    internal sealed class InverseCosineUnaryExpression : UnaryExpression
    {
        internal InverseCosineUnaryExpression(Expression expression)
            : base(expression)
        {
        }

        internal override double Evaluate()
        {
            return Math.Acos(Expression.Evaluate());
        }
    }
}