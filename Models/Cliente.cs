using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MecanicoTallerApp.Models
{
	public class Cliente
	{
		public int Id { get; set; }
		public string CodigoCliente { get; set; }
		public string NombreCompleto { get; set; }
		public string Direccion { get; set; }
		public string Telefono { get; set; }
		public string Email { get; set; }
	}
}
