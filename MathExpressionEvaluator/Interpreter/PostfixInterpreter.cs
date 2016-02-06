using System;
using System.Collections.Generic;
using MathExpressionEvaluator.Expressions;
using MathExpressionEvaluator.Parser;

namespace MathExpressionEvaluator.Interpreter
{
    internal class PostfixInterpreter
    {
        private static PostfixInterpreter _postfixInterpreter;

        private PostfixInterpreter()
        {
        }

        internal static PostfixInterpreter Accessor()
        {
            return _postfixInterpreter ?? (_postfixInterpreter = new PostfixInterpreter());
        }

        internal Expression Interpret(Notation notation)
        {
            var expressionFactory = ExpressionFactory.Accessor();

            var expressions = new Stack<Expression>();

            foreach (var @operator in notation.Postfix)
            {
                switch (expressionFactory.RequiredOperands(@operator, expressions.Count))
                {
                    case 0:
                        expressions.Push(expressionFactory.Create(@operator));
                        break;
                    case 1:
                        expressions.Push(expressionFactory.Create(@operator, expressions.Pop()));
                        break;
                    case 2:
                        expressions.Push(expressionFactory.Create(@operator, expressions.Pop(), expressions.Pop()));
                        break;
                    default:
                        throw new NotSupportedException();
                }
            }

            if (expressions.Count == 1)
            {
                return expressions.Pop();
            }

            throw new ArgumentException(notation.Expression);
        }
    }
}