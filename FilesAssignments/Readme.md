## How each button and function works

### 1. Create File

- `StreamWriter outputfile;` declares a variable that can write text to a file.
- `File.CreateText("Home.doc")` creates `Home.doc` and returns a `StreamWriter` to write into it. If the file already exists, its previous contents are overwritten.
- `outputfile.WriteLine(...)` writes text followed by a new line.
- `outputfile.Close()` closes the file after writing.

### 2. Read File

This button reads the file one line at a time and displays each line in the ListBox.

- `File.Exists("Home.doc")` checks whether the file exists. If it does not, the message is shown and `return` stops the method.
- `lstFileContents.Items.Clear()` removes old items from the ListBox before showing the new results.
- `StreamReader inputfile = File.OpenText("Home.doc")` opens the file for reading.
- `inputfile.ReadLine()` reads the next line. It returns `null` when there are no more lines to read.
- `bool endStream = false;` creates a Boolean variable to track whether the end of the file has been reached.
- `while (endStream == false)` repeats the loop until `endStream` becomes `true`.
- `if (line == null)` detects the end of the file and changes `endStream` to `true`.
- `lstFileContents.Items.Add(line)` adds each actual line to the ListBox.
- `inputfile.Close()` closes the file after reading.

**About `File.ReadLines()`:** `File.ReadLines("Home.doc")` is another .NET method that provides the file's lines as a sequence, often used with `foreach`. The current project instead uses `StreamReader` with `ReadLine()` inside a `while` loop, as requested. `ReadLine()` and `ReadLines()` are different methods.

### 3. Delete File

- `File.Exists("Home.doc")` checks that the file is present before trying to delete it.
- `File.Delete("Home.doc")` deletes the file itself.
- `lstFileContents.Items.Clear()` clears the displayed lines from the ListBox.
- The success message confirms the operation.

### 4. Clear File Contents

- `File.WriteAllText("Home.doc", string.Empty)` writes an empty string to the file, removing all its text while keeping the file itself.
- `lstFileContents.Items.Clear()` removes the old displayed lines from the ListBox.
- This is different from deleting the file: after clearing, `Home.doc` still exists but is empty.

## Important terms

| Term | Meaning |
|---|---|
| `StreamWriter` | A class used to write text to a file. |
| `StreamReader` | A class used to read text from a file. |
| `File.CreateText()` | Creates a text file for writing; overwrites it if it already exists. |
| `File.OpenText()` | Opens a text file for reading. |
| `ReadLine()` | Reads one line and returns `null` when no more lines remain. |
| `File.Delete()` | Deletes the file. |
| `File.WriteAllText()` | Writes text to a file, replacing its previous contents. |
| `string.Empty` | An empty string, containing no characters. |
| `File.Exists()` | Checks whether the specified file exists. |

