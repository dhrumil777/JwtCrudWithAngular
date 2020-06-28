using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPP.Models
{
    public class EmployeeVM
    {

        //Here we need to find the steps of how we can put json object into C# model class this will help us to save the time
          //Step 1:

        public int EmployeeId { get; set; }

        public string EmployeeName { get; set; }

        //Deperment name should be in comma separated 
        public string DepartmentName { get; set; }
    }
}