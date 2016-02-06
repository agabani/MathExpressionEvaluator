using System;

namespace MathExpressionEvaluator.Expressions.Unary.Concrete
{
    internal sealed class Log2UnaryExpression : UnaryExpression
    {
        internal Log2UnaryExpression(Expression expression)
            : base(expression)
        {
        }

        internal override double Evaluate()
        {
            return Math.Log(Expression.Evaluate(), 2);
        }
    }
}