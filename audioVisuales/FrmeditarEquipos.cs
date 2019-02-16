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
	public partial class FrmeditarEquipos : Form
	{
		public Equipos Equipo { get; set; }
		private AudiovisualesDBEntities1 entities = new AudiovisualesDBEntities1();
		public FrmeditarEquipos()
		{
			InitializeComponent();
		}

		private void cmdGuardar_Click(object sender, EventArgs e)
		{
			entities.Equipos.Add(new Equipos
			{
				ID = int.Parse(txtID.Text),
				Descripcion = txtDescripcion.Text,
				NSerial = txtSerie.Text,
				ServiceTag = txtServiceTag.Text,
				TipoEquipoID = int.Parse(cbxTipoEquipo.Text),
				MarcaID = int.Parse(cbxMarca.Text),
				ModeloID = int.Parse(cbxModelo.Text),
				TCID = int.Parse(cbxTecId.Text),
				Estado = cbxEstado.Text
			}); entities.SaveChanges();
			MessageBox.Show("Datos guardados con exito"); this.Close();
		}

		private void cmdEliminar_Click(object sender, EventArgs e)
		{

			Equipos Equipo = entities.Equipos.Find(Int32.Parse(txtID.Text));
			if (Equipo != null)
			{
				entities.Equipos.Remove(Equipo);
				entities.SaveChanges();
				MessageBox.Show("Marca eliminada con exito");
			}
			else
				MessageBox.Show("Marca no existente");
			this.Close();
		}

		private void FrmeditarEquipos_Load(object sender, EventArgs e)
		{
			if (Equipo != null)
			{
				txtID.Text = Equipo.ID.ToString();
				txtDescripcion.Text = Equipo.Descripcion;
				txtSerie.Text = Equipo.NSerial;
				txtServiceTag.Text = Equipo.ServiceTag;
				cbxTipoEquipo.Text = Equipo.TipoEquipoID.Value.ToString();
				cbxMarca.Text = Equipo.MarcaID.Value.ToString();
				cbxTecId.Text = Equipo.TCID.Value.ToString();
				cbxEstado.Text = Equipo.Estado;
			}
		}
	}
}
