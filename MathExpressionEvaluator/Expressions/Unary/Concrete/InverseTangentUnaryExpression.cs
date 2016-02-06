using System;

namespace MathExpressionEvaluator.Expressions.Unary.Concrete
{
    internal sealed class InverseTangentUnaryExpression : UnaryExpression
    {
        internal InverseTangentUnaryExpression(Expression expression)
            : base(expression)
        {
        }

        internal override double Evaluate()
        {
            return Math.Atan(Expression.Evaluate());
        }
    }
}