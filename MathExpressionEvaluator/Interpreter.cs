﻿using System;
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
                        var operand = expressions.Pop();
                        expressions.Push(expressionFactory.Create(expression, operand));
                        break;
                    case 2:
                        var operand2 = expressions.Pop();
                        var operand1 = expressions.Pop();
                        expressions.Push(expressionFactory.Create(expression, operand1, operand2));
                        break;
                    default:
                        throw new NotSupportedException();
                }
            }

            return expressions.Pop();
        }
    }
}