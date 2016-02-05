using System;
using MathExpressionEvaluator.Expressions.Binary.Concrete;
using MathExpressionEvaluator.Expressions.Unary.Concrete;

namespace MathExpressionEvaluator.Expressions
{
    public class ExpressionFactory
    {
        private static ExpressionFactory _expressionFactory;

        private ExpressionFactory()
        {
        }

        public static ExpressionFactory Accessor()
        {
            return _expressionFactory ?? (_expressionFactory = new ExpressionFactory());
        }

        public int RequiredOperands(string @operator, int availableOperands)
        {
            decimal value;

            if (decimal.TryParse(@operator, out value))
            {
                return 0;
            }

            switch (@operator)
            {
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

        public Expression Create(string @operator)
        {
            return new ValueExpression(decimal.Parse(@operator));
        }

        public Expression Create(string @operator, Expression operand)
        {
            switch (@operator)
            {
                case Symbol.SquareRoot:
                    return new SquareRootUnaryExpression(operand);
                case Symbol.Subtraction:
                    return new NotUnaryExpression(operand);
                default:
                    throw new NotSupportedException(@operator);
            }
        }

        public Expression Create(string @operator, Expression operand2, Expression operand1)
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