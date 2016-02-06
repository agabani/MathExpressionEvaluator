using System;

namespace MathExpressionEvaluator.Expressions.Unary.Concrete
{
    internal class LogUnaryExpression : UnaryExpression
    {
        internal LogUnaryExpression(Expression expression)
            : base(expression)
        {
        }

        internal override decimal Evaluate()
        {
            return (decimal) Math.Log10((double) Expression.Evaluate());
        }
    }
}