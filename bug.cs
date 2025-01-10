public class ExampleClass
{
    public int MyProperty { get; set; }

    public ExampleClass(int value)
    {
        MyProperty = value;
    }

    public void MyMethod()
    {
        // Accessing a disposed object
        using (var context = new MyDbContext())
        {
            // ... some database operations ...
        }

        // This will throw an exception if MyDbContext is not properly disposed
        context.SaveChanges(); //This line will throw an exception
    }
}