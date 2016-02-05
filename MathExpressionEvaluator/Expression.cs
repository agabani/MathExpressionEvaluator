using System;

namespace MathExpressionEvaluator
{
    public abstract class Expression
    {
        public abstract decimal Evaluate();
    }

    public sealed class ValueExpression : Expression
    {
        private readonly decimal _value;

        public ValueExpression(decimal value)
        {
            _value = value;
        }

        public override decimal Evaluate()
        {
            return _value;
        }
    }

    public abstract class BinaryExpression : Expression
    {
        protected Expression Expression1;
        protected Expression Expression2;

        protected BinaryExpression(Expression expression1, Expression expression2)
        {
            Expression1 = expression1;
            Expression2 = expression2;
        }
    }

    public sealed class AdditionBinaryExpression : BinaryExpression
    {
        public AdditionBinaryExpression(Expression expression1, Expression expression2)
            : base(expression1, expression2)
        {
        }

        public override decimal Evaluate()
        {
            return Expression1.Evaluate() + Expression2.Evaluate();
        }
    }

    public sealed class SubtractionBinaryExpression : BinaryExpression
    {
        public SubtractionBinaryExpression(Expression expression1, Expression expression2)
            : base(expression1, expression2)
        {
        }

        public override decimal Evaluate()
        {
            return Expression1.Evaluate() - Expression2.Evaluate();
        }
    }

    public sealed class MultiplicationBinaryExpression : BinaryExpression
    {
        public MultiplicationBinaryExpression(Expression expression1, Expression expression2)
            : base(expression1, expression2)
        {
        }

        public override decimal Evaluate()
        {
            return Expression1.Evaluate()*Expression2.Evaluate();
        }
    }

    public sealed class DivisionBinaryExpression : BinaryExpression
    {
        public DivisionBinaryExpression(Expression expression1, Expression expression2)
            : base(expression1, expression2)
        {
        }

        public override decimal Evaluate()
        {
            return Expression1.Evaluate()/Expression2.Evaluate();
        }
    }

    public sealed class PowerBinaryExpression : BinaryExpression
    {
        public PowerBinaryExpression(Expression expression1, Expression expression2)
            : base(expression1, expression2)
        {
        }

        public override decimal Evaluate()
        {
            return (decimal) Math.Pow((double) Expression1.Evaluate(), (double) Expression2.Evaluate());
        }
    }
}