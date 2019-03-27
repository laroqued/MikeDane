using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectMethods
{
    class Student
    {
        //create attributes
        public string name;
        public string major;
        public double gpa;


        //Constructor
        public Student(string name, string major, double gpa)
        {
            this.name = name ;
            this.major = major;
            this.gpa = gpa;
        }
        public bool HasHonor()
        {
            if (gpa >= 3.5)
            {
                return true;
            }
            return false;
        }

    }
}
