public class ExampleClass
{
    public int MyProperty { get; set; }

    public ExampleClass(int value)
    {
        MyProperty = value;
    }

    public void MyMethod()
    {
        // Correct way to access the object within the using block
        using (var context = new MyDbContext())
        {
            // ... some database operations ...
            context.SaveChanges();
        }
    }
}