using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Overriding
{
	class ArmorSuite
    {
		public virtual void Initialize()
        {
			Console.WriteLine("Armored");
        }
    }
	class IronMan : ArmorSuite
    {
		new public void Initialize()
        {
			base.Initialize();
			Console.WriteLine("Repulsor Rays Armed");
        }
    }
	class WarMachine : ArmorSuite 
	{
		new public void Initialize()
		{
			base.Initialize();
			Console.WriteLine("Double-Barrel Cannons Armed");
			Console.WriteLine("Micro-Rocket Launcher Armed");
        }

	} 

	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Creating ArmorSuite...");
			ArmorSuite armorsuite = new ArmorSuite();
			armorsuite.Initialize();

			Console.WriteLine("\nCreating IronMan...");
			IronMan ironman = new IronMan();
			ironman.Initialize();

			Console.WriteLine("\nCreating WarMaching...");
			WarMachine warMachine = new WarMachine();
			warMachine.Initialize();
		}
	}

	
}

