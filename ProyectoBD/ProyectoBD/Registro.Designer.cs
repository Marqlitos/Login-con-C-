/*
 * Created by SharpDevelop.
 * User: marco
 * Date: 05/10/2026
 * Time: 09:25 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProyectoBD
{
	partial class Registro
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lblNombre;
		private System.Windows.Forms.Label lblApellidoPat;
		private System.Windows.Forms.Label lblUsuario;
		private System.Windows.Forms.Label lblEdad;
		private System.Windows.Forms.Label lblControl;
		private System.Windows.Forms.TextBox txtbNombre;
		private System.Windows.Forms.TextBox txtbApellidoP;
		private System.Windows.Forms.TextBox txtbUsuario;
		private System.Windows.Forms.Label lblContraseña;
		private System.Windows.Forms.TextBox txtbNControl;
		private System.Windows.Forms.NumericUpDown nudEdad;
		private System.Windows.Forms.TextBox txtbContraseña;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cmbArea;
		private System.Windows.Forms.Label lblCurp;
		private System.Windows.Forms.TextBox txtbRFC;
		private System.Windows.Forms.Label lblTelefono;
		private System.Windows.Forms.TextBox txtTelefono;
		private System.Windows.Forms.Button btnAtras;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.Label lblApellidoMat;
		private System.Windows.Forms.TextBox txtbApellidoM;
		private System.Windows.Forms.Label lblMail;
		private System.Windows.Forms.TextBox txtbEMail;
		private System.Windows.Forms.Label lblRol;
		private System.Windows.Forms.ComboBox cmbRol;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DateTimePicker dtpFecha;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.CheckBox cbActivo;
		private System.Windows.Forms.CheckBox cbInactivo;
		private System.Windows.Forms.TextBox txtbCurp;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblNombre = new System.Windows.Forms.Label();
			this.lblApellidoPat = new System.Windows.Forms.Label();
			this.lblUsuario = new System.Windows.Forms.Label();
			this.lblEdad = new System.Windows.Forms.Label();
			this.lblControl = new System.Windows.Forms.Label();
			this.txtbNombre = new System.Windows.Forms.TextBox();
			this.txtbApellidoP = new System.Windows.Forms.TextBox();
			this.txtbUsuario = new System.Windows.Forms.TextBox();
			this.lblContraseña = new System.Windows.Forms.Label();
			this.txtbNControl = new System.Windows.Forms.TextBox();
			this.nudEdad = new System.Windows.Forms.NumericUpDown();
			this.txtbContraseña = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cmbArea = new System.Windows.Forms.ComboBox();
			this.lblCurp = new System.Windows.Forms.Label();
			this.txtbRFC = new System.Windows.Forms.TextBox();
			this.lblTelefono = new System.Windows.Forms.Label();
			this.txtTelefono = new System.Windows.Forms.TextBox();
			this.btnAtras = new System.Windows.Forms.Button();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.lblApellidoMat = new System.Windows.Forms.Label();
			this.txtbApellidoM = new System.Windows.Forms.TextBox();
			this.lblMail = new System.Windows.Forms.Label();
			this.txtbEMail = new System.Windows.Forms.TextBox();
			this.lblRol = new System.Windows.Forms.Label();
			this.cmbRol = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.dtpFecha = new System.Windows.Forms.DateTimePicker();
			this.label3 = new System.Windows.Forms.Label();
			this.txtbCurp = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.cbActivo = new System.Windows.Forms.CheckBox();
			this.cbInactivo = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.nudEdad)).BeginInit();
			this.SuspendLayout();
			// 
			// lblNombre
			// 
			this.lblNombre.Location = new System.Drawing.Point(14, 13);
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.Size = new System.Drawing.Size(100, 23);
			this.lblNombre.TabIndex = 0;
			this.lblNombre.Text = "Nombre(s):";
			// 
			// lblApellidoPat
			// 
			this.lblApellidoPat.Location = new System.Drawing.Point(14, 41);
			this.lblApellidoPat.Name = "lblApellidoPat";
			this.lblApellidoPat.Size = new System.Drawing.Size(137, 23);
			this.lblApellidoPat.TabIndex = 1;
			this.lblApellidoPat.Text = "Apellido (Paterno):";
			// 
			// lblUsuario
			// 
			this.lblUsuario.Location = new System.Drawing.Point(13, 97);
			this.lblUsuario.Name = "lblUsuario";
			this.lblUsuario.Size = new System.Drawing.Size(128, 22);
			this.lblUsuario.TabIndex = 2;
			this.lblUsuario.Text = "Usuario / Apodo:";
			// 
			// lblEdad
			// 
			this.lblEdad.Location = new System.Drawing.Point(439, 14);
			this.lblEdad.Name = "lblEdad";
			this.lblEdad.Size = new System.Drawing.Size(54, 23);
			this.lblEdad.TabIndex = 3;
			this.lblEdad.Text = "Edad:";
			// 
			// lblControl
			// 
			this.lblControl.Location = new System.Drawing.Point(439, 45);
			this.lblControl.Name = "lblControl";
			this.lblControl.Size = new System.Drawing.Size(100, 23);
			this.lblControl.TabIndex = 4;
			this.lblControl.Text = "No. Control:";
			// 
			// txtbNombre
			// 
			this.txtbNombre.Location = new System.Drawing.Point(147, 13);
			this.txtbNombre.MaxLength = 50;
			this.txtbNombre.Name = "txtbNombre";
			this.txtbNombre.Size = new System.Drawing.Size(250, 22);
			this.txtbNombre.TabIndex = 5;
			// 
			// txtbApellidoP
			// 
			this.txtbApellidoP.Location = new System.Drawing.Point(147, 41);
			this.txtbApellidoP.MaxLength = 50;
			this.txtbApellidoP.Name = "txtbApellidoP";
			this.txtbApellidoP.Size = new System.Drawing.Size(250, 22);
			this.txtbApellidoP.TabIndex = 6;
			// 
			// txtbUsuario
			// 
			this.txtbUsuario.Location = new System.Drawing.Point(147, 97);
			this.txtbUsuario.MaxLength = 50;
			this.txtbUsuario.Name = "txtbUsuario";
			this.txtbUsuario.Size = new System.Drawing.Size(250, 22);
			this.txtbUsuario.TabIndex = 8;
			// 
			// lblContraseña
			// 
			this.lblContraseña.Location = new System.Drawing.Point(13, 125);
			this.lblContraseña.Name = "lblContraseña";
			this.lblContraseña.Size = new System.Drawing.Size(100, 23);
			this.lblContraseña.TabIndex = 9;
			this.lblContraseña.Text = "Contraseña:";
			// 
			// txtbNControl
			// 
			this.txtbNControl.Location = new System.Drawing.Point(604, 42);
			this.txtbNControl.MaxLength = 8;
			this.txtbNControl.Name = "txtbNControl";
			this.txtbNControl.Size = new System.Drawing.Size(200, 22);
			this.txtbNControl.TabIndex = 10;
			// 
			// nudEdad
			// 
			this.nudEdad.Location = new System.Drawing.Point(604, 14);
			this.nudEdad.Name = "nudEdad";
			this.nudEdad.Size = new System.Drawing.Size(200, 22);
			this.nudEdad.TabIndex = 11;
			// 
			// txtbContraseña
			// 
			this.txtbContraseña.Location = new System.Drawing.Point(147, 125);
			this.txtbContraseña.MaxLength = 50;
			this.txtbContraseña.Name = "txtbContraseña";
			this.txtbContraseña.PasswordChar = '#';
			this.txtbContraseña.Size = new System.Drawing.Size(250, 22);
			this.txtbContraseña.TabIndex = 12;
			this.txtbContraseña.UseSystemPasswordChar = true;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(439, 73);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 13;
			this.label1.Text = "Area:";
			// 
			// cmbArea
			// 
			this.cmbArea.FormattingEnabled = true;
			this.cmbArea.Items.AddRange(new object[] {
			"Programador",
			"Contador",
			"Secretaria",
			"Intendente",
			"Administrador",
			"Jefe de Area",
			"Recursos Humanos",
			"Atencion a cliente"});
			this.cmbArea.Location = new System.Drawing.Point(603, 70);
			this.cmbArea.Name = "cmbArea";
			this.cmbArea.Size = new System.Drawing.Size(201, 24);
			this.cmbArea.TabIndex = 14;
			// 
			// lblCurp
			// 
			this.lblCurp.Location = new System.Drawing.Point(13, 155);
			this.lblCurp.Name = "lblCurp";
			this.lblCurp.Size = new System.Drawing.Size(88, 23);
			this.lblCurp.TabIndex = 15;
			this.lblCurp.Text = "RFC:";
			// 
			// txtbRFC
			// 
			this.txtbRFC.Location = new System.Drawing.Point(147, 152);
			this.txtbRFC.MaxLength = 18;
			this.txtbRFC.Name = "txtbRFC";
			this.txtbRFC.Size = new System.Drawing.Size(249, 22);
			this.txtbRFC.TabIndex = 16;
			// 
			// lblTelefono
			// 
			this.lblTelefono.Location = new System.Drawing.Point(439, 103);
			this.lblTelefono.Name = "lblTelefono";
			this.lblTelefono.Size = new System.Drawing.Size(100, 23);
			this.lblTelefono.TabIndex = 17;
			this.lblTelefono.Text = "Telefono:";
			// 
			// txtTelefono
			// 
			this.txtTelefono.Location = new System.Drawing.Point(603, 100);
			this.txtTelefono.MaxLength = 10;
			this.txtTelefono.Name = "txtTelefono";
			this.txtTelefono.Size = new System.Drawing.Size(201, 22);
			this.txtTelefono.TabIndex = 18;
			this.txtTelefono.Tag = "";
			// 
			// btnAtras
			// 
			this.btnAtras.Location = new System.Drawing.Point(13, 248);
			this.btnAtras.Name = "btnAtras";
			this.btnAtras.Size = new System.Drawing.Size(75, 23);
			this.btnAtras.TabIndex = 19;
			this.btnAtras.Text = "Atrás";
			this.btnAtras.UseVisualStyleBackColor = true;
			this.btnAtras.Click += new System.EventHandler(this.BtnAtrasClick);
			// 
			// btnGuardar
			// 
			this.btnGuardar.Location = new System.Drawing.Point(729, 248);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(75, 23);
			this.btnGuardar.TabIndex = 20;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.BtnGuardarClick);
			// 
			// lblApellidoMat
			// 
			this.lblApellidoMat.Location = new System.Drawing.Point(14, 68);
			this.lblApellidoMat.Name = "lblApellidoMat";
			this.lblApellidoMat.Size = new System.Drawing.Size(137, 23);
			this.lblApellidoMat.TabIndex = 21;
			this.lblApellidoMat.Text = "Apellido (Materno):";
			// 
			// txtbApellidoM
			// 
			this.txtbApellidoM.Location = new System.Drawing.Point(148, 70);
			this.txtbApellidoM.Name = "txtbApellidoM";
			this.txtbApellidoM.Size = new System.Drawing.Size(249, 22);
			this.txtbApellidoM.TabIndex = 22;
			// 
			// lblMail
			// 
			this.lblMail.Location = new System.Drawing.Point(13, 182);
			this.lblMail.Name = "lblMail";
			this.lblMail.Size = new System.Drawing.Size(100, 23);
			this.lblMail.TabIndex = 23;
			this.lblMail.Text = "E-mail:";
			// 
			// txtbEMail
			// 
			this.txtbEMail.Location = new System.Drawing.Point(148, 181);
			this.txtbEMail.MaxLength = 100;
			this.txtbEMail.Name = "txtbEMail";
			this.txtbEMail.Size = new System.Drawing.Size(249, 22);
			this.txtbEMail.TabIndex = 24;
			// 
			// lblRol
			// 
			this.lblRol.Location = new System.Drawing.Point(439, 131);
			this.lblRol.Name = "lblRol";
			this.lblRol.Size = new System.Drawing.Size(100, 23);
			this.lblRol.TabIndex = 25;
			this.lblRol.Text = "Rol:";
			// 
			// cmbRol
			// 
			this.cmbRol.FormattingEnabled = true;
			this.cmbRol.Items.AddRange(new object[] {
			"Trabajador",
			"Administrador"});
			this.cmbRol.Location = new System.Drawing.Point(604, 128);
			this.cmbRol.Name = "cmbRol";
			this.cmbRol.Size = new System.Drawing.Size(200, 24);
			this.cmbRol.TabIndex = 26;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(439, 163);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(164, 23);
			this.label2.TabIndex = 27;
			this.label2.Text = "Fecha de Nacimiento:";
			// 
			// dtpFecha
			// 
			this.dtpFecha.Location = new System.Drawing.Point(604, 158);
			this.dtpFecha.Name = "dtpFecha";
			this.dtpFecha.Size = new System.Drawing.Size(200, 22);
			this.dtpFecha.TabIndex = 28;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(13, 209);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 29;
			this.label3.Text = "CURP:";
			// 
			// txtbCurp
			// 
			this.txtbCurp.Location = new System.Drawing.Point(147, 209);
			this.txtbCurp.MaxLength = 17;
			this.txtbCurp.Name = "txtbCurp";
			this.txtbCurp.Size = new System.Drawing.Size(249, 22);
			this.txtbCurp.TabIndex = 30;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(439, 190);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 31;
			this.label4.Text = "Estado:";
			// 
			// cbActivo
			// 
			this.cbActivo.Location = new System.Drawing.Point(603, 190);
			this.cbActivo.Name = "cbActivo";
			this.cbActivo.Size = new System.Drawing.Size(112, 24);
			this.cbActivo.TabIndex = 32;
			this.cbActivo.Text = "Activo";
			this.cbActivo.UseVisualStyleBackColor = true;
			// 
			// cbInactivo
			// 
			this.cbInactivo.Location = new System.Drawing.Point(721, 190);
			this.cbInactivo.Name = "cbInactivo";
			this.cbInactivo.Size = new System.Drawing.Size(101, 24);
			this.cbInactivo.TabIndex = 33;
			this.cbInactivo.Text = "Inactivo";
			this.cbInactivo.UseVisualStyleBackColor = true;
			// 
			// Registro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(816, 283);
			this.Controls.Add(this.cbInactivo);
			this.Controls.Add(this.cbActivo);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtbCurp);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.dtpFecha);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cmbRol);
			this.Controls.Add(this.lblRol);
			this.Controls.Add(this.txtbEMail);
			this.Controls.Add(this.lblMail);
			this.Controls.Add(this.txtbApellidoM);
			this.Controls.Add(this.lblApellidoMat);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.btnAtras);
			this.Controls.Add(this.txtTelefono);
			this.Controls.Add(this.lblTelefono);
			this.Controls.Add(this.txtbRFC);
			this.Controls.Add(this.lblCurp);
			this.Controls.Add(this.cmbArea);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtbContraseña);
			this.Controls.Add(this.nudEdad);
			this.Controls.Add(this.txtbNControl);
			this.Controls.Add(this.lblContraseña);
			this.Controls.Add(this.txtbUsuario);
			this.Controls.Add(this.txtbApellidoP);
			this.Controls.Add(this.txtbNombre);
			this.Controls.Add(this.lblControl);
			this.Controls.Add(this.lblEdad);
			this.Controls.Add(this.lblUsuario);
			this.Controls.Add(this.lblApellidoPat);
			this.Controls.Add(this.lblNombre);
			this.Name = "Registro";
			this.Text = "Registro";
			((System.ComponentModel.ISupportInitialize)(this.nudEdad)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
