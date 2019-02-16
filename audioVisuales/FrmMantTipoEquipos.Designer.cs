namespace audioVisuales
{
	partial class FrmMantTipoEquipos
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
			this.dgvTipoEquipo = new System.Windows.Forms.DataGridView();
			this.panel1 = new System.Windows.Forms.Panel();
			this.cmdAgregar = new System.Windows.Forms.Button();
			this.cmdBuscar = new System.Windows.Forms.Button();
			this.txtBuscar = new System.Windows.Forms.TextBox();
			this.cbxCriterio = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvTipoEquipo)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvTipoEquipo
			// 
			this.dgvTipoEquipo.AllowUserToAddRows = false;
			this.dgvTipoEquipo.AllowUserToDeleteRows = false;
			this.dgvTipoEquipo.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.dgvTipoEquipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvTipoEquipo.Location = new System.Drawing.Point(12, 76);
			this.dgvTipoEquipo.Name = "dgvTipoEquipo";
			this.dgvTipoEquipo.ReadOnly = true;
			this.dgvTipoEquipo.RowTemplate.Height = 24;
			this.dgvTipoEquipo.Size = new System.Drawing.Size(499, 362);
			this.dgvTipoEquipo.TabIndex = 3;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.cmdAgregar);
			this.panel1.Controls.Add(this.cmdBuscar);
			this.panel1.Controls.Add(this.txtBuscar);
			this.panel1.Controls.Add(this.cbxCriterio);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(506, 52);
			this.panel1.TabIndex = 4;
			this.panel1.Tag = "Buscar ";
			// 
			// cmdAgregar
			// 
			this.cmdAgregar.BackColor = System.Drawing.Color.LimeGreen;
			this.cmdAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdAgregar.Location = new System.Drawing.Point(419, 1);
			this.cmdAgregar.Name = "cmdAgregar";
			this.cmdAgregar.Size = new System.Drawing.Size(84, 52);
			this.cmdAgregar.TabIndex = 3;
			this.cmdAgregar.Text = "Agregar";
			this.cmdAgregar.UseVisualStyleBackColor = false;
			this.cmdAgregar.Click += new System.EventHandler(this.cmdAgregar_Click);
			// 
			// cmdBuscar
			// 
			this.cmdBuscar.BackColor = System.Drawing.SystemColors.HotTrack;
			this.cmdBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdBuscar.Location = new System.Drawing.Point(347, 0);
			this.cmdBuscar.Name = "cmdBuscar";
			this.cmdBuscar.Size = new System.Drawing.Size(82, 52);
			this.cmdBuscar.TabIndex = 2;
			this.cmdBuscar.Text = "Buscar";
			this.cmdBuscar.UseVisualStyleBackColor = false;
			this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
			// 
			// txtBuscar
			// 
			this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtBuscar.Location = new System.Drawing.Point(131, 14);
			this.txtBuscar.Name = "txtBuscar";
			this.txtBuscar.Size = new System.Drawing.Size(210, 22);
			this.txtBuscar.TabIndex = 1;
			this.txtBuscar.Tag = "";
			this.txtBuscar.Text = "Buscar";
			// 
			// cbxCriterio
			// 
			this.cbxCriterio.FormattingEnabled = true;
			this.cbxCriterio.Items.AddRange(new object[] {
            "ID",
            "Descripcion",
            "Estado"});
			this.cbxCriterio.Location = new System.Drawing.Point(4, 14);
			this.cbxCriterio.Name = "cbxCriterio";
			this.cbxCriterio.Size = new System.Drawing.Size(121, 24);
			this.cbxCriterio.TabIndex = 0;
			this.cbxCriterio.Text = "Criteros";
			// 
			// FrmMantTipoEquipos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(537, 450);
			this.Controls.Add(this.dgvTipoEquipo);
			this.Controls.Add(this.panel1);
			this.Name = "FrmMantTipoEquipos";
			this.Text = "FrmMantTipoEquipos";
			this.Load += new System.EventHandler(this.FrmMantTipoEquipos_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvTipoEquipo)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvTipoEquipo;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button cmdAgregar;
		private System.Windows.Forms.Button cmdBuscar;
		private System.Windows.Forms.TextBox txtBuscar;
		private System.Windows.Forms.ComboBox cbxCriterio;
	}
}