using System;

namespace MathExpressionEvaluator.Expressions.Unary.Concrete
{
    internal class SinUnaryExpression : UnaryExpression
    {
        internal SinUnaryExpression(Expression expression)
            : base(expression)
        {
        }

        internal override decimal Evaluate()
        {
            return (decimal) Math.Sin((double) Expression.Evaluate());
        }
    }
}