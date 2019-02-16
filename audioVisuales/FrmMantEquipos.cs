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
	public partial class FrmMantEquipos : Form
	{
		private AudiovisualesDBEntities1 entities = new AudiovisualesDBEntities1();
		public Equipos Equipo{ get; set; }
		public FrmMantEquipos()
		{
			InitializeComponent();
		}

		private void FrmMantEquipos_Load(object sender, EventArgs e)
		{
			consultarEquipos();

		}
		private void consultarEquipos()
		{
			dgvResultados.DataSource = entities.Equipos.ToList();
		}

		private void dgvResultados_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridViewRow row = this.dgvResultados.SelectedRows[0];
			Equipos Equipo = new Equipos();
			Equipo.ID = Int32.Parse(row.Cells[0].Value.ToString());
			Equipo.Descripcion = row.Cells[1].Value.ToString();
			Equipo.NSerial = row.Cells[2].Value.ToString();
			Equipo.ServiceTag = (row.Cells[3].Value.ToString());
			Equipo.MarcaID = Int32.Parse(row.Cells[4].Value.ToString());
			Equipo.ModeloID = Int32.Parse(row.Cells[5].Value.ToString());
			Equipo.TCID = Int32.Parse(row.Cells[6].Value.ToString());
			FrmMantEquipos fed = new FrmMantEquipos();
			fed.Equipo = Equipo;
			fed.Show();
			dgvResultados.Refresh();
		}

		private void cmdBuscar_Click(object sender, EventArgs e)
		{
			consultarPorCriterio();
		}

		private void cmdAgregar_Click(object sender, EventArgs e)
		{
			FrmeditarEmpleado cr = new FrmeditarEmpleado();
			cr.ShowDialog();
		}
		private void consultarPorCriterio()
		{
			var Equipo = from em in entities.Equipos
						 where (em.ID.ToString().StartsWith(txtBuscar.Text) ||
								em.Descripcion.ToString().StartsWith(txtBuscar.Text) ||
								em.NSerial.ToString().StartsWith(txtBuscar.Text) ||
								em.ServiceTag.ToString().StartsWith(txtBuscar.Text) ||
								em.TipoEquipoID.ToString().StartsWith(txtBuscar.Text) ||
								em.MarcaID.ToString().StartsWith(txtBuscar.Text) ||
								em.ModeloID.ToString().StartsWith(txtBuscar.Text) ||
								em.TCID.ToString().StartsWith(txtBuscar.Text)
							   )
						 select em;
			dgvResultados.DataSource = Equipo.ToList();
		}
	}
}
