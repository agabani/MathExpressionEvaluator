using System;

namespace MathExpressionEvaluator.Expressions.Binary.Concrete
{
    internal sealed class PowerBinaryExpression : BinaryExpression
    {
        internal PowerBinaryExpression(Expression expression1, Expression expression2)
            : base(expression1, expression2)
        {
        }

        internal override decimal Evaluate()
        {
            return (decimal) Math.Pow((double) Expression1.Evaluate(), (double) Expression2.Evaluate());
        }
    }
}