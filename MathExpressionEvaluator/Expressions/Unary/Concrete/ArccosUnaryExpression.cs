using System;

namespace MathExpressionEvaluator.Expressions.Unary.Concrete
{
    internal class ArccosUnaryExpression : UnaryExpression
    {
        internal ArccosUnaryExpression(Expression expression)
            : base(expression)
        {
        }

        internal override decimal Evaluate()
        {
            return (decimal)Math.Acos((double)Expression.Evaluate());
        }
    }
}