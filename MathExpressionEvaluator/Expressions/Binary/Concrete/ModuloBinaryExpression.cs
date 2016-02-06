namespace MathExpressionEvaluator.Expressions.Binary.Concrete
{
    internal sealed class ModuloBinaryExpression : BinaryExpression
    {
        internal ModuloBinaryExpression(Expression expression1, Expression expression2)
            : base(expression1, expression2)
        {
        }

        internal override decimal Evaluate()
        {
            return Expression1.Evaluate()%Expression2.Evaluate();
        }
    }
}