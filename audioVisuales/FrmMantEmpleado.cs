using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace audioVisuales
{

	public partial class FrmMantEmpleado : Form
	{
		private AudiovisualesDBEntities1 entities = new AudiovisualesDBEntities1();
		public Empleados Empleado { get; set; }
		public FrmMantEmpleado()
		{
			InitializeComponent();
		}

		private void FrmMantEmpleado_Load(object sender, EventArgs e)
		{
			consultarEmpleado();

		}
		private void FrmMantEmpleado_Activated(object sender, EventArgs e)
		{
			consultarEmpleado();
		}
		private void cmdBuscar_Click(object sender, EventArgs e)
		{
			consultarPorCriterio();
		}

		private void cmdAgregar_Click(object sender, EventArgs e)
		{
			FrmeditarEmpleado frm = new FrmeditarEmpleado();
			frm.ShowDialog();
		}
		private void consultarEmpleado()
		{
			dgvResultados.DataSource = entities.Empleados.ToList();

		}
		private void consultarPorCriterio()
		{
			var Empleado = from em in entities.Empleados
						   where (em.ID.ToString().StartsWith(txtBuscar.Text) ||
								  em.Nombre.ToString().StartsWith(txtBuscar.Text) ||
								  em.Tanda_Labor.ToString().StartsWith(txtBuscar.Text) ||
								 em.Fecha_Ingreso.ToString().StartsWith(txtBuscar.Text) ||
								 em.Estado.ToString().StartsWith(txtBuscar.Text) ||
								 em.Renta_Dev.Any(x => x.FechaPrestamo.ToString().StartsWith(txtBuscar.Text))
								)
						  select em;
			dgvResultados.DataSource = Empleado.ToList();
		}
	}
}
