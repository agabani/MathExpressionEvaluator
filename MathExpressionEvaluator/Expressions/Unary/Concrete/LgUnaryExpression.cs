using System;

namespace MathExpressionEvaluator.Expressions.Unary.Concrete
{
    internal class LgUnaryExpression : UnaryExpression
    {
        internal LgUnaryExpression(Expression expression)
            : base(expression)
        {
        }

        internal override decimal Evaluate()
        {
            return (decimal) Math.Log((double) Expression.Evaluate(), 2);
        }
    }
}