using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MecanicoTallerApp.Models
{
	public class Trabajo
	{

		public int Id { get; set; }
		public int OrdenTrabajoId { get; set; }
		public string TipoTrabajo { get; set; }
		public string Descripcion { get; set; }
		public DateTime FechaInicio { get; set; }
		public DateTime HoraInicio { get; set; }
		public decimal Monto { get; set; }
		public string Comentarios { get; set; }
		public bool TrabajoFinalizado { get; set; }

		public OrdenTrabajo OrdenTrabajo { get; set; }
	}
}
