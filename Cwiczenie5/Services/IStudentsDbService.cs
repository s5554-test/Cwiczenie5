using Cwiczenie5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cwiczenie5.Controllers;
using Cwiczenie5.DTOs.Requests;
using Cwiczenie5.DTOs.Responses;

namespace Cwiczenie5.Services
{
    public interface IStudentsDbService
    {
        IEnumerable<Student> GetStudents();
        IEnumerable<EnrollStudentResponse> EnrollStudent(EnrollStudentRequest r);
        IEnumerable<EnrollStudentResponse> PromoteStudents(int semester, string studiesname);



    }
}
