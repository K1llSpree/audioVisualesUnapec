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
	public partial class FrmCrTecConcs : Form
	{
		public Tecnologia_Conexion Conexion { get; set; }

		private AudiovisualesDBEntities1 entities = new AudiovisualesDBEntities1();
		public FrmCrTecConcs()
		{
			InitializeComponent();
		}

		private void txtID_TextChanged(object sender, EventArgs e)
		{

		}

		private void FrmCrTecConcs_Load(object sender, EventArgs e)
		{
			if ( Conexion != null)
			{
				txtID.Text = Conexion.ID.ToString();
				TxtDescripcion.Text = Conexion.Descripcion.ToString();
				cbxEstado.Text = Conexion.Estado.ToString();

			}

		}
		private void add()
		{
			entities.Tecnologia_Conexion.Add(new Tecnologia_Conexion
			{
				ID = Int32.Parse(txtID.Text),
				Estado = cbxEstado.Text,
				Descripcion = TxtDescripcion.Text,

			});
			entities.SaveChanges();
			this.Close();
		}




		private void cmdGuardar_Click(object sender, EventArgs e)
		{
			try
			{
				add();
				MessageBox.Show("Modelo guardado con exito");
			}
			catch (Exception)
			{
				MessageBox.Show("Introduzca los datos solicitados");
			}
			
		}

		private void cmdEliminar_Click(object sender, EventArgs e)
		{
			try
			{
				Tecnologia_Conexion Conexion = entities.Tecnologia_Conexion.Find(int.Parse(txtID.Text));
				if (Conexion != null)
				{
					entities.Tecnologia_Conexion.Remove(Conexion);
					entities.SaveChanges();
					MessageBox.Show("La conexión eliminado con exito");
				}
				else
					MessageBox.Show("conexión no existe");
				this.Close();
			}
			catch (Exception)
			{
				MessageBox.Show("Introduzca los datos solicitados");
			}

		}
	}
}