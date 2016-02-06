namespace MathExpressionEvaluator.Expressions.Value
{
    internal sealed class ConstantExpression : Expression
    {
        private readonly double _value;

        internal ConstantExpression(double value)
        {
            _value = value;
        }

        internal override double Evaluate()
        {
            return _value;
        }
    }
}