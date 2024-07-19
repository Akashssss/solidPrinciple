using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CollegePerson
{
    public  class Student : Person
    {
    
        //constructor for student
        public Student(string name, int enrollmentNumber )
        {
            Name = name;
            Enrollment = enrollmentNumber;
    
        }
        public  override void DisplayDetails()
        {
            Console.WriteLine($"name: {Name} \nEnrollment:{Enrollment}");
        }
        public virtual void getMarks()
        {
            Console.WriteLine("Not implemented yet .");
        }
        public virtual void setMarks()
        {
            Console.WriteLine("Not implemented yet .");
        }     
    }
}
