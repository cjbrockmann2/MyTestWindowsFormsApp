using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopitosWindowsFormsApp.Model
{
    public class Ergebnisse: Personalstamm
    {
		public float Betrag { get; set; } = 0;

		public float USt
		{
			
			get {
                return Betrag * (float) 0.19; 
			}
		}



	}
}
