using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class EmployeesController : ControllerBase
    {
        [HttpGet(Name = "GetAllEmployee")]
        public IEnumerable<Employee> Get()
        {
            using DummyWebAPIContext dbContext = new DummyWebAPIContext();
            return dbContext.Employees.ToList();
        }

        [HttpGet("/api/[controller]/{id}", Name = "GetEmployeeById")]
        public Employee Get(int id)
        {
            using DummyWebAPIContext dbContext = new DummyWebAPIContext();
            return dbContext.Employees.FirstOrDefault(e => e.ID == id);
        }


        // PUT: api/Employees/5
        //[ResponseType(typeof(void))]
        [HttpPut(Name = "UpdateEmployeeUsingId")]
        public IActionResult PutEmployee(int id, Employee employee)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != employee.ID)
            {
                return BadRequest("Ids doesnot match");
            }
            using (DummyWebAPIContext dbContext = new DummyWebAPIContext())
            {
                //dbContext.Entry(employee).State = EntityState.Modified;
                //dbContext.Employees.Attach(employee);
                Employee e = dbContext.Employees.Find(id);
                e.Created = DateTime.Now;
                Employee ee = new Employee();
                //ee = e.MemberwiseClone();
                e.Created = DateTime.Now;
                //employee.Created = DateTime.Now;

                try
                {
                    dbContext.SaveChanges();
                }
                catch (DbUpdateConcurrencyException ex)
                {
                    return BadRequest(ex.ToString());
                }

                return Ok(ee);//dbContext.Employees.Find(id)); //StatusCode(HttpStatusCode.NoContent);
            }
        }

    }
    //public class EmployeesController : ApiController
    //{
    //    private DummyWebAPIContext db = new DummyWebAPIContext();

    //    // GET: api/Employees
    //    public IEnumerable<Employee> GetEmployees()
    //    {
    //        return db.Employees.ToList();
    //    }

    //    // GET: api/Employees/5
    //    [ResponseType(typeof(Employee))]
    //    public IHttpActionResult GetEmployee(int id)
    //    {
    //        Employee employee = db.Employees.Find(id);
    //        if (employee == null)
    //        {
    //            return NotFound();
    //        }

    //        return Ok(employee);
    //    }

    //    // POST: api/Employees
    //    [ResponseType(typeof(Employee))]
    //    public IHttpActionResult PostEmployee(Employee employee)
    //    {
    //        if (!ModelState.IsValid)
    //        {
    //            return BadRequest(ModelState);
    //        }
    //        employee.Created = DateTime.Now;
    //        db.Employees.Add(employee);
    //        db.SaveChanges();

    //        return CreatedAtRoute("DefaultApi", new { id = employee.ID }, employee);
    //    }

    //    // PUT: api/Employees/5
    //    [ResponseType(typeof(void))]
    //    public IHttpActionResult PutEmployee(int id, Employee employee)
    //    {
    //        if (!ModelState.IsValid)
    //        {
    //            return BadRequest(ModelState);
    //        }

    //        if (id != employee.ID)
    //        {
    //            return BadRequest();
    //        }

    //        db.Entry(employee).State = EntityState.Modified;

    //        try
    //        {
    //            db.SaveChanges();
    //        }
    //        catch (DbUpdateConcurrencyException)
    //        {
    //            if (!EmployeeExists(id))
    //            {
    //                return NotFound();
    //            }
    //            else
    //            {
    //                throw;
    //            }
    //        }

    //        return StatusCode(HttpStatusCode.NoContent);
    //    }

    //    // DELETE: api/Employees/5
    //    [ResponseType(typeof(Employee))]
    //    public IHttpActionResult DeleteEmployee(int id)
    //    {
    //        Employee employee = db.Employees.Find(id);
    //        if (employee == null)
    //        {
    //            return NotFound();
    //        }

    //        db.Employees.Remove(employee);
    //        db.SaveChanges();

    //        return Ok(employee);
    //    }

    //    protected override void Dispose(bool disposing)
    //    {
    //        if (disposing)
    //        {
    //            db.Dispose();
    //        }
    //        base.Dispose(disposing);
    //    }

    //    private bool EmployeeExists(int id)
    //    {
    //        return db.Employees.Count(e => e.ID == id) > 0;
    //    }
    //}
}
