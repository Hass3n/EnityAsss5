using EnityAsss5.Context;
using EntityFwAsss4.Entities;

namespace EnityAsss5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            using ComapnySuDatabase dbcontext = new ComapnySuDatabase();

            #region   query syntax  inner join


            //var Result = from E in dbcontext.Employees
            //             join D in dbcontext.departments
            //             on E.workDeparmentsId equals D.DepartmentId
            //             where E.Salary>2000

            //             select new
            //             {

            //                 DeptName = D.DeptName,
            //                 EmployeeName = E.EmployeeName,
            //             };


            #endregion


            #region fluent syntax inner join


            //var Result = dbcontext.Employees.Join(dbcontext.departments, E => E.workDeparmentsId, d => d.DepartmentId,

            //    (E, D) => new
            //    {

            //        Department = D,
            //        Employee = E,
            //        salary = E.Salary
            //    }



            //).Where(E => E.salary > 2000);


            #endregion


            #region Left join  fluent syntax


            //var Result = dbcontext.departments.GroupJoin(dbcontext.Employees, D => D.DepartmentId, E => E.workDeparmentsId,


            //    (D, E) => new
            //    {

            //        Department = D,
            //        Employee = E
            //    }


            //    );

            #endregion

            #region Left join Query syntax

            //var Result = from D in dbcontext.departments
            //             join E in dbcontext.Employees
            //             on D.DepartmentId equals E.workDeparmentsId
            //             into G
            //             select new
            //             {
            //                 Department = D,
            //                 Employee = G
            //             };



            #endregion


            #region Croos join  Query syntax


            //var Result = from E in dbcontext.Employees
            //             from D in dbcontext.departments
            //             select new
            //             {
            //                 DeptName = D.DeptName,
            //                 empName = E.EmployeeName
            //             };

            #endregion

            #region croos join  fluent syntax

            //var Result = dbcontext.Employees.SelectMany(

            //    E => dbcontext.departments.Select(D => new
            //    {
            //         EmpName=E.EmployeeName,
            //         DeptName=D.DeptName

            //    })
            //    );
            #endregion

        }
    }
}
