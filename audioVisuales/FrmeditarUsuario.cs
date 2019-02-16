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
	public partial class FrmeditarUsuario : Form
	{
		private AudiovisualesDBEntities1 entities = new AudiovisualesDBEntities1();
		public Usuarios Usuario { get; set; }
		public FrmeditarUsuario()
		{
			InitializeComponent();
		}

		private void FrmeditarUsuario_Load(object sender, EventArgs e)
		{
			if (Usuario != null)
			{
				txtID.Text = Usuario.ID.ToString();
				txtNomUser.Text = Usuario.nombre;
				txtCedulaUser.Text = Usuario.NumCarnet.ToString();
				txtCarnet.Text = Usuario.NumCarnet.ToString();
				cbxTipoUsuario.Text = Usuario.TipoUsuario.ToString();
				cbxTipoPersona.Text = Usuario.TipoPersona.ToString();
				cbxEstado.Text = Usuario.Estado.ToString();
			}
		}

		private void cmdEliminar_Click(object sender, EventArgs e)
		{
			try
			{

				Usuarios Usuario = entities.Usuarios.Find(Int32.Parse(txtID.Text));
				if (Usuario != null)
				{
					entities.Usuarios.Remove(Usuario);
					entities.SaveChanges();
					MessageBox.Show("Usuario eliminada con exito");
				}
				else
					MessageBox.Show("Usuario no existente");
				this.Close();
			}
			catch (Exception)
			{
				MessageBox.Show("Ha ocurrido un error");

			}
		}

		private void cmdGuardar_Click(object sender, EventArgs e)
		{
			entities.Usuarios.Add(new Usuarios
			{
				ID = int.Parse(txtID.Text),
				nombre = txtNomUser.Text,
				Cedula = txtCedulaUser.Text,
				NumCarnet = int.Parse(txtCarnet.Text),
				TipoUsuario = cbxTipoUsuario.Text,
				TipoPersona = cbxTipoPersona.Text,
				Estado = cbxEstado.Text
			}); entities.SaveChanges();
			MessageBox.Show("Datos guardados con exito"); this.Close();
		}
	}
}
