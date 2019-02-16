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
	public partial class FrmEditarMarca : Form
	{
		public Marcas marcas { get; set; }
		private AudiovisualesDBEntities1 entities = new AudiovisualesDBEntities1();
		public FrmEditarMarca()
		{
			InitializeComponent();
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void cmdGuardar_Click(object sender, EventArgs e)
		{
			entities.Marcas.Add(new Marcas
			{
				ID = int.Parse(txtID.Text),
				Descripcion = txtDescripcion.Text,
				Estado = cbxEstado.Text
			}); entities.SaveChanges();
			MessageBox.Show("Datos guardados con exito"); this.Close();
		}

		private void cmdEliminar_Click(object sender, EventArgs e)
		{
			try
			{

				Marcas marcas = entities.Marcas.Find(Int32.Parse(txtID.Text));
				if (marcas != null)
				{
					entities.Marcas.Remove(marcas);
					entities.SaveChanges();
					MessageBox.Show("Marca eliminada con exito");
				}
				else
					MessageBox.Show("Marca no existente");
				this.Close();
			}
			catch (Exception)
			{
				MessageBox.Show("Ha ocurrido un error");

			}
		}

		private void FrmEditarMarca_Load(object sender, EventArgs e)
		{
			if (marcas != null)
			{
				txtID.Text = marcas.ID.ToString();
				txtDescripcion.Text = marcas.Descripcion;
				cbxEstado.Text = marcas.Estado;
			}
		}
	}
}
