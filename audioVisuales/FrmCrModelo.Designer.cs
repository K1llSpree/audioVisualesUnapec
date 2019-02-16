namespace audioVisuales
{
	partial class CrModelo
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
			this.cbxEstado = new System.Windows.Forms.ComboBox();
			this.TxtDescripcion = new System.Windows.Forms.RichTextBox();
			this.txtID = new System.Windows.Forms.TextBox();
			this.cbxIDMarca = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.cmdEliminar = new System.Windows.Forms.Button();
			this.cmdGuardar = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.cbxEstado);
			this.panel1.Controls.Add(this.TxtDescripcion);
			this.panel1.Controls.Add(this.txtID);
			this.panel1.Controls.Add(this.cbxIDMarca);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(418, 346);
			this.panel1.TabIndex = 21;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(46, 194);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(52, 17);
			this.label3.TabIndex = 18;
			this.label3.Text = "Estado";
			// 
			// cbxEstado
			// 
			this.cbxEstado.FormattingEnabled = true;
			this.cbxEstado.Items.AddRange(new object[] {
            "Activo",
            "Desocupado"});
			this.cbxEstado.Location = new System.Drawing.Point(15, 226);
			this.cbxEstado.Name = "cbxEstado";
			this.cbxEstado.Size = new System.Drawing.Size(121, 24);
			this.cbxEstado.TabIndex = 17;
			// 
			// TxtDescripcion
			// 
			this.TxtDescripcion.Location = new System.Drawing.Point(175, 92);
			this.TxtDescripcion.Name = "TxtDescripcion";
			this.TxtDescripcion.Size = new System.Drawing.Size(229, 228);
			this.TxtDescripcion.TabIndex = 16;
			this.TxtDescripcion.Text = "";
			// 
			// txtID
			// 
			this.txtID.Location = new System.Drawing.Point(87, 17);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(49, 22);
			this.txtID.TabIndex = 0;
			this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
			// 
			// cbxIDMarca
			// 
			this.cbxIDMarca.DisplayMember = "(ninguno) ";
			this.cbxIDMarca.FormattingEnabled = true;
			this.cbxIDMarca.Location = new System.Drawing.Point(175, 54);
			this.cbxIDMarca.Name = "cbxIDMarca";
			this.cbxIDMarca.Size = new System.Drawing.Size(229, 24);
			this.cbxIDMarca.TabIndex = 13;
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
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(8, 61);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(60, 17);
			this.label2.TabIndex = 6;
			this.label2.Text = "IDMarca";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(8, 117);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(82, 17);
			this.label4.TabIndex = 8;
			this.label4.Text = "Descripcion";
			// 
			// cmdEliminar
			// 
			this.cmdEliminar.BackColor = System.Drawing.Color.Red;
			this.cmdEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdEliminar.Location = new System.Drawing.Point(446, 188);
			this.cmdEliminar.Name = "cmdEliminar";
			this.cmdEliminar.Size = new System.Drawing.Size(107, 149);
			this.cmdEliminar.TabIndex = 28;
			this.cmdEliminar.Text = "Eliminar";
			this.cmdEliminar.UseVisualStyleBackColor = false;
			this.cmdEliminar.Click += new System.EventHandler(this.cmdEliminar_Click);
			// 
			// cmdGuardar
			// 
			this.cmdGuardar.BackColor = System.Drawing.Color.Lime;
			this.cmdGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdGuardar.Location = new System.Drawing.Point(446, 39);
			this.cmdGuardar.Name = "cmdGuardar";
			this.cmdGuardar.Size = new System.Drawing.Size(107, 153);
			this.cmdGuardar.TabIndex = 27;
			this.cmdGuardar.Text = "Guardar";
			this.cmdGuardar.UseVisualStyleBackColor = false;
			this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
			// 
			// CrModelo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(563, 383);
			this.Controls.Add(this.cmdEliminar);
			this.Controls.Add(this.cmdGuardar);
			this.Controls.Add(this.panel1);
			this.Name = "CrModelo";
			this.Text = "CrModelo";
			this.Load += new System.EventHandler(this.CrModelo_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.ComboBox cbxIDMarca;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.RichTextBox TxtDescripcion;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cbxEstado;
		private System.Windows.Forms.Button cmdEliminar;
		private System.Windows.Forms.Button cmdGuardar;
	}
}