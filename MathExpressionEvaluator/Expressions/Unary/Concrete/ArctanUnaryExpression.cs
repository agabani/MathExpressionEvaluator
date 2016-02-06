using System;

namespace MathExpressionEvaluator.Expressions.Unary.Concrete
{
    internal class ArctanUnaryExpression : UnaryExpression
    {
        internal ArctanUnaryExpression(Expression expression)
            : base(expression)
        {
        }

        internal override decimal Evaluate()
        {
            return (decimal) Math.Atan((double) Expression.Evaluate());
        }
    }
}