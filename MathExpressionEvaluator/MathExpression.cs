namespace MathExpressionEvaluator
{
    public class MathExpression
    {
        private readonly string _expression;
        private decimal? _evaluation;

        public MathExpression(string expression)
        {
            _expression = expression;
        }

        public decimal Evaluate()
        {
            return (decimal)
                (_evaluation ?? (_evaluation = Interpreter.Accessor().Interpret(new Notation(_expression)).Evaluate()));
        }
    }
}