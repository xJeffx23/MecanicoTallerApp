using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MecanicoTallerApp.Models
{
	public class Gasto
	{
		public int Id { get; set; }
		public int OrdenTrabajoId { get; set; }
		public string Descripcion { get; set; }
		public decimal Monto { get; set; }

		public OrdenTrabajo OrdenTrabajo { get; set; }
	}
}
