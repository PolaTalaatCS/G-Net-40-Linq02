using G_Net_40_Linq02.Datasources;

namespace G_Net_40_Linq02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            var top = Source.ProductList.OrderByDescending(p => p.UnitPrice).Take(3);
            #endregion
        }
    }
}
