namespace audioVisuales
{
	partial class FrmMantModelo
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.panel2 = new System.Windows.Forms.Panel();
			this.lbl2 = new System.Windows.Forms.Label();
			this.lbl1 = new System.Windows.Forms.Label();
			this.cbxCriterio = new System.Windows.Forms.ComboBox();
			this.txtBuscar = new System.Windows.Forms.TextBox();
			this.dgvResultados = new System.Windows.Forms.DataGridView();
			this.cmdAgregar = new System.Windows.Forms.Button();
			this.cmdBuscar = new System.Windows.Forms.Button();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.cmdAgregar);
			this.panel2.Controls.Add(this.cmdBuscar);
			this.panel2.Controls.Add(this.lbl2);
			this.panel2.Controls.Add(this.lbl1);
			this.panel2.Controls.Add(this.cbxCriterio);
			this.panel2.Controls.Add(this.txtBuscar);
			this.panel2.Location = new System.Drawing.Point(9, 12);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(776, 59);
			this.panel2.TabIndex = 8;
			// 
			// lbl2
			// 
			this.lbl2.AutoSize = true;
			this.lbl2.Location = new System.Drawing.Point(314, 10);
			this.lbl2.Name = "lbl2";
			this.lbl2.Size = new System.Drawing.Size(72, 17);
			this.lbl2.TabIndex = 5;
			this.lbl2.Text = "Busqueda";
			// 
			// lbl1
			// 
			this.lbl1.AutoSize = true;
			this.lbl1.Location = new System.Drawing.Point(13, 10);
			this.lbl1.Name = "lbl1";
			this.lbl1.Size = new System.Drawing.Size(53, 17);
			this.lbl1.TabIndex = 4;
			this.lbl1.Text = "Criterio";
			// 
			// cbxCriterio
			// 
			this.cbxCriterio.FormattingEnabled = true;
			this.cbxCriterio.Items.AddRange(new object[] {
            "ID",
            "ID Marca",
            "Descripción",
            "Estado"});
			this.cbxCriterio.Location = new System.Drawing.Point(146, 6);
			this.cbxCriterio.Name = "cbxCriterio";
			this.cbxCriterio.Size = new System.Drawing.Size(148, 24);
			this.cbxCriterio.TabIndex = 0;
			// 
			// txtBuscar
			// 
			this.txtBuscar.Location = new System.Drawing.Point(410, 6);
			this.txtBuscar.Name = "txtBuscar";
			this.txtBuscar.Size = new System.Drawing.Size(190, 22);
			this.txtBuscar.TabIndex = 1;
			// 
			// dgvResultados
			// 
			this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvResultados.Location = new System.Drawing.Point(15, 77);
			this.dgvResultados.Name = "dgvResultados";
			this.dgvResultados.RowTemplate.Height = 24;
			this.dgvResultados.Size = new System.Drawing.Size(770, 361);
			this.dgvResultados.TabIndex = 9;
			this.dgvResultados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResultados_CellDoubleClick);
			// 
			// cmdAgregar
			// 
			this.cmdAgregar.BackColor = System.Drawing.Color.LimeGreen;
			this.cmdAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdAgregar.Location = new System.Drawing.Point(695, 2);
			this.cmdAgregar.Name = "cmdAgregar";
			this.cmdAgregar.Size = new System.Drawing.Size(84, 52);
			this.cmdAgregar.TabIndex = 7;
			this.cmdAgregar.Text = "Agregar";
			this.cmdAgregar.UseVisualStyleBackColor = false;
			// 
			// cmdBuscar
			// 
			this.cmdBuscar.BackColor = System.Drawing.SystemColors.HotTrack;
			this.cmdBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdBuscar.Location = new System.Drawing.Point(601, 2);
			this.cmdBuscar.Name = "cmdBuscar";
			this.cmdBuscar.Size = new System.Drawing.Size(82, 52);
			this.cmdBuscar.TabIndex = 6;
			this.cmdBuscar.Text = "Buscar";
			this.cmdBuscar.UseVisualStyleBackColor = false;
			this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
			// 
			// FrmMantModelo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.dgvResultados);
			this.Controls.Add(this.panel2);
			this.Name = "FrmMantModelo";
			this.Text = "Mantenimiento de Modelos";
			this.Load += new System.EventHandler(this.FrmMantModelo_Load);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label lbl2;
		private System.Windows.Forms.Label lbl1;
		private System.Windows.Forms.ComboBox cbxCriterio;
		private System.Windows.Forms.TextBox txtBuscar;
		private System.Windows.Forms.DataGridView dgvResultados;
		private System.Windows.Forms.Button cmdAgregar;
		private System.Windows.Forms.Button cmdBuscar;
	}
}

