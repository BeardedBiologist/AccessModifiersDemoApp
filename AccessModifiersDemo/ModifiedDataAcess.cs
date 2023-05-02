using DemoLibrary;

// Mini project to use inheritance and interfaces

// https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/access-modifiers

namespace AccessModifiersDemo
{
    public class ModifiedDataAcess : DataAccess
    {
        public void GetUnsecureConnectionInfo()
        {
            GetConnectionString();
        }
    }

}