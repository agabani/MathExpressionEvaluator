namespace MathExpressionEvaluator.Expressions
{
    public abstract class Expression
    {
        public abstract decimal Evaluate();
    }

    public sealed class ValueExpression : Expression
    {
        private readonly decimal _value;

        public ValueExpression(decimal value)
        {
            _value = value;
        }

        public override decimal Evaluate()
        {
            return _value;
        }
    }
}