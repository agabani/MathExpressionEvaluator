using System;

namespace MathExpressionEvaluator.Expressions.Unary.Concrete
{
    internal sealed class HyperbolicCosineUnaryExpression : UnaryExpression
    {
        internal HyperbolicCosineUnaryExpression(Expression expression)
            : base(expression)
        {
        }

        internal override double Evaluate()
        {
            return Math.Cosh(Expression.Evaluate());
        }
    }
}