using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Linq;

namespace AnnotationsDemo
{
    class AnnotationsData
    {
        public static void Display()
        {
            Console.WriteLine("Employee class Validations");
            Console.WriteLine("..........................\n");
            Employee objEmployee = new Employee();
            objEmployee.Name = "prakash";
            objEmployee.Age = 24;
            objEmployee.PhoneNumber = "8499875245";
            objEmployee.Email = "abhinayprakash143@gmail.com";

            ValidationContext context = new ValidationContext(objEmployee, null ,null);
            List<ValidationResult> results = new List<ValidationResult>();
            bool valid = Validator.TryValidateObject(objEmployee, context,results,true);
            if (!valid)
            {
                foreach ( ValidationResult Totalresult in results)
                {
                    Console.WriteLine("Member Name :{0}",Totalresult.MemberNames.First(),Environment. NewLine); 
                    Console.WriteLine("Error msg : {0}{1}", Totalresult.ErrorMessage ,Environment.NewLine);


                }

            }
            else
            {
                Console.WriteLine("Name: "+objEmployee.Name + "\n" + "age :"+objEmployee.Age+ "\n"+ "phoneNumber :"+objEmployee.PhoneNumber + "\n" +"email:" + objEmployee.Email + "\n");

            }
            Console.WriteLine("\n  press any key to exit");
            Console.ReadKey();
        }
    }
}
