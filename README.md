# C# ObjectDisposedException after using statement

This repository demonstrates a common error in C# where an ObjectDisposedException is thrown after using a using statement. The error occurs because the code attempts to access a disposed object after it has left the using block. 

## Bug Description:
The bug is in the MyMethod() method in ExampleClass.cs. A using statement is used to create and manage the lifecycle of a MyDbContext object.  After the using block, an attempt is made to call SaveChanges() on the context, which results in an ObjectDisposedException.