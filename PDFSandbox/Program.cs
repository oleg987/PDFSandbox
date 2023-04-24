using OfficeOpenXml;
using Spire.Xls;

namespace PDFSandbox
{
    /// <summary>
    /// Class implements Singleton design pattern.
    /// Any changes in A class forbidden!
    /// </summary>
    sealed class A
    {
        private static readonly A _instance = new(); // field that hold singleton object.
        public static A Instance { get => _instance; } // property to get access to singleton object.


        private readonly Guid _id; // field with some data.
        public Guid Id { get => _id; } // readonly property with some data.
        private A() => _id = Guid.NewGuid(); // constructor.

        public override bool Equals(object? obj) // implementation of equals method.
        {
            if (obj is null || obj is not A a) throw new ArgumentException();
            return a.Id == Id;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            A? a1 = A.Instance;

            // Let`s fuck incapsulation!)
            A? a2 = null; // Create another instance of class A.

            Console.WriteLine(a1.Equals(a2)); // Console output: false
        }
    }
}