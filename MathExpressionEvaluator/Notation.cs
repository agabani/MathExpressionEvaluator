using System.Collections.Generic;
using System.Linq;

namespace MathExpressionEvaluator
{
    public class Notation
    {
        private IReadOnlyList<string> _infix;
        private IReadOnlyList<string> _postfix;

        public Notation(string expression)
        {
            Expression = expression;
        }

        public IReadOnlyList<string> Infix => _infix ?? (_infix = RegexExpressionParser.Accessor().Parse(Expression));
        public IReadOnlyList<string> Postfix => _postfix ?? (_postfix = ToPostfix(Infix));

        public string Expression { get; }

        private static IReadOnlyList<string> ToPostfix(IEnumerable<string> expression)
        {
            var stack = new Stack<string>();
            var postfix = new List<string>();

            foreach (var item in expression)
            {
                if (IsOpenParentheses(item))
                {
                    AddToStack(stack, item);
                }
                else if (IsCloseParentheses(item))
                {
                    DumpUntilOpenParentheses(stack, postfix);
                }
                else if (IsExponent(item) || IsMultiplication(item) || IsAddition(item))
                {
                    ProcessItem(stack, item, postfix);
                }
                else
                {
                    postfix.Add(item);
                }
            }

            DumpFullStack(stack, postfix);

            return postfix;
        }

        private static void AddToStack(Stack<string> stack, string item)
        {
            stack.Push(item);
        }

        private static void DumpUntilOpenParentheses(Stack<string> stack, ICollection<string> postfix)
        {
            while (!IsOpenParentheses(stack.Peek()))
            {
                postfix.Add(stack.Pop());
            }

            stack.Pop();
        }

        private static void ProcessItem(Stack<string> stack, string item, ICollection<string> postfix)
        {
            if (stack.Any() && !IsHigherPrecedence(item, stack.Peek()))
            {
                DumpFullStack(stack, postfix);
            }

            AddToStack(stack, item);
        }

        private static void DumpFullStack(Stack<string> stack, ICollection<string> postfix)
        {
            while (stack.Any())
            {
                postfix.Add(stack.Pop());
            }
        }

        public static bool IsHigherPrecedence(string @this, string other)
        {
            if (IsOpenParentheses(@this))
            {
                return IsOpenParentheses(other);
            }

            if (IsExponent(@this))
            {
                return true;
            }

            if (IsMultiplication(@this))
            {
                return IsExponent(other) || IsOpenParentheses(other);
            }

            if (IsAddition(@this))
            {
                return IsMultiplication(other) || IsExponent(other) || IsOpenParentheses(other);
            }

            return default(bool);
        }

        private static bool IsOpenParentheses(string expression)
        {
            return expression == Symbol.OpenParentheses;
        }

        private static bool IsCloseParentheses(string expression)
        {
            return expression == Symbol.CloseParentheses;
        }

        private static bool IsExponent(string expression)
        {
            return expression == Symbol.Power || expression == Symbol.SquareRoot;
        }

        public static bool IsMultiplication(string expression)
        {
            return expression == Symbol.Multiplication || expression == Symbol.Division;
        }

        public static bool IsAddition(string expression)
        {
            return expression == Symbol.Addition || expression == Symbol.Subtraction;
        }
    }
}