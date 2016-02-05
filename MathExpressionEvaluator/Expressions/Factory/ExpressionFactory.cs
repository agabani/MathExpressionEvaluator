using System;
using MathExpressionEvaluator.Expressions.Binary.Concrete;

namespace MathExpressionEvaluator.Expressions.Factory
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
                case "-":
                    return availableOperands == 1 ? 1 : 2;
                case "*":
                case "/":
                case "+":
                case "^":
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
                case "-":
                    return new SubtractionBinaryExpression(new ValueExpression(0), operand);
                default:
                    throw new NotSupportedException(@operator);
            }
        }

        public Expression Create(string @operator, Expression operand1, Expression operand2)
        {
            switch (@operator)
            {
                case "*":
                    return new MultiplicationBinaryExpression(operand1, operand2);
                case "/":
                    return new DivisionBinaryExpression(operand1, operand2);
                case "+":
                    return new AdditionBinaryExpression(operand1, operand2);
                case "-":
                    return new SubtractionBinaryExpression(operand1, operand2);
                case "^":
                    return new PowerBinaryExpression(operand1, operand2);
                default:
                    throw new NotSupportedException(@operator);
            }
        }
    }
}