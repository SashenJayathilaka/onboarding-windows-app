# 📌 Identifying & Fixing Code Smells

## 🎯 Goal

Learn how to recognize common code smells and refactor them for better readability, maintainability, and performance.

---

## ✅ Tasks & Code Smells

### 🔸 1. Magic Numbers & Strings

**❌ Bad Example:**

```csharp
double discount = price * 0.15;
```

**✅ Refactored:**

```csharp
const double DISCOUNT_RATE = 0.15;
double discount = price * DISCOUNT_RATE;
```

---

### 🔸 2. Long Functions

**❌ Bad Example:**

```csharp
public void RegisterUser(User user)
{
    if (string.IsNullOrEmpty(user.Email) || string.IsNullOrEmpty(user.Password))
    {
        Console.WriteLine("Missing info");
        return;
    }

    bool isValidEmail = user.Email.Contains("@");
    if (!isValidEmail)
    {
        Console.WriteLine("Invalid email");
        return;
    }

    // Save user to database
    SaveToDatabase(user);

    // Send email
    SendConfirmationEmail(user.Email);
}
```

**✅ Refactored:**

```csharp
public bool IsUserValid(User user)
{
    return !string.IsNullOrEmpty(user.Email) && !string.IsNullOrEmpty(user.Password) && user.Email.Contains("@");
}

public void RegisterUser(User user)
{
    if (!IsUserValid(user))
    {
        Console.WriteLine("Missing or invalid info");
        return;
    }

    SaveToDatabase(user);
    SendConfirmationEmail(user.Email);
}
```

---

### 🔸 3. Duplicate Code

**❌ Bad Example:**

```csharp
Console.WriteLine(user.FirstName + " " + user.LastName);
Console.WriteLine(admin.FirstName + " " + admin.LastName);
```

**✅ Refactored:**

```csharp
public string GetFullName(Person person)
{
    return person.FirstName + " " + person.LastName;
}

Console.WriteLine(GetFullName(user));
Console.WriteLine(GetFullName(admin));
```

---

### 🔸 4. Large Classes (God Objects)

**❌ Bad Example:**

```csharp
public class AppManager
{
    public void Login() { }
    public void Logout() { }
    public void RenderUI() { }
    public void FetchData() { }
    public void SaveData() { }
}
```

**✅ Refactored:**

```csharp
public class AuthService
{
    public void Login() { }
    public void Logout() { }
}

public class UIService
{
    public void RenderUI() { }
}

public class DataService
{
    public void FetchData() { }
    public void SaveData() { }
}
```

---

### 🔸 5. Deeply Nested Conditionals

**❌ Bad Example:**

```csharp
if (user != null)
{
    if (user.IsActive)
    {
        if (user.Role == "admin")
        {
            AllowAccess();
        }
    }
}
```

**✅ Refactored:**

```csharp
if (user?.IsActive == true && user.Role == "admin")
{
    AllowAccess();
}
```

---

### 🔸 6. Commented-Out Code

**❌ Bad Example:**

```csharp
// var temp = CalculateTemp();
// Console.WriteLine(temp);
```

**✅ Refactored:**
❌ Remove commented-out code if it's not necessary. If needed, version control systems keep track of previous versions.

---

### 🔸 7. Inconsistent Naming

**❌ Bad Example:**

```csharp
int x = 5;
string y = "John";
bool z = true;
```

**✅ Refactored:**

```csharp
int userAge = 5;
string userName = "John";
bool isActive = true;
```

---

## 🧠 Reflections

### 💎 What code smells did you find in your code?

- I found magic numbers, long functions doing too much, duplicate logic, classes with too many responsibilities, nested conditionals, commented-out code, and variable names that were not descriptive.

### 💎 How did refactoring improve the readability and maintainability of the code?

- Refactoring not only made the code easier to read by breaking down lengthy functions into shorter, more manageable functions, but it also made it easier to maintain by organizing responsibilities into various classes and removing redundant code.

### 💎 How does avoiding code smells simplify future debugging?

- By avoiding code smells, we maintain a clean codebase that is easier to understand. It is easier to debug because we can locate the problem easily, understand the logic, and make the necessary changes without side effects.
