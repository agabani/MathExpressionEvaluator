namespace MathExpressionEvaluator.Expressions.Value
{
    internal sealed class ConstantExpression : Expression
    {
        private readonly decimal _value;

        internal ConstantExpression(decimal value)
        {
            _value = value;
        }

        internal override decimal Evaluate()
        {
            return _value;
        }
    }
}