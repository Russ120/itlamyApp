using System;

namespace itlamyApp.Web.Models
{
    public class InstructorModel : PersonModel
    {
        public int Id { get; set; }
        public DateTime HireDate { get; set; }
    }
}
