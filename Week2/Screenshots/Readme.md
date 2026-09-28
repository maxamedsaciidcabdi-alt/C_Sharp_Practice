# C# Calculation Examples – Average Score, MPG and Constants

Four short C# (Windows Forms) snippets:

1. Calculating the **average of three test scores** with error handling
2. Calculating **miles per gallon (MPG)**
3. Displaying the MPG result
4. Declaring a **constant** interest rate

---

## 1. Average of three test scores (`try` / `catch`)

```csharp
try
{
    //Declaring Variable to store input user
    double test1, test2, test3, Average;

    //Get the three test scores
    test1 = double.Parse(txttest1.Text);
    test2 = double.Parse(txttest2.Text);
    test3 = double.Parse(txttest3.Text);

    //Calculate The Average test scors
    Average = (test1 + test2 + test3) / 3;
    // Display the average test score, with
    // the output rounded to 1 decimal point
    lblaverage.Text = Average.ToString("n1");
}
catch (Exception ex)
{
    // Display the default error message.
    MessageBox.Show(ex.Message);
}
```

*(The right edge of the screenshot is cropped, so the ends of the comments above are reconstructed.)*

### Step by step

| Step | Code | Explanation |
|---|---|---|
| Declare variables | `double test1, test2, test3, Average;` | Four `double` variables hold the three scores and the result. `double` allows decimal values. |
| Read input | `double.Parse(txttest1.Text)` | Converts the text typed in each `TextBox` into a number. |
| Calculate | `(test1 + test2 + test3) / 3` | Adds the scores and divides by 3. The parentheses make sure the addition happens first. |
| Display | `Average.ToString("n1")` | Converts the number to text using the **number format with 1 decimal place** (e.g. `85.6667` becomes `85.7`). |
| Show on form | `lblaverage.Text = ...` | Puts the formatted text into the label. |

### Why `try` / `catch`?

`double.Parse` throws an exception if the text cannot be converted, for example when the box is empty (`FormatException`) or contains letters. Without protection the program would crash.

- The code that might fail goes in the `try` block.
- If an error occurs, execution jumps to the `catch` block.
- `ex.Message` is the built-in error text, and `MessageBox.Show(...)` shows it in a pop-up.

---

## 2. Calculating MPG

```csharp
double miles = double.Parse(milesTextBox.Text);
double gallons = double.Parse(gallonsTextBox.Text);
double mpg = miles / gallons;
```

- Reads the miles driven and the gallons of fuel used from two text boxes.
- `mpg = miles / gallons` gives the miles per gallon.
- Example: `300 miles / 12 gallons = 25 mpg`.

**Things to watch**

- If `gallons` is `0`, a `double` division does **not** throw an exception. The result is `Infinity` (or `NaN` for `0/0`), so check for `gallons > 0` first.
- Invalid text still throws a `FormatException`, so this code should also sit inside a `try` / `catch` (as in section 1).

---

## 3. Displaying the MPG

```csharp
mpgLabel.Text = mpg.ToString();
```

- `ToString()` converts the number to text, because a label's `Text` property only accepts a string.
- Without a format, a value like `27.3333333333` is shown in full. To limit it to 1 decimal place, use `mpg.ToString("n1")` as in section 1.

---

## 4. Constant interest rate

```csharp
const double INTEREST_RATE = 0.129;
```

- `const` makes the value fixed. It cannot be changed later in the program, and trying to do so causes a compile error.
- `0.129` is the decimal form of **12.9%**.
- `UPPER_CASE` names are a common convention for constants.
- Use a constant instead of typing `0.129` in several places. If the rate changes, you edit one line.

Example use:

```csharp
double interest = balance * INTEREST_RATE;
```

---

## Suggested improvements

- Use `double.TryParse` instead of `double.Parse` to validate input without exceptions:
  ```csharp
  if (double.TryParse(gallonsTextBox.Text, out double gallons) && gallons > 0)
  {
      mpgLabel.Text = (miles / gallons).ToString("n1");
  }
  else
  {
      MessageBox.Show("Please enter a valid number of gallons greater than 0.");
  }
  ```
- Use `camelCase` for local variables (`average` instead of `Average`).
- Catch specific exceptions (e.g. `FormatException`) when you want more helpful messages.

## Requirements

- Visual Studio
- .NET Windows Forms App
- Language: C#
