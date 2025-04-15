# 📌 Styling & Templating

---

### 🔍 Research & Learn

**1. What are the differences between styling and templating in WPF?**

| Concept      | Description                                                                                                                     |
| ------------ | ------------------------------------------------------------------------------------------------------------------------------- |
| **Style**    | A set of property values that can be reused across multiple controls. Similar to CSS in web development.                        |
| **Template** | Defines the **visual structure and behavior** of a control. Useful when you want to completely redesign a control’s appearance. |

**2. How do you define and apply styles and control templates?**

**Style Example:**

```xml
<Window.Resources>
    <Style TargetType="Button">
        <Setter Property="Background" Value="LightBlue" />
        <Setter Property="FontSize" Value="16" />
        <Setter Property="Margin" Value="10" />
    </Style>
</Window.Resources>
```

```xml

<ControlTemplate x:Key="CustomButtonTemplate" TargetType="Button">
    <Border Background="{TemplateBinding Background}" CornerRadius="10" BorderBrush="Black" BorderThickness="2">
        <ContentPresenter HorizontalAlignment="Center" VerticalAlignment="Center"/>
    </Border>
</ControlTemplate>

<Style TargetType="Button">
    <Setter Property="Template" Value="{StaticResource CustomButtonTemplate}" />
</Style>

```

**3. What are best practices for designing reusable and adaptive UI elements?**

- Define styles in App.xaml or separate resource dictionaries.
- Use DynamicResource for theme switching.
- Use BasedOn to create hierarchical styles.
- Leverage DataTriggers and VisualStateManager for interactivity.

---

---

### 📝 Reflection

**1. How can using styles enforce consistency across your application?**

- Using styles means that all controls follow a centralized visual guideline. This improves:

  - Visual coherence across screens.
  - Ease of updating UI in one place.
  - Readability of the XAML files.

**2. Reflect on the benefits and challenges of using control templates.**

- Benefits:

  - Full control over UI rendering.
  - Encourages UI innovation without affecting logic.
  - Great for branding and accessibility.

- Challenges:

  - Can be verbose.
  - Requires deeper understanding of the control's visual structure.
  - Debugging templated visuals can be tricky without tools like Live Visual Tree in Visual Studio.

**3. How might templating improve the maintainability of your UI?**

- Templates abstract presentation, making it easy to:

  - Apply a new visual identity without rewriting business logic.
  - Share templates across multiple projects.
  - Adapt UI for different devices or platforms.

---

---

### 🛠️ Task

#### 🧪 Experiments

- Changed CornerRadius from 8 to 20 → observed a pill-like button shape.
- Swapped Background to LinearGradientBrush → added a modern effect.
- Added Trigger to change color on IsPressed → improved interactivity.

---
