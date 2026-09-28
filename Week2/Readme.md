# Discourse Chapter 2

# Week 2 - C# Processing Data

## Overview

This week's practice and lessons introduce processing data in C# Windows
Forms. We learned how to receive information from users, store it in
variables, perform calculations, display results, handle unexpected
input.

Topics covered:

-   Read input with TextBox controls
-   Work with string and numeric data types
-   Perform arithmetic calculations
-   Convert input strings to numeric values
-   Display and format numeric output
-   Handle exceptions with `try-catch`
-   Use named constants and class-level fields


------------------------------------------------------------------------

## 1. Reading Input with TextBox Controls

A `TextBox` is a Windows Forms control that lets a user enter
information using the keyboard. The value entered by the user is stored
in the control's `Text` property.

For example, the following statement clears a TextBox:

``` csharp
textBox1.Clear();
```

We can also clear it by assigning an empty string:

``` csharp
textBox1.Text = string.Empty;
```

**Key point:** A TextBox stores its input as a string, even when the
user types digits.

------------------------------------------------------------------------


## 2. Numeric Data Types

When a program needs to store numbers for calculations, it uses a
numeric data type. The slides introduce these commonly used types:

  ------------------------------------------------------------------------------
  Type                    What it stores          Example
  ----------------------- ----------------------- ------------------------------
  `int`                   Whole numbers           `int hoursWorked = 40;`

  `double`                Real numbers, including `double temperature = 87.6;`
                          fractional values       

  `decimal`               Real numbers with       `decimal payRate = 28.75m;`
                          greater precision,      
                          often used for          
                          financial values        
  ------------------------------------------------------------------------------

A numeric literal is a number written directly in code. Integer literals
such as `40` are treated as `int`; a number with a decimal point, such
as `87.6`, is treated as `double`. A `decimal` literal uses the suffix
`m` or `M`.

### Assignment compatibility and type casting

Values assigned to variables must be compatible with the variable's data
type. The lecture explains that `int` accepts integer values; `double`
accepts `int` and `double`; and `decimal` accepts `int` and `decimal`.
Directly assigning a `double` to a `decimal`, or a `decimal` to a
`double`, is not allowed.

A cast explicitly converts a value to another type:

``` csharp
decimal moneyNumber = 4500m;
int wholeNumber = (int)moneyNumber;
```

The `var` keyword can be used for a local variable when it is
initialized. The compiler infers the variable's type from the assigned
value:

``` csharp
var interestRate = 12.0;
var stockCode = "D465U";
```

------------------------------------------------------------------------

## 3. Performing Calculations

C# uses arithmetic operators to perform calculations.

  Operator   Operation        Description
  ---------- ---------------- ----------------------------------
  `+`        Addition         Adds values
  `-`        Subtraction      Subtracts one value from another
  `*`        Multiplication   Multiplies values
  `/`        Division         Divides and returns the quotient
  `%`        Modulus          Returns the remainder

Example:

``` csharp
int x = 5;
int y = 4;
int total = x + y;
```

Use parentheses when needed to control the order of operations:

``` csharp
result = (a + b) / 4;
```

### Integer division

When both operands are integers, division produces an integer result,
dropping the fractional part. For example, `7 / 3` results in `2`.

To get a fractional result, at least one operand must be a
floating-point value:

``` csharp
double result = (double)7 / 3;
```

------------------------------------------------------------------------

## 4. Inputting and Outputting Numeric Values

Because a TextBox's `Text` property contains a string, numeric input
must be converted before it can be used in a numeric calculation. The
slides introduce `Parse` methods for this purpose:

``` csharp
int hoursWorked = int.Parse(hoursWorkedTextBox.Text);
double temperature = double.Parse(temperatureTextBox.Text);
decimal price = decimal.Parse(priceTextBox.Text);
```

A cast operator is not used to convert a string into a number.

To display a numeric value in a Label or TextBox, convert it to a string
with `ToString()`:

``` csharp
decimal grossPay = 1550.0m;
grossPayLabel.Text = grossPay.ToString();
```

A number can also be joined with text using `+`:

``` csharp
int idNumber = 1044;
string output = "Your ID number is " + idNumber;
```

------------------------------------------------------------------------

## 5. Formatting Numbers with `ToString()`

The `ToString()` method can format a numeric value for display. The
format string indicates how the value should appear.

  Format   Purpose              Example
  -------- -------------------- ------------------------
  `"N"`    Number format        `value.ToString("N3")`
  `"F"`    Fixed-point format   `value.ToString("F2")`
  `"E"`    Exponential format   `value.ToString("E3")`
  `"C"`    Currency format      `value.ToString("C")`
  `"P"`    Percentage format    `value.ToString("P")`

The number after the format letter specifies decimal places in examples
such as `"N3"` or `"F2"`. Currency and number appearance can depend on
the computer's regional settings.

------------------------------------------------------------------------

## 6. Simple Exception Handling

An exception is an unexpected error that occurs while a program is
running. Examples from the lecture include invalid user input, dividing
by zero, and trying to open a file that does not exist. If an exception
is not handled, the application may stop unexpectedly.

### Using `try-catch`

The `try` block contains statements that may cause an exception. If an
exception occurs, execution moves to the `catch` block, where the
program can respond.

``` csharp
try
{
    double miles = double.Parse(milesTextBox.Text);
    double gallons = double.Parse(gallonsTextBox.Text);
    double mpg = miles / gallons;

    mpgLabel.Text = mpg.ToString();
}
catch
{
    MessageBox.Show("Invalid data was entered.");
}
```

This example catches an exception from invalid numeric input and
displays a message. (Additional checks, such as ensuring gallons is not
zero, are also important for a complete calculation.)

To display the exception's message, the lecture shows catching an
`Exception` object:

``` csharp
catch (Exception ex)
{
    MessageBox.Show(ex.Message);
}
```

------------------------------------------------------------------------

## 7. Using Named Constants

A named constant is a name that represents a value that cannot be
changed during program execution. In C#, declare a constant with the
`const` keyword.

``` csharp
const double INTEREST_RATE = 0.129;
```

Using uppercase letters for constant names is a common convention, but
it is not required.

------------------------------------------------------------------------


## Summary

In Week 2, we learned how C# Windows Forms applications read user input,
store and process data, calculate results, and show output. We also
studied formatting, exception handling, constants, fields, Math methods,
GUI properties, and debugging techniques.

These topics provide a foundation for building interactive applications
that process user-provided data.
