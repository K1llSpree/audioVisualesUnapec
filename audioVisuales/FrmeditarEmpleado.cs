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
	public partial class FrmeditarEmpleado : Form
	{
		public Empleados Empleado { get; set; }
		private AudiovisualesDBEntities1 entities = new AudiovisualesDBEntities1();
		public FrmeditarEmpleado()
		{
			InitializeComponent();
		}

		private void FrmeditarEmpleado_Load(object sender, EventArgs e)
		{
			if (Empleado != null)
			{
				txtID.Text = Empleado.ID.ToString();
				txtNombre.Text = Empleado.Nombre;
				cbxTanda.Text = Empleado.Tanda_Labor;
				DtFechaIngreso.Text = Empleado.Fecha_Ingreso.ToString();
				cbxEstado.Text = Empleado.Estado;
			}
		}

		private void cmdGuardar_Click(object sender, EventArgs e)
		{

			entities.Empleados.Add(new Empleados
			{
				ID = int.Parse(txtID.Text),
				Nombre = txtNombre.Text,
				Cedula = txtCedula.Text,
				Tanda_Labor = cbxTanda.Text,
				Fecha_Ingreso= DtFechaIngreso.Value,
				Estado = cbxEstado.Text
			}); entities.SaveChanges();
			MessageBox.Show("Datos guardados con exito"); this.Close();
			FrmMantEmpleado frm = new FrmMantEmpleado();
			frm.Refresh();
		}

		private void cmdEliminar_Click(object sender, EventArgs e)
		{
			try
			{

				Empleados Empleado = entities.Empleados.Find(Int32.Parse(txtID.Text));
				if (Empleado != null)
				{
					entities.Empleados.Remove(Empleado);
					entities.SaveChanges();
					MessageBox.Show("Empleado eliminado con exito");
				}
				else
					MessageBox.Show("Empleado no existente");
				this.Close();
				FrmMantEmpleado frm = new FrmMantEmpleado();
				frm.Refresh();
			}
			catch (Exception)
			{
				MessageBox.Show("Ha ocurrido un error");

			}
		}
	}
}
