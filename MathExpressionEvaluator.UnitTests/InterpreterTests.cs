using NUnit.Framework;

namespace MathExpressionEvaluator.UnitTests
{
    [TestFixture]
    public class InterpreterTests
    {
        [Test]
        [TestCase("1", 1)]
        [TestCase("1 + 2", 3)]
        [TestCase("-1", -1)]
        [TestCase("-1 - 2", -3)]
        [TestCase("(5 + 3) * 12 / 3", 32)]
        [TestCase("(5 + 3 ^ 2) * 12 / 3", 56)]
        [TestCase("64^(1/2)", 8)]
        public void Should_parse_interpret_and_evaluate_expression(string question, decimal answer)
        {
            var notation = new Notation(question);

            var expression = Interpreter.Accessor().Interpret(notation);

            Assert.That(expression.Evaluate(), Is.EqualTo(answer));
        }
    }
}