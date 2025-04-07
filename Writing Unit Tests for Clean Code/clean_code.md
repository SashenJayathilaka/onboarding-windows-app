# Clean Code Principles

## 1. Simplicity

"Keep it simple, stupid (KISS)."  
Good code should be as simple as possible while solving the problem efficiently.

```javascript
function getEvenOrOdd(num) {
  if (num % 2 === 0) {
    return "Even";
  } else if (num % 2 !== 0) {
    return "Odd";
  }
  return "";
}

const getEvenOrOdd = (num) => (num % 2 === 0 ? "Even" : "Odd");
```

---

## 2. Readability

Use meaningful names, proper indentation, and avoid convoluted logic.

```javascript
function c(a, b) {
  return (a * b) / 100;
}

function calculatePercentage(value, percentage) {
  return (value * percentage) / 100;
}
```

---

## 3. Maintainability

Code should be modular and easy to update without breaking.

```javascript
let tax = 0.15;
console.log("Total with tax: $" + (100 + 100 * tax));

// Good
function calculateTotalPrice(price, taxRate = 0.15) {
  return price + price * taxRate;
}
console.log(`Total with tax: $${calculateTotalPrice(100)}`);
```

---

## 4. Consistency

Follow consistent naming and formatting.

```javascript
class calcTax {
  cT(p, t) {
    return p + t * p;
  }
}

class TaxCalculator {
  calculateTax(price, taxRate) {
    return price + price * taxRate;
  }
}
```

---

## 5. Efficiency

Use built-in methods and avoid unnecessary computation.

```javascript
const numbers = [1, 2, 3, 4, 5];
let sum = 0;
for (let i = 0; i < numbers.length; i++) {
  sum += numbers[i];
}
console.log(sum);

const numbers = [1, 2, 3, 4, 5];
console.log(numbers.reduce((acc, num) => acc + num, 0));
```

---

# ✅ Writing Unit Tests for Clean Code

## 🎯 Goal

Learn how writing unit tests helps maintain clean and reliable code.

---

## 🔍 Function to Test

```javascript
function calculateDiscountedPrice(price, discountPercent) {
  if (price < 0 || discountPercent < 0 || discountPercent > 100) {
    throw new Error("Invalid input");
  }
  return price - (price * discountPercent) / 100;
}

module.exports = { calculateDiscountedPrice };
```

---

## 🧪 Unit Tests using Jest

```javascript
const { calculateDiscountedPrice } = require("./utils");

test("calculates 20% discount on $100", () => {
  expect(calculateDiscountedPrice(100, 20)).toBe(80);
});

test("calculates 0% discount", () => {
  expect(calculateDiscountedPrice(200, 0)).toBe(200);
});

test("throws error for negative price", () => {
  expect(() => calculateDiscountedPrice(-50, 10)).toThrow("Invalid input");
});

test("throws error for discount over 100%", () => {
  expect(() => calculateDiscountedPrice(100, 110)).toThrow("Invalid input");
});
```

---

## 🧠 Reflections

### 🔹 How do unit tests help keep code clean?

Unit tests help detect bugs early, improve design through modularity, and ensure that future changes don't break existing functionality. They enforce discipline in writing testable, readable, and reliable code.

### 🔹 What issues did you find while testing?

Initially, the function did not handle edge cases like negative prices or discount percentages greater than 100%. Writing tests made these shortcomings visible, prompting an update in the function logic to handle invalid inputs properly.

---
