using System;
using System.Collections.Generic;
using System.Linq;
using MathExpressionEvaluator.Common;

namespace MathExpressionEvaluator.Parser
{
    internal class Notation
    {
        private IReadOnlyList<string> _infix;
        private IReadOnlyList<string> _postfix;

        internal Notation(string expression)
        {
            Expression = expression;
        }

        internal IReadOnlyList<string> Infix => _infix ?? (_infix = RegexExpressionParser.Accessor().Parse(Expression));
        internal IReadOnlyList<string> Postfix => _postfix ?? (_postfix = ToPostfix(Infix));
        internal string Expression { get; }

        private static IReadOnlyList<string> ToPostfix(IEnumerable<string> infix)
        {
            var stack = new Stack<string>();
            var postfix = new List<string>();

            foreach (var item in infix)
            {
                if (IsOpenParentheses(item))
                {
                    AddToStack(item, stack);
                }
                else if (IsCloseParentheses(item))
                {
                    DumpUntilThenDiscardOpenParentheses(stack, postfix);
                }
                else if (IsExponent(item) || IsModulo(item) || IsMultiplicationOrDivision(item) ||
                         IsAdditionOrSubtraction(item))
                {
                    ProcessItem(item, stack, postfix);
                }
                else
                {
                    postfix.Add(item);
                }
            }

            DumpFullStack(stack, postfix);

            return postfix;
        }

        private static void AddToStack(string item, Stack<string> stack)
        {
            stack.Push(item);
        }

        private static void ProcessItem(string item, Stack<string> stack, ICollection<string> postfix)
        {
            if (stack.Any() && IsLowerPrecedence(item, stack.Peek()))
            {
                DumpUntilOpenParentheses(stack, postfix);
            }

            AddToStack(item, stack);
        }

        private static void DumpFullStack(Stack<string> stack, ICollection<string> postfix)
        {
            while (stack.Any() && stack.Any())
            {
                postfix.Add(stack.Pop());
            }
        }

        private static void DumpUntilThenDiscardOpenParentheses(Stack<string> stack, ICollection<string> postfix)
        {
            DumpUntilOpenParentheses(stack, postfix);

            if (stack.Any())
            {
                stack.Pop();
            }
        }

        private static void DumpUntilOpenParentheses(Stack<string> stack, ICollection<string> postfix)
        {
            while (stack.Any() && !IsOpenParentheses(stack.Peek()))
            {
                postfix.Add(stack.Pop());
            }
        }

        private static bool IsLowerPrecedence(string item, string stack)
        {
            if (IsOpenParentheses(stack))
            {
                return true;
            }

            if (IsExponent(item))
            {
                return false;
            }

            if (IsModulo(item))
            {
                return IsExponent(stack) || IsModulo(stack) || IsMultiplicationOrDivision(stack);
            }

            if (IsMultiplicationOrDivision(item))
            {
                return IsExponent(stack) || IsModulo(stack);
            }

            if (IsAdditionOrSubtraction(item))
            {
                return IsAdditionOrSubtraction(stack) || IsMultiplicationOrDivision(stack) || IsExponent(stack);
            }

            throw new NotSupportedException(item);
        }

        private static bool IsOpenParentheses(string @operator)
        {
            return @operator == Symbol.OpenParentheses;
        }

        private static bool IsCloseParentheses(string @operator)
        {
            return @operator == Symbol.CloseParentheses;
        }

        private static bool IsExponent(string @operator)
        {
            return @operator == Symbol.Arccos
                   || @operator == Symbol.Arcsin
                   || @operator == Symbol.Arctan
                   || @operator == Symbol.Cos
                   || @operator == Symbol.Factorial
                   || @operator == Symbol.Lg
                   || @operator == Symbol.Ln
                   || @operator == Symbol.Log
                   || @operator == Symbol.Power
                   || @operator == Symbol.Sin
                   || @operator == Symbol.SquareRoot
                   || @operator == Symbol.Tan;
        }

        private static bool IsModulo(string @operator)
        {
            return @operator == Symbol.Modulo;
        }

        private static bool IsMultiplicationOrDivision(string @operator)
        {
            return @operator == Symbol.Multiplication || @operator == Symbol.Division;
        }

        private static bool IsAdditionOrSubtraction(string @operator)
        {
            return @operator == Symbol.Addition || @operator == Symbol.Subtraction;
        }
    }
}