using System;

namespace MathExpressionEvaluator.Expressions.Unary.Concrete
{
    internal class LnUnaryExpression : UnaryExpression
    {
        internal LnUnaryExpression(Expression expression)
            : base(expression)
        {
        }

        internal override decimal Evaluate()
        {
            return (decimal) Math.Log((double) Expression.Evaluate(), Math.E);
        }
    }
}