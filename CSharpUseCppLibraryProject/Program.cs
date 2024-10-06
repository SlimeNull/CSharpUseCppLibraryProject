using System.Runtime.InteropServices;

namespace CSharpUseCppLibraryProject
{
    internal class Program
    {
        [DllImport("TestDll")]
        static extern int Plus(int a, int b);

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
