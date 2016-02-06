using System;

namespace MathExpressionEvaluator.Expressions.Unary.Concrete
{
    internal sealed class HyperbolicSineUnaryExpression : UnaryExpression
    {
        internal HyperbolicSineUnaryExpression(Expression expression)
            : base(expression)
        {
        }

        internal override double Evaluate()
        {
            return Math.Sinh(Expression.Evaluate());
        }
    }
}