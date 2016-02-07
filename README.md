# Math Expression Evaluator
>  A lightweight C# math expression evaluator with lazy parsing and solving during runtime, designed to be easy to use, with support for standard order of operations and commonly used functions such as logarithms, trigonometry and factorials.

## Examples

``` c#
// Area of a circle
var expression = new MathExpression("pi * 2^2");
var evaluation = expression.Evaluate();
```

``` c#
// Quadratic Formula
var expression = new MathExpression("(-5 + sqrt(5^2 - 4*1*6)) / (2*1)");
var evaluation = expression.Evaluate();
```

``` c#
// Pythagoras Theorem
var expression = new MathExpression("sqrt(3^2 + 4^2)");
var evaluation = expression.Evaluate();
```

``` c#
// Trigonometry
var expression = new MathExpression("arccos(5/7) * 180/pi");
var evaluation = expression.Evaluate();
```

``` c#
// Change of base
var expression = new MathExpression("log(4) / log($e)");
var evaluation = expression.Evaluate();
```

## Supported Constants
| Name           | Symbol | Usage |
|----------------|--------|-------|
| Pi             | pi     | pi    |
| Euler's number | $e     | $e    |

## Supported Functions
### Unary Functions
| Name               | Symbol | Usage     |
|--------------------|--------|-----------|
| Log2               | lg     | lg(16)    |
| Log10              | log    | log(16)   |
| Natural Log        | ln     | ln(16)    |
| Factorial          | !      | 10!       |
| Sine               | sin    | sin(0)    |
| Cosine             | cos    | cos(0)    |
| Tangent            | tan    | tan(0)    |
| Inverse Sine       | arcsin | arcsin(0) |
| Inverse Cosine     | arccos | arccos(0) |
| Inverse Tangent    | arctan | arctan(0) |
| Hyperbolic Sine    | sinh   | sinh(0)   |
| Hyperbolic Cosine  | cosh   | cosh(0)   |
| Hyperbolic Tangent | tanh   | tanh(0)   |
| Square Root        | sqrt   | sqrt(0)   |

### Binary functions
| Name           | Symbol | Usage |
|----------------|--------|-------|
| Addition       | +      | 1 + 2 |
| Subtraction    | -      | 1 - 2 |
| Multiplication | *      | 1 * 2 |
| Division       | /      | 1 / 2 |
| Exponentiation | ^      | 1 ^ 2 |
| Modulo         | %      | 1 % 2 |

## Supported Order of Operations
| Name              | Symbol |
|-------------------|--------|
| Open Parentheses  | (      |
| Close Parentheses | )      |