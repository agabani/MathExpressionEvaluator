﻿using System;

namespace MathExpressionEvaluator.Expressions.Unary.Concrete
{
    internal class InverseCosineUnaryExpression : UnaryExpression
    {
        internal InverseCosineUnaryExpression(Expression expression)
            : base(expression)
        {
        }

        internal override decimal Evaluate()
        {
            return (decimal) Math.Acos((double) Expression.Evaluate());
        }
    }
}