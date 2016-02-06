using System;

namespace MathExpressionEvaluator.Expressions.Unary.Concrete
{
    internal class Log10UnaryExpression : UnaryExpression
    {
        internal Log10UnaryExpression(Expression expression)
            : base(expression)
        {
        }

        internal override decimal Evaluate()
        {
            return (decimal) Math.Log10((double) Expression.Evaluate());
        }
    }
}