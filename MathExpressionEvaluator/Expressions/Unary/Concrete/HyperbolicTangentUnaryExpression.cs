using System;

namespace MathExpressionEvaluator.Expressions.Unary.Concrete
{
    internal sealed class HyperbolicTangentUnaryExpression : UnaryExpression
    {
        internal HyperbolicTangentUnaryExpression(Expression expression)
            : base(expression)
        {
        }

        internal override double Evaluate()
        {
            return Math.Tanh(Expression.Evaluate());
        }
    }
}