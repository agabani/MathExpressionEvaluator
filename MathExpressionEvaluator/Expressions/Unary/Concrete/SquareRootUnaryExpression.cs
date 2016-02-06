using System;

namespace MathExpressionEvaluator.Expressions.Unary.Concrete
{
    internal sealed class SquareRootUnaryExpression : UnaryExpression
    {
        internal SquareRootUnaryExpression(Expression expression)
            : base(expression)
        {
        }

        internal override decimal Evaluate()
        {
            return (decimal) Math.Sqrt((double) Expression.Evaluate());
        }
    }
}