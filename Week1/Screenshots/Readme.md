# Full Date Builder – C# Windows Forms

A small Windows Forms (C#) example that takes date parts typed by the user, joins them into one full-date string, and shows it in a label. It also has **Clear** and **Close** buttons.

## Overview

The form has:

| Control | Name | Purpose |
|---|---|---|
| TextBox | `txtdayoftheweek` | Day of the week (e.g. `Monday`) |
| TextBox | `txtmonth` | Name of the month (e.g. `September`) |
| TextBox | `txtnumericofmonth` | Day number of the month (e.g. `28`) |
| TextBox | `txtyear` | Year (e.g. `2026`) |
| Label | `lbloutput` | Displays the final combined date |
| Button | `btnClear` | Clears all inputs and the output |
| Button | `btnClose` | Closes the form |

The code is organised in **stages**: get the input, concatenate, then output.

---

## Stage 2 – Concatenation of the full date

```csharp
// stage process concatenation of full date
Fulldate = day_of_the_week + "," + Name_of_the_month + "," + NumericDay + "," + Year;
```

**What it does**

- Joins four string values into a single string called `Fulldate`.
- The `+` operator concatenates strings.
- `","` is a literal separator placed between each part.

**Example**

| Variable | Value |
|---|---|
| `day_of_the_week` | `Monday` |
| `Name_of_the_month` | `September` |
| `NumericDay` | `28` |
| `Year` | `2026` |

Result: `Monday,September,28,2026`

> **Tip:** `Fulldate` must be declared earlier (e.g. `string Fulldate;`). The four source variables are normally filled from the textboxes, for example `day_of_the_week = txtdayoftheweek.Text;`.

---

## Stage 3 – The output

```csharp
//Stage 3 : The output

lbloutput.Text = Fulldate;
```

**What it does**

- Assigns the combined string to the `Text` property of the label `lbloutput`.
- The user immediately sees the full date on the form.

---

## Clear button

```csharp
private void btnClear_Click(object sender, EventArgs e)
{
    // clearing textbox
    txtdayoftheweek.Clear();
    txtmonth.Clear();
    txtnumericofmonth.Clear();
    txtyear.Clear();

    // clearing label - not used function
    lbloutput.Text = "";
    //lbloutput.Text = string.Empty;
}
```

**What it does**

- `btnClear_Click` is the event handler that runs when the Clear button is clicked.
  - `object sender` – the control that raised the event (the button).
  - `EventArgs e` – extra event data (unused here).
- `.Clear()` removes all text from each `TextBox`.
- A `Label` has no `Clear()` method, so its text is reset by assigning an empty string:
  - `lbloutput.Text = "";`
  - `lbloutput.Text = string.Empty;` is equivalent (it is commented out in the code as an alternative).

---

## Close button

```csharp
private void btnClose_Click(object sender, EventArgs e)
{
    // form close - using this keyword and close function
    this.Close();
}
```

**What it does**

- `this` refers to the current form.
- `Close()` closes the form. If it is the main form, the application exits.

---

## Program flow

```
User types day, month, date number, year
                │
                ▼
Stage 2: Fulldate = day + "," + month + "," + number + "," + year
                │
                ▼
Stage 3: lbloutput.Text = Fulldate   →  shown on screen
                │
        ┌───────┴────────┐
        ▼                ▼
   Clear button     Close button
   (reset inputs)   (this.Close())
```



s
