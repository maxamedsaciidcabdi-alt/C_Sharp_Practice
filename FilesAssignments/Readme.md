## How it works

- **Create File:** `File.CreateText("Home.doc")` creates the file and returns a `StreamWriter`. `WriteLine()` writes text; `Close()` closes the writer.
- **Read File:** `File.ReadLines("Home.doc")` supplies the lines one by one to the `foreach` loop.
- **Delete File:** `File.Delete("Home.doc")` removes the file.
- **Clear File Contents:** `File.WriteAllText("Home.doc", string.Empty)` empties the file but keeps it.

## Important notes

- `StreamWriter` writes text. `StreamReader` reads text.
- Although the filename ends in `.doc`, the content written by this example is plain text, not a formatted Microsoft Word document.
- The relative path `"Home.doc"` means the file is created in the application's current working directory, which can vary when running from Visual Studio.
- Double-click each button in the Designer to create its Click event and connect it to the matching method.
