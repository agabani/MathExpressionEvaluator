# Math Expression Evaluator
>  A lightweight C# math expression evaluator with lazy parsing and solving during runtime, designed to be simple and easy to use, with support for standard order of operations and commonly used functions such as logarithms, trigonometry and factorials.

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
| Name           | Symbol |
|----------------|--------|
| Pi             | pi     |
| Euler's number | $e     |

## Supported Functions
### Unary Functions
| Name               | Symbol |
|--------------------|--------|
| Log2               | lg     |
| Log10              | log    |
| Natural Log        | ln     |
| Factorial          | !      |
| Sine               | sin    |
| Cosine             | cos    |
| Tangent            | tan    |
| Inverse Sine       | arcsin |
| Inverse Cosine     | arccos |
| Inverse Tangent    | arctan |
| Hyperbolic Sine    | sinh   |
| Hyperbolic Cosine  | cosh   |
| Hyperbolic Tangent | tanh   |
| Square Root        | sqrt   |

### Binary functions
| Name           | Symbol |
|----------------|--------|
| Addition       | +      |
| Subtraction    | -      |
| Multiplication | *      |
| Division       | /      |
| Exponentiation | ^      |
| Modulo         | %      |

## Supported Order of Operations
| Name              | Symbol |
|-------------------|--------|
| Open Parentheses  | (      |
| Close Parentheses | )      |