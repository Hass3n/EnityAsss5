


using Dfirst.Models;
using Microsoft.EntityFrameworkCore;

namespace Dfirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
           using NorthwindContext dbContext = new NorthwindContext();



            //var Result = dbContext.Categories.ToList();




            #region DQl [FromSqlraw,FromSqlInterpolated]
            //   var Result = dbContext.Categories.FromSqlRaw("select * from Categories ");


            //   // using variables

            //   int count = 3;

            //   Result = dbContext.Categories.FromSqlRaw("select top({0})* from Categories ", count);
            //   #endregion

            //   // FromSqlInterpolated

            //   Result = dbContext.Categories.FromSqlInterpolated($"select * from  Categories");


            //   // using variables

            //   Result = dbContext.Categories.FromSqlInterpolated($"select top({count})* from  Categories");







            //foreach (var Category in Result)
            //{
            //    Console.WriteLine(Category.CategoryName);

            //} 
            #endregion



            #region DML(insert ,update Delete)

            //   //ExecuteSqlRaw
            ////   int R = dbContext.Database.ExecuteSqlRaw("update Categories set CategoryName='it'  where CategoryID=3");

            //   //ExecuteSqlInterpolated

            //int  R = dbContext.Database.ExecuteSqlInterpolated($"update Categories set CategoryName='it'  where CategoryID=3");





            // Console.WriteLine(R);
            #endregion


            #region Run StoredProcedure


            // NorthwindContextProcedures northwindContextProcedures = new NorthwindContextProcedures(dbContext);

            //var Result= northwindContextProcedures.SalesByCategoryAsync("Seafood", "1998").Result;


            // foreach (var result in Result)
            // {
            //     Console.WriteLine(result);
            // }

            #endregion



            #region Local  vs Remote

            dbContext.Categories.Load();


            if (dbContext.Categories.Local.Any(c => c.CategoryId > 1))
            {
                Console.WriteLine("local yes");
            }

            else if (dbContext.Categories.Any(c => c.CategoryId > 1))
            {
                Console.WriteLine("Remote yes");

            }



            // find


            var Result = dbContext.Categories.Find(1);
            //Console.WriteLine(Result);

            #endregion

        }
    }
}
