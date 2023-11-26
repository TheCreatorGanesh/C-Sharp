using Microsoft.EntityFrameworkCore;

namespace WebAPI.Models
{
    public class DummyWebAPIContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx

        public DummyWebAPIContext() : base()
        {

            if (Employees.Count() == 0)
            {
                Employees.Add(new Employee() { ID = 1, FirstName = "Pranaya", LastName = "Rout", Salary = 60000, Gender = "Male", Created = DateTime.Now });
                Employees.Add(new Employee() { ID = 2, FirstName = "Anurag", LastName = "Mohanty", Salary = 45000, Gender = "Male", Created = DateTime.Now });
                Employees.Add(new Employee() { ID = 3, FirstName = "Preety", LastName = "Tiwari", Salary = 45000, Gender = "Female", Created = DateTime.Now });
                Employees.Add(new Employee() { ID = 4, FirstName = "Sambit", LastName = "Mohanty", Salary = 70000, Gender = "Male", Created = DateTime.Now });
                Employees.Add(new Employee() { ID = 5, FirstName = "Shushanta", LastName = "Jena", Salary = 45000, Gender = "Male", Created = DateTime.Now });
            }
        }

        public DbSet<WebAPI.Models.Employee> Employees { get; set; }
    }
}
