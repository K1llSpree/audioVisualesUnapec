namespace audioVisuales
{
	partial class FrmeditarEquipos
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
			this.cmdEliminar = new System.Windows.Forms.Button();
			this.cmdGuardar = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.cbxEstado = new System.Windows.Forms.ComboBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txtID = new System.Windows.Forms.TextBox();
			this.cbxTipoEquipo = new System.Windows.Forms.ComboBox();
			this.txtServiceTag = new System.Windows.Forms.TextBox();
			this.txtSerie = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtDescripcion = new System.Windows.Forms.TextBox();
			this.cbxMarca = new System.Windows.Forms.ComboBox();
			this.cbxModelo = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cbxTecId = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// cmdEliminar
			// 
			this.cmdEliminar.BackColor = System.Drawing.Color.Red;
			this.cmdEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdEliminar.Location = new System.Drawing.Point(438, 208);
			this.cmdEliminar.Name = "cmdEliminar";
			this.cmdEliminar.Size = new System.Drawing.Size(107, 149);
			this.cmdEliminar.TabIndex = 25;
			this.cmdEliminar.Text = "Eliminar";
			this.cmdEliminar.UseVisualStyleBackColor = false;
			this.cmdEliminar.Click += new System.EventHandler(this.cmdEliminar_Click);
			// 
			// cmdGuardar
			// 
			this.cmdGuardar.BackColor = System.Drawing.Color.Lime;
			this.cmdGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdGuardar.Location = new System.Drawing.Point(438, 49);
			this.cmdGuardar.Name = "cmdGuardar";
			this.cmdGuardar.Size = new System.Drawing.Size(107, 153);
			this.cmdGuardar.TabIndex = 24;
			this.cmdGuardar.Text = "Guardar";
			this.cmdGuardar.UseVisualStyleBackColor = false;
			this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.cbxEstado);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.txtID);
			this.panel1.Controls.Add(this.cbxTipoEquipo);
			this.panel1.Controls.Add(this.txtServiceTag);
			this.panel1.Controls.Add(this.txtSerie);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.txtDescripcion);
			this.panel1.Controls.Add(this.cbxMarca);
			this.panel1.Controls.Add(this.cbxModelo);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.cbxTecId);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Location = new System.Drawing.Point(25, 27);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(407, 386);
			this.panel1.TabIndex = 23;
			// 
			// cbxEstado
			// 
			this.cbxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxEstado.FormattingEnabled = true;
			this.cbxEstado.Items.AddRange(new object[] {
            "Activo",
            "Desocupado"});
			this.cbxEstado.Location = new System.Drawing.Point(175, 332);
			this.cbxEstado.Name = "cbxEstado";
			this.cbxEstado.Size = new System.Drawing.Size(229, 24);
			this.cbxEstado.TabIndex = 23;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(8, 339);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(52, 17);
			this.label9.TabIndex = 22;
			this.label9.Text = "Estado";
			// 
			// txtID
			// 
			this.txtID.Location = new System.Drawing.Point(175, 17);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(229, 22);
			this.txtID.TabIndex = 20;
			// 
			// cbxTipoEquipo
			// 
			this.cbxTipoEquipo.FormattingEnabled = true;
			this.cbxTipoEquipo.Location = new System.Drawing.Point(175, 191);
			this.cbxTipoEquipo.Name = "cbxTipoEquipo";
			this.cbxTipoEquipo.Size = new System.Drawing.Size(229, 24);
			this.cbxTipoEquipo.TabIndex = 21;
			// 
			// txtServiceTag
			// 
			this.txtServiceTag.Location = new System.Drawing.Point(175, 161);
			this.txtServiceTag.Name = "txtServiceTag";
			this.txtServiceTag.Size = new System.Drawing.Size(229, 22);
			this.txtServiceTag.TabIndex = 20;
			// 
			// txtSerie
			// 
			this.txtSerie.Location = new System.Drawing.Point(175, 131);
			this.txtSerie.Name = "txtSerie";
			this.txtSerie.Size = new System.Drawing.Size(229, 22);
			this.txtSerie.TabIndex = 19;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(8, 198);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(103, 17);
			this.label8.TabIndex = 18;
			this.label8.Text = "Tipo de equipo";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(8, 166);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(84, 17);
			this.label7.TabIndex = 17;
			this.label7.Text = "Service Tag";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(8, 136);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(87, 17);
			this.label6.TabIndex = 16;
			this.label6.Text = "No. de Serie";
			// 
			// txtDescripcion
			// 
			this.txtDescripcion.Location = new System.Drawing.Point(175, 272);
			this.txtDescripcion.Multiline = true;
			this.txtDescripcion.Name = "txtDescripcion";
			this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtDescripcion.Size = new System.Drawing.Size(229, 40);
			this.txtDescripcion.TabIndex = 14;
			// 
			// cbxMarca
			// 
			this.cbxMarca.FormattingEnabled = true;
			this.cbxMarca.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
			this.cbxMarca.Location = new System.Drawing.Point(175, 54);
			this.cbxMarca.Name = "cbxMarca";
			this.cbxMarca.Size = new System.Drawing.Size(229, 24);
			this.cbxMarca.TabIndex = 13;
			// 
			// cbxModelo
			// 
			this.cbxModelo.FormattingEnabled = true;
			this.cbxModelo.Location = new System.Drawing.Point(175, 95);
			this.cbxModelo.Name = "cbxModelo";
			this.cbxModelo.Size = new System.Drawing.Size(229, 24);
			this.cbxModelo.TabIndex = 13;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(5, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(21, 17);
			this.label1.TabIndex = 5;
			this.label1.Text = "ID";
			// 
			// cbxTecId
			// 
			this.cbxTecId.FormattingEnabled = true;
			this.cbxTecId.Location = new System.Drawing.Point(175, 233);
			this.cbxTecId.Name = "cbxTecId";
			this.cbxTecId.Size = new System.Drawing.Size(229, 24);
			this.cbxTecId.TabIndex = 12;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(8, 61);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(47, 17);
			this.label2.TabIndex = 6;
			this.label2.Text = "Marca";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(8, 104);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(54, 17);
			this.label3.TabIndex = 7;
			this.label3.Text = "Modelo";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(5, 278);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(82, 17);
			this.label4.TabIndex = 8;
			this.label4.Text = "Descripcion";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(5, 240);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(140, 17);
			this.label5.TabIndex = 9;
			this.label5.Text = "Tecnologia Conexion";
			// 
			// FrmeditarEquipos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(560, 450);
			this.Controls.Add(this.cmdEliminar);
			this.Controls.Add(this.cmdGuardar);
			this.Controls.Add(this.panel1);
			this.Name = "FrmeditarEquipos";
			this.Text = "FrmeditarEquipos";
			this.Load += new System.EventHandler(this.FrmeditarEquipos_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button cmdEliminar;
		private System.Windows.Forms.Button cmdGuardar;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ComboBox cbxEstado;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.ComboBox cbxTipoEquipo;
		private System.Windows.Forms.TextBox txtServiceTag;
		private System.Windows.Forms.TextBox txtSerie;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtDescripcion;
		private System.Windows.Forms.ComboBox cbxMarca;
		private System.Windows.Forms.ComboBox cbxModelo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbxTecId;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
	}
}