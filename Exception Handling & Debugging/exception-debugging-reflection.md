## 📌 Exception Handling & Debugging

### 🔍 Research & Learn

**1. What are the best practices for exception handling in C#?**

- Catch only the exceptions you can handle.
- Prefer particular exception types instead of a plain `Exception`.
- Avoid using empty catch blocks.
- Log exception details for diagnostics.
- Avoid the use of exceptions for ordinary control flow.
- Throw exceptions when necessary using `throw;` to preserve stack trace.

**2. How do try-catch-finally blocks work, and when should you use them?**

- `try`: Code that might throw an exception.
- `catch`: Code that handles the exception.
- `finally`: Code that runs regardless of whether an exception was thrown or caught (e.g., releasing a resource).
- Use them close to dangerous operations like file I/O, database queries, or calls to an external API.

**3. What debugging tools in Visual Studio help diagnose runtime issues?**

- Breakpoints (including data and conditional breakpoints).
- Watch window and Locals window.
- Immediate Window for evaluating code in real-time.
- Method Call Tracing window called "Call Stack.".
- Exception Settings to break when given exceptions are thrown.

### 📝 Reflection

**1. Reflect on a time when proper exception handling prevented a major issue.**

- At one point, a file uploader prevented the application from crashing as a user tried to upload an invalid file with exception handling enabled. The `catch` block printed an error and displayed a nice error message instead of annihilating the UI

**2. What debugging techniques did you find most effective?**

- Walking through each line of code using breakpoints.
- Variable values observed in the Watch window.
- Placing exception breakpoints to trap unhandled exceptions without delay.

**3. How can you improve error logging and reporting in your code?**

- Utilizing structured logging (such as with `Serilog` or `NLog`).
- Add context information to logs (user ID, operation name, timestamps).
- Send critical errors to a logging server or monitoring system (e.g., Sentry, Application Insights).

### 🛠️ Task

```csharp
using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Attempting risky operation...");
            int result = 10 / int.Parse("0"); // Will trigger DivideByZeroException
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Caught exception: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Finally block: Clean-up operations.");
        }
    }
}
```
