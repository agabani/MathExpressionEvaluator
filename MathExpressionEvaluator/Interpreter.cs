using System;
using System.Collections.Generic;
using MathExpressionEvaluator.Expressions;

namespace MathExpressionEvaluator
{
    public class Interpreter
    {
        private static Interpreter _interpreter;

        private Interpreter()
        {
        }

        public static Interpreter Accessor()
        {
            return _interpreter ?? (_interpreter = new Interpreter());
        }

        public Expression Interpret(Notation notation)
        {
            var expressionFactory = ExpressionFactory.Accessor();

            var expressions = new Stack<Expression>();

            foreach (var expression in notation.Postfix)
            {
                switch (expressionFactory.RequiredOperands(expression, expressions.Count))
                {
                    case 0:
                        expressions.Push(expressionFactory.Create(expression));
                        break;
                    case 1:
                        expressions.Push(expressionFactory.Create(expression, expressions.Pop()));
                        break;
                    case 2:
                        expressions.Push(expressionFactory.Create(expression, expressions.Pop(), expressions.Pop()));
                        break;
                    default:
                        throw new NotSupportedException();
                }
            }

            return expressions.Pop();
        }
    }
}