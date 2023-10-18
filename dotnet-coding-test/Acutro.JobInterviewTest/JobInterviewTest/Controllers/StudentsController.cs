using Microsoft.AspNetCore.Mvc;

/*
 * Tasks:
 * 
 * 1. Create an endpoint to return a list of students
 *    a. Modify the endpoint so that we can filter by name, grade
 *    b. Add ability to page the results
 *    c. Add ability to sort results
 *    d. Include all of the enrollments, course and grades with the student records
 * 2. Create an endpoint to add an Enrollment to a student
 * 3. Discuss how you would go about creating automated tests
 * 4. Discuss how you would add security
 * 5. Take a look at the Models.
 *    a. How would we fix the warnings?
 *    b. How would you set max length contraints on fields, apply migrations, etc
 */

namespace JobInterviewTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentsController : ControllerBase
    {
       
    }
}