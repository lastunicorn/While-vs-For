# `while` vs `for`

## Preparation Recipe

- Create a C# Class Library project.
- Transform a `while` statement into a `for` statement.
  - Write the `while` statement that uses a counter.
  - Step 1: Change "while" into "for".
    - Talk about the structure of the `for` statement.
  - Step 2: Include the counter's initialization into the `for` statement.
  - Step 3: Include the counter's incrementation into the `for` statement.
- Show IL for both `while` and `for` statements.
  - Write again the method with the `while`. Keep the one containing the `for` previously created.
  - Compile in release mode.
  - Open the dll in ILDASM to demonstrate that the code is identical.