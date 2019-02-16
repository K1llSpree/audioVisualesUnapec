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
	public partial class FrmMantTipoEquipos : Form
	{
		public Tipos_Equipos tipoEquipo { get; set; }
		private AudiovisualesDBEntities1 entities = new AudiovisualesDBEntities1();
		public FrmMantTipoEquipos()
		{
			InitializeComponent();
		}

		private void cmdBuscar_Click(object sender, EventArgs e)
		{
			consultarPorCriterio();
		}

		private void consultarPorCriterio()
		{
			var tipoEquipos = from em in entities.Tipos_Equipos
							  where (em.ID.ToString().StartsWith(txtBuscar.Text) ||
									 em.Descripcion.StartsWith(txtBuscar.Text) ||
									 em.Estado.ToString().StartsWith(txtBuscar.Text)
									 )
							  select em;
			dgvTipoEquipo.DataSource = tipoEquipos.ToList();
		}

		private void FrmMantTipoEquipos_Load(object sender, EventArgs e)
		{
			consultarTipoEquipo();

		}
		private void consultarTipoEquipo()
		{
			dgvTipoEquipo.DataSource = entities.Tipos_Equipos.ToList();
		}

		private void cmdAgregar_Click(object sender, EventArgs e)
		{
			editarTipoEquipo fed = new editarTipoEquipo();
			fed.ShowDialog();
		}

		private void frmGestionTipoEquipo_Activated(object sender, EventArgs e)
		{
			consultarTipoEquipo();
		}
		private void dgvTipoEquipo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridViewRow row = this.dgvTipoEquipo.SelectedRows[0];
			Tipos_Equipos tipoEquipo = new Tipos_Equipos();
			tipoEquipo.ID = Int32.Parse(row.Cells[0].Value.ToString());
			tipoEquipo.Descripcion = row.Cells[1].Value.ToString();
			FrmMantTipoEquipos fed = new FrmMantTipoEquipos();
			fed.tipoEquipo = tipoEquipo;
			fed.ShowDialog();

		}
	}
}
