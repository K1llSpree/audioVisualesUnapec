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
	public partial class FrmMantUsuario : Form
	{
		private AudiovisualesDBEntities1 entities = new AudiovisualesDBEntities1();
		public Usuarios Usuario { get; set; }
		public FrmMantUsuario()
		{
			InitializeComponent();
		}
		private void FrmMantUsuario_Activated(object sender, EventArgs e)
		{
			consultarUsuario();
		}
		private void cmdBuscar_Click(object sender, EventArgs e)
		{
			consultarPorCriterio();
		}



		private void cmdAgregar_Click(object sender, EventArgs e)
		{
			FrmeditarUsuario frm = new FrmeditarUsuario();
			frm.ShowDialog();
		}

		private void FrmMantUsuario_Load(object sender, EventArgs e)
		{
			consultarUsuario();
		}

		private void consultarPorCriterio()
		{
			var Usuario = from em in entities.Usuarios
						 where (em.nombre.ToString().StartsWith(txtBuscar.Text) ||
								em.NumCarnet.ToString().StartsWith(txtBuscar.Text) ||
								em.TipoUsuario.ToString().StartsWith(txtBuscar.Text) ||
								em.TipoPersona.ToString().StartsWith(txtBuscar.Text) ||
								em.Estado.ToString().StartsWith(txtBuscar.Text) ||
								em.Renta_Dev.ToString().StartsWith(txtBuscar.Text)
							   )
						 select em;
			dgvResultados.DataSource = Usuario.ToList();
		}
		private void consultarUsuario()
		{
			dgvResultados.DataSource = entities.Usuarios.ToList();

		}

		private void dgvResultados_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridViewRow row = this.dgvResultados.SelectedRows[0];
			Usuarios usuario = new Usuarios();
			Usuario.ID = Int32.Parse(row.Cells[0].Value.ToString());
			Usuario.nombre = row.Cells[1].Value.ToString();
			Usuario.Cedula = row.Cells[2].Value.ToString();
			Usuario.NumCarnet = Int32.Parse(row.Cells[3].Value.ToString());
			Usuario.TipoUsuario = row.Cells[4].Value.ToString();
			Usuario.TipoPersona = row.Cells[5].Value.ToString();
			Usuario.Estado= row.Cells[6].Value.ToString();
			//Usuario.Renta_Dev = row.Cells[7].Value.ToString();
			FrmMantUsuario fed = new FrmMantUsuario();
			fed.Usuario = Usuario;
			fed.Show();
		}
	}
}
