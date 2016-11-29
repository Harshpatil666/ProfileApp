using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProfileApp
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }


        public void FullName()
        {
            FirstName + " " + LastName;
        }
    }
}