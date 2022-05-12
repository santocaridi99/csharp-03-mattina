namespace csharp_es03_mattina
{
    internal class Pencil
    {
        static int total = 0;
        internal static int Add(int value)
        {
            total = total + value;
            return total;
        }
    }
}