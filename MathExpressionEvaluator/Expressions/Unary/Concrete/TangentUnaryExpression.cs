using System;

namespace MathExpressionEvaluator.Expressions.Unary.Concrete
{
    internal sealed class TangentUnaryExpression : UnaryExpression
    {
        internal TangentUnaryExpression(Expression expression)
            : base(expression)
        {
        }

        internal override double Evaluate()
        {
            return Math.Tan(Expression.Evaluate());
        }
    }
}