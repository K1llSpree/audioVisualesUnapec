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
	public partial class Menú : Form
	{
		public Menú()
		{
			InitializeComponent();
		}

		private void tiposDeEquiposToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FrmMantTipoEquipos frm = new FrmMantTipoEquipos();
			frm.ShowDialog();
		}

		private void tiposDeConexiónToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FrmMantTecConexion frm = new FrmMantTecConexion();
			frm.ShowDialog();
		}

		private void modelosToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FrmMantModelo frm = new FrmMantModelo();
			frm.ShowDialog();
		}

		private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FrmGestionMarca frm = new FrmGestionMarca();
			frm.ShowDialog();
		}

		private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FrmMantUsuario frm = new FrmMantUsuario();
			frm.ShowDialog();
		}

		private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FrmMantEmpleado frm = new FrmMantEmpleado();
			frm.ShowDialog();
		}

		private void equipoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FrmMantEquipos frm = new FrmMantEquipos();
			frm.ShowDialog();
		}
	}
}
