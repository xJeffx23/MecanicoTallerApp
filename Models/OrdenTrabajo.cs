using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MecanicoTallerApp.Models
{
	public class OrdenTrabajo
	{
		public int Id { get; set; }
		public string NumeroOrden { get; set; }
		public string CodigoCliente { get; set; }
		public string NombreCliente { get; set; }
		public string PlacaVehiculo { get; set; }
		public double KilometrajeVehiculo { get; set; }
		public string CantidadCombustible { get; set; }
		public bool OrdenVigente { get; set; }
		public DateTime FechaInicio { get; set; }
		public DateTime HoraInicio { get; set; }
		public decimal Monto { get; set; }
		public string Comentarios { get; set; }
		public bool TrabajoFinalizado { get; set; }

		public ICollection<Trabajo> Trabajos { get; set; }
		public ICollection<Repuesto> Repuestos { get; set; }
		public ICollection<ServicioExterno> ServiciosExternos { get; set; }
		public ICollection<Gasto> Gastos { get; set; }
	}
}
