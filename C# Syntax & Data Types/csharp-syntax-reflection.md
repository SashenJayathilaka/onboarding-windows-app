# 📌 C# Syntax & Data Types

## 🔍 Research & Learn

**1. What are the primary data types in C# (e.g., int, string, bool, etc.)?**

- **In C#, data types are divided into two main categories: Value Types and Reference Types. Here are some of the most common ones:**

  - int: Represents integers (whole numbers).
  - string: Represents a sequence of characters (text).
  - bool: Represents a Boolean value (true or false).
  - double: Represents a double-precision floating-point number.
  - char: Represents a single character.
  - decimal: Represents high-precision decimal numbers.

**2. How do variables, constants, and operators function in C#?**

- Variables: Used to store data values. The value of a variable can change throughout the program

```csharp
int number = 10;
string name = "John";
```

- Constants: Represent values that do not change once assigned. Defined using the const keyword.

```csharp
const double Pi = 3.14;
```

- Operators: Used to perform operations on variables and values. Common operators include:

  - Arithmetic: +, -, \*, /
  - Comparison: ==, !=, >, <
  - Logical: &&, ||, !

**3. What are the common pitfalls with type conversions in C#?**

- Implicit and Explicit Conversions: C# allows implicit conversions (from smaller to larger types) but explicit conversions (casting) are needed for larger to smaller types.

```csharp
int x = 10;
double y = x;
double pi = 3.14;
int roundedPi = (int)pi;
```

- Overflow and Loss of Precision: Be careful when casting between numeric types, as data loss or overflow might occur (e.g., from double to int).

## 📝 Reflection

**1. Which aspects of C# syntax were new or surprising?**

- Type Safety in C# guarantees that variables are always given particular types, making runtime errors less likely.
- Implicit vs Explicit Casting: It is necessary to understand when automatic type conversion is possible and when explicit casting is needed.

**2. How do data types influence performance and memory management in your code?**

- Value Types (e.g., int, double) are put on the stack, which is quicker but limited in size.
- Reference Types (e.g., string, objects) are stored on the heap, and while more flexible, consume more memory management overhead.

**3. What practices can help avoid common type-related errors?**

- Always use explicit casting when casting from types that can potentially lose data (e.g., from double to int).
- Be cautious of type inference (using var), as it can cause surprising types.

## 🛠️ Task

**1. Write a simple C# program that demonstrates the use of at least three different data types and basic operators.**

```csharp
using System;

class Program
{
    static void Main()
    {
        int number = 10;
        double price = 99.99;
        string name = "Alice";
        bool isValid = true;

        double total = price * number;
        Console.WriteLine("Total Price: " + total);

        double discount = 0.1;
        double discountedPrice = total - (total * discount);
        Console.WriteLine("Discounted Price: " + discountedPrice);

        int roundedPrice = (int)discountedPrice;
        Console.WriteLine("Rounded Price: " + roundedPrice);

        if (isValid && number > 5)
        {
            Console.WriteLine(name + " has a valid order!");
        }
        else
        {
            Console.WriteLine(name + " has an invalid order.");
        }
    }
}

```

**2. Experiment with type conversions and document your observations.**

- Implicit int to double conversion worked automatically when calculating the total.
- Explicit casting was required when converting the double discounted price to an int in order to remove the decimal points.
- Logical operators come in handy when making decisions in code, such as checking whether conditions are true.
