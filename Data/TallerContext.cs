using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MecanicoTallerApp.Models;


namespace MecanicoTallerApp.Data
{

	public class TallerContext : DbContext
	{
		public DbSet<OrdenTrabajo> OrdenesTrabajo { get; set; }
		public DbSet<Trabajo> Trabajos { get; set; }
		public DbSet<Repuesto> Repuestos { get; set; }
		public DbSet<ServicioExterno> ServiciosExternos { get; set; }
		public DbSet<Gasto> Gastos { get; set; }
		public DbSet<Vehiculo> Vehiculos { get; set; }
		public DbSet<Cliente> Clientes { get; set; }

		public TallerContext(DbContextOptions<TallerContext> options) : base(options)
		{
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!optionsBuilder.IsConfigured)
			{
				optionsBuilder.UseSqlite("Data Source=taller.db");
			}
		}
	}
}

