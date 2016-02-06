using System;

namespace MathExpressionEvaluator.Expressions.Unary.Concrete
{
    internal sealed class SquareRootUnaryExpression : UnaryExpression
    {
        internal SquareRootUnaryExpression(Expression expression)
            : base(expression)
        {
        }

        internal override double Evaluate()
        {
            return Math.Sqrt(Expression.Evaluate());
        }
    }
}