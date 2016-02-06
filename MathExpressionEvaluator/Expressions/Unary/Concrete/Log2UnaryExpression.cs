using System;

namespace MathExpressionEvaluator.Expressions.Unary.Concrete
{
    internal class Log2UnaryExpression : UnaryExpression
    {
        internal Log2UnaryExpression(Expression expression)
            : base(expression)
        {
        }

        internal override decimal Evaluate()
        {
            return (decimal) Math.Log((double) Expression.Evaluate(), 2);
        }
    }
}