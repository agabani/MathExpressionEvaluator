namespace MathExpressionEvaluator.Expressions.Binary.Concrete
{
    public sealed class AdditionBinaryExpression : BinaryExpression
    {
        public AdditionBinaryExpression(Expression expression1, Expression expression2)
            : base(expression1, expression2)
        {
        }

        public override decimal Evaluate()
        {
            return Expression1.Evaluate() + Expression2.Evaluate();
        }
    }
}