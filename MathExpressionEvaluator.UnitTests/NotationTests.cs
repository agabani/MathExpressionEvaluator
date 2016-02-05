using System.Collections.Generic;
using NUnit.Framework;

namespace MathExpressionEvaluator.UnitTests
{
    [TestFixture]
    public class NotationTests
    {
        [Test]
        public void Should_be_able_to_create_notation_from_expression()
        {
            var notation = new Notation("(5+3)*12/3");

            CollectionAssert
                .AreEqual(new List<string> { "(", "5", "+", "3", ")", "*", "12", "/", "3" }, notation.Infix);

            CollectionAssert
                .AreEqual(new List<string> { "5", "3", "+", "12", "*", "3", "/" }, notation.Postfix);
        }
    }
}