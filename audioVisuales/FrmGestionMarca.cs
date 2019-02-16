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
	public partial class FrmGestionMarca : Form
	{
		public Marcas marca { get; set; }
		private AudiovisualesDBEntities1 entities = new AudiovisualesDBEntities1();
		public FrmGestionMarca()
		{
			InitializeComponent();
		}

		private void cmdBuscar_Click(object sender, EventArgs e)
		{
			consultarPorCriterio();
		}
		private void consultarPorCriterio()
		{
			var marcas = from em in entities.Marcas
						 where (em.ID.ToString().StartsWith(txtBuscar.Text) ||
															 em.ID.ToString().StartsWith(txtBuscar.Text) ||
															 em.Descripcion.StartsWith(txtBuscar.Text)
															 )
						 select em;
			dgvMarcas.DataSource = marcas.ToList();
		}

		private void FrmGestionMarca_Load(object sender, EventArgs e)
		{
			consultarMarcas();

		}
		private void consultarMarcas() { dgvMarcas.DataSource = entities.Marcas.ToList(); }

		private void cmdAgregar_Click(object sender, EventArgs e)
		{
			FrmEditarMarca fed = new FrmEditarMarca();
			fed.ShowDialog();
		}

		private void FrmGestionMarca_Activated(object sender, EventArgs e)
		{
			FrmGestionMarca frm = new FrmGestionMarca();
			frm.Refresh();
			consultarMarcas();
			
		}
	}
}
