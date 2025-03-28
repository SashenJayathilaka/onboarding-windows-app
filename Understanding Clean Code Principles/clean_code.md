# Clean Code Principles

## 1. Simplicity

**"Keep it simple, stupid (KISS)."**  
Good code should be as simple as possible while solving the problem efficiently. Avoid unnecessary complexity, convoluted logic, or over-engineered solutions.

```csharp
// Bad Example (Overcomplicated logic)
public string GetEvenOrOdd(int num)
{
    if (num % 2 == 0)
    {
        return "Even";
    }
    else if (num % 2 != 0)
    {
        return "Odd";
    }
    return "";
}

// Good Example (Simpler logic)
public string GetEvenOrOdd(int num) => num % 2 == 0 ? "Even" : "Odd";
```

---

## 2. Readability

Code should be easy to understand for both the original developer and others. This means using meaningful variable and function names, proper indentation, and avoiding unnecessary complexity.

```python
# Bad Example (Hard to read due to unclear naming)
def c(a, b):
    return a * b / 100

# Good Example (Improved readability with meaningful names)
def calculate_percentage(value, percentage):
    return value * percentage / 100
```

---

## 3. Maintainability

Code should be easy to modify and extend in the future without breaking existing functionality. This is achieved through modular design, comments where necessary, and avoiding hardcoded values.

```javascript
// Bad Example (Hardcoded values, no modularization)
let tax = 0.15;
console.log("Total price with tax: $" + (100 + 100 * tax));

// Good Example (Encapsulated in a function for maintainability)
function calculateTotalPrice(price, taxRate = 0.15) {
  return price + price * taxRate;
}
console.log(`Total price with tax: $${calculateTotalPrice(100)}`);
```

---

## 4. Consistency

Follow the same naming conventions, indentation, and structure throughout the codebase. This makes it easier for teams to collaborate and maintain the project.

```java
// Bad Example (Inconsistent naming and formatting)
public class calcTax {
    public double cT(double p, double t){
        return p+t*p;
    }
}

// Good Example (Consistent naming and formatting)
public class TaxCalculator {
    public double calculateTax(double price, double taxRate) {
        return price + (taxRate * price);
    }
}
```

---

## 5. Efficiency

Write optimized code without unnecessary computations. However, avoid premature optimization at the cost of readability.

```python
# Bad Example (Inefficient and redundant loop)
numbers = [1, 2, 3, 4, 5]
sum = 0
for i in range(len(numbers)):
    sum += numbers[i]
print(sum)

# Good Example (Uses Python’s built-in function for efficiency)
numbers = [1, 2, 3, 4, 5]
print(sum(numbers))
```

---

# Example of Messy Code

## Bad Code (Hard to Read and Maintain)

```csharp
class P {
    static void Main() {
        int[] n = { 1, 2, 3, 4, 5 };
        int s = 0;
        for (int i = 0; i < n.Length; i++) {
            s = s + n[i];
        }
        System.Console.WriteLine(s);
    }
}
```

### Issues:

- The class name (`P`) is unclear.
- The variable names (`n` and `s`) are not descriptive.
- The loop is unnecessarily verbose.

## Refactored Code (Cleaner and More Readable)

```csharp
class Program {
    static void Main() {
        int[] numbers = { 1, 2, 3, 4, 5 };
        int sum = numbers.Sum();
        Console.WriteLine($"Sum: {sum}");
    }
}
```

### Improvements:

- Meaningful class and variable names.
- Uses `.Sum()` instead of a manual loop for clarity and efficiency.
- Improved formatting and readability.
