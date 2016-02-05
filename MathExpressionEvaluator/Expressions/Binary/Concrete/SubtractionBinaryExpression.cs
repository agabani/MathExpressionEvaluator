﻿namespace MathExpressionEvaluator.Expressions.Binary.Concrete
{
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
}