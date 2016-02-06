using System;

namespace MathExpressionEvaluator.Expressions.Unary.Concrete
{
    internal sealed class SineUnaryExpression : UnaryExpression
    {
        internal SineUnaryExpression(Expression expression)
            : base(expression)
        {
        }

        internal override double Evaluate()
        {
            return Math.Sin(Expression.Evaluate());
        }
    }
}