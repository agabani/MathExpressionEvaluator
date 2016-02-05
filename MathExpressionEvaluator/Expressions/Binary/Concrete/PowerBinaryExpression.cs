using System;

namespace MathExpressionEvaluator.Expressions.Binary.Concrete
{
    public sealed class PowerBinaryExpression : BinaryExpression
    {
        public PowerBinaryExpression(Expression expression1, Expression expression2)
            : base(expression1, expression2)
        {
        }

        public override decimal Evaluate()
        {
            return (decimal) Math.Pow((double) Expression1.Evaluate(), (double) Expression2.Evaluate());
        }
    }
}