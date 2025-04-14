## 📌 XAML Basics & UI Layout

### 🔍 Research & Learn

**1. What are the basic elements and syntax of XAML?**

- **XAML (eXtensible Application Markup Language)** is a declarative XML-based language used to define the UI of WPF applications.
- Basic syntax:

```xml
  <Button Content="Click Me" Width="100" Height="30" Click="Button_Click"/>
```

**2. How do layout panels like Grid, StackPanel, and DockPanel function?**

| **Panel Type** | **Description**                                                            |
| -------------- | -------------------------------------------------------------------------- |
| `Grid`         | Organizes content into rows and columns. Offers most flexibility.          |
| `StackPanel`   | Arranges children in a single line either vertically or horizontally.      |
| `DockPanel`    | Aligns child elements to the top, bottom, left, or right of the container. |

**3. What properties and events are commonly used with WPF controls?**

- Common properties: Margin, Padding, Width, Height, HorizontalAlignment, VerticalAlignment, FontSize, Foreground, Background.
- Common events: Click, TextChanged, Loaded, MouseEnter, SelectionChanged.

### 📝 Reflection

**1. How do different layout panels influence UI flexibility?**

- Each of the layout panels provides a different way of organizing content:

  - Grid is best suited for complex layouts.
  - StackPanel is best used for simple lists or toolbars.
  - DockPanel allows fluid positioning around the window edges.

- Choosing the right panel helps to build responsive, adaptive UIs better.

**2. What challenges might arise when building responsive UIs with XAML?**

- Misuse of fixed sizes may lead to inflexibility.
- Nested structures may become difficult to manage.
- Support for a variety of screen resolutions requires careful design with adjustable layouts, relative sizes, and alignment.

**3. How does separating UI and logic benefit application development?**

- Improves maintainability by allowing designers and developers to work independently.
- Enables reuse of UI or logic across different projects.
- Enhances testability by isolating business logic from presentation code.

### 🛠️ Task

```xml
<Window x:Class="WpfApp.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        Title="XAML Layout Demo" Height="300" Width="400">

    <Grid>
        <Grid.RowDefinitions>
            <RowDefinition Height="Auto"/>
            <RowDefinition Height="*"/>
        </Grid.RowDefinitions>

        <StackPanel Orientation="Horizontal" Margin="10">
            <TextBlock Text="Name:" VerticalAlignment="Center"/>
            <TextBox Width="200" Margin="5,0,0,0"/>
        </StackPanel>

        <DockPanel Grid.Row="1" Margin="10">
            <Button DockPanel.Dock="Top" Content="Submit" Height="30" Margin="0,0,0,5"/>
            <TextBlock Text="Welcome to XAML layout!" FontSize="16" HorizontalAlignment="Center"/>
        </DockPanel>
    </Grid>
</Window>
```
