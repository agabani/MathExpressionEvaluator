using System;

namespace MathExpressionEvaluator.Expressions.Unary.Concrete
{
    internal sealed class Log10UnaryExpression : UnaryExpression
    {
        internal Log10UnaryExpression(Expression expression)
            : base(expression)
        {
        }

        internal override double Evaluate()
        {
            return Math.Log10(Expression.Evaluate());
        }
    }
}