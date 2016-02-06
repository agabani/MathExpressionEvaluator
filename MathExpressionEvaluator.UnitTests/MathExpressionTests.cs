using System;
using NUnit.Framework;

namespace MathExpressionEvaluator.UnitTests
{
    [TestFixture]
    public class MathExpressionTests
    {
        [Test]
        [TestCase("1 + 2", 3)]
        [TestCase("2 + 4 + 6", 12)]
        public void Should_be_able_to_evaluate_addition(string question, decimal answer)
        {
            Assert.That(new MathExpression(question).Evaluate(), Is.EqualTo(answer));
        }

        [Test]
        [TestCase("(5 + 3) * 12 / 3", 32)]
        [TestCase("(5 + 3 ^ 2) * 12 / 3", 56)]
        public void Should_be_able_to_evaluate_bodmas(string question, decimal answer)
        {
            Assert.That(new MathExpression(question).Evaluate(), Is.EqualTo(answer));
        }

        [Test]
        [TestCase("0", 0)]
        [TestCase("1", 1)]
        [TestCase("-1", -1)]
        public void Should_be_able_to_evaluate_numbers(string question, decimal answer)
        {
            Assert.That(new MathExpression(question).Evaluate(), Is.EqualTo(answer));
        }

        [Test]
        [TestCase("pi", Math.PI)]
        [TestCase("-pi", -Math.PI)]
        public void Should_be_able_to_evaluate_Pi(string question, decimal answer)
        {
            Assert.That(new MathExpression(question).Evaluate(), Is.EqualTo(answer));
        }

        [Test]
        [TestCase("3^3", 27)]
        [TestCase("64^(1/2)", 8)]
        public void Should_be_able_to_evaluate_power(string question, decimal answer)
        {
            Assert.That(new MathExpression(question).Evaluate(), Is.EqualTo(answer));
        }

        [Test]
        [TestCase("sqrt(64)", 8)]
        public void Should_be_able_to_evaluate_square_root(string question, decimal answer)
        {
            Assert.That(new MathExpression(question).Evaluate(), Is.EqualTo(answer));
        }

        [Test]
        [TestCase("-1 - 2", -3)]
        public void Should_be_able_to_evaluate_subtraction(string question, decimal answer)
        {
            Assert.That(new MathExpression(question).Evaluate(), Is.EqualTo(answer));
        }

        [Test]
        [TestCase("cos(0)", 1)]
        [TestCase("cos(pi/2)", 0)]
        [TestCase("cos(pi)", -1)]
        [TestCase("cos(3*pi/2)", 0)]
        [TestCase("sin(0)", 0)]
        [TestCase("sin(pi/2)", 1)]
        [TestCase("sin(pi)", 0)]
        [TestCase("sin(3*pi/2)", -1)]
        [TestCase("tan(0)", 0)]
        [TestCase("tan(pi/4)", 1)]
        [TestCase("tan(pi)", 0)]
        [TestCase("tan(3*pi/4)", -1)]
        [TestCase("arccos(1)", 0)]
        [TestCase("arccos(0)", Math.PI/2)]
        [TestCase("arccos(-1)", Math.PI)]
        [TestCase("arcsin(1)", Math.PI/2)]
        [TestCase("arcsin(0)", 0)]
        [TestCase("arcsin(-1)", -Math.PI/2)]
        public void Should_be_able_to_evaluate_trigonometry(string question, decimal answer)
        {
            var mathExpression = new MathExpression(question);
            var actual = mathExpression.Evaluate();
            Assert.That(actual,
                Is.LessThanOrEqualTo(answer + (decimal) 0.00000000000001)
                    .And.GreaterThanOrEqualTo(answer - (decimal) 0.00000000000001));
        }
    }
}