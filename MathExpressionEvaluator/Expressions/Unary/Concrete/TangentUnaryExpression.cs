﻿using System;

namespace MathExpressionEvaluator.Expressions.Unary.Concrete
{
    internal sealed class TangentUnaryExpression : UnaryExpression
    {
        internal TangentUnaryExpression(Expression expression)
            : base(expression)
        {
        }

        internal override decimal Evaluate()
        {
            return (decimal) Math.Tan((double) Expression.Evaluate());
        }
    }
}