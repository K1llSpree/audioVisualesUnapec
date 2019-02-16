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
	public partial class editarTipoEquipo : Form
	{
		public Tipos_Equipos tipoEquipo { get; set; }
		private AudiovisualesDBEntities1 entities = new AudiovisualesDBEntities1();
		public editarTipoEquipo()
		{
			InitializeComponent();
		}

		private void cmdGuardar_Click(object sender, EventArgs e)
		{
			entities.Tipos_Equipos.Add(new Tipos_Equipos
			{

				ID = int.Parse(txtID.Text),
				Descripcion = txtDescripcion.Text,
				Estado = cbxEstado.Text

			});
			entities.SaveChanges();
			MessageBox.Show("Datos Guardados con exito");
			this.Close();
		}

		private void editarTipoEquipo_Load(object sender, EventArgs e)
		{
			if (tipoEquipo != null)
			{
				txtID.Text = tipoEquipo.ID.ToString();
				txtDescripcion.Text = tipoEquipo.Descripcion;
				cbxEstado.Text = tipoEquipo.Estado;

			}
		}

		private void cmdEliminar_Click(object sender, EventArgs e)
		{
			Tipos_Equipos tipoEqui = entities.Tipos_Equipos.Find(Int32.Parse(txtID.Text));
			if (tipoEqui != null)
			{
				entities.Tipos_Equipos.Remove(tipoEqui);
				entities.SaveChanges();
				MessageBox.Show("Tipo de equipo eliminado con exito");
			}
			else
				MessageBox.Show("Tipo de equipo no existente");
			this.Close();
			
		}
	}
}
