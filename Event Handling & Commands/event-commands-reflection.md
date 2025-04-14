## 📌 Event Handling & Commands

---

### 🔍 Research & Learn

**1. How does WPF handle events, and what are the differences between routed events and standard events?**

| Event Type      | Description                                                         |
| --------------- | ------------------------------------------------------------------- |
| Standard Event  | Traditional C# event, handled directly on the control.              |
| Bubbling Event  | Propagates from the child to the parent (e.g., `Button.Click`).     |
| Tunneling Event | Propagates from the parent to the child (e.g., `PreviewMouseDown`). |

---

**2. What are commands in WPF, and how do they integrate with the MVVM pattern?**

- Commands are **actions** that can be called from the UI, usually with bindings. Common in the **MVVM pattern**, they decouple logic from the UI, making reuse and testing possible.
  - Pre-built commands like `ApplicationCommands.Copy` or your own with the `ICommand` interface are common.

**3. How does the ICommand interface facilitate the binding of commands to UI elements?**

- The `ICommand` interface defines two methods and one event:

```csharp
public interface ICommand
{
    event EventHandler CanExecuteChanged;
    bool CanExecute(object parameter);
    void Execute(object parameter);
}
```

### 📝 Reflection

**1. How does using commands improve the maintainability of your code compared to direct event handling?**

- Commands allow putting logic into the ViewModel rather than in code-behind, facilitating improved separation of concerns, easier testing, and cleaner UI code.

**2. Reflect on scenarios where commands are more beneficial than event handlers.**

- Commands are ideal for:

  - Reusable behavior (e.g., Save, Delete).
  - Centralizing logic for multiple UI triggers.
  - MVVM designs where UI must not refer to code-behind.

**3. What challenges might you encounter when implementing commands in WPF?**

- Forgetting to raise CanExecuteChanged when needed.
- Slope of initial learning with ICommand.
- Silent failures can be triggered by CommandParameter type mismatches.

### 🛠️ Task

#### ✅ Step 1: Standard Event Handler Example

MainWindow.xaml:

```xml
<Window x:Class="EventDemo.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        Title="Event Demo" Height="150" Width="300">
    <StackPanel Margin="10">
        <Button Content="Click Me" Click="Button_Click"/>
        <TextBlock x:Name="txtOutput" Margin="10"/>
    </StackPanel>
</Window>
```

MainWindow.xaml.cs:

```csharp
private void Button_Click(object sender, RoutedEventArgs e)
{
    txtOutput.Text = "Button clicked via standard event!";
}
```

#### ✅ Step 2: Refactored with Command (MVVM)

MainWindow.xaml:

```xml
<Window x:Class="CommandDemo.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:local="clr-namespace:CommandDemo"
        Title="Command Demo" Height="150" Width="300">
    <Window.DataContext>
        <local:MainViewModel />
    </Window.DataContext>
    <StackPanel Margin="10">
        <Button Content="Click Me (Command)" Command="{Binding ClickCommand}" />
        <TextBlock Text="{Binding Message}" Margin="10"/>
    </StackPanel>
</Window>
```

MainViewModel.cs:

```csharp
using System.ComponentModel;
using System.Windows.Input;

public class MainViewModel : INotifyPropertyChanged
{
    private string message;
    public string Message
    {
        get => message;
        set { message = value; OnPropertyChanged(nameof(Message)); }
    }

    public ICommand ClickCommand { get; }

    public MainViewModel()
    {
        ClickCommand = new RelayCommand(_ => Message = "Button clicked via command!");
    }

    public event PropertyChangedEventHandler PropertyChanged;
    protected void OnPropertyChanged(string propName) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
}
```

RelayCommand.cs:

```csharp
using System;
using System.Windows.Input;

public class RelayCommand : ICommand
{
    private readonly Action<object> _execute;
    private readonly Func<object, bool> _canExecute;

    public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
    {
        _execute = execute;
        _canExecute = canExecute;
    }

    public bool CanExecute(object parameter) =>
        _canExecute == null || _canExecute(parameter);

    public void Execute(object parameter) =>
        _execute(parameter);

    public event EventHandler CanExecuteChanged
    {
        add { CommandManager.RequerySuggested += value; }
        remove { CommandManager.RequerySuggested -= value; }
    }
}
```

#### 🔚 Conclusion

- They assist in decoupling logic from the UI and fit well with MVVM. Event handlers may be quicker to implement for immediate actions, but commands better support scalability and maintainability for actual applications.
