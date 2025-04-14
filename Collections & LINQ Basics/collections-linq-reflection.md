# 📌 Collections & LINQ Basics

### 🔍 Research & Learn

**1. What are the common collection types in C# (e.g., List, Dictionary, Array, etc.)?**

| Collection Type            | Description                             | Example Usage                           |
| -------------------------- | --------------------------------------- | --------------------------------------- |
| `Array`                    | Fixed size, simple structure            | Storing known-length data like weekdays |
| `List<T>`                  | Dynamic array, resizable                | Most common for general-purpose data    |
| `Dictionary<TKey, TValue>` | Key-value store                         | Fast lookup by unique key               |
| `HashSet<T>`               | Unordered collection with no duplicates | Membership testing                      |
| `Queue<T>`                 | FIFO structure                          | Task scheduling                         |
| `Stack<T>`                 | LIFO structure                          | Undo/Redo functionality                 |

**2. How does LINQ simplify data queries compared to traditional loops and conditional logic?**

```csharp
var results = students.Where(s => s.Grade > 75).OrderBy(s => s.Name);
```

```csharp
List<Student> results = new List<Student>();
foreach (var s in students)
{
    if (s.Grade > 75)
        results.Add(s);
}
results.Sort((a, b) => a.Name.CompareTo(b.Name));
```

**3. What are some performance considerations when choosing a collection type?**

- Use List<T> for dynamic-sized data.
- Dictionary is faster for key-based lookup.
- Avoid LINQ in tight performance-critical loops (sometimes loops are faster).
- Be aware of deferred execution in LINQ (especially with IEnumerable).

### 📝 Reflection

### Which Collection Type Do You Find Most Useful and Why?

- `List<T>` is the most versatile for general scenarios. It allows dynamic resizing, indexing, and works well with LINQ. `Dictionary<TKey, TValue>` is best when fast key-based lookup is needed.

### How Does LINQ Improve Code Readability and Efficiency?

- LINQ allows complex queries to be written in a clear, declarative style. It avoids verbose loops and makes filtering, sorting, and projection operations much easier to understand.

### Real-World Example

- In a student grade processing tool, we previously used nested loops to filter students by grade and sort them. Switching to a LINQ-based query reduced code from 20+ lines to just 2 and made it more maintainable.

### 🛠️ Task

```csharp
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Using List<T>
        List<string> fruits = new List<string> { "apple", "banana", "kiwi", "avocado", "blueberry" };

        // LINQ: Filter fruits starting with 'a'
        var aFruits = fruits.Where(f => f.StartsWith("a")).OrderBy(f => f);

        Console.WriteLine("Fruits starting with 'a':");
        foreach (var fruit in aFruits)
            Console.WriteLine(fruit);

        // Using Dictionary<TKey, TValue>
        Dictionary<string, int> stock = new Dictionary<string, int>
        {
            {"apple", 50 },
            {"banana", 25 },
            {"kiwi", 5 },
            {"blueberry", 0 }
        };

        Console.WriteLine("\nAvailable stock > 10:");
        var inStock = stock.Where(item => item.Value > 10);
        foreach (var item in inStock)
            Console.WriteLine($"{item.Key}: {item.Value}");
    }
}
```
