using G_Net_40_Linq02.Datasources;namespace G_Net_40_Linq02{    internal class Program    {        static void Main(string[] args)        {            #region Question 1            var top = Source.ProductList.OrderByDescending(p => p.UnitPrice).Take(3);            #endregion            #region Question 3            var list3 = Source.ProductList.TakeWhile(p => p.UnitPrice < 25);            #endregion            #region Question 4            var check = Source.ProductList.All(p => p.Category == "Seafood");            #endregion            #region Question 5            int[] ids = { 3, 9, 13, 18 };            var contains = ids.Contains(9);            #endregion            #region Question 6            var groupping = Source.ProductList.GroupBy(p => p.Category);            foreach (var group in groupping)            {                Console.WriteLine($"group : {group.Key} Count = {group.Count()}");            }            #endregion            #region Question 7            var groupping1= Source.ProductList.GroupBy(p => p.Category).Select(g => new     {         Category = g.Key,         ProductNames = g.Select(p => p.ProductName)     });


            #endregion
            #region Question 8      var result = Source.ProductList.GroupBy(p => p.Category).Where(g => g.Count() > 3);



            #endregion
            #region Question 9
            var result1 = from c in Source.CustomerList
                         group c by c.Country into countryGroup
                         select new
                         {
                             Country = countryGroup.Key,
                             Count = countryGroup.Count(),
                             TotalOrderValue = countryGroup.Sum(cust => cust.Orders.Sum(o => o.Total))
                         };
            #endregion
            #region Question 10
            var count1= Source.ProductList.Count();
            #endregion
        }    }}