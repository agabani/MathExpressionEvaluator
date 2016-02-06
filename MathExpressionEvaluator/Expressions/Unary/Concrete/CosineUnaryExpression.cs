using System;

namespace MathExpressionEvaluator.Expressions.Unary.Concrete
{
    internal sealed class CosineUnaryExpression : UnaryExpression
    {
        internal CosineUnaryExpression(Expression expression)
            : base(expression)
        {
        }

        internal override double Evaluate()
        {
            return Math.Cos(Expression.Evaluate());
        }
    }
}