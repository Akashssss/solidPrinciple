using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branch
{    
	// CSE interface
	public interface ICSE {
	    double CompilerDesign { get; set; }
		double ComputerArchitecture { get; set; }
		double Aptitude { get; set; } 
		double softwareEngineering { get; set; }

	}

    // ECE interface
    public interface IECE {

        
        double AnalogElectronics { get; set; }
		double DigitalElectronics { get; set; }
		double SignalsAndSystems { get; set; }
	}


	//MECH interface
	public interface IMECH {
	
	double Mechanics { get; set; } 
	double Thermodynamics { get; set; } 
	double FluidMechanics { get; set; } 
	
	}

}
