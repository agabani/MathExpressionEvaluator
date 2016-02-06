using System;

namespace MathExpressionEvaluator.Expressions.Unary.Concrete
{
    internal class CosineUnaryExpression : UnaryExpression
    {
        internal CosineUnaryExpression(Expression expression)
            : base(expression)
        {
        }

        internal override decimal Evaluate()
        {
            return (decimal) Math.Cos((double) Expression.Evaluate());
        }
    }
}