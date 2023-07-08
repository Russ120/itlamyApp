using System;

namespace itlamyApp.Web.Models
{
    public class StudentModel : PersonModel
    {
        public int Id { get; set; }
        public DateTime EnrollmentDate { get; set; }  //fecha de inscripcion

    }
}
