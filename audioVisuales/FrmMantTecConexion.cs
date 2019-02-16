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
	public partial class FrmMantTecConexion : Form
	{
		private AudiovisualesDBEntities1 entities = new AudiovisualesDBEntities1();
		public Tecnologia_Conexion Conexion { get; set; }
		public FrmMantTecConexion()
		{
			InitializeComponent();
		}
		private void FrmMantTecConexion_Activated(object sender, EventArgs e)
		{
			consultarConexion();
		}

		private void consultarConexion()
		{
			dgvResultados.DataSource = entities.Tecnologia_Conexion.ToList();
		}
		private void consultarPorCriterio()
		{
			var Conexion = from em in entities.Tecnologia_Conexion

						 where (em.ID.ToString().StartsWith(txtBuscar.Text) ||
								em.Descripcion.ToString().StartsWith(txtBuscar.Text) ||
								em.Estado.ToString().StartsWith(txtBuscar.Text) ||
								em.Equipos.ToString().StartsWith(txtBuscar.Text)
							   )
						 select em;
			dgvResultados.DataSource = Conexion.ToList();
		}

		private void dgvResultados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridViewRow row = this.dgvResultados.SelectedRows[0];
			Tecnologia_Conexion Conexion = new Tecnologia_Conexion();
			Conexion.ID = Int32.Parse(row.Cells[0].Value.ToString());
			Conexion.Descripcion = row.Cells[1].Value.ToString();
			Conexion.Estado = row.Cells[2].Value.ToString();
			FrmMantTecConexion fed = new FrmMantTecConexion();
			fed.Conexion = Conexion ;
			fed.Show();
		}
		private void FrmMantTecConexion_Load(object sender, EventArgs e)
		{

			consultarConexion();

		}




		private void cmdAgregar_Click(object sender, EventArgs e)
		{
			FrmCrTecConcs frm = new FrmCrTecConcs();
			frm.ShowDialog();
		}

		private void cmdBuscar_Click(object sender, EventArgs e)
		{
			consultarPorCriterio();
		}
	}
}

