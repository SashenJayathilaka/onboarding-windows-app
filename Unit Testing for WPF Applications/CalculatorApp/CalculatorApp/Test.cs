// In CalculatorApp project
public class CalculatorViewModel
{
    public int NumberA { get; set; }
    public int NumberB { get; set; }
    public int Result { get; private set; }

    public void Add()
    {
        Result = NumberA + NumberB;
    }
}
