namespace MathExpressionEvaluator.Expressions.Binary
{
    internal abstract class BinaryExpression : Expression
    {
        protected Expression Expression1;
        protected Expression Expression2;

        protected BinaryExpression(Expression expression1, Expression expression2)
        {
            Expression1 = expression1;
            Expression2 = expression2;
        }
    }
}