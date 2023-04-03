using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnotationDemo
{
    public class AnnotationTest
    {
        public static void Display()
        {
            Console.WriteLine("Employee class validation");
            Console.WriteLine("---------------------\n");
            EmployeeDetails employeeDetails = new EmployeeDetails();
            employeeDetails.Name = "Ask";
            employeeDetails.Age = "24";
            employeeDetails.PhoneNumber = "9299999769";
            employeeDetails.EmailID = "anand298@gmail.com";
            ValidationContext context = new ValidationContext(employeeDetails, null, null);
            List<ValidationResult> Results = new List<ValidationResult>();
            bool valid = Validator.TryValidateObject(employeeDetails, context, Results, true);
            //fiels are not valid
            if (valid != true)
            {
                foreach (ValidationResult result in Results)
                {
                    Console.WriteLine("EmployeeName :{0}", result.MemberNames.First(), Environment.NewLine);
                    Console.WriteLine("EmployeeName :{0}{1}", result.ErrorMessage, Environment.NewLine);//0-->field,1-->errormsg
                }
            }
            else
            {
                Console.WriteLine("Name-->" + employeeDetails.Name + "\n" + "Age-->" + employeeDetails.Age + "\n" + "Phonenumber-->" + employeeDetails.PhoneNumber+"\n"+"emailid--->" + employeeDetails.EmailID);
            }
            Console.WriteLine("\nPress any key to exit");
            Console.ReadKey();
        }
    }
}
