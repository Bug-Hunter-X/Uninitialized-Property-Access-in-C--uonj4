public class ExampleClass
{
    public int MyProperty { get; set; }

    // Constructor to initialize the property
    public ExampleClass()
    {
        MyProperty = 0; // Initialize MyProperty to a default value
    }

    public void MyMethod()
    {
        int value = MyProperty; // Now safe to access MyProperty
        Console.WriteLine(value);
    }
}