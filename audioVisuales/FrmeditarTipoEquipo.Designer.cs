namespace audioVisuales
{
	partial class editarTipoEquipo
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.txtDescripcion = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtID = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cmdEliminar = new System.Windows.Forms.Button();
			this.cmdGuardar = new System.Windows.Forms.Button();
			this.cbxEstado = new System.Windows.Forms.ComboBox();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.cbxEstado);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.txtDescripcion);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.txtID);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(12, 53);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(299, 298);
			this.panel1.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(25, 135);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(52, 17);
			this.label3.TabIndex = 4;
			this.label3.Text = "Estado";
			// 
			// txtDescripcion
			// 
			this.txtDescripcion.Location = new System.Drawing.Point(28, 99);
			this.txtDescripcion.Name = "txtDescripcion";
			this.txtDescripcion.Size = new System.Drawing.Size(248, 22);
			this.txtDescripcion.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(25, 78);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(82, 17);
			this.label2.TabIndex = 2;
			this.label2.Text = "Descripcion";
			// 
			// txtID
			// 
			this.txtID.Location = new System.Drawing.Point(28, 37);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(155, 22);
			this.txtID.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(25, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(21, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "ID";
			// 
			// cmdEliminar
			// 
			this.cmdEliminar.BackColor = System.Drawing.Color.Red;
			this.cmdEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdEliminar.Location = new System.Drawing.Point(317, 201);
			this.cmdEliminar.Name = "cmdEliminar";
			this.cmdEliminar.Size = new System.Drawing.Size(107, 149);
			this.cmdEliminar.TabIndex = 4;
			this.cmdEliminar.Text = "Eliminar";
			this.cmdEliminar.UseVisualStyleBackColor = false;
			this.cmdEliminar.Click += new System.EventHandler(this.cmdEliminar_Click);
			// 
			// cmdGuardar
			// 
			this.cmdGuardar.BackColor = System.Drawing.Color.Lime;
			this.cmdGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdGuardar.Location = new System.Drawing.Point(317, 52);
			this.cmdGuardar.Name = "cmdGuardar";
			this.cmdGuardar.Size = new System.Drawing.Size(107, 153);
			this.cmdGuardar.TabIndex = 3;
			this.cmdGuardar.Text = "Guardar";
			this.cmdGuardar.UseVisualStyleBackColor = false;
			this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
			// 
			// cbxEstado
			// 
			this.cbxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxEstado.FormattingEnabled = true;
			this.cbxEstado.Items.AddRange(new object[] {
            "Activo",
            "Desocupado"});
			this.cbxEstado.Location = new System.Drawing.Point(28, 168);
			this.cbxEstado.Name = "cbxEstado";
			this.cbxEstado.Size = new System.Drawing.Size(248, 24);
			this.cbxEstado.TabIndex = 5;
			// 
			// editarTipoEquipo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(441, 369);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.cmdEliminar);
			this.Controls.Add(this.cmdGuardar);
			this.Name = "editarTipoEquipo";
			this.Text = "editarTipoEquipo";
			this.Load += new System.EventHandler(this.editarTipoEquipo_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtDescripcion;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button cmdEliminar;
		private System.Windows.Forms.Button cmdGuardar;
		private System.Windows.Forms.ComboBox cbxEstado;
	}
}