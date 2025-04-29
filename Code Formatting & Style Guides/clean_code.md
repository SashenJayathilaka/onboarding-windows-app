# Clean Code Reflections

## Why is Code Formatting Important?

- Improves readability and maintainability.
- Helps teams collaborate efficiently.
- Reduces errors and makes debugging easier.
- Enforces a standard coding convention.

## What Issues Did the Linter Detect?

- Unused variables.
- Incorrect indentation.
- Missing semicolons.
- Console statements flagged as warnings.

## Did Formatting Make the Code Easier to Read?

Yes, the formatted code is more structured, has consistent spacing, and follows a uniform style, making it easier to read and debug.

# Clean Code Reflection

## Why is Code Formatting Important?

- Improves readability and maintainability.
- Helps teams collaborate efficiently with consistent code style.
- Reduces errors and makes debugging faster.
- Enforces a standard coding convention across the codebase.

## What Issues Did ESLint/Prettier Detect?

## What Issues Did ESLint/Prettier Detect?

| Line      | Issue                                                                       |
| :-------- | :-------------------------------------------------------------------------- |
| 7         | Missing XML documentation for public method `GetUserInfo()`.                |
| 17        | `tempData` is declared but never used.                                      |
| 26        | Incorrect indentation — should be 4 spaces, but 2 spaces used.              |
| 30        | Unnecessary empty line inside `CalculateTotal()`.                           |
| 24, 25    | Opening brace `{` should be on a new line according to common C# standards. |
| 36 and 43 | `Console.WriteLine` used — recommend structured logging instead.            |

## Did Formatting Make the Code Easier to Read?

Yes! After formatting:

- Functions were properly spaced out.
- Nested code blocks were correctly indented.
- Redundant empty lines were removed.
- Overall, it made debugging and understanding the logic much smoother.

## Commit Hash

`49cb0d5`

## Screenshot

![Image](https://github.com/user-attachments/assets/0ba71b49-a0f4-434a-be39-804170ec026b)
