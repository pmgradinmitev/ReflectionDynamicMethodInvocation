using System.Reflection;

namespace ReflectionDynamicMethodInvocation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            // Get type information
            Type type = typeof(Calculator);

            // Get the method info for "Add"
            MethodInfo method = type.GetMethod("Add");

            // Invoke the method dynamically
            object result = method.Invoke(calculator, new object[] { 5, 3 });

            Console.WriteLine($"Result: {result}"); // Output: Result: 8
        }
    }
}
