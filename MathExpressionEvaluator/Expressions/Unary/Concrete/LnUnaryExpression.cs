using System;

namespace MathExpressionEvaluator.Expressions.Unary.Concrete
{
    internal sealed class LnUnaryExpression : UnaryExpression
    {
        internal LnUnaryExpression(Expression expression)
            : base(expression)
        {
        }

        internal override double Evaluate()
        {
            return Math.Log(Expression.Evaluate(), Math.E);
        }
    }
}