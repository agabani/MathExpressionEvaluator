using System;

namespace MathExpressionEvaluator.Expressions.Binary.Concrete
{
    internal sealed class PowerBinaryExpression : BinaryExpression
    {
        internal PowerBinaryExpression(Expression expression1, Expression expression2)
            : base(expression1, expression2)
        {
        }

        internal override double Evaluate()
        {
            return Math.Pow(Expression1.Evaluate(), Expression2.Evaluate());
        }
    }
}