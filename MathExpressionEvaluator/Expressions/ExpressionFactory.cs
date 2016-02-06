using System;
using MathExpressionEvaluator.Common;
using MathExpressionEvaluator.Expressions.Binary.Concrete;
using MathExpressionEvaluator.Expressions.Unary.Concrete;
using MathExpressionEvaluator.Expressions.Value;

namespace MathExpressionEvaluator.Expressions
{
    internal class ExpressionFactory
    {
        private static ExpressionFactory _expressionFactory;

        private ExpressionFactory()
        {
        }

        internal static ExpressionFactory Accessor()
        {
            return _expressionFactory ?? (_expressionFactory = new ExpressionFactory());
        }

        internal int RequiredOperands(string @operator, int availableOperands)
        {
            decimal value;

            if (decimal.TryParse(@operator, out value))
            {
                return 0;
            }

            switch (@operator)
            {
                case Symbol.Pi:
                    return 0;
                case Symbol.Cos:
                case Symbol.Sin:
                case Symbol.SquareRoot:
                    return 1;
                case Symbol.Subtraction:
                    return availableOperands == 1 ? 1 : 2;
                case Symbol.Addition:
                case Symbol.Division:
                case Symbol.Multiplication:
                case Symbol.Power:
                    return 2;

                default:
                    throw new NotSupportedException(@operator);
            }
        }

        internal Expression Create(string @operator)
        {
            decimal value;

            if (decimal.TryParse(@operator, out value))
            {
                return new ValueExpression(decimal.Parse(@operator));
            }

            switch (@operator)
            {
                case Symbol.Pi:
                    return new PiExpression();
                default:
                    throw new NotSupportedException(@operator);
            }
        }

        internal Expression Create(string @operator, Expression operand)
        {
            switch (@operator)
            {
                case Symbol.Cos:
                    return new CosUnaryExpression(operand);
                case Symbol.Sin:
                    return new SinUnaryExpression(operand);
                case Symbol.SquareRoot:
                    return new SquareRootUnaryExpression(operand);
                case Symbol.Subtraction:
                    return new NotUnaryExpression(operand);
                default:
                    throw new NotSupportedException(@operator);
            }
        }

        internal Expression Create(string @operator, Expression operand2, Expression operand1)
        {
            switch (@operator)
            {
                case Symbol.Addition:
                    return new AdditionBinaryExpression(operand1, operand2);
                case Symbol.Division:
                    return new DivisionBinaryExpression(operand1, operand2);
                case Symbol.Multiplication:
                    return new MultiplicationBinaryExpression(operand1, operand2);
                case Symbol.Power:
                    return new PowerBinaryExpression(operand1, operand2);
                case Symbol.Subtraction:
                    return new SubtractionBinaryExpression(operand1, operand2);
                default:
                    throw new NotSupportedException(@operator);
            }
        }
    }
}