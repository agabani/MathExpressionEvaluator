using System;

namespace MathExpressionEvaluator.Expressions.Unary.Concrete
{
    public class SquareRootUnaryExpression : UnaryExpression
    {
        public SquareRootUnaryExpression(Expression expression)
            : base(expression)
        {
        }

        public override decimal Evaluate()
        {
            return (decimal) Math.Sqrt((double) Expression.Evaluate());
        }
    }
}