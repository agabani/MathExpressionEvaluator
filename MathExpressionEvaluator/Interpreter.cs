using System;
using System.Collections.Generic;

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
            var expressions = new Stack<Expression>();

            foreach (var expression in notation.Postfix)
            {
                decimal value;

                if (decimal.TryParse(expression, out value))
                {
                    ParseOperand(expressions, value);
                }
                else
                {
                    ParseOperator(expressions, expression);
                }
            }

            return expressions.Pop();
        }

        private static void ParseOperand(Stack<Expression> expressions, decimal value)
        {
            expressions.Push(new ValueExpression(value));
        }

        private static void ParseOperator(Stack<Expression> expressions, string opera)
        {
            var rightOperand = expressions.Pop();
            var leftOperand = expressions.Pop();
            expressions.Push(ParseOperation(opera, leftOperand, rightOperand));
        }

        private static Expression ParseOperation(string @operator, Expression leftOperand, Expression rightOperand)
        {
            switch (@operator)
            {
                case "*":
                    return new MultiplicationBinaryExpression(leftOperand, rightOperand);
                case "/":
                    return new DivisionBinaryExpression(leftOperand, rightOperand);
                case "+":
                    return new AdditionBinaryExpression(leftOperand, rightOperand);
                case "-":
                    return new SubtractionBinaryExpression(leftOperand, rightOperand);
                case "^":
                    return new PowerBinaryExpression(leftOperand, rightOperand);
                default:
                    throw new NotSupportedException(@operator);
            }
        }
    }
}