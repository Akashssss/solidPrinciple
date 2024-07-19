using CollegePerson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Branch;

namespace CollegePerson
{
    internal class CSE_Student : Student, ICSE
    {
         String Branch {  get; set; }
        double total;
        public CSE_Student(string name, int enrollmentNumber) : base(name, enrollmentNumber)
        {
            Branch="COMPUTER_SCIENCE";
            total = 0;
            CompilerDesign = 0;
            ComputerArchitecture =0;
            Aptitude = 0;
            softwareEngineering = 0;
        }

        public double CompilerDesign  { get; set ; }
        public double ComputerArchitecture { get ; set ; }
        public double Aptitude { get ; set ; }
        public double softwareEngineering { get; set; }

        public override void  setMarks()
        {
            double n;
            Console.WriteLine("\n\n");
            Console.WriteLine("Enter the marks subject-wise :");
            Console.Write("Compiler Design :");
            n = double.Parse(Console.ReadLine());
            CompilerDesign= n;
            Console.Write("Computer Architecture :");
            n = double.Parse(Console.ReadLine());
            ComputerArchitecture =n ;
           
            Console.Write("Aptitude :");
            n = double.Parse(Console.ReadLine());
            Aptitude = n ;
            
            Console.Write("Software Engineering :");
            n = double.Parse(Console.ReadLine());
            softwareEngineering =n ;
        } 

        public override void getMarks()
        {   
            total = CompilerDesign+ComputerArchitecture+ Aptitude +softwareEngineering;
            Console.WriteLine("\n\n");
            Console.WriteLine($"{Name}'s result :  ");
            Console.WriteLine($"Computer Architecture : {ComputerArchitecture}");
            Console.WriteLine($"Compiler Design : {CompilerDesign}");
            Console.WriteLine($"Aptitude : {Aptitude}");
            Console.WriteLine($"Software Engineering : {softwareEngineering}");
            Console.WriteLine($"\n Total marks : {total}");
            Console.WriteLine($"\n Result :{(total>=300 ?" PASS":" FAIL")} ");
        }
        public override void DisplayDetails()
        {
            Console.WriteLine($"name: {Name} \tBranch:{Branch}\tEnrollment:{Enrollment}");
        }
    }
}
