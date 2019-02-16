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
	public partial class CrModelo : Form
	{
		public Modelos Modelo { get; set; }
		private AudiovisualesDBEntities1 entities = new AudiovisualesDBEntities1();
		public CrModelo()
		{
			InitializeComponent();
		}

		private void txtID_TextChanged(object sender, EventArgs e)
		{

		}

		private void CrModelo_Load(object sender, EventArgs e)
		{
			cbxEstado.SelectedIndex = 0;
			if (Modelo != null)
			{
				txtID.Text = Modelo.ID.ToString();
				cbxIDMarca.Text = Modelo.IDMARCA.ToString();
				TxtDescripcion.Text = Modelo.Descripcion.ToString();
				cbxEstado.Text = Modelo.Estado.ToString();
				
			}

		}
		private void add()
		{
			entities.Modelos.Add(new Modelos
			{
				ID = Int32.Parse(txtID.Text),
				Estado = cbxEstado.Text,
				IDMARCA = Int32.Parse(cbxIDMarca.Text),
				Descripcion= TxtDescripcion.Text,
			
			});
			entities.SaveChanges();this.Close();
		}

		private void cmdGuardar_Click(object sender, EventArgs e)
		{
			try
			{
				add();
				MessageBox.Show("Modelo guardado con exito");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Ha ocurrido un error " +""+ex.Message+"");
			}
			
		}

		private void cmdEliminar_Click(object sender, EventArgs e)
		{
			try
			{
				Modelos Modelo = entities.Modelos.Find(int.Parse(txtID.Text));
				if (Modelo != null)
				{
					entities.Modelos.Remove(Modelo);
					entities.SaveChanges();
					MessageBox.Show("Modelo eliminado con exito");
				}
				else
					MessageBox.Show("Modelo no existe");
			}
			catch (Exception xe)
			{
				MessageBox.Show("Introduzca los datos solicitados");
			}
			this.Close();
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}


	}
	}

