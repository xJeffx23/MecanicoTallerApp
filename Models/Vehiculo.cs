using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MecanicoTallerApp.Models
{
	public class Vehiculo
	{
		public int Id { get; set; }
		public string Placa { get; set; }
		public string Marca { get; set; }
		public string Modelo { get; set; }
		public int Año { get; set; }
		public double Kilometraje { get; set; }
		public string Combustible { get; set; }
	}
}
