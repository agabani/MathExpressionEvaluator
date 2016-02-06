using MathExpressionEvaluator.Interpreter;
using MathExpressionEvaluator.Parser;

namespace MathExpressionEvaluator
{
    public class MathExpression
    {
        private readonly string _expression;
        private double? _evaluation;

        public MathExpression(string expression)
        {
            _expression = expression;
        }

        public double Evaluate()
        {
            return (double)
                (_evaluation ??
                 (_evaluation = PostfixInterpreter.Accessor().Interpret(new Notation(_expression)).Evaluate()));
        }
    }
}