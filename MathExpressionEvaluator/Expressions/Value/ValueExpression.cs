namespace MathExpressionEvaluator.Expressions.Value
{
    internal sealed class ValueExpression : Expression
    {
        private readonly decimal _value;

        internal ValueExpression(decimal value)
        {
            _value = value;
        }

        internal override decimal Evaluate()
        {
            return _value;
        }
    }
}