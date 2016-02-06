using System;

namespace MathExpressionEvaluator.Expressions.Unary.Concrete
{
    internal class CosUnaryExpression : UnaryExpression
    {
        internal CosUnaryExpression(Expression expression) : base(expression)
        {
        }

        internal override decimal Evaluate()
        {
            return (decimal) Math.Cos((double) Expression.Evaluate());
        }
    }
}