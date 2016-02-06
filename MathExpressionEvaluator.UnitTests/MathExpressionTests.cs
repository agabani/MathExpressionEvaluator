using System;
using NUnit.Framework;

namespace MathExpressionEvaluator.UnitTests
{
    [TestFixture]
    public class MathExpressionTests
    {
        private const double Epsilon = 0.0000000001;

        [Test]
        [TestCase("1 + 2", 3d)]
        [TestCase("2 + 4 + 6", 12d)]
        public void Should_be_able_to_evaluate_addition(string question, double answer)
        {
            Assert.That(new MathExpression(question).Evaluate(), Is.EqualTo(answer));
        }

        [Test]
        [TestCase("(-5 + sqrt(5^2 - 4*1*6)) / (2*1)", -2d)]
        [TestCase("(-5 - sqrt(5^2 - 4*1*6)) / (2*1)", -3d)]
        public void Should_be_able_to_evaluate_bodmas(string question, double answer)
        {
            Assert.That(new MathExpression(question).Evaluate(), Is.EqualTo(answer));
        }

        [Test]
        [TestCase("$e", Math.E)]
        [TestCase("-$e", -Math.E)]
        [TestCase("pi", Math.PI)]
        [TestCase("-pi", -Math.PI)]
        public void Should_be_able_to_evaluate_constants(string question, double answer)
        {
            Assert.That(new MathExpression(question).Evaluate(), Is.EqualTo(answer));
        }

        [Test]
        [TestCase("0!", 1d)]
        [TestCase("0.5!", 0.88622692545d)]
        [TestCase("1!", 1d)]
        [TestCase("4!", 24d)]
        [TestCase("6!", 720d)]
        public void Should_be_able_to_evaluate_factorial(string question, double answer)
        {
            Assert.That(new MathExpression(question).Evaluate(),
                Is.LessThanOrEqualTo(answer + Epsilon)
                    .And.GreaterThanOrEqualTo(answer - Epsilon));
        }

        [Test]
        [TestCase("lg(16)", 4d)]
        [TestCase("ln(16)", 2.77258872224d)]
        [TestCase("log(16)", 1.20411998266d)]
        public void Should_be_able_to_evaluate_logarithm(string question, double answer)
        {
            Assert.That(new MathExpression(question).Evaluate(),
                Is.LessThanOrEqualTo(answer + Epsilon)
                    .And.GreaterThanOrEqualTo(answer - Epsilon));
        }

        [Test]
        [TestCase("5 % 2", 1d)]
        [TestCase("5 % 2 * 3", 3d)]
        [TestCase("5 % 2 ^ 3", 5d)]
        [TestCase("3 * 5 % 2", 1d)]
        [TestCase("3 ^ 5 % 2", 1d)]
        public void Should_be_able_to_evaluate_modulation(string question, double answer)
        {
            Assert.That(new MathExpression(question).Evaluate(), Is.EqualTo(answer));
        }

        [Test]
        [TestCase("0", 0d)]
        [TestCase("1", 1d)]
        [TestCase("-1", -1d)]
        public void Should_be_able_to_evaluate_numbers(string question, double answer)
        {
            Assert.That(new MathExpression(question).Evaluate(), Is.EqualTo(answer));
        }

        [Test]
        [TestCase("3^3", 27d)]
        [TestCase("64^(1/2)", 8d)]
        public void Should_be_able_to_evaluate_power(string question, double answer)
        {
            Assert.That(new MathExpression(question).Evaluate(), Is.EqualTo(answer));
        }

        [Test]
        [TestCase("sqrt(64)", 8d)]
        public void Should_be_able_to_evaluate_square_root(string question, double answer)
        {
            Assert.That(new MathExpression(question).Evaluate(), Is.EqualTo(answer));
        }

        [Test]
        [TestCase("-1 - 2", -3d)]
        [TestCase("3 - -2", 5d)]
        public void Should_be_able_to_evaluate_subtraction(string question, double answer)
        {
            Assert.That(new MathExpression(question).Evaluate(), Is.EqualTo(answer));
        }

        [Test]
        [TestCase("cos(0)", 1d)]
        [TestCase("cos(pi/2)", 0d)]
        [TestCase("cos(pi)", -1d)]
        [TestCase("cos(3*pi/2)", 0d)]
        [TestCase("sin(0)", 0d)]
        [TestCase("sin(pi/2)", 1d)]
        [TestCase("sin(pi)", 0d)]
        [TestCase("sin(3*pi/2)", -1d)]
        [TestCase("tan(0)", 0d)]
        [TestCase("tan(pi/4)", 1d)]
        [TestCase("tan(pi)", 0d)]
        [TestCase("tan(3*pi/4)", -1d)]
        [TestCase("arccos(1)", 0d)]
        [TestCase("arccos(0)", Math.PI/2)]
        [TestCase("arccos(-1)", Math.PI)]
        [TestCase("arcsin(1)", Math.PI/2)]
        [TestCase("arcsin(0)", 0d)]
        [TestCase("arcsin(-1)", -Math.PI/2)]
        [TestCase("arctan(1)", Math.PI/4)]
        [TestCase("arctan(0)", 0d)]
        [TestCase("arctan(-1)", -Math.PI/4)]
        [TestCase("cosh(0)", 1d)]
        [TestCase("cosh(pi)", 11.5919532755d)]
        [TestCase("cosh(-3*pi/4)", 5.32275214952d)]
        [TestCase("sinh(0)", 0d)]
        [TestCase("sinh(pi)", 11.5487393573d)]
        [TestCase("sinh(-3*pi/4)", -5.22797192468d)]
        [TestCase("tanh(0)", 0d)]
        [TestCase("tanh(pi/4)", 0.65579420263d)]
        [TestCase("tanh(-pi/4)", -0.65579420263d)]
        public void Should_be_able_to_evaluate_trigonometry(string question, double answer)
        {
            Assert.That(new MathExpression(question).Evaluate(),
                Is.LessThanOrEqualTo(answer + Epsilon)
                    .And.GreaterThanOrEqualTo(answer - Epsilon));
        }

        [Test]
        [TestCase("1 + 2 * 3 -4")]
        public void Should_not_be_able_to_evaluate_invalid_expressions(string question)
        {
            var exception = Assert.Throws<ArgumentException>(() => new MathExpression(question).Evaluate());
            Assert.That(exception.Message, Is.EqualTo(question));
        }
    }
}