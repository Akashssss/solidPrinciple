using System;
using CollegePerson;

namespace Assesment
{



    class Program
    {


        static void Main(string[] args)
        {   

            Student s = new CSE_Student("Akash" ,101) ;
            s.DisplayDetails();
            s.setMarks();
            s.getMarks();

            Console.WriteLine("\n\n");

            // Add a ECE Student 

            s = new ECE_Student("Prakash" , 545);
            s.DisplayDetails();
            s.setMarks();
            s.getMarks();
           
        }

    }


}

