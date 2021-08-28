using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AnnotationsDemo
{
  public  class Employee
    {
        [Required(ErrorMessage="Employee {0} is required")]
        [StringLength(100,MinimumLength=3,ErrorMessage="Name Should be 3 Characters And Maximum Of 100 Characters")]
        [DataType(DataType.Text)]
        public string Name { get; set; }
        [Range(18,99 ,ErrorMessage="Age Should be Above 18")]
        public int Age { get; set; }
        [DataType(DataType.PhoneNumber)]
        [Phone]
        public string PhoneNumber { get; set; }
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email{ get; set; }


    }
}
