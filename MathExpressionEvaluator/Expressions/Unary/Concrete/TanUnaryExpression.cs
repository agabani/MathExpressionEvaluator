using System;

namespace MathExpressionEvaluator.Expressions.Unary.Concrete
{
    internal class TanUnaryExpression : UnaryExpression
    {
        internal TanUnaryExpression(Expression expression)
            : base(expression)
        {
        }

        internal override decimal Evaluate()
        {
            return (decimal)Math.Tan((double)Expression.Evaluate());
        }
    }
}