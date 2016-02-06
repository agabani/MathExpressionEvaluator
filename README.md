# Math Expression Evalutor
> Lightweight lazy infix math expression evaluator written using C#

## Examples

``` c#
// Order of Operations - BODMAS
var expression = new MathExpression("(5 + 3 ^ 2) * 12 / 3");
var evaluation = expression.Evaluate();
```

``` c#
// Area of a circle
var expression = new MathExpression("pi * 2^2");
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
| Name            | Symbol |
|-----------------|--------|
| Square Root     | sqrt   |
| Sine            | sin    |
| Cosine          | cos    |
| Tangent         | tan    |
| Inverse Sine    | arcsin |
| Inverse Cosine  | arccos |
| Inverse Tangent | arctan |
| Natural Log     | ln     |
| Log2            | lg     |
| Log10           | log    |

### Binary functions
| Name           | Symbol |
|----------------|--------|
| Addition       |    +   |
| Subtraction    |    -   |
| Multiplication |    *   |
| Division       |    /   |
| Exponentiation |    ^   |