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
	public partial class FrmMantModelo : Form
	{
			private AudiovisualesDBEntities1 entities = new AudiovisualesDBEntities1();
			public Modelos Modelo { get; set; }
		
		public FrmMantModelo()
		{
			InitializeComponent();

		}
		private void FrmMantModelo_Activated(object sender, EventArgs e)
		{
			consultarModelo(); 

		}
		private void FrmMantModelo_Load(object sender, EventArgs e)
		{
			consultarModelo();

		}
		private void consultarModelo()
		{
			dgvResultados.DataSource = entities.Modelos.ToList();
		}
		private void consultarPorCriterio()
		{
			var Modelo = from em in entities.Modelos
							where (em.ID.ToString().StartsWith(txtBuscar.Text) ||
								   em.IDMARCA.ToString().StartsWith(txtBuscar.Text) ||
								   em.Descripcion.ToString().StartsWith(txtBuscar.Text) ||
								   em.Estado.ToString().StartsWith(txtBuscar.Text)
								  )
							select em;
			dgvResultados.DataSource = Modelo.ToList();
		}

		private void dgvResultados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				DataGridViewRow row = this.dgvResultados.SelectedRows[0];
				Modelos Modelo = new Modelos();
				Modelo.ID = Int32.Parse(row.Cells[0].Value.ToString());
				Modelo.IDMARCA = Int32.Parse(row.Cells[1].Value.ToString());
				Modelo.Descripcion = row.Cells[2].Value.ToString();
				Modelo.Estado = (row.Cells[3].Value.ToString());
				FrmMantModelo fed = new FrmMantModelo();
				fed.Modelo = Modelo;
				fed.Show();
				dgvResultados.Refresh();

			}
			catch (Exception)
			{
				MessageBox.Show("No existen funciones de doble click");
			}
			
		}

		private void cmdBuscar_Click(object sender, EventArgs e)
		{
			consultarPorCriterio();
		}

		private void cmdAgregar_Click(object sender, EventArgs e)
		{
			CrModelo cr = new CrModelo();
			cr.ShowDialog();
		}


	}
}
