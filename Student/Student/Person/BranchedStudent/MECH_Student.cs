using CollegePerson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Branch;

namespace CollegePerson
{
    internal class MECH_Student : Student, IMECH
    {
        String Branch { get; set; }
        double total;
        public MECH_Student(string name, int enrollmentNumber) : base(name, enrollmentNumber)
        {
            Branch="MECHANICAL";
            Mechanics = 0;
            Thermodynamics =0;
            FluidMechanics = 0;
            total = 0;
        }

        public double Mechanics { get; set; }
        public double Thermodynamics { get; set; }
        public double FluidMechanics { get; set; }
        
        public override void setMarks()
        {
            double n;
            Console.WriteLine("\n\n");
            Console.WriteLine("Enter the marks subject-wise :");
            Console.Write("Analog Electronics :");
            n = double.Parse(Console.ReadLine());
            Mechanics = n ;
           
            Console.Write("Thermodynamics :");
             n = double.Parse(Console.ReadLine());
            Thermodynamics=n;
           
            Console.Write("FluidMechanics :");
            n = double.Parse(Console.ReadLine());
            FluidMechanics=n;

        }

        public override void getMarks()
        {
            
            total = Mechanics+ Thermodynamics +FluidMechanics;
            Console.WriteLine("\n\n");
            Console.WriteLine($"{Name}'s result :  ");
            Console.WriteLine($"Mechanics : {Mechanics}");
            Console.WriteLine($"Thermodynamics : {Thermodynamics}");
            Console.WriteLine($"Fluid Mechanics : {FluidMechanics}");
            Console.WriteLine($"\n\n Total marks : {total}");
            Console.WriteLine($"\n Result :{(total>=200 ? " PASS" : " FAIL")} ");
        }
        
        
        
        public override void DisplayDetails()
        {
            Console.WriteLine($"name: {Name} \tBranch:{Branch}\tEnrollment:{Enrollment}");
        }
    }
}


