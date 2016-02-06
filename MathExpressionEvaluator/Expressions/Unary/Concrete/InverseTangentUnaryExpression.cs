using System;

namespace MathExpressionEvaluator.Expressions.Unary.Concrete
{
    internal class InverseTangentUnaryExpression : UnaryExpression
    {
        internal InverseTangentUnaryExpression(Expression expression)
            : base(expression)
        {
        }

        internal override decimal Evaluate()
        {
            return (decimal) Math.Atan((double) Expression.Evaluate());
        }
    }
}