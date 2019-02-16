namespace audioVisuales
{
	partial class FrmMantTecConexion
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.dgvResultados = new System.Windows.Forms.DataGridView();
			this.panel2 = new System.Windows.Forms.Panel();
			this.cbxCriterio = new System.Windows.Forms.ComboBox();
			this.lbl2 = new System.Windows.Forms.Label();
			this.lbl1 = new System.Windows.Forms.Label();
			this.txtBuscar = new System.Windows.Forms.TextBox();
			this.cmdAgregar = new System.Windows.Forms.Button();
			this.cmdBuscar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvResultados
			// 
			this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvResultados.Location = new System.Drawing.Point(18, 72);
			this.dgvResultados.Name = "dgvResultados";
			this.dgvResultados.RowTemplate.Height = 24;
			this.dgvResultados.Size = new System.Drawing.Size(770, 361);
			this.dgvResultados.TabIndex = 11;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.cmdAgregar);
			this.panel2.Controls.Add(this.cmdBuscar);
			this.panel2.Controls.Add(this.cbxCriterio);
			this.panel2.Controls.Add(this.lbl2);
			this.panel2.Controls.Add(this.lbl1);
			this.panel2.Controls.Add(this.txtBuscar);
			this.panel2.Location = new System.Drawing.Point(12, 12);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(776, 54);
			this.panel2.TabIndex = 10;
			// 
			// cbxCriterio
			// 
			this.cbxCriterio.FormattingEnabled = true;
			this.cbxCriterio.Items.AddRange(new object[] {
            "ID",
            "Estado",
            "Descripcion"});
			this.cbxCriterio.Location = new System.Drawing.Point(73, 5);
			this.cbxCriterio.Name = "cbxCriterio";
			this.cbxCriterio.Size = new System.Drawing.Size(235, 24);
			this.cbxCriterio.TabIndex = 6;
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
			// txtBuscar
			// 
			this.txtBuscar.Location = new System.Drawing.Point(410, 6);
			this.txtBuscar.Name = "txtBuscar";
			this.txtBuscar.Size = new System.Drawing.Size(190, 22);
			this.txtBuscar.TabIndex = 1;
			// 
			// cmdAgregar
			// 
			this.cmdAgregar.BackColor = System.Drawing.Color.LimeGreen;
			this.cmdAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdAgregar.Location = new System.Drawing.Point(694, 0);
			this.cmdAgregar.Name = "cmdAgregar";
			this.cmdAgregar.Size = new System.Drawing.Size(84, 52);
			this.cmdAgregar.TabIndex = 8;
			this.cmdAgregar.Text = "Agregar";
			this.cmdAgregar.UseVisualStyleBackColor = false;
			this.cmdAgregar.Click += new System.EventHandler(this.cmdAgregar_Click);
			// 
			// cmdBuscar
			// 
			this.cmdBuscar.BackColor = System.Drawing.SystemColors.HotTrack;
			this.cmdBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdBuscar.Location = new System.Drawing.Point(606, 0);
			this.cmdBuscar.Name = "cmdBuscar";
			this.cmdBuscar.Size = new System.Drawing.Size(82, 52);
			this.cmdBuscar.TabIndex = 7;
			this.cmdBuscar.Text = "Buscar";
			this.cmdBuscar.UseVisualStyleBackColor = false;
			this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
			// 
			// FrmMantTecConexion
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.dgvResultados);
			this.Controls.Add(this.panel2);
			this.Name = "FrmMantTecConexion";
			this.Text = "FrmMantTecConexion";
			this.Load += new System.EventHandler(this.FrmMantTecConexion_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvResultados;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label lbl2;
		private System.Windows.Forms.Label lbl1;
		private System.Windows.Forms.TextBox txtBuscar;
		private System.Windows.Forms.ComboBox cbxCriterio;
		private System.Windows.Forms.Button cmdAgregar;
		private System.Windows.Forms.Button cmdBuscar;
	}
}