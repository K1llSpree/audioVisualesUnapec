namespace audioVisuales
{
	partial class FrmeditarEmpleado
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
			this.label5 = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.DtFechaIngreso = new System.Windows.Forms.DateTimePicker();
			this.txtCedula = new System.Windows.Forms.TextBox();
			this.cbxTanda = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.cmdEliminar = new System.Windows.Forms.Button();
			this.cmdGuardar = new System.Windows.Forms.Button();
			this.cbxEstado = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtID = new System.Windows.Forms.TextBox();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.txtNombre);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.cbxEstado);
			this.panel1.Controls.Add(this.DtFechaIngreso);
			this.panel1.Controls.Add(this.txtCedula);
			this.panel1.Controls.Add(this.txtID);
			this.panel1.Controls.Add(this.cbxTanda);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Location = new System.Drawing.Point(12, 25);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(383, 318);
			this.panel1.TabIndex = 16;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 19);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(21, 17);
			this.label5.TabIndex = 16;
			this.label5.Text = "ID";
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(127, 62);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(231, 22);
			this.txtNombre.TabIndex = 0;
			// 
			// DtFechaIngreso
			// 
			this.DtFechaIngreso.Location = new System.Drawing.Point(127, 178);
			this.DtFechaIngreso.Name = "DtFechaIngreso";
			this.DtFechaIngreso.Size = new System.Drawing.Size(232, 22);
			this.DtFechaIngreso.TabIndex = 14;
			// 
			// txtCedula
			// 
			this.txtCedula.Location = new System.Drawing.Point(127, 100);
			this.txtCedula.Name = "txtCedula";
			this.txtCedula.Size = new System.Drawing.Size(232, 22);
			this.txtCedula.TabIndex = 1;
			// 
			// cbxTanda
			// 
			this.cbxTanda.AutoCompleteCustomSource.AddRange(new string[] {
            "Diurna",
            "Nocturna",
            "Mixta"});
			this.cbxTanda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxTanda.FormattingEnabled = true;
			this.cbxTanda.Items.AddRange(new object[] {
            "Diurna",
            "Nocturna",
            "Mixta"});
			this.cbxTanda.Location = new System.Drawing.Point(127, 138);
			this.cbxTanda.Name = "cbxTanda";
			this.cbxTanda.Size = new System.Drawing.Size(231, 24);
			this.cbxTanda.TabIndex = 13;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 64);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 17);
			this.label1.TabIndex = 5;
			this.label1.Text = "Nombre";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 103);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 17);
			this.label2.TabIndex = 6;
			this.label2.Text = "Cedula";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 146);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(49, 17);
			this.label3.TabIndex = 7;
			this.label3.Text = "Tanda";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(3, 183);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(118, 17);
			this.label4.TabIndex = 8;
			this.label4.Text = "Fecha de ingreso";
			// 
			// cmdEliminar
			// 
			this.cmdEliminar.BackColor = System.Drawing.Color.Red;
			this.cmdEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdEliminar.Location = new System.Drawing.Point(401, 183);
			this.cmdEliminar.Name = "cmdEliminar";
			this.cmdEliminar.Size = new System.Drawing.Size(107, 149);
			this.cmdEliminar.TabIndex = 19;
			this.cmdEliminar.Text = "Eliminar";
			this.cmdEliminar.UseVisualStyleBackColor = false;
			this.cmdEliminar.Click += new System.EventHandler(this.cmdEliminar_Click);
			// 
			// cmdGuardar
			// 
			this.cmdGuardar.BackColor = System.Drawing.Color.Lime;
			this.cmdGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdGuardar.Location = new System.Drawing.Point(401, 34);
			this.cmdGuardar.Name = "cmdGuardar";
			this.cmdGuardar.Size = new System.Drawing.Size(107, 153);
			this.cmdGuardar.TabIndex = 18;
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
			this.cbxEstado.Location = new System.Drawing.Point(127, 227);
			this.cbxEstado.Name = "cbxEstado";
			this.cbxEstado.Size = new System.Drawing.Size(234, 24);
			this.cbxEstado.TabIndex = 21;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 229);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(52, 17);
			this.label6.TabIndex = 20;
			this.label6.Text = "Estado";
			// 
			// txtID
			// 
			this.txtID.Location = new System.Drawing.Point(127, 20);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(231, 22);
			this.txtID.TabIndex = 17;
			// 
			// FrmeditarEmpleado
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(531, 368);
			this.Controls.Add(this.cmdEliminar);
			this.Controls.Add(this.cmdGuardar);
			this.Controls.Add(this.panel1);
			this.Name = "FrmeditarEmpleado";
			this.Text = "FrmeditarEmpleado";
			this.Load += new System.EventHandler(this.FrmeditarEmpleado_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.DateTimePicker DtFechaIngreso;
		private System.Windows.Forms.TextBox txtCedula;
		private System.Windows.Forms.ComboBox cbxTanda;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cbxEstado;
		private System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.Button cmdEliminar;
		private System.Windows.Forms.Button cmdGuardar;
	}
}