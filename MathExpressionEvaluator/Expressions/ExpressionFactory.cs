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
            double value;

            if (double.TryParse(@operator, out value))
            {
                return 0;
            }

            switch (@operator)
            {
                case Symbol.E:
                case Symbol.Pi:
                    return 0;

                case Symbol.Arccos:
                case Symbol.Arcsin:
                case Symbol.Arctan:
                case Symbol.Cos:
                case Symbol.Factorial:
                case Symbol.Lg:
                case Symbol.Ln:
                case Symbol.Log:
                case Symbol.Sin:
                case Symbol.SquareRoot:
                case Symbol.Tan:
                    return 1;

                case Symbol.Subtraction:
                    return availableOperands == 1 ? 1 : 2;

                case Symbol.Addition:
                case Symbol.Division:
                case Symbol.Modulo:
                case Symbol.Multiplication:
                case Symbol.Power:
                    return 2;

                default:
                    throw new NotSupportedException(@operator);
            }
        }

        internal Expression Create(string @operator)
        {
            double value;

            if (double.TryParse(@operator, out value))
            {
                return new ConstantExpression(double.Parse(@operator));
            }

            switch (@operator)
            {
                case Symbol.E:
                    return new NaturalExpression();
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
                case Symbol.Arccos:
                    return new InverseCosineUnaryExpression(operand);
                case Symbol.Arcsin:
                    return new InverseSineUnaryExpression(operand);
                case Symbol.Arctan:
                    return new InverseTangentUnaryExpression(operand);
                case Symbol.Cos:
                    return new CosineUnaryExpression(operand);
                case Symbol.Factorial:
                    return new FactorialUnaryExpression(operand);
                case Symbol.Lg:
                    return new Log2UnaryExpression(operand);
                case Symbol.Ln:
                    return new LnUnaryExpression(operand);
                case Symbol.Log:
                    return new Log10UnaryExpression(operand);
                case Symbol.Sin:
                    return new SineUnaryExpression(operand);
                case Symbol.SquareRoot:
                    return new SquareRootUnaryExpression(operand);
                case Symbol.Subtraction:
                    return new NotUnaryExpression(operand);
                case Symbol.Tan:
                    return new TangentUnaryExpression(operand);
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
                case Symbol.Modulo:
                    return new ModuloBinaryExpression(operand1, operand2);
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