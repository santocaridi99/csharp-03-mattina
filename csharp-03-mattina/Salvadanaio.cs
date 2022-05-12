namespace csharp_es03_mattina
{
    internal class Bank
    {
        int total;
        internal int Add(int value)
        {
            total += value;
            return total;
        }

        public Bank()
        {
            total = 0;
        }
    }
}