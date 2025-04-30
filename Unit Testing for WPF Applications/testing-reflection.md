# 📌 Unit Testing for WPF Applications

---

## 🔍 Research & Learn

### ✅ Unit Testing vs UI Testing in WPF

- **Unit Testing**:
  - Tests individual pieces of logic (typically in the ViewModel or Model).
  - Fast, isolated, easy to run repeatedly.
  - Focuses on business logic and data processing.
- **UI Testing**:
  - Tests the user interface as a whole, including interaction behavior.
  - Slower, dependent on system state.
  - Tools include UI Automation frameworks like **Appium**, **White**, or **WinAppDriver**.

### ✅ Commonly Used Tools

- **Unit Testing Frameworks**:
  - MSTest
  - NUnit
  - xUnit
- **UI Automation Tools**:
  - **WinAppDriver** (by Microsoft)
  - **White** (open source)
  - **TestStack.White** for legacy support
  - **Selenium** (for web but not WPF)
- **Mocking Tools**:
  - Moq
  - NSubstitute

### ✅ Designing Effective Tests

- Start with unit tests on the ViewModel layer.
- Write tests for both typical usage and edge cases.
- Mock dependencies (e.g., services, data access).
- Keep UI logic out of code-behind to enable testability.

---

## 📝 Reflection

### 💡 How does implementing tests improve your development process?

Testing forces a clear separation of concerns and encourages writing testable code. It reduces the likelihood of regressions and provides a safety net during refactoring. It also improves confidence when adding new features or fixing bugs.

### 💡 Trade-offs Between Unit and UI Tests

| Unit Tests                      | UI Tests                          |
| ------------------------------- | --------------------------------- |
| Easy to write and maintain      | Harder to set up                  |
| Fast and reliable               | Slow and more brittle             |
| Don’t verify actual UI behavior | Simulate real user interactions   |
| Focus on logic, not rendering   | Validate end-to-end functionality |

A good strategy is to use unit tests heavily and write a minimal number of UI tests to cover key user flows.

### 💡 Strategies for WPF Testing Challenges

- Use **MVVM** pattern to push all logic into ViewModel for testability.
- Avoid logic in code-behind files.
- Mock data services and navigation in ViewModel unit tests.
- Use UI testing tools sparingly to avoid flakiness.

---

## 🛠️ Task – Sample Implementation

### 🧪 Project: Simple Calculator WPF App

- **Functionality**: A ViewModel that adds two numbers.
- **Tools**:
  - MSTest for unit tests.
  - Moq for mocking (not needed in this simple example).
