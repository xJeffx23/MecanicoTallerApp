using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MecanicoTallerApp.Models
{
	public class Repuesto
	{
		public int Id { get; set; }
		public int OrdenTrabajoId { get; set; }
		public string Nombre { get; set; }
		public int Cantidad { get; set; }
		public decimal Precio { get; set; }

		public OrdenTrabajo OrdenTrabajo { get; set; }
	}
}
