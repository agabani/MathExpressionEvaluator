namespace MathExpressionEvaluator.Expressions.Binary.Concrete
{
    internal sealed class MultiplicationBinaryExpression : BinaryExpression
    {
        internal MultiplicationBinaryExpression(Expression expression1, Expression expression2)
            : base(expression1, expression2)
        {
        }

        internal override double Evaluate()
        {
            return Expression1.Evaluate()*Expression2.Evaluate();
        }
    }
}