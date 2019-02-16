namespace audioVisuales
{
	partial class FrmeditarUsuario
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
			this.txtNomUser = new System.Windows.Forms.TextBox();
			this.txtCarnet = new System.Windows.Forms.TextBox();
			this.txtCedulaUser = new System.Windows.Forms.TextBox();
			this.cbxTipoUsuario = new System.Windows.Forms.ComboBox();
			this.cbxTipoPersona = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtID = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.cmdEliminar = new System.Windows.Forms.Button();
			this.cmdGuardar = new System.Windows.Forms.Button();
			this.cbxEstado = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtNomUser
			// 
			this.txtNomUser.Location = new System.Drawing.Point(188, 81);
			this.txtNomUser.Name = "txtNomUser";
			this.txtNomUser.Size = new System.Drawing.Size(229, 22);
			this.txtNomUser.TabIndex = 37;
			// 
			// txtCarnet
			// 
			this.txtCarnet.Location = new System.Drawing.Point(188, 148);
			this.txtCarnet.Name = "txtCarnet";
			this.txtCarnet.Size = new System.Drawing.Size(229, 22);
			this.txtCarnet.TabIndex = 36;
			// 
			// txtCedulaUser
			// 
			this.txtCedulaUser.Location = new System.Drawing.Point(188, 116);
			this.txtCedulaUser.Name = "txtCedulaUser";
			this.txtCedulaUser.Size = new System.Drawing.Size(229, 22);
			this.txtCedulaUser.TabIndex = 35;
			// 
			// cbxTipoUsuario
			// 
			this.cbxTipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxTipoUsuario.FormattingEnabled = true;
			this.cbxTipoUsuario.Items.AddRange(new object[] {
            "Profesor",
            "Estudiante",
            "Empleado",
            "Otros"});
			this.cbxTipoUsuario.Location = new System.Drawing.Point(188, 181);
			this.cbxTipoUsuario.Name = "cbxTipoUsuario";
			this.cbxTipoUsuario.Size = new System.Drawing.Size(229, 24);
			this.cbxTipoUsuario.TabIndex = 34;
			// 
			// cbxTipoPersona
			// 
			this.cbxTipoPersona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxTipoPersona.FormattingEnabled = true;
			this.cbxTipoPersona.Items.AddRange(new object[] {
            "Fisica",
            "Juridica"});
			this.cbxTipoPersona.Location = new System.Drawing.Point(188, 215);
			this.cbxTipoPersona.Name = "cbxTipoPersona";
			this.cbxTipoPersona.Size = new System.Drawing.Size(229, 24);
			this.cbxTipoPersona.TabIndex = 33;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(21, 222);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(112, 17);
			this.label8.TabIndex = 32;
			this.label8.Text = "Tipo de persona";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(21, 190);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(109, 17);
			this.label7.TabIndex = 31;
			this.label7.Text = "Tipo de Usuario";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(21, 154);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(50, 17);
			this.label6.TabIndex = 30;
			this.label6.Text = "Carnet";
			// 
			// txtID
			// 
			this.txtID.Location = new System.Drawing.Point(84, 35);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(49, 22);
			this.txtID.TabIndex = 26;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(18, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(21, 17);
			this.label1.TabIndex = 27;
			this.label1.Text = "ID";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(21, 87);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 17);
			this.label2.TabIndex = 28;
			this.label2.Text = "Nombre";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(21, 122);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(52, 17);
			this.label3.TabIndex = 29;
			this.label3.Text = "Cedula";
			// 
			// cmdEliminar
			// 
			this.cmdEliminar.BackColor = System.Drawing.Color.Red;
			this.cmdEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdEliminar.Location = new System.Drawing.Point(434, 184);
			this.cmdEliminar.Name = "cmdEliminar";
			this.cmdEliminar.Size = new System.Drawing.Size(107, 149);
			this.cmdEliminar.TabIndex = 39;
			this.cmdEliminar.Text = "Eliminar";
			this.cmdEliminar.UseVisualStyleBackColor = false;
			this.cmdEliminar.Click += new System.EventHandler(this.cmdEliminar_Click);
			// 
			// cmdGuardar
			// 
			this.cmdGuardar.BackColor = System.Drawing.Color.Lime;
			this.cmdGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdGuardar.Location = new System.Drawing.Point(434, 35);
			this.cmdGuardar.Name = "cmdGuardar";
			this.cmdGuardar.Size = new System.Drawing.Size(107, 153);
			this.cmdGuardar.TabIndex = 38;
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
			this.cbxEstado.Location = new System.Drawing.Point(188, 252);
			this.cbxEstado.Name = "cbxEstado";
			this.cbxEstado.Size = new System.Drawing.Size(229, 24);
			this.cbxEstado.TabIndex = 41;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(27, 255);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(52, 17);
			this.label4.TabIndex = 40;
			this.label4.Text = "Estado";
			// 
			// FrmeditarUsuario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(551, 339);
			this.Controls.Add(this.cmdEliminar);
			this.Controls.Add(this.cmdGuardar);
			this.Controls.Add(this.cbxEstado);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtNomUser);
			this.Controls.Add(this.txtCarnet);
			this.Controls.Add(this.txtCedulaUser);
			this.Controls.Add(this.cbxTipoUsuario);
			this.Controls.Add(this.cbxTipoPersona);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtID);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label3);
			this.Name = "FrmeditarUsuario";
			this.Text = "FrmeditarUsuario";
			this.Load += new System.EventHandler(this.FrmeditarUsuario_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtNomUser;
		private System.Windows.Forms.TextBox txtCarnet;
		private System.Windows.Forms.TextBox txtCedulaUser;
		private System.Windows.Forms.ComboBox cbxTipoUsuario;
		private System.Windows.Forms.ComboBox cbxTipoPersona;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button cmdEliminar;
		private System.Windows.Forms.Button cmdGuardar;
		private System.Windows.Forms.ComboBox cbxEstado;
		private System.Windows.Forms.Label label4;
	}
}