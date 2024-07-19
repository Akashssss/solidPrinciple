using CollegePerson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Branch;

namespace CollegePerson
{
    internal class ECE_Student : Student, IECE
    {
        String Branch { get; set; }
        double total;
        public ECE_Student(string name, int enrollmentNumber) : base(name, enrollmentNumber)
        {
            Branch="ECECTRICAL";
            AnalogElectronics = 0;
            DigitalElectronics =0;
            SignalsAndSystems = 0;
        }

        public double AnalogElectronics { get; set; }
        public double DigitalElectronics { get; set; }
        public double SignalsAndSystems { get; set; }

        public override void setMarks()
        {
            double n;
            Console.WriteLine("\n\n");
            Console.WriteLine("Enter the marks subject-wise :");
            Console.Write("Analog Electronics :");
            n = double.Parse(Console.ReadLine());
            AnalogElectronics =n;

            Console.Write("Digital Electronics :");
            n = double.Parse(Console.ReadLine());
            DigitalElectronics=n;

            Console.Write("Signals And Systems :");
            n = double.Parse(Console.ReadLine());
            SignalsAndSystems=n;

        }

        public override void getMarks()
        {
            total = AnalogElectronics+ DigitalElectronics +SignalsAndSystems;
            Console.WriteLine("\n\n");
            Console.WriteLine($"{Name}'s result :  ");
            Console.WriteLine($"Analog Electronics : {AnalogElectronics}");
            Console.WriteLine($"Digital Electronics : {DigitalElectronics}");
            Console.WriteLine($"Signals And Systems : {SignalsAndSystems}");
            Console.WriteLine($"\n Total marks : {total}");
            Console.WriteLine($"\n Result :{(total>=200 ? " PASS" : " FAIL")} ");

        }
        public override void DisplayDetails()
        {
            Console.WriteLine($"name: {Name} \tBranch:{Branch}\tEnrollment:{Enrollment}");
        }

    }
}

