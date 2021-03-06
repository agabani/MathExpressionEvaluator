﻿using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace MathExpressionEvaluator.Parser
{
    internal class RegexExpressionParser
    {
        private const string Numeric = "-?\\d+(\\.\\d+)?";
        private const string Variable = "\\$[a-zA-Z][a-zA-Z0-9]*";
        private const string Operation = "[a-zA-Z][a-zA-Z0-9]+|[-*/+|?:@&^<>'`=%#!]";
        private const string Parenthesis = "[()]";

        private static RegexExpressionParser _regexExpressionParser;

        private static readonly Regex Regex = new Regex(Numeric + "|" + Operation + "|" + Variable + "|" + Parenthesis);

        private RegexExpressionParser()
        {
        }

        internal static RegexExpressionParser Accessor()
        {
            return _regexExpressionParser ?? (_regexExpressionParser = new RegexExpressionParser());
        }

        internal IReadOnlyList<string> Parse(string expression)
        {
            return (from object match in Regex.Matches(expression) select match.ToString()).ToList();
        }
    }
}