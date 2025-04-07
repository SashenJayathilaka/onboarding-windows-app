# 🧼 Clean Code Principles

Writing clean code isn't just about making things work — it's about making them _understandable_, _maintainable_, and _efficient_ for everyone, including future you.

---

## 1. **Simplicity**

> **"Keep it simple, stupid (KISS)."**  
> Good code solves problems with minimal complexity. Avoid overengineering or convoluted logic.

```csharp
// ❌ Overcomplicated
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

// ✅ Simplified
public string GetEvenOrOdd(int num) => num % 2 == 0 ? "Even" : "Odd";
```

---

## 2. **Readability**

Code should clearly communicate its intent. Use descriptive names, proper indentation, and straightforward logic.

```python
# ❌ Unclear naming
def c(a, b):
    return a * b / 100

# ✅ Clear and descriptive
def calculate_percentage(value, percentage):
    return value * percentage / 100
```

---

## 3. **Maintainability**

Make your code easy to update and extend. Avoid magic numbers, use functions, and keep things modular.

```javascript
// ❌ Hardcoded logic, not reusable
let tax = 0.15;
console.log("Total price with tax: $" + (100 + 100 * tax));

// ✅ Modular and maintainable
function calculateTotalPrice(price, taxRate = 0.15) {
  return price + price * taxRate;
}
console.log(`Total price with tax: $${calculateTotalPrice(100)}`);
```

---

## 4. **Consistency**

Stick to consistent naming, formatting, and structure throughout your codebase. This improves collaboration and reduces bugs.

```java
// ❌ Inconsistent style and unclear names
public class calcTax {
    public double cT(double p, double t){
        return p+t*p;
    }
}

// ✅ Consistent naming and style
public class TaxCalculator {
    public double calculateTax(double price, double taxRate) {
        return price + (taxRate * price);
    }
}
```

---

## 5. **Efficiency**

Write optimized code where it matters, but don't sacrifice readability for premature optimization.

```python
# ❌ Verbose and inefficient
numbers = [1, 2, 3, 4, 5]
sum = 0
for i in range(len(numbers)):
    sum += numbers[i]
print(sum)

# ✅ Clean and efficient
numbers = [1, 2, 3, 4, 5]
print(sum(numbers))
```

---

## 🧩 Example of Messy vs Clean Code

### ❌ Messy Code

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

**Problems:**

- Class and variable names are unclear (`P`, `n`, `s`)
- Verbose loop logic
- Lacks clarity and intention

---

### ✅ Refactored Code

```csharp
class Program {
    static void Main() {
        int[] numbers = { 1, 2, 3, 4, 5 };
        int sum = numbers.Sum();
        Console.WriteLine($"Sum: {sum}");
    }
}
```

**Improvements:**

- Clear class and variable names
- Uses `Sum()` for brevity and clarity
- Easier to read and maintain

---

## 📌 Final Thoughts

Clean code isn’t just about writing for compilers — it’s about writing for **humans**. Simplicity, clarity, and consistency are the cornerstones of sustainable development.

> _“Any fool can write code that a computer can understand. Good programmers write code that humans can understand.”_ – Martin Fowler
