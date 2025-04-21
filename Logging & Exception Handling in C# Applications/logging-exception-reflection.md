# 📌 Logging & Exception Handling in C# Applications

## 🎯 Goal

Understand and implement best practices for logging and exception handling in C# to improve application reliability and maintainability.

---

## 🔍 Research & Learn

### ✅ Best Practices for Logging in C#

- Use established logging frameworks like **Serilog**, **NLog**, or **log4net**.
- Log meaningful information (timestamp, severity, message, context).
- Avoid logging sensitive data.
- Use different log levels (`Debug`, `Info`, `Warning`, `Error`, `Fatal`) appropriately.
- Configure logs to be output to multiple sinks (e.g., console, file, database, external services).
- Enable structured logging (e.g., JSON format) to support automated parsing and analysis.

### ✅ Handling Exceptions and Logging Them

- Use `try-catch-finally` blocks where necessary, especially around risky operations (I/O, network).
- Avoid catching general exceptions (`catch (Exception)`) unless rethrowing or logging properly.
- Always log exceptions with:
  - Stack trace
  - Method name
  - Custom context (e.g., user ID, input params)
- Prefer throwing specific exception types and avoid swallowing exceptions.

### ✅ Common Patterns in Production Code

- Global exception handlers (e.g., in `AppDomain` or `Middleware` for web apps).
- Logging uncaught exceptions.
- Using fallback logic or graceful degradation where possible.
- Retrying transient failures (with caution).

---

## 📝 Reflection

### 💡 How does effective logging contribute to faster troubleshooting and improved code quality?

Logging provides visibility into the internal workings of an application. During debugging or production monitoring, logs allow developers to trace the flow of execution and quickly identify issues. It helps spot patterns, rare bugs, and usage behavior that aren’t visible through testing alone.

### 💡 Reflect on the impact of exception handling on application stability and user trust.

Proper exception handling prevents application crashes and allows users to continue working or receive helpful error messages. It builds user trust by ensuring that failures are managed gracefully instead of resulting in unhandled crashes or data loss.

### 💡 Strategies to Enhance Logging in a Complex App

- Use correlation IDs for tracking requests across systems.
- Create reusable logging utilities to reduce code repetition.
- Separate log files by severity or component.
- Integrate with external log aggregators like **Seq**, **Elastic Stack**, or **Application Insights**.
- Regularly review logs to fine-tune log verbosity and relevance.

---

## 🛠️ Task – Sample Implementation

### 📦 Tools Used

- Framework: **Serilog**
- Output: Console + Rolling File

### 🔧 Sample Code

```csharp
using System;
using Serilog;

class Program
{
    static void Main(string[] args)
    {
        Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Debug()
            .WriteTo.Console()
            .WriteTo.File("logs/app_log.txt", rollingInterval: RollingInterval.Day)
            .CreateLogger();

        try
        {
            Log.Information("Application started.");
            SimulateWork();
        }
        catch (Exception ex)
        {
            Log.Error(ex, "An unhandled exception occurred");
        }
        finally
        {
            Log.Information("Application exiting.");
            Log.CloseAndFlush();
        }
    }

    static void SimulateWork()
    {
        Log.Debug("Simulating work...");
        throw new InvalidOperationException("Something went wrong!");
    }
}
```
