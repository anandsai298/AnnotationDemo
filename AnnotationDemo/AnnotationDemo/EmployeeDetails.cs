using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnotationDemo
{
    public class EmployeeDetails
    {
        [Required(ErrorMessage ="Employee {0} is Required")]
        [StringLength(100,MinimumLength =3,ErrorMessage ="Name should be min 3 char and a max 100 char")]
        [DataType(DataType.Text)]
        public string Name { get; set; }
        [Range(18,99,ErrorMessage ="Age should be above 18")]
        public string Age { get; set; }
        [DataType(DataType.PhoneNumber)]
        [Phone]
        public string PhoneNumber { get; set; }
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string EmailID { get; set; }
    }
}
