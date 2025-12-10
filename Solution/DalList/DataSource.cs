

using DO;

namespace Dal;

internal static class DataSource
{
    internal static List<Customer> customers = new();
    internal static List<Sale> Sales = new();
    internal static List<Product> Products = new();

    internal static class Config
    {
        internal const int start = 0;
        private static int id = start;
        public static int GetId()
        {
            return id++;
        }
    }
}
