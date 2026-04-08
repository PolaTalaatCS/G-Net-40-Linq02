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
            #region Question 3
            var list3 = Source.ProductList.TakeWhile(p => p.UnitPrice < 25);
            #endregion
            #region Question 4
            var check = Source.ProductList.All(p => p.Category == "Seafood");

            #endregion
            #region Question 5
            int[] ids = { 3, 9, 13, 18 };
            var contains = ids.Contains(9);
            #endregion
        }
    }
}
